// C# Structs For Eurex Cash T7 Eti 7.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Appl Id Values
/// </summary>
public enum ApplId : byte {
    Trade = 1,
    News = 2,
    Serviceavailability = 3,
    Sessiondata = 4,
    Listenerdata = 5,
    RiskControl = 6,
    TesMaintenance = 7,
    TesTrade = 8,
    ApplIDMinimumValue = 10,
    ApplIDMinimumValue = 0,
};

/// <summary>
///  Appl Id Status Values
/// </summary>
public enum ApplIdStatus : uint {
    Outboundconversionerror = 105,
    ApplIdStatusMinimumValue = 4294967294,
    ApplIdStatusMinimumValue = 0,
};

/// <summary>
///  Appl Resend Flag Values
/// </summary>
public enum ApplResendFlag : byte {
    False = 0,
    True = 1,
    ApplResendFlagMinimumValue = 1,
    ApplResendFlagMinimumValue = 0,
};

/// <summary>
///  Appl Seq Indicator Values
/// </summary>
public enum ApplSeqIndicator : byte {
    NoRecoveryRequired = 0,
    RecoveryRequired = 1,
    ApplSeqIndicatorMinimumValue = 1,
    ApplSeqIndicatorMinimumValue = 0,
};

/// <summary>
///  Appl Seq Status Values
/// </summary>
public enum ApplSeqStatus : byte {
    Unavailable = 0,
    Available = 1,
    ApplSeqStatusMinimumValue = 1,
    ApplSeqStatusMinimumValue = 0,
};

/// <summary>
///  Appl Usage Orders Values
/// </summary>
public enum ApplUsageOrders : byte {
    Automated = (byte)'A',
    Manual = (byte)'M',
    AutoSelect = (byte)'B',
    None = (byte)'N',
};

/// <summary>
///  Appl Usage Quotes Values
/// </summary>
public enum ApplUsageQuotes : byte {
    Automated = (byte)'A',
    Manual = (byte)'M',
    AutoSelect = (byte)'B',
    None = (byte)'N',
};

/// <summary>
///  Crossed Indicator Values
/// </summary>
public enum CrossedIndicator : byte {
    Nocrossing = 0,
    Crossrejected = 1,
    CrossedIndicatorMinimumValue = 1,
    CrossedIndicatorMinimumValue = 0,
};

/// <summary>
///  Delete Reason Values
/// </summary>
public enum DeleteReason : byte {
    Nospecialreason = 100,
    TasChange = 101,
    IntradayExpiration = 102,
    RiskEvent = 103,
    StopTrading = 104,
    DeleteReasonMinimumValue = 107,
    DeleteReasonMinimumValue = 100,
};

/// <summary>
///  Delivery Type Values
/// </summary>
public enum DeliveryType : byte {
    Akv = 1,
    Gs = 2,
    Str = 3,
    Wpr = 4,
    DeliveryTypeMinimumValue = 4,
    DeliveryTypeMinimumValue = 1,
};

/// <summary>
///  Event Type Values
/// </summary>
public enum EventType : byte {
    Redemption = 26,
    Delisting = 100,
    EventTypeMinimumValue = 100,
    EventTypeMinimumValue = 8,
};

/// <summary>
///  Ex Destination Type Values
/// </summary>
public enum ExDestinationType : byte {
    TradeonexchangeorSi = 3,
    ExDestinationTypeMinimumValue = 3,
    ExDestinationTypeMinimumValue = 3,
};

/// <summary>
///  Exec Inst Values
/// </summary>
public enum ExecInst : byte {
    H = 1,
    Q = 2,
    Hq = 3,
    H6 = 5,
    Q6 = 6,
    ExecInstMinimumValue = 6,
    ExecInstMinimumValue = 1,
};

/// <summary>
///  Exec Restatement Reason Values
/// </summary>
public enum ExecRestatementReason : ushort {
    CorporateAction = 0,
    OrderBookRestatement = 1,
    ExchangeOption = 8,
    OrderAdded = 101,
    OrderModified = 102,
    OrderCancelled = 103,
    IocOrderCancelled = 105,
    FokOrderCancelled = 107,
    BookOrderExecuted = 108,
    InstrumentStateChange = 122,
    EndOfDayProcessing = 146,
    OrderExpiration = 148,
    CaoOrderActivated = 149,
    CaoOrderInactivated = 150,
    OaoOrderActivated = 151,
    OaoOrderInactivated = 152,
    AaoOrderActivated = 153,
    AaoOrderInactivated = 154,
    IaoOrderActivated = 159,
    IaoOrderInactivated = 160,
    OrderRefreshed = 155,
    OcoOrderTriggered = 164,
    StopOrderTriggered = 172,
    OwnershipChanged = 181,
    OrderCancellationPending = 197,
    PendingCancellationExecuted = 199,
    BocOrderCancelled = 212,
    TrailingStopUpdate = 213,
    ExceedsMaximumQuantity = 237,
    InvalidLimitPrice = 238,
    UserDoesNotExist = 241,
    SessionDoesNotExist = 242,
    InvalidStopPrice = 243,
    InstrumentDoesNotExist = 245,
    BusinessUnitRiskEvent = 246,
    DividendPayment = 292,
    LastTradingDay = 294,
    TradingParameterChange = 295,
    CurrencyChange = 296,
    ProductAssignmentChange = 297,
    ReferencePriceChange = 298,
    TickRuleChange = 300,
    ExecRestatementReasonMinimumValue = 344,
    ExecRestatementReasonMinimumValue = 0,
};

/// <summary>
///  Exec Type Values
/// </summary>
public enum ExecType : byte {
    New = (byte)'0',
    Canceled = (byte)'4',
    Replaced = (byte)'5',
    PendingCancele = (byte)'6',
    Suspended = (byte)'9',
    Restated = (byte)'D',
    Triggered = (byte)'L',
    Trade = (byte)'F',
};

/// <summary>
///  Executing Trader Qualifier Values
/// </summary>
public enum ExecutingTraderQualifier : byte {
    Algo = 22,
    Human = 24,
    ExecutingTraderQualifierMinimumValue = 24,
    ExecutingTraderQualifierMinimumValue = 22,
};

/// <summary>
///  Fill Liquidity Ind Values
/// </summary>
public enum FillLiquidityInd : byte {
    AddedLiquidity = 1,
    RemovedLiquidity = 2,
    Auction = 4,
    TriggeredStopOrder = 5,
    TriggeredOcoOrder = 6,
    TriggeredMarketOrder = 7,
    FillLiquidityIndMinimumValue = 7,
    FillLiquidityIndMinimumValue = 1,
};

/// <summary>
///  Last Coupon Deviation Indicator Values
/// </summary>
public enum LastCouponDeviationIndicator : byte {
    None = 0,
    Shortperiod = 1,
    Longperiod = 2,
    Onlyonecoupon = 3,
    Shorttwointerestpaymentsdue = 4,
    Longtwointerestpaymentsdue = 5,
    LastCouponDeviationIndicatorMinimumValue = 5,
    LastCouponDeviationIndicatorMinimumValue = 0,
};

/// <summary>
///  Last Fragment Values
/// </summary>
public enum LastFragment : byte {
    NotLastMessage = 0,
    LastMessage = 1,
    LastFragmentMinimumValue = 1,
    LastFragmentMinimumValue = 0,
};

