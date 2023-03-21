// C# Structs For Memx Equities Sbe Memo 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Cancel Reason Values
/// </summary>
public enum CancelReason : byte {
    Other = 0,
    UserRequestedCancel = 1,
    EndOfTrading = 4,
    LimitUpLimitDown = 5,
    Halted = 6,
    ExchangeSupervisory = 7,
    OrderExpired = 8,
    LockOrCrossBook = 9,
    SelfTradePrevention = 10,
    InsufficientQuotes = 11,
    NonCompliantPrice = 12,
    ParticipantDisconnect = 13,
    OrderNotBookable = 14,
    TradeProtectionLimits = 15,
    UnableToRoute = 16,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Cust Order Capacity Values
/// </summary>
public enum CustOrderCapacity : byte {
    MemberTradingOnTheirOwnAccount = 1,
    NullValue = 255,
};

/// <summary>
///  Cxl Rej Reason Values
/// </summary>
public enum CxlRejReason : byte {
    Other = 0,
    MissingSymbol = 1,
    MissingClOrdId = 2,
    MissingOrigOrderIdentifiers = 3,
    AmbiguousOrigOrderIdentifiers = 4,
    UnknownOrigOrder = 5,
    OrigOrderSymbolNotMatchingRequestSymbol = 6,
    MissingLocate = 7,
    InvalidOrderQuantity = 8,
    InvalidSymbol = 9,
    InvalidLimitPrice = 10,
    InvalidLimitPriceIncrement = 11,
    InvalidLocate = 12,
    SymbolHaltedOrPaused = 13,
    ExchangeClosed = 14,
    DuplicateClOrdId = 15,
    OrderSizeExceedsLimit = 16,
    ExceededMaxNotionalOrderAmt = 17,
    UnsupportedDisplayQuantityChange = 18,
    UnsupportedOrdTypeChange = 19,
    UnsupportedSideChange = 20,
    UnsupportedQuantityChange = 21,
    OrderInPendingState = 22,
    NullValue = 255,
};

/// <summary>
///  Cxl Rej Response To Values
/// </summary>
public enum CxlRejResponseTo : byte {
    OrderCancelRequest = 1,
    OrderCancelReplaceRequest = 2,
    NullValue = 255,
};

/// <summary>
///  Display Method Values
/// </summary>
public enum DisplayMethod : byte {
    Initial = 1,
    Random = 2,
    Undisclosed = 3,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Exec Restatement Reason Values
/// </summary>
public enum ExecRestatementReason : byte {
    OrderReprice = 1,
    SelfTradePrevention = 2,
    NullValue = 255,
};

/// <summary>
///  Last Liquidity Ind Values
/// </summary>
public enum LastLiquidityInd : byte {
    AddDisplayed = 1,
    Removed = 2,
    Routed = 3,
    Cross = 4,
    AddHidden = 5,
    AddMidpointPeg = 6,
    AddDisplayedNbboImprove = 7,
    NullValue = 255,
};

/// <summary>
///  Last Mkt Values
/// </summary>
public enum LastMkt : byte {
    Memx = (byte)'U',
    Nasdaq = (byte)'Q',
    NasdaqBx = (byte)'B',
    NasdaqPsx = (byte)'X',
    Nyse = (byte)'N',
    Arca = (byte)'P',
    NyseAmerican = (byte)'A',
    NyseChicago = (byte)'M',
    NyseNational = (byte)'C',
    Edgx = (byte)'K',
    Edga = (byte)'J',
    Bats = (byte)'Z',
    Batsy = (byte)'Y',
    Iex = (byte)'V',
    Ltse = (byte)'L',
    Eprl = (byte)'H',
    NullValue = (byte)' ',
};

/// <summary>
///  Login Reject Code Values
/// </summary>
public enum LoginRejectCode : byte {
    MalformedToken = (byte)'T',
    TokenTypeUnsupported = (byte)'U',
    TokenTypeInvalid = (byte)'V',
    AuthorizationFailed = (byte)'A',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    LoginRequest = 100,
    ReplayRequest = 101,
    ReplayAllRequest = 102,
    StreamRequest = 103,
    UnsequencedMessage = 104,
    LoginAccepted = 1,
    LoginRejected = 2,
    StartOfSession = 3,
    EndOfSession = 3,
    ReplayBegin = 5,
    ReplayRejected = 6,
    ReplayComplete = 7,
    StreamBegin = 8,
    StreamRejected = 9,
    StreamComplete = 10,
    SequencedMessage = 11,
};

/// <summary>
///  Ord Status Values
/// </summary>
public enum OrdStatus : byte {
    New = 1,
    PartialFilled = 2,
    Filled = 3,
    Canceled = 4,
    PendingCancel = 5,
    Rejected = 6,
    PendingNew = 7,
    PendingReplace = 8,
    Expired = 9,
    NullValue = 255,
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = 1,
    Limit = 2,
    Pegged = 3,
    NullValue = 255,
};

/// <summary>
///  Order Capacity Values
/// </summary>
public enum OrderCapacity : byte {
    Agency = 1,
    Principal = 2,
    RisklessPrincipal = 3,
    NullValue = 255,
};

/// <summary>
///  Peg Price Type Values
/// </summary>
public enum PegPriceType : byte {
    MidPricePeg = 1,
    PrimaryPeg = 2,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Reject Reason Values
/// </summary>
public enum RejectReason : byte {
    Other = 0,
    MissingSymbol = 1,
    MissingLocate = 2,
    MissingClOrdId = 3,
    MissingSide = 4,
    MissingOrderQuantity = 5,
    MissingOrderType = 6,
    MissingTimeInForce = 7,
    MissingOrderCapacity = 8,
    MissingExecInst = 9,
    MissingLimitPrice = 10,
    MissingMaxFloor = 11,
    MissingReserveReplenishAmountType = 12,
    MissingReserveReplenishTimeType = 13,
    MissingRandomReplenishValue = 14,
    MissingRepriceFrequencyType = 15,
    MissingRepriceBehaviorType = 16,
    MissingCustomerCapacityType = 17,
    MissingExpireTime = 18,
    MissingPegType = 19,
    InvalidModifierForOrderType = 20,
    InvalidModifiersCombination = 21,
    InvalidTradingSessionForOrderType = 22,
    InvalidTimeInForceForOrderType = 23,
    InvalidMinQuantity = 24,
    InvalidOrderQuantity = 25,
    InvalidSide = 26,
    InvalidOrderType = 27,
    InvalidTimeInForce = 28,
    InvalidOrderCapacity = 29,
    InvalidCustomerCapacity = 30,
    InvalidSymbol = 31,
    InvalidExpireTime = 32,
    InvalidLimitPrice = 33,
    InvalidLimitPriceIncrement = 34,
    InvalidMaxFloor = 35,
    InvalidRandomReplenishValue = 36,
    InvalidRandomReplenishValueForReserveType = 37,
    InvalidReserveReplenishAmountType = 38,
    InvalidReserveReplenishTimeType = 39,
    InvalidRepriceFrequencyType = 40,
    InvalidRepriceBehaviorType = 41,
    InvalidRepriceBehaviorForRepriceFrequency = 42,
    InvalidMpidValue = 43,
    InvalidPegType = 44,
    InvalidModifierForPegType = 45,
    InvalidLocate = 46,
    SymbolHaltedOrPaused = 47,
    ExchangeClosed = 48,
    DuplicateClOrdId = 49,
    OrderSizeExceedsLimit = 50,
    OrderNotionalExceedsLimit = 51,
    BlockIsoRiskRuleViolated = 52,
    BlockSessionRiskRuleViolated = 53,
    BlockSellShortRiskRuleViolated = 54,
    BlockNonTestSymbolsRiskRuleViolated = 55,
    MaxSharesPerOrderRiskRuleBreach = 56,
    MaxNotionalValuePerOrderRiskRuleBreach = 57,
    PricePercentCollarRiskRuleViolated = 58,
    PriceValueCollarRiskRuleViolated = 59,
    MaxAdvPercentPerOrderRiskRuleBreach = 60,
    DailyGrossNotionalExposureRiskRuleBreach = 61,
    DailyNetNotionalExposureRiskRuleBreach = 62,
    MaxNumDuplicateOrdersRiskRuleBreach = 63,
    MaxOrderRateRiskRuleBreach = 64,
    RestrictedSecurityRiskRuleViolated = 65,
    HardToBorrowSecurityRiskRuleViolated = 66,
    InvalidSelfTradePreventionConfiguration = 67,
    InvalidSelfTradePreventionType = 68,
    InvalidRiskGroupId = 69,
    FirmDisabled = 70,
    MpidDisabled = 71,
    AccountDisabled = 72,
    NoNbboAvailable = 73,
    CannotTradeNonTestSymbol = 74,
    MissingFirm = 75,
    MissingAccount = 76,
    MissingMpid = 77,
    MissingRiskGroup = 78,
    DailyMarketOrderGrossNotionalExposureRiskRuleBreach = 79,
    DailyMarketOrderNetNotionalExposureRiskRuleBreach = 80,
    MissingDispMethodType = 81,
    NullValue = 255,
    UnknownProduct = 1,
    UnknownSide = 2,
    UnknownGroupId = 3,
    HigherPriceLowerOrEqualToLowerPrice = 4,
    ProductMissingForPriceRestriction = 5,
    DuplicateClOrdId = 6,
    MalformedRequestMissingClOrdIdField = 7,
};

/// <summary>
///  Replay Reject Code Values
/// </summary>
public enum ReplayRejectCode : byte {
    ReplayRequestsAreNotAllowed = (byte)'R',
    ReplayAllRequestsAreNotAllowed = (byte)'A',
    NotTheActiveSession = (byte)'P',
    SequenceNumberOutOfRange = (byte)'S',
};

/// <summary>
///  Reprice Behavior Values
/// </summary>
public enum RepriceBehavior : byte {
    RepriceLockCancelCross = 1,
    RepriceLockRepriceCross = 2,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Reprice Frequency Values
/// </summary>
public enum RepriceFrequency : byte {
    SingleReprice = 1,
    ContinuousReprice = 2,
    None = 3,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Reserve Replenish Timing Values
/// </summary>
public enum ReserveReplenishTiming : byte {
    Immediate = 1,
    Random = 2,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Self Trade Prevention Values
/// </summary>
public enum SelfTradePrevention : byte {
    CancelNewest = 1,
    CancelOldest = 2,
    DecrementAndCancel = 3,
    CancelBoth = 4,
    CancelSmallest = 5,
    NullValue = 255,
    NoValue = 255,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
    SellShort = 3,
    SellShortExempt = 4,
    NullValue = 255,
};

/// <summary>
///  Stream Reject Code Values
/// </summary>
public enum StreamRejectCode : byte {
    StreamRequestsAreNotAllowed = (byte)'R',
    NotTheActiveSession = (byte)'P',
    SequenceNumberOutOfRange = (byte)'S',
};

/// <summary>
///  Supported Request Mode Values
/// </summary>
public enum SupportedRequestMode : byte {
    Stream = (byte)'S',
    Replay = (byte)'R',
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : byte {
    NewOrderSingleMessage = 1,
    OrderCancelReplaceRequestMessage = 2,
    OrderCancelRequestMessage = 3,
    MassCancelRequestMessage = 4,
    ExecutionReportPendingNewMessage = 5,
    ExecutionReportNewMessage = 6,
    ExecutionReportRejectedMessage = 7,
    ExecutionReportTradeMessage = 8,
    ExecutionReportPendingCancelMessage = 9,
    PendingMassCancelMessage = 10,
    ExecutionReportCanceledMessage = 11,
    MassCancelDoneMessage = 12,
    ExecutionReportPendingReplaceMessage = 13,
    ExecutionReportReplacedMessage = 14,
    ExecutionReportTradeCorrectionMessage = 15,
    ExecutionReportTradeBreakMessage = 16,
    ExecutionReportRestatementMessage = 17,
    OrderCancelRejectMessage = 18,
    MassCancelRejectMessage = 20,
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 1,
    ImmediateOrCancel = 2,
    FillOrKill = 3,
    GoodForTime = 4,
    RegularHoursOnly = 5,
    NullValue = 255,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Common Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CommonHeader {
    public MessageType MessageType;
    public ushort MessageLength;
};

/// <summary>
///  Struct for Exec Inst
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecInst {
    public fixed byte Reserved13[13];
    public fixed byte ExternalRoutingNotAllowed[1];
    public fixed byte IntermarketSweep[1];
    public fixed byte ParticipateDoNotInitiate[1];
};

/// <summary>
///  Struct for Execution Report Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportCanceledMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte OrigClOrdId[16];
    public ulong OrderId;
    public ulong ExecId;
    public OrdStatus OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
    public CancelReason CancelReason;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Report New Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportNewMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public fixed sbyte Mpid[4];
    public OrdStatus OrdStatus;
    public fixed sbyte SymbolExecutionReportNewSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public OrdType OrdType;
    public uint OrderQty;
    public long Price;
    public TimeInForce TimeInForce;
    public OrderCapacity OrderCapacity;
    public CustOrderCapacity CustOrderCapacity;
    public fixed byte ExecInst[0];
    public long PegOffsetValue;
    public PegPriceType PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public DisplayMethod DisplayMethod;
    public ReserveReplenishTiming ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public RepriceFrequency RepriceFrequency;
    public RepriceBehavior RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public SelfTradePrevention SelfTradePrevention;
    public ushort RiskGroupId;
    public uint LeavesQty;
    public uint CumQty;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Report Pending Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportPendingCancelMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte OrigClOrdId[16];
    public ulong ExecId;
    public fixed sbyte SymbolExecutionReportPendingCancelSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public OrdStatus OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
};

/// <summary>
///  Struct for Execution Report Pending New Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportPendingNewMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public fixed sbyte Mpid[4];
    public OrdStatus OrdStatus;
    public fixed sbyte SymbolExecutionReportPendingNewSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public OrdType OrdType;
    public uint OrderQty;
    public long Price;
    public TimeInForce TimeInForce;
    public OrderCapacity OrderCapacity;
    public CustOrderCapacity CustOrderCapacity;
    public fixed byte ExecInst[0];
    public long PegOffsetValue;
    public PegPriceType PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public DisplayMethod DisplayMethod;
    public ReserveReplenishTiming ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public RepriceFrequency RepriceFrequency;
    public RepriceBehavior RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public SelfTradePrevention SelfTradePrevention;
    public ushort RiskGroupId;
    public uint LeavesQty;
    public uint CumQty;
};

/// <summary>
///  Struct for Execution Report Pending Replace Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportPendingReplaceMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte OrigClOrdId[16];
    public ulong ExecId;
    public fixed sbyte SymbolExecutionReportPendingReplaceSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public uint DisplayQty;
    public fixed sbyte LocateReqd[1];
    public OrdStatus OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
};

/// <summary>
///  Struct for Execution Report Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportRejectedMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public OrdStatus OrdStatus;
    public fixed sbyte SymbolExecutionReportRejectedSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public uint LeavesQty;
    public uint CumQty;
    public RejectReason RejectReason;
};

/// <summary>
///  Struct for Execution Report Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportReplacedMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte OrigClOrdId[16];
    public ulong ExecId;
    public fixed sbyte SymbolExecutionReportReplacedSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public uint DisplayQty;
    public fixed sbyte LocateReqd[1];
    public OrdStatus OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Report Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportRestatementMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public OrdStatus OrdStatus;
    public long LastPx;
    public uint LeavesQty;
    public uint CumQty;
    public uint LastShares;
    public ExecRestatementReason ExecRestatementReason;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Report Trade Break Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeBreakMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public ulong ExecRefId;
    public ulong TrdMatchId;
    public OrdStatus OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
};

/// <summary>
///  Struct for Execution Report Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeCorrectionMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public ulong ExecRefId;
    public ulong TrdMatchId;
    public OrdStatus OrdStatus;
    public long LastPx;
    public uint LastQty;
    public uint LeavesQty;
    public uint CumQty;
};

/// <summary>
///  Struct for Execution Report Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeMessage {
    public ulong SendingTime;
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public ulong ExecId;
    public OrdStatus OrdStatus;
    public uint LastQty;
    public long LastPx;
    public uint LeavesQty;
    public uint CumQty;
    public ulong TransactTime;
    public LastLiquidityInd LastLiquidityInd;
    public LastMkt LastMkt;
    public ulong TrdMatchingId;
};

/// <summary>
///  Struct for Login Accepted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginAcceptedMessage {
    public SupportedRequestMode SupportedRequestMode;
};

