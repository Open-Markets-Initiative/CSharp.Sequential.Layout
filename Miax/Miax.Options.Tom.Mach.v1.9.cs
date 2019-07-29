// C# Structs For Miax Options Mach Tom 1.9 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Bid Condition Values
/// </summary>
public enum BidCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Event Reason Values
/// </summary>
public enum EventReason : byte {
    Automatic = (byte)'A',
    Manual = (byte)'M',
};

/// <summary>
///  Liquidity Acceptance Increment Indicator Values
/// </summary>
public enum LiquidityAcceptanceIncrementIndicator : byte {
    Penny = (byte)'P',
    Nickel = (byte)'N',
    Dime = (byte)'D',
};

/// <summary>
///  Mbbo Condition Values
/// </summary>
public enum MbboCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemTimeMessage = (byte)'1',
    SeriesUpdate = (byte)'P',
    SystemStateMessage = (byte)'S',
    TopOfMarketBidCompactMessage = (byte)'B',
    TopOfMarketOfferCompactMessage = (byte)'O',
    WideTopOfMarketBidMessage = (byte)'W',
    WideTopOfMarketOfferMessage = (byte)'A',
    DoubleSidedTopOfMarketCompactMessage = (byte)'d',
    WideDoubleSidedTopOfMarketMessage = (byte)'D',
    TradeMessage = (byte)'T',
    TradeCancelMessage = (byte)'X',
    UnderlyingTradingStatusMessage = (byte)'H',
};

/// <summary>
///  Miax Bbo Posting Increment Indicator Values
/// </summary>
public enum MiaxBboPostingIncrementIndicator : byte {
    Penny = (byte)'P',
    Nickel = (byte)'N',
    Dime = (byte)'D',
};

/// <summary>
///  Offer Condition Values
/// </summary>
public enum OfferCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Opening Underlying Market Code Values
/// </summary>
public enum OpeningUnderlyingMarketCode : byte {
    NyseAmex = (byte)'A',
    NasdaqOmxBx = (byte)'B',
    Nse = (byte)'C',
    FinraAdf = (byte)'D',
    MarketIndependent = (byte)'E',
    Ise = (byte)'I',
    Edga = (byte)'J',
    Edgx = (byte)'K',
    Cse = (byte)'M',
    NyseEuronext = (byte)'N',
    NyseArca = (byte)'P',
    NasdaqOmxUtp = (byte)'Q',
    NasdaqOmxCta = (byte)'T',
    Iex = (byte)'V',
    NasdaqOmxPhlx = (byte)'X',
    BatsY = (byte)'Y',
    Bats = (byte)'Z',
};

/// <summary>
///  Packet Type Values
/// </summary>
public enum PacketType : byte {
    Heartbeat = 0,
    StartOfSession = 1,
    EndOfSession = 2,
    ApplicationMessage = 3,
};

/// <summary>
///  System Status Values
/// </summary>
public enum SystemStatus : byte {
    StartOfSystemHours = (byte)'S',
    EndOfSystemHours = (byte)'C',
    StartTestSession = (byte)'1',
    EndOfTestSession = (byte)'2',
    TopBid = (byte)'B',
    TopOffer = (byte)'O',
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    CancelOfTrade = (byte)'A',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Halted = (byte)'H',
    Resumed = (byte)'R',
    Opened = (byte)'O',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Application Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApplicationMessage {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Double Sided Top Of Market Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DoubleSidedTopOfMarketCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort BidPrice2;
    public ushort BidSize2;
    public ushort BidPriorityCustomerSize2;
    public BidCondition BidCondition;
    public ushort OfferPrice2;
    public ushort OfferSize2;
    public ushort OfferPriorityCustomerSize2;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ulong SequenceNumber;
    public ushort PacketLength;
    public PacketType PacketType;
    public byte SessionNumber;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
};

/// <summary>
///  Struct for Series Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SeriesUpdate {
    public uint ProductAddUpdateTime;
    public uint ProductId;
    public fixed sbyte UnderlyingSymbol[11];
    public fixed sbyte SecuritySymbol[6];
    public fixed sbyte ExpirationDate[8];
    public uint StrikePrice;
    public fixed sbyte CallOrPut[1];
    public fixed sbyte OpeningTime[8];
    public fixed sbyte ClosingTime[8];
    public fixed sbyte RestrictedOption[1];
    public fixed sbyte LongTermOption[1];
    public fixed sbyte ActiveOnMiax[1];
    public MiaxBboPostingIncrementIndicator MiaxBboPostingIncrementIndicator;
    public LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
    public OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
    public uint PriorityQuoteWidth;
    public ulong Reserved;
};

/// <summary>
///  Struct for System State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemStateMessage {
    public uint NotificationTime;
    public fixed sbyte ToMVersion[8];
    public uint SessionId;
    public SystemStatus SystemStatus;
};

/// <summary>
///  Struct for System Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemTimeMessage {
    public uint Timestamp;
};

/// <summary>
///  Struct for Top Of Market Bid Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TopOfMarketBidCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort MbboPrice2;
    public ushort MbboSize2;
    public ushort MbboPriorityCustomerSize2;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Top Of Market Offer Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TopOfMarketOfferCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort MbboPrice2;
    public ushort MbboSize2;
    public ushort MbboPriorityCustomerSize2;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint TradeId;
    public byte CorrectionNumber;
    public uint TradePrice;
    public uint TradeSize;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint TradeId;
    public byte CorrectionNumber;
    public uint ReferenceTradeId;
    public byte ReferenceCorrectionNumber;
    public uint TradePrice;
    public uint TradeSize;
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Underlying Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingTradingStatusMessage {
    public uint Timestamp;
    public fixed sbyte UnderlyingSymbol[11];
    public TradingStatus TradingStatus;
    public EventReason EventReason;
    public uint SecondsPart;
    public uint ExpectedEventTimeNanoSecondsPart;
};

/// <summary>
///  Struct for Wide Double Sided Top Of Market Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideDoubleSidedTopOfMarketMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint BidPrice4;
    public uint BidSize4;
    public uint BidPriorityCustomerSize4;
    public BidCondition BidCondition;
    public uint OfferPrice4;
    public uint OfferSize4;
    public uint OfferPriorityCustomerSize4;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Wide Top Of Market Bid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideTopOfMarketBidMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint MbboPrice4;
    public uint MbboSize4;
    public uint MbboPriorityCustomerSize4;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Wide Top Of Market Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideTopOfMarketOfferMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint MbboPrice4;
    public uint MbboSize4;
    public uint MbboPriorityCustomerSize4;
    public MbboCondition MbboCondition;
};