/// <summary>
///  Last Mkt Values
/// </summary>
public enum LastMkt : ushort {
    Xetr = 3,
    Xvie = 4,
    Xdub = 5,
    Xmal = 6,
    Xbul = 7,
    Xbud = 8,
    Xlju = 9,
    Xpra = 10,
    Xzag = 11,
    LastMktMinimumValue = 255,
    LastMktMinimumValue = 1,
};

/// <summary>
///  List Update Action Values
/// </summary>
public enum ListUpdateAction : byte {
    Add = (byte)'A',
    Delete = (byte)'D',
};

/// <summary>
///  Market Id Values
/// </summary>
public enum MarketId : ushort {
    Xetr = 3,
    Xvie = 4,
    Xdub = 5,
    Xmal = 6,
    Xbul = 7,
    Xbud = 8,
    Xlju = 9,
    Xpra = 10,
    Xzag = 11,
    MarketIDMinimumValue = 255,
    MarketIDMinimumValue = 1,
};

/// <summary>
///  Mass Action Reason Values
/// </summary>
public enum MassActionReason : byte {
    NoSpecialReason = 0,
    StopTrading = 1,
    Emergency = 2,
    SessionLoss = 6,
    DuplicateSessionLogin = 7,
    ClearingRiskControl = 8,
    ProductStateHalt = 105,
    ProductStateHoliday = 106,
    InstrumentSuspended = 107,
    VolatilityInterruption = 110,
    Producttemporarilynottradeable = 111,
    InstrumentStopped = 113,
    InstrumentKnockOut = 115,
    InstrumentSoldOut = 116,
    MassActionReasonMinimumValue = 200,
    MassActionReasonMinimumValue = 0,
};

/// <summary>
///  Mass Action Type Values
/// </summary>
public enum MassActionType : byte {
    Suspendquotes = 1,
    Releasequotes = 2,
    MassActionTypeMinimumValue = 2,
    MassActionTypeMinimumValue = 1,
};

/// <summary>
///  Match Sub Type Values
/// </summary>
public enum MatchSubType : byte {
    OpeningAuction = 1,
    ClosingAuction = 2,
    IntradayAuction = 3,
    CircuitBreakerAuction = 4,
    MatchSubTypeMinimumValue = 6,
    MatchSubTypeMinimumValue = 1,
};

/// <summary>
///  Match Type Values
/// </summary>
public enum MatchType : byte {
    ConfirmedTradeReport = 3,
    Automatchincoming = 4,
    CrossAuction = 5,
    CallAuction = 7,
    SystematicInternaliser = 9,
    Automatchresting = 11,
    Automatchatmidpoint = 12,
    ContinousAuction = 14,
    MatchTypeMinimumValue = 14,
    MatchTypeMinimumValue = 0,
};

/// <summary>
///  Matching Engine Status Values
/// </summary>
public enum MatchingEngineStatus : byte {
    Unavailable = 0,
    Available = 1,
    MatchingEngineStatusMinimumValue = 1,
    MatchingEngineStatusMinimumValue = 0,
};

/// <summary>
///  Message Event Source Values
/// </summary>
public enum MessageEventSource : byte {
    BroadcasttoInitiator = (byte)'I',
    BroadcasttoApprover = (byte)'A',
    BroadcasttoRequester = (byte)'R',
    BroadcasttoQuoteSubmitter = (byte)'Q',
};

/// <summary>
///  Ord Status Values
/// </summary>
public enum OrdStatus : byte {
    New = (byte)'0',
    Partiallyfilled = (byte)'1',
    Filled = (byte)'2',
    Canceled = (byte)'4',
    PendingCancel = (byte)'6',
    Suspended = (byte)'9',
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = 1,
    Limit = 2,
    Stop = 3,
    StopLimit = 4,
    OrdTypeMinimumValue = 4,
    OrdTypeMinimumValue = 1,
};

/// <summary>
///  Order Attribute Liquidity Provision Values
/// </summary>
public enum OrderAttributeLiquidityProvision : byte {
    Y = 1,
    N = 0,
    OrderAttributeLiquidityProvisionMinimumValue = 1,
    OrderAttributeLiquidityProvisionMinimumValue = 0,
};

/// <summary>
///  Order Category Values
/// </summary>
public enum OrderCategory : byte {
    Order = (byte)'1',
    Quote = (byte)'2',
};

/// <summary>
///  Order Routing Indicator Values
/// </summary>
public enum OrderRoutingIndicator : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Ownership Indicator Values
/// </summary>
public enum OwnershipIndicator : byte {
    NoChangeofOwnership = 0,
    ChangetoExecutingTrader = 1,
    OwnershipIndicatorMinimumValue = 1,
    OwnershipIndicatorMinimumValue = 0,
};

/// <summary>
///  Party Action Type Values
/// </summary>
public enum PartyActionType : byte {
    HaltTrading = 1,
    Reinstate = 2,
    PartyActionTypeMinimumValue = 2,
    PartyActionTypeMinimumValue = 1,
};

/// <summary>
///  Party Detail Role Qualifier Values
/// </summary>
public enum PartyDetailRoleQualifier : byte {
    Trader = 10,
    HeadTrader = 11,
    Supervisor = 12,
    PartyDetailRoleQualifierMinimumValue = 12,
    PartyDetailRoleQualifierMinimumValue = 10,
};

/// <summary>
///  Party Detail Status Values
/// </summary>
public enum PartyDetailStatus : byte {
    Active = 0,
    Suspend = 1,
    PartyDetailStatusMinimumValue = 1,
    PartyDetailStatusMinimumValue = 0,
};

/// <summary>
///  Party Id Entering Firm Values
/// </summary>
public enum PartyIdEnteringFirm : byte {
    Participant = 1,
    MarketSupervision = 2,
    PartyIdEnteringFirmMinimumValue = 2,
    PartyIdEnteringFirmMinimumValue = 1,
};

/// <summary>
///  Party Id Investment Decision Maker Qualifier Values
/// </summary>
public enum PartyIdInvestmentDecisionMakerQualifier : byte {
    Algo = 22,
    Human = 24,
    PartyIdInvestmentDecisionMakerQualifierMinimumValue = 24,
    PartyIdInvestmentDecisionMakerQualifierMinimumValue = 22,
};

/// <summary>
///  Price Validity Check Type Values
/// </summary>
public enum PriceValidityCheckType : byte {
    None = 0,
    Mandatory = 2,
    PriceValidityCheckTypeMinimumValue = 2,
    PriceValidityCheckTypeMinimumValue = 0,
};

