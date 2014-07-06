using System;

namespace SharpFair.Models
{
	public class EventTypes
	{
		public const string Soccer = "1";
		public const string Tennis = "2";
		public const string Golf = "3";
		public const string Cricket = "4";
		public const string RugbyUnion = "5";
		public const string Boxing = "6";
		public const string HorseRacing = "7";
		public const string MotorSport = "8";
		public const string SpecialBets = "10";
		public const string Cycling = "11";
		public const string Rowing = "12";
		public const string RugbyLeague = "1477";
		public const string Athletics = "3988";
		public const string GreyhoundRacing = "4339";
		public const string FinancialBets = "6231";
		public const string Snooker = "6422";
		public const string AmericanFootball = "6423";
		public const string Baseball = "7511";
		public const string Basketball = "7522";
		public const string IceHockey = "7524";
		public const string Pool = "72382";
		public const string Handball = "468328";
		public const string Volleyball = "998917";
		public const string Bowls = "998918";
		public const string Floorball = "998920";
		public const string GaelicGames = "2152880";
		public const string Politics = "2378961";
		public const string MixedMartialArts = "26420387";
	}

	public class MarketTypeCodes
	{
		// common & soccer
		public const string WIN = "WIN";
		public const string PLACE = "PLACE";
		public const string ANTEPOST_WIN = "ANTEPOST_WIN";
		public const string FORECAST = "FORECAST";
		public const string SPECIAL = "SPECIAL";
		public const string STEWARDS = "STEWARDS";
		public const string DAILY_WIN_DIST = "DAILY_WIN_DIST";
		public const string UNDIFFERENTIATED = "UNDIFFERENTIATED";
		public const string MATCH_BET = "MATCH_BET";
		public const string REV_FORECAST = "REV_FORECAST";
		public const string MATCH_ODDS = "MATCH_ODDS";
		public const string CORRECT_SCORE2 = "CORRECT_SCORE2";
		public const string CORRECT_SCORE = "CORRECT_SCORE";
		public const string OVER_UNDER_85 = "OVER_UNDER_85";
		public const string OVER_UNDER_75 = "OVER_UNDER_75";
		public const string OVER_UNDER_65 = "OVER_UNDER_65";
		public const string OVER_UNDER_55 = "OVER_UNDER_65";
		public const string OVER_UNDER_45 = "OVER_UNDER_45";
		public const string OVER_UNDER_35 = "OVER_UNDER_35";
		public const string OVER_UNDER_25 = "OVER_UNDER_25";
		public const string OVER_UNDER_15 = "OVER_UNDER_15";
		public const string OVER_UNDER_05 = "OVER_UNDER_05";
		public const string ASIAN_HANDICAP = "ASIAN_HANDICAP";
		public const string DRAW_NO_BET = "DRAW_NO_BET";
		public const string HALF_TIME = "HALF_TIME";
		public const string HALF_TIME_SCORE = "HALF_TIME_SCORE";
		public const string NEXT_GOAL = "NEXT_GOAL";
		public const string HALF_TIME_FULL_TIME = "HALF_TIME_FULL_TIME";
		public const string WIN_BOTH_HALVES = "WIN_BOTH_HALVES";
		public const string BOTH_TEAMS_TO_SCORE = "BOTH_TEAMS_TO_SCORE";
		public const string DOUBLE_CHANCE = "DOUBLE_CHANCE";
		public const string ODD_OR_EVEN = "ODD_OR_EVEN";
		public const string WINNER = "WINNER";
		public const string SENDING_OFF = "SENDING_OFF";
		public const string HAT_TRICKED_SCORED = "HAT_TRICKED_SCORED";
		public const string PENALTY_TAKEN = "PENALTY_TAKEN";
		public const string TEAM_TOTAL_GOALS = "TEAM_TOTAL_GOALS";
		public const string TOTAL_GOALS = "TOTAL_GOALS";
		public const string TEAM_B_1 = "TEAM_B_1";
		public const string TEAM_A_1 = "TEAM_A_1";
		public const string FIRST_HALF_GOALS_05 = "FIRST_HALF_GOALS_05";
		public const string FIRST_HALF_GOALS_15 = "FIRST_HALF_GOALS_15";
		public const string TEAM_A_WIN_TO_NIL = "TEAM_A_WIN_TO_NIL";
		public const string FIRST_HALF_GOALS_25 = "FIRST_HALF_GOALS_25";
		public const string CLEAN_SHEET = "CLEAN_SHEET";
		public const string TEAM_B_WIN_TO_NIL = "TEAM_B_WIN_TO_NIL";
		public const string FIRST_GOAL_ODDS = "FIRST_GOAL_ODDS";
		public const string HALF_WITH_MOST_GOALS = "HALF_WITH_MOST_GOALS";
		public const string RACE_TO_3_GOALS = "RACE_TO_3_GOALS";
		public const string SECOND_HALF_GOALS_05 = "SECOND_HALF_GOALS_05";
		public const string SECOND_HALF_GOALS_15 = "SECOND_HALF_GOALS_15";
		public const string SCORE_CAST = "SCORE_CAST";
		public const string RACE_TO_2_GOALS = "RACE_TO_2_GOALS";
		public const string BOOKING_MATCH_BET = "BOOKING_MATCH_BET";
		public const string UNUSED = "UNUSED";
		public const string GOAL_BOTH_HALVES = "GOAL_BOTH_HALVES";
		public const string WINNING_MARGIN = "WINNING_MARGIN";
		public const string BOOKING_ODDS = "BOOKING_ODDS";
		public const string TO_SCORE = "TO_SCORE";
		public const string TO_SCORE_BOTH_HALVES = "TO_SCORE_BOTH_HALVES";
		public const string FIRST_CORNER = "FIRST_CORNER";
		public const string CORNER_MATCH_BET = "CORNER_MATCH_BET";
		public const string TOTAL_GOALS_INDEX = "TOTAL_GOALS_INDEX";
		public const string CORNER_ODDS = "CORNER_ODDS";
		public const string LAST_GOALSCORER = "LAST_GOALSCORER";
		public const string TOTAL_CORNERS = "TOTAL_CORNERS";
		public const string OVER_UNDER_105_CORNR = "OVER_UNDER_105_CORNR";
		public const string OVER_UNDER_45_CARDS = "OVER_UNDER_45_CARDS";
		public const string FIRST_HALF_CORNERS = "FIRST_HALF_CORNERS";
		public const string FIRST_GOAL_SCORER = "FIRST_GOAL_SCORER";
		public const string WIN_HALF = "WIN_HALF";
		public const string OVER_UNDER_55_CORNR = "OVER_UNDER_55_CORNR";
		public const string WIN_FROM_BEHIND = "WIN_FROM_BEHIND";
		public const string OVER_UNDER_135_CORNR = "OVER_UNDER_135_CORNR";
		public const string WINCAST = "WINCAST";
		public const string TEAM_A_3 = "TEAM_A_3";
		public const string TEAM_B_2 = "TEAM_B_2";
		public const string TEAM_B_3 = "TEAM_B_3";
		public const string TEAM_A_2 = "TEAM_A_2";
		public const string OVER_UNDER_65_CARDS = "OVER_UNDER_65_CARDS";
		public const string SHOWN_A_CARD = "SHOWN_A_CARD";
		public const string TO_QUALIFY = "TO_QUALIFY";
		public const string EXACT_GOALS = "EXACT_GOALS";
		public const string GROUP_QUADCAST = "GROUP_QUADCAST";
		public const string TO_REACH_QUARTERS = "TO_REACH_QUARTERS";
		public const string TO_REACH_SEMIS = "TO_REACH_SEMIS";
		public const string TO_REACH_FINAL = "TO_REACH_FINAL";
		public const string TOP_N_FINISH = "TOP_N_FINISH";	

