using System;
using Newtonsoft.Json;

namespace SharpFair.Models
{
	public class NGRequest
	{
		public int id { get; set; }
		public string jsonrpc { get; set; }
		public string method { get; set; }

		[JsonProperty(PropertyName = "params", NullValueHandling = NullValueHandling.Ignore)]
		public NGParameters parameters { get; set; }
	}

	public class NGParameters
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGMarketFilter filter { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? maxResults { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string currencyCode { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string fromCurrency { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string locale { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] marketProjection { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGPriceProjection priceProjection { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string marketId { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object instructions { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string customerRef { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string orderProjection { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGTimeRange placedDateRange { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGTimeRange dateRange { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGTimeRange settledDateRange { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string orderBy { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string groupBy { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string sortDir { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? fromRecord { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? recordCount { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string betStatus { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] eventTypeIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] eventIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] marketIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] runnerIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] betIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? includeItemDescription { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string timeGranularity { get; set; }

		//[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		//public bool? inPlayOnly { get; set; }
	}

	public class NGMarketFilter
	{
		public string textQuery { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] exchangeIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] eventTypeIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] eventIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] competitionIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] marketIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] venues { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? bspOnly { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? turnInPlayEnabled { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? inPlayOnly { get; set; }

		// marketBettingTypes

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] marketCountries { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] marketTypeCodes { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NGTimeRange marketStartTime { get; set; }

		// withOrders
	}

	public class NGMarketCatalogue
	{
		public string marketId { get; set; }
		public string marketName { get; set; }
		public DateTime marketStartTime { get; set; }
		public NGMarketDescription description { get; set; }
		public decimal totalMatched { get; set; }
		public NGRunnerCatalog[] runners { get; set; }
		//public string EventType { get; set; }
		public NGEventType eventType { get; set; } 
		public NGCompetition competition { get; set; }
		[JsonProperty(PropertyName = "event")]
		public NGEvent _event { get; set; }
	}

	public class NGMarketBook
	{
		public string marketId { get; set; }
		public bool isMarketDataDelayed { get; set; }
		public string status { get; set; }
		public int betDelay { get; set; }
		public bool bspReconciled { get; set; }
		public bool complete { get; set; }
		public bool inplay { get; set; }
		public int numberOfWinners { get; set; }
		public int numberOfRunners { get; set; }
		public int numberOfActiveRunners { get; set; }
		public DateTime lastMatchTime { get; set; }
		public decimal totalMatched { get; set; }
		public decimal totalAvailable { get; set; }
		public bool crossMatching { get; set; }
		public bool runnersVoidable { get; set; }
		public long version { get; set; }
		public NGRunner[] runners { get; set; }

		/*public NGMarketDescription description { get; set; }
		[JsonProperty(PropertyName = "event")]
		public NGEvent _event { get; set; }
		public NGEventType eventType { get; set; }
		public string marketName { get; set; }
		public DateTime marketStartTime { get; set; }*/
	}

	public class NGRunnerCatalog
	{
		public int selectionId { get; set; }
		public string runnerName { get; set; }
		public decimal handicap { get; set; }
		public int sortPriority { get; set; }
		public NGRunnerMetaData metadata { get; set; }
	}

	public class NGRunner
	{
		public int selectionId { get; set; }
		public decimal handicap { get; set; }
		public string status { get; set; }
		public double adjustmentFactor { get; set; }
		public decimal lastPriceTraded { get; set; }
		public decimal totalMatched { get; set; }
		public DateTime removalDate { get; set; }
		public NGStartingPrices startingPrices { get; set; }
		public NGExchangePrices ex { get; set; }
		public NGOrder[] orders { get; set; }
		public NGMatch[] matches { get; set; }
	}

	public class NGRunnerMetaData
	{
		public string runnerId { get; set; }
	}

	public class NGRunnerDescription
	{
		public string runnerName { get; set; }
		//public NGRunnerMetaData metadata { get; set; }
	}

	public class NGStartingPrices
	{
		public decimal nearPrice { get; set; }
		public decimal farPrice { get; set; }
		public NGPriceSize[] backStakeTaken { get; set; }
		public NGPriceSize[] layLiabilityTaken { get; set; }
		public decimal actualSP { get; set; }
	}

	public class NGExchangePrices
	{
		public NGPriceSize[] availableToBack { get; set; }
		public NGPriceSize[] availableToLay { get; set; }
		public NGPriceSize[] tradedVolume { get; set; }
	}

	public class NGEvent
	{
		public string id { get; set; }
		public string name { get; set; }
		public string countryCode { get; set; }
		public string timeZone { get; set; }
		public string venue { get; set; }
		public DateTime openDate { get; set; }
	}

	public class NGEventResult
	{
		[JsonProperty(PropertyName = "event")]
		public NGEvent _event { get; set; }
		public int marketCount { get; set; }
	}

	public class NGCompetition
	{
		public string id { get; set; }
		public string name { get; set; }
	}

	public class NGCompetitionResult
	{
		public NGCompetition competition { get; set; }
		public int marketCount { get; set; }
		public string competitionRegion { get; set; }
	}

	public class NGEventType
	{
		public string id { get; set; }
		public string name { get; set; }
	}

	public class NGEventTypeResult
	{
		public NGEventType eventType { get; set; }
		public int marketCount { get; set; }
	}

	public class NGMarketTypeResult
	{
		public string marketType { get; set; }
		public int marketCount { get; set; }
	}

	public class NGCountryCodeResult
	{
		public string countryCode { get; set; }
		public int marketCount { get; set; }
	}

	public class NGVenueResult
	{
		public string venue { get; set; }
		public int marketCount { get; set; }
	}

	public class NGTimeRange
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? from { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? to { get; set; }
	}

	public class NGTimeRangeResult
	{
		public NGTimeRange timeRange { get; set; }
		public int marketCount { get; set; }
	}

	public class NGOrder
	{
		public string betId { get; set; }
		public string orderType { get; set; } // NGOrderType
		public string status { get; set; } // NGStatus
		public string persistenceType { get; set; } // NGPersistenceType
		public string side { get; set; } // NGSide
		public decimal price { get; set; }
		public decimal size { get; set; }
		public decimal bspLiability { get; set; }
		public DateTime placedDate { get; set; }
		public decimal avgPriceMatched { get; set; }
		public decimal sizeMatched { get; set; }
		public decimal sizeRemaining { get; set; }
		public decimal sizeLapsed { get; set; }
		public decimal sizeCancelled { get; set; }
		public decimal sizeVoided { get; set; }
	}

	public class NGMatch
	{
		public string betId { get; set; }
		public string matchId { get; set; }
		public string side { get; set; }
		public decimal price { get; set; }
		public decimal size { get; set; }
		public DateTime matchDate { get; set; }
	}

	public class NGMarketState
	{
		public string status { get; set; }
		public int betDelay { get; set; }
		public bool bspReconciled { get; set; }
		public bool complete { get; set; }
		public bool inplay { get; set; }
		public int numberOfActiveRunners { get; set; }
		public DateTime lastMatchTime { get; set; }
		public decimal totalMatched { get; set; }
		public decimal totalAvailable { get; set; }
	}

	public class NGMarketVersion
	{
		public long version { get; set; }
	}

	public class NGMarketDescription
	{
		public bool persistenceEnabled { get; set; }
		public bool bspMarket { get; set; }
		public DateTime marketTime { get; set; }
		public DateTime suspendTime { get; set; }
		public string bettingType { get; set; }
		public bool turnInPlayEnabled { get; set; }
		public string marketType { get; set; }
		public string regulator { get; set; }
		public decimal marketBaseRate { get; set; }
		public bool discountAllowed { get; set; }
		public string wallet { get; set; }
		public string rules { get; set; }
		public bool rulesHasDate { get; set; }
		public string clarifications { get; set; }
	}

	public class NGMarketRates
	{
		public decimal marketBaseRate { get; set; }
		public bool discountAllowed { get; set; }
	}

	public class NGMarketLicence
	{
		public string wallet { get; set; }
		public string rules { get; set; }
		public bool rulesHasDate { get; set; }
		public string clarifications { get; set; }
	}

	public class NGMarketLineRangeInfo
	{
		public decimal maxUnitValue { get; set; }
		public decimal minUnitValue { get; set; }
		public decimal interval { get; set; }
		public string marketUnit { get; set; }
	}

	public class NGPriceSize
	{
		public decimal price { get; set; }
		public decimal size { get; set; }
	}

	public class NGClearedOrderSummary
	{
		public string eventTypeId { get; set; }
		public string eventId { get; set; }
		public string marketId { get; set; }
		public int selectionId { get; set; }
		public decimal handicap { get; set; }
		public string betId { get; set; }
		public DateTime placedDate { get; set; }
		public string persistenceType { get; set; }
		public string orderType { get; set; }
		public string side { get; set; }
		public NGItemDescription itemDescription { get; set; }
		public decimal priceRequested { get; set; }
		public DateTime settledDate { get; set; }
		public int betCount { get; set; }
		public decimal commission { get; set; }
		public decimal priceMatched { get; set; }
		public bool priceReduced { get; set; }
		public decimal sizeSettled { get; set; }
		public decimal profit { get; set; }
		public decimal sizeCancelled { get; set; }
	}

	public class NGClearedOrderSummaryReport
	{
		public NGClearedOrderSummary[] clearedOrders { get; set; }
		public bool moreAvailable { get; set; }
	}

	public class NGItemDescription
	{
		public string eventTypeDesc { get; set; }
		public string eventDesc { get; set; }
		public string marketDesc { get; set; }
		public DateTime marketStartTime { get; set; }
		public string runnerDesc { get; set; }
		public int numberOfWinners { get; set; }
	}

	public class NGRunnerId
	{
		public string marketId { get; set; }
		public int selectionId { get; set; }
		public decimal handicap { get; set; }
	}

	public class NGCurrentOrderSummaryReport
	{
		public NGCurrentOrderSummary[] currentOrders { get; set; }
		public bool moreAvailable { get; set; }
	}

	public class NGCurrentOrderSummary
	{
		public string betId { get; set; }
		public string marketId { get; set; }
		public int selectionId { get; set; }
		public decimal handicap { get; set; }
		public NGPriceSize priceSize { get; set; }
		public decimal bspLiability { get; set; }
		public string side { get; set; }
		public string status { get; set; }
		public string persistenceType { get; set; }
		public string orderType { get; set; }
		public DateTime placedDate { get; set; }
		public DateTime matchedDate { get; set; }
		public decimal averagePriceMatched { get; set; }
		public decimal sizeMatched { get; set; }
		public decimal sizeRemaining { get; set; }
		public decimal sizeLapsed { get; set; }
		public decimal sizeVoided { get; set; }
		public string regulatorAuthCode { get; set; }
		public string regulatorCode { get; set; }
	}

	public class NGPlaceInstruction
	{
		public string orderType { get; set; }
		public int selectionId { get; set; }
		public decimal handicap { get; set; }
		public string side { get; set; }
		public NGLimitOrder limitOrder { get; set; }
		public NGLimitOnCloseOrder limitOnCloseOrder { get; set; }
		public NGMarketOnCloseOrder marketOnCloseOrder { get; set; }
	}

	public class NGPlaceExecutionReport
	{
		public string customerRef { get; set; }
		public string status { get; set; }
		public string errorCode { get; set; }
		public string marketId { get; set; }
		public NGPlaceInstructionReport[] instructionReports { get; set; }
	}

	public class NGLimitOrder
	{
		public decimal size { get; set; }
		public decimal price { get; set; }
		public string persistenceType { get; set; }
	}

	public class NGLimitOnCloseOrder
	{
		public decimal liability { get; set; }
		public decimal price { get; set; }
	}

	public class NGMarketOnCloseOrder
	{
		public decimal liability { get; set; }
	}

	public class NGPlaceInstructionReport
	{
		public string status { get; set; }
		public string errorCode { get; set; }
		public NGPlaceInstruction instruction { get; set; }
		public string betId { get; set; }
		public DateTime placedDate { get; set; }
		public decimal averagePriceMatched { get; set; }
		public decimal sizeMatched { get; set; }
	}

	public class NGCancelInstruction
	{
		public string betId { get; set; }
		public double? sizeReduction { get; set; }
	}

	public class NGCancelExecutionReport
	{
		public string customerRef { get; set; }
		public string status { get; set; }
		public string errorCode { get; set; }
		public string marketId { get; set; }
		public NGCancelInstructionReport[] instructionReports { get; set; }
	}

	public class NGCancelInstructionReport
	{
		public string status { get; set; }
		public string errorCode { get; set; }
		public NGCancelInstruction instruction { get; set; }
		public double sizeCancelled { get; set; }
		public DateTime cancelledDate { get; set; }
	}

	public class NGReplaceInstruction
	{
		public string betId { get; set; }
		public double newPrice { get; set; }
	}

	public class NGReplaceExecutionReport
	{
		public string customerRef { get; set; }
		public string status { get; set; }
		public string errorCode { get; set; }
		public string marketId { get; set; }
		public NGReplaceInstructionReport[] instructionReports { get; set; }
	}

	public class NGReplaceInstructionReport
	{
		public string status { get; set; }
		public string errorCode { get; set; }
		public NGCancelInstructionReport cancelInstructionReport { get; set; }
		public NGPlaceInstructionReport placeInstructionReport { get; set; }
	}

	public class NGUpdateInstruction
	{
		public string betId { get; set; }
		public string newPersistenceType { get; set; }
	}

	public class NGUpdateExecutionReport
	{
		public string customerRef { get; set; }
		public string status { get; set; }
		public string errorCode { get; set; }
		public string marketId { get; set; }
		public NGUpdateInstructionReport[] instructionReports { get; set; }
	}

	public class NGUpdateInstructionReport
	{
		public string status { get; set; }
		public string errorCode { get; set; }
		public NGUpdateInstruction instruction { get; set; }
	}

	public class NGPriceProjection
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] priceData { get; set; }

		public NGExBestOffersOverrides exBestOffersOverrides { get; set; }
		public bool virtualise { get; set; }
		public bool rolloverStakes { get; set; }
	}

	public class NGExBestOffersOverrides
	{
		public int bestPricesDepth { get; set; }
		public string rollupModel { get; set; }
		public int rollupLimit { get; set; }
		public decimal rollupLiabilityThreshold { get; set; }
		public int rollupLiabilityFactor { get; set; }
	}

	public class NGMarketProfitAndLoss
	{
		public string marketId { get; set; }
		public decimal commissionApplied { get; set; }
		public NGRunnerProfitAndLoss[] profitAndLosses { get; set; }
	}

	public class NGRunnerProfitAndLoss
	{
		public long selectionId { get; set; }
		public decimal ifWin { get; set; }
		public decimal ifLose { get; set; }
	}

	public class NGResponse<T>
	{
		public string jsonrpc { get; set; }
		public T result { get; set; }
		public int id { get; set; }
	}

	public class NGLoginResponse
	{
		public string token { get; set; }
		public string product { get; set; }
		public string status { get; set; }
		public string error { get; set; }
	}

	public class NGAccountFundsResponse
	{
		public decimal availableToBetBalance { get; set; }
		public decimal exposure { get; set; }
		public decimal retainedCommission { get; set; }
		public decimal exposureLimit { get; set; }
	}

	public class NGAccountStatementReport
	{
		public NGStatementItem[] accountStatement { get; set; }
		public bool moreAvailable { get; set; }
	}

	public class NGStatementItem
	{
		public string refId { get; set; }
		//An external reference, eg. equivalent to betId in the case of an exchange bet statement item.

		public DateTime itemDate { get; set; }
		//The date and time of the statement item, eg. equivalent to settledData for an exchange bet statement item. (in ISO-8601 format, not translated)

		public decimal amount { get; set; }
		// The amount of money the balance is adjusted by

		public decimal balance { get; set; }
		// Account balance.

		public string itemClass { get; set; }
		// Class of statement item. This value will determine which set of keys will be included in itemClassData

		/// <summary>
		/// Key value pairs describing the current statement item. The set of keys will be determined by the itemClass 
		/// </summary>
		/// <value>The item class data.</value>
		public string[][] itemClassData { get; set; }

		/// <summary>
		/// Set of fields originally returned from APIv6. Provided to facilitate migration from APIv6 to API-NG, and ultimately onto itemClass and itemClassData
		/// </summary>
		/// <value>The legacy data.</value>
		public NGStatementLegacyData legacyData { get; set; }

	}

	public class NGStatementLegacyData
	{
		public decimal avgPrice { get; set; }
		public decimal betSize { get; set; }
		public string betType { get; set; }
		public string betCategoryType { get; set; }
		public string commissionRate { get; set; }
		public long eventId { get; set; }
		public long eventTypeId { get; set; }
		public string fullMarketName { get; set; }
		public decimal grossBetAmount { get; set; }
		public string marketName { get; set; }
		public string marketType { get; set; }
		public DateTime placedDate { get; set; }
		public long selectionId { get; set; }
		public string selectionName { get; set; }
		public DateTime startDate { get; set; }
		public string transactionType { get; set; }
		public long transactionId { get; set; }
		public string winLose { get; set; }
	}

	public class NGCurrencyRate
	{
		public string currencyCode { get; set; }
		public decimal rate { get; set; }
	}
}

