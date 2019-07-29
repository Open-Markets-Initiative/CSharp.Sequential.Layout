// C# Structs For Miax Options Mach cTom 1.3 protocol

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
///  Liquidity Acceptance Increment Indicator Values
/// </summary>
public enum LiquidityAcceptanceIncrementIndicator : byte {
    Penny = (byte)'P',
    PennyOrNickel = (byte)'N',
    NickelOrDime = (byte)'D',
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
    SimpleSeriesUpdateMessage = (byte)'P',
    ComplexStrategyDefinitionMessage = (byte)'C',
    SystemStateMessage = (byte)'S',
    ComplexTopOfMarketBidCompactMessage = (byte)'b',
    ComplexTopOfMarketOfferCompactMessage = (byte)'o',
    ComplexTopOfMarketBidWideMessage = (byte)'e',
    ComplexTopOfMarketOfferWideMessage = (byte)'f',
    ComplexDoubleSidedTopOfMarketCompactMessage = (byte)'m',
    ComplexDoubleSidedTopOfMarketWideMessage = (byte)'w',
    StrategyLastSaleMessage = (byte)'t',
    UnderlyingTradingStatusNotificationMessage = (byte)'H',
};

/// <summary>
///  Miax Bbo Posting Increment Indicator Values
/// </summary>
public enum MiaxBboPostingIncrementIndicator : byte {
    Penny = (byte)'P',
    PennyOrNickel = (byte)'N',
    NickelOrDime = (byte)'D',
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
    Heartbeat = 0,
    StartOfSession = 1,
    EndOfSession = 2,
    ApplicationMessage = 3,
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
    Regular = (byte)'A',
    TradingHalt = (byte)'T',
    Wide = (byte)'W',
    SimpleAuction = (byte)'S',
    ComplexAuction = (byte)'C',
    SimpleMarketProtection = (byte)'M',
    LegMarketProtection = (byte)'L',
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
///  Struct for Complex Double Sided Top Of Market Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexDoubleSidedTopOfMarketCompactMessage {
    public uint Timestamp;
    public uint StrategyId;
    public short BidPrice2;
    public ushort BidSize2;
    public ushort BidPriorityCustomerSize2;
    public BidCondition BidCondition;
    public short OfferPrice2;
    public ushort OfferSize2;
    public ushort OfferPriorityCustomerSize2;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Complex Double Sided Top Of Market Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexDoubleSidedTopOfMarketWideMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long BidPrice8;
    public uint BidSize4;
    public uint BidPriorityCustomerSize4;
    public BidCondition BidCondition;
    public long OfferPrice8;
    public uint OfferSize4;
    public uint OfferPriorityCustomerSize4;
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
    public short Price2;
    public ushort Size2;
    public ushort PriorityCustomerSize2;
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Complex Top Of Market Bid Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTopOfMarketBidWideMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long Price8;
    public uint Size4;
    public uint PriorityCustomerSize4;
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Complex Top Of Market Offer Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTopOfMarketOfferCompactMessage {
    public uint Timestamp;
    public uint StrategyId;
    public short Price2;
    public ushort Size2;
    public ushort PriorityCustomerSize2;
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Complex Top Of Market Offer Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTopOfMarketOfferWideMessage {
    public uint Timestamp;
    public uint StrategyId;
    public long Price8;
    public uint Size4;
    public uint PriorityCustomerSize4;
    public TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
};

/// <summary>
///  Struct for Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegDefinition {
    public uint ProductId;
    public ushort LegRatioQty;
    public fixed byte LegSide[1];
    public ulong Reserved8;
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
///  Struct for Simple Series Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleSeriesUpdateMessage {
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
    public ulong Reserved8;
};

/// <summary>
///  Struct for Strategy Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyLastSaleMessage {
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
///  Struct for Underlying Trading Status Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingTradingStatusNotificationMessage {
    public uint Timestamp;
    public fixed sbyte UnderlyingSymbol[11];
    public TradingStatus TradingStatus;
    public EventReason EventReason;
    public uint ExpectedEventTimeSeconds;
    public uint ExpectedEventTimeNanoSeconds;
};

