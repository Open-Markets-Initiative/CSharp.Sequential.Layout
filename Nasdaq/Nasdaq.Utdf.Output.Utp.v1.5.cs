// C# Structs For Nasdaq Utdf Utp Output 1.5 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Administrative Message Type Values
/// </summary>
public enum AdministrativeMessageType : byte {
    GeneralAdministrativeMessage = (byte)'A',
    CrossSroTradingActionMessage = (byte)'H',
    MarketCenterTradingActionMessage = (byte)'H',
    IssueSymbolDirectoryMessage = (byte)'B',
    RegulationShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'V',
    LimitUpLimitDownPriceBandMessage = (byte)'P',
    MarketWideCircuitBreakerDeclineLevelMessage = (byte)'C',
    MarketWideCircuitBreakerDeclineLevelMessage = (byte)'D',
    AuctionCollarMessage = (byte)'E',
    ClosingTradeSummaryReportMessage = (byte)'Z',
};

/// <summary>
///  As Of Action Values
/// </summary>
public enum AsOfAction : byte {
    TradeAddition = (byte)'A',
    TradeCancel = (byte)'C',
};

/// <summary>
///  Authenticity Values
/// </summary>
public enum Authenticity : byte {
    Production = (byte)'P',
    Test = (byte)'T',
    Demo = (byte)'D',
    Deleted = (byte)'X',
};

/// <summary>
///  Consolidated Price Change Indicator Values
/// </summary>
public enum ConsolidatedPriceChangeIndicator : byte {
    NoPricesChanged = (byte)'0',
    ConsolidatedLastPriceChanged = (byte)'1',
    ConsolidatedLowPriceChanged = (byte)'2',
    ConsolidatedLastAndConsolidatedLowPricesChanged = (byte)'3',
    ConsolidatedHighPriceChanged = (byte)'4',
    ConsolidatedLastAndConsolidatedHighPricesChanged = (byte)'5',
    ConsolidatedHighAndConsolidatedLowPricesChanged = (byte)'6',
    AllConsolidatedPricesChanged = (byte)'7',
};

/// <summary>
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfDayMessage = (byte)'I',
    EndOfDayMessage = (byte)'J',
    MarketSessionOpenMessage = (byte)'O',
    MarketSessionCloseMessage = (byte)'C',
    EndOfTransmissionsMessage = (byte)'Z',
    EndOfTradeReportingMessage = (byte)'X',
    EndOfConsolidatedLastSaleEligibility = (byte)'S',
};

/// <summary>
///  Financial Status Indicator Values
/// </summary>
public enum FinancialStatusIndicator : byte {
    CreationsAndOrRedemptionsSuspended = (byte)'C',
    Deficient = (byte)'D',
    Delinquent = (byte)'E',
    Bankrupt = (byte)'Q',
    Normal = (byte)'Q',
    Normal = (byte)'G',
    DeficientAndDelinquent = (byte)'H',
    DelinquentAndBankrupt = (byte)'J',
    DeficientDelinquentAndBankrupt = (byte)'K',
};

/// <summary>
///  Issue Type Values
/// </summary>
public enum IssueType : byte {
    AmericanDepositoryReceipt = (byte)'A',
    Bond = (byte)'B',
    CommonStock = (byte)'C',
    DepositoryReceipt = (byte)'F',
    Rule144A = (byte)'I',
    LimitedPartnership = (byte)'L',
    Note = (byte)'N',
    OrdinaryShares = (byte)'O',
    PreferredStock = (byte)'P',
    OtherSecurities = (byte)'Q',
    Rights = (byte)'R',
    SharesOfBeneficialInterest = (byte)'S',
    ConvertibleDebenture = (byte)'T',
    Unit = (byte)'U',
    UnitsOfBeneficialInterest = (byte)'V',
    Warrant = (byte)'W',
};