/// <summary>
///  Quote Entry Reject Reason Values
/// </summary>
public enum QuoteEntryRejectReason : uint {
    UnknownSecurity = 1,
    DuplicateQuote = 6,
    InvalidPrice = 8,
    NoReferencePriceAvailable = 16,
    NoSingleSidedQuotes = 100,
    InvalidQuotingModel = 103,
    InvalidSize = 106,
    BidPriceNotReasonable = 108,
    AskPriceNotReasonable = 109,
    BidPriceExceedsRange = 110,
    AskPriceExceedsRange = 111,
    InstrumentStateFreeze = 115,
    DeletionAlreadyPending = 116,
    PreTradeRiskSessionLimitExceeded = 117,
    PreTradeRiskBuLimitExceeded = 118,
    BidValueExceedsLimit = 120,
    AskValueExceedsLimit = 121,
    NotTradeableForBusinessUnit = 122,
    QuantityLimitExceeded = 125,
    ValueLimitExceeded = 126,
    InvalidQuoteSpread = 127,
    CantProcInCurrInstrState = 131,
    PwtQuotenotallowedincurrentstate = 135,
    StandardQuotenotallowedincurrentstate = 136,
    PwtQuotenotallowedwithcrossedbook = 137,
    Asksidequotenotallowed = 138,
    Asksidequotewithqtynotallowed = 139,
    InvalidchangeLPsession = 140,
    OnBookTradingdisabledforInstrumentType = 144,
    LPlicencenotassigned = 145,
    SPlicencenotassigned = 146,
    QuantityLimitExceededInstrument = 149,
    ValueLimitExceededInstrument = 150,
    QuoteEntryRejectReasonMinimumValue = 65535,
    QuoteEntryRejectReasonMinimumValue = 0,
};

/// <summary>
///  Quote Entry Status Values
/// </summary>
public enum QuoteEntryStatus : byte {
    Accepted = 0,
    Rejected = 5,
    RemovedandRejected = 6,
    Pending = 10,
    QuoteEntryStatusMinimumValue = 100,
    QuoteEntryStatusMinimumValue = 0,
};

/// <summary>
///  Quote Event Liquidity Ind Values
/// </summary>
public enum QuoteEventLiquidityInd : byte {
    AddedLiquidity = 1,
    RemovedLiquidity = 2,
    Auction = 4,
    QuoteEventLiquidityIndMinimumValue = 4,
    QuoteEventLiquidityIndMinimumValue = 1,
};

/// <summary>
///  Quote Event Reason Values
/// </summary>
public enum QuoteEventReason : byte {
    Pendingcancellationexecuted = 14,
    Invalidprice = 15,
    Crossrejected = 16,
    QuoteEventReasonMinimumValue = 18,
    QuoteEventReasonMinimumValue = 14,
};

/// <summary>
///  Quote Event Side Values
/// </summary>
public enum QuoteEventSide : byte {
    Buy = 1,
    Sell = 2,
    QuoteEventSideMinimumValue = 2,
    QuoteEventSideMinimumValue = 1,
};

/// <summary>
///  Quote Event Type Values
/// </summary>
public enum QuoteEventType : byte {
    Modifiedquoteside = 2,
    Removedquoteside = 3,
    Partiallyfilled = 4,
    Filled = 5,
    QuoteEventTypeMinimumValue = 5,
    QuoteEventTypeMinimumValue = 0,
};

/// <summary>
///  Quote Size Type Values
/// </summary>
public enum QuoteSizeType : byte {
    TotalSize = 1,
    OpenSize = 2,
    QuoteSizeTypeMinimumValue = 2,
    QuoteSizeTypeMinimumValue = 1,
};

/// <summary>
///  Quote Type Values
/// </summary>
public enum QuoteType : byte {
    Indicative = 0,
    Tradeable = 1,
    TradeableMatching = 101,
    TradeablePwt = 102,
    QuoteTypeMinimumValue = 102,
    QuoteTypeMinimumValue = 0,
};

/// <summary>
///  Ref Appl Id Values
/// </summary>
public enum RefApplId : byte {
    Trade = 1,
    News = 2,
    Serviceavailability = 3,
    Sessiondata = 4,
    Listenerdata = 5,
    RiskControl = 6,
    TesMaintenance = 7,
    TesTrade = 8,
    RefApplIDMinimumValue = 10,
    RefApplIDMinimumValue = 0,
};

/// <summary>
///  Refinancing Eligibility Indicator Values
/// </summary>
public enum RefinancingEligibilityIndicator : byte {
    No = 0,
    Yes = 1,
    RefinancingEligibilityIndicatorMinimumValue = 1,
    RefinancingEligibilityIndicatorMinimumValue = 0,
};

/// <summary>
///  Requesting Party Id Entering Firm Values
/// </summary>
public enum RequestingPartyIdEnteringFirm : byte {
    Participant = 1,
    MarketSupervision = 2,
    RequestingPartyIdEnteringFirmMinimumValue = 2,
    RequestingPartyIdEnteringFirmMinimumValue = 1,
};

/// <summary>
///  Requesting Party Id Executing System Values
/// </summary>
public enum RequestingPartyIdExecutingSystem : uint {
    T7 = 2,
    RequestingPartyIdExecutingSystemMinimumValue = 4294967294,
    RequestingPartyIdExecutingSystemMinimumValue = 0,
};

/// <summary>
///  Rfq Publish Indicator Values
/// </summary>
public enum RfqPublishIndicator : byte {
    MarketData = 1,
    DesignatedSponsor = 2,
    MarketDataandDesignatedSponsor = 3,
    MarketMakerandDesignatedSponsor = 4,
    MarketDataandMarketMakerandDesignatedSponsor = 5,
    RfqPublishIndicatorMinimumValue = 5,
    RfqPublishIndicatorMinimumValue = 1,
};

/// <summary>
///  Rfq Requester Disclosure Instruction Values
/// </summary>
public enum RfqRequesterDisclosureInstruction : byte {
    No = 0,
    Yes = 1,
    RfqRequesterDisclosureInstructionMinimumValue = 1,
    RfqRequesterDisclosureInstructionMinimumValue = 0,
};

/// <summary>
///  Root Party Id Investment Decision Maker Qualifier Values
/// </summary>
public enum RootPartyIdInvestmentDecisionMakerQualifier : byte {
    Algo = 22,
    Human = 24,
    RootPartyIdInvestmentDecisionMakerQualifierMinimumValue = 24,
    RootPartyIdInvestmentDecisionMakerQualifierMinimumValue = 22,
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    Knockedout = 6,
    Knockoutrevoked = 7,
    Knockedoutandsuspend = 12,
    SecurityStatusMinimumValue = 12,
    SecurityStatusMinimumValue = 6,
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    MarketImbalanceBuy = 7,
    MarketImbalanceSell = 8,
    SecurityTradingStatusMinimumValue = 8,
    SecurityTradingStatusMinimumValue = 7,
};

/// <summary>
///  Session Mode Values
/// </summary>
public enum SessionMode : byte {
    Hf = 1,
    Lf = 2,
    Gui = 3,
    SessionModeMinimumValue = 3,
    SessionModeMinimumValue = 1,
};

/// <summary>
///  Session Reject Reason Values
/// </summary>
public enum SessionRejectReason : uint {
    RequiredTagMissing = 1,
    Valueisincorrect = 5,
    Decryptionproblem = 7,
    InvalidMsgId = 11,
    IncorrectNumInGroupcount = 16,
    Other = 99,
    ThrottleLimitExceeded = 100,
    ExposureLimitExceeded = 101,
    ServiceTemporarilyNotAvailable = 102,
    ServiceNotAvailable = 103,
    Outboundconversionerror = 105,
    HeartbeatViolation = 152,
    Internaltechnicalerror = 200,
    ValidationError = 210,
    UserAlreadyLoggedIn = 211,
    SessionGatewayAssignmentExpired = 214,
    GatewayNotReservedToSession = 215,
    GatewayIsStandby = 216,
    SessionLoginLimitReached = 217,
    PartitionNotReachableByHfGateway = 218,
    PartitionNotReachableByPsGateway = 219,
    NoGatewayAvailable = 222,
    UserEntitlementDataTimeout = 223,
    OrderNotFound = 10000,
    PriceNotReasonable = 10001,
    ClientOrderIdNotUnique = 10002,
    QuoteActivationInProgress = 10003,
    BuBookOrderLimitExceeded = 10004,
    SessionBookOrderLimitExceeded = 10005,
    StopBidPriceNotReasonable = 10006,
    StopAskPriceNotReasonable = 10007,
    OrderNotExecutableWithinValidity = 10008,
    InvalidTradingRestrictionForInstrumentState = 10009,
    TransactionNotAllowedInCurrentState = 10011,
    SessionRejectReasonMinimumValue = 4294967294,
    SessionRejectReasonMinimumValue = 0,
};

