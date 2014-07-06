using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Text;
using System.Collections.Generic;
using SharpFair.Models;

namespace SharpFair.API
{

	public class BetfairNGAPI
	{
		enum RequestType
		{
			Login,
			Account,
			Sports
		}

		private class RequestHandler
		{
			public HttpWebRequest Request { get; set; }
			public string token { get; set; }

			public RequestHandler(RequestType type = RequestType.Sports, string token = null, string url = null) 
			{
				if (url == null) {
					switch (type) {
					case RequestType.Login: url = LoginUrl; break;
					case RequestType.Sports: url = SportsUrl; break;
					case RequestType.Account: url = AccountsUrl; break;
					default: throw new NotSupportedException();
					}
				}

				Request = (HttpWebRequest) WebRequest.Create(url);
				Request.Method = "POST";
				Request.Timeout = 10000;
				Request.Accept = "application/json";
				Request.ContentType = "application/json";
				Request.Headers.Add(HttpRequestHeader.AcceptCharset, "ISO-8859-1,utf-8");
				Request.Headers.Add(APPKEY_HEADER, AppKey);
				Request.KeepAlive = true;

				if (type != RequestType.Login) {
					this.token = token;
					Request.Headers.Add(SESSION_TOKEN_HEADER, token);
				}
			}

			public string GetResponseString(NGRequest req)
			{
				try {
					//var json = Newtonsoft.Json.JsonConvert.SerializeObject (req);
					//Console.WriteLine(json);
					var json = JsonHelper.ToJson(req);
					var sw = new StreamWriter (Request.GetRequestStream ());
					sw.Write (json);
					sw.Flush ();
					//sw.Close();

					return GetResponseString ();
				}
				catch (Exception ex) {
					Log.WriteException (ex);
					return null;
				}
			}

			public string GetResponseString()
			{
				try {
					Request.Timeout = 10000;
					var response = Request.GetResponse ();
					var sr = new StreamReader (response.GetResponseStream ());
					var data = sr.ReadToEnd ();
					//Console.WriteLine ("GetResponseString: {0}", data);
					return data;
				}
				catch (Exception ex) {
					Log.WriteException (ex);
					return null;
				}
			}

			public T GetResponseData<T>(NGRequest req)
			{
				//Console.WriteLine ("BFAPI: call: {0}", req.method);
				string json = GetResponseString (req);

				if (json == null) {
					return default(T);
				}

				//Console.WriteLine (json);

				try	{
					var data = JsonHelper.FromJson<NGResponse<T>>(json);
					return data.result;
				}
				//catch (JsonException jex) {
				//	Log.WriteException (jex);
				//	return default(T);
				//}
				catch (Exception ex) {
					Log.WriteException (ex);
					return default(T);
				}
			}

			public T GetResponseData<T>()
			{
				string json = GetResponseString ();
				try	{
					var data = JsonHelper.FromJson<NGResponse<T>>(json);
					return data.result;
				}
				catch (Exception ex) {
					Log.WriteException (ex);
					return default(T);
				}
			}
		}

		public string _token;

		public const string SportsUrl = "https://api.betfair.com/exchange/betting/json-rpc/v1";
		public const string AccountsUrl = "https://api.betfair.com/exchange/account/json-rpc/v1";
		public const string LoginUrl = "https://identitysso.betfair.com/api/certlogin";
		public static string AppKey = "YOUR_API_KEY";
		public string EndPoint { get; private set; }

		public const string APPKEY_HEADER = "X-Application";
		public const string SESSION_TOKEN_HEADER = "X-Authentication";

		public BetfairNGAPI ()
		{
		}

		private RequestHandler CreateRequestHandler(RequestType type = RequestType.Sports, string url = null)
		{
			return new RequestHandler (type, _token, url);
		}

		public string Login(string appKey, string username, string password)
		{
			try {
				AppKey = appKey;

				string url = string.Format("https://identitysso.betfair.com/api/login?username={1}&password={2}&url=https://www.betfair.com/", 
					AppKey,
					username, 
					password);

				var req = CreateRequestHandler(RequestType.Login, url);

				//var result = req.GetResponseData<NGLoginResponse>();
				var json = req.GetResponseString();
				//var result = Newtonsoft.Json.JsonConvert.DeserializeObject<NGLoginResponse> (json);
				var result = JsonHelper.FromJson<NGLoginResponse>(json);


				if (string.Compare(result.status, InstructionReportStatus.SUCCESS, true) != 0) {
					return null;
				}

				_token = result.token;
			}
			catch (Exception e) {
				Console.WriteLine("\nException Caught!");
				Console.WriteLine("Message :{0} ", e.Message);
				Log.WriteException (e);
				return null;
			}

			return _token;
		}

