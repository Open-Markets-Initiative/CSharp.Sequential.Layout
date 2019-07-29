// C# Structs For Nasdaq Psx Itch Bbo 2.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Authenticity Values
/// </summary>
public enum Authenticity : byte {
    LiveProduction = (byte)'P',
    Test = (byte)'T',
};

/// <summary>
///  Breached Level Values
/// </summary>
public enum BreachedLevel : byte {
    Level1 = (byte)'1',
    Level2 = (byte)'2',
    Level3 = (byte)'3',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halted = (byte)'H',
    Paused = (byte)'P',
    QuotationOnlyPeriod = (byte)'Q',
    Trading = (byte)'T',
};

/// <summary>
///  Etp Flag Values
/// </summary>
public enum EtpFlag : byte {
    Etp = (byte)'Y',
    NotEtp = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfTransmissions = (byte)'O',
    StartOfSystemHours = (byte)'S',
    StartOfMarketHours = (byte)'Q',
    EndOfMarketHours = (byte)'M',
    EndOfSystemHours = (byte)'E',
    EndOfMessages = (byte)'C',
};

/// <summary>
///  Financial Status Indicator Values
/// </summary>
public enum FinancialStatusIndicator : byte {
    Deficient = (byte)'D',
    Delinquent = (byte)'E',
    Bankrupt = (byte)'Q',
    Suspended = (byte)'S',
    DeficientAndBankrupt = (byte)'G',
    DeficientAndDelinquent = (byte)'H',
    DelinquentAndBankrupt = (byte)'J',
    DeficientDelinquentAndBankrupt = (byte)'K',
    CreationsAndRedemptionsSuspended = (byte)'C',
    Normal = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Inverse Indicator Values
/// </summary>
public enum InverseIndicator : byte {
    InverseEtp = (byte)'Y',
    NotInverseEtp = (byte)'N',
};

/// <summary>
///  Ipo Flag Values
/// </summary>
public enum IpoFlag : byte {
    NasdaqListedInstrument = (byte)'Y',
    NasdaqListedInstrument = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Luld Reference Price Tier Values
/// </summary>
public enum LuldReferencePriceTier : byte {
    Tier1 = (byte)'1',
    Tier2 = (byte)'2',
    Na = (byte)' ',
};

/// <summary>
///  Market Category Values
/// </summary>
public enum MarketCategory : byte {
    NasdaqGlobalSelectMarket = (byte)'Q',
    NasdaqGlobalMarket = (byte)'G',
    NasdaqCapitalMarket = (byte)'S',
    Nyse = (byte)'N',
    NyseAmex = (byte)'A',
    NyseArca = (byte)'P',
    BatsBzx = (byte)'Z',
    InvestorsExchange = (byte)'V',
    Na = (byte)' ',
};

/// <summary>
///  Market Code Values
/// </summary>
public enum MarketCode : sbyte {
    Nasdaq = Q,
    Bx = B,
    Psx = X,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    StockTradingActionMessage = (byte)'H',
    RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
    MwcbDeclineLevelMessage = (byte)'V',
    MwcbStatusMessage = (byte)'W',
    OperationalHaltMessage = (byte)'h',
    QuotationMessage = (byte)'Q',
    NextSharesQuotationMessage = (byte)'A',
};

/// <summary>
///  Operational Halt Action Values
/// </summary>
public enum OperationalHaltAction : sbyte {
    Halted = H,
    Resumed = T,
};

/// <summary>
///  Reg Sho Action Values
/// </summary>
public enum RegShoAction : byte {
    NoPriceTest = (byte)'0',
    RegShoShortSalePriceTestRestriction = (byte)'1',
    TestRestrictionRemains = (byte)'2',
};

/// <summary>
///  Round Lots Only Values
/// </summary>
public enum RoundLotsOnly : byte {
    RoundLotsOnly = (byte)'Y',
    OddMixedAllowed = (byte)'N',
};

/// <summary>
///  Security Class Values
/// </summary>
public enum SecurityClass : byte {
    NasdaqListedIssue = (byte)'Q',
    Nyse = (byte)'N',
    NyseMkt = (byte)'A',
    NyseArca = (byte)'P',
    Bats = (byte)'Z',
    Iexg = (byte)'V',
    Na = (byte)' ',
};

/// <summary>
///  Short Sale Threshold Indicator Values
/// </summary>
public enum ShortSaleThresholdIndicator : byte {
    Restricted = (byte)'Y',
    NotRestricted = (byte)'N',
    Na = (byte)' ',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

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
///  Struct for Mwcb Decline Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbDeclineLevelMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public long Level1;
    public long Level2;
    public long Level3;
};

/// <summary>
///  Struct for Mwcb Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbStatusMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public BreachedLevel BreachedLevel;
};

/// <summary>
///  Struct for Next Shares Quotation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NextSharesQuotationMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte NextSharesSymbol[8];
    public SecurityClass SecurityClass;
    public int NasdaqBestBid;
};

/// <summary>
///  Struct for Operational Halt Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OperationalHaltMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public MarketCode MarketCode;
    public OperationalHaltAction OperationalHaltAction;
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
///  Struct for Quotation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuotationMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public SecurityClass SecurityClass;
    public int PsxBestBidPrice;
    public uint PsxBestBidSize;
    public int PsxBestOfferPrice;
    public uint PsxBestOfferSize;
};

/// <summary>
///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Stock Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockDirectoryMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public MarketCategory MarketCategory;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public uint RoundLotSize;
    public RoundLotsOnly RoundLotsOnly;
    public fixed sbyte IssueClassification[1];
    public fixed sbyte IssueSubType[2];
    public Authenticity Authenticity;
    public ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
    public IpoFlag IpoFlag;
    public LuldReferencePriceTier LuldReferencePriceTier;
    public EtpFlag EtpFlag;
    public uint EtpLeverageFactor;
    public InverseIndicator InverseIndicator;
};

/// <summary>
///  Struct for Stock Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockTradingActionMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public SecurityClass SecurityClass;
    public CurrentTradingState CurrentTradingState;
    public fixed sbyte Reason[4];
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

