// C# Structs For Lse Millennium Mitch Level2 11.9 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    ClosingAuction = (byte)'C',
    OpeningAuction = (byte)'O',
    Aesp = (byte)'A',
    Edsp = (byte)'B',
    ResumeAuction = (byte)'E',
    PeriodicAuction = (byte)'F',
    ScheduledLevel1OnlyAuction = (byte)'G',
};

/// <summary>
///  Book Type Values
/// </summary>
public enum BookType : byte {
    OnBook = 1,
    OffBook = 2,
    PrivateRfq = 3,
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    Meaning = Value,
    InternalCross = 5,
    InternalBtf = 6,
    CommittedCross = 7,
    CommittedBtf = 8,
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    EndOfDay = (byte)'C',
    StartOfDay = (byte)'O',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = 0x54,
    SystemEventMessage = 0x53,
    SymbolDirectoryMessage = 0x52,
    SymbolStatusMessage = 0x48,
    AddOrderMessage = 0x41,
    AddAttributedOrderMessage = 0x46,
    OrderDeletedMessage = 0x44,
    OrderModifiedMessage = 0x55,
    OrderBookClearMessage = 0x79,
    OrderExecutedMessage = 0x45,
    OrderExecutedWithPriceSizeMessage = 0x43,
    TradeMessage = 0x50,
    AuctionTradeMessage = 0x51,
    AuctionInfoMessage = 0x49,
    StatisticsMessage = 0x77,
    TopOfBookMessage = 0x71,
};

/// <summary>
///  Open Close Price Indicator Values
/// </summary>
public enum OpenClosePriceIndicator : byte {
    Meaning = (byte)'Value',
    Ut = (byte)'A',
    At = (byte)'B',
    MidOfBbo = (byte)'C',
    LastAt = (byte)'D',
    LastUt = (byte)'E',
    Manual = (byte)'F',
    DerivedFromPreviousClose = (byte)'I',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    NonPrintable = (byte)'N',
    Printable = (byte)'Y',
};

/// <summary>
///  Session Change Reason Values
/// </summary>
public enum SessionChangeReason : byte {
    ScheduledTransition = 0,
    ExtendedByMarketOps = 1,
    ShortenedByMarketOps = 2,
    MarketOrderImbalance = 3,
    PriceOutsideRange = 4,
    UnavailableRecoveryServiceOnly = 9,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    BuyOrder = (byte)'B',
    SellOrder = (byte)'S',
};

/// <summary>
///  Statistic Type Values
/// </summary>
public enum StatisticType : byte {
    OpeningPrice = (byte)'O',
    ClosingPrice = (byte)'C',
};

/// <summary>
///  Sub Book Values
/// </summary>
public enum SubBook : byte {
    RegularTrades = 0,
    RfqTrades = 11,
};

/// <summary>
///  Symbol Status Values
/// </summary>
public enum SymbolStatus : byte {
    Active = (byte)' ',
    Suspended = (byte)'S',
    Inactive = (byte)'a',
    Halt = (byte)'H',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Active = (byte)' ',
    Meaning = (byte)'Value',
    Halt = (byte)'H',
    RegularTradingStartOfTradeReporting = (byte)'T',
    OpeningFirstAuctionCall = (byte)'a',
    PostClose = (byte)'b',
    MarketCloseSystemShutdown = (byte)'c',
    ClosingAuctionCall = (byte)'d',
    AespAuctionCall = (byte)'e',
    ResumeAuctionCall = (byte)'f',
    Pause = (byte)'l',
    PreMandatory = (byte)'m',
    Mandatory = (byte)'n',
    PostMandatory = (byte)'o',
    EdspAuctionCall = (byte)'q',
    PeriodicAuctionCall = (byte)'r',
    EndTradeReporting = (byte)'t',
    NoActiveSession = (byte)'w',
    EndOfPostClose = (byte)'x',
    ClosingPriceCrossing = (byte)'u',
    ScheduledLevel1OnlyAuction = (byte)'G',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Attributed Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddAttributedOrderMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public Side Side;
    public uint Quantity;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public long Price;
    public fixed sbyte Attribution[11];
    public fixed byte Flags[0];
};

