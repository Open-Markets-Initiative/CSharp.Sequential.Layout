// C# Structs For Asx Securities Ouch SR8 2.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Capacity Of Participant Values
/// </summary>
public enum CapacityOfParticipant : byte {
    Agency = (byte)'A',
    Principal = (byte)'P',
    MixedAgencyAndPrincipal = (byte)'M',
};

/// <summary>
///  Directed Wholesale Values
/// </summary>
public enum DirectedWholesale : byte {
    True = (byte)'Y',
    FalseDefault = (byte)'N',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    EnterOrderMessage = (byte)'O',
    ReplaceOrderMessage = (byte)'U',
    CancelOrderMessage = (byte)'X',
    CancelByOrderIdMessage = (byte)'Y',
    OrderAcceptedMessage = (byte)'A',
    OrderRejectedMessage = (byte)'J',
    OrderReplacedMessage = (byte)'U',
    OrderCancelledMessage = (byte)'C',
    OrderExecutedMessage = (byte)'E',
};

/// <summary>
///  Order State Values
/// </summary>
public enum OrderState : byte {
    OnBook = 1,
    NotOnBook = 2,
    OuchOwnershipLost = 99,
};

/// <summary>
///  Ouch Order Type Values
/// </summary>
public enum OuchOrderType : byte {
    LimitOrder = (byte)'Y',
    CentrePointOrder = (byte)'N',
    CentrePointOrder = (byte)'D',
    SweepOrder = (byte)'S',
    DualpostedSweepOrder = (byte)'P',
    CentrePointBlockOrderWithSingleFillMaq = (byte)'B',
    CentrePointOrderWithSingleFillMaq = (byte)'F',
    LimitSweepOrderWithSingleFillMaq = (byte)'T = Limit Sweep order (can be dual-posted if entered price is at half-tick) with single fill MAQ',
    AnyPriceBlockOrder = (byte)'C',
    AnyPriceBlockOrderWithSingleFillMaq = (byte)'E',
};

/// <summary>
///  Packet Type Values
/// </summary>
public enum PacketType : byte {
    DebugPacket = (byte)'+',
    LoginAcceptedPacket = (byte)'A',
    LoginRejectedPacket = (byte)'J',
    SequencedDataPacket = (byte)'S',
    ServerHeartbeatPacket = (byte)'H',
    EndOfSessionPacket = (byte)'Z',
    LoginRequestPacket = (byte)'L',
    UnsequencedDataPacket = (byte)'U',
    ClientHeartbeatPacket = (byte)'R',
    LogoutRequestPacket = (byte)'O',
};

/// <summary>
///  Reason Values
/// </summary>
public enum Reason : byte {
    CancelledByUser = 1,
    OrderInactivatedDueToConnectionLoss = 4,
    FillAndKillOrderThatWasDeletedInAnAuction = 9,
    OrderDeletedByAsxOnBehalfOfTheCustomer = 10,
    DeletedBySystemDueToInstrumentSessionChange = 20,
    InactivatedBySystemDueToInstrumentSessionChange = 21,
    InactivatedDayOrder = 24,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    BuyOrder = (byte)'B',
    SellOrder = (byte)'S',
    ShortSellOrder = (byte)'T',
    BuyOrderInACombination = (byte)'C',
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 0,
    FillAndKill = 3,
    FillOrKill = 4,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel By Order Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelByOrderIdMessage {
    public uint OrderBookId;
    public Side Side;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderMessage {
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Debug Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DebugPacket {
    public fixed sbyte Text[1];
};

/// <summary>
///  Struct for Enter Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnterOrderMessage {
    public fixed sbyte OrderToken[14];
    public uint OrderBookId;
    public Side Side;
    public ulong Quantity;
    public int Price;
    public TimeInForce TimeInForce;
    public byte OpenClose;
    public fixed sbyte ClientAccount[10];
    public fixed sbyte CustomerInfo[15];
    public fixed sbyte ExchangeInfo[32];
    public fixed sbyte ClearingParticipant[1];
    public uint CrossingKey;
    public CapacityOfParticipant CapacityOfParticipant;
    public DirectedWholesale DirectedWholesale;
    public fixed sbyte ExecutionVenue[4];
    public fixed sbyte IntermediaryId[10];
    public fixed sbyte OrderOrigin[20];
    public fixed sbyte Filler[8];
    public OuchOrderType OuchOrderType;
    public ulong ShortSellQuantity;
    public ulong MinimumAcceptableQuantity;
};

/// <summary>
///  Struct for Login Accepted Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginAcceptedPacket {
    public fixed sbyte Session[10];
    public fixed sbyte SequenceNumber[20];
};

/// <summary>
///  Struct for Login Rejected Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRejectedPacket {
    public fixed sbyte RejectReasonCode[1];
};

