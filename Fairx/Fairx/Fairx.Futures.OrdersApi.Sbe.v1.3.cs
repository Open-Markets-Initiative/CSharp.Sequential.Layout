// C# Structs For Fairx Futures Sbe OrdersApi 1.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Cancel Reason Values
/// </summary>
public enum CancelReason : byte {
    Expired = 0,
    Canceledbyuser = 1,
    Selfmatchprevention = 2,
    Clientdisconnect = 3,
    Pricelimit = 4,
    Admincancel = 5,
    Masscancel = 6,
    Streamreplaced = 7,
    Activelimitexceeded = 8,
};

/// <summary>
///  Current Session Only Values
/// </summary>
public enum CurrentSessionOnly : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Is Aggressor Values
/// </summary>
public enum IsAggressor : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Is Last Message Values
/// </summary>
public enum IsLastMessage : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Only Current Session Values
/// </summary>
public enum OnlyCurrentSession : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Reject Reason Values
/// </summary>
public enum RejectReason : byte {
    Error = 1,
    Invalidinstrument = 2,
    Clordidinuse = 3,
    Validationfailure = 8,
    Unknownorder = 9,
    Unknownorder = 2,
    Orderfilled = 3,
    Beginexecidtoosmall = 1,
    Endexecidtoolarge = 2,
    Resendalreadyinprogress = 3,
    Toomanyresendrequests = 4,
    Servererror = 5,
};

/// <summary>
///  Request Trading Lock Values
/// </summary>
public enum RequestTradingLock : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Reset Seq Num Values
/// </summary>
public enum ResetSeqNum : sbyte {
    False = 0,
    True = 1,
};

/// <summary>
///  Security Type Values
/// </summary>
public enum SecurityType : byte {
    Futures = 0,
    Options = 1,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : sbyte {
    Buy = 1,
    Sell = -1,
};

/// <summary>
///  Status Values
/// </summary>
public enum Status : sbyte {
    Ok = 0,
    Temporarilyunavailable = 1,
    Backpressured = 2,
    Preopen = 1,
    Preopennocancel = 2,
    Readytotrade = 3,
    Tradinghalt = 4,
    Close = 5,
    Postclose = 6,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    LogonMessage = 100,
    LogonConfMessage = 200,
    LogoutMessage = 101,
    LoggedOutMessage = 201,
    HeartbeatMessage = 10,
    TestRequestMessage = 11,
    ResendRequestMessage = 102,
    GapFillMessage = 202,
    PingMessage = 102,
    PongMessage = 202,
    InstrumentInfoRequestMessage = 103,
    InstrumentInfoMessage = 203,
    SetAccountMessage = 105,
    SetTraderMessage = 106,
    SetAckMessage = 205,
    NewOrderMessage = 110,
    OrderEnteredMessage = 210,
    ReplaceOrderMessage = 120,
    StreamOrderMessage = 121,
    OrderRejectMessage = 221,
    OrderReplacedMessage = 220,
    CancelOrderMessage = 130,
    OrderCanceledMessage = 230,
    CancelOrderRejectMessage = 233,
    MassCancelOrderMessage = 131,
    MassCancelOrderAckMessage = 231,
    MassCancelOrderRejectMessage = 232,
    UnlockTradingMessage = 132,
    UnlockTradingAckMessage = 234,
    UnlockTradingRejectMessage = 235,
    OrderFilledMessage = 240,
    SpreadOrderFilledMessage = 241,
    LastExecIdRequestMessage = 150,
    LastExecIdMessage = 250,
    EventResendRequestMessage = 152,
    EventResendCompleteMessage = 252,
    EventResendRejectMessage = 253,
};

/// <summary>
///  Trading Lock Applied Values
/// </summary>
public enum TradingLockApplied : sbyte {
    False = 0,
    True = 1,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderMessage {
    public long ClientOrderId;
    public long CorrelationId;
    public int InstrumentId;
};

/// <summary>
///  Struct for Cancel Order Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderRejectMessage {
    public long Timestamp;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public RejectReason RejectReason;
    public fixed sbyte Details[47];
};

/// <summary>
///  Struct for Data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Data {
    public fixed byte Length[0];
};

/// <summary>
///  Struct for Event Resend Complete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventResendCompleteMessage {
    public long CorrelationId;
    public int ResentEventCount;
};

/// <summary>
///  Struct for Event Resend Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventResendRejectMessage {
    public long CorrelationId;
    public RejectReason RejectReason;
    public fixed sbyte Details[47];
};

/// <summary>
///  Struct for Event Resend Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventResendRequestMessage {
    public long CorrelationId;
    public long BeginExecId;
    public long EndExecId;
};

/// <summary>
///  Struct for Gap Fill Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GapFillMessage {
    public uint NewSequenceNumber;
    public uint GapFillPadding;
};

/// <summary>
///  Struct for Heartbeat Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HeartbeatMessage {
    public long CorrelationId;
};

/// <summary>
///  Struct for Instrument Info Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentInfoMessage {
    public long CorrelationId;
    public int InstrumentId;
    public SecurityType SecurityType;
    public Status Status;
    public IsLastMessage IsLastMessage;
    public uint Reserved;
    public fixed sbyte Symbol[32];
};

/// <summary>
///  Struct for Instrument Info Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentInfoRequestMessage {
    public long CorrelationId;
};

/// <summary>
///  Struct for Last Exec Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LastExecIdMessage {
    public long Timestamp;
    public long LastExecId;
    public long CorrelationId;
};

