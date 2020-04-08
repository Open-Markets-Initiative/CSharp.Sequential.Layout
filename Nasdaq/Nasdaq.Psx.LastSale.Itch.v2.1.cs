// C# Structs For Nasdaq Psx Itch LastSale 2.1 protocol

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
    QuotationOnly = (byte)'Q',
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
    StartOfMarketHours = (byte)'Q',
    StartOfSystemHours = (byte)'S',
    EndOfMarketHours = (byte)'M',
    EndOfSystemHours = (byte)'E',
    EndOfTransmissions = (byte)'C',
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
    NyseMkt = (byte)'A',
    NyseArca = (byte)'P',
    BatsZ = (byte)'Z',
    Investors’Exchange = (byte)'V',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Market Center Identifier Values
/// </summary>
public enum MarketCenterIdentifier : byte {
    PsxExecutionSystem = (byte)'B',
    PsxExecutionSystem = (byte)'X',
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
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    TradeReportMessage = (byte)'T',
    NextSharesTradeReportMessage = (byte)'M',
    TradeCancelErrorMessage = (byte)'X',
    TradeCancelErrorForNextSharesMessage = (byte)'O',
    TradeCorrectionMessage = (byte)'C',
    TradeCorrectionForNextSharesMessage = (byte)'Z',
    TradingActionMessage = (byte)'H',
    RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
    StockDirectoryMessage = (byte)'R',
    MwcbDeclineLevelMessage = (byte)'V',
    MwcbBreachMessage = (byte)'W',
    OperationalHaltMessage = (byte)'h',
};

/// <summary>
///  Operational Halt Action Values
/// </summary>
public enum OperationalHaltAction : byte {
    Halted = (byte)'H',
    Resumed = (byte)'T',
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
    NoRestriction = (byte)'N',
};

/// <summary>
///  Sale Condition Modifier Level 1 Values
/// </summary>
public enum SaleConditionModifierLevel1 : byte {
    ProxyPriceSettlement = (byte)'J',
    RegularSettlement = (byte)'@',
    CashSettlement = (byte)'C',
    NextDaySettlement = (byte)'N',
    SellerSettlement = (byte)'R',
};

/// <summary>
///  Sale Condition Modifier Level 2 Values
/// </summary>
public enum SaleConditionModifierLevel2 : byte {
    IntermarketSweep = (byte)'F',
    OpeningPrint = (byte)'O',
    DerivativePriced = (byte)'4',
    ReOpeningPrint = (byte)'5',
    ClosingPrint = (byte)'6',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Sale Condition Modifier Level 3 Values
/// </summary>
public enum SaleConditionModifierLevel3 : byte {
    ExtendedHoursTrade = (byte)'T',
    ReportedLateOrOutOfSequence = (byte)'U',
    ReportedLateButInSequence = (byte)'L',
    SoldOutOfSequence = (byte)'Z',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Sale Condition Modifier Level 4 Values
/// </summary>
public enum SaleConditionModifierLevel4 : byte {
    Acquisition = (byte)'A',
    Bunched = (byte)'B',
    Distribution = (byte)'D',
    PriceVariationTransaction = (byte)'H',
    PsxOfficialClosePrice = (byte)'M',
    PriorReferencePrice = (byte)'P',
    PsxOfficialOpeningPrice = (byte)'Q',
    SplitTrade = (byte)'S',
    WeightedAveragePrice = (byte)'W',
    CrossTrade = (byte)'X',
    OddLotExecution = (byte)'o',
    OddLotCrossExecution = (byte)'x',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Security Class Values
/// </summary>
public enum SecurityClass : byte {
    Nasdaq = (byte)'Q',
    Nyse = (byte)'N',
    NyseAmex = (byte)'A',
    NyseArca = (byte)'P',
    Bats = (byte)'Z',
    InvestorsExchange = (byte)'V',
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
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Mwcb Breach Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbBreachMessage {
    public BreachedLevel BreachedLevel;
};

/// <summary>
///  Struct for Mwcb Decline Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbDeclineLevelMessage {
    public long Level1;
    public long Level2;
    public long Level3;
};

/// <summary>
///  Struct for Next Shares Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NextSharesTradeReportMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte NextSharesSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte TradeControlNumber[10];
    public int ProxyPrice;
    public uint TradeSize;
    public int NavPremiumDiscountAmount;
    public SaleConditionModifierLevel1 SaleConditionModifierLevel1;
    public SaleConditionModifierLevel2 SaleConditionModifierLevel2;
    public SaleConditionModifierLevel3 SaleConditionModifierLevel3;
    public SaleConditionModifierLevel4 SaleConditionModifierLevel4;
};

/// <summary>
///  Struct for Operational Halt Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OperationalHaltMessage {
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
///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
    public fixed sbyte Stock[8];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Stock Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockDirectoryMessage {
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
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public EventCode EventCode;
};

/// <summary>
///  Struct for Trade Cancel Error For Next Shares Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelErrorForNextSharesMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte OriginalTradeControlNumber[10];
    public int OriginalTradePrice;
    public int OriginalNavPremiumDiscountAmount;
    public uint OriginalTradeSize;
    public fixed sbyte OriginalSaleConditionModifier[4];
};

/// <summary>
///  Struct for Trade Cancel Error Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelErrorMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte OriginalTradeControlNumber[10];
    public int OriginalTradePrice;
    public uint OriginalTradeSize;
    public fixed sbyte OriginalSaleConditionModifier[4];
};

/// <summary>
///  Struct for Trade Correction For Next Shares Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionForNextSharesMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte OriginalTradeControlNumber[10];
    public int OriginalTradePrice;
    public int OriginalNavPremiumDiscountAmount;
    public uint OriginalTradeSize;
    public fixed sbyte OriginalSaleConditionModifier[4];
    public fixed sbyte CorrectedTradeControlNumber[10];
    public int CorrectedTradePrice;
    public int CorrectedNavPremiumDiscountAmount;
    public uint CorrectedTradeSize;
    public fixed sbyte CorrectedSaleConditionModifier[4];
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte OriginalTradeControlNumber[10];
    public int OriginalTradePrice;
    public uint OriginalTradeSize;
    public fixed sbyte OriginalSaleConditionModifier[4];
    public fixed sbyte CorrectedTradeControlNumber[10];
    public int CorrectedTradePrice;
    public uint CorrectedTradeSize;
    public fixed sbyte CorrectedSaleConditionModifier[4];
};

/// <summary>
///  Struct for Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessage {
    public MarketCenterIdentifier MarketCenterIdentifier;
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public fixed sbyte TradeControlNumber[10];
    public int TradePrice;
    public uint TradeSize;
    public SaleConditionModifierLevel1 SaleConditionModifierLevel1;
    public SaleConditionModifierLevel2 SaleConditionModifierLevel2;
    public SaleConditionModifierLevel3 SaleConditionModifierLevel3;
    public SaleConditionModifierLevel4 SaleConditionModifierLevel4;
};

/// <summary>
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public fixed sbyte IssueSymbol[8];
    public SecurityClass SecurityClass;
    public CurrentTradingState CurrentTradingState;
    public fixed sbyte TradingActionReason[4];
};