/// <summary>
///  Struct for Login Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRejectedMessage {
    public LoginRejectCode LoginRejectCode;
};

/// <summary>
///  Struct for Login Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRequestMessage {
    public fixed sbyte TokenType[1];
    public fixed sbyte Token[1];
};

/// <summary>
///  Struct for Mass Cancel Done Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelDoneMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
};

/// <summary>
///  Struct for Mass Cancel Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelRejectMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte SymbolMassCancelRejectSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public long LowerThanPrice;
    public long HigherThanPrice;
    public ushort CancelGroupId;
    public RejectReason RejectReason;
};

/// <summary>
///  Struct for Mass Cancel Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelRequestMessage {
    public fixed sbyte ClOrdId[16];
    public fixed sbyte SymbolMassCancelRequestSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public long LowerThanPrice;
    public long HigherThanPrice;
    public ushort CancelGroupId;
};

/// <summary>
///  Struct for New Order Single Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingleMessage {
    public fixed sbyte ClOrdId[16];
    public fixed sbyte Mpid[4];
    public fixed sbyte SymbolNewOrderSingleSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public TimeInForce TimeInForce;
    public OrderCapacity OrderCapacity;
    public CustOrderCapacity CustOrderCapacity;
    public fixed byte ExecInst[0];
    public long PegOffsetValue;
    public PegPriceType PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public DisplayMethod DisplayMethod;
    public ReserveReplenishTiming ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public RepriceFrequency RepriceFrequency;
    public RepriceBehavior RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public SelfTradePrevention SelfTradePrevention;
    public ushort RiskGroupId;
};