		// basketball
		public const string TOURNAMENT_WINNER = "TOURNAMENT_WINNER";
		public const string HANDICAP = "HANDICAP";
		public const string TOTAL_POINTS = "TOTAL_POINTS";
		public const string HALF_HANDICAP = "HALF_HANDICAP";
		public const string HALF_TOTAL_POINTS = "HALF_TOTAL_POINTS";
		public const string HALF_MATCH_ODDS = "HALF_MATCH_ODDS";
		public const string QUARTER_HANDICAP = "QUARTER_HANDICAP";
		public const string QUARTER_TOTAL_POINTS = "QUARTER_TOTAL_POINTS";
		public const string PLAYER_POINTS = "PLAYER_POINTS";
		public const string QUARTER_MATCH_ODDS = "QUARTER_MATCH_ODDS";

		// tennis
		public const string TOTAL_GAMES = "TOTAL_GAMES";
		public const string SET_BETTING = "SET_BETTING";
		public const string _6_0_SET = "6-0_SET";
		public const string TIE_BREAK = "TIE_BREAK";
		public const string GAME_BY_GAME_03_12 = "GAME_BY_GAME_03_12";
		public const string GAME_BY_GAME_03_13 = "GAME_BY_GAME_03_13";
		public const string GAME_BY_GAME_03_07 = "GAME_BY_GAME_03_07";
		public const string GAME_BY_GAME_03_08 = "GAME_BY_GAME_03_08";
		public const string GAME_BY_GAME_03_10 = "GAME_BY_GAME_03_10";
		public const string GAME_BY_GAME_03_09 = "GAME_BY_GAME_03_09";
		public const string GAME_BY_GAME_03_11 = "GAME_BY_GAME_03_11";
		public const string SET_WINNER = "SET_WINNER";
		public const string GAME_BY_GAME_03_02 = "GAME_BY_GAME_03_02";
		public const string GAME_BY_GAME_03_01 = "GAME_BY_GAME_03_01";
		public const string GAME_BY_GAME_02_12 = "GAME_BY_GAME_02_12";
		public const string GAME_BY_GAME_02_13 = "GAME_BY_GAME_02_13";
		public const string GAME_BY_GAME_03_06 = "GAME_BY_GAME_03_06";
		public const string GAME_BY_GAME_03_05 = "GAME_BY_GAME_03_05";
		public const string GAME_BY_GAME_03_04 = "GAME_BY_GAME_03_04";
		public const string GAME_BY_GAME_03_03 = "GAME_BY_GAME_03_03";
		public const string GAME_BY_GAME_02_02 = "GAME_BY_GAME_02_02";
		public const string GAME_BY_GAME_02_01 = "GAME_BY_GAME_02_01";
		public const string GAME_BY_GAME_02_09 = "GAME_BY_GAME_02_09";
		public const string GAME_BY_GAME_02_08 = "GAME_BY_GAME_02_08";
		public const string GAME_BY_GAME_02_11 = "GAME_BY_GAME_02_11";
		public const string GAME_BY_GAME_02_10 = "GAME_BY_GAME_02_10";
		public const string GAME_BY_GAME_02_04 = "GAME_BY_GAME_02_04";
		public const string GAME_BY_GAME_02_03 = "GAME_BY_GAME_02_03";
		public const string GAME_BY_GAME_02_07 = "GAME_BY_GAME_02_07";
		public const string GAME_BY_GAME_02_06 = "GAME_BY_GAME_02_06";
		public const string GAME_BY_GAME_02_05 = "GAME_BY_GAME_02_05";
		public const string GAME_BY_GAME_01_01 = "GAME_BY_GAME_01_01";
		public const string GAME_BY_GAME_01_02 = "GAME_BY_GAME_01_02";
		public const string GAME_BY_GAME_01_03 = "GAME_BY_GAME_01_03";
		public const string GAME_BY_GAME_01_05 = "GAME_BY_GAME_01_05";
		public const string GAME_BY_GAME_01_04 = "GAME_BY_GAME_01_04";
		public const string GAME_BY_GAME_01_06 = "GAME_BY_GAME_01_06";
		public const string GAME_BY_GAME_01_07 = "GAME_BY_GAME_01_07";
		public const string GAME_BY_GAME_01_08 = "GAME_BY_GAME_01_08";
		public const string GAME_BY_GAME_01_09 = "GAME_BY_GAME_01_09";
		public const string GAME_BY_GAME_01_10 = "GAME_BY_GAME_01_10";
		public const string GAME_BY_GAME_01_11 = "GAME_BY_GAME_01_11";
		public const string SET_CORRECT_SCORE = "SET_CORRECT_SCORE";
		public const string GAME_BY_GAME_01_12 = "GAME_BY_GAME_01_12";
		public const string GAME_BY_GAME_01_13 = "GAME_BY_GAME_01_13";
	}

