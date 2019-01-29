// C# Structs For Miax Options Mach cTom 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Active On Miax Values
/// </summary>
public enum ActiveOnMiax : byte {
    Active = (byte)'A',
    Inactive = (byte)'I',
};

/// <summary>
///  Bid Condition Values
/// </summary>
public enum BidCondition : byte {
    Regular = (byte)'A',
    TradingHalt = (byte)'T',
    Wide = (byte)'W',
    SimpleAuction = (byte)'S',
    ComplexAuction = (byte)'C',
    SimpleMarketProtection = (byte)'M',
    LegMarketProtection = (byte)'L',
};

/// <summary>
///  Call Or Put Values
/// </summary>
public enum CallOrPut : byte {
    Call = (byte)'C',
    Put = (byte)'P',
};

/// <summary>
///  Event Reason Values
/// </summary>
public enum EventReason : byte {
    Automatic = (byte)'A',
    Manual = (byte)'M',
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Bid = "B",
    Ask = "A",
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
///  Long Term Option Values
/// </summary>
public enum LongTermOption : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemTimeMessage = (byte)'1',
    SeriesUpdate = (byte)'P',
    ComplexStrategyDefinitionMessage = (byte)'C',
    SystemStateMessage = (byte)'S',
    ComplexTopOfMarketBidCompactMessage = (byte)'b',
    ComplexTopOfMarketOfferCompactMessage = (byte)'o',
    WideComplexTopOfMarketBidMessage = (byte)'e',
    WideComplexTopOfMarketOfferMessage = (byte)'f',
    ComplexDoubleSidedTopOfMarketCompactMessage = (byte)'m',
    WideComplexDoubleSidedTopOfMarketMessage = (byte)'w',
    StrategyTradeMessage = (byte)'t',
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
    TradingHalt = (byte)'T',
    Wide = (byte)'W',
    SimpleAuction = (byte)'S',
    ComplexAuction = (byte)'C',
    SimpleMarketProtection = (byte)'M',
    LegMarketProtection = (byte)'L',
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
    Heartbeat = "0",
    StartOfSession = "1",
    EndOfSession = "2",
    ApplicationMessage = "3",
};

/// <summary>
///  Restricted Option Values
/// </summary>
public enum RestrictedOption : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  System Status Values
/// </summary>
public enum SystemStatus : byte {
    StartOfSystemHours = (byte)'S',
    EndOfSystemHours = (byte)'C',
    StartTestSession = (byte)'1',
    EndOfTestSession = (byte)'2',
};

/// <summary>
///  Top Of Market Quote Condition Values
/// </summary>
public enum TopOfMarketQuoteCondition : byte {
    Halted = (byte)'H',
    Resumed = (byte)'R',
    Opened = (byte)'O',
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    Matched = (byte)'S',
    Legged = (byte)'L',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Halted = (byte)'H',
    Resumed = (byte)'R',
    Opened = (byte)'O',
};

/// <summary>
///  Update Reason Values
/// </summary>
public enum UpdateReason : byte {
    NewStrategyCreated = (byte)'N',
    Updated = (byte)'U',
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
///  Struct for Complex Double Sided Top of Market Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexDoubleSidedTopOfMarketCompactMessage {
    public uint Timestamp;
    public uint StrategyId;
    public short CompactBidPrice;
    public ushort CompactBidSize;
    public fixed byte BidReserved2[2];
    public BidCondition BidCondition;
    public short CompactOfferPrice;
    public ushort CompactOfferSize;
    public fixed byte OfferReserved2[2];
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Complex Strategy Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStrategyDefinitionMessage {
    public uint StrategyAddTime;
    public uint StrategyId;
    public fixed sbyte UnderlyingSymbol[11];
    public ActiveOnMiax ActiveOnMiax;
    public fixed byte Reserved1[1];
    public UpdateReason UpdateReason;
    public fixed byte Reserved10[10];
    public byte NumberOfLegs;
    public fixed byte LegDefinition[0];
};

/// <summary>
///  Struct for Complex Top Of Market Bid Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTopOfMarketBidCompactMessage {
    public uint Timestamp;
    public uint StrategyId;
    public short CompactPrice;
    public ushort CompactSize;
    public fixed byte Reserved2[2];
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Complex Top Of Market Offer Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTopOfMarketOfferCompactMessage {
    public uint Timestamp;
    public uint StrategyId;
    public short CompactPrice;
    public ushort CompactSize;
    public fixed byte Reserved2[2];
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegDefinition {
    public uint ProductId;
    public ushort LegRatioQty;
    public LegSide LegSide;
    public fixed byte Reserved8[8];
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
    public CallOrPut CallOrPut;
    public fixed sbyte OpeningTime[8];
    public fixed sbyte ClosingTime[8];
    public RestrictedOption RestrictedOption;
    public LongTermOption LongTermOption;
    public ActiveOnMiax ActiveOnMiax;
    public MiaxBboPostingIncrementIndicator MiaxBboPostingIncrementIndicator;
    public LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
    public OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
    public uint PriorityQuoteWidth;
    public fixed byte Reserved8[8];
};

/// <summary>
///  Struct for Strategy Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyTradeMessage {
    public uint Timestamp;
    public uint StrategyId;
    public uint TradeId;
    public long NetPrice;
    public uint TradeSize;
    public TradeCondition TradeCondition;
    public fixed byte Reserved16[16];
};

/// <summary>
///  Struct for System State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemStateMessage {
    public uint NotificationTime;
    public fixed sbyte Version[8];
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
///  Struct for Wide Complex Double Sided Top of Market Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideComplexDoubleSidedTopOfMarketMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long WideBidPrice;
    public uint WideBidSize;
    public fixed byte BidReserved4[4];
    public BidCondition BidCondition;
    public long WideOfferPrice;
    public uint WideOfferSize;
    public fixed byte OfferReserved4[4];
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Wide Complex Top Of Market Bid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideComplexTopOfMarketBidMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long WidePrice;
    public uint WideSize;
    public fixed byte Reserved4[4];
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Wide Complex Top Of Market Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideComplexTopOfMarketOfferMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long WidePrice;
    public uint WideSize;
    public fixed byte Reserved4[4];
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