/// <summary>
///  Session Status Values
/// </summary>
public enum SessionStatus : byte {
    Active = 0,
    Logout = 4,
    SessionStatusMinimumValue = 4,
    SessionStatusMinimumValue = 0,
};

/// <summary>
///  Session Sub Mode Values
/// </summary>
public enum SessionSubMode : byte {
    Regulartradingsession = 0,
    FiXtradingsession = 1,
    RegularBackOfficesession = 2,
    SessionSubModeMinimumValue = 2,
    SessionSubModeMinimumValue = 0,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
    SideMinimumValue = 2,
    SideMinimumValue = 1,
};

/// <summary>
///  Side Liquidity Ind Values
/// </summary>
public enum SideLiquidityInd : byte {
    AddedLiquidity = 1,
    RemovedLiquidity = 2,
    Auction = 4,
    SideLiquidityIndMinimumValue = 4,
    SideLiquidityIndMinimumValue = 1,
};

/// <summary>
///  Sold Out Indicator Values
/// </summary>
public enum SoldOutIndicator : byte {
    Revertsoldout = 0,
    Soldout = 1,
    SoldOutIndicatorMinimumValue = 1,
    SoldOutIndicatorMinimumValue = 0,
};

/// <summary>
///  Stop Px Indicator Values
/// </summary>
public enum StopPxIndicator : byte {
    Donotoverwrite = 0,
    Overwrite = 1,
    StopPxIndicatorMinimumValue = 1,
    StopPxIndicatorMinimumValue = 0,
};

/// <summary>
///  T 7 Entry Service Rtm Status Values
/// </summary>
public enum T7EntryServiceRtmStatus : byte {
    Unavailable = 0,
    Available = 1,
    T7EntryServiceRtmStatusMinimumValue = 1,
    T7EntryServiceRtmStatusMinimumValue = 0,
};

/// <summary>
///  T 7 Entry Service Status Values
/// </summary>
public enum T7EntryServiceStatus : byte {
    Unavailable = 0,
    Available = 1,
    T7EntryServiceStatusMinimumValue = 1,
    T7EntryServiceStatusMinimumValue = 0,
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 0,
    Gtc = 1,
    Ioc = 3,
    Fok = 4,
    Gtx = 5,
    Gtd = 6,
    TimeInForceMinimumValue = 6,
    TimeInForceMinimumValue = 0,
};

/// <summary>
///  Trad Ses Event Values
/// </summary>
public enum TradSesEvent : byte {
    StartofService = 101,
    MarketReset = 102,
    EndofRestatement = 103,
    EndofDayService = 104,
    ServiceResumed = 105,
    TradSesEventMinimumValue = 105,
    TradSesEventMinimumValue = 100,
};

/// <summary>
///  Trad Ses Mode Values
/// </summary>
public enum TradSesMode : byte {
    Testing = 1,
    Simulated = 2,
    Production = 3,
    Acceptance = 4,
    TradSesModeMinimumValue = 4,
    TradSesModeMinimumValue = 1,
};

/// <summary>
///  Trade Alloc Status Values
/// </summary>
public enum TradeAllocStatus : byte {
    Pending = 1,
    Approved = 2,
    AutoApproved = 3,
    Uploaded = 4,
    Canceled = 5,
    TradeAllocStatusMinimumValue = 5,
    TradeAllocStatusMinimumValue = 0,
};

/// <summary>
///  Trade Manager Status Values
/// </summary>
public enum TradeManagerStatus : byte {
    Unavailable = 0,
    Available = 1,
    TradeManagerStatusMinimumValue = 1,
    TradeManagerStatusMinimumValue = 0,
};

/// <summary>
///  Trade Publish Indicator Values
/// </summary>
public enum TradePublishIndicator : byte {
    DeferredPublication = 2,
    Published = 3,
    TradePublishIndicatorMinimumValue = 3,
    TradePublishIndicatorMinimumValue = 0,
};

/// <summary>
///  Trade Report Type Values
/// </summary>
public enum TradeReportType : byte {
    Submit = 0,
    Accept = 2,
    Decline = 3,
    NoWasReplaced = 5,
    TradeReportCancel = 6,
    TradeBreak = 7,
    AllegedNew = 11,
    AllegedNoWas = 13,
    TradeReportTypeMinimumValue = 13,
    TradeReportTypeMinimumValue = 0,
};

/// <summary>
///  Trading Capacity Values
/// </summary>
public enum TradingCapacity : byte {
    Customer = 1,
    Principal = 5,
    MarketMaker = 6,
    SystematicInternaliser = 8,
    RisklessPrincipal = 9,
    TradingCapacityMinimumValue = 9,
    TradingCapacityMinimumValue = 1,
};

/// <summary>
///  Trading Session Sub Id Values
/// </summary>
public enum TradingSessionSubId : byte {
    Openingauction = 2,
    Closingauction = 4,
    IntradayAuction = 6,
    AnyAuction = 8,
    TradingSessionSubIDMinimumValue = 8,
    TradingSessionSubIDMinimumValue = 1,
};

/// <summary>
///  Transfer Reason Values
/// </summary>
public enum TransferReason : byte {
    Owner = 1,
    Clearer = 2,
    TransferReasonMinimumValue = 5,
    TransferReasonMinimumValue = 1,
};

/// <summary>
///  Trd Type Values
/// </summary>
public enum TrdType : ushort {
    Otc = 54,
    Lis = 1005,
    TrdTypeMinimumValue = 1005,
    TrdTypeMinimumValue = 1,
};

/// <summary>
///  Triggered Values
/// </summary>
public enum Triggered : byte {
    Nottriggered = 0,
    TriggeredStop = 1,
    TriggeredOco = 2,
    TriggeredMinimumValue = 2,
    TriggeredMinimumValue = 0,
};

/// <summary>
///  User Status Values
/// </summary>
public enum UserStatus : byte {
    Userforcedlogout = 7,
    Userstopped = 10,
    Userreleased = 11,
    UserStatusMinimumValue = 11,
    UserStatusMinimumValue = 7,
};

/// <summary>
///  Value Check Type Quantity Values
/// </summary>
public enum ValueCheckTypeQuantity : byte {
    Donotcheck = 0,
    Check = 1,
    ValueCheckTypeQuantityMinimumValue = 1,
    ValueCheckTypeQuantityMinimumValue = 0,
};

