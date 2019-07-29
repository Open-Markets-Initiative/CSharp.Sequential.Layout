// C# Structs For Nasdaq Bx Options Itch TopOfMarket 1.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halt = (byte)'H',
    Trading = (byte)'T',
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
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimestampMessage = (byte)'T',
    SystemEventMessage = (byte)'S',
    OptionsDirectoryMessage = (byte)'D',
    TradingActionMessage = (byte)'H',
    SecurityOpenMessage = (byte)'O',
    BestBidAndAskUpdateShortFormMessage = (byte)'q',
    BestBidAndAskUpdateLongFormMessage = (byte)'Q',
    BestBidUpdateShortFormMessage = (byte)'b',
    BestAskUpdateShortFormMessage = (byte)'a',
    BestBidUpdateLongFormMessage = (byte)'B',
    BestAskUpdateLongFormMessage = (byte)'A',
    TradeReportMessage = (byte)'R',
    BrokenTradeReportMessage = (byte)'X',
};

/// <summary>
///  Minimum Price Variation Values
/// </summary>
public enum MinimumPriceVariation : byte {
    PennyEverywhere = (byte)'E',
    Scaled = (byte)'S',
    PennyPilot = (byte)'P',
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
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    NonfirmQuote = (byte)'F',
    RotationalQuote = (byte)'R',
    BidSideFirm = (byte)'X',
    AskSideFirm = (byte)'Y',
    RegularQuote = (byte)' ',
};

/// <summary>
///  Tradable Values
/// </summary>
public enum Tradable : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Best Ask Update Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestAskUpdateLongFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint PriceLong;
    public uint SizeLong;
};

/// <summary>
///  Struct for Best Ask Update Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestAskUpdateShortFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort Price;
    public ushort Size;
};

/// <summary>
///  Struct for Best Bid And Ask Update Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidAndAskUpdateLongFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint BidPriceLong;
    public uint BidSizeLong;
    public uint AskPriceLong;
    public uint AskSizeLong;
};

/// <summary>
///  Struct for Best Bid And Ask Update Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidAndAskUpdateShortFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort AskPrice;
    public ushort AskSize;
};

/// <summary>
///  Struct for Best Bid Update Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidUpdateLongFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint PriceLong;
    public uint SizeLong;
};

/// <summary>
///  Struct for Best Bid Update Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidUpdateShortFormMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort Price;
    public ushort Size;
};

/// <summary>
///  Struct for Broken Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeReportMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public uint OriginalCrossId;
    public uint OriginalPrice;
    public uint OriginalVolume;
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
///  Struct for Options Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionsDirectoryMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[6];
    public byte ExpirationYear;
    public byte ExpirationMonth;
    public byte ExpirationDay;
    public uint StrikePrice;
    public OptionType OptionType;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public fixed sbyte OptionClosingType[1];
    public Tradable Tradable;
    public MinimumPriceVariation MinimumPriceVariation;
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
///  Struct for Security Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityOpenMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint Nanoseconds;
    public EventCode EventCode;
    public byte Version;
    public byte Subversion;
};

/// <summary>
///  Struct for Timestamp Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimestampMessage {
    public uint Seconds;
};

/// <summary>
///  Struct for Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public uint CrossId;
    public fixed sbyte TradeCondition[1];
    public uint PriceLong;
    public uint Volume;
};

/// <summary>
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public CurrentTradingState CurrentTradingState;
};

