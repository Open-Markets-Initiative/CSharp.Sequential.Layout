// C# Structs For Nasdaq Phlx Itch Orders 1.9 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Action Values
/// </summary>
public enum Action : byte {
    Add = (byte)'A',
    Delete = (byte)'D',
};

/// <summary>
///  All Or None Values
/// </summary>
public enum AllOrNone : byte {
    AllOrNoneOrder = (byte)'Y',
    NotAllOrNoneOrder = (byte)'N',
};

/// <summary>
///  Auction Side Values
/// </summary>
public enum AuctionSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    SolicitationAuction = (byte)'*',
};

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Cola = (byte)'C',
    Opening = (byte)'O',
    Reopening = (byte)'R',
    Pixl = (byte)'P',
    Solicitation = (byte)'S',
    OrderExposure = (byte)'I',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    HaltInEffect = "H",
    PhlxTradingResumed = "T",
};

/// <summary>
///  Customer Firm Indicator Values
/// </summary>
public enum CustomerFirmIndicator : byte {
    CustomerOrder = (byte)'C',
    FirmOrder = (byte)'F',
    OnfloorMarketMaker = (byte)'M',
    BrokerDealerOrder = (byte)'B',
    ProfessionalOrder = (byte)'P',
    NaForImpliedOrder = (byte)' ',
};

/// <summary>
///  Debit Or Credit Values
/// </summary>
public enum DebitOrCredit : byte {
    NetDebit = (byte)'D',
    NetCredit = (byte)'C',
    EvenOrMarketOrder = (byte)' ',
    Anonymous = (byte)'*',
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
///  Leg Open Close Indicator Values
/// </summary>
public enum LegOpenCloseIndicator : byte {
    OpensPosition = (byte)'O',
    ClosesPosition = (byte)'C',
    StockLeg = (byte)' ',
};

/// <summary>
///  Market Qualifier Values
/// </summary>
public enum MarketQualifier : byte {
    OpeningOrder = (byte)'O',
    ImpliedOrder = (byte)'I',
    Na = (byte)' ',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    OptionsDirectoryMessage = (byte)'D',
    ComplexOrderStrategyMessage = (byte)'R',
    SecurityTradingActionMessage = (byte)'H',
    ComplexTradingActionMessage = (byte)'I',
    SecurityOpenClosedMessage = (byte)'P',
    StrategyOpenClosedMessage = (byte)'Q',
    SimpleOrderMessage = (byte)'O',
    ComplexOrderMessage = (byte)'X',
    AuctionNotificationMessage = (byte)'A',
    ComplexAuctionNotificationMessage = (byte)'C',
};

/// <summary>
///  Open Close Indicator Values
/// </summary>
public enum OpenCloseIndicator : byte {
    OpensPosition = (byte)'O',
    ClosesPosition = (byte)'C',
    Na = (byte)' ',
};

/// <summary>
///  Open State Values
/// </summary>
public enum OpenState : byte {
    OpenForAutoExecution = "Y",
    ClosedForAutoExecution = "N",
};

/// <summary>
///  Option Closing Type Values
/// </summary>
public enum OptionClosingType : byte {
    Normal = "N",
    Late = "L",
    WcoEarlyClosing = "W",
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
///  Order Status Values
/// </summary>
public enum OrderStatus : byte {
    Open = (byte)'O',
    Filled = (byte)'F',
    Cancelled = (byte)'C',
    Renotification = (byte)'R',
};

/// <summary>
///  Order Type Values
/// </summary>
public enum OrderType : byte {
    Market = (byte)'M',
    Limit = (byte)'L',
    Anonymous = (byte)'*',
};

/// <summary>
///  Phlx Tradable Values
/// </summary>
public enum PhlxTradable : byte {
    Tradable = "Y",
    NotTradable = "N",
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    Hidden = (byte)'*',
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    DayOrder = (byte)'D',
    Gtc = (byte)'G',
    Ioc = (byte)'I',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Auction Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionNotificationMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public uint AuctionId;
    public AuctionType AuctionType;
    public uint Price;
    public AuctionSide AuctionSide;
    public uint MatchedVolume;
    public uint ImbalanceVolume;
    public uint Reserved;
};

/// <summary>
///  Struct for Complex Auction Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexAuctionNotificationMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint StrategyId;
    public uint AuctionId;
    public AuctionType AuctionType;
    public uint Price;
    public AuctionSide AuctionSide;
    public DebitOrCredit DebitOrCredit;
    public uint Volume;
};

/// <summary>
///  Struct for Complex Order Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderLeg {
    public LegOpenCloseIndicator LegOpenCloseIndicator;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public Side Side;
    public uint LegRatio;
};

/// <summary>
///  Struct for Complex Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint StrategyId;
    public uint OrderId;
    public Side Side;
    public uint OriginalOrderVolume;
    public uint ExecutableOrderVolume;
    public OrderStatus OrderStatus;
    public OrderType OrderType;
    public uint LimitPrice;
    public DebitOrCredit DebitOrCredit;
    public AllOrNone AllOrNone;
    public TimeInForce TimeInForce;
    public CustomerFirmIndicator CustomerFirmIndicator;
    public fixed sbyte UnderlyingSymbol[13];
    public byte NumberOfLegs;
};

/// <summary>
///  Struct for Complex Order Strategy Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderStrategyLeg {
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public Side Side;
    public uint LegRatio;
};

/// <summary>
///  Struct for Complex Order Strategy Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderStrategyMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint StrategyId;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public Action Action;
    public byte NumberOfLegs;
};

/// <summary>
///  Struct for Complex Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTradingActionMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint StrategyId;
    public CurrentTradingState CurrentTradingState;
};

/// <summary>
///  Struct for Expiration
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Expiration {
    public fixed byte Year[7];
    public fixed byte Month[4];
    public fixed byte Day[5];
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
    public uint Seconds;
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public byte Source;
    public fixed sbyte UnderlyingSymbol[13];
    public OptionClosingType OptionClosingType;
    public PhlxTradable PhlxTradable;
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public fixed sbyte Session[10];
    public uint Sequence;
    public ushort Count;
};

/// <summary>
///  Struct for Security Open Closed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityOpenClosedMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public OpenState OpenState;
};

/// <summary>
///  Struct for Security Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityTradingActionMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public CurrentTradingState CurrentTradingState;
};

/// <summary>
///  Struct for Simple Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleOrderMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint OptionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Expiration[0];
    public uint ExplicitStrikePrice;
    public OptionType OptionType;
    public uint OrderId;
    public Side Side;
    public uint OriginalOrderVolume;
    public uint ExecutableOrderVolume;
    public OrderStatus OrderStatus;
    public OrderType OrderType;
    public MarketQualifier MarketQualifier;
    public uint LimitPrice;
    public AllOrNone AllOrNone;
    public TimeInForce TimeInForce;
    public CustomerFirmIndicator CustomerFirmIndicator;
    public OpenCloseIndicator OpenCloseIndicator;
};

/// <summary>
///  Struct for Strategy Open Closed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyOpenClosedMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public uint StrategyId;
    public OpenState OpenState;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public uint Seconds;
    public uint Nanoseconds;
    public EventCode EventCode;
    public byte Version;
};

