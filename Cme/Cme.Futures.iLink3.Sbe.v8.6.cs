// C# Structs For Cme Futures Sbe iLink3 8.6 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Cmta Give Up Cd Values
/// </summary>
public enum CmtaGiveUpCd : byte {
    NoValue = (byte)'0',
    GiveUp = (byte)'G',
    SgXoffset = (byte)'S',
};

/// <summary>
///  Cust Order Capacity Values
/// </summary>
public enum CustOrderCapacity : byte {
    NoValue = 255,
    Membertradingfortheirownaccount = 1,
    Clearingfirmtradingforitsproprietaryaccount = 2,
    Membertradingforanothermember = 3,
    Allother = 4,
};

/// <summary>
///  Dk Reason Values
/// </summary>
public enum DkReason : byte {
    NoValue = (byte)'0',
    UnknownSecurity = (byte)'A',
    WrongSide = (byte)'B',
    QuantityExceedsOrder = (byte)'C',
    NoMatchingOrder = (byte)'D',
    PriceExceedsLimit = (byte)'E',
    CalculationDifference = (byte)'F',
    NoMatchingExecutionReport = (byte)'G',
    Other = (byte)'Z',
};

/// <summary>
///  Exec Ack Status Values
/// </summary>
public enum ExecAckStatus : byte {
    Accepted = 1,
    Rejected = 2,
};

/// <summary>
///  Mass Action Response Values
/// </summary>
public enum MassActionResponse : byte {
    Rejected = 0,
    Accepted = 1,
};

/// <summary>
///  Mass Action Scope Values
/// </summary>
public enum MassActionScope : byte {
    Instrument = 1,
    All = 7,
    MarketSegmentId = 9,
    InstrumentGroup = 10,
    QuoteSetId = 100,
};

/// <summary>
///  Order Event Type Values
/// </summary>
public enum OrderEventType : byte {
    NoValue = 255,
    PartiallyFilled = 4,
    Filled = 5,
};

/// <summary>
///  Party Detail Role Values
/// </summary>
public enum PartyDetailRole : ushort {
    ExecutingFirm = 1,
    CustomerAccount = 24,
    TakeUpFirm = 96,
    Operator = 118,
    TakeUpAccount = 1000,
};

/// <summary>
///  Short Sale Type Values
/// </summary>
public enum ShortSaleType : byte {
    NoValue = 255,
    LongSell = 0,
    ShortSaleWithNoExemptionSesh = 1,
    ShortSaleWithExemptionSsex = 2,
    UndisclosedSellInformationNotAvailableUndi = 3,
};

/// <summary>
///  Side Time In Force Values
/// </summary>
public enum SideTimeInForce : byte {
    Day = 0,
    Fak = 3,
};

