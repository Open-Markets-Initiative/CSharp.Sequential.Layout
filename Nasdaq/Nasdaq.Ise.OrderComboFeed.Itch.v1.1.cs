// C# Structs For Nasdaq Ise Itch OrderComboFeed 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Event Values
/// </summary>
public enum AuctionEvent : byte {
    Start = (byte)'S',
    AuctionUpdate = (byte)'U',
    EndOfAuction = (byte)'E',
};

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Exposure = (byte)'E',
    Facilitation = (byte)'C',
    Solicitation = (byte)'S',
    Pim = (byte)'P',
};

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
///  Exec Flag Values
/// </summary>
public enum ExecFlag : byte {
    None = (byte)'N',
    Aon = (byte)'A',
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    ComplexStrategyDirectoryMessage = (byte)'R',
    StrategyTradingActionMessage = (byte)'H',
    StrategyOpenClosedMessage = (byte)'O',
    ComplexStrategyOrderOnBookMessage = (byte)'L',
    ComplexStrategyAuctionMessage = (byte)'J',
};

/// <summary>
///  Open State Values
/// </summary>
public enum OpenState : byte {
    OpenForAutoExecution = (byte)'Y',
    ClosedForAutoExecution = (byte)'N',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Call = (byte)'C',
    Put = (byte)'P',
    Stock = (byte)' ',
};

/// <summary>
///  Order Capacity Values
/// </summary>
public enum OrderCapacity : byte {
    Customer = (byte)'C',
    CustomerProfessional = (byte)'D',
    Firm = (byte)'F',
    BrokerDealerCustomer = (byte)'B',
    BrokerDealerFirm = (byte)'K',
    Proprietary = (byte)'E',
    AwayMarketMaker = (byte)'N',
    MarketMaker = (byte)'M',
};

/// <summary>
///  Order Type Values
/// </summary>
public enum OrderType : byte {
    Market = (byte)'M',
    Limit = (byte)'L',
};

/// <summary>
///  Scope Values
/// </summary>
public enum Scope : byte {
    Local = (byte)'L',
    National = (byte)'N',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Bid = (byte)'B',
    OfferAsk = (byte)'A',
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
///  Struct for Auction Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionResponse {
    public uint ResponsePrice;
    public uint ResponseSize;
};

/// <summary>
///  Struct for Complex Strategy Auction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStrategyAuctionMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public uint AuctionId;
    public OrderType OrderType;
    public Side Side;
    public uint Price;
    public uint Size;
    public ExecFlag ExecFlag;
    public OrderCapacity OrderCapacity;
    public Scope Scope;
    public fixed sbyte OwnerId[6];
    public fixed sbyte Giveup[6];
    public fixed sbyte Cmta[6];
    public AuctionEvent AuctionEvent;
    public AuctionType AuctionType;
    public byte NumberOfResponses;
};

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
///  Struct for Complex Strategy Order On Book Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStrategyOrderOnBookMessage {
    public fixed byte Timestamp;
    public uint StrategyId;
    public OrderType OrderType;
    public Side Side;
    public uint Price;
    public uint Size;
    public ExecFlag ExecFlag;
    public OrderCapacity OrderCapacity;
    public Scope Scope;
    public fixed sbyte OwnerId[6];
    public fixed sbyte Giveup[6];
    public fixed sbyte Cmta[6];
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
    public LegSide LegSide;
    public uint LegRatio;
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
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public fixed sbyte Session[10];
    public ulong Sequence;
    public ushort Count;
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

