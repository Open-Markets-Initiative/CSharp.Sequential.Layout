// C# Structs For Nasdaq Nom Itch Itto 4.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Opening = (byte)'O',
    Reopening = (byte)'R',
    PriceImprovement = (byte)'P',
    Exposure = (byte)'I',
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
    NasdaqOpeningReopening = (byte)'O',
    PriceImprovement = (byte)'P',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halt = (byte)'H',
    Trading = (byte)'T',
    BuySideTradingSuspended = (byte)'B',
    SellSideTradingSuspended = (byte)'S',
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
    StartOfMessagesThisIsAlwaysTheFirstMessageSentInAnyTradingDay = (byte)'O',
    StartOfSystemHoursThisMessageIndicatesThatNasdaqIsOpenAndReadyToStartAcceptingOrders = (byte)'S',
    StartOfOpeningProcessThisMessageIsIntendedToIndicateThatNasdaqHasStartedItsOpeningAuctionProcess = (byte)'Q',
    EndOfNormalHoursProcessingThisMessageIsIntendedToIndicateThatNasdaqWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringNormalTradingHours = (byte)'N',
    EndOfLateHoursProcessingThisMessageIsIntendedToIndicateThatNasdaqWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringExtendedHours = (byte)'L',
    EndOfSystemHoursThisMessageIndicatesThatNasdaqOptionsSystemIsNowClosed = (byte)'E',
    EndOfMessagesThisIsAlwaysTheLastMessageSentInAnyTradingDay = (byte)'C',
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
    SystemEventMessage = (byte)'S',
    OptionsDirectoryMessage = (byte)'R',
    TradingActionMessage = (byte)'H',
    SecurityOpenMessage = (byte)'O',
    AddOrderMessageShortMessageForm = (byte)'a',
    AddOrderMessageLongFormMessage = (byte)'A',
    AddQuoteMessageShortFormMessage = (byte)'j',
    AddQuoteMessageLongFormMessage = (byte)'J',
    SingleSideExecutedMessage = (byte)'E',
    SingleSideExecutedWithPriceMessage = (byte)'C',
    OrderCancelMessage = (byte)'X',
    SingleSideReplaceMessageShortForm = (byte)'u',
    SingleSideReplaceMessageLongForm = (byte)'U',
    SingleSideDeleteMessage = (byte)'D',
    SingleSideChangeMessage = (byte)'G',
    QuoteReplaceMessageShortForm = (byte)'k',
    QuoteReplaceMessageLongForm = (byte)'K',
    QuoteDeleteMessage = (byte)'Y',
    OptionsTradeMessagesNonAuction = (byte)'P',
    OptionsCrossTradeMessage = (byte)'Q',
    BrokenTradeOrderExecutedMessage = (byte)'B',
    NoiiMessage = (byte)'I',
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
///  Struct for Add Order Message Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessageLongFormMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public MarketSide MarketSide;
    public uint OptionId;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Add Order Message Short Message Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessageShortMessageForm {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public MarketSide MarketSide;
    public uint OptionId;
    public ushort Price;
    public ushort Volume;
};

/// <summary>
///  Struct for Add Quote Message Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddQuoteMessageLongFormMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong BidReferenceNumber;
    public ulong AskReferenceNumber;
    public uint OptionId;
    public uint Bid;
    public uint BidSizeLong;
    public uint Ask;
    public uint AskSizeLong;
};

/// <summary>
///  Struct for Add Quote Message Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddQuoteMessageShortFormMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong BidReferenceNumber;
    public ulong AskReferenceNumber;
    public uint OptionId;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort AskPrice;
    public ushort AskSize;
};

/// <summary>
///  Struct for Broken Trade Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeOrderExecutedMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
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
///  Struct for Noii Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NoiiMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
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
///  Struct for Options Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsCrossTradeMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public CrossType CrossType;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Options Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsDirectoryMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
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
///  Struct for Options Trade Messages Non Auction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsTradeMessagesNonAuction {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public BuySellIndicator BuySellIndicator;
    public uint OptionId;
    public uint CrossNumber;
    public uint MatchNumber;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Order Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
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
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong BidReferenceNumber;
    public ulong AskReferenceNumber;
};

/// <summary>
///  Struct for Quote Replace Message Long Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteReplaceMessageLongForm {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OriginalBidReferenceNumber;
    public ulong BidReferenceNumber;
    public ulong OriginalAskReferenceNumber;
    public ulong AskReferenceNumber;
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
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OriginalBidReferenceNumber;
    public ulong BidReferenceNumber;
    public ulong OriginalAskReferenceNumber;
    public ulong AskReferenceNumber;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort AskPrice;
    public ushort AskSize;
};

/// <summary>
///  Struct for Security Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityOpenMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public uint OptionId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for Single Side Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideChangeMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong ReferenceNumber;
    public ChangeReason ChangeReason;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Single Side Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideDeleteMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong ReferenceNumber;
};

/// <summary>
///  Struct for Single Side Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideExecutedMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong ReferenceNumber;
    public uint ExecutedContracts;
    public uint CrossNumber;
    public uint MatchNumber;
};

/// <summary>
///  Struct for Single Side Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideExecutedWithPriceMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong ReferenceNumber;
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
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OriginalReferenceNumber;
    public ulong NewReferenceNumber;
    public uint PriceLong;
    public uint VolumeLong;
};

/// <summary>
///  Struct for Single Side Replace Message Short Form
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SingleSideReplaceMessageShortForm {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OriginalReferenceNumber;
    public ulong NewReferenceNumber;
    public ushort Price;
    public ushort Volume;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public uint OptionId;
    public CurrentTradingState CurrentTradingState;
};