/// <summary>
///  Split Msg Values
/// </summary>
public enum SplitMsg : byte {
    NoValue = 255,
    SplitMessageDelayed = 0,
    OutofOrderMessageDelayed = 1,
    CompleteMessageDelayed = 2,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    Negotiate = 500,
    NegotiationResponse = 501,
    NegotiationReject = 502,
    Establish = 503,
    EstablishmentAck = 504,
    EstablishmentReject = 505,
    Sequence = 506,
    Terminate = 507,
    RetransmitRequest = 508,
    Retransmission = 509,
    RetransmitReject = 510,
    NotApplied = 513,
    NewOrderSingle = 514,
    OrderCancelReplaceRequest = 515,
    OrderCancelRequest = 516,
    MassQuote = 517,
    PartyDetailsDefinitionRequest = 518,
    PartyDetailsDefinitionRequestAck = 519,
    BusinessReject = 521,
    ExecutionReportNew = 522,
    ExecutionReportReject = 523,
    ExecutionReportElimination = 524,
    ExecutionReportTradeOutright = 525,
    ExecutionReportTradeSpread = 526,
    ExecutionReportTradeSpreadLeg = 527,
    QuoteCancel = 528,
    OrderMassActionRequest = 529,
    OrderMassStatusRequest = 530,
    ExecutionReportModify = 531,
    ExecutionReportStatus = 532,
    OrderStatusRequest = 533,
    ExecutionReportCancel = 534,
    OrderCancelReject = 535,
    OrderCancelReplaceReject = 536,
    PartyDetailsListRequest = 537,
    PartyDetailsListReport = 538,
    ExecutionAck = 539,
    RequestForQuote = 543,
    NewOrderCross = 544,
    MassQuoteAck = 545,
    RequestForQuoteAck = 546,
    ExecutionReportTradeAddendumOutright = 548,
    ExecutionReportTradeAddendumSpread = 549,
    ExecutionReportTradeAddendumSpreadLeg = 550,
    SecurityDefinitionRequest = 560,
    SecurityDefinitionResponse = 561,
    OrderMassActionReport = 562,
    QuoteCancelAck = 563,
    ExecutionReportPendingCancel = 564,
    ExecutionReportPendingReplace = 565,
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 0,
    GoodTillCancel = 1,
    FillAndKill = 3,
    FillOrKill = 4,
    GoodTillDate = 6,
    GoodForSession = 99,
    Null = 255,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Affected Orders Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AffectedOrdersGroup {
    public fixed sbyte Origclordid[20];
    public ulong AffectedOrderId;
    public uint CxlQuantity;
};

/// <summary>
///  Struct for Affected Orders Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AffectedOrdersGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Business Reject 521
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BusinessReject521 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte SenderId[20];
    public ulong PartyDetailsListReqId;
    public ulong SendingTimeEpoch;
    public ulong BusinessRejectRefId;
    public fixed sbyte Location[5];
    public uint RefSeqNum;
    public ushort RefTagId;
    public ushort BusinessRejectReason;
    public fixed sbyte RefMsgType[2];
    public byte PossRetransFlag;
    public byte ManualOrderIndicator;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Calculated Ccy Last Qty
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CalculatedCcyLastQty {
    public long Mantissa64;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Contra Calculated Ccy Last Qty
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContraCalculatedCcyLastQty {
    public long Mantissa64;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Contra Gross Trade Amt
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContraGrossTradeAmt {
    public long Mantissa64;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Establishment Ack 504
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EstablishmentAck504 {
    public ulong Uuid;
    public ulong RequestTimestamp;
    public uint NextSeqNo;
    public uint PreviousSeqNo;
    public ulong PreviousUuid;
    public ushort KeepAliveInterval;
    public ushort SecretKeySecureIdExpiration;
    public byte FaultToleranceIndicator;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Establishment Reject 505
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EstablishmentReject505 {
    public fixed sbyte Reason[48];
    public ulong Uuid;
    public ulong RequestTimestamp;
    public uint NextSeqNo;
    public ushort ErrorCodes;
    public byte FaultToleranceIndicator;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Exec Inst
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecInst {
    public fixed byte Reserved5[1];
    public fixed byte Reserved4[1];
    public fixed byte Reserved3[1];
    public fixed byte Reserved2[1];
    public fixed byte Reserved1[1];
    public fixed byte Nh[1];
    public fixed byte Ob[1];
    public fixed byte Aon[1];
};

/// <summary>
///  Struct for Execution Ack 539
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionAck539 {
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public ExecAckStatus ExecAckStatus;
    public uint SeqNum;
    public fixed sbyte Clordid[20];
    public ulong SecExecId;
    public long LastPx;
    public int SecurityId;
    public uint LastQty;
    public DkReason DkReason;
    public byte Side;
    public fixed sbyte SenderId[20];
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
    public byte ManualOrderIndicator;
};

/// <summary>
///  Struct for Execution Report Cancel 534
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportCancel534 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint CumQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public ushort DelayDuration;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public byte ExecRestatementReason;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Elimination 524
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportElimination524 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint CumQty;
    public uint OrderQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Modify 531
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportModify531 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint CumQty;
    public uint LeavesQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public ushort DelayDuration;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report New 522
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportNew522 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public ushort DelayDuration;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Pending Cancel 564
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportPendingCancel564 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint CumQty;
    public uint LeavesQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Pending Replace 565
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportPendingReplace565 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint CumQty;
    public uint LeavesQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public ShortSaleType ShortSaleType;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Reject 523
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportReject523 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort OrdRejReason;
    public ushort ExpireDate;
    public ushort DelayDuration;
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public ulong DelayToTime;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Status 532
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportStatus532 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long Price;
    public long StopPx;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong OrdStatusReqId;
    public ulong MassStatusReqId;
    public ulong CrossId;
    public ulong HostCrossId;
    public fixed sbyte Location[5];
    public int SecurityId;
    public uint OrderQty;
    public uint CumQty;
    public uint LeavesQty;
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdStatus[1];
    public fixed sbyte OrdType[1];
    public byte Side;
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public byte LastRptRequested;
    public fixed sbyte CrossType[1];
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Execution Report Trade Addendum Outright Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumOutrightOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
    public uint OriginalOrderEventExecId;
    public fixed byte ContraGrossTradeAmt[0];
    public fixed byte ContraCalculatedCcyLastQty[0];
};

/// <summary>
///  Struct for Execution Report Trade Addendum Outright Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumOutrightOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadLegGroup {
    public ulong LegExecId;
    public long LegLastPx;
    public ulong LegExecRefId;
    public uint LegTradeId;
    public uint LegTradeRefId;
    public int LegSecurityId;
    public uint LegLastQty;
    public byte LegSide;
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadLegGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Leg Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadLegOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
    public uint OriginalOrderEventExecId;
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Leg Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadLegOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
    public uint OriginalOrderEventExecId;
};

/// <summary>
///  Struct for Execution Report Trade Addendum Spread Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeAddendumSpreadOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Outright Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeOutrightOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
    public fixed byte ContraGrossTradeAmt[0];
    public fixed byte ContraCalculatedCcyLastQty[0];
};

/// <summary>
///  Struct for Execution Report Trade Outright Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeOutrightOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Spread Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadLegGroup {
    public ulong LegExecId;
    public long LegLastPx;
    public int LegSecurityId;
    public uint LegTradeId;
    public uint LegLastQty;
    public byte LegSide;
};

/// <summary>
///  Struct for Execution Report Trade Spread Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadLegGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Spread Leg Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadLegOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
};

/// <summary>
///  Struct for Execution Report Trade Spread Leg Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadLegOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Execution Report Trade Spread Order Event Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadOrderEventGroup {
    public long OrderEventPx;
    public fixed sbyte OrderEventText[5];
    public uint OrderEventExecId;
    public uint OrderEventQty;
    public OrderEventType OrderEventType;
    public byte OrderEventReason;
};