	public class CountryCodes
	{
		public const string UnitedKingdom = "GB";
		public const string France = "FR";
		public const string Ireland = "IE";
		public const string UnitedArabEmirates = "AE";
		public const string Germany = "DE";
		public const string SouthAfrica = "ZA";
		public const string UnitedStates = "US";
	}

	public class CurrencyCodes
	{
		public const string USD = "USD";
		public const string GBP = "GBP";
		public const string EUR = "EUR";
		public const string TRY = "TRY";
	}

	public class MethodNames
	{
		//
		// account operations
		//
		public const string GetAccountFunds = "getAccountFunds";
		public const string GetAccountDetails = "getAccountDetails";
		public const string GetAccountStatement = "getAccountStatement";
		public const string ListCurrencyRates = "listCurrencyRates";

		//
		// sports operations
		//
		public const string ListCompetitions = "listCompetitions";
		public const string ListCountries = "listCountries";
		public const string ListEvents = "listEvents";
		public const string ListEventTypes = "listEventTypes";
		public const string ListMarketTypes = "listMarketTypes";
		public const string ListVenues = "listVenues";
		public const string ListMarketCatalogue = "listMarketCatalogue";
		public const string ListMarketProfitAndLoss = "listMarketProfitAndLoss";
		public const string ListMarketBook = "listMarketBook";
		public const string ListTimeRanges = "listTimeRanges";