/// <summary>
///  Struct for Order Cancel Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelRejectMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public CxlRejResponseTo CxlRejResponseTo;
    public CxlRejReason CxlRejReason;
};

/// <summary>
///  Struct for Order Cancel Replace Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelReplaceRequestMessage {
    public fixed sbyte OrigClOrdId[16];
    public fixed sbyte ClOrdId[16];
    public fixed sbyte SymbolOrderCancelReplaceRequestSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public uint DisplayQty;
    public fixed sbyte LocateReqd[1];
};

/// <summary>
///  Struct for Order Cancel Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelRequestMessage {
    public fixed sbyte OrigClOrdId[16];
    public ulong OrderId;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte SymbolOrderCancelRequestSymbol[6];
    public fixed sbyte SymbolSfx[6];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte CommonHeader[0];
};

/// <summary>
///  Struct for Pending Mass Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PendingMassCancelMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte SymbolPendingMassCancelSymbol[6];
    public fixed sbyte SymbolSfx[6];
    public Side Side;
    public long LowerThanPrice;
    public long HigherThanPrice;
    public ushort CancelGroupId;
};

/// <summary>
///  Struct for Replay All Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplayAllRequestMessage {
    public ulong SessionId;
};

/// <summary>
///  Struct for Replay Begin Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplayBeginMessage {
    public ulong NextSequenceNumber;
    public uint PendingMessageCount;
};

