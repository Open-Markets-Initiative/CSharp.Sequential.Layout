// C# Structs For Nasdaq Nom Itch Bono 3.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    HaltInEffect = (byte)'H',
    Trading = (byte)'T',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
    StartOfSystemHours = (byte)'S',
    StartOfOpeningProcess = (byte)'Q',
    StartOfNormalHoursClosingProcess = (byte)'N',
    StartOfLateHoursClosingProcess = (byte)'L',
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
    SecurityOpenClosedMessage = (byte)'O',
    ShortBestBidAndAskUpdateMessage = (byte)'q',
    LongBestBidAndAskUpdateMessage = (byte)'Q',
    ShortBestAskUpdateMessage = (byte)'a',
    ShortBestBidUpdateMessage = (byte)'b',
    LongBestAskUpdateMessage = (byte)'A',
    LongBestBidUpdateMessage = (byte)'B',
    TradeReportMessage = (byte)'R',
    BrokenTradeReportMessage = (byte)'X',
};

/// <summary>
///  Mpv Values
/// </summary>
public enum Mpv : byte {
    PennyEverywhere = (byte)'E',
    Scaled = (byte)'S',
    PennyPilot = (byte)'P',
};

/// <summary>
///  Open State Values
/// </summary>
public enum OpenState : byte {
    OpenForAutoExecution = (byte)'Y',
    ClosedForAutoExecution = (byte)'N',
};

/// <summary>
///  Option Closing Type Values
/// </summary>
public enum OptionClosingType : byte {
    Normal = (byte)'N',
    Late = (byte)'L',
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
    RegularQuoteautoxEligible = (byte)'',
    RotationalQuote = (byte)'R',
    BidSideFirm = (byte)'X',
    AskSideFirm = (byte)'Y',
};

/// <summary>
///  Tradable Values
/// </summary>
public enum Tradable : byte {
    Tradable = (byte)'Y',
    NotTradable = (byte)'N',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

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
///  Struct for Long Best Ask Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongBestAskUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint Price4;
    public uint Size4;
};

/// <summary>
///  Struct for Long Best Bid And Ask Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongBestBidAndAskUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint BidPrice4;
    public uint BidSize4;
    public uint AskPrice4;
    public uint AskSize4;
};

/// <summary>
///  Struct for Long Best Bid Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongBestBidUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public uint Price4;
    public uint Size4;
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
    public OptionClosingType OptionClosingType;
    public Tradable Tradable;
    public Mpv Mpv;
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
///  Struct for Security Open Closed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityOpenClosedMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for Short Best Ask Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortBestAskUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort Price2;
    public ushort Size2;
};

/// <summary>
///  Struct for Short Best Bid And Ask Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortBestBidAndAskUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort BidPrice2;
    public ushort BidSize2;
    public ushort AskPrice2;
    public ushort AskSize2;
};

/// <summary>
///  Struct for Short Best Bid Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortBestBidUpdateMessage {
    public uint Nanoseconds;
    public uint OptionId;
    public QuoteCondition QuoteCondition;
    public ushort Price2;
    public ushort Size2;
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
    public uint Price4;
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

