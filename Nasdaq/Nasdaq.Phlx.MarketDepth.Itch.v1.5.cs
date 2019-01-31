// C# Structs For Nasdaq Phlx Itch MarketDepth 1.5 protocol

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
};

/// <summary>
///  Change Reason Values
/// </summary>
public enum ChangeReason : byte {
    User = (byte)'U',
    Reprice = (byte)'R',
    Suspend = (byte)'S',
    Exhausted = (byte)'E',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    OpeningReopening = (byte)'O',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halt = (byte)'H',
    Trading = (byte)'T',
    BuySideTradingSuspendedExhausted = (byte)'B',
    SellSideTradingSuspendedExhausted = (byte)'S',
};

/// <summary>
///  Customer Indicator Values
/// </summary>
public enum CustomerIndicator : byte {
    Customer = (byte)'C',
    Firm = (byte)'F',
    Onfloor = (byte)'M',
    Professional = (byte)'P',
    NonPhlx = (byte)'B',
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
    Buy = (byte)'A',
    Sell = (byte)'B',
    Buy = (byte)'M',
    Sell = (byte)'N',
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
    SecurityOpenMessage = (byte)'O',
    AddOrderMessageShortForm = (byte)'a',
    AddOrderMessageLongForm = (byte)'A',
    AddQuoteMessageShortForm = (byte)'j',
    AddQuoteMessageLongForm = (byte)'J',
    SingleSideExecutedMessage = (byte)'E',
    SingleSideExecutedWithPriceMessage = (byte)'C',
    SingleSideCancelMessage = (byte)'X',
    SingleSideReplaceMessageShortForm = (byte)'u',
    SingleSideReplaceMessageLongForm = (byte)'U',
    OrderReplaceMessageShortForm = (byte)'v',
    SingleSideReplaceLongFormMessage = (byte)'V',
    SingleSideDeleteMessage = (byte)'D',
    SingleSideUpdateMessage = (byte)'G',
    QuoteReplaceShortFormMessage = (byte)'k',
    QuoteReplaceLongFormMessage = (byte)'K',
    QuoteDeleteMessage = (byte)'Y',
    BlockDeleteMessage = (byte)'Z',
    NonAuctionOptionsTradeMessage = (byte)'P',
    OptionsCrossTradeMessage = (byte)'Q',
    BrokenTradeOrderExecutionMessage = (byte)'B',
    AuctionNotificationMessage = (byte)'I',
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
///  Open State Values
/// </summary>
public enum OpenState : byte {
    Open = (byte)'Y',
    Closed = (byte)'N',
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
    WcoEarlyClosing = (byte)'W',
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
    Tradable = (byte)'Y',
    NotTradable = (byte)'N',
};

/// <summary>
///  Trade Indicator Values
/// </summary>
public enum TradeIndicator : byte {
    NonDisplayable = (byte)'O',
    Complex = (byte)'C',
    Pixl = (byte)'P',
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
    public uint Price;
    public uint Volume;
    public uint OrderId;
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
    public ushort ShortPrice;
    public ushort ShortVolume;
    public uint OrderId;
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
    public uint BidSize;
    public uint Ask;
    public uint AskSize;
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
    public ushort ShortBidSize;
    public ushort AskPrice;
    public ushort ShortAskSize;
};

/// <summary>
///  Struct for Auction Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionNotificationMessage {
    public uint Timestamp;
    public uint AuctionId;
    public AuctionType AuctionType;
    public uint PairedContracts;
    public ImbalanceDirection ImbalanceDirection;
    public uint OptionId;
    public uint ImbalancePrice;
    public uint ImbalanceVolume;
    public CustomerIndicator CustomerIndicator;
    public fixed byte Reserved;
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
    public ushort NumberOfReferenceNumberDeltas;
};

/// <summary>
///  Struct for Broken Trade Order Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeOrderExecutionMessage {
    public uint Timestamp;
    public uint CrossNumber;
    public uint MatchNumber;
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
///  Struct for Non Auction Options Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NonAuctionOptionsTradeMessage {
    public uint Timestamp;
    public TradeIndicator TradeIndicator;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public uint Price;
    public uint Volume;
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
///  Struct for Options Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsCrossTradeMessage {
    public uint Timestamp;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public CrossType CrossType;
    public uint Price;
    public uint Volume;
};

/// <summary>
///  Struct for Order Replace Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplaceMessageShortForm {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public ushort ShortPrice;
    public ushort ShortVolume;
    public uint OrderId;
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
///  Struct for Quote Replace Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteReplaceLongFormMessage {
    public uint Timestamp;
    public uint OriginalBidReferenceNumberDelta;
    public uint BidReferenceNumberDelta;
    public uint OriginalAskReferenceNumberDelta;
    public uint AskReferenceNumberDelta;
    public uint Bid;
    public uint BidSize;
    public uint Ask;
    public uint AskSize;
};

/// <summary>
///  Struct for Quote Replace Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteReplaceShortFormMessage {
    public uint Timestamp;
    public uint OriginalBidReferenceNumberDelta;
    public uint BidReferenceNumberDelta;
    public uint OriginalAskReferenceNumberDelta;
    public uint AskReferenceNumberDelta;
    public ushort BidPrice;
    public ushort ShortBidSize;
    public ushort AskPrice;
    public ushort ShortAskSize;
};

/// <summary>
///  Struct for Seconds Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecondsMessage {
    public uint Second;
};

/// <summary>
///  Struct for Security Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityOpenMessage {
    public uint Timestamp;
    public uint OptionId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for Single Side Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideCancelMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public uint CancelledContracts;
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
///  Struct for Single Side Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideExecutedWithPriceMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public uint CrossNumber;
    public uint MatchNumber;
    public Printable Printable;
    public uint Price;
    public uint Volume;
};

/// <summary>
///  Struct for Single Side Replace Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceLongFormMessage {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public uint Price;
    public uint Volume;
    public uint OrderId;
};

/// <summary>
///  Struct for Single Side Replace Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceMessageLongForm {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public uint Price;
    public uint Volume;
};

/// <summary>
///  Struct for Single Side Replace Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceMessageShortForm {
    public uint Timestamp;
    public uint OriginalReferenceNumberDelta;
    public uint NewReferenceNumberDelta;
    public ushort ShortPrice;
    public ushort ShortVolume;
};

/// <summary>
///  Struct for Single Side Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideUpdateMessage {
    public uint Timestamp;
    public uint ReferenceNumberDelta;
    public ChangeReason ChangeReason;
    public uint Price;
    public uint Volume;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint Timestamp;
    public fixed sbyte EventCode[1];
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

