// C# Structs For Nasdaq Bx Options Itch DepthOfMarket 1.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Opening = (byte)'O',
    Reopening = (byte)'R',
    Exposure = (byte)'I',
    PriceImprovement = (byte)'P',
};

/// <summary>
///  Buy Sell Indicator Values
/// </summary>
public enum BuySellIndicator : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Change Reason Values
/// </summary>
public enum ChangeReason : byte {
    User = (byte)'U',
    Reprice = (byte)'R',
    Suspend = (byte)'S',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    BxOpeningReopening = (byte)'O',
    BxOpeningReopening = (byte)'P',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halt = (byte)'H',
    Trading = (byte)'T',
    BuySideTradingSuspended = (byte)'B',
    SellSideTradingSuspended = (byte)'S',
    Open = (byte)'Y',
    Closed = (byte)'N',
};

/// <summary>
///  Customer Firm Indicator Values
/// </summary>
public enum CustomerFirmIndicator : byte {
    Customer = (byte)'C',
    FirmJoint = (byte)'F',
    Onfloor = (byte)'M',
    Professional = (byte)'P',
    BrokerDealerNonRegistered = (byte)'B',
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
    EndOfMessages = (byte)'C',
};

/// <summary>
///  Imbalance Direction Values
/// </summary>
public enum ImbalanceDirection : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Market Side Values
/// </summary>
public enum MarketSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SecondsMessage = (byte)'T',
    SystemEventMessage = (byte)'S',
    BaseReferenceMessage = (byte)'L',
    OptionDirectoryMessage = (byte)'R',
    TradingActionMessage = (byte)'H',
    OptionOpenMessage = (byte)'O',
    AddOrderMessageShortForm = (byte)'a',
    AddOrderMessageLongForm = (byte)'A',
    AddQuoteMessageShortForm = (byte)'j',
    AddQuoteMessageLongForm = (byte)'J',
    SingleSideExecutedMessage = (byte)'E',
    SingleSideOrderExecutedWithPriceMessage = (byte)'C',
    OrderCancelMessage = (byte)'X',
    SingleSideReplaceMessageShortForm = (byte)'u',
    SingleSideReplaceMessageLongForm = (byte)'U',
    SingleSideDeleteMessage = (byte)'D',
    SingleSideUpdateMessage = (byte)'G',
    QuoteReplaceMessageShortForm = (byte)'k',
    QuoteReplaceMessageLongForm = (byte)'K',
    QuoteDeleteMessage = (byte)'Y',
    BlockDeleteMessage = (byte)'Z',
    NonAuctionOptionsTradeMessage = (byte)'P',
    OptionsCrossTradeMessage = (byte)'Q',
    BrokenTradeOrOrderExecutionMessage = (byte)'B',
    NetOrderImbalanceIndicatorMessage = (byte)'I',
};

/// <summary>
///  Mpv Values
/// </summary>
public enum Mpv : byte {
    Everywhere = (byte)'E',
    Scaled = (byte)'S',
    Pilot = (byte)'P',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Call = (byte)'C',
    Put = (byte)'P',
};

/// <summary>
///  Options Closing Type Values
/// </summary>
public enum OptionsClosingType : byte {
    Normal = (byte)'N',
    Late = (byte)'L',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    Nonprintable = (byte)'N',
    Printable = (byte)'Y',
};

/// <summary>
///  Tradable Values
/// </summary>
public enum Tradable : byte {
    NotTradable = (byte)'N',
    IsTradable = (byte)'Y',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessageLongForm {
    public uint Timestamp;
    public uint OrderReferenceNumberDelta;
    public MarketSide MarketSide;
    public uint OptionId;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Add Order Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessageShortForm {
    public uint Timestamp;
    public uint OrderReferenceNumberDelta;
    public MarketSide MarketSide;
    public uint OptionId;
    public ushort Price;
    public ushort Volume;
};

/// <summary>
///  Struct for Add Quote Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddQuoteMessageLongForm {
    public uint Timestamp;
    public uint BidReferenceNumberDelta;
    public uint AskReferenceNumberDelta;
    public uint OptionId;
    public uint Bid;
    public uint BidSizeLong;
    public uint Ask;
    public uint AskSizeLong;
};

/// <summary>
///  Struct for Add Quote Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddQuoteMessageShortForm {
    public uint Timestamp;
    public uint BidReferenceNumberDelta;
    public uint AskReferenceNumberDelta;
    public uint OptionId;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort AskPrice;
    public ushort AskSize;
};

