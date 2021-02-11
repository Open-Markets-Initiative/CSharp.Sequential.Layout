// C# Structs For Eurex Derivatives T7 Eti 2.5 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Indicator Values
/// </summary>
public enum AggressorIndicator : byte {
    Passive = 0,
    Agressor = 1,
    AggressorIndicatorMinimumValue = 1,
    AggressorIndicatorMinimumValue = 0,
};

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
    ApplIDMinimumValue = 6,
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
    OrderBookRestatement = 001,
    OrderAdded = 101,
    OrderModified = 102,
    OrderCancelled = 103,
    IocOrderCancelled = 105,
    BookOrderExecuted = 108,
    MarketOrderTriggered = 135,
    CaoOrderActivated = 149,
    CaoOrderInactivated = 150,
    OcoOrderTriggered = 164,
    StopOrderTriggered = 172,
    OwnershipChanged = 181,
    OrderCancellationPending = 197,
    PendingCancellationExecuted = 199,
    BocOrderCancelled = 212,
    ExecRestatementReasonMinimumValue = 299,
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
///  Fill Liquidity Ind Values
/// </summary>
public enum FillLiquidityInd : byte {
    AddedLiquidity = 1,
    RemovedLiquidity = 2,
    TriggeredStopOrder = 5,
    TriggeredOcoOrder = 6,
    TriggeredMarketOrder = 7,
    FillLiquidityIndMinimumValue = 7,
    FillLiquidityIndMinimumValue = 1,
};