/// <summary>
///  Struct for Execution Report Trade Spread Order Event Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportTradeSpreadOrderEventGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Fills Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FillsGroup {
    public long FillPx;
    public uint FillQty;
    public fixed sbyte FillExecId[2];
    public byte FillYieldType;
};

/// <summary>
///  Struct for Fills Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FillsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Gross Trade Amt
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GrossTradeAmt {
    public long Mantissa64;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Group Size
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSize {
    public ushort BlockLength;
    public byte NumInGroup;
};

/// <summary>
///  Struct for Leg Option Delta
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegOptionDelta {
    public int Mantissa32;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Mass Quote 517
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuote517 {
    public ulong PartyDetailsListReqId;
    public ulong SendingTimeEpoch;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong QuoteReqId;
    public fixed sbyte Location[5];
    public uint QuoteId;
    public byte TotNoQuoteEntries;
    public byte MmProtectionReset;
    public byte LiquidityFlag;
    public ShortSaleType ShortSaleType;
    public fixed sbyte Reserved[30];
};

/// <summary>
///  Struct for Mass Quote Ack 545
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteAck545 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte SenderId[20];
    public ulong PartyDetailsListReqId;
    public ulong RequestTime;
    public ulong SendingTimeEpoch;
    public ulong QuoteReqId;
    public fixed sbyte Location[5];
    public uint QuoteId;
    public ushort QuoteRejectReason;
    public ushort DelayDuration;
    public byte QuoteStatus;
    public byte ManualOrderIndicator;
    public byte NoProcessedEntries;
    public byte MmProtectionReset;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public ShortSaleType ShortSaleType;
    public byte TotNoQuoteEntries;
    public byte PossRetransFlag;
    public ulong DelayToTime;
};

/// <summary>
///  Struct for Mass Quote Ack Entry Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteAckEntryGroup {
    public uint QuoteEntryId;
    public int SecurityId;
    public ushort QuoteSetId;
    public byte QuoteEntryRejectReason;
};

