// C# Structs For Asx Securities Itch Ntp 1.05 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Buyer Side Values
/// </summary>
public enum BuyerSide : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    BusinessTradeDateHasEnded = (byte)'C',
};

/// <summary>
///  Expiry Month Values
/// </summary>
public enum ExpiryMonth : byte {
    Jan = 1,
    Feb = 2,
    Mar = 3,
    Apr = 4,
    May = 5,
    Jun = 6,
    Jul = 7,
    Aug = 8,
    Sep = 9,
    Oct = 10,
    Nov = 11,
    Dec = 12,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SecondsMessage = (byte)'T',
    EndOfBusinessTradeDateMessage = (byte)'S',
    FutureSymbolDirectoryMessage = (byte)'f',
    OptionsSymbolDirectoryMessage = (byte)'h',
    CombinationSymbolDirectoryMessage = (byte)'M',
    BundlesSymbolDirectory = (byte)'m',
    OrderBookStateMessage = (byte)'O',
    AddOrderMessage = (byte)'A',
    OrderVolumeCancelledMessage = (byte)'X',
    OrderDeletedMessage = (byte)'D',
    OrderExecutedMessage = (byte)'E',
    AuctionOrderExecutedMessage = (byte)'C',
    CombinationOrderExecutedMessage = (byte)'e',
    ImpliedOrderAddedMessage = (byte)'j',
    ImpliedOrderReplacedMessage = (byte)'l',
    ImpliedOrderDeletedMessage = (byte)'k',
    TradeExecutedMessage = (byte)'P',
    CombinationTradeExecutedMessage = (byte)'p',
    TradeCancellationMessage = (byte)'B',
    EquilibriumPriceMessage = (byte)'Z',
    OpenHighLowLastTradeAdjustmentMessage = (byte)'t',
    MarketSettlementMessage = (byte)'Y',
    TextMessage = (byte)'x',
    RequestForQuoteMessage = (byte)'q',
    AnomalousOrderThresholdPublishMessage = (byte)'W',
    VolumeAndOpenInterestMessage = (byte)'V',
};

/// <summary>
///  Opposite Side Values
/// </summary>
public enum OppositeSide : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Put = (byte)'P',
    Call = (byte)'C',
};

/// <summary>
///  Price Method Values
/// </summary>
public enum PriceMethod : byte {
    NetPrice = 0,
    YieldDifference = 2,
    Individual = 3,
    AveragePrice = 4,
};

/// <summary>
///  Rfq Side Values
/// </summary>
public enum RfqSide : byte {
    TwoSidedQuote = (byte)'T',
    BidQuote = (byte)'B',
    AskQuote = (byte)'S',
    Crossing = (byte)'X',
};

/// <summary>
///  Seller Side Values
/// </summary>
public enum SellerSide : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};

/// <summary>
///  Session State Values
/// </summary>
public enum SessionState : byte {
    PreOpen = (byte)'P',
    Opened = (byte)'O',
    RegulatoryHalt = (byte)'R',
    Halted = (byte)'H',
    Closed = (byte)'C',
    Maintenance = (byte)'M',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};

/// <summary>
///  Side Leg Values
/// </summary>
public enum SideLeg : byte {
    NotDefined = (byte)' ',
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Trade Type Values
/// </summary>
public enum TradeType : byte {
    NormalTrade = (byte)'T',
    NormalCross = (byte)'t',
    AuctionTrade = (byte)'L',
    AuctionCross = (byte)'l',
    CombinationToUnderlyingTrade = (byte)'S',
    CombinationToUnderlyingCross = (byte)'s',
    CombinationToCombinationTrade = (byte)'R',
    CombinationToCombinationCross = (byte)'r',
    StripToStripTrade = (byte)'A',
    StripToStripCross = (byte)'a',
    StripToOutrightTrade = (byte)'B',
    StripToOutrightCross = (byte)'b',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public ulong OrderBookPriority;
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Anomalous Order Threshold Publish Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AnomalousOrderThresholdPublishMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public long AotPrice;
    public long AotUpperPrice;
    public long AotLowerPrice;
    public long EtrPrice;
    public long EtrUpperPrice;
    public long EtrLowerPrice;
};

/// <summary>
///  Struct for Auction Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionOrderExecutedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public ulong TradeId;
    public uint ExecutedQuantity;
    public long TradePrice;
    public ulong OppositeOrderId;
};

/// <summary>
///  Struct for Bundle Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BundleLeg {
    public uint TradeableInstrumentIdLeg;
    public SideLeg SideLeg;
    public uint RatioLeg;
    public long PriceLeg;
};

/// <summary>
///  Struct for Bundles Symbol Directory
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BundlesSymbolDirectory {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public fixed sbyte SymbolName[32];
    public fixed sbyte LongName[60];
    public fixed sbyte CfiCode[6];
    public PriceMethod PriceMethod;
    public byte PriceDisplayDecimals;
    public uint PriceFractionalDenominator;
    public uint PriceMinimumTick;
    public byte Legs;
    public fixed byte BundleLeg[0];
};

/// <summary>
///  Struct for Combination Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CombinationLeg {
    public uint TradeableInstrumentIdLeg;
    public SideLeg SideLeg;
    public uint RatioLeg;
    public long PriceLeg;
};

/// <summary>
///  Struct for Combination Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CombinationOrderExecutedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public ulong TradeId;
    public uint ExecutedQuantity;
    public long TradePrice;
    public uint OppositeTradeableInstrumentId;
    public OppositeSide OppositeSide;
    public ulong OppositeOrderId;
    public ulong CombinationTradeId;
};

