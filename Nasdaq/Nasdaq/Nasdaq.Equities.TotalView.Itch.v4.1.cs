// C# Structs For Nasdaq Equities Itch TotalView 4.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    Opening = (byte)'O',
    Closing = (byte)'C',
    CrossForIpoAndHalted = (byte)'H',
    NasdaqCrossNetwork = (byte)'I',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
    StartOfSystemHours = (byte)'S',
    StartOfMarketHours = (byte)'Q',
    EndOfMarketHours = (byte)'M',
    EndOfSystemHours = (byte)'E',
    EndOfMessage = (byte)'C',
    Halt = (byte)'A',
    QuoteOnlyPeriod = (byte)'R',
    Resumption = (byte)'B',
};

/// <summary>
///  Financial Status Indicator Values
/// </summary>
public enum FinancialStatusIndicator : byte {
    Delinquent = (byte)'D',
    Deficient = (byte)'E',
    Bankrupt = (byte)'Q',
    Suspended = (byte)'S',
    DeficientAndBankrupt = (byte)'G',
    DeficientAndDelinquent = (byte)'H',
    DelinquentAndBankrupt = (byte)'J',
    DeficientDelinquentAndBankrupt = (byte)'K',
};

/// <summary>
///  Imbalance Direction Values
/// </summary>
public enum ImbalanceDirection : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    No = (byte)'N',
    InsufficientOrders = (byte)'O',
};

/// <summary>
///  Interest Flag Values
/// </summary>
public enum InterestFlag : byte {
    RpiBuy = (byte)'B',
    RpiSell = (byte)'S',
    RpiBoth = (byte)'A',
    NoRpi = (byte)'N',
};

/// <summary>
///  Market Category Values
/// </summary>
public enum MarketCategory : byte {
    Nyse = (byte)'N',
    Amex = (byte)'A',
    Arca = (byte)'P',
    NasdaqGsm = (byte)'Q',
    NasdaqGm = (byte)'G',
    NasdaqCm = (byte)'S',
    Bats = (byte)'Z',
};

/// <summary>
///  Market Maker Mode Values
/// </summary>
public enum MarketMakerMode : byte {
    Normal = (byte)'N',
    Passive = (byte)'P',
    Syndicate = (byte)'S',
    Penalty = (byte)'L',
};

/// <summary>
///  Market Participant State Values
/// </summary>
public enum MarketParticipantState : byte {
    Active = (byte)'A',
    ExcusedWithdrawn = (byte)'E',
    Withdrawn = (byte)'W',
    Suspended = (byte)'S',
    Deleted = (byte)'D',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeStampMessage = (byte)'T',
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
    MarketParticipantPositionMessage = (byte)'L',
    AddOrderMessage = (byte)'A',
    AddOrderWithMpidMessage = (byte)'F',
    OrderExecutedMessage = (byte)'E',
    OrderExecutedWithPriceMessage = (byte)'C',
    OrderCancelMessage = (byte)'X',
    OrderDeleteMessage = (byte)'D',
    OrderReplaceMessage = (byte)'U',
    TradeMessage = (byte)'P',
    CrossTradeMessage = (byte)'Q',
    BrokenTradeMessage = (byte)'B',
    NetOrderImbalanceIndicatorMessage = (byte)'I',
    RetailPriceImprovementIndicatorMessage = (byte)'N',
};

/// <summary>
///  Price Variation Indicator Values
/// </summary>
public enum PriceVariationIndicator : byte {
    Less = (byte)'L',
    1To199 = (byte)'1',
    2To299 = (byte)'2',
    3To399 = (byte)'3',
    4To499 = (byte)'4',
    5To599 = (byte)'5',
    6To699 = (byte)'6',
    7To799 = (byte)'7',
    8To899 = (byte)'8',
    9To999 = (byte)'9',
    10To1999 = (byte)'A',
    20To2999 = (byte)'B',
    30OrGreater = (byte)'C',
    NoCalculation = (byte)' ',
};

/// <summary>
///  Primary Market Maker Values
/// </summary>
public enum PrimaryMarketMaker : byte {
    Primary = (byte)'Y',
    Nonprimary = (byte)'N',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    Nonprintable = (byte)'N',
    Printable = (byte)'Y',
};

/// <summary>
///  Reg Sho Action Values
/// </summary>
public enum RegShoAction : byte {
    NoPrice = (byte)'0',
    RegShoShortSalePriceTestRestriction = (byte)'1',
    RegShoShortSalePriceTest = (byte)'2',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
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
    public ulong OrderReferenceNumber;
    public Side Side;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
};

/// <summary>
///  Struct for Add Order With Mpid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderWithMpidMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
    public Side Side;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public fixed sbyte Attribution[4];
};

/// <summary>
///  Struct for Broken Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeMessage {
    public uint Timestamp;
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossTradeMessage {
    public uint Timestamp;
    public ulong CrossShares;
    public fixed sbyte Stock[8];
    public uint CrossPrice;
    public ulong MatchNumber;
    public CrossType CrossType;
};

/// <summary>
///  Struct for Market Participant Position Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketParticipantPositionMessage {
    public uint Timestamp;
    public fixed sbyte Mpid[4];
    public fixed sbyte Stock[8];
    public PrimaryMarketMaker PrimaryMarketMaker;
    public MarketMakerMode MarketMakerMode;
    public MarketParticipantState MarketParticipantState;
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
///  Struct for Net Order Imbalance Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NetOrderImbalanceIndicatorMessage {
    public uint Timestamp;
    public ulong PairedShares;
    public ulong ImbalanceShares;
    public ImbalanceDirection ImbalanceDirection;
    public fixed sbyte Stock[8];
    public uint FarPrice;
    public uint NearPrice;
    public uint CurrentReferencePrice;
    public CrossType CrossType;
    public PriceVariationIndicator PriceVariationIndicator;
};

/// <summary>
///  Struct for Order Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
    public uint CanceledShares;
};

/// <summary>
///  Struct for Order Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeleteMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
    public uint ExecutedShares;
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Order Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedWithPriceMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
    public uint ExecutedShares;
    public ulong MatchNumber;
    public Printable Printable;
    public uint ExecutionPrice;
};

/// <summary>
///  Struct for Order Replace Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplaceMessage {
    public uint TimestampNanoseconds;
    public ulong OriginalOrderReferenceNumber;
    public ulong NewOrderReferenceNumber;
    public uint Shares;
    public uint Price;
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
///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
    public uint Timestamp;
    public fixed sbyte Stock[8];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Retail Price Improvement Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetailPriceImprovementIndicatorMessage {
    public uint Timestamp;
    public fixed sbyte Stock[8];
    public InterestFlag InterestFlag;
};

/// <summary>
///  Struct for Stock Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockDirectoryMessage {
    public uint Timestamp;
    public fixed sbyte Stock[8];
    public MarketCategory MarketCategory;
    public FinancialStatusIndicator FinancialStatusIndicator;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint Timestamp;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Time Stamp Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeStampMessage {
    public uint Second;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint Timestamp;
    public ulong OrderReferenceNumber;
    public Side Side;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public ulong MatchNumber;
};