/// <summary>
///  Value Check Type Value Values
/// </summary>
public enum ValueCheckTypeValue : byte {
    Donotcheck = 0,
    Check = 1,
    ValueCheckTypeValueMinimumValue = 1,
    ValueCheckTypeValueMinimumValue = 0,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Affected Ord Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AffectedOrdGrpComp {
    public ulong AffectedOrderId;
    public ulong AffectedOrigClOrdId;
};

/// <summary>
///  Struct for Approve Tes Trade Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApproveTesTradeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public ulong AllocQty;
    public uint PackageId;
    public uint AllocId;
    public uint TesExecId;
    public int MarketSegmentId;
    public TrdType TrdType;
    public TradingCapacity TradingCapacity;
    public TradeReportType TradeReportType;
    public Side Side;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte TradeReportId[20];
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Best Quote Execution Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestQuoteExecutionReport {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong ExecId;
    public ulong QuoteMsgId;
    public long SecurityId;
    public ulong QuoteEventPx;
    public ulong QuoteEventQty;
    public ulong ReservedSize;
    public int MarketSegmentId;
    public uint QuoteEventMatchId;
    public int QuoteEventExecId;
    public QuoteEventType QuoteEventType;
    public QuoteEventSide QuoteEventSide;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Best Quote Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestQuoteResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong QuoteId;
    public ulong QuoteResponseId;
    public long SecurityId;
    public ulong BidCxlSize;
    public ulong OfferCxlSize;
    public int MarketSegmentId;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Cross Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong OrderQty;
    public int MarketSegmentId;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Cross Request Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossRequestResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong ExecId;
};

/// <summary>
///  Struct for Delete All Order Nr Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllOrderNrResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong MassActionReportId;
};

/// <summary>
///  Struct for Delete All Order Quote Event Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllOrderQuoteEventBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong MassActionReportId;
    public long SecurityId;
    public int MarketSegmentId;
    public MassActionReason MassActionReason;
    public ExecInst ExecInst;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Delete All Order Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllOrderRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong Price;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public uint TargetPartyIdExecutingTrader;
    public Side Side;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Delete All Quote Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllQuoteBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong MassActionReportId;
    public long SecurityId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public uint PartyIdEnteringTrader;
    public uint TargetPartyIdExecutingTrader;
    public ushort NoNotAffectedSecurities;
    public MassActionReason MassActionReason;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public fixed sbyte TargetPartyIdDeskId[3];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Delete All Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllQuoteRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Delete All Quote Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllQuoteResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong MassActionReportId;
    public ushort NoNotAffectedSecurities;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Delete Order Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong CumQty;
    public ulong CxlQty;
    public uint OrderIdSfx;
    public int MarketSegmentId;
    public uint PartyIdEnteringTrader;
    public uint PartyIdSessionId;
    public ExecRestatementReason ExecRestatementReason;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public Side Side;
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Delete Order Nr Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderNrResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong CumQty;
    public ulong CxlQty;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
};

/// <summary>
///  Struct for Delete Order Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong CumQty;
    public ulong CxlQty;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
};

/// <summary>
///  Struct for Delete Order Single Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderSingleRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Delete Tes Trade Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteTesTradeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint PackageId;
    public int MarketSegmentId;
    public uint TesExecId;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public fixed sbyte TradeReportId[20];
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Enrichment Rules Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnrichmentRulesGrpComp {
    public ushort EnrichmentRuleId;
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Enter Best Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnterBestQuoteRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong QuoteId;
    public long SecurityId;
    public ulong BidPx;
    public ulong BidSize;
    public ulong ReservedBidSize;
    public ulong OfferPx;
    public ulong OfferSize;
    public ulong ReservedOfferSize;
    public ulong PegOffsetValueBidPx;
    public ulong PegOffsetValueOfferPx;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public ushort EnrichmentRuleId;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Enter Tes Trade Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnterTesTradeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong LastPx;
    public ulong TransBkdTime;
    public ulong SettlCurrFxRate;
    public int MarketSegmentId;
    public uint SettlDate;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public byte NoSideAllocs;
    public fixed sbyte TradeReportText[20];
    public fixed sbyte TradeReportId[20];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Extended Deletion Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExtendedDeletionReport {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong TrdRegTsEntryTime;
    public ulong Price;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong OrderQty;
    public ulong DisplayQty;
    public ulong DisplayLowQty;
    public ulong DisplayHighQty;
    public ulong StopPx;
    public ulong VolumeDiscoveryPrice;
    public ulong PegOffsetValueAbs;
    public ulong PegOffsetValuePct;
    public int MarketSegmentId;
    public uint OrderIdSfx;
    public uint ExpireDate;
    public uint MatchInstCrossId;
    public uint PartyIdExecutingUnit;
    public uint PartyIdSessionId;
    public uint PartyIdExecutingTrader;
    public uint PartyIdEnteringTrader;
    public ExecRestatementReason ExecRestatementReason;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public Side Side;
    public OrdType OrdType;
    public TradingCapacity TradingCapacity;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public ApplSeqIndicator ApplSeqIndicator;
    public ExDestinationType ExDestinationType;
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed sbyte FixClOrdId[20];
    public Triggered Triggered;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Fills Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FillsGrpComp {
    public ulong FillPx;
    public ulong FillQty;
    public uint FillMatchId;
    public int FillExecId;
    public FillLiquidityInd FillLiquidityInd;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Gateway Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GatewayRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint PartyIdSessionId;
    public ushort PartitionId;
    public fixed sbyte DefaultCstmApplVerId[30];
    public fixed sbyte Password[32];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Heartbeat
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Heartbeat {
    public fixed byte MessageHeaderInComp[0];
};

/// <summary>
///  Struct for Heartbeat Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HeartbeatNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NotifHeaderComp[0];
};

/// <summary>
///  Struct for Inquire Enrichment Rule Id List Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireEnrichmentRuleIdListRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public fixed byte LastEntityProcessed[16];
};

/// <summary>
///  Struct for Inquire Enrichment Rule Id List Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireEnrichmentRuleIdListResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public fixed byte LastEntityProcessed[16];
    public ushort NoEnrichmentRules;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Inquire Session List Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireSessionListRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
};

/// <summary>
///  Struct for Inquire Session List Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireSessionListResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public ushort NoSessions;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Inquire User Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireUserRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public fixed byte LastEntityProcessed[16];
};

/// <summary>
///  Struct for Inquire User Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireUserResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public fixed byte LastEntityProcessed[16];
    public ushort NoPartyDetails;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Issuer Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IssuerNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public long SecurityId;
    public ulong TransactTime;
    public ulong LastPx;
    public ulong PotentialExecVolume;
    public ulong LastQty;
    public ulong ImbalanceQty;
    public int MarketSegmentId;
    public uint PartyIdSessionId;
    public SecurityTradingStatus SecurityTradingStatus;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Issuer Security State Change Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IssuerSecurityStateChangeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong TransactTime;
    public int MarketSegmentId;
    public byte NoEvents;
    public SecurityStatus SecurityStatus;
    public SoldOutIndicator SoldOutIndicator;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Issuer Security State Change Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IssuerSecurityStateChangeResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong SecurityStatusReportId;
};

