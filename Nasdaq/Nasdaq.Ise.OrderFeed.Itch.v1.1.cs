// C# Structs For Nasdaq Ise Itch OrderFeed 1.1 protocol

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
///  Closing Only Values
/// </summary>
public enum ClosingOnly : byte {
    ClosingPositionOnly = (byte)'Y',
    NotClosingPositionOnly = (byte)'N',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    HaltInEffect = (byte)'H',
    TradingOnTheOptionsSystem = (byte)'T',
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
    Hidden = (byte)' ',
};

/// <summary>
///  Imbalance Direction Values
/// </summary>
public enum ImbalanceDirection : byte {
    BuyImbalance = (byte)'B',
    SellImbalance = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    OptionDirectoryMessage = (byte)'D',
    TradingActionMessage = (byte)'H',
    SecurityOpenClosedMessage = (byte)'O',
    OpeningImbalanceMessage = (byte)'N',
    OrderOnBookMessage = (byte)'B',
    AuctionMessage = (byte)'A',
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
///  Side Values
/// </summary>
public enum Side : byte {
    Bid = (byte)'B',
    OfferAsk = (byte)'A',
    Hidden = (byte)' ',
};

/// <summary>
///  Tradable Values
/// </summary>
public enum Tradable : byte {
    Tradable = (byte)'Y',
    NotTradable = (byte)'N',
};

/// <summary>
///  Trading Type Values
/// </summary>
public enum TradingType : byte {
    Equity = (byte)'E',
    Index = (byte)'I',
    Etf = (byte)'F',
    Currency = (byte)'C',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Auction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionMessage {
    public fixed byte Timestamp;
    public uint OptionId;
    public uint AuctionId;
    public OrderType OrderType;
    public Side Side;
    public uint Price;
    public uint Size;
    public ExecFlag ExecFlag;
    public OrderCapacity OrderCapacity;
    public fixed sbyte OwnerId[6];
    public fixed sbyte Giveup[6];
    public fixed sbyte Cmta[6];
    public AuctionEvent AuctionEvent;
    public byte NumberOfResponses;
};

/// <summary>
///  Struct for Auction Response
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionResponse {
    public uint ResponsePrice;
    public uint ResponseSize;
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
///  Struct for Opening Imbalance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpeningImbalanceMessage {
    public fixed byte Timestamp;
    public uint OptionId;
    public uint PairedContracts;
    public ImbalanceDirection ImbalanceDirection;
    public uint ImbalancePrice;
    public uint ImbalanceVolume;
};

/// <summary>
///  Struct for Option Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionDirectoryMessage {
    public fixed byte Timestamp;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[6];
    public byte ExpirationYear;
    public byte ExpirationMonth;
    public byte ExpirationDay;
    public ulong StrikePrice;
    public OptionType OptionType;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public TradingType TradingType;
    public ushort ContractSize;
    public OptionClosingType OptionClosingType;
    public Tradable Tradable;
    public Mpv Mpv;
    public ClosingOnly ClosingOnly;
};

/// <summary>
///  Struct for Order On Book Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderOnBookMessage {
    public fixed byte Timestamp;
    public uint OptionId;
    public OrderType OrderType;
    public Side Side;
    public uint Price;
    public uint Size;
    public ExecFlag ExecFlag;
    public OrderCapacity OrderCapacity;
    public fixed sbyte OwnerId[6];
    public fixed sbyte Giveup[6];
    public fixed sbyte Cmta[6];
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
    public fixed byte Timestamp;
    public uint OptionId;
    public OpenState OpenState;
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

/// <summary>
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public fixed byte Timestamp;
    public uint OptionId;
    public CurrentTradingState CurrentTradingState;
};

