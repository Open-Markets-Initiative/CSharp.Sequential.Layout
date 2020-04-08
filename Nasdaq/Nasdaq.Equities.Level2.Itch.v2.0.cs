// C# Structs For Nasdaq Equities Itch Level2 2.0 protocol

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
    NotAvailable = (byte)' ',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
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
    InCompliance = (byte)' ',
};

/// <summary>
///  Interest Flag Values
/// </summary>
public enum InterestFlag : byte {
    BuySideRpiOrdersAvailable = (byte)'B',
    SellSideRpiOrdersAvailable = (byte)'S',
    BothSidesRpiOrdersAvailable = (byte)'A',
    NoRpiOrdersAvailable = (byte)'N',
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
///  Issue Classification Values
/// </summary>
public enum IssueClassification : byte {
    AmericanDepositaryShare = (byte)'A',
    Bond = (byte)'B',
    Common = (byte)'C',
    Depository = (byte)'F',
    144A = (byte)'I',
    Limited = (byte)'L',
    Notes = (byte)'N',
    OrdinaryShare = (byte)'O',
    Preferred = (byte)'P',
    Other = (byte)'Q',
    Right = (byte)'R',
    Shares = (byte)'S',
    Convertible = (byte)'T',
    Unit = (byte)'U',
    UnitsBenifInt = (byte)'V',
    Warrant = (byte)'W',
};

/// <summary>
///  Luld Reference Price Tier Values
/// </summary>
public enum LuldReferencePriceTier : byte {
    Tier1 = (byte)'1',
    Tier2 = (byte)'2',
    NotAvailable = (byte)' ',
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
///  Market Code Values
/// </summary>
public enum MarketCode : byte {
    Nasdaq = (byte)'Q',
    Bx = (byte)'B',
    Psx = (byte)'X',
};

/// <summary>
///  Market Maker Mode Values
/// </summary>
public enum MarketMakerMode : byte {
    Normal = (byte)'N',
    Passive = (byte)'P',
    Syndicate = (byte)'S',
    PreSyndicate = (byte)'R',
    Penalty = (byte)'L',
};

/// <summary>
///  Market Participant State Values
/// </summary>
public enum MarketParticipantState : byte {
    Active = (byte)'A',
    Excused = (byte)'E',
    Withdrawn = (byte)'W',
    Suspended = (byte)'S',
    Deleted = (byte)'D',
};

/// <summary>
///  Market Side Values
/// </summary>
public enum MarketSide : byte {
    BidUpdate = (byte)'B',
    OfferAskUpdate = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    StockTradingActionMessage = (byte)'H',
    RegShoRestrictionMessage = (byte)'Y',
    ParticipantPositionSummaryMessage = (byte)'P',
    OperationalHaltMessage = (byte)'h',
    MarketParticipantBidaskUpdateMessage = (byte)'U',
    RetailPriceInterestIndicatorMessage = (byte)'N',
    MwcbDeclineLevelMessage = (byte)'V',
    MwcbStatusMessage = (byte)'W',
    IpoQuotingPeriodUpdateMessage = (byte)'K',
};

/// <summary>
///  Operational Halt Action Values
/// </summary>
public enum OperationalHaltAction : byte {
    TradingHalted = (byte)'H',
    TradingResumed = (byte)'T',
};

/// <summary>
///  Primary Market Maker Values
/// </summary>
public enum PrimaryMarketMaker : byte {
    Primary = (byte)'Y',
    NonPrimary = (byte)'N',
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
///  Struct for Ipo Quoting Period Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IpoQuotingPeriodUpdateMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public uint IpoQuotationReleaseTime;
    public IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
    public fixed byte IpoPrice[10];
};

/// <summary>
///  Struct for Market Participant Bidask Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketParticipantBidaskUpdateMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public MarketSide MarketSide;
    public uint ParticipantShares;
    public fixed sbyte Stock[8];
    public int Price;
    public fixed sbyte Mpid[4];
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
///  Struct for Participant Position Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParticipantPositionSummaryMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Mpid[4];
    public fixed sbyte Stock[8];
    public PrimaryMarketMaker PrimaryMarketMaker;
    public MarketMakerMode MarketMakerMode;
    public MarketParticipantState MarketParticipantState;
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
///  Struct for Retail Price Interest Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetailPriceInterestIndicatorMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public InterestFlag InterestFlag;
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
    public IssueClassification IssueClassification;
    public fixed sbyte IssueSubtype[2];
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
    public fixed sbyte TradingActionReason[4];
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