/// <summary>
///  Struct for Replay Complete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplayCompleteMessage {
    public ulong MessageCount;
};

/// <summary>
///  Struct for Replay Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplayRejectedMessage {
    public ReplayRejectCode ReplayRejectCode;
};

/// <summary>
///  Struct for Replay Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplayRequestMessage {
    public ulong SessionId;
    public ulong NextSequenceNumber;
    public uint Count;
};

/// <summary>
///  Struct for Sbe Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SbeHeader {
    public ushort BlockLength;
    public TemplateId TemplateId;
    public byte SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Sbe Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SbeMessage {
    public fixed byte SbeHeader[0];
};

/// <summary>
///  Struct for Sequenced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequencedMessage {
};

/// <summary>
///  Struct for Stream Begin Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamBeginMessage {
    public ulong NextSequenceNumber;
    public fixed byte MaxSequenceNumber[0];
};

/// <summary>
///  Struct for Stream Complete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamCompleteMessage {
    public ulong TotalSequenceCount;
};

/// <summary>
///  Struct for Stream Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamRejectedMessage {
    public StreamRejectCode StreamRejectCode;
};

/// <summary>
///  Struct for Stream Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamRequestMessage {
    public ulong SessionId;
    public ulong NextSequenceNumber;
};

/// <summary>
///  Struct for Unsequenced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsequencedMessage {
};