/// <summary>
///  Struct for Last Exec Id Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LastExecIdRequestMessage {
    public long CorrelationId;
};

/// <summary>
///  Struct for Logged Out Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoggedOutMessage {
    public fixed sbyte Reason[64];
};

/// <summary>
///  Struct for Logon Conf Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonConfMessage {
    public int HeartbeatIntervalSeconds;
};

/// <summary>
///  Struct for Logon Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonMessage {
    public fixed sbyte Username[16];
    public fixed sbyte Password[32];
    public ResetSeqNum ResetSeqNum;
};

/// <summary>
///  Struct for Logout Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutMessage {
    public fixed sbyte Reason[64];
};

/// <summary>
///  Struct for Mass Cancel Order Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelOrderAckMessage {
    public long Timestamp;
    public long ExecId;
    public long CorrelationId;
    public int CanceledCount;
    public OnlyCurrentSession OnlyCurrentSession;
    public TradingLockApplied TradingLockApplied;
};

/// <summary>
///  Struct for Mass Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelOrderMessage {
    public long CorrelationId;
    public long LimitPrice;
    public int InstrumentId;
    public Side Side;
    public CurrentSessionOnly CurrentSessionOnly;
    public RequestTradingLock RequestTradingLock;
};

/// <summary>
///  Struct for Mass Cancel Order Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelOrderRejectMessage {
    public long Timestamp;
    public long CorrelationId;
    public fixed sbyte ErrorMessage[32];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public byte ProtocolId;
    public byte Flags;
    public ushort MessageLength;
    public uint SequenceNumber;
    public uint LastProcessedSeqNo;
    public uint Reserved;
    public long SendTimeEpochNanos;
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for New Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderMessage {
    public long ClientOrderId;
    public long CorrelationId;
    public long LimitPrice;
    public int Quantity;
    public int InstrumentId;
    public Side Side;
};

/// <summary>
///  Struct for Order Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCanceledMessage {
    public long Timestamp;
    public long ExecId;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public long ReceiveTime;
    public int TotalFilled;
    public int InstrumentId;
    public CancelReason CancelReason;
};

/// <summary>
///  Struct for Order Entered Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderEnteredMessage {
    public long Timestamp;
    public long ExecId;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public long ReceiveTime;
};

/// <summary>
///  Struct for Order Filled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderFilledMessage {
    public long Timestamp;
    public long ExecId;
    public long MatchId;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public long FilledVwap;
    public int TotalFilled;
    public int AvailableQty;
    public long FillPrice;
    public int FillQty;
    public int InstrumentId;
    public IsAggressor IsAggressor;
};

/// <summary>
///  Struct for Order Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectMessage {
    public long Timestamp;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public RejectReason RejectReason;
    public fixed sbyte Details[47];
};

/// <summary>
///  Struct for Order Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplacedMessage {
    public long Timestamp;
    public long ExecId;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public long ReceiveTime;
    public int TotalFilled;
    public int AvailableQty;
    public int InstrumentId;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
};

/// <summary>
///  Struct for Ping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PingMessage {
    public long CorrelationId;
    public long RequestTime;
};

/// <summary>
///  Struct for Pong Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PongMessage {
    public long CorrelationId;
    public long RequestTime;
    public long ServerTime;
    public Status Status;
};

/// <summary>
///  Struct for Replace Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplaceOrderMessage {
    public long ClientOrderId;
    public long CorrelationId;
    public long NewLimitPrice;
    public int NewQuantity;
    public int InstrumentId;
};

/// <summary>
///  Struct for Resend Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResendRequestMessage {
    public uint FromSequenceNumber;
    public uint ToSequenceNumber;
};

/// <summary>
///  Struct for Set Account Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SetAccountMessage {
    public long CorrelationId;
    public fixed sbyte Account[16];
};

/// <summary>
///  Struct for Set Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SetAckMessage {
    public long CorrelationId;
};

/// <summary>
///  Struct for Set Trader Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SetTraderMessage {
    public long CorrelationId;
    public fixed sbyte Trader[16];
};

/// <summary>
///  Struct for Spread Order Filled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpreadOrderFilledMessage {
    public long Timestamp;
    public long ExecId;
    public long MatchId;
    public long ClientOrderId;
    public long CorrelationId;
    public long OrderId;
    public long FilledVwap;
    public int TotalFilled;
    public int AvailableQty;
    public long FillPrice;
    public long Leg1FillPrice;
    public long Leg2FillPrice;
    public int FillQty;
    public int InstrumentId;
    public IsAggressor IsAggressor;
};

/// <summary>
///  Struct for Stream Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamOrderMessage {
    public long ClientOrderId;
    public long CorrelationId;
    public long LastProcessedFillId;
    public long LimitPrice;
    public int Quantity;
    public int InstrumentId;
    public Side Side;
};

/// <summary>
///  Struct for Test Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TestRequestMessage {
    public long CorrelationId;
};

/// <summary>
///  Struct for Unlock Trading Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnlockTradingAckMessage {
    public long Timestamp;
    public long CorrelationId;
    public int NumUsersAffected;
};

/// <summary>
///  Struct for Unlock Trading Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnlockTradingMessage {
    public long CorrelationId;
    public CurrentSessionOnly CurrentSessionOnly;
};

/// <summary>
///  Struct for Unlock Trading Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnlockTradingRejectMessage {
    public long Timestamp;
    public long CorrelationId;
    public fixed sbyte ErrorMessage[32];
};

