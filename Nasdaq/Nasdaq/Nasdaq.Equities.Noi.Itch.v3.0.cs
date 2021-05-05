// C# Structs For Nasdaq Equities Itch Noi 3.0 protocol

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
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    OpeningCross = (byte)'O',
    ClosingCross = (byte)'C',
    CrossHaltedOrPaused = (byte)'H',
};

/// <summary>
///  Current Trading State Values
/// </summary>
public enum CurrentTradingState : byte {
    Halted = (byte)'H',
    Paused = (byte)'P',
    Trading = (byte)'T',
};

/// <summary>
///  Etp Flag Values
/// </summary>
public enum EtpFlag : byte {
    Etp = (byte)'Y',
    NotEtp = (byte)'N',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
    StartOfSystemHours = (byte)'S',
    StartOfMarketHours = (byte)'Q',
    ClearNoiiOpeningCrossData = (byte)'X',
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
///  Imbalance Direction Values
/// </summary>
public enum ImbalanceDirection : byte {
    BuyImbalance = (byte)'B',
    SellImbalance = (byte)'S',
    NoImbalance = (byte)'N',
    InsufficientOrders = (byte)'O',
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
    SetUpForIpoRelease = (byte)'Y',
    NotSetUpForIpoRelease = (byte)'N',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Ipo Quotation Release Qualifier Values
/// </summary>
public enum IpoQuotationReleaseQualifier : byte {
    AnticipatedQuotationReleaseTime = (byte)'A',
    IpoReleaseCanceledOrPostponed = (byte)'C',
};

/// <summary>
///  Luld Reference Price Tier Values
/// </summary>
public enum LuldReferencePriceTier : byte {
    Tier1 = (byte)'1',
    Tier2 = (byte)'2',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Market Category Values
/// </summary>
public enum MarketCategory : byte {
    NasdaqGlobalSelectMarket = (byte)'Q',
    NasdaqGlobalMarket = (byte)'G',
    NasdaqCapitalMarket = (byte)'S',
    Nyse = (byte)'N',
    NyseMkt = (byte)'A',
    NyseArca = (byte)'P',
    BatsZ = (byte)'Z',
    InvestorsExchange = (byte)'V',
    Na = (byte)' ',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    StockTradingActionMessage = (byte)'H',
    RegShoRestrictionMessage = (byte)'Y',
    NoiiMessage = (byte)'I',
    CrossTradeMessage = (byte)'Q',
    IpoQuotingPeriodUpdateMessage = (byte)'K',
};

/// <summary>
///  Price Variation Indicator Values
/// </summary>
public enum PriceVariationIndicator : byte {
    Less = (byte)'L',
    1To199 = (byte)'1',
    2To299 = (byte)'2',
    3To399 = (byte)'3',
    4To499 = (byte)'4',
    5To599 = (byte)'5',
    6To699 = (byte)'6',
    7To799 = (byte)'7',
    8To899 = (byte)'8',
    9To999 = (byte)'9',
    10To1999 = (byte)'A',
    20To2999 = (byte)'B',
    30OrGreater = (byte)'C',
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
    NoRestrictions = (byte)'N',
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
///  Struct for Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossTradeMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong Shares;
    public fixed sbyte Stock[8];
    public int CrossPrice;
    public ulong MatchNumber;
    public CrossType CrossType;
};

/// <summary>
///  Struct for Ipo Quoting Period Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IpoQuotingPeriodUpdateMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public uint IpoQuotationReleaseTime;
    public IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
    public int IpoPrice;
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
///  Struct for Noii Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NoiiMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong PairedShares;
    public ulong ImbalanceShares;
    public ImbalanceDirection ImbalanceDirection;
    public fixed sbyte Stock[8];
    public int FarPrice;
    public int NearPrice;
    public int CurrentReferencePrice;
    public CrossType CrossType;
    public PriceVariationIndicator PriceVariationIndicator;
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
///  Struct for Reg Sho Restriction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoRestrictionMessage {
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

