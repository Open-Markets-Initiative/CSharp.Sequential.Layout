// C# Structs For Nasdaq Equities Itch Aggregated 2.0 protocol

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
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    OpeningCross = (byte)'O',
    ClosingCross = (byte)'C',
    CrossHaltedOrPaused = (byte)'H',
    IntradayCrossAndPostCloseCross = (byte)'I',
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
    ClearNoii = (byte)'X',
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
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalance = (byte)'N',
    InsufficientOrders = (byte)'O',
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
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    StockTradingActionMessage = (byte)'H',
    RegShoRestrictionMessage = (byte)'Y',
    MarketParticipantPositionMessage = (byte)'P',
    MwcbDeclineLevelMessage = (byte)'V',
    MwcbStatusMessage = (byte)'W',
    IpoQuotingPeriodUpdateMessage = (byte)'K',
    LuldAuctionCollarMessage = (byte)'J',
    PriceLevelUpdateMessage = (byte)'U',
    NoiiMessage = (byte)'I',
    RpiiMessage = (byte)'N',
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
    NoCalculation = (byte)' ',
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

/// <summary>
///  Trading State Values
/// </summary>
public enum TradingState : byte {
    Halted = (byte)'H',
    Paused = (byte)'P',
    QuotationOnlyPeriod = (byte)'Q',
    Trading = (byte)'T',
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
    public int IpoPrice;
};

/// <summary>
///  Struct for Luld Auction Collar Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LuldAuctionCollarMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public int AuctionCollarReferencePrice;
    public int UpperAuctionCollarPrice;
    public int LowerAuctionCollarPrice;
    public uint AuctionCollarExtension;
};

/// <summary>
///  Struct for Market Participant Position Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketParticipantPositionMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Mpid[4];
    public fixed sbyte Stock[8];
    public PrimaryMarketMaker PrimaryMarketMaker;
    public MarketMakerMode MarketMakerMode;
    public MarketParticipantState MarketParticipantState;
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
    public uint FarPrice;
    public uint NearPrice;
    public uint CurrentReferencePrice;
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
///  Struct for Price Level Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriceLevelUpdateMessage {
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public MarketSide MarketSide;
    public uint ParticipantShares;
    public uint AggregateShares;
    public fixed sbyte Stock[8];
    public uint Price;
    public fixed sbyte Mpid[4];
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
///  Struct for Rpii Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RpiiMessage {
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
    public TradingState TradingState;
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