/// <summary>
///  Struct for Login Request Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRequestPacket {
    public fixed sbyte Username[6];
    public fixed sbyte Password[10];
    public fixed sbyte RequestedSession[10];
    public fixed sbyte RequestedSequenceNumber[20];
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Order Accepted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcceptedMessage {
    public ulong TimestampNanoseconds;
    public fixed sbyte OrderToken[14];
    public uint OrderBookId;
    public Side Side;
    public ulong OrderId;
    public ulong Quantity;
    public int Price;
    public TimeInForce TimeInForce;
    public byte OpenClose;
    public fixed sbyte ClientAccount[10];
    public OrderState OrderState;
    public fixed sbyte CustomerInfo[15];
    public fixed sbyte ExchangeInfo[32];
    public fixed sbyte ClearingParticipant[1];
    public uint CrossingKey;
    public CapacityOfParticipant CapacityOfParticipant;
    public DirectedWholesale DirectedWholesale;
    public fixed sbyte ExecutionVenue[4];
    public fixed sbyte IntermediaryId[10];
    public fixed sbyte OrderOrigin[20];
    public fixed sbyte Filler[8];
    public OuchOrderType OuchOrderType;
    public ulong ShortSellQuantity;
    public ulong MinimumAcceptableQuantity;
};

/// <summary>
///  Struct for Order Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledMessage {
    public ulong TimestampNanoseconds;
    public fixed sbyte OrderToken[14];
    public uint OrderBookId;
    public Side Side;
    public ulong OrderId;
    public Reason Reason;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public ulong TimestampNanoseconds;
    public fixed sbyte OrderToken[14];
    public uint OrderBookId;
    public ulong TradedQuantity;
    public int TradePrice;
    public fixed byte MatchId[12];
    public ushort DealSource;
    public byte MatchAttributes;
};

/// <summary>
///  Struct for Order Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedMessage {
    public ulong TimestampNanoseconds;
    public fixed sbyte OrderToken[14];
    public uint RejectCode;
};

/// <summary>
///  Struct for Order Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplacedMessage {
    public ulong TimestampNanoseconds;
    public fixed sbyte ReplacementOrderToken[14];
    public fixed sbyte PreviousOrderToken[14];
    public uint OrderBookId;
    public Side Side;
    public ulong OrderId;
    public ulong Quantity;
    public int Price;
    public TimeInForce TimeInForce;
    public byte OpenClose;
    public fixed sbyte ClientAccount[10];
    public OrderState OrderState;
    public fixed sbyte CustomerInfo[15];
    public fixed sbyte ExchangeInfo[32];
    public fixed sbyte ClearingParticipant[1];
    public uint CrossingKey;
    public CapacityOfParticipant CapacityOfParticipant;
    public DirectedWholesale DirectedWholesale;
    public fixed sbyte ExecutionVenue[4];
    public fixed sbyte IntermediaryId[10];
    public fixed sbyte OrderOrigin[20];
    public fixed sbyte Filler[8];
    public OuchOrderType OuchOrderType;
    public ulong ShortSellQuantity;
    public ulong MinimumAcceptableQuantity;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte PacketHeader[0];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public ushort PacketLength;
    public PacketType PacketType;
};

/// <summary>
///  Struct for Replace Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplaceOrderMessage {
    public fixed sbyte ExistingOrderToken[14];
    public fixed sbyte ReplacementOrderToken[14];
    public ulong Quantity;
    public int Price;
    public byte OpenClose;
    public fixed sbyte ClientAccount[10];
    public fixed sbyte CustomerInfo[15];
    public fixed sbyte ExchangeInfo[32];
    public CapacityOfParticipant CapacityOfParticipant;
    public DirectedWholesale DirectedWholesale;
    public fixed sbyte ExecutionVenue[4];
    public fixed sbyte IntermediaryId[10];
    public fixed sbyte OrderOrigin[20];
    public fixed sbyte Filler[8];
    public ulong ShortSellQuantity;
    public ulong MinimumAcceptableQuantity;
};

/// <summary>
///  Struct for Sequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequencedDataPacket {
};

/// <summary>
///  Struct for Unsequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsequencedDataPacket {
};