/// <summary>
///  Level 1 Values
/// </summary>
public enum Level1 : byte {
    RegularTrade = (byte)'@',
    Cash = (byte)'C',
    NextDay = (byte)'N',
    Seller = (byte)'R',
    YellowFlag = (byte)'Y',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Level 2 Values
/// </summary>
public enum Level2 : byte {
    IntermarketSweep = (byte)'F',
    OpeningPrints = (byte)'O',
    DerivativelyPriced = (byte)'4',
    ReOpeningPrints = (byte)'5',
    ClosingPrints = (byte)'6',
    QualifiedContingentTrade = (byte)'7',
    PlaceholderFor611Exempt = (byte)'8',
    CorrectedConsolidatedClose = (byte)'9',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Level 3 Values
/// </summary>
public enum Level3 : byte {
    FormT = (byte)'T',
    SoldLast = (byte)'L',
    SoldOutOfSequence = (byte)'Z',
    ExtendedTradingHours = (byte)'U',
    NotAvailable = (byte)' ',
    StoppedStock = (byte)'1',
    Acquisition = (byte)'A',
    Bunched = (byte)'B',
    Distribution = (byte)'D',
    PlaceholderFuture = (byte)'E',
    BunchedSoldTrade = (byte)'G',
    PriceVariation = (byte)'H',
    OddLotTrade = (byte)'I',
    Rule155 = (byte)'K',
    MarketCenterOfficialClosePrice = (byte)'M',
    PriorReferencePrice = (byte)'P',
    MarketCenterOfficialOpenPrice = (byte)'Q',
    SplitTrade = (byte)'S',
    ContingentTrade = (byte)'V',
    AveragePriceTrade = (byte)'W',
    CrossTrade = (byte)'X',
};

/// <summary>
///  Luld Price Band Indicator Values
/// </summary>
public enum LuldPriceBandIndicator : byte {
    OpeningUpdate = (byte)'A',
    IntraDayUpdate = (byte)'B',
    RestatedValue = (byte)'C',
    SuspendedDuringTradingHaltOrTradingPause = (byte)'D',
    ReOpeningUpdate = (byte)'E',
    OutsidePriceBandRuleHours = (byte)'F',
    NoneProvided = (byte)' ',
};

/// <summary>
///  Market Center Close Indicator Values
/// </summary>
public enum MarketCenterCloseIndicator : byte {
    BasedOnMSaleCondition = (byte)'M',
    NotBasedOnMSaleCondition = (byte)' ',
};

/// <summary>
///  Market Center Originator Id Values
/// </summary>
public enum MarketCenterOriginatorId : byte {
    Byx = (byte)'Y',
    Bzx = (byte)'Z',
    Edga = (byte)'J',
    Edgx = (byte)'K',
    Cboe = (byte)'W',
    Bx = (byte)'B',
    Phlx = (byte)'X',
    Nasdaq = (byte)'Q',
    Ise = (byte)'I',
    Nyse = (byte)'N',
    Arca = (byte)'P',
    American = (byte)'A',
    National = (byte)'C',
    Chicago = (byte)'M',
    Finra = (byte)'D',
    Iex = (byte)'V',
    Ltse = (byte)'L',
    Pearl = (byte)'H',
    Memx = (byte)'U',
    MarketIndependent = (byte)'E',
};

/// <summary>
///  Market Tier Values
/// </summary>
public enum MarketTier : byte {
    NasdaqGlobalSelectMarket = (byte)'Q',
    NasdaqGlobalMarket = (byte)'G',
    NasdaqCapitalMarket = (byte)'S',
};

/// <summary>
///  Participant Price Change Indicator Values
/// </summary>
public enum ParticipantPriceChangeIndicator : byte {
    NoPricesChanged = (byte)'0',
    ParticipantLastPriceChanged = (byte)'1',
    ParticipantLowPriceChanged = (byte)'2',
    ParticipantLastAndLowPricesChanged = (byte)'3',
    ParticipantHighPriceChanged = (byte)'4',
    ParticipantLastAndHighPricesChanged = (byte)'5',
    ParticipantHighAndLowPricesChanged = (byte)'6',
    AllParticipantPricesChanged = (byte)'7',
};

/// <summary>
///  Reg Sho Action Values
/// </summary>
public enum RegShoAction : byte {
    NoPriceTestInEffect = (byte)'0',
    RegShoInEffectDueToAnIntraDayPriceDrop = (byte)'1',
    RegShoRestrictionRemainsInEffect = (byte)'2',
};

/// <summary>
///  Short Sale Threshold Indicator Values
/// </summary>
public enum ShortSaleThresholdIndicator : byte {
    IssueIsRestricted = (byte)'Y',
    IssueIsNotRestricted = (byte)'N',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Sub Market Center Id Values
/// </summary>
public enum SubMarketCenterId : byte {
    NyseTrf = (byte)'N',
    NasdaqTrfCarteret = (byte)'Q',
    NasdaqTrfChicago = (byte)'B',
    FinraAlternativeDisplayFacility = (byte)' ',
};

/// <summary>
///  Trade Message Type Values
/// </summary>
public enum TradeMessageType : byte {
    TradeReportMessageShortFormMessage = (byte)'A',
    TradeReportMessageLongFormMessage = (byte)'W',
    TradeCancelErrorMessage = (byte)'Z',
    TradeCorrectionMessage = (byte)'Y',
    PriorDayAsOfTradeMessage = (byte)'H',
};

/// <summary>
///  Trading Action Code Values
/// </summary>
public enum TradingActionCode : byte {
    TradingHalt = (byte)'H',
    QuotationResumptionIncludingAfterEma = (byte)'Q',
    TradingResumption = (byte)'T',
    VolatilityTradingPause = (byte)'P',
};

/// <summary>
///  Trading Action Indicator Values
/// </summary>
public enum TradingActionIndicator : byte {
    TradingHalt = (byte)'H',
    RegularTrading = (byte)' ',
};

/// <summary>
///  Volume Message Type Values
/// </summary>
public enum VolumeMessageType : byte {
    TotalConsolidatedAndMarketCenterVolumeMessage = (byte)'M',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Auction Collar Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionCollarMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public uint TradingActionSequenceNumber;
    public ulong CollarReferencePrice;
    public ulong CollarUpPrice;
    public ulong CollarDownPrice;
    public fixed sbyte CollarExtensionIndicator[1];
};

/// <summary>
///  Struct for Closing Trade Summary Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClosingTradeSummaryReportMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public ulong DailyConsolidatedHighPrice;
    public ulong DailyConsolidatedLowPrice;
    public ulong DailyConsolidatedClosingPrice;
    public MarketCenterOriginatorId MarketCenterOriginatorId;
    public ulong ConsolidatedVolume;
    public TradingActionIndicator TradingActionIndicator;
    public ushort NumberOfMarketCenterSummaries;
};

/// <summary>
///  Struct for Cross Sro Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossSroTradingActionMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public TradingActionCode TradingActionCode;
    public uint TradingActionSequenceNumber;
    public ulong ActionTimestamp;
    public fixed sbyte TradingActionReason[6];
};

/// <summary>
///  Struct for End Of Consolidated Last Sale Eligibility
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfConsolidatedLastSaleEligibility {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for End Of Trade Reporting Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTradeReportingMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for End Of Transmissions Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTransmissionsMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for Issue Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IssueSymbolDirectoryMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public fixed sbyte OldSymbol[11];
    public fixed sbyte IssueName[30];
    public IssueType IssueType;
    public fixed sbyte IssueSubtype[2];
    public MarketTier MarketTier;
    public Authenticity Authenticity;
    public ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
    public ushort RoundLotSize;
    public FinancialStatusIndicator FinancialStatusIndicator;
};

/// <summary>
///  Struct for Limit Up Limit Down Price Band Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LimitUpLimitDownPriceBandMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public LuldPriceBandIndicator LuldPriceBandIndicator;
    public ulong LuldTimestamp;
    public ulong LimitDownPrice;
    public ulong LimitUpPrice;
};