/// <summary>
///  Struct for Combination Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CombinationSymbolDirectoryMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public fixed sbyte SymbolName[32];
    public fixed sbyte LongName[60];
    public fixed sbyte CfiCode[6];
    public PriceMethod PriceMethod;
    public byte PriceDisplayDecimals;
    public uint PriceFractionalDenominator;
    public uint PriceMinimumTick;
    public byte Legs;
    public fixed byte CombinationLeg[0];
};

/// <summary>
///  Struct for Combination Trade Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CombinationTradeExecutedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public TradeType TradeType;
    public ulong TradeId;
    public uint ExecutedQuantity;
    public long TradePrice;
    public uint BuyerTradeableInstrumentId;
    public BuyerSide BuyerSide;
    public ulong BuyerOrderId;
    public ulong BuyerCombinationTradeId;
    public fixed sbyte BuyerParticipantId[3];
    public uint SellerTradeableInstrumentId;
    public SellerSide SellerSide;
    public ulong SellerOrderId;
    public ulong SellerCombinationTradeId;
    public fixed sbyte SellerParticipantId[3];
};

/// <summary>
///  Struct for End Of Business Trade Date Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfBusinessTradeDateMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Equilibrium Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquilibriumPriceMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public long EquilibriumPrice;
    public ulong MatchedQuantity;
    public ulong BidQuantity;
    public ulong AskQuantity;
};

/// <summary>
///  Struct for Future Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureSymbolDirectoryMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public fixed sbyte SymbolName[32];
    public fixed sbyte LongName[60];
    public fixed sbyte Isin[12];
    public fixed sbyte Exchange[6];
    public fixed sbyte Instrument[6];
    public fixed sbyte CfiCode[6];
    public ushort ExpiryYear;
    public ExpiryMonth ExpiryMonth;
    public byte PriceDisplayDecimals;
    public uint PriceFractionalDenominator;
    public uint PriceMinimumTick;
    public uint LastTradingDate;
    public long PriorDaySettlement;
    public fixed sbyte Currency[3];
    public ulong LotSizeOrFaceValue;
    public byte MaturityValue;
    public ushort CouponRate;
    public byte PaymentsPerYear;
    public uint BlockLotSize;
    public uint ExpiryDate;
};

/// <summary>
///  Struct for Implied Order Added Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderAddedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public ulong OrderBookPriority;
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Implied Order Deleted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderDeletedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
};

/// <summary>
///  Struct for Implied Order Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderReplacedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public ulong OrderBookPriority;
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Market Settlement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSettlementMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public long OpeningTrade;
    public long HighestTrade;
    public long LowestTrade;
    public long LastTrade;
    public uint LastVolume;
    public ulong TotalTradedVolume;
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
    public ushort Length;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Open High Low Last Trade Adjustment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenHighLowLastTradeAdjustmentMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public long OpeningTrade;
    public long HighestTrade;
    public long LowestTrade;
    public long LastTrade;
    public uint LastVolume;
    public ulong TotalTradedVolume;
};

/// <summary>
///  Struct for Options Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsSymbolDirectoryMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public fixed sbyte SymbolName[32];
    public fixed sbyte LongName[60];
    public fixed sbyte Isin[12];
    public fixed sbyte Exchange[6];
    public fixed sbyte Instrument[6];
    public fixed sbyte CfiCode[6];
    public ushort ExpiryYear;
    public ExpiryMonth ExpiryMonth;
    public OptionType OptionType;
    public long Strike;
    public uint UnderlyingTradeableInstrumentId;
    public byte PriceDisplayDecimals;
    public uint PriceFractionalDenominator;
    public uint PriceMinimumTick;
    public byte StrikePriceDecimalPosition;
    public uint StrikePriceFractionalDenominator;
    public uint StrikePriceMinimumTick;
    public uint LastTradingDate;
    public long PriorDaySettlement;
    public ulong Volatility;
    public fixed sbyte Currency[3];
    public ulong LotSizeOrFaceValue;
    public byte MaturityValue;
    public ushort CouponRate;
    public byte PaymentsPerYear;
    public uint BlockLotSize;
    public uint ExpiryDate;
    public fixed sbyte BasisOfQuotation[10];
};

/// <summary>
///  Struct for Order Book State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookStateMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public SessionState SessionState;
};

/// <summary>
///  Struct for Order Deleted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeletedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public ulong TradeId;
    public uint ExecutedQuantity;
    public long TradePrice;
    public ulong CombinationTradeId;
    public fixed sbyte CounterPartyId[3];
};

/// <summary>
///  Struct for Order Volume Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderVolumeCancelledMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public Side Side;
    public ulong OrderId;
    public uint Quantity;
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
    public fixed sbyte Session[10];
    public ulong Sequence;
    public ushort Count;
};

/// <summary>
///  Struct for Request For Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForQuoteMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public RfqSide RfqSide;
    public uint Quantity;
};

/// <summary>
///  Struct for Seconds Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecondsMessage {
    public uint Seconds;
};

/// <summary>
///  Struct for Text Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TextMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public fixed sbyte SourceId[6];
    public fixed sbyte Text[100];
};

/// <summary>
///  Struct for Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancellationMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public ulong TradeId;
};

/// <summary>
///  Struct for Trade Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeExecutedMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public TradeType TradeType;
    public ulong TradeId;
    public uint ExecutedQuantity;
    public long TradePrice;
    public ulong CombinationTradeId;
    public fixed sbyte ParticipantIdBuyer[3];
    public fixed sbyte ParticipantIdSeller[3];
};

/// <summary>
///  Struct for Volume And Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VolumeAndOpenInterestMessage {
    public uint Timestamp;
    public ushort TradeDate;
    public uint TradeableInstrumentId;
    public ulong CumulativeVolume;
    public ulong OpenInterest;
    public ushort VoiTradeDate;
};

