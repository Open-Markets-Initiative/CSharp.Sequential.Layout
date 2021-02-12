// C# Structs For Eurex Derivatives T7 Eti 6.0 protocol

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
    SrqsMaintenance = 9,
    ServiceAvailabilityMarket = 10,
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
    InstrumentDeletion = 105,
    InstrumentSuspension = 106,
    DeleteReasonMinimumValue = 106,
    DeleteReasonMinimumValue = 100,
};

/// <summary>
///  Event Type Values
/// </summary>
public enum EventType : byte {
    SwapStartDate = 8,
    SwapEndDate = 9,
    EventTypeMinimumValue = 9,
    EventTypeMinimumValue = 8,
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
    OrderBookRestatement = 1,
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
    ExecRestatementReasonMinimumValue = 300,
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
///  Exercise Style Values
/// </summary>
public enum ExerciseStyle : byte {
    European = 0,
    American = 1,
    ExerciseStyleMinimumValue = 1,
    ExerciseStyleMinimumValue = 0,
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
///  Gateway Status Values
/// </summary>
public enum GatewayStatus : byte {
    Standby = 0,
    Active = 1,
    GatewayStatusMinimumValue = 1,
    GatewayStatusMinimumValue = 0,
};

/// <summary>
///  Hedge Type Values
/// </summary>
public enum HedgeType : byte {
    DurationHedge = 0,
    NominalHedge = 1,
    PriceFactorHedge = 2,
    HedgeTypeMinimumValue = 2,
    HedgeTypeMinimumValue = 0,
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
///  Instr Attrib Type Values
/// </summary>
public enum InstrAttribType : byte {
    VariableRate = 5,
    CouponRate = 100,
    Offsettothevariablecouponrate = 101,
    SwapCustomer1 = 102,
    SwapCustomer2 = 103,
    CashBasketReference = 104,
    InstrAttribTypeMinimumValue = 104,
    InstrAttribTypeMinimumValue = 5,
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
///  Leaves Qty Disclosure Instruction Values
/// </summary>
public enum LeavesQtyDisclosureInstruction : byte {
    No = 0,
    Yes = 1,
    LeavesQtyDisclosureInstructionMinimumValue = 1,
    LeavesQtyDisclosureInstructionMinimumValue = 0,
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
///  Message Event Source Values
/// </summary>
public enum MessageEventSource : byte {
    BroadcasttoInitiator = (byte)'I',
    BroadcasttoApprover = (byte)'A',
    BroadcasttoRequester = (byte)'R',
    BroadcasttoQuoteSubmitter = (byte)'Q',
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
///  Multileg Price Model Values
/// </summary>
public enum MultilegPriceModel : byte {
    Standard = 0,
    UserDefined = 1,
    MultilegPriceModelMinimumValue = 1,
    MultilegPriceModelMinimumValue = 0,
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
///  Order Attribute Risk Reduction Values
/// </summary>
public enum OrderAttributeRiskReduction : byte {
    Y = 1,
    N = 0,
    OrderAttributeRiskReductionMinimumValue = 1,
    OrderAttributeRiskReductionMinimumValue = 0,
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
///  Party Id Investment Decision Maker Qualifier Values
/// </summary>
public enum PartyIdInvestmentDecisionMakerQualifier : byte {
    Algo = 22,
    Human = 24,
    PartyIdInvestmentDecisionMakerQualifierMinimumValue = 24,
    PartyIdInvestmentDecisionMakerQualifierMinimumValue = 22,
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
///  Party Id Settlement Location Values
/// </summary>
public enum PartyIdSettlementLocation : byte {
    ClearstremBankingFrankfurt = 1,
    ClearstremBankingLuxemburg = 2,
    ClsGroup = 3,
    Euroclear = 4,
    PartyIdSettlementLocationMinimumValue = 4,
    PartyIdSettlementLocationMinimumValue = 1,
};

/// <summary>
///  Position Effect Values
/// </summary>
public enum PositionEffect : byte {
    Close = (byte)'C',
    Open = (byte)'O',
};

/// <summary>
///  Price Disclosure Instruction Values
/// </summary>
public enum PriceDisclosureInstruction : byte {
    No = 0,
    Yes = 1,
    PriceDisclosureInstructionMinimumValue = 1,
    PriceDisclosureInstructionMinimumValue = 0,
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
    Flexiblesimpleinstrument = 10,
    ProductComplexMinimumValue = 10,
    ProductComplexMinimumValue = 1,
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = 0,
    Call = 1,
    PutOrCallMinimumValue = 1,
    PutOrCallMinimumValue = 0,
};

/// <summary>
///  Quote Cancel Type Values
/// </summary>
public enum QuoteCancelType : byte {
    CancelAllQuotes = 4,
    QuoteCancelTypeMinimumValue = 4,
    QuoteCancelTypeMinimumValue = 4,
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
    CurrentlyNotTradeableOnBook = 124,
    QuantityLimitExceeded = 125,
    ValueLimitExceeded = 126,
    InvalidQuoteSpread = 127,
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
    Crossrejected = 16,
    QuoteEventReasonMinimumValue = 16,
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
///  Quote Instruction Values
/// </summary>
public enum QuoteInstruction : byte {
    DoNotQuote = 0,
    Quote = 1,
    QuoteInstructionMinimumValue = 1,
    QuoteInstructionMinimumValue = 0,
};

/// <summary>
///  Quote Ref Price Source Values
/// </summary>
public enum QuoteRefPriceSource : byte {
    Underlying = 1,
    CustomIndex = 2,
    QuoteRefPriceSourceMinimumValue = 2,
    QuoteRefPriceSourceMinimumValue = 1,
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
///  Quote Status Values
/// </summary>
public enum QuoteStatus : byte {
    Removed = 6,
    Expired = 7,
    Active = 16,
    QuoteStatusMinimumValue = 17,
    QuoteStatusMinimumValue = 6,
};

/// <summary>
///  Quote Type Values
/// </summary>
public enum QuoteType : byte {
    Indicative = 0,
    Tradeable = 1,
    QuoteTypeMinimumValue = 1,
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
    SrqsMaintenance = 9,
    ServiceAvailabilityMarket = 10,
    RefApplIDMinimumValue = 10,
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
    T7 = 2,
    RequestingPartyIdExecutingSystemMinimumValue = 4294967294,
    RequestingPartyIdExecutingSystemMinimumValue = 0,
};

/// <summary>
///  Risk Limit Action Values
/// </summary>
public enum RiskLimitAction : byte {
    QueueInbound = 0,
    Reject = 2,
    Warning = 4,
    RiskLimitActionMinimumValue = 4,
    RiskLimitActionMinimumValue = 0,
};

/// <summary>
///  Secondary Gateway Status Values
/// </summary>
public enum SecondaryGatewayStatus : byte {
    Standby = 0,
    Active = 1,
    SecondaryGatewayStatusMinimumValue = 1,
    SecondaryGatewayStatusMinimumValue = 0,
};

/// <summary>
///  Selective Request For Quote Service Status Values
/// </summary>
public enum SelectiveRequestForQuoteServiceStatus : byte {
    Unavailable = 0,
    Available = 1,
    SelectiveRequestForQuoteServiceStatusMinimumValue = 1,
    SelectiveRequestForQuoteServiceStatusMinimumValue = 0,
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
    CreateCiThrottleExceeded = 10010,
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
///  Settl Method Values
/// </summary>
public enum SettlMethod : byte {
    CashSettlement = (byte)'C',
    PhysicalSettlement = (byte)'P',
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
///  Side Disclosure Instruction Values
/// </summary>
public enum SideDisclosureInstruction : byte {
    No = 0,
    Yes = 1,
    SideDisclosureInstructionMinimumValue = 1,
    SideDisclosureInstructionMinimumValue = 0,
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
///  Skip Validations Values
/// </summary>
public enum SkipValidations : byte {
    False = 0,
    True = 1,
    SkipValidationsMinimumValue = 1,
    SkipValidationsMinimumValue = 0,
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
    TradeAllocStatusMinimumValue = 45,
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
    DoNotPublishTrade = 0,
    PublishTrade = 1,
    TradePublishIndicatorMinimumValue = 1,
    TradePublishIndicatorMinimumValue = 0,
};

/// <summary>
///  Trade Report Type Values
/// </summary>
public enum TradeReportType : byte {
    Submit = 0,
    Alleged = 1,
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
///  Trade Underlying Values
/// </summary>
public enum TradeUnderlying : byte {
    No = 1,
    Yes = 2,
    TradeUnderlyingMinimumValue = 2,
    TradeUnderlyingMinimumValue = 1,
};

/// <summary>
///  Trading Capacity Values
/// </summary>
public enum TradingCapacity : byte {
    Customer = 1,
    Principal = 5,
    MarketMaker = 6,
    TradingCapacityMinimumValue = 9,
    TradingCapacityMinimumValue = 1,
};

/// <summary>
///  Trading Session Sub Id Values
/// </summary>
public enum TradingSessionSubId : byte {
    Closingauction = 4,
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
///  Trd Rpt Status Values
/// </summary>
public enum TrdRptStatus : byte {
    Accepted = 0,
    Rejected = 1,
    Cancelled = 2,
    PendingNew = 4,
    Terminated = 7,
    TrdRptStatusMinimumValue = 7,
    TrdRptStatusMinimumValue = 0,
};

/// <summary>
///  Trd Type Values
/// </summary>
public enum TrdType : ushort {
    BlockTrade = 1,
    ExchangeforSwap = 12,
    ExchangeBasisFacility = 55,
    VolaTrade = 1000,
    EfpFinTrade = 1001,
    EfpIndexFuturesTrade = 1002,
    TradeatMarket = 1004,
    TrdTypeMinimumValue = 1004,
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
///  Struct for Add Complex Instrument Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddComplexInstrumentRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
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
///  Struct for Add Flexible Instrument Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddFlexibleInstrumentRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong StrikePrice;
    public int MarketSegmentId;
    public uint MaturityDate;
    public SettlMethod SettlMethod;
    public byte OptAttribute;
    public PutOrCall PutOrCall;
    public ExerciseStyle ExerciseStyle;
    public fixed sbyte ComplianceText[20];
};

/// <summary>
///  Struct for Add Flexible Instrument Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddFlexibleInstrumentResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public ulong SecurityResponseId;
    public long SecurityId;
    public ulong StrikePrice;
    public int MarketSegmentId;
    public uint MaturityDate;
    public ProductComplex ProductComplex;
    public SettlMethod SettlMethod;
    public byte OptAttribute;
    public PutOrCall PutOrCall;
    public ExerciseStyle ExerciseStyle;
    public fixed sbyte Symbol[4];
    public fixed byte Pad7[7];
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
    public uint PackageId;
    public uint AllocId;
    public int AllocQty;
    public uint TesExecId;
    public int MarketSegmentId;
    public int RelatedMarketSegmentId;
    public TrdType TrdType;
    public TradingCapacity TradingCapacity;
    public TradeReportType TradeReportType;
    public Side Side;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte TradeReportId[20];
    public PositionEffect PositionEffect;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte Account[2];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdPositionAccount[32];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Broadcast Error Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BroadcastErrorNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NotifHeaderComp[0];
    public ApplIdStatus ApplIdStatus;
    public uint RefApplSubId;
    public ushort VarTextLen;
    public RefApplId RefApplId;
    public SessionStatus SessionStatus;
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
    public ulong Price;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public uint TargetPartyIdExecutingTrader;
    public uint PartyIdEnteringTrader;
    public ushort NoNotAffectedOrders;
    public PartyIdEnteringFirm PartyIdEnteringFirm;
    public MassActionReason MassActionReason;
    public ExecInst ExecInst;
    public Side Side;
    public fixed byte Pad2[2];
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
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad5[5];
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
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public uint TargetPartyIdSessionId;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte FixClOrdId[20];
    public fixed byte Pad6[6];
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
    public int RelatedMarketSegmentId;
    public TrdType TrdType;
    public TradeReportType TradeReportType;
    public fixed sbyte TradeReportId[20];
    public fixed byte Pad1[1];
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
///  Struct for Forced Logout Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ForcedLogoutNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NotifHeaderComp[0];
    public ushort VarTextLen;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Forced User Logout Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ForcedUserLogoutNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NotifHeaderComp[0];
    public UserStatus UserStatus;
    public fixed byte Pad3[3];
    public uint Username;
    public ushort VarTextLen;
    public fixed byte Pad6[6];
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
    public GatewayStatus GatewayStatus;
    public SecondaryGatewayStatus SecondaryGatewayStatus;
    public SessionMode SessionMode;
    public TradSesMode TradSesMode;
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
    public byte FillRefId;
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
///  Struct for Instrument Attribute Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentAttributeGrpComp {
    public InstrAttribType InstrAttribType;
    public fixed sbyte InstrAttribValue[32];
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Instrument Event Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentEventGrpComp {
    public uint EventDate;
    public EventType EventType;
    public fixed byte Pad3[3];
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
///  Struct for Legal Notification Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegalNotificationBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public ushort VarTextLen;
    public UserStatus UserStatus;
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
    public QuoteSizeType QuoteSizeType;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public byte NoQuoteEntries;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
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
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public int OrderQty;
    public uint ExpireDate;
    public uint MatchInstCrossId;
    public uint TargetPartyIdSessionId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public ProductComplex ProductComplex;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public ExecInst ExecInst;
    public TimeInForce TimeInForce;
    public TradingCapacity TradingCapacity;
    public OwnershipIndicator OwnershipIndicator;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte PartyIdPositionAccount[32];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte FixClOrdId[20];
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
    public CrossedIndicator CrossedIndicator;
    public ProductComplex ProductComplex;
    public Triggered Triggered;
    public fixed byte Pad5[5];
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
    public CrossedIndicator CrossedIndicator;
    public ProductComplex ProductComplex;
    public Triggered Triggered;
    public fixed byte Pad5[5];
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
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int OrderQty;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public uint MatchInstCrossId;
    public uint TargetPartyIdSessionId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public TradingCapacity TradingCapacity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte Account[2];
    public fixed sbyte PartyIdPositionAccount[32];
    public PositionEffect PositionEffect;
    public OwnershipIndicator OwnershipIndicator;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
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
    public ulong Price;
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int OrderQty;
    public uint SimpleSecurityId;
    public uint MatchInstCrossId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
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
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public int OrderQty;
    public uint ExpireDate;
    public uint MatchInstCrossId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public ProductComplex ProductComplex;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public OrderAttributeRiskReduction OrderAttributeRiskReduction;
    public ExecInst ExecInst;
    public TimeInForce TimeInForce;
    public TradingCapacity TradingCapacity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte PartyIdPositionAccount[32];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte FixClOrdId[20];
    public byte NoLegs;
    public fixed byte Pad6[6];
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
    public CrossedIndicator CrossedIndicator;
    public ProductComplex ProductComplex;
    public Triggered Triggered;
    public fixed byte Pad1[1];
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
    public CrossedIndicator CrossedIndicator;
    public ProductComplex ProductComplex;
    public Triggered Triggered;
    public fixed byte Pad1[1];
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
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int OrderQty;
    public uint ExpireDate;
    public int MarketSegmentId;
    public uint SimpleSecurityId;
    public uint MatchInstCrossId;
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public ApplSeqIndicator ApplSeqIndicator;
    public Side Side;
    public OrdType OrdType;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public OrderAttributeRiskReduction OrderAttributeRiskReduction;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingSessionSubId TradingSessionSubId;
    public TradingCapacity TradingCapacity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed sbyte Account[2];
    public fixed sbyte PartyIdPositionAccount[32];
    public PositionEffect PositionEffect;
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte FixClOrdId[20];
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
    public ulong PartyIdClientId;
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int OrderQty;
    public uint SimpleSecurityId;
    public uint MatchInstCrossId;
    public ushort EnrichmentRuleId;
    public Side Side;
    public PriceValidityCheckType PriceValidityCheckType;
    public ValueCheckTypeValue ValueCheckTypeValue;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public TimeInForce TimeInForce;
    public ExecInst ExecInst;
    public TradingCapacity TradingCapacity;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for News Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewsBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong OrigTime;
    public ushort VarTextLen;
    public fixed sbyte Headline[256];
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
///  Struct for Quot Req Legs Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuotReqLegsGrpComp {
    public long LegSecurityId;
    public uint LegRatioQty;
    public int LegSymbol;
    public LegSecurityType LegSecurityType;
    public LegSide LegSide;
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
    public ulong PartyIdInvestmentDecisionMaker;
    public ulong ExecutingTrader;
    public int MarketSegmentId;
    public uint TargetPartyIdSessionId;
    public MassActionType MassActionType;
    public ProductComplex ProductComplex;
    public PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
    public ExecutingTraderQualifier ExecutingTraderQualifier;
    public fixed byte Pad4[4];
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
///  Struct for Reject
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Reject {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrResponseHeaderMeComp[0];
    public SessionRejectReason SessionRejectReason;
    public ushort VarTextLen;
    public SessionStatus SessionStatus;
    public fixed byte Pad1[1];
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
///  Struct for Rfq Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public long SecurityId;
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
///  Struct for Service Availability Market Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ServiceAvailabilityMarketBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte NrbcHeaderComp[0];
    public uint SelectiveRequestForQuoteServiceTradeDate;
    public SelectiveRequestForQuoteServiceStatus SelectiveRequestForQuoteServiceStatus;
    public fixed byte Pad3[3];
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
///  Struct for Side Alloc Ext Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SideAllocExtGrpComp {
    public uint IndividualAllocId;
    public int AllocQty;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public Side Side;
    public TradeAllocStatus TradeAllocStatus;
    public TradingCapacity TradingCapacity;
    public PositionEffect PositionEffect;
    public OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
    public fixed sbyte Account[2];
    public fixed sbyte PartyIdPositionAccount[32];
    public fixed sbyte PartyIdTakeUpTradingFirm[5];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte PartyIdOrderOriginationFirm[7];
    public fixed sbyte PartyIdBeneficiary[9];
    public fixed sbyte PartyIdLocationId[2];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte ComplianceText[20];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Side Alloc Grp Bc Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SideAllocGrpBcComp {
    public uint IndividualAllocId;
    public int AllocQty;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public Side Side;
    public TradeAllocStatus TradeAllocStatus;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Side Alloc Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SideAllocGrpComp {
    public uint IndividualAllocId;
    public int AllocQty;
    public Side Side;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Srqs Create Deal Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsCreateDealNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public ulong LastPx;
    public ulong QuoteId;
    public long SecurityId;
    public ulong ExpireTime;
    public uint NegotiationId;
    public uint TradeId;
    public int LastQty;
    public TrdRptStatus TrdRptStatus;
    public MessageEventSource MessageEventSource;
    public Side Side;
    public byte NoLegs;
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyEnteringTrader[6];
    public fixed sbyte TargetPartyExecutingFirm[5];
    public fixed sbyte TargetPartyExecutingTrader[6];
    public fixed sbyte FirmTradeId[20];
    public fixed sbyte FirmNegotiationId[20];
    public fixed sbyte FreeText1[12];
};

/// <summary>
///  Struct for Srqs Deal Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsDealNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public uint NegotiationId;
    public uint TradeId;
    public TrdRptStatus TrdRptStatus;
    public MessageEventSource MessageEventSource;
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyEnteringTrader[6];
    public fixed sbyte TargetPartyExecutingFirm[5];
    public fixed sbyte TargetPartyExecutingTrader[6];
    public fixed sbyte TargetPartyEnteringTrader[6];
    public fixed sbyte FirmTradeId[20];
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Srqs Deal Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsDealResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public long SecurityId;
    public ulong QuoteId;
    public uint NegotiationId;
    public uint TradeId;
    public uint SecondaryTradeId;
    public fixed sbyte FirmTradeId[20];
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Srqs Enter Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsEnterQuoteRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong BidPx;
    public ulong OfferPx;
    public int MarketSegmentId;
    public uint NegotiationId;
    public int BidSize;
    public int OfferSize;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte FreeText1[12];
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Srqs Hit Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsHitQuoteRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong QuoteId;
    public ulong ValidUntilTime;
    public int MarketSegmentId;
    public uint NegotiationId;
    public int OrderQty;
    public Side Side;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte FirmTradeId[20];
    public fixed sbyte FreeText1[12];
};

/// <summary>
///  Struct for Srqs Negotiation Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsNegotiationNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public ulong QuoteRefPrice;
    public ulong BidPx;
    public ulong OfferPx;
    public uint NegotiationId;
    public int LeavesQty;
    public QuoteType QuoteType;
    public QuoteStatus QuoteStatus;
    public QuoteInstruction QuoteInstruction;
    public Side Side;
    public QuoteRefPriceSource QuoteRefPriceSource;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte PartyEnteringTrader[6];
    public fixed sbyte TargetPartyExecutingFirm[5];
    public fixed sbyte TargetPartyExecutingTrader[6];
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Srqs Negotiation Requester Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsNegotiationRequesterNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public ulong QuoteRefPrice;
    public ulong BidPx;
    public ulong OfferPx;
    public uint NegotiationId;
    public int OrderQty;
    public int LeavesQty;
    public QuoteType QuoteType;
    public QuoteStatus QuoteStatus;
    public byte NoTargetPartyIDs;
    public Side Side;
    public QuoteRefPriceSource QuoteRefPriceSource;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte PartyEnteringTrader[6];
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Srqs Negotiation Status Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsNegotiationStatusNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public uint NegotiationId;
    public QuoteStatus QuoteStatus;
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Srqs Open Negotiation Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsOpenNegotiationNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public long SecurityId;
    public ulong BidPx;
    public ulong OfferPx;
    public ulong QuoteRefPrice;
    public uint NegotiationId;
    public int MarketSegmentId;
    public int LeavesQty;
    public QuoteType QuoteType;
    public QuoteStatus QuoteStatus;
    public byte NoLegs;
    public Side Side;
    public QuoteRefPriceSource QuoteRefPriceSource;
    public TradeUnderlying TradeUnderlying;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte PartyEnteringTrader[6];
    public fixed sbyte TargetPartyExecutingFirm[5];
    public fixed sbyte TargetPartyExecutingTrader[6];
    public fixed sbyte FirmNegotiationId[20];
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Srqs Quote Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsQuoteNotification {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public ulong TransactTime;
    public ulong QuoteId;
    public ulong SecondaryQuoteId;
    public ulong BidPx;
    public ulong OfferPx;
    public uint NegotiationId;
    public int BidSize;
    public int OfferSize;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed sbyte PartyEnteringTrader[6];
    public fixed sbyte QuoteReqId[20];
    public fixed sbyte FreeText1[12];
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Srqs Quote Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsQuoteResponse {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte ResponseHeaderComp[0];
    public ulong QuoteId;
    public uint NegotiationId;
    public fixed sbyte QuoteReqId[20];
};

/// <summary>
///  Struct for Srqs Status Broadcast
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsStatusBroadcast {
    public fixed byte MessageHeaderOutComp[0];
    public fixed byte RbcHeaderComp[0];
    public uint TradeDate;
    public TradSesEvent TradSesEvent;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Srqs Trd Instrmnt Leg Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsTrdInstrmntLegGrpComp {
    public long LegSecurityId;
    public ulong LegBestBidPx;
    public ulong LegBestOfferPx;
    public int LegBestBidSize;
    public int LegBestOfferSize;
};

/// <summary>
///  Struct for Srqs Update Deal Status Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsUpdateDealStatusRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public int MarketSegmentId;
    public uint NegotiationId;
    public uint TradeId;
    public TradeReportType TradeReportType;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
};

/// <summary>
///  Struct for Srqs Update Negotiation Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SrqsUpdateNegotiationRequest {
    public fixed byte MessageHeaderInComp[0];
    public fixed byte RequestHeaderComp[0];
    public ulong QuoteRefPrice;
    public ulong BidPx;
    public ulong OfferPx;
    public int MarketSegmentId;
    public uint NegotiationId;
    public int OrderQty;
    public byte NoTargetPartyIDs;
    public Side Side;
    public QuoteCancelType QuoteCancelType;
    public QuoteRefPriceSource QuoteRefPriceSource;
    public fixed sbyte PartyExecutingFirm[5];
    public fixed sbyte PartyExecutingTrader[6];
    public fixed byte Pad5[5];
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
///  Struct for Target Parties Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TargetPartiesComp {
    public SideDisclosureInstruction SideDisclosureInstruction;
    public PriceDisclosureInstruction PriceDisclosureInstruction;
    public LeavesQtyDisclosureInstruction LeavesQtyDisclosureInstruction;
    public QuoteInstruction QuoteInstruction;
    public fixed sbyte TargetPartyExecutingFirm[5];
    public fixed sbyte TargetPartyExecutingTrader[6];
    public fixed byte Pad1[1];
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
    public MessageEventSource MessageEventSource;
    public fixed byte Pad4[4];
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
    public ulong ClearingTradePrice;
    public ulong TransactTime;
    public long RelatedSecurityId;
    public uint PackageId;
    public int LastQty;
    public int MarketSegmentId;
    public uint TradeId;
    public uint TradeDate;
    public uint SideTradeId;
    public uint RootPartyIdSessionId;
    public uint OrigTradeId;
    public int ClearingTradeQty;
    public uint RootPartyIdExecutingUnit;
    public uint RootPartyIdExecutingTrader;
    public uint RootPartyIdClearingUnit;
    public uint StrategyLinkId;
    public int RelatedSymbol;
    public int TotNumTradeReports;
    public TrdType TrdType;
    public ProductComplex ProductComplex;
    public RelatedProductComplex RelatedProductComplex;
    public Side Side;
    public TradingCapacity TradingCapacity;
    public TradeReportType TradeReportType;
    public TransferReason TransferReason;
    public MultiLegReportingType MultiLegReportingType;
    public PositionEffect PositionEffect;
    public MultilegPriceModel MultilegPriceModel;
    public fixed sbyte Account[2];
    public fixed sbyte RootPartyIdPositionAccount[32];
    public fixed sbyte CustOrderHandlingInst[1];
    public fixed sbyte FreeText1[12];
    public fixed sbyte FreeText2[12];
    public fixed sbyte FreeText3[12];
    public fixed sbyte RootPartyExecutingFirm[5];
    public fixed sbyte RootPartyExecutingTrader[6];
    public fixed sbyte RootPartyClearingFirm[5];
    public fixed sbyte RootPartyClearingOrganization[4];
    public fixed sbyte RootPartyIdBeneficiary[9];
    public fixed sbyte RootPartyIdTakeUpTradingFirm[5];
    public fixed sbyte RootPartyIdOrderOriginationFirm[7];
    public fixed byte Pad1[1];
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
    public SideLiquidityInd SideLiquidityInd;
    public TradingCapacity TradingCapacity;
    public fixed sbyte Account[2];
    public fixed sbyte RootPartyIdPositionAccount[32];
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
    public fixed byte Pad3[3];
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
///  Struct for Trd Instrmnt Leg Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TrdInstrmntLegGrpComp {
    public long LegSecurityId;
    public ulong LegPrice;
};

/// <summary>
///  Struct for Underlying Stip Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingStipGrpComp {
    public fixed sbyte UnderlyingStipValue[32];
    public fixed sbyte UnderlyingStipType[7];
    public fixed byte Pad1[1];
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