/// <summary>
///  Struct for Market Center Closing Price And Volume Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCenterClosingPriceAndVolumeSummary {
    public fixed sbyte MarketCenterIdentifier[1];
    public ulong MarketCenterClosingPrice;
    public ulong MarketCenterVolume;
    public MarketCenterCloseIndicator MarketCenterCloseIndicator;
    public ulong MarketParticipantHighPrice;
    public ulong MarketParticipantLowPrice;
};

/// <summary>
///  Struct for Market Center Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCenterTradingActionMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public TradingActionCode TradingActionCode;
    public ulong ActionTimestamp;
    public fixed sbyte MarketCenterIdentifier[1];
};

/// <summary>
///  Struct for Market Center Volume Attachment
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCenterVolumeAttachment {
    public fixed sbyte MarketCenterIdentifier[1];
    public ulong CurrentMarketCenterVolume;
};

/// <summary>
///  Struct for Market Session Close Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSessionCloseMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for Market Session Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSessionOpenMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for Market Wide Circuit Breaker Decline Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketWideCircuitBreakerDeclineLevelMessage {
    public fixed byte MessageInfo[0];
    public ulong MwcbLevel1;
    public ulong MwcbLevel2;
    public ulong MwcbLevel3;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort MessageLength;
    public byte Version;
    public fixed sbyte MessageCategory[1];
};