		public const string PlaceOrders = "placeOrders";
		public const string CancelOrders = "cancelOrders";
		public const string UpdateOrders = "updateOrders";
		public const string ReplaceOrders = "replaceOrders";
		public const string ListCurrentOrders = "listCurrentOrders";
		public const string ListClearedOrders = "listClearedOrders";

	}

	public class MarketProjection
	{
		public const string RUNNER_METADATA = "RUNNER_METADATA";
		public const string MARKET_START_TIME = "MARKET_START_TIME";
		public const string RUNNER_DESCRIPTION = "RUNNER_DESCRIPTION";
		public const string MARKET_DESCRIPTION = "MARKET_DESCRIPTION";
		public const string EVENT_TYPE = "EVENT_TYPE";
		public const string EVENT = "EVENT";
		public const string COMPETITION = "COMPETITION";
	}

	public class PriceData
	{
		public const string SP_AVAILABLE = "SP_AVAILABLE";
		public const string SP_TRADED = "SP_TRADED";
		public const string EX_BEST_OFFERS = "EX_BEST_OFFERS";
		public const string EX_ALL_OFFERS = "EX_ALL_OFFERS";
		public const string EX_TRADED = "EX_TRADED";
	}

	public class MatchProjection
	{

	}

	public class OrderProjection
	{
	}

	public class MarketStatus
	{
		public const string INACTIVE = "INACTIVE";
		public const string OPEN = "OPEN";
		public const string SUSPENDED = "SUSPENDED";
		public const string CLOSED = "CLOSED";
	}

	public class RunnerStatus
	{
		public const string ACTIVE = "ACTIVE";
		public const string WINNER = "WINNER";
		public const string LOSER = "LOSER";
		public const string REMOVED_VACANT = "REMOVED_VACANT";
		public const string REMOVED = "REMOVED";
		public const string HIDDEN = "HIDDEN";
	}

	public class TimeGranularity
	{
		public const string DAYS = "DAYS";
		public const string HOURS = "HOURS";
		public const string MINUTES = "MINUTES";
	}