/// <summary>
///  Struct for Base Reference Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BaseReferenceMessage {
    public uint Timestamp;
    public ulong BaseReferenceNumber;
};

/// <summary>
///  Struct for Block Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BlockDeleteMessage {
    public uint Timestamp;
    public ushort TotalNumberOfReferenceNumberDeltas;
    public uint ReferenceNumberDeltan;
};

/// <summary>
///  Struct for Broken Trade Or Order Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeOrOrderExecutionMessage {
    public uint Timestamp;
    public uint CrossNumber;
    public uint MatchNumber;
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
    public uint AuctionId;
    public AuctionType AuctionType;
    public uint PairedContracts;
    public ImbalanceDirection ImbalanceDirection;
    public uint OptionId;
    public uint ImbalancePrice;
    public uint ImbalanceVolume;
    public CustomerFirmIndicator CustomerFirmIndicator;
    public fixed byte Reserved;
};

/// <summary>
///  Struct for Non Auction Options Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NonAuctionOptionsTradeMessage {
    public uint Timestamp;
    public BuySellIndicator BuySellIndicator;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Option Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionDirectoryMessage {
    public uint Timestamp;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[6];
    public byte ExpirationYear;
    public byte ExpirationMonth;
    public byte ExpirationDate;
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public OptionsClosingType OptionsClosingType;
    public Tradable Tradable;
    public Mpv Mpv;
};

/// <summary>
///  Struct for Option Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionOpenMessage {
    public uint Timestamp;
    public uint OptionId;
    public fixed sbyte OpenState[1];
};

/// <summary>
///  Struct for Options Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsCrossTradeMessage {
    public uint Timestamp;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public CrossType CrossType;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Order Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelMessage {
    public uint Timestamp;
    public uint OrderReferenceNumberDelta;
    public uint CancelledContracts;
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
///  Struct for Quote Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteDeleteMessage {
    public uint Timestamp;
    public uint BidReferenceNumberDelta;
    public uint AskReferenceNumberDelta;
};

/// <summary>
///  Struct for Quote Replace Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteReplaceMessageLongForm {
    public uint Timestamp;
    public uint OriginalBidReferenceNumberDelta;
    public uint BidReferenceNumberDelta;
    public uint OriginalAskReferenceNumberDelta;
    public uint AskReferenceDeltaNumber;
    public uint BidPriceLong;
    public uint BidSizeLong;
    public uint AskPriceLong;
    public uint AskSizeLong;
};

/// <summary>
///  Struct for Quote Replace Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteReplaceMessageShortForm {
    public uint Timestamp;
    public uint OriginalBidReferenceNumberDelta;
    public uint BidReferenceNumberDelta;
    public uint OriginalAskReferenceNumberDelta;
    public uint AskReferenceDeltaNumber;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort AskPrice;
    public ushort AskSize;
};

/// <summary>
///  Struct for Seconds Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecondsMessage {
    public uint Second;
};

/// <summary>
///  Struct for Single Side Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideDeleteMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
};

/// <summary>
///  Struct for Single Side Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideExecutedMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public uint ExecutedContracts;
    public uint CrossNumber;
    public uint MatchNumber;
};

/// <summary>
///  Struct for Single Side Order Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideOrderExecutedWithPriceMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public uint CrossNumber;
    public uint MatchNumber;
    public Printable Printable;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Single Side Replace Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceMessageLongForm {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Single Side Replace Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceMessageShortForm {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public ushort Price;
    public ushort Volume;
};

/// <summary>
///  Struct for Single Side Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideUpdateMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public ChangeReason ChangeReason;
    public uint PriceLong;
    public uint VolumeLong;
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
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public uint Timestamp;
    public uint OptionId;
    public CurrentTradingState CurrentTradingState;
};

