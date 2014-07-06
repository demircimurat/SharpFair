using System;

namespace SharpFair
{
	public class JsonHelper
	{
		public static string ToJson(object o)
		{
			string	json = Newtonsoft.Json.JsonConvert.SerializeObject(o,
				Newtonsoft.Json.Formatting.None,
				new Newtonsoft.Json.JsonSerializerSettings
				{
					NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
				}
			);

			return json;
		}

		public static T FromJson<T>(string json)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
		}
	}
}