	public class Side
	{
		public const string BACK = "BACK";
		public const string LAY = "LAY";
	}

	public class OrderBy
	{
		public const string BY_BET = "BY_BET";
		public const string BY_MARKET = "BY_MARKET";
		public const string BY_MATCH_TIME = "BY_MATCH_TIME";
	}

	public class SortDir
	{
		public const string EARLIEST_TO_LATEST = "EARLIEST_TO_LATEST";
		public const string LATEST_TO_EARLIEST = "LATEST_TO_EARLIEST";
	}

	public class OrderType
	{
		public const string LIMIT = "LIMIT";
		public const string LIMIT_ON_CLOSE = "LIMIT_ON_CLOSE";
		public const string MARKET_ON_CLOSE = "MARKET_ON_CLOSE";
	}

	public class MarketSort
	{
		public const string MINIMUM_TRADED = "MINIMUM_TRADED"; // Minimum traded volume
		public const string MAXIMUM_TRADED = "MAXIMUM_TRADED"; // Maximum traded volume
		public const string MINIMUM_AVAILABLE = "MINIMUM_AVAILABLE"; // Minimum available to match
		public const string MAXIMUM_AVAILABLE = "MAXIMUM_AVAILABLE"; // Maximum available to match
		public const string FIRST_TO_START = "FIRST_TO_START"; //The closest markets based on their expected start time
		public const string LAST_TO_START = "LAST_TO_START"; // The most distant markets based on their expected start time
	}

	public class MarketBettingType
	{
		public const string ODDS = "ODDS"; // Odds Market
		public const string LINE = "LINE"; // Line Market
		public const string RANGE = "RANGE"; // Range Market
		public const string ASIAN_HANDICAP_DOUBLE_LINE = "ASIAN_HANDICAP_DOUBLE_LINE"; // Asian Handicap Market
		public const string ASIAN_HANDICAP_SINGLE_LINE = "ASIAN_HANDICAP_SINGLE_LINE"; // Asian Single Line Market
		public const string FIXED_ODDS = "FIXED_ODDS";	// Sportsbook Odds Market. This type is deprecated and will be removed in future releases, 
														// when Sportsbook markets will be represented as ODDS market but with a different produc
	}

	public class ExecutionReportStatus 
	{
		public const string SUCCESS = "SUCCESS";
		public const string FAILURE = "FAILURE";
		public const string PROCESSED_WITH_ERRORS = "PROCESSED_WITH_ERRORS";
		public const string TIMEOUT = "TIMEOUT";
	
	}

	public class ExecutionReportErrorCode 
	{
		public const string ERROR_IN_MATCHER = "ERROR_IN_MATCHER";
		public const string PROCESSED_WITH_ERRORS = "PROCESSED_WITH_ERRORS";
		public const string BET_ACTION_ERROR = "BET_ACTION_ERROR";
		public const string INVALID_ACCOUNT_STATE = "INVALID_ACCOUNT_STATE";
		public const string INVALID_WALLET_STATUS = "INVALID_WALLET_STATUS";
		public const string INSUFFICIENT_FUNDS = "INSUFFICIENT_FUNDS";
		public const string LOSS_LIMIT_EXCEEDED = "LOSS_LIMIT_EXCEEDED";
		public const string MARKET_SUSPENDED = "MARKET_SUSPENDED";
		public const string MARKET_NOT_OPEN_FOR_BETTING = "MARKET_NOT_OPEN_FOR_BETTING";
		public const string DUPLICATE_TRANSACTION = "DUPLICATE_TRANSACTION";
		public const string INVALID_ORDER = "INVALID_ORDER";
		public const string INVALID_MARKET_ID = "INVALID_MARKET_ID";
		public const string PERMISSION_DENIED = "PERMISSION_DENIED";
		public const string DUPLICATE_BETIDS = "DUPLICATE_BETIDS";
		public const string NO_ACTION_REQUIRED = "NO_ACTION_REQUIRED";
		public const string SERVICE_UNAVAILABLE = "SERVICE_UNAVAILABLE";
		public const string REJECTED_BY_REGULATOR = "REJECTED_BY_REGULATOR";
	}