		public bool IsLoggedIn
		{
			get {
				return _token != null;
			}
		}

		public void KeepAlive(string token, string appKey = "")
		{
			string url = " https://identitysso.betfair.com/api/keepAlive";
			WebRequest request = null;
			WebResponse response = null;
			//string strResponseStatus = "";

			try {
				request = WebRequest.Create(new Uri(url));
				request.Method = "POST";
				request.ContentType = "application/json-rpc";
				request.Headers.Add(HttpRequestHeader.AcceptCharset, "ISO-8859-1,utf-8");
				request.Headers.Add("X-Authentication", token);

				if (!string.IsNullOrEmpty(AppKey)) {
					request.Headers.Add("X-Application", appKey);
				}

				response = request.GetResponse();
				var sr = new StreamReader (response.GetResponseStream());
				sr.ReadToEnd();
				//strResponseStatus = "Status is " + ((HttpWebResponse)response).StatusDescription;
			} catch (Exception ex) {
				Log.WriteException (ex);
				//Interaction.MsgBox("CreateRequest Error" + Constants.vbCrLf + ex.Message);
			}

			//Interaction.MsgBox(strResponseStatus);
			response.Close();
		}

		// {"jsonrpc": "2.0", "method": "SportsAPING/v1.0/listEventTypes", "params": {"filter":{}}, "id": 1}
		public List<NGEventTypeResult> ListEventsTypes()
		{
			var handler = CreateRequestHandler ();
			var req = CreateSportRequest (new NGParameters (), MethodNames.ListEventTypes);
			req.parameters.filter = new NGMarketFilter ();
			var data = handler.GetResponseData<List<NGEventTypeResult>> (req);
			return data;
		}

		// MarketFilter filter ,String locale
		public List<NGMarketTypeResult> ListMarketTypes(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListMarketTypes);
			return CreateRequestHandler ().GetResponseData<List<NGMarketTypeResult>> (req);
		}