/// <summary>
///  Struct for Mass Quote Ack Entry Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteAckEntryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Mass Quote Entry Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteEntryGroup {
    public long BidPx;
    public long OfferPx;
    public uint QuoteEntryId;
    public int SecurityId;
    public uint BidSize;
    public uint OfferSize;
    public int UnderlyingSecurityId;
    public ushort QuoteSetId;
};

/// <summary>
///  Struct for Mass Quote Entry Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassQuoteEntryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Maturity Month Year
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MaturityMonthYear {
    public ushort Year;
    public byte Month;
    public byte Day;
    public byte Week;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Negotiation Reject 502
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NegotiationReject502 {
    public fixed sbyte Reason[48];
    public ulong Uuid;
    public ulong RequestTimestamp;
    public ushort ErrorCodes;
    public byte FaultToleranceIndicator;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for New Order Cross 544
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCross544 {
    public ulong CrossId;
    public ulong OrderRequestId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public long Price;
    public ulong TransBkdTime;
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
    public int SecurityId;
};

/// <summary>
///  Struct for New Order Single 514
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderSingle514 {
    public long Price;
    public uint OrderQty;
    public int SecurityId;
    public byte Side;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderRequestId;
    public ulong SendingTimeEpoch;
    public long StopPx;
    public fixed sbyte Location[5];
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdType[1];
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Not Applied 513
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotApplied513 {
    public ulong Uuid;
    public uint FromSeqNo;
    public ushort MsgCount;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Option Delta
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionDelta {
    public int Mantissa32;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Order Cancel Reject 535
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelReject535 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public fixed sbyte Location[5];
    public ushort CxlRejReason;
    public ushort DelayDuration;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public ulong DelayToTime;
};

/// <summary>
///  Struct for Order Cancel Replace Reject 536
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelReplaceReject536 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte ExecId[40];
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public fixed sbyte Location[5];
    public ushort CxlRejReason;
    public ushort DelayDuration;
    public byte ManualOrderIndicator;
    public byte PossRetransFlag;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public ulong DelayToTime;
};

/// <summary>
///  Struct for Order Cancel Replace Request 515
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelReplaceRequest515 {
    public long Price;
    public uint OrderQty;
    public int SecurityId;
    public byte Side;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public ulong OrderId;
    public long StopPx;
    public ulong OrderRequestId;
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
    public uint MinQty;
    public uint DisplayQty;
    public ushort ExpireDate;
    public fixed sbyte OrdType[1];
    public TimeInForce TimeInForce;
    public byte ManualOrderIndicator;
    public byte OfmOverride;
    public fixed byte ExecInst[0];
    public fixed sbyte ExecutionMode[1];
    public byte LiquidityFlag;
    public byte ManagedOrder;
    public ShortSaleType ShortSaleType;
    public long DiscretionPrice;
};

/// <summary>
///  Struct for Order Cancel Request 516
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelRequest516 {
    public ulong OrderId;
    public ulong PartyDetailsListReqId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public fixed sbyte Clordid[20];
    public ulong OrderRequestId;
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
    public int SecurityId;
    public byte Side;
    public byte LiquidityFlag;
};

/// <summary>
///  Struct for Order Mass Action Report 562
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderMassActionReport562 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte SenderId[20];
    public ulong PartyDetailsListReqId;
    public ulong TransactTime;
    public ulong SendingTimeEpoch;
    public ulong OrderRequestId;
    public ulong MassActionReportId;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte Location[5];
    public int SecurityId;
    public ushort DelayDuration;
    public MassActionResponse MassActionResponse;
    public byte ManualOrderIndicator;
    public MassActionScope MassActionScope;
    public uint TotalAffectedOrders;
    public byte LastFragment;
    public byte MassActionRejectReason;
    public byte MarketSegmentId;
    public byte MassCancelRequestType;
    public byte Side;
    public fixed sbyte OrdType[1];
    public TimeInForce TimeInForce;
    public SplitMsg SplitMsg;
    public byte LiquidityFlag;
    public byte PossRetransFlag;
    public ulong DelayToTime;
};

/// <summary>
///  Struct for Order Mass Action Request 529
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderMassActionRequest529 {
    public ulong PartyDetailsListReqId;
    public ulong OrderRequestId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong SendingTimeEpoch;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte Location[5];
    public int SecurityId;
    public MassActionScope MassActionScope;
    public byte MarketSegmentId;
    public byte MassCancelRequestType;
    public byte Side;
    public fixed sbyte OrdType[1];
    public TimeInForce TimeInForce;
    public byte LiquidityFlag;
};

/// <summary>
///  Struct for Order Mass Status Request 530
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderMassStatusRequest530 {
    public ulong PartyDetailsListReqId;
    public ulong MassStatusReqId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong SendingTimeEpoch;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte Location[5];
    public int SecurityId;
    public byte MassStatusReqType;
    public byte OrdStatusReqType;
    public TimeInForce TimeInForce;
    public byte MarketSegmentId;
};

/// <summary>
///  Struct for Order Status Request 533
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderStatusRequest533 {
    public ulong PartyDetailsListReqId;
    public ulong OrdStatusReqId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong OrderId;
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
};

/// <summary>
///  Struct for Party Details Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyDetailsGroup {
    public fixed sbyte PartyDetailId[20];
    public PartyDetailRole PartyDetailRole;
};

/// <summary>
///  Struct for Party Details Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyDetailsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Party I Ds Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyIDsGroup {
    public ulong PartyId;
    public fixed sbyte PartyIdSource[1];
    public ushort PartyRole;
};

