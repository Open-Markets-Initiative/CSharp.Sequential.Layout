// C# Structs For Nasdaq Ouch Orders 4.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Bbo Weight Indicator Values
/// </summary>
public enum BboWeightIndicator : byte {
    002 = (byte)'0',
    021 = (byte)'1',
    12 = (byte)'2',
    GreaterThan2 = (byte)'3',
    SetsTheQbbo = (byte)'S',
    ImprovesTheNbboUponEntry = (byte)'N',
};

/// <summary>
///  Buy Sell Indicator Values
/// </summary>
public enum BuySellIndicator : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    SellShort = (byte)'T',
    SellShortExempt = (byte)'E',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    Other = (byte)'O',
    Agency = (byte)'A',
    Principal = (byte)'P',
    Riskless = (byte)'R',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    NoCross = (byte)'N',
    Opening = (byte)'O',
    Closing = (byte)'C',
    HaltIpoCross = (byte)'H',
    Supplemental = (byte)'S',
    Retail = (byte)'R',
    Extended = (byte)'E',
};

/// <summary>
///  Customer Type Values
/// </summary>
public enum CustomerType : byte {
    RetailDesignated = (byte)'R',
    NotARetailDesignated = (byte)'N',
};

/// <summary>
///  Display Values
/// </summary>
public enum Display : byte {
    AttributablePrice = (byte)'A',
    AnonymousPrice = (byte)'Y',
    NonDisplay = (byte)'N',
    PostOnly = (byte)'P',
    ImbalanceOnly = (byte)'I',
    MidPoint = (byte)'M',
    MidPoint = (byte)'W',
    PostOnlyAndAttributable = (byte)'L',
    RetailOrder = (byte)'O',
    RetailOrder = (byte)'T',
    RetailPrice = (byte)'Q',
    MidPoint = (byte)'m',
    NonDisplayAndMidPoint = (byte)'n',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfDay—ThisIsAlwaysTheFirstMessageEachDay = (byte)'S',
    EndOfDay—ThisIndicatesThatNasdaqIsNowClosedAndWillNotAcceptAnyNewOrdersOrReplacesInThisSession = (byte)'E',
};

/// <summary>
///  Intermarket Sweep Eligibility Values
/// </summary>
public enum IntermarketSweepEligibility : byte {
    Eligible = (byte)'Y',
    NotEligible = (byte)'N',
    Tradeat = (byte)'y',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    EnterOrderMessage = (byte)'O',
    ReplaceOrderMessage = (byte)'U',
    CancelOrderMessage = (byte)'X',
    ModifyOrderMessage = (byte)'M',
    TradeNowMessage = (byte)'N',
    SystemEventMessage = (byte)'S',
    AcceptedMessage = (byte)'A',
    ReplacedMessage = (byte)'U',
    CanceledMessage = (byte)'C',
    AiqCancelledMessage = (byte)'C',
    ExecutedMessage = (byte)'E',
    BrokenTradeMessage = (byte)'B',
    ExecutedWithReferencePriceMessage = (byte)'G',
    TradeCorrectionMessage = (byte)'F',
    RejectedOrderMessage = (byte)'J',
    CancelPendingMessage = (byte)'P',
    CancelRejectMessage = (byte)'I',
    OrderPriorityUpdateMessage = (byte)'T',
    OrderModifiedMessage = (byte)'U',
};

/// <summary>
///  Order State Values
/// </summary>
public enum OrderState : byte {
    Order = (byte)'L',
    Order = (byte)'D',
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


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Accepted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AcceptedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public ulong OrderReferenceNumber;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
    public OrderState OrderState;
    public BboWeightIndicator BboWeightIndicator;
};

/// <summary>
///  Struct for Aiq Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AiqCancelledMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint DecrementShares;
    public fixed sbyte Reason[1];
    public uint QuantityPreventedFromTrading;
    public uint ExecutionPrice;
    public fixed sbyte LiquidityFlag[1];
};

/// <summary>
///  Struct for Broken Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public ulong MatchNumber;
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderMessage {
    public fixed sbyte OrderToken[14];
    public uint Shares;
};

/// <summary>
///  Struct for Cancel Pending Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelPendingMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Cancel Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CanceledMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint DecrementShares;
    public fixed sbyte Reason[1];
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
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
    public CustomerType CustomerType;
};

/// <summary>
///  Struct for Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint ExecutedShares;
    public uint ExecutionPrice;
    public fixed sbyte LiquidityFlag[1];
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Executed With Reference Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutedWithReferencePriceMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint ExecutedShares;
    public uint ExecutionPrice;
    public fixed sbyte LiquidityFlag[1];
    public ulong MatchNumber;
    public uint ReferencePrice;
    public fixed sbyte ReferencePriceType[1];
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
///  Struct for Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderMessage {
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
};

/// <summary>
///  Struct for Order Modified Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
};

/// <summary>
///  Struct for Order Priority Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriorityUpdateMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint Price;
    public Display Display;
    public ulong OrderReferenceNumber;
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
///  Struct for Rejected Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RejectedOrderMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Replace Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplaceOrderMessage {
    public fixed sbyte ExistingOrderToken[14];
    public fixed sbyte ReplacementOrderToken[14];
    public uint Shares;
    public uint Price;
    public uint TimeInForce;
    public Display Display;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
};

/// <summary>
///  Struct for Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplacedMessage {
    public ulong Timestamp;
    public fixed sbyte ReplacementOrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public ulong OrderReferenceNumber;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
    public OrderState OrderState;
    public fixed sbyte PreviousOrderToken[14];
    public BboWeightIndicator BboWeightIndicator;
};

/// <summary>
///  Struct for Sequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequencedDataPacket {
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public ulong Timestamp;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint ExecutedShares;
    public uint ExecutionPrice;
    public fixed sbyte LiquidityFlag[1];
    public ulong MatchNumber;
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Trade Now Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeNowMessage {
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Unsequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsequencedDataPacket {
};