		// MarketFilter filter ,String locale
		public List<NGTimeRangeResult> ListTimeRanges(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListTimeRanges);
			return CreateRequestHandler ().GetResponseData<List<NGTimeRangeResult>> (req);
		}

		// MarketFilter filter ,String locale
		public List<NGVenueResult> ListVenues(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListVenues);
			return CreateRequestHandler ().GetResponseData<List<NGVenueResult>> (req);
		}

		public List<NGEventResult> ListEvents(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListEvents);
			return CreateRequestHandler().GetResponseData<List<NGEventResult>> (req);
		}

		public List<NGCompetitionResult> ListCompetitions(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListCompetitions);
			return CreateRequestHandler().GetResponseData<List<NGCompetitionResult>> (req);
		}

		public List<NGCountryCodeResult> ListCountries(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListCountries);
			return CreateRequestHandler ().GetResponseData<List<NGCountryCodeResult>> (req);
		}

		// [{"jsonrpc": "2.0", "method": "SportsAPING/v1.0/listMarketCatalogue", "params": {"filter":{"marketStartTime":{"from":"2014-03-25T12:15:00Z","to":"2014-03-25T18:00:00Z"}},"maxResults":"1"}, "id": 1}]
		public List<NGMarketCatalogue> ListMarketCatalogue(NGParameters args)
		{
			var handler = CreateRequestHandler ();

			var req = CreateSportRequest (args, MethodNames.ListMarketCatalogue);

			var data = handler.GetResponseData<List<NGMarketCatalogue>> (req);
			return data;
		}

		public List<NGMarketProfitAndLoss> ListMarketProfitAndLoss(NGParameters args)
		{
			var req = CreateSportRequest (args, MethodNames.ListMarketProfitAndLoss);
			return CreateRequestHandler ().GetResponseData<List<NGMarketProfitAndLoss>> (req);
		}

		public List<NGMarketBook> ListMarketBook(NGParameters args)
		{
			var handler = CreateRequestHandler ();

			var req = CreateSportRequest (args, MethodNames.ListMarketBook);
			var data = handler.GetResponseData<List<NGMarketBook>> (req);
			return data;

		}

		public NGAccountFundsResponse GetAccountFunds()
		{
			var req = CreateAccountRequest (MethodNames.GetAccountFunds);
			var handler = CreateRequestHandler (RequestType.Account);
			return handler.GetResponseData<NGAccountFundsResponse> (req);
		}

		public NGAccountStatementReport GetAccountStatement(NGParameters args)
		{
			var req = CreateAccountRequest (MethodNames.GetAccountStatement);
			req.parameters = args;
			return CreateRequestHandler ().GetResponseData<NGAccountStatementReport> (req);
		}

		public List<NGCurrencyRate> ListCurrencyRates(string fromCurrency)
		{
			var req = CreateAccountRequest (MethodNames.ListCurrencyRates);
			req.parameters = new NGParameters { fromCurrency = fromCurrency };
			return CreateRequestHandler().GetResponseData<List<NGCurrencyRate>>(req);
		}

		public NGPlaceExecutionReport PlaceOrders(NGParameters args)
		{
			var handler = CreateRequestHandler ();
			var req = CreateSportRequest (args, MethodNames.PlaceOrders);
			return handler.GetResponseData<NGPlaceExecutionReport>(req);
		}

		public NGUpdateExecutionReport UpdateOrders(NGParameters args)
		{
			var handler = CreateRequestHandler ();
			var req = CreateSportRequest (args, MethodNames.UpdateOrders);
			return handler.GetResponseData<NGUpdateExecutionReport> (req);
		}
		
		public NGCurrentOrderSummaryReport ListCurrentOrders(NGParameters args)
		{
			var handler = CreateRequestHandler ();
			var req = CreateSportRequest (args, MethodNames.ListCurrentOrders);
			return handler.GetResponseData<NGCurrentOrderSummaryReport>(req);
		}

		public NGClearedOrderSummaryReport ListClearedOrders(NGParameters args)
		{
			var handler = CreateRequestHandler ();
			var req = CreateSportRequest (args, MethodNames.ListClearedOrders);
			return handler.GetResponseData<NGClearedOrderSummaryReport> (req);
		}

		private NGRequest CreateSportRequest(NGParameters args, string methodName)
		{
			var req = new NGRequest {
				id = 1,
				jsonrpc = "2.0",
				method = string.Format ("SportsAPING/v1.0/{0}", methodName),
				parameters = args
			};

			return req;
		}

		private NGRequest CreateAccountRequest(string methodName)
		{
			var req = new NGRequest {
				id = 1,
				jsonrpc = "2.0",
				method = string.Format ("AccountAPING/v1.0/{0}", methodName)
			};
			return req;
		}

		public decimal NearestIncrement(decimal price)
		{
			//throw new NotImplementedException();
			if (price < 2) {
				// .01
				return price;
			} else if (price >= 2 && price < 3) {
				//.02
				return NormalizePrice (price, 0.02M);
			} else if (price >= 3 && price < 4) {
				// .05
				return NormalizePrice (price, 0.05M);
			} else if (price >= 4 && price < 6) {
				// .1
				return NormalizePrice (price, 0.1M);
			} else if (price >= 6 && price < 10) {
				// .2
				return NormalizePrice (price, 0.2M);
			} else if (price >= 10 && price < 20) {
				// .5
				return NormalizePrice (price, 0.5M);
			} else if (price >= 20 && price < 30) {
				// 1
				return NormalizePrice (price, 1);
			} else if (price >= 30 && price < 50) {
				// 2
				return NormalizePrice (price, 2);
			} else if (price >= 50 && price < 100) {
				// 5
				return NormalizePrice (price, 5M);
			} else if (price > 100 && price < 1000) {
				// 10
				return NormalizePrice (price, 10M);
			}
			return price;
		}

		private decimal NormalizePrice(decimal price, decimal increment) 
		{
			decimal diff = price % increment;
			if (diff == 0M) {
				return price;
			}
			decimal newPrice = price + (increment - diff);
			return newPrice;
		}
	}
}