/// <summary>
///  Struct for Party I Ds Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartyIDsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Quote Cancel Ack Entry Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelAckEntryGroup {
    public uint QuoteEntryId;
    public int SecurityId;
    public byte QuoteEntryRejectReason;
};

/// <summary>
///  Struct for Quote Cancel Ack Entry Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelAckEntryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Quote Cancel Ack Set Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelAckSetGroup {
    public ushort QuoteSetId;
    public ushort QuoteErrorCode;
};

/// <summary>
///  Struct for Quote Cancel Ack Set Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelAckSetGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Quote Cancel Entry Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelEntryGroup {
    public fixed sbyte SecurityGroup[6];
    public int SecurityId;
};

/// <summary>
///  Struct for Quote Cancel Entry Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelEntryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Quote Cancel Set Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelSetGroup {
    public uint BidSize;
    public uint OfferSize;
    public ushort QuoteSetId;
};

/// <summary>
///  Struct for Quote Cancel Set Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelSetGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Related Sym Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroup {
    public int SecurityId;
    public uint OrderQty;
    public byte Side;
};

/// <summary>
///  Struct for Related Sym Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Request For Quote 543
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForQuote543 {
    public ulong PartyDetailsListReqId;
    public ulong QuoteReqId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong SendingTimeEpoch;
    public fixed sbyte Location[5];
    public byte QuoteType;
};

/// <summary>
///  Struct for Request For Quote Ack 546
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForQuoteAck546 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte SenderId[20];
    public fixed sbyte ExchangeQuoteReqId[17];
    public ulong PartyDetailsListReqId;
    public ulong RequestTime;
    public ulong SendingTimeEpoch;
    public ulong QuoteReqId;
    public fixed sbyte Location[5];
    public ushort QuoteRejectReason;
    public ushort DelayDuration;
    public byte QuoteStatus;
    public byte ManualOrderIndicator;
    public SplitMsg SplitMsg;
    public byte PossRetransFlag;
    public ulong DelayToTime;
};

/// <summary>
///  Struct for Requesting Party I Ds Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestingPartyIDsGroup {
    public fixed sbyte RequestingPartyId[5];
    public fixed sbyte RequestingPartyIdSource[1];
    public fixed sbyte RequestingPartyRole[1];
};

