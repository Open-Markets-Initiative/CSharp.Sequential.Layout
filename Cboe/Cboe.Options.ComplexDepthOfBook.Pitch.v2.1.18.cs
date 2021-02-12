// C# Structs For Cboe Options Pitch ComplexDepthOfBook 2.1.18 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Opening Type Values
/// </summary>
public enum AuctionOpeningType : byte {
    Gth = (byte)'G',
    Rth = (byte)'O',
    HaltReopening = (byte)'H',
};

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    ComplexAuction = (byte)'C',
    ComplexSolicitationAuction = (byte)'S',
    ComplexAim = (byte)'B',
    CoaAllOrNone = (byte)'O',
};

/// <summary>
///  Customer Indicator Values
/// </summary>
public enum CustomerIndicator : byte {
    NonCustomer = (byte)'N',
    Customer = (byte)'C',
};

/// <summary>
///  Gth Trading Status Values
/// </summary>
public enum GthTradingStatus : byte {
    Halted = (byte)'H',
    QuoteOnly = (byte)'Q',
    Trading = (byte)'T',
};

/// <summary>
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    Option = (byte)'O',
    Equity = (byte)'E',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = 0x20,
    UnitClearMessage = 0x97,
    TransactionBegin = 0xBC,
    TransactionEndMessage = 0xBD,
    ComplexInstrumentDefinitionExpandedMessage = 0x9A,
    SymbolMappingMessage = 0x2E,
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
    AuctionNotificationMessage = 0xAD,
    AuctionCancelMessage = 0xAE,
    AuctionTradeMessage = 0xAF,
    TradingStatusMessage = 0x31,
    AuctionUpdateMessage = 0xD1,
    AuctionSummaryMessage = 0x96,
    EndOfSessionMessage = 0x2D,
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
    ComplexToComplexElectronicTrade = (byte)'F',
    ComplexAuctionTrade = (byte)'G',
    ComplexCross = (byte)'H',
    ComplexElectronicTradeAgainstSingle = (byte)'J',
    ComplexWithStockOptionsAuctionTrade = (byte)'K',
    ComplexWithStockElectronicTrade = (byte)'N',
    ComplexWithStockCross = (byte)'O',
    ElectronicTrade = (byte)'L',
    OpeningTrade = (byte)'O',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Halted = (byte)'H',
    QuoteOnly = (byte)'Q',
    Trading = (byte)'T',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order Expanded Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderExpandedMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint Quantity;
    public fixed sbyte ComplexInstrumentId8[8];
    public long Price;
    public fixed byte Reserved[1];
    public fixed sbyte ParticipantId[4];
    public CustomerIndicator CustomerIndicator;
    public fixed sbyte ClientId[4];
};

/// <summary>
///  Struct for Add Order Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint Quantity;
    public fixed sbyte ComplexInstrumentId[6];
    public long Price;
    public fixed byte Padding[1];
};

/// <summary>
///  Struct for Add Order Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public ushort QuantityShort;
    public fixed sbyte ComplexInstrumentId[6];
    public short PriceShort;
    public fixed byte Padding[1];
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
    public fixed sbyte ComplexInstrumentId[6];
    public ulong AuctionId;
    public AuctionType AuctionType;
    public SideIndicator SideIndicator;
    public long Price;
    public uint Quantity;
    public CustomerIndicator CustomerIndicator;
    public fixed sbyte ParticipantId[4];
    public uint AuctionEndOffset;
    public fixed sbyte ClientId[4];
};

/// <summary>
///  Struct for Auction Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionSummaryMessage {
    public uint TimeOffset;
    public fixed sbyte ComplexInstrumentId8[8];
    public AuctionOpeningType AuctionOpeningType;
    public long Price;
    public uint Quantity;
};

/// <summary>
///  Struct for Auction Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionTradeMessage {
    public uint TimeOffset;
    public ulong AuctionId;
    public ulong ExecutionId;
    public long Price;
    public uint Quantity;
};

/// <summary>
///  Struct for Auction Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionUpdateMessage {
    public uint TimeOffset;
    public fixed sbyte ComplexInstrumentId8[8];
    public AuctionOpeningType AuctionOpeningType;
    public ulong ReferencePrice;
    public uint BuyContracts;
    public uint SellContracts;
    public long IndicativePrice;
    public long AuctionOnlyPrice;
    public fixed sbyte OpeningCondition[1];
    public long CompositeMarketBidPrice;
    public long CompositeMarketOfferPrice;
};

/// <summary>
///  Struct for Complex Instrument Definition Expanded Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentDefinitionExpandedMessage {
    public uint TimeOffset;
    public fixed sbyte ComplexInstrumentId[6];
    public fixed sbyte ComplexInstrumentUnderlying[8];
    public fixed sbyte ComplexInstrumentType[4];
    public byte LegCount;
};

/// <summary>
///  Struct for Complex Instrument Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentLeg {
    public fixed sbyte LegSymbol[8];
    public int LegRatio;
    public LegSecurityType LegSecurityType;
};

/// <summary>
///  Struct for Complex Instrument Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentType {
    public fixed sbyte ComplexAuctionType[1];
    public fixed byte ComplexAuctionReservedBytes[3];
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
///  Struct for Modify Order Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public uint Quantity;
    public long Price;
    public fixed byte Padding[1];
};

/// <summary>
///  Struct for Modify Order Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public ushort QuantityShort;
    public short PriceShort;
    public fixed byte Padding[1];
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
    public long Price;
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
    public uint CanceledQuantity;
};

/// <summary>
///  Struct for Reduce Size Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReduceSizeShortMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public ushort CanceledQuantityShort;
};

/// <summary>
///  Struct for Symbol Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolMappingMessage {
    public fixed sbyte FeedSymbol[6];
    public fixed sbyte OsiSymbol[21];
    public SymbolCondition SymbolCondition;
    public fixed sbyte Underlying[8];
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Time;
};

/// <summary>
///  Struct for Trade Long Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeLongMessage {
    public uint TimeOffset;
    public ulong OrderId;
    public SideIndicator SideIndicator;
    public uint Quantity;
    public fixed sbyte ComplexInstrumentId[6];
    public long Price;
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
    public ushort QuantityShort;
    public fixed sbyte ComplexInstrumentId[6];
    public short PriceShort;
    public ulong ExecutionId;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingStatusMessage {
    public uint TimeOffset;
    public fixed sbyte ComplexSymbolId[6];
    public fixed byte Unused[2];
    public TradingStatus TradingStatus;
    public fixed byte Reserved[1];
    public GthTradingStatus GthTradingStatus;
    public fixed byte Padding[1];
};

/// <summary>
///  Struct for Transaction Begin
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TransactionBegin {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Transaction End Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TransactionEndMessage {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Unit Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitClearMessage {
    public uint TimeOffset;
};