/// <summary>
///  Struct for Logon Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint HeartBtInt;
    public uint PartyIdSessionId;
    public fixed sbyte DefaultCstmApplVerId[30];
    public fixed sbyte Password[32];
    public ApplUsageOrders ApplUsageOrders;
    public ApplUsageQuotes ApplUsageQuotes;
    public OrderRoutingIndicator OrderRoutingIndicator;
    public fixed sbyte FixEngineName[30];
    public fixed sbyte FixEngineVersion[30];
    public fixed sbyte FixEngineVendor[30];
    public fixed sbyte ApplicationSystemName[30];
    public fixed sbyte ApplicationSystemVersion[30];
    public fixed sbyte ApplicationSystemVendor[30];
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Logon Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public long ThrottleTimeInterval;
    public uint ThrottleNoMsgs;
    public uint ThrottleDisconnectLimit;
    public uint HeartBtInt;
    public uint SessionInstanceId;
    public MarketId MarketId;
    public TradSesMode TradSesMode;
    public fixed sbyte DefaultCstmApplVerId[30];
    public fixed sbyte DefaultCstmApplVerSubId[5];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Logout Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
};

/// <summary>
///  Struct for Logout Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
};

/// <summary>
///  Struct for Mass Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong QuoteId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint MatchInstCrossId;
    public ushort EnrichmentRuleId;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public QuoteSizeType QuoteSizeType;
    public QuoteType QuoteType;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public byte NoQuoteEntries;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Mass Quote Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong QuoteId;
    public ulong QuoteResponseId;
    public int MarketSegmentId;
    public byte NoQuoteEntries;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Message Header In Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeaderInComp {
    public uint BodyLen;
    public ushort TemplateId;
    public fixed sbyte NetworkMsgId[8];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Message Header Out Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeaderOutComp {
    public uint BodyLen;
    public ushort TemplateId;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Modify Order Nr Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderNrResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong StopPx;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong DisplayQty;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public CrossedIndicator CrossedIndicator;
    public Triggered Triggered;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Modify Order Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong StopPx;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong DisplayQty;
    public ulong TrdRegTsTimePriority;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public CrossedIndicator CrossedIndicator;
    public Triggered Triggered;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Modify Order Single Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderSingleRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong Price;
    public ulong OrderQty;
    public ulong DisplayQty;
    public ulong DisplayLowQty;
    public ulong DisplayHighQty;
    public ulong StopPx;
    public ulong VolumeDiscoveryPrice;
    public ulong PegOffsetValueAbs;
    public ulong PegOffsetValuePct;
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint MatchInstCrossId;
    public uint TargetPartyIdSessionId;
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public StopPxIndicator StopPxIndicator;
    public TradingCapacity TradingCapacity;
    public ExDestinationType ExDestinationType;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public OwnershipIndicator OwnershipIndicator;
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Modify Order Single Short Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderSingleShortRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong Price;
    public ulong OrderQty;
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public uint MatchInstCrossId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ApplSeqIndicator ApplSeqIndicator;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public ExDestinationType ExDestinationType;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Modify Tes Trade Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyTesTradeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong LastPx;
    public ulong TransBkdTime;
    public int MarketSegmentId;
    public uint PackageId;
    public uint TesExecId;
    public uint SettlDate;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public byte NoSideAllocs;
    public fixed sbyte TradeReportText[20];
    public fixed sbyte TradeReportId[20];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for New Order Nr Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderNrResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public CrossedIndicator CrossedIndicator;
    public Triggered Triggered;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for New Order Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong TrdRegTsEntryTime;
    public ulong TrdRegTsTimePriority;
    public uint OrderIdSfx;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public CrossedIndicator CrossedIndicator;
    public Triggered Triggered;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for New Order Single Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingleRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong Price;
    public ulong OrderQty;
    public ulong DisplayQty;
    public ulong DisplayLowQty;
    public ulong DisplayHighQty;
    public ulong StopPx;
    public ulong VolumeDiscoveryPrice;
    public ulong PegOffsetValueAbs;
    public ulong PegOffsetValuePct;
    public ulong ClOrdId;
    public long SecurityId;
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint MatchInstCrossId;
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public TradingCapacity TradingCapacity;
    public ExDestinationType ExDestinationType;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for New Order Single Short Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingleShortRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong Price;
    public ulong OrderQty;
    public ulong ClOrdId;
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public uint MatchInstCrossId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public ApplSeqIndicator ApplSeqIndicator;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public ExDestinationType ExDestinationType;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Not Affected Orders Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotAffectedOrdersGrpComp {
    public ulong NotAffectedOrderId;
    public ulong NotAffOrigClOrdId;
};

/// <summary>
///  Struct for Not Affected Securities Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotAffectedSecuritiesGrpComp {
    public ulong NotAffectedSecurityId;
};

/// <summary>
///  Struct for Notif Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotifHeaderComp {
    public ulong SendingTime;
};