	public class PersistenceType
	{
		public const string LAPSE = "LAPSE";
		public const string PERSIST = "PERSIST";
		public const string MARKET_ON_CLOSE = "MARKET_ON_CLOSE";
	}

	public class InstructionReportErrorCode 
	{
		public const string INVALID_BET_SIZE = "INVALID_BET_SIZE";
		public const string INVALID_RUNNER = "INVALID_RUNNER";
		public const string BET_TAKEN_OR_LAPSED = "BET_TAKEN_OR_LAPSED";
		public const string BET_IN_PROGRESS = "BET_IN_PROGRESS";
		public const string RUNNER_REMOVED = "RUNNER_REMOVED";
		public const string MARKET_NOT_OPEN_FOR_BETTING = "MARKET_NOT_OPEN_FOR_BETTING";
		public const string LOSS_LIMIT_EXCEEDED = "LOSS_LIMIT_EXCEEDED";
		public const string MARKET_NOT_OPEN_FOR_BSP_BETTING = "MARKET_NOT_OPEN_FOR_BSP_BETTING";
		public const string INVALID_PRICE_EDIT = "INVALID_PRICE_EDIT";
		public const string INVALID_ODDS = "INVALID_ODDS";
		public const string INSUFFICIENT_FUNDS = "INSUFFICIENT_FUNDS";
		public const string INVALID_PERSISTENCE_TYPE = "INVALID_PERSISTENCE_TYPE";
		public const string ERROR_IN_MATCHER = "ERROR_IN_MATCHER";
		public const string INVALID_BACK_LAY_COMBINATION = "INVALID_BACK_LAY_COMBINATION";
		public const string ERROR_IN_ORDER = "ERROR_IN_ORDER";
		public const string INVALID_BID_TYPE = "INVALID_BID_TYPE";
		public const string INVALID_BET_ID = "INVALID_BET_ID";
		public const string CANCELLED_NOT_PLACED = "CANCELLED_NOT_PLACED";
		public const string RELATED_ACTION_FAILED = "RELATED_ACTION_FAILED";
		public const string NO_ACTION_REQUIRED = "NO_ACTION_REQUIRED";
	}

	public class RollupModel 
	{
		/* STAKE
The volumes will be rolled up to the minimum value which is >= rollupLimit.
PAYOUT
The volumes will be rolled up to the minimum value where the payout( price * volume ) is >= rollupLimit.
MANAGED_LIABILITY
The volumes will be rolled up to the minimum value which is >= rollupLimit, until a lay price threshold. There after, the volumes will be rolled up to the minimum value such that the liability >= a minimum liability. Not supported as yet.
NONE
No rollup will be applied. However the volumes will be filtered by currency specific minimum stake unless overridden specifically for the channel.
*/
	}

	public class GroupBy 
	{
		/* EVENT_TYPE
A roll up of settled P&L, commission paid and number of bet orders, on a specified event type
EVENT
A roll up of settled P&L, commission paid and number of bet orders, on a specified event
MARKET
A roll up of settled P&L, commission paid and number of bet orders, on a specified market
SIDE
An averaged roll up of settled P&L, and number of bets, on the specified side of a specified selection within a specified market, that are either settled or voided
BET
The P&L, commission paid, side and regulatory information etc, about each individual bet order
*/
	}

	public class BetStatus
	{
		public const string SETTLED = "SETTLED";
		public const string VOIDED = "VOIDED"; // A matched bet that was subsequently voided by Betfair, before, during or after settlement
		public const string LAPSED = "LAPSED"; // Unmatched bet that was cancelled by Betfair (for example at turn in play).
		public const string CANCELLED = "CANCELLED"; // Unmatched bet that was cancelled by an explicit customer action.
	}

	public class InstructionReportStatus
	{
		public const string SUCCESS = "SUCCESS";
		public const string FAILURE = "FAILURE";
		public const string TIMEOUT = "TIMEOUT";
	}
}
