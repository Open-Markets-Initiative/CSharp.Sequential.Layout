// C# Structs For Cboe Futures Pitch DepthOfBook 1.1.6 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Futures Flags Values
/// </summary>
public enum FuturesFlags : byte {
    Standard = 0,
    Variance = 1,
};

/// <summary>
///  Issue Values
/// </summary>
public enum Issue : byte {
    InitialSettlement = (byte)'S',
    ReissuedSettlement = (byte)'R',
};

/// <summary>
///  Listing State Values
/// </summary>
public enum ListingState : byte {
    Active = (byte)'A',
    Inactive = (byte)'I',
    Test = (byte)'T',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = 0x20,
    UnitClearMessage = 0x97,
    TimeReferenceMessage = 0xB1,
    FuturesInstrumentDefinitionMessage = 0xBB,
    AddOrderLongMessage = 0x21,
    AddOrderShortMessage = 0x22,
    OrderExecutedMessage = 0x23,
    ReduceSizeLongMessage = 0x25,
    ReduceSizeShortMessage = 0x26,
    ModifyOrderLongMessage = 0x27,
    ModifyOrderShortMessage = 0x28,
    DeleteOrderMessage = 0x29,
    TradeLongMessage = 0x2A,
    TradeShortMessage = 0x2B,
    TransactionBegin = 0xBC,
    TransactionEnd = 0xBD,
    TradeBreakMessage = 0x2C,
    SettlementMessage = 0xB9,
    EndOfDaySummaryMessage = 0xBA,
    TradingStatusMessage = 0x31,
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
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    NormalTrade = (byte)' ',
    OpeningTrade = (byte)'O',
    SpreadTrade = (byte)'S',
    BlockTrade = (byte)'B',
    EcrpTrade = (byte)'E',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Halted = (byte)'H',
    QuoteOnly = (byte)'Q',
    ExchangeSpecificSuspension = (byte)'S',
    Trading = (byte)'T',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

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
///  Struct for End Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDaySummaryMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol[6];
    public uint TradeDate;
    public uint OpenInterest;
    public ulong HighPrice;
    public ulong LowPrice;
    public ulong OpenPrice;
    public ulong ClosePrice;
    public uint TotalVolume;
    public uint BlockVolume;
    public uint EcrpVolume;
    public fixed byte SummaryFlags[0];
};

/// <summary>
///  Struct for End Of Session Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSessionMessage {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Future Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureLeg {
    public int LegRatio;
    public fixed sbyte LegSymbol[6];
};

/// <summary>
///  Struct for Futures Instrument Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesInstrumentDefinitionMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol[6];
    public uint UnitTimestamp;
    public fixed sbyte ReportSymbol[6];
    public FuturesFlags FuturesFlags;
    public uint ExpirationDate;
    public ushort ContractSize;
    public ListingState ListingState;
    public ulong PriceIncrement;
    public byte LegCount;
    public byte LegOffset;
    public byte VarianceBlockOffset;
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
    public uint LongQuantity;
    public ulong LongPrice;
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
///  Struct for Settlement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlementMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol[6];
    public uint TradeDate;
    public ulong SettlementPrice;
    public Issue Issue;
};

/// <summary>
///  Struct for Standard
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Standard {
};

/// <summary>
///  Struct for Summary Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SummaryFlags {
    public fixed byte ReservedFlags[7];
    public fixed byte OfferCloseValid[1];
    public fixed byte LowPriceIsOffer[1];
    public fixed byte LowPriceValid[1];
    public fixed byte HighPriceIsBid[1];
    public fixed byte HighPriceValid[1];
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Time;
    public uint Epoch;
};

/// <summary>
///  Struct for Time Reference Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeReferenceMessage {
    public uint MidnightReference;
    public uint Time;
    public uint TimeOffset;
    public uint TradeDate;
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
    public fixed sbyte Symbol[6];
    public fixed sbyte Reserved2[2];
    public TradingStatus TradingStatus;
    public fixed sbyte Reserved3[3];
};

/// <summary>
///  Struct for Transaction Begin
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TransactionBegin {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Transaction End
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TransactionEnd {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Unit Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitClearMessage {
    public uint TimeOffset;
};

/// <summary>
///  Struct for Variance
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Variance {
    public long RealizedVariance;
    public ushort NumExpectedPrices;
    public ushort NumElapsedReturns;
    public ulong PreviousSettlement;
    public long DiscountFactor;
    public ulong InitialStrike;
    public long PreviousArmvm;
    public long FedFundsRate;
};

