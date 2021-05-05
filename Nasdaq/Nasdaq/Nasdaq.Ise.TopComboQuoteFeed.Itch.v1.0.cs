// C# Structs For Nasdaq Ise Itch TopComboQuoteFeed 1.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    HaltInEffect = (byte)'H',
    TradingResumed = (byte)'T',
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
    EndOfWcoEarlyClosing = (byte)'W',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    ComplexStrategyDirectoryMessage = (byte)'R',
    StrategyOpenClosedMessage = (byte)'O',
    StrategyTradingActionMessage = (byte)'H',
    StrategyBestBidAndAskUpdate = (byte)'C',
    StrategyBestBidUpdate = (byte)'D',
    StrategyBestAskUpdate = (byte)'E',
    ComplexStrategyTickerMessage = (byte)'t',
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
    Na = (byte)' ',
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    RegularQuote = (byte)' ',
    Halted = (byte)'X',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    Hidden = (byte)' ',
};

/// <summary>
///  Strategy Type Values
/// </summary>
public enum StrategyType : byte {
    VerticalSpread = (byte)'V',
    TimeSpread = (byte)'T',
    DiagonalSpread = (byte)'D',
    Straddle = (byte)'S',
    Strangle = (byte)'G',
    Combo = (byte)'C',
    RiskReversal = (byte)'R',
    RatioSpread = (byte)'A',
    Custom = (byte)'U',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Complex Strategy Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStrategyDirectoryMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public StrategyType StrategyType;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public byte NumberOfLegs;
};

/// <summary>
///  Struct for Complex Strategy Ticker Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStrategyTickerMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public ulong LastPrice;
    public uint Size;
    public uint Volume;
    public ulong High;
    public ulong Low;
    public ulong First;
    public fixed sbyte TradeCondition[1];
};

/// <summary>
///  Struct for Leg Information
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegInformation {
    public uint OptionId;
    public fixed sbyte SecuritySymbol[6];
    public byte LegId;
    public byte ExpirationYear;
    public byte ExpirationMonth;
    public byte ExpirationDay;
    public ulong ExplicitStrikePrice;
    public OptionType OptionType;
    public Side Side;
    public uint LegRatio;
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
///  Struct for Strategy Best Ask Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyBestAskUpdate {
    public fixed byte Timestamp;
    public uint StrategyId;
    public QuoteCondition QuoteCondition;
    public uint Price;
    public uint Size;
    public uint CustSize;
    public uint ProCustSize;
    public uint NttSize;
    public uint MarketSize;
    public uint NttMarketSize;
};

/// <summary>
///  Struct for Strategy Best Bid And Ask Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyBestBidAndAskUpdate {
    public fixed byte Timestamp;
    public uint StrategyId;
    public QuoteCondition QuoteCondition;
    public uint BidPrice;
    public uint BidSize;
    public uint BidCustSize;
    public uint BidProCustSize;
    public uint BidNttSize;
    public uint BidMarketSize;
    public uint BidNttMarketSize;
    public uint AskPrice;
    public uint AskSize;
    public uint AskCustSize;
    public uint AskProCustSize;
    public uint AskNttSize;
    public uint AskMarketSize;
    public uint AskNttMarketSize;
};

/// <summary>
///  Struct for Strategy Best Bid Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyBestBidUpdate {
    public fixed byte Timestamp;
    public uint StrategyId;
    public QuoteCondition QuoteCondition;
    public uint Price;
    public uint Size;
    public uint CustSize;
    public uint ProCustSize;
    public uint NttSize;
    public uint MarketSize;
    public uint NttMarketSize;
};

/// <summary>
///  Struct for Strategy Open Closed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyOpenClosedMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for Strategy Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyTradingActionMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public CurrentTradingState CurrentTradingState;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public fixed byte Timestamp;
    public EventCode EventCode;
    public ushort CurrentYear;
    public byte CurrentMonth;
    public byte CurrentDay;
    public byte Version;
    public byte Subversion;
};