/// <summary>
///  Struct for Requesting Party I Ds Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestingPartyIDsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Retransmission 509
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Retransmission509 {
    public ulong Uuid;
    public ulong LastUuid;
    public ulong RequestTimestamp;
    public uint FromSeqNo;
    public ushort MsgCount;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Retransmit Reject 510
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitReject510 {
    public fixed sbyte Reason[48];
    public ulong Uuid;
    public ulong LastUuid;
    public ulong RequestTimestamp;
    public ushort ErrorCodes;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Retransmit Request 508
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitRequest508 {
    public ulong Uuid;
    public ulong LastUuid;
    public ulong RequestTimestamp;
    public uint FromSeqNo;
    public ushort MsgCount;
};

/// <summary>
///  Struct for Risk Free Rate
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RiskFreeRate {
    public int Mantissa32;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Security Definition Request 560
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionRequest560 {
    public ulong PartyDetailsListReqId;
    public ulong SecurityReqId;
    public byte ManualOrderIndicator;
    public uint SeqNum;
    public fixed sbyte SenderId[20];
    public ulong SendingTimeEpoch;
    public fixed sbyte SecuritySubType[8];
    public fixed sbyte Location[5];
    public ushort StartDate;
    public ushort EndDate;
    public byte MaxNoOfSubstitutions;
    public int SourceRepoId;
};

/// <summary>
///  Struct for Security Definition Request Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionRequestLegGroup {
    public long LegPrice;
    public int LegSecurityId;
    public fixed byte LegOptionDelta[0];
    public byte LegSide;
    public byte LegRatioQty;
};

/// <summary>
///  Struct for Security Definition Request Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionRequestLegGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Security Definition Response 561
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionResponse561 {
    public uint SeqNum;
    public ulong Uuid;
    public fixed sbyte Text[256];
    public fixed sbyte FinancialInstrumentFullName[35];
    public fixed sbyte SenderId[20];
    public fixed sbyte Symbol[20];
    public ulong PartyDetailsListReqId;
    public ulong SecurityReqId;
    public ulong SecurityResponseId;
    public ulong SendingTimeEpoch;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte SecurityType[6];
    public fixed sbyte Location[5];
    public int SecurityId;
    public fixed sbyte Currency[3];
    public fixed byte MaturityMonthYear[0];
    public ushort DelayDuration;
    public ushort StartDate;
    public ushort EndDate;
    public byte MaxNoOfSubstitutions;
    public int SourceRepoId;
    public fixed sbyte TerminationType[8];
    public byte SecurityResponseType;
    public byte ExpirationCycle;
    public byte ManualOrderIndicator;
    public SplitMsg SplitMsg;
    public byte AutoQuoteRequest;
    public byte PossRetransFlag;
};

/// <summary>
///  Struct for Security Definition Response Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionResponseLegGroup {
    public long LegPrice;
    public fixed byte LegOptionDelta[0];
    public int LegSecurityId;
    public byte LegSide;
    public byte LegRatioQty;
};

/// <summary>
///  Struct for Security Definition Response Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionResponseLegGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Sequence 506
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Sequence506 {
    public ulong Uuid;
    public uint NextSeqNo;
    public byte FaultToleranceIndicator;
    public byte KeepAliveIntervalLapsed;
};

/// <summary>
///  Struct for Sides Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SidesGroup {
    public fixed sbyte Clordid[20];
    public ulong PartyDetailsListReqId;
    public uint OrderQty;
    public byte Side;
    public SideTimeInForce SideTimeInForce;
};

/// <summary>
///  Struct for Sides Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SidesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Simple Open Framing Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleOpenFramingHeader {
    public ushort MessageLength;
    public ushort EncodingType;
};

/// <summary>
///  Struct for Terminate 507
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Terminate507 {
    public fixed sbyte Reason[48];
    public ulong Uuid;
    public ulong RequestTimestamp;
    public ushort ErrorCodes;
    public SplitMsg SplitMsg;
};

/// <summary>
///  Struct for Time To Expiration
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeToExpiration {
    public int Mantissa32;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Trd Reg Publications Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TrdRegPublicationsGroup {
    public byte TrdRegPublicationType;
    public byte TrdRegPublicationReason;
};

/// <summary>
///  Struct for Trd Reg Publications Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TrdRegPublicationsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Volatility
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Volatility {
    public long Mantissa64;
    public sbyte Exponent;
};