/// <summary>
///  Struct for Add Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public Side Side;
    public uint Quantity;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public long Price;
    public fixed byte Flags[0];
    public fixed sbyte ReservedAlpha[4];
};

/// <summary>
///  Struct for Auction Info Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionInfoMessage {
    public uint Nanosecond;
    public uint PairedQuantity;
    public uint ReservedUint32;
    public fixed sbyte ReservedByte[1];
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public long Price;
    public AuctionType AuctionType;
};

/// <summary>
///  Struct for Auction Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionTradeMessage {
    public uint Nanosecond;
    public uint Quantity;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public long Price;
    public ulong TradeMatchId;
    public AuctionType AuctionType;
    public fixed byte PtModFlags[0];
};

/// <summary>
///  Struct for Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Flags {
    public fixed byte PriorityFlag[1];
    public fixed byte Unused3[3];
    public fixed byte MarketOrder[1];
    public fixed byte FirmQuote[1];
    public fixed byte PrivateRfq[1];
    public fixed byte Unused1[1];
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
///  Struct for Order Book Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookClearMessage {
    public uint Nanosecond;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public fixed byte Flags[0];
};

/// <summary>
///  Struct for Order Deleted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeletedMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public fixed byte Flags[0];
    public uint InstrumentId;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public uint ExecutedQuantity;
    public ulong TradeMatchId;
};

/// <summary>
///  Struct for Order Executed With Price Size Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedWithPriceSizeMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public uint ExecutedQuantity;
    public uint DisplayQuantity;
    public ulong TradeMatchId;
    public Printable Printable;
    public long Price;
};

/// <summary>
///  Struct for Order Modified Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedMessage {
    public uint Nanosecond;
    public ulong OrderId;
    public uint NewQuantity;
    public long NewPrice;
    public fixed byte Flags[0];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte UnitHeader[0];
};

/// <summary>
///  Struct for Pt Mod Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PtModFlags {
    public fixed byte Canc[1];
    public fixed byte Amnd[1];
    public fixed byte Unused6[6];
};

/// <summary>
///  Struct for Statistics Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StatisticsMessage {
    public uint Nanosecond;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public StatisticType StatisticType;
    public long Price;
    public OpenClosePriceIndicator OpenClosePriceIndicator;
    public fixed sbyte ReservedByte[1];
};

/// <summary>
///  Struct for Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolDirectoryMessage {
    public uint Nanosecond;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public SymbolStatus SymbolStatus;
    public fixed sbyte Isin[12];
    public fixed sbyte Sedol[12];
    public fixed sbyte Segment[6];
    public fixed sbyte Underlying[6];
    public fixed sbyte Currency[3];
    public fixed sbyte ReservedByte[1];
    public fixed sbyte ReservedAlpha[4];
    public long PreviousClosePrice;
};

/// <summary>
///  Struct for Symbol Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolStatusMessage {
    public uint Nanosecond;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public TradingStatus TradingStatus;
    public fixed byte SymbolStatusFlags[0];
    public fixed sbyte Reason[4];
    public SessionChangeReason SessionChangeReason;
    public fixed sbyte NewEndTime[8];
    public BookType BookType;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint Nanosecond;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Seconds;
};

/// <summary>
///  Struct for Top Of Book Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TopOfBookMessage {
    public uint Nanosecond;
    public uint InstrumentId;
    public long BuyLimitPrice;
    public uint BuyLimitSize;
    public long SellLimitPrice;
    public uint SellLimitSize;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint Nanosecond;
    public uint ExecutedQuantity;
    public uint InstrumentId;
    public fixed sbyte ReservedA[1];
    public fixed sbyte ReservedB[1];
    public long Price;
    public ulong TradeMatchId;
    public CrossType CrossType;
    public SubBook SubBook;
    public fixed byte PtModFlags[0];
};

/// <summary>
///  Struct for Unit Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitHeader {
    public ushort Length;
    public byte MessageCount;
    public fixed sbyte MarketDataGroup[1];
    public uint SequenceNumber;
};

