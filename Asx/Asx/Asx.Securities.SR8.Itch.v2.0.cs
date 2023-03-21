// C# Structs For Asx Securities Itch SR8 2.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
    EndOfMessages = (byte)'C',
};

/// <summary>
///  Exchange Order Type Values
/// </summary>
public enum ExchangeOrderType : ushort {
    MarketBid = 4,
    PriceStabilisation = 8,
    Undisclosed = 32,
};

/// <summary>
///  Financial Product Values
/// </summary>
public enum FinancialProduct : byte {
    Option = 1,
    Future = 3,
    Cash = 5,
    StandardCombination = 11,
};

/// <summary>
///  Leg 1 Side Values
/// </summary>
public enum Leg1Side : byte {
    BuyLeg = (byte)'B',
    SellLeg = (byte)'C',
};

/// <summary>
///  Leg 2 Side Values
/// </summary>
public enum Leg2Side : byte {
    BuyLeg = (byte)'B',
    SellLeg = (byte)'C',
};

/// <summary>
///  Leg 3 Side Values
/// </summary>
public enum Leg3Side : byte {
    BuyLeg = (byte)'B',
    SellLeg = (byte)'C',
    NotDefined = (byte)'?',
};

/// <summary>
///  Leg 4 Side Values
/// </summary>
public enum Leg4Side : byte {
    BuyLeg = (byte)'B',
    SellLeg = (byte)'C',
    NotDefined = (byte)'?',
};

/// <summary>
///  Lot Type Values
/// </summary>
public enum LotType : byte {
    Undefined = 0,
    OddLot = 1,
    RoundLot = 2,
    BlockLot = 3,
    AllOrNoneLot = 4,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SecondsMessage = (byte)'T',
    OrderBookDirectoryMessage = (byte)'R',
    CombinationOrderBookDirectoryMessage = (byte)'M',
    TickSizeMessage = (byte)'L',
    SystemEventMessage = (byte)'S',
    OrderBookStateMessage = (byte)'O',
    AddOrderNoParticipantIdMessage = (byte)'A',
    AddOrderParticipantIdMessage = (byte)'F',
    OrderExecutedMessage = (byte)'E',
    OrderExecutedWithPriceMessage = (byte)'C',
    OrderReplaceMessage = (byte)'U',
    OrderDeleteMessage = (byte)'D',
    TradeMessage = (byte)'P',
    EquilibriumPriceUpdateMessage = (byte)'Z',
};

/// <summary>
///  Occurred At Cross Values
/// </summary>
public enum OccurredAtCross : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order No Participant Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderNoParticipantIdMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
    public uint OrderBookPosition;
    public ulong Quantity;
    public int Price;
    public ExchangeOrderType ExchangeOrderType;
    public LotType LotType;
};

/// <summary>
///  Struct for Add Order Participant Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderParticipantIdMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
    public uint OrderBookPosition;
    public ulong Quantity;
    public int Price;
    public ExchangeOrderType ExchangeOrderType;
    public LotType LotType;
    public fixed sbyte ParticipantId[7];
};

/// <summary>
///  Struct for Combination Order Book Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CombinationOrderBookDirectoryMessage {
    public uint TimestampNanoseconds;
    public uint OrderBookId;
    public fixed sbyte Symbol[32];
    public fixed sbyte LongName[32];
    public fixed sbyte Isin[12];
    public FinancialProduct FinancialProduct;
    public fixed sbyte TradingCurrency[3];
    public ushort NumberOfDecimalsInPrice;
    public ushort NumberOfDecimalsInNominalValue;
    public uint OddLotSize;
    public uint RoundLotSize;
    public uint BlockLotSize;
    public ulong NominalValue;
    public fixed sbyte Leg1Symbol[32];
    public Leg1Side Leg1Side;
    public uint Leg1Ratio;
    public fixed sbyte Leg2Symbol[32];
    public Leg2Side Leg2Side;
    public uint Leg2Ratio;
    public fixed sbyte Leg3Symbol[32];
    public Leg3Side Leg3Side;
    public uint Leg3Ratio;
    public fixed sbyte Leg4Symbol[32];
    public Leg4Side Leg4Side;
    public uint Leg4Ratio;
};

/// <summary>
///  Struct for Equilibrium Price Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquilibriumPriceUpdateMessage {
    public uint TimestampNanoseconds;
    public uint OrderBookId;
    public ulong BidQuantity;
    public ulong AskQuantity;
    public int EquilibriumPrice;
    public int BestBidPrice;
    public int BestAskPrice;
    public ulong BestBidQuantity;
    public ulong BestAskQuantity;
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
///  Struct for Order Book Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookDirectoryMessage {
    public uint TimestampNanoseconds;
    public uint OrderBookId;
    public fixed sbyte Symbol[32];
    public fixed sbyte LongName[32];
    public fixed sbyte Isin[12];
    public FinancialProduct FinancialProduct;
    public fixed sbyte TradingCurrency[3];
    public ushort NumberOfDecimalsInPrice;
    public ushort NumberOfDecimalsInNominalValue;
    public uint OddLotSize;
    public uint RoundLotSize;
    public uint BlockLotSize;
    public ulong NominalValue;
};

/// <summary>
///  Struct for Order Book State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookStateMessage {
    public uint TimestampNanoseconds;
    public uint OrderBookId;
    public fixed sbyte StateName[20];
};

/// <summary>
///  Struct for Order Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeleteMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
    public ulong ExecutedQuantity;
    public fixed byte MatchId[12];
    public fixed sbyte ParticipantIdOwner[7];
    public fixed sbyte ParticipantIdCounterparty[7];
};

/// <summary>
///  Struct for Order Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedWithPriceMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
    public ulong ExecutedQuantity;
    public fixed byte MatchId[12];
    public fixed sbyte ParticipantIdOwner[7];
    public fixed sbyte ParticipantIdCounterparty[7];
    public int TradePrice;
    public OccurredAtCross OccurredAtCross;
    public Printable Printable;
};

/// <summary>
///  Struct for Order Replace Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplaceMessage {
    public uint TimestampNanoseconds;
    public ulong OrderId;
    public uint OrderBookId;
    public Side Side;
    public uint NewOrderBookPosition;
    public ulong Quantity;
    public int Price;
    public ExchangeOrderType ExchangeOrderType;
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
///  Struct for Seconds Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecondsMessage {
    public uint TimestampSeconds;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint TimestampNanoseconds;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Tick Size Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TickSizeMessage {
    public uint TimestampNanoseconds;
    public uint OrderBookId;
    public ulong TickSize;
    public int PriceFrom;
    public int PriceTo;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint TimestampNanoseconds;
    public fixed byte MatchId[12];
    public Side Side;
    public ulong Quantity;
    public uint OrderBookId;
    public int TradePrice;
    public fixed sbyte ParticipantIdOwner[7];
    public fixed sbyte ParticipantIdCounterparty[7];
    public Printable Printable;
    public OccurredAtCross OccurredAtCross;
};