/// <summary>
///  Struct for Nr Response Header Me Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NrResponseHeaderMeComp {
    public ulong RequestTime;
    public ulong TrdRegTsTimeIn;
    public ulong TrdRegTsTimeOut;
    public ulong ResponseIn;
    public ulong SendingTime;
    public uint MsgSeqNum;
    public LastFragment LastFragment;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Nrbc Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NrbcHeaderComp {
    public ulong SendingTime;
    public uint ApplSubId;
    public ApplId ApplId;
    public LastFragment LastFragment;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Order Exec Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong DisplayQty;
    public int MarketSegmentId;
    public uint OrderIdSfx;
    public ExecRestatementReason ExecRestatementReason;
    public Side Side;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public MatchType MatchType;
    public Triggered Triggered;
    public CrossedIndicator CrossedIndicator;
    public fixed sbyte FixClOrdId[20];
    public byte NoFills;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Order Exec Report Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecReportBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong TrdRegTsEntryTime;
    public ulong TrdRegTsTimePriority;
    public ulong Price;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong OrderQty;
    public ulong DisplayQty;
    public ulong DisplayLowQty;
    public ulong DisplayHighQty;
    public ulong StopPx;
    public ulong VolumeDiscoveryPrice;
    public ulong PegOffsetValueAbs;
    public ulong PegOffsetValuePct;
    public int MarketSegmentId;
    public uint OrderIdSfx;
    public uint ExpireDate;
    public uint MatchInstCrossId;
    public uint PartyIdExecutingUnit;
    public uint PartyIdSessionId;
    public uint PartyIdExecutingTrader;
    public uint PartyIdEnteringTrader;
    public ExecRestatementReason ExecRestatementReason;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public MatchType MatchType;
    public Side Side;
    public OrdType OrdType;
    public TradingCapacity TradingCapacity;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public ApplSeqIndicator ApplSeqIndicator;
    public ExDestinationType ExDestinationType;
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed sbyte FixClOrdId[20];
    public byte NoFills;
    public Triggered Triggered;
    public CrossedIndicator CrossedIndicator;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Order Exec Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong TrdRegTsEntryTime;
    public ulong TrdRegTsTimePriority;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong CxlQty;
    public ulong DisplayQty;
    public int MarketSegmentId;
    public uint OrderIdSfx;
    public ExecRestatementReason ExecRestatementReason;
    public Side Side;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public MatchType MatchType;
    public Triggered Triggered;
    public CrossedIndicator CrossedIndicator;
    public byte NoFills;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Party Action Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyActionReport {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public uint TradeDate;
    public uint RequestingPartyIdExecutingTrader;
    public uint PartyIdExecutingUnit;
    public uint PartyIdExecutingTrader;
    public RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
    public MarketId MarketId;
    public PartyActionType PartyActionType;
    public RequestingPartyIdEnteringFirm RequestingPartyIdEnteringFirm;
};

/// <summary>
///  Struct for Party Details Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyDetailsGrpComp {
    public uint PartyDetailIdExecutingTrader;
    public fixed sbyte PartyDetailExecutingTrader[6];
    public PartyDetailRoleQualifier PartyDetailRoleQualifier;
    public PartyDetailStatus PartyDetailStatus;
    public fixed sbyte PartyDetailDeskId[3];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Party Entitlements Update Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyEntitlementsUpdateReport {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public uint TradeDate;
    public uint PartyDetailIdExecutingUnit;
    public RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
    public MarketId MarketId;
    public ListUpdateAction ListUpdateAction;
    public fixed sbyte RequestingPartyEnteringFirm[9];
    public fixed sbyte RequestingPartyClearingFirm[9];
    public PartyDetailStatus PartyDetailStatus;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Quote Activation Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteActivationNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong MassActionReportId;
    public int MarketSegmentId;
    public uint PartyIdEnteringTrader;
    public ushort NoNotAffectedSecurities;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public MassActionType MassActionType;
    public MassActionReason MassActionReason;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Quote Activation Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteActivationRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public MassActionType MassActionType;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Quote Activation Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteActivationResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong MassActionReportId;
    public ushort NoNotAffectedSecurities;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Quote Entry Ack Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteEntryAckGrpComp {
    public long SecurityId;
    public ulong BidCxlSize;
    public ulong OfferCxlSize;
    public QuoteEntryRejectReason QuoteEntryRejectReason;
    public QuoteEntryStatus QuoteEntryStatus;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Quote Entry Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteEntryGrpComp {
    public long SecurityId;
    public ulong BidPx;
    public ulong BidSize;
    public ulong OfferPx;
    public ulong OfferSize;
};

/// <summary>
///  Struct for Quote Event Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteEventGrpComp {
    public long SecurityId;
    public ulong QuoteEventPx;
    public ulong QuoteEventQty;
    public ulong QuoteMsgId;
    public uint QuoteEventMatchId;
    public int QuoteEventExecId;
    public QuoteEventType QuoteEventType;
    public QuoteEventSide QuoteEventSide;
    public QuoteEventLiquidityInd QuoteEventLiquidityInd;
    public QuoteEventReason QuoteEventReason;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Quote Execution Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteExecutionReport {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong ExecId;
    public int MarketSegmentId;
    public byte NoQuoteEvents;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Rbc Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RbcHeaderComp {
    public ulong SendingTime;
    public ulong ApplSeqNum;
    public uint ApplSubId;
    public ushort PartitionId;
    public ApplResendFlag ApplResendFlag;
    public ApplId ApplId;
    public LastFragment LastFragment;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Rbc Header Me Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RbcHeaderMeComp {
    public ulong TrdRegTsTimeOut;
    public ulong NotificationIn;
    public ulong SendingTime;
    public uint ApplSubId;
    public ushort PartitionId;
    public fixed byte ApplMsgId[16];
    public ApplId ApplId;
    public ApplResendFlag ApplResendFlag;
    public LastFragment LastFragment;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Request Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestHeaderComp {
    public uint MsgSeqNum;
    public uint SenderSubId;
};

/// <summary>
///  Struct for Response Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResponseHeaderComp {
    public ulong RequestTime;
    public ulong SendingTime;
    public uint MsgSeqNum;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Response Header Me Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResponseHeaderMeComp {
    public ulong RequestTime;
    public ulong TrdRegTsTimeIn;
    public ulong TrdRegTsTimeOut;
    public ulong ResponseIn;
    public ulong SendingTime;
    public uint MsgSeqNum;
    public ushort PartitionId;
    public ApplId ApplId;
    public fixed byte ApplMsgId[16];
    public LastFragment LastFragment;
};

/// <summary>
///  Struct for Retransmit Me Message Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitMeMessageRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint SubscriptionScope;
    public ushort PartitionId;
    public RefApplId RefApplId;
    public fixed byte ApplBegMsgId[16];
    public fixed byte ApplEndMsgId[16];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Retransmit Me Message Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitMeMessageResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public ushort ApplTotalMessageCount;
    public fixed byte ApplEndMsgId[16];
    public fixed byte RefApplLastMsgId[16];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Retransmit Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong ApplBegSeqNum;
    public ulong ApplEndSeqNum;
    public ushort PartitionId;
    public RefApplId RefApplId;
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Retransmit Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public ulong ApplEndSeqNum;
    public ulong RefApplLastSeqNum;
    public ushort ApplTotalMessageCount;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Rfq Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public long SecurityId;
    public ulong ExecId;
    public ulong OrderQty;
    public int MarketSegmentId;
    public Side Side;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Rfq Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong OrderQty;
    public int MarketSegmentId;
    public RfqPublishIndicator RfqPublishIndicator;
    public RfqRequesterDisclosureInstruction RfqRequesterDisclosureInstruction;
    public Side Side;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Rfq Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong ExecId;
};

/// <summary>
///  Struct for Security Status Event Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusEventGrpComp {
    public ulong EventPx;
    public uint EventDate;
    public EventType EventType;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Service Availability Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ServiceAvailabilityBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrbcHeaderComp[0];
    public uint MatchingEngineTradeDate;
    public uint TradeManagerTradeDate;
    public uint ApplSeqTradeDate;
    public uint T7EntryServiceTradeDate;
    public uint T7EntryServiceRtmTradeDate;
    public ushort PartitionId;
    public MatchingEngineStatus MatchingEngineStatus;
    public TradeManagerStatus TradeManagerStatus;
    public ApplSeqStatus ApplSeqStatus;
    public T7EntryServiceStatus T7EntryServiceStatus;
    public T7EntryServiceRtmStatus T7EntryServiceRtmStatus;
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Sessions Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SessionsGrpComp {
    public uint PartyIdSessionId;
    public SessionMode SessionMode;
    public SessionSubMode SessionSubMode;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Side Alloc Grp Bc Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SideAllocGrpBcComp {
    public ulong AllocQty;
    public uint IndividualAllocId;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public Side Side;
    public TradeAllocStatus TradeAllocStatus;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Side Alloc Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SideAllocGrpComp {
    public ulong AllocQty;
    public uint IndividualAllocId;
    public Side Side;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
};

/// <summary>
///  Struct for Subscribe Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SubscribeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint SubscriptionScope;
    public RefApplId RefApplId;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Subscribe Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SubscribeResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public uint ApplSubId;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Tes Approve Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesApproveBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public long SecurityId;
    public ulong LastPx;
    public ulong AllocQty;
    public ulong TransactTime;
    public ulong TransBkdTime;
    public ulong SettlCurrFxRate;
    public int MarketSegmentId;
    public uint PackageId;
    public uint TesExecId;
    public uint AllocId;
    public uint SettlDate;
    public TrdType TrdType;
    public Side Side;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public ValueCheckTypeQuantity ValueCheckTypeQuantity;
    public TradeReportType TradeReportType;
    public TradingCapacity TradingCapacity;
    public TradeAllocStatus TradeAllocStatus;
    public MessageEventSource MessageEventSource;
    public fixed sbyte TradeReportId[20];
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public fixed sbyte PartyEnteringTrader[6];
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Tes Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public long SecurityId;
    public ulong LastPx;
    public ulong TransactTime;
    public ulong TransBkdTime;
    public ulong SettlCurrFxRate;
    public int MarketSegmentId;
    public uint PackageId;
    public uint TesExecId;
    public uint SettlDate;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public byte NoSideAllocs;
    public MessageEventSource MessageEventSource;
    public fixed sbyte TradeReportText[20];
    public fixed sbyte TradeReportId[20];
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
};

/// <summary>
///  Struct for Tes Delete Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesDeleteBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public int MarketSegmentId;
    public uint PackageId;
    public uint TesExecId;
    public TrdType TrdType;
    public DeleteReason DeleteReason;
    public TradeReportType TradeReportType;
    public MessageEventSource MessageEventSource;
    public fixed sbyte TradeReportId[20];
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Tes Execution Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesExecutionBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public int MarketSegmentId;
    public uint PackageId;
    public uint TesExecId;
    public uint AllocId;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public Side Side;
    public MessageEventSource MessageEventSource;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Tes Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public uint TesExecId;
    public fixed sbyte TradeReportId[20];
};

/// <summary>
///  Struct for Tes Trade Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesTradeBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public long SecurityId;
    public ulong LastPx;
    public ulong LastQty;
    public ulong TransactTime;
    public ulong SettlCurrAmt;
    public ulong SideGrossTradeAmt;
    public ulong SettlCurrFxRate;
    public ulong AccruedInteresAmt;
    public ulong CouponRate;
    public ulong RootPartyIdClientId;
    public ulong ExecutingTrader;
    public ulong RootPartyIdInvestmentDecisionMaker;
    public uint PackageId;
    public int MarketSegmentId;
    public uint TradeId;
    public uint TradeDate;
    public uint SideTradeId;
    public uint RootPartyIdSessionId;
    public uint RootPartyIdSettlementUnit;
    public uint RootPartyIdContraUnit;
    public uint RootPartyIdContraSettlementUnit;
    public uint OrigTradeId;
    public uint RootPartyIdExecutingUnit;
    public uint RootPartyIdExecutingTrader;
    public uint RootPartyIdClearingUnit;
    public uint SettlDate;
    public uint NumDaysInterest;
    public TrdType TrdType;
    public LastMkt LastMkt;
    public Side Side;
    public TradingCapacity TradingCapacity;
    public TradeReportType TradeReportType;
    public TransferReason TransferReason;
    public TradePublishIndicator TradePublishIndicator;
    public LastCouponDeviationIndicator LastCouponDeviationIndicator;
    public RefinancingEligibilityIndicator RefinancingEligibilityIndicator;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public RootPartyIdInvestmentDecisionMakerQualifier RootPartyIdInvestmentDecisionMakerQualifier;
    public fixed sbyte Account[2];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public fixed sbyte SettlCurrency[3];
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyClearingFirm[5];
    public fixed sbyte RootPartyClearingOrganization[4];
    public fixed sbyte RootPartyExecutingFirmKvNumber[4];
    public fixed sbyte RootPartySettlementAccount[35];
    public fixed sbyte RootPartySettlementLocation[3];
    public fixed sbyte RootPartySettlementFirm[5];
    public fixed sbyte RootPartyContraFirm[5];
    public fixed sbyte RootPartyContraSettlementFirm[5];
    public fixed sbyte RootPartyContraFirmKvNumber[4];
    public fixed sbyte RootPartyContraSettlementAccount[35];
    public fixed sbyte RootPartyContraSettlementLocation[3];
    public fixed sbyte RegulatoryTradeId[52];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Tes Trading Session Status Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TesTradingSessionStatusBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public uint TradeDate;
    public TradSesEvent TradSesEvent;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Throttle Update Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ThrottleUpdateNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NotifHeaderComp[0];
    public long ThrottleTimeInterval;
    public uint ThrottleNoMsgs;
    public uint ThrottleDisconnectLimit;
};

/// <summary>
///  Struct for Tm Trading Session Status Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TmTradingSessionStatusBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public TradSesEvent TradSesEvent;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Trade Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public long SecurityId;
    public ulong Price;
    public ulong LastPx;
    public ulong LastQty;
    public ulong SettlCurrAmt;
    public ulong SettlCurrFxRate;
    public ulong TransactTime;
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong LeavesQty;
    public ulong CumQty;
    public ulong SideGrossTradeAmt;
    public ulong AccruedInteresAmt;
    public ulong CouponRate;
    public ulong RootPartyIdClientId;
    public ulong ExecutingTrader;
    public ulong RootPartyIdInvestmentDecisionMaker;
    public uint TradeId;
    public uint OrigTradeId;
    public uint RootPartyIdExecutingUnit;
    public uint RootPartyIdSessionId;
    public uint RootPartyIdExecutingTrader;
    public uint RootPartyIdSettlementUnit;
    public uint RootPartyIdClearingUnit;
    public uint RootPartyIdContraUnit;
    public uint RootPartyIdContraSettlementUnit;
    public uint OrderIdSfx;
    public int MarketSegmentId;
    public uint SideTradeId;
    public uint SideTradeReportId;
    public uint TradeNumber;
    public uint MatchDate;
    public uint SettlDate;
    public uint TrdMatchId;
    public uint NumDaysInterest;
    public LastMkt LastMkt;
    public TradeReportType TradeReportType;
    public TransferReason TransferReason;
    public MatchType MatchType;
    public MatchSubType MatchSubType;
    public Side Side;
    public SideLiquidityInd SideLiquidityInd;
    public DeliveryType DeliveryType;
    public TradingCapacity TradingCapacity;
    public LastCouponDeviationIndicator LastCouponDeviationIndicator;
    public RefinancingEligibilityIndicator RefinancingEligibilityIndicator;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public RootPartyIdInvestmentDecisionMakerQualifier RootPartyIdInvestmentDecisionMakerQualifier;
    public fixed sbyte Account[2];
    public fixed sbyte SettlCurrency[3];
    public fixed sbyte Currency[3];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText4[16];
    public OrderCategory OrderCategory;
    public OrdType OrdType;
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyClearingFirm[5];
    public fixed sbyte RootPartyExecutingFirmKvNumber[4];
    public fixed sbyte RootPartySettlementAccount[35];
    public fixed sbyte RootPartySettlementLocation[3];
    public fixed sbyte RootPartySettlementFirm[5];
    public fixed sbyte RootPartyContraFirm[5];
    public fixed sbyte RootPartyContraSettlementFirm[5];
    public fixed sbyte RootPartyContraFirmKvNumber[4];
    public fixed sbyte RootPartyContraSettlementAccount[35];
    public fixed sbyte RootPartyContraSettlementLocation[3];
    public fixed sbyte RegulatoryTradeId[52];
};

/// <summary>
///  Struct for Trading Session Status Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionStatusBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public int MarketSegmentId;
    public uint TradeDate;
    public TradSesEvent TradSesEvent;
    public fixed byte RefApplLastMsgId[16];
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Trailing Stop Update Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TrailingStopUpdateNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ExecId;
    public ulong StopPx;
    public ulong OrderQty;
    public uint OrderIdSfx;
    public int MarketSegmentId;
    public ExecRestatementReason ExecRestatementReason;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public Side Side;
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Unsubscribe Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsubscribeRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint RefApplSubId;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Unsubscribe Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsubscribeResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
};

/// <summary>
///  Struct for User Login Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserLoginRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint Username;
    public fixed sbyte Password[32];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for User Login Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserLoginResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
};

/// <summary>
///  Struct for User Logout Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserLogoutRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint Username;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for User Logout Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserLogoutResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
};

