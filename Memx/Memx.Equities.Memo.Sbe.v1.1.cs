// C# Structs For Memx Equities Sbe Memo 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

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
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = 1,
    Limit = 2,
    Pegged = 3,
    NullValue = 255,
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
///  Struct for Execution Report Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionReportCanceledMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte OrigClOrdId[16];
    public ulong OrderId;
    public ulong ExecId;
    public byte OrdStatus;
    public uint LeavesQty;
    public uint CumQty;
    public byte CancelReason;
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
    public byte OrdStatus;
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public OrdType OrdType;
    public uint OrderQty;
    public long Price;
    public byte TimeInForce;
    public byte OrderCapacity;
    public byte CustOrderCapacity;
    public ushort ExecInst;
    public long PegOffsetValue;
    public byte PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public byte DisplayMethod;
    public byte ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public byte RepriceFrequency;
    public byte RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public byte SelfTradePrevention;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte OrdStatus;
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
    public byte OrdStatus;
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public OrdType OrdType;
    public uint OrderQty;
    public long Price;
    public byte TimeInForce;
    public byte OrderCapacity;
    public byte CustOrderCapacity;
    public ushort ExecInst;
    public long PegOffsetValue;
    public byte PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public byte DisplayMethod;
    public byte ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public byte RepriceFrequency;
    public byte RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public byte SelfTradePrevention;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public uint DisplayQty;
    public fixed sbyte LocateReqd[1];
    public byte OrdStatus;
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
    public byte OrdStatus;
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public uint LeavesQty;
    public uint CumQty;
    public byte RejectReason;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public uint DisplayQty;
    public fixed sbyte LocateReqd[1];
    public byte OrdStatus;
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
    public byte OrdStatus;
    public long LastPx;
    public uint LeavesQty;
    public uint CumQty;
    public uint LastShares;
    public byte ExecRestatementReason;
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
    public byte OrdStatus;
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
    public byte OrdStatus;
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
    public byte OrdStatus;
    public uint LastQty;
    public long LastPx;
    public uint LeavesQty;
    public uint CumQty;
    public ulong TransactTime;
    public byte LastLiquidityInd;
    public fixed sbyte LastMkt[1];
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public long LowerThanPrice;
    public long HigherThanPrice;
    public ushort CancelGroupId;
    public byte RejectReason;
};

/// <summary>
///  Struct for Mass Cancel Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelRequestMessage {
    public fixed sbyte ClOrdId[16];
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
    public uint OrderQty;
    public OrdType OrdType;
    public long Price;
    public byte TimeInForce;
    public byte OrderCapacity;
    public byte CustOrderCapacity;
    public ushort ExecInst;
    public long PegOffsetValue;
    public byte PegPriceType;
    public ulong ExpireTime;
    public uint MinQty;
    public uint DisplayQty;
    public byte DisplayMethod;
    public byte ReserveReplenishTiming;
    public uint DisplayMinIncr;
    public fixed sbyte LocateReqd[1];
    public byte RepriceFrequency;
    public byte RepriceBehavior;
    public ushort CancelGroupId;
    public ushort StpGroupId;
    public byte SelfTradePrevention;
    public ushort RiskGroupId;
};

/// <summary>
///  Struct for Order Cancel Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelRejectMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public byte CxlRejResponseTo;
    public byte CxlRejReason;
};

/// <summary>
///  Struct for Order Cancel Replace Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelReplaceRequestMessage {
    public fixed sbyte OrigClOrdId[16];
    public fixed sbyte ClOrdId[16];
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
};

/// <summary>
///  Struct for Pending Mass Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PendingMassCancelMessage {
    public ulong SendingTime;
    public fixed sbyte ClOrdId[16];
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public byte Side;
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