/// <summary>
///  Struct for Message Info
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageInfo {
    public MarketCenterOriginatorId MarketCenterOriginatorId;
    public SubMarketCenterId SubMarketCenterId;
    public ulong SipTimestamp;
    public ulong ParticipantTimestamp;
    public ulong ParticipantToken;
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
///  Struct for Prior Day As Of Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriorDayAsOfTradeMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[5];
    public ulong TradeId;
    public ulong TradePrice;
    public uint TradeVolume;
    public fixed byte SaleCondition[0];
    public fixed sbyte TradeThroughExemptFlag[1];
    public ushort SellersSaleDays;
    public AsOfAction AsOfAction;
    public ulong TimestampOfTrade;
};

/// <summary>
///  Struct for Regulation Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegulationShoShortSalePriceTestRestrictedIndicatorMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[5];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Sale Condition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SaleCondition {
    public Level1 Level1;
    public Level2 Level2;
    public Level3 Level3;
    public fixed sbyte Level4[1];
};

/// <summary>
///  Struct for Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfDayMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for Total Consolidated And Market Center Volume Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TotalConsolidatedAndMarketCenterVolumeMessage {
    public fixed byte MessageInfo[0];
    public ulong TotalConsolidatedVolume;
    public ushort NumberOfMarketCenterVolumes;
};

/// <summary>
///  Struct for Trade Cancel Error Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelErrorMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[5];
    public fixed sbyte TradeCancellationType[1];
    public ulong OriginalTradeId;
    public ulong OriginalTradePrice;
    public uint OriginalVolume;
    public fixed byte OriginalSaleCondition[0];
    public fixed sbyte OriginalTradeThroughExemptFlag[1];
    public ushort OriginalSellersSaleDays;
    public ulong ConsolidatedHighPrice;
    public ulong ConsolidatedLowPrice;
    public ulong ConsolidatedLastPrice;
    public ulong ConsolidatedVolume;
    public ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
    public MarketCenterOriginatorId MarketCenterOriginatorId;
    public ulong MarketParticipantHighPrice;
    public ulong MarketParticipantLowPrice;
    public ulong MarketParticipantLastPrice;
    public ulong MarketParticipantVolume;
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[5];
    public ulong OriginalTradeId;
    public ulong OriginalTradePrice;
    public uint OriginalVolume;
    public fixed byte OriginalSaleCondition[0];
    public fixed sbyte OriginalTradeThroughExemptFlag[1];
    public ushort OriginalSellersSaleDays;
    public ulong CorrectedTradeId;
    public ulong CorrectedTradePrice;
    public uint CorrectedVolume;
    public fixed byte CorrectedSaleCondition[0];
    public fixed sbyte CorrectedTradeThroughExemptFlag[1];
    public ushort CorrectedSellersSaleDays;
    public ulong ConsolidatedHighPrice;
    public ulong ConsolidatedLowPrice;
    public ulong ConsolidatedLastPrice;
    public ulong ConsolidatedVolume;
    public ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
    public MarketCenterOriginatorId MarketCenterOriginatorId;
    public ulong MarketParticipantHighPrice;
    public ulong MarketParticipantLowPrice;
    public ulong MarketParticipantLastPrice;
    public ulong MarketParticipantVolume;
};

/// <summary>
///  Struct for Trade Report Message Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessageLongFormMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[5];
    public ulong TradeId;
    public ulong TradePrice;
    public uint TradeVolume;
    public fixed byte SaleCondition[0];
    public fixed sbyte TradeThroughExemptFlag[1];
    public ushort SellersSaleDays;
    public ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
    public ParticipantPriceChangeIndicator ParticipantPriceChangeIndicator;
};

/// <summary>
///  Struct for Trade Report Message Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessageShortFormMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[5];
    public ulong TradeId;
    public ushort TradePriceShort;
    public ushort TradeVolumeShort;
    public fixed byte SaleCondition[0];
    public fixed sbyte TradeThroughExemptFlag[1];
    public ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
    public ParticipantPriceChangeIndicator ParticipantPriceChangeIndicator;
};

/// <summary>
///  Struct for Volume
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Volume {
    public VolumeMessageType VolumeMessageType;
};

