// C# Structs For Cboe Options Pitch DepthOfBook 2.39.4 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Opening = (byte)'O',
    Closing = (byte)'C',
    Halt = (byte)'H',
    Ipo = (byte)'I',
    Close = (byte)'M',
    Sum = (byte)'T',
    Bam = (byte)'B',
};

/// <summary>
///  Customer Indicator Values
/// </summary>
public enum CustomerIndicator : byte {
    NonCustomer = (byte)'N',
    Customer = (byte)'C',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = 0x20,
    UnitClearMessage = 0x97,
    AddOrderLongMessage = 0x21,
    AddOrderShortMessage = 0x22,
    AddOrderExpandedMessage = 0x2F,
    OrderExecutedMessage = 0x23,
    OrderExecutedAtPriceSizeMessage = 0x24,
    ReduceSizeLongMessage = 0x25,
    ReduceSizeShortMessage = 0x26,
    ModifyOrderLongMessage = 0x27,
    ModifyOrderShortMessage = 0x28,
    DeleteOrderMessage = 0x29,
    TradeLongMessage = 0x2A,
    TradeShortMessage = 0x2B,
    TradeExpandedMessage = 0x30,
    TradeBreakMessage = 0x2C,
    EndOfSessionMessage = 0x2D,
    SymbolMappingMessage = 0x2E,
    TradingStatusMessage = 0x31,
    AuctionUpdateMessage = 0x95,
    AuctionSummaryMessage = 0x96,
    AuctionNotificationMessage = 0xAD,
    AuctionCancelMessage = 0xAE,
    AuctionTradeMessage = 0xAF,
    RetailPriceImprovementMessage = 0x98,
};

/// <summary>
///  Reg Sho Action Values
/// </summary>
public enum RegShoAction : byte {
    NoPriceTestInEffect = (byte)'0',
    RegShoPriceTestRestrictionInEffect = (byte)'1',
};

/// <summary>
///  Retail Price Improvement Values
/// </summary>
public enum RetailPriceImprovement : byte {
    BuySide = (byte)'B',
    SellSide = (byte)'S',
    BuyAndSell = (byte)'A',
    NoRpi = (byte)'N',
};

/// <summary>
///  Side Indicator Values
/// </summary>
public enum SideIndicator : byte {
    BuyOrder = (byte)'B',
    SellOrder = (byte)'S',
};

/// <summary>
///  Symbol Condition Values
/// </summary>
public enum SymbolCondition : byte {
    Normal = (byte)'N',
    ClosingOnly = (byte)'C',
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    NormalTrade = (byte)' ',
    SpreadTrade = (byte)'S',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    AcceptingOrders = (byte)'A',
    Halted = (byte)'H',
    QuoteOnly = (byte)'Q',
    ExchangeSpecificSuspension = (byte)'S',
    Trading = (byte)'T',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddFlags {
    public fixed byte Reserved7[7];
    public fixed byte Display[1];
};

/// <summary>
///  Struct for Add Order Expanded Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderExpandedMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint LongQuantity;
    public fixed sbyte ExpandedSymbol[8];
    public ulong LongPrice;
    public fixed byte AddFlags[0];
    public fixed sbyte ParticipantId[4];
    public CustomerIndicator CustomerIndicator;
};

/// <summary>
///  Struct for Add Order Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint LongQuantity;
    public fixed sbyte Symbol[6];
    public ulong LongPrice;
    public fixed byte AddFlags[0];
};

/// <summary>
///  Struct for Add Order Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public ushort ShortQuantity;
    public fixed sbyte Symbol[6];
    public ushort ShortPrice;
    public fixed byte AddFlags[0];
};

/// <summary>
///  Struct for Auction Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionCancelMessage {
    public uint TimeOffset;
    public ulong AuctionId;
};