/// <summary>
///  Implied Market Indicator Values
/// </summary>
public enum ImpliedMarketIndicator : byte {
    Notimplied = 0,
    Impliedinout = 3,
    ImpliedMarketIndicatorMinimumValue = 3,
    ImpliedMarketIndicatorMinimumValue = 0,
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
///  Leg Position Effect Values
/// </summary>
public enum LegPositionEffect : byte {
    Close = (byte)'C',
    Open = (byte)'O',
};

/// <summary>
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    MultilegInstrument = 1,
    UnderlyingLeg = 2,
    LegSecurityTypeMinimumValue = 2,
    LegSecurityTypeMinimumValue = 1,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = 1,
    Sell = 2,
    LegSideMinimumValue = 2,
    LegSideMinimumValue = 1,
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
    Xeur = 1,
    Xeee = 2,
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
    MarketMakerProtection = 3,
    SessionLoss = 6,
    DuplicateSessionLogin = 7,
    ClearingRiskControl = 8,
    ProductStateHalt = 105,
    ProductStateHoliday = 106,
    InstrumentSuspended = 107,
    ComplexInstrumentDeletion = 109,
    VolatilityInterruption = 110,
    Producttemporarilynottradeable = 111,
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
    MatchSubTypeMinimumValue = 4,
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
    Automatchresting = 11,
    MatchTypeMinimumValue = 12,
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
///  Multi Leg Reporting Type Values
/// </summary>
public enum MultiLegReportingType : byte {
    Singlesecurity = 1,
    Individuallegofamultilegsecurity = 2,
    MultiLegReportingTypeMinimumValue = 2,
    MultiLegReportingTypeMinimumValue = 1,
};

/// <summary>
///  Multileg Model Values
/// </summary>
public enum MultilegModel : byte {
    PredefinedMultilegSecurity = 0,
    UserdefinedMultleg = 1,
    MultilegModelMinimumValue = 1,
    MultilegModelMinimumValue = 0,
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
///  Order Side Values
/// </summary>
public enum OrderSide : byte {
    Buy = 1,
    Sell = 2,
    OrderSideMinimumValue = 2,
    OrderSideMinimumValue = 1,
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
///  Party Id Origination Market Values
/// </summary>
public enum PartyIdOriginationMarket : byte {
    Xkfe = 1,
    Xtaf = 2,
    PartyIdOriginationMarketMinimumValue = 2,
    PartyIdOriginationMarketMinimumValue = 1,
};

/// <summary>
///  Position Effect Values
/// </summary>
public enum PositionEffect : byte {
    Close = (byte)'C',
    Open = (byte)'O',
};

/// <summary>
///  Price Validity Check Type Values
/// </summary>
public enum PriceValidityCheckType : byte {
    None = 0,
    Optional = 1,
    Mandatory = 2,
    PriceValidityCheckTypeMinimumValue = 2,
    PriceValidityCheckTypeMinimumValue = 0,
};

/// <summary>
///  Product Complex Values
/// </summary>
public enum ProductComplex : byte {
    Simpleinstrument = 1,
    Standardoptionstrategy = 2,
    Nonstandardoptionstrategy = 3,
    Volatilitystrategy = 4,
    FuturesSpread = 5,
    Interproductspread = 6,
    Standardfuturestrategy = 7,
    Packandbundle = 8,
    Strip = 9,
    ProductComplexMinimumValue = 9,
    ProductComplexMinimumValue = 1,
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
    InvalidUnderlyingPrice = 107,
    BidPriceNotReasonable = 108,
    AskPriceNotReasonable = 109,
    BidPriceExceedsRange = 110,
    AskPriceExceedsRange = 111,
    InstrumentStateFreeze = 115,
    DeletionAlreadyPending = 116,
    PreTradeRiskSessionLimitExceeded = 117,
    PreTradeRiskBuLimitExceeded = 118,
    EntitlementNotAssignedForUnderlying = 119,
    CantProcInCurrInstrState = 131,
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
    QuoteEventLiquidityIndMinimumValue = 2,
    QuoteEventLiquidityIndMinimumValue = 1,
};

/// <summary>
///  Quote Event Reason Values
/// </summary>
public enum QuoteEventReason : byte {
    Pendingcancellationexecuted = 14,
    Invalidprice = 15,
    QuoteEventReasonMinimumValue = 15,
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
///  Ref Appl Id Values
/// </summary>
public enum RefApplId : byte {
    Trade = 1,
    News = 2,
    Serviceavailability = 3,
    Sessiondata = 4,
    Listenerdata = 5,
    RiskControl = 6,
    RefApplIDMinimumValue = 6,
    RefApplIDMinimumValue = 0,
};

/// <summary>
///  Related Product Complex Values
/// </summary>
public enum RelatedProductComplex : byte {
    Standardoptionstrategy = 2,
    Nonstandardoptionstrategy = 3,
    Volatilitystrategy = 4,
    FuturesSpread = 5,
    Interproductspread = 6,
    Standardfuturestrategy = 7,
    Packandbundle = 8,
    Strip = 9,
    RelatedProductComplexMinimumValue = 9,
    RelatedProductComplexMinimumValue = 1,
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
    EurexClearing = 1,
    EurexTrading = 2,
    RequestingPartyIdExecutingSystemMinimumValue = 4294967294,
    RequestingPartyIdExecutingSystemMinimumValue = 0,
};

/// <summary>
///  Risk Limit Action Values
/// </summary>
public enum RiskLimitAction : byte {
    Warning = 4,
    QueueInbound = 0,
    Reject = 2,
    RiskLimitActionMinimumValue = 4,
    RiskLimitActionMinimumValue = 0,
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
    ResultOfTransactionUnknown = 104,
    Outboundconversionerror = 105,
    HeartbeatViolation = 152,
    Internaltechnicalerror = 200,
    ValidationError = 210,
    UserAlreadyLoggedIn = 211,
    OrderNotFound = 10000,
    PriceNotReasonable = 10001,
    ClientOrderIdNotUnique = 10002,
    QuoteActivationInProgress = 10003,
    BuBookOrderLimitExceeded = 10004,
    SessionBookOrderLimitExceeded = 10005,
    CreateCiThrottleExceeded = 10010,
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
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 0,
    Gtc = 1,
    Ioc = 3,
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
///  Trade Manager Status Values
/// </summary>
public enum TradeManagerStatus : byte {
    Unavailable = 0,
    Available = 1,
    TradeManagerStatusMinimumValue = 1,
    TradeManagerStatusMinimumValue = 0,
};

/// <summary>
///  Trade Report Type Values
/// </summary>
public enum TradeReportType : byte {
    Submit = 0,
    Alleged = 1,
    NoWasReplaced = 5,
    TradeBreak = 7,
    TradeReportTypeMinimumValue = 7,
    TradeReportTypeMinimumValue = 0,
};

/// <summary>
///  Trading Capacity Values
/// </summary>
public enum TradingCapacity : byte {
    Customer = 1,
    Principal = 5,
    MarketMaker = 6,
    TradingCapacityMinimumValue = 6,
    TradingCapacityMinimumValue = 1,
};

/// <summary>
///  Trading Session Sub Id Values
/// </summary>
public enum TradingSessionSubId : byte {
    Closingauction = 4,
    TradingSessionSubIDMinimumValue = 7,
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
    Userstopped = 10,
    Userreleased = 11,
    UserStatusMinimumValue = 11,
    UserStatusMinimumValue = 10,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Complex Instrument Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddComplexInstrumentRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong ComplianceId;
    public int MarketSegmentId;
    public int SecuritySubType;
    public ProductComplex ProductComplex;
    public byte NoLegs;
    public fixed sbyte ComplianceText[20];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Add Complex Instrument Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddComplexInstrumentResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong LowLimitPrice;
    public ulong HighLimitPrice;
    public long SecurityId;
    public ulong LastUpdateTime;
    public ulong SecurityResponseId;
    public int MarketSegmentId;
    public int NumberOfSecurities;
    public int SecuritySubType;
    public MultilegModel MultilegModel;
    public ImpliedMarketIndicator ImpliedMarketIndicator;
    public ProductComplex ProductComplex;
    public byte NoLegs;
};

/// <summary>
///  Struct for Cross Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong ComplianceId;
    public int MarketSegmentId;
    public int OrderQty;
    public fixed sbyte ComplianceText[20];
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
///  Struct for Delete All Order Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllOrderBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderMeComp[0];
    public ulong MassActionReportId;
    public long SecurityId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public uint TargetPartyIdExecutingTrader;
    public uint PartyIdEnteringTrader;
    public ushort NoNotAffectedOrders;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public MassActionReason MassActionReason;
    public ExecInst ExecInst;
    public fixed byte Pad3[3];
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
    public ulong ComplianceId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public uint TargetPartyIdExecutingTrader;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Delete All Order Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteAllOrderResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderMeComp[0];
    public ulong MassActionReportId;
    public ushort NoNotAffectedOrders;
    public fixed byte Pad6[6];
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
    public ulong ComplianceId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
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
    public int CumQty;
    public int CxlQty;
    public int MarketSegmentId;
    public uint PartyIdEnteringTrader;
    public ExecRestatementReason ExecRestatementReason;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ProductComplex ProductComplex;
    public Side Side;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Delete Order Complex Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderComplexRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong ComplianceId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
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
    public int CumQty;
    public int CxlQty;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad3[3];
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
    public int CumQty;
    public int CxlQty;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad3[3];
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
    public ulong ComplianceId;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public uint TargetPartyIdSessionId;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Enrichment Rules Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnrichmentRulesGrpComp {
    public ushort EnrichmentRuleId;
    public PartyIdOriginationMarket PartyIdOriginationMarket;
    public fixed sbyte Account[2];
    public PositionEffect PositionEffect;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Fills Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FillsGrpComp {
    public ulong FillPx;
    public int FillQty;
    public uint FillMatchId;
    public int FillExecId;
    public FillLiquidityInd FillLiquidityInd;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Gateway Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GatewayRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public uint PartyIdSessionId;
    public fixed sbyte DefaultCstmApplVerId[30];
    public fixed sbyte Password[32];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Gateway Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GatewayResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public uint GatewayId;
    public uint GatewaySubId;
    public uint SecondaryGatewayId;
    public uint SecondaryGatewaySubId;
    public SessionMode SessionMode;
    public TradSesMode TradSesMode;
    public fixed byte Pad6[6];
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
///  Struct for Inquire Mm Parameter Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireMmParameterRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
};

/// <summary>
///  Struct for Inquire Mm Parameter Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InquireMmParameterResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong MmParameterReportId;
    public int MarketSegmentId;
    public byte NoMmParameters;
    public fixed byte Pad3[3];
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
///  Struct for Instrmnt Leg Exec Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrmntLegExecGrpComp {
    public long LegSecurityId;
    public ulong LegLastPx;
    public int LegLastQty;
    public int LegExecId;
    public LegSide LegSide;
    public byte NoFillsIndex;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Instrmt Leg Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrmtLegGrpComp {
    public long LegSecurityId;
    public ulong LegPrice;
    public int LegSymbol;
    public uint LegRatioQty;
    public LegSide LegSide;
    public LegSecurityType LegSecurityType;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Leg Ord Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegOrdGrpComp {
    public fixed sbyte LegAccount[2];
    public LegPositionEffect LegPositionEffect;
    public fixed byte Pad5[5];
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
    public TradSesMode TradSesMode;
    public fixed sbyte DefaultCstmApplVerId[30];
    public fixed byte Pad1[1];
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
    public ulong ComplianceId;
    public int MarketSegmentId;
    public ushort EnrichmentRuleId;
    public PriceValidityCheckType PriceValidityCheckType;
    public QuoteSizeType QuoteSizeType;
    public byte NoQuoteEntries;
    public fixed byte Pad7[7];
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
///  Struct for Mm Parameter Definition Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmParameterDefinitionRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long ExposureDuration;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public int CumQty;
    public int PctCount;
    public int Delta;
    public int Vega;
    public ProductComplex ProductComplex;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Mm Parameter Definition Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmParameterDefinitionResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong ExecId;
};

/// <summary>
///  Struct for Mm Parameter Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmParameterGrpComp {
    public long ExposureDuration;
    public int CumQty;
    public int PctCount;
    public int Delta;
    public int Vega;
    public ProductComplex ProductComplex;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Modify Order Complex Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderComplexRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong OrderId;
    public ulong ClOrdId;
    public ulong OrigClOrdId;
    public long SecurityId;
    public ulong Price;
    public ulong ComplianceId;
    public int MarketSegmentId;
    public int OrderQty;
    public uint ExpireDate;
    public uint TargetPartyIdSessionId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public ProductComplex ProductComplex;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ExecInst ExecInst;
    public TimeInForce TimeInForce;
    public TradingCapacity TradingCapacity;
    public OwnershipIndicator OwnershipIndicator;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte PartyIdPositionAccount[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public byte NoLegs;
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
    public int LeavesQty;
    public int CumQty;
    public int CxlQty;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad7[7];
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
    public ulong TrdRegTsTimePriority;
    public int LeavesQty;
    public int CumQty;
    public int CxlQty;
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad7[7];
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
    public ulong Price;
    public ulong StopPx;
    public ulong ComplianceId;
    public int OrderQty;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public uint TargetPartyIdSessionId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public TradingCapacity TradingCapacity;
    public fixed sbyte Account[2];
    public fixed sbyte PartyIdPositionAccount[20];
    public PositionEffect PositionEffect;
    public OwnershipIndicator OwnershipIndicator;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
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
    public ulong Price;
    public ulong ComplianceId;
    public int OrderQty;
    public uint SimpleSecurityId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public PriceValidityCheckType PriceValidityCheckType;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for New Order Complex Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderComplexRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong ClOrdId;
    public long SecurityId;
    public ulong Price;
    public ulong ComplianceId;
    public int MarketSegmentId;
    public int OrderQty;
    public uint ExpireDate;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public ProductComplex ProductComplex;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ExecInst ExecInst;
    public TimeInForce TimeInForce;
    public TradingCapacity TradingCapacity;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte PartyIdPositionAccount[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public byte NoLegs;
    public fixed byte Pad7[7];
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
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad3[3];
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
    public OrdStatus OrdStatus;
    public ExecType ExecType;
    public ExecRestatementReason ExecRestatementReason;
    public ProductComplex ProductComplex;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for New Order Single Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingleRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong Price;
    public ulong StopPx;
    public ulong ClOrdId;
    public ulong ComplianceId;
    public int OrderQty;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public TradingCapacity TradingCapacity;
    public fixed sbyte Account[2];
    public fixed sbyte PartyIdPositionAccount[20];
    public PositionEffect PositionEffect;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for New Order Single Short Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingleShortRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong Price;
    public ulong ClOrdId;
    public ulong ComplianceId;
    public int OrderQty;
    public uint SimpleSecurityId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public PriceValidityCheckType PriceValidityCheckType;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public fixed byte Pad1[1];
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
    public ulong RequestOut;
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
    public ProductComplex ProductComplex;
    public MassActionType MassActionType;
    public MassActionReason MassActionReason;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Quote Activation Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteActivationRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong ComplianceId;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public MassActionType MassActionType;
    public ProductComplex ProductComplex;
    public fixed byte Pad6[6];
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
    public int BidCxlSize;
    public int OfferCxlSize;
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
    public ulong OfferPx;
    public int BidSize;
    public int OfferSize;
};

/// <summary>
///  Struct for Quote Event Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteEventGrpComp {
    public long SecurityId;
    public ulong QuoteEventPx;
    public ulong QuoteMsgId;
    public uint QuoteEventMatchId;
    public int QuoteEventExecId;
    public int QuoteEventQty;
    public QuoteEventType QuoteEventType;
    public QuoteEventSide QuoteEventSide;
    public QuoteEventLiquidityInd QuoteEventLiquidityInd;
    public QuoteEventReason QuoteEventReason;
};

/// <summary>
///  Struct for Quote Leg Exec Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteLegExecGrpComp {
    public long LegSecurityId;
    public ulong LegLastPx;
    public int LegLastQty;
    public int LegExecId;
    public LegSide LegSide;
    public byte NoQuoteEventsIndex;
    public fixed byte Pad6[6];
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
    public ulong RequestOut;
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
    public uint SubscriptionScope;
    public ushort PartitionId;
    public RefApplId RefApplId;
    public fixed byte Pad1[1];
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
///  Struct for Rfq Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
    public ulong ComplianceId;
    public int MarketSegmentId;
    public int OrderQty;
    public Side Side;
    public fixed sbyte ComplianceText[20];
    public fixed byte Pad3[3];
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
///  Struct for Risk Notification Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RiskNotificationBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public uint TradeDate;
    public uint PartyDetailIdExecutingUnit;
    public RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
    public MarketId MarketId;
    public ListUpdateAction ListUpdateAction;
    public RiskLimitAction RiskLimitAction;
    public fixed sbyte RequestingPartyEnteringFirm[9];
    public fixed sbyte RequestingPartyClearingFirm[9];
    public fixed byte Pad6[6];
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
    public ushort PartitionId;
    public MatchingEngineStatus MatchingEngineStatus;
    public TradeManagerStatus TradeManagerStatus;
    public ApplSeqStatus ApplSeqStatus;
    public fixed byte Pad7[7];
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
    public long RelatedSecurityId;
    public ulong Price;
    public ulong LastPx;
    public ulong SideLastPx;
    public ulong ClearingTradePrice;
    public ulong TransactTime;
    public ulong OrderId;
    public ulong ClOrdId;
    public uint TradeId;
    public uint OrigTradeId;
    public uint RootPartyIdExecutingUnit;
    public uint RootPartyIdSessionId;
    public uint RootPartyIdExecutingTrader;
    public uint RootPartyIdClearingUnit;
    public int CumQty;
    public int LeavesQty;
    public int MarketSegmentId;
    public int RelatedSymbol;
    public int LastQty;
    public int SideLastQty;
    public int ClearingTradeQty;
    public uint SideTradeId;
    public uint MatchDate;
    public uint TrdMatchId;
    public uint StrategyLinkId;
    public int TotNumTradeReports;
    public MultiLegReportingType MultiLegReportingType;
    public TradeReportType TradeReportType;
    public TransferReason TransferReason;
    public fixed sbyte RootPartyIdBeneficiary[9];
    public fixed sbyte RootPartyIdTakeUpTradingFirm[5];
    public fixed sbyte RootPartyIdOrderOriginationFirm[7];
    public MatchType MatchType;
    public MatchSubType MatchSubType;
    public Side Side;
    public AggressorIndicator AggressorIndicator;
    public TradingCapacity TradingCapacity;
    public fixed sbyte Account[2];
    public fixed sbyte RootPartyIdPositionAccount[20];
    public PositionEffect PositionEffect;
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public OrderCategory OrderCategory;
    public OrdType OrdType;
    public RelatedProductComplex RelatedProductComplex;
    public OrderSide OrderSide;
    public fixed sbyte RootPartyClearingOrganization[4];
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyClearingFirm[5];
    public fixed byte Pad7[7];
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