/// <summary>
///  Struct for Auction Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionNotificationMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol[6];
    public ulong AuctionId;
    public AuctionType AuctionType;
    public SideIndicator SideIndicator;
    public ulong LongPrice;
    public uint Contracts;
    public CustomerIndicator CustomerIndicator;
    public fixed sbyte ParticipantId[4];
    public uint AuctionEndOffset;
};

/// <summary>
///  Struct for Auction Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionSummaryMessage {
    public uint TimeOffset;
    public fixed sbyte StockSymbol[8];
    public AuctionType AuctionType;
    public ulong LongPrice;
    public uint Shares;
};

/// <summary>
///  Struct for Auction Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionTradeMessage {
    public uint TimeOffset;
    public ulong AuctionId;
    public ulong ExecutionId;
    public ulong LongPrice;
    public uint Contracts;
};

/// <summary>
///  Struct for Auction Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionUpdateMessage {
    public uint TimeOffset;
    public fixed sbyte StockSymbol[8];
    public AuctionType AuctionType;
    public ulong ReferencePrice;
    public uint BuyShares;
    public uint SellShares;
    public ulong IndicativePrice;
    public ulong AuctionOnlyPrice;
};

/// <summary>
///  Struct for Delete Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderMessage {
    public uint TimeOffset;
    public ulong OrderId;
};

/// <summary>
///  Struct for End Of Session Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSessionMessage {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public byte MessageLength;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Modify Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyFlags {
    public fixed byte Reserved6[6];
    public fixed byte MaintainPriority[1];
    public fixed byte Display[1];
};

/// <summary>
///  Struct for Modify Order Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public uint LongQuantity;
    public ulong LongPrice;
    public fixed byte ModifyFlags[0];
};

/// <summary>
///  Struct for Modify Order Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public ushort ShortQuantity;
    public ushort ShortPrice;
    public fixed byte ModifyFlags[0];
};

/// <summary>
///  Struct for Order Executed At Price Size Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedAtPriceSizeMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public uint ExecutedQuantity;
    public uint RemainingQuantity;
    public ulong ExecutionId;
    public ulong LongPrice;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public uint ExecutedQuantity;
    public ulong ExecutionId;
    public TradeCondition TradeCondition;
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
    public ushort Length;
    public byte Count;
    public byte Unit;
    public uint Sequence;
};

/// <summary>
///  Struct for Reduce Size Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReduceSizeLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public uint CanceledLongQuantity;
};

/// <summary>
///  Struct for Reduce Size Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReduceSizeShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public ushort CanceledShortQuantity;
};

/// <summary>
///  Struct for Retail Price Improvement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetailPriceImprovementMessage {
    public uint TimeOffset;
    public fixed sbyte ExpandedSymbol[8];
    public RetailPriceImprovement RetailPriceImprovement;
};

/// <summary>
///  Struct for Symbol Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolMappingMessage {
    public fixed sbyte FeedSymbol[6];
    public fixed sbyte OsiSymbol[21];
    public SymbolCondition SymbolCondition;
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Time;
};

/// <summary>
///  Struct for Trade Break Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBreakMessage {
    public uint TimeOffset;
    public ulong ExecutionId;
};

/// <summary>
///  Struct for Trade Expanded Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeExpandedMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint LongQuantity;
    public fixed sbyte ExpandedSymbol[8];
    public ulong LongPrice;
    public ulong ExecutionId;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Trade Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint LongQuantity;
    public fixed sbyte Symbol[6];
    public ulong LongPrice;
    public ulong ExecutionId;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Trade Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public ushort ShortQuantity;
    public fixed sbyte Symbol[6];
    public ushort ShortPrice;
    public ulong ExecutionId;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingStatusMessage {
    public uint TimeOffset;
    public fixed sbyte ExpandedSymbol[8];
    public TradingStatus TradingStatus;
    public RegShoAction RegShoAction;
    public fixed sbyte Reserved1[1];
    public fixed sbyte Reserved2[1];
};

/// <summary>
///  Struct for Unit Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitClearMessage {
    public uint TimeOffset;
};

