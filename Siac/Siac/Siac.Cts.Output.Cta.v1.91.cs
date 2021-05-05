// C# Structs For Siac Cts Cta Output 1.91 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Administrative Message Type Values
/// </summary>
public enum AdministrativeMessageType : byte {
    StartOfEndOfDayMessage = (byte)'A',
    EndOfEndOfDayMessage = (byte)'B',
    StartOfStartOfDayMessage = (byte)'C',
    EndOfStartOfDayMessage = (byte)'D',
    AdministrativeUnformattedMessage = (byte)'H',
};

/// <summary>
///  Cancel Error Action Values
/// </summary>
public enum CancelErrorAction : byte {
    Cancel = (byte)'1',
    Error = (byte)'2',
};

/// <summary>
///  Category 2 Values
/// </summary>
public enum Category2 : byte {
    NoReason = (byte)' ',
    IntermarketSweepOrder = (byte)'F',
    MarketCenterOpeningTrade = (byte)'O',
    DerivativelyPriced = (byte)'4',
    MarketCenterReopeningTrade = (byte)'5',
    MarketCenterClosingTrade = (byte)'6',
    QualifiedContingentTrade = (byte)'7',
    Reserved = (byte)'8',
    CorrectedConsolidatedClosePriceAsPerListingMarket = (byte)'9',
};

/// <summary>
///  Category 3 Values
/// </summary>
public enum Category3 : byte {
    NotExtendedHoursOrSoldOutOfSequence = (byte)' ',
    SoldLast = (byte)'L',
    ExtendedHoursTrade = (byte)'T',
    ExtendedHoursSold = (byte)'U',
    SoldOutOfSequence = (byte)'Z',
};

/// <summary>
///  Category 4 Values
/// </summary>
public enum Category4 : byte {
    NoSroRequiredTradeDetail = (byte)' ',
    AveragePriceTrade = (byte)'B',
    AutomaticExecution = (byte)'E',
    PriceVariationTrade = (byte)'H',
    OddLotTrade = (byte)'I',
    Rule127Or155 = (byte)'K',
    MarketCenterOfficialClose = (byte)'M',
    PriorReferencePrice = (byte)'P',
    MarketCenterOfficialOpen = (byte)'Q',
    ContingentTrade = (byte)'V',
    CrossTrade = (byte)'X',
};

/// <summary>
///  Consolidated High Low Last Indicator Values
/// </summary>
public enum ConsolidatedHighLowLastIndicator : byte {
    None = (byte)'A',
    High = (byte)'B',
    Low = (byte)'C',
    Last = (byte)'D',
    HighLast = (byte)'E',
    LowLast = (byte)'F',
    HighLowLast = (byte)'G',
    HighLow = (byte)'H',
};

/// <summary>
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfDayMessage = (byte)'A',
    ResetBlockSequenceNumberMessage = (byte)'L',
    StartOfTestCycleMessage = (byte)'M',
    EndOfTestCycleMessage = (byte)'N',
    DisasterRecoveryDataCenterActivationMessage = (byte)'P',
    LineIntegrityMessage = (byte)'T',
    EndOfDayMessage = (byte)'Z',
};

/// <summary>
///  Financial Status Indicator Values
/// </summary>
public enum FinancialStatusIndicator : byte {
    FinancialStatusNotApplicable = (byte)'0',
    Bankrupt = (byte)'1',
    BelowContinuingListingStandards = (byte)'2',
    BankruptAndBelowContinuingListingStandards = (byte)'3',
    LateFiling = (byte)'4',
    BankruptAndLateFiling = (byte)'5',
    BelowContinuingListingStandardsAndLateFiling = (byte)'6',
    BankruptBelowContinuingListingStandardsAndLateFiling = (byte)'7',
    CreationsSuspended = (byte)'8',
    RedemptionsSuspended = (byte)'9',
    Liquidation = (byte)'A',
};

/// <summary>
///  Halt Reason Values
/// </summary>
public enum HaltReason : byte {
    NotApplicable = (byte)' ',
    NewsDissemination = (byte)'D',
    OrderImbalance = (byte)'I',
    LimitUpLimitDownTradingPause = (byte)'M',
    NewsPending = (byte)'P',
    Operational = (byte)'X',
    SubpennyTrading = (byte)'Y',
    MarketWideCircuitBreakerLevel1Breached = (byte)'1',
    MarketWideCircuitBreakerLevel2Breached = (byte)'2',
    MarketWideCircuitBreakerLevel3Breached = (byte)'3',
};

/// <summary>
///  Held Trade Indicator Values
/// </summary>
public enum HeldTradeIndicator : byte {
    NotApplicable = (byte)' ',
    CannotBeUsedAsALastSaleForBothParticipantAndConsolidatedBasis = (byte)'A',
    CanBeUsedAsALastSaleForParticipantButNotConsolidatedBasis = (byte)'B',
    CanBeUsedAsALastSaleForParticipantAndConsolidatedBasis = (byte)'C',
};

/// <summary>
///  Index Message Type Values
/// </summary>
public enum IndexMessageType : byte {
    IndexMessage = (byte)'I',
    BidAndOfferIndexMessage = (byte)'Q',
};

/// <summary>
///  Instrument Type Values
/// </summary>
public enum InstrumentType : byte {
    CtaEligibleEquity = (byte)'0',
    LocalIssue = (byte)'1',
    CorporateBond = (byte)'2',
    GovernmentBond = (byte)'3',
};

/// <summary>
///  Last Participant Id Values
/// </summary>
public enum LastParticipantId : byte {
    NyseAmerican = (byte)'A',
    NasdaqBx = (byte)'B',
    NyseNational = (byte)'C',
    FinraAdf = (byte)'D',
    Ise = (byte)'I',
    CboeEdga = (byte)'J',
    CboeEdgx = (byte)'K',
    Ltse = (byte)'L',
    NyseChicago = (byte)'M',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Cts = (byte)'S',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Limit Up Limit Down Indicator Values
/// </summary>
public enum LimitUpLimitDownIndicator : byte {
    LimitUpLimitDownNotApplicable = (byte)' ',
    LimitUpLimitDownPriceBand = (byte)'A',
    RepublishedLimitUpLimitDownPriceBand = (byte)'B',
    NationalBestBidLimitStateEntered = (byte)'C',
    NationalBestBidLimitStateExited = (byte)'D',
    NationalBestOfferLimitStateEntered = (byte)'E',
    NationalBestOfferLimitStateExited = (byte)'F',
    NationalBestBidAndNationalBestOfferLimitStateEntered = (byte)'G',
    NationalBestBidAndNationalBestOfferLimitStateExited = (byte)'H',
    NationalBestBidLimitStateEnteredAndNationalBestOfferLimitStateExited = (byte)'I',
    NationalBestBidLimitStateExitedAndNationalBestOfferLimitStateEntered = (byte)'J',
};

/// <summary>
///  Market Status Message Type Values
/// </summary>
public enum MarketStatusMessageType : byte {
    MarketWideCircuitBreakerDeclineLevelStatusMessage = (byte)'M',
    MarketWideCircuitBreakerStatusMessage = (byte)'L',
    ApproximateAdjustedVolumeMarketCenterMessage = (byte)'N',
    ApproximateTradesAndTotalDollarValueMessage = (byte)'O',
    CrossingSessionSummaryMessage = (byte)'P',
};

/// <summary>
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    Administrative = (byte)'A',
    Control = (byte)'C',
    Index = (byte)'I',
    MarketStatus = (byte)'M',
    PriorDay = (byte)'P',
    Summary = (byte)'S',
    Trade = (byte)'T',
};

/// <summary>
///  Participant Id Values
/// </summary>
public enum ParticipantId : byte {
    NyseAmerican = (byte)'A',
    NasdaqBx = (byte)'B',
    NyseNational = (byte)'C',
    FinraAdf = (byte)'D',
    Ise = (byte)'I',
    CboeEdga = (byte)'J',
    CboeEdgx = (byte)'K',
    Ltse = (byte)'L',
    NyseChicago = (byte)'M',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Cts = (byte)'S',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Participant Open High Low Last Indicator Values
/// </summary>
public enum ParticipantOpenHighLowLastIndicator : byte {
    None = (byte)'A',
    High = (byte)'B',
    Low = (byte)'C',
    Last = (byte)'D',
    HighLast = (byte)'E',
    LowLast = (byte)'F',
    Unused = (byte)'G',
    Open = (byte)'H',
    OpenHigh = (byte)'I',
    OpenLow = (byte)'J',
    OpenHighLowLast = (byte)'K',
    OpenLast = (byte)'L',
    OpenHighLow = (byte)'M',
    OpenHighLast = (byte)'N',
    OpenLowLast = (byte)'O',
    HighLow = (byte)'P',
    HighLowLast = (byte)'Q',
};

/// <summary>
///  Primary Listing Market Participant Id Values
/// </summary>
public enum PrimaryListingMarketParticipantId : byte {
    NyseAmerican = (byte)'A',
    NasdaqBx = (byte)'B',
    NyseNational = (byte)'C',
    FinraAdf = (byte)'D',
    Ise = (byte)'I',
    CboeEdga = (byte)'J',
    CboeEdgx = (byte)'K',
    NyseChicago = (byte)'M',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Prior Day Message Type Values
/// </summary>
public enum PriorDayMessageType : byte {
    PriorDayTradeCorrectionMessage = (byte)'C',
    PriorDayTradeMessage = (byte)'L',
    PriorDayTradeMessage = (byte)'X',
};

/// <summary>
///  Retransmission Indicator Values
/// </summary>
public enum RetransmissionIndicator : byte {
    Original = (byte)'O',
    Retransmitted = (byte)'V',
};

/// <summary>
///  Sale Condition Values
/// </summary>
public enum SaleCondition : byte {
    RegularSale = (byte)' ',
    AveragePriceTrade = (byte)'B',
    CashTrade = (byte)'C',
    AutomaticExecution = (byte)'E',
    IntermarketSweepOrder = (byte)'F',
    PriceVariationTrade = (byte)'H',
    OddLotTrade = (byte)'I',
    Rule127Or155 = (byte)'K',
    SoldLast = (byte)'L',
    MarketCenterOfficialClose = (byte)'M',
    NextDayTrade = (byte)'N',
    MarketCenterOpeningTrade = (byte)'O',
    PriorReferencePrice = (byte)'P',
    MarketCenterOfficialOpen = (byte)'Q',
    Seller = (byte)'R',
    ExtendedHoursTrade = (byte)'T',
    ExtendedHoursSold = (byte)'U',
    ContingentTrade = (byte)'V',
    CrossTrade = (byte)'X',
    Sold = (byte)'Z',
    DerivativelyPriced = (byte)'4',
    MarketCenterReopeningTrade = (byte)'5',
    MarketCenterClosingTrade = (byte)'6',
    QualifiedContingentTrade = (byte)'7',
    Reserved = (byte)'8',
    CorrectedConsolidatedClosePriceAsPerListingMarket = (byte)'9',
};

/// <summary>
///  Sale Condition Category Values
/// </summary>
public enum SaleConditionCategory : byte {
    NotApplicable = (byte)' ',
    Category1 = (byte)'1',
    Category2 = (byte)'2',
    Category3 = (byte)'3',
    Category4 = (byte)'4',
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    NotApplicable = (byte)' ',
    OpeningDelay = (byte)'1',
    TradingHalt = (byte)'2',
    Resume = (byte)'3',
    NoOpenNoResume = (byte)'4',
    PriceIndication = (byte)'5',
    TradingRangeIndication = (byte)'6',
    MarketImbalanceBuy = (byte)'7',
    MarketImbalanceSell = (byte)'8',
    MarketOnCloseImbalanceBuy = (byte)'9',
    MarketOnCloseImbalanceSell = (byte)'A',
    Reserved = (byte)'B',
    NoMarketImbalance = (byte)'C',
    NoMarketOnCloseImbalance = (byte)'D',
    ShortSaleRestriction = (byte)'E',
    LimitUpLimitDown = (byte)'F',
};

/// <summary>
///  Short Sale Restriction Indicator Values
/// </summary>
public enum ShortSaleRestrictionIndicator : byte {
    NotInEffect = (byte)' ',
    Activated = (byte)'A',
    Continued = (byte)'C',
    Deactivated = (byte)'D',
    RestrictionInEffect = (byte)'E',
};

/// <summary>
///  Stop Stock Indicator Values
/// </summary>
public enum StopStockIndicator : byte {
    NotApplicable = (byte)'0',
    StopStock = (byte)'1',
};

/// <summary>
///  Summary Message Type Values
/// </summary>
public enum SummaryMessageType : byte {
    ConsolidatedStartOfDaySummaryMessage = (byte)'A',
    ParticipantStartOfDaySummaryMessage = (byte)'B',
    ConsolidatedEndOfDaySummaryMessage = (byte)'C',
    ParticipantEndOfDaySummaryMessage = (byte)'D',
};

/// <summary>
///  Tick Values
/// </summary>
public enum Tick : byte {
    NotApplicable = (byte)' ',
    Upward = (byte)'1',
    Downward = (byte)'2',
    UnchangedUpward = (byte)'3',
    UnchangedDownward = (byte)'4',
};

/// <summary>
///  Trade Message Type Values
/// </summary>
public enum TradeMessageType : byte {
    AuctionStatusMessage = (byte)'A',
    TradeCorrectionMessage = (byte)'C',
    LongTradeMessage = (byte)'L',
    TradingStatusMessage = (byte)'S',
    ShortTradeMessage = (byte)'T',
    TradeCancelErrorMessage = (byte)'X',
};

/// <summary>
///  Trade Reporting Facility Id Values
/// </summary>
public enum TradeReportingFacilityId : byte {
    NotApplicable = (byte)' ',
    InactiveValueA = (byte)'A',
    FinraNasdaqChicago = (byte)'B',
    InactiveValueC = (byte)'C',
    InactiveValueD = (byte)'D',
    InactiveValueI = (byte)'I',
    InactiveValueJ = (byte)'J',
    InactiveValueK = (byte)'K',
    InactiveValueM = (byte)'M',
    FinraNyse = (byte)'N',
    InactiveValueP = (byte)'P',
    FinraNasdaqCarteret = (byte)'B',
    InactiveValueV = (byte)'V',
    InactiveValueW = (byte)'W',
    InactiveValueX = (byte)'X',
    InactiveValueY = (byte)'Y',
    InactiveValueZ = (byte)'Z',
};

/// <summary>
///  Trade Through Exempt Indicator Values
/// </summary>
public enum TradeThroughExemptIndicator : byte {
    NotATradeThroughExemption = (byte)'0',
    TradeThroughExemption = (byte)'1',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Administrative
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Administrative {
    public AdministrativeMessageType AdministrativeMessageType;
};

/// <summary>
///  Struct for Administrative Unformatted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdministrativeUnformattedMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed byte Text[0];
};

/// <summary>
///  Struct for Approximate Adjusted Volume Market Center Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApproximateAdjustedVolumeMarketCenterMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public byte NumberOfParticipants;
};

/// <summary>
///  Struct for Approximate Trades And Total Dollar Value Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApproximateTradesAndTotalDollarValueMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public uint TotalTrades;
    public ulong DollarValue;
};

/// <summary>
///  Struct for Auction Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionStatusMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public ulong AuctionCollarReferencePrice;
    public fixed byte AuctionCollarUpperThresholdPrice[0];
    public ulong AuctionCollarLowerThresholdPrice;
    public byte NumberOfExtensions;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public fixed sbyte FutureUse[62];
};

/// <summary>
///  Struct for Bid And Offer Index Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BidAndOfferIndexMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte IndexSymbol[11];
    public long BidIndexValue;
    public long OfferIndexValue;
};

/// <summary>
///  Struct for Block Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BlockHeader {
    public byte Version;
    public ushort BlockSize;
    public fixed sbyte DataFeedIndicator[1];
    public RetransmissionIndicator RetransmissionIndicator;
    public uint BlockSequenceNumber;
    public byte MessagesInBlock;
    public fixed byte SipBlockTimestamp[0];
    public ushort BlockChecksum;
};

/// <summary>
///  Struct for Consolidated Data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedData {
    public uint PreviousClosePriceDate;
    public LastParticipantId LastParticipantId;
    public ulong LastPrice;
    public ulong HighPrice;
    public ulong LowPrice;
    public ulong TotalVolume;
    public Tick Tick;
};

/// <summary>
///  Struct for Consolidated End Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedEndOfDaySummaryMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public LastParticipantId LastParticipantId;
    public uint PreviousClosePriceDate;
    public ulong LastPrice;
    public ulong HighPrice;
    public ulong LowPrice;
    public ulong TotalVolume;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public byte NumberOfParticipants;
};

/// <summary>
///  Struct for Consolidated Start Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedStartOfDaySummaryMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public ParticipantId ParticipantId;
    public uint PreviousClosePriceDate;
    public ulong PreviousClosePrice;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public byte NumberOfParticipants;
};

/// <summary>
///  Struct for Control
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Control {
    public ControlMessageType ControlMessageType;
};

/// <summary>
///  Struct for Corrected Trade
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CorrectedTrade {
    public fixed byte SaleConditions[0];
    public fixed byte TradePriceLong[0];
    public fixed byte TradeVolumeLong[0];
    public byte SellersSaleDays;
    public StopStockIndicator StopStockIndicator;
    public TradeThroughExemptIndicator TradeThroughExemptIndicator;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public fixed byte PriorDayTradeDateAndTime[0];
};

/// <summary>
///  Struct for Crossing Session Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossingSessionSummaryMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public ulong CrossingSession1TotalTradesVolume;
    public ulong CrossingSession2DollarValue;
    public ulong CrossingSession2TotalTradesVolume;
};

/// <summary>
///  Struct for Disaster Recovery Data Center Activation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DisasterRecoveryDataCenterActivationMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for End Of End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfEndOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for End Of Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfStartOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for End Of Test Cycle Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTestCycleMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Index
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Index {
    public IndexMessageType IndexMessageType;
};

/// <summary>
///  Struct for Index Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IndexMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte IndexSymbol[11];
    public long IndexValue;
};

/// <summary>
///  Struct for Line Integrity Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LineIntegrityMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Long Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongTradeMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public fixed byte SaleConditions[0];
    public ulong TradePrice;
    public uint TradeVolume;
    public byte SellersSaleDays;
    public StopStockIndicator StopStockIndicator;
    public TradeThroughExemptIndicator TradeThroughExemptIndicator;
    public TradeReportingFacilityId TradeReportingFacilityId;
    public fixed byte Timestamp2[0];
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public HeldTradeIndicator HeldTradeIndicator;
    public ConsolidatedHighLowLastIndicator ConsolidatedHighLowLastIndicator;
    public ParticipantOpenHighLowLastIndicator ParticipantOpenHighLowLastIndicator;
};

/// <summary>
///  Struct for Market Status
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatus {
    public MarketStatusMessageType MarketStatusMessageType;
};

/// <summary>
///  Struct for Market Wide Circuit Breaker Decline Level Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketWideCircuitBreakerDeclineLevelStatusMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed byte MwcbLevel1[0];
    public long MwcbLevel2;
    public long MwcbLevel3;
    public byte Reserved;
};

/// <summary>
///  Struct for Market Wide Circuit Breaker Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketWideCircuitBreakerStatusMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed byte MarketWideCircuitBreakerLevelIndicator[0];
    public byte Reserved;
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
    public ushort MessageLength;
    public MessageCategory MessageCategory;
};

/// <summary>
///  Struct for Original Trade
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OriginalTrade {
    public fixed byte SaleConditions[0];
    public fixed byte TradePriceLong[0];
    public fixed byte TradeVolumeLong[0];
    public byte SellersSaleDays;
    public StopStockIndicator StopStockIndicator;
    public TradeThroughExemptIndicator TradeThroughExemptIndicator;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public fixed byte PriorDayTradeDateAndTime[0];
};

/// <summary>
///  Struct for Participant Data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParticipantData {
    public uint PreviousClosePriceDate;
    public LastParticipantId LastParticipantId;
    public ulong LastPrice;
    public ulong HighPrice;
    public ulong LowPrice;
    public ulong TotalVolume;
    public Tick Tick;
};

/// <summary>
///  Struct for Participant End Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParticipantEndOfDaySummaryMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public ParticipantId ParticipantId;
    public uint PreviousClosePriceDate;
    public ulong LastPrice;
    public ulong HighPrice;
    public ulong LowPrice;
    public ulong OpenPrice;
    public ulong TotalVolume;
    public Tick Tick;
};

/// <summary>
///  Struct for Participant Start Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParticipantStartOfDaySummaryMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public ParticipantId ParticipantId;
    public uint PreviousClosePriceDate;
    public ulong PreviousClosePrice;
};

/// <summary>
///  Struct for Participants
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Participants {
    public ParticipantId ParticipantId;
    public ulong TradeTotalVolume;
};

/// <summary>
///  Struct for Prior Day
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriorDay {
    public PriorDayMessageType PriorDayMessageType;
};

/// <summary>
///  Struct for Prior Day Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriorDayTradeCorrectionMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public fixed byte CorrectedTrade[0];
    public TradeReportingFacilityId TradeReportingFacilityId;
    public fixed byte OriginalTrade[0];
};

/// <summary>
///  Struct for Prior Day Trade Date And Time
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriorDayTradeDateAndTime {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Prior Day Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriorDayTradeMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public fixed byte SaleConditions[0];
    public ulong TradePrice;
    public uint TradeVolume;
    public byte SellersSaleDays;
    public StopStockIndicator StopStockIndicator;
    public TradeThroughExemptIndicator TradeThroughExemptIndicator;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public TradeReportingFacilityId TradeReportingFacilityId;
    public fixed byte PriorDayTradeDateAndTime[0];
};

/// <summary>
///  Struct for Reset Block Sequence Number Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetBlockSequenceNumberMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Sale Conditions
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SaleConditions {
    public fixed sbyte Category1[1];
    public Category2 Category2;
    public Category3 Category3;
    public Category4 Category4;
};

/// <summary>
///  Struct for Short Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortTradeMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbolShort[5];
    public SaleCondition SaleCondition;
    public SaleConditionCategory SaleConditionCategory;
    public ushort TradePriceShort;
    public ushort TradeVolumeShort;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public ConsolidatedHighLowLastIndicator ConsolidatedHighLowLastIndicator;
    public ParticipantOpenHighLowLastIndicator ParticipantOpenHighLowLastIndicator;
};

/// <summary>
///  Struct for Sip Block Timestamp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SipBlockTimestamp {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Start Of End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfEndOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Start Of Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfStartOfDayMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Start Of Test Cycle Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfTestCycleMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Summary {
    public SummaryMessageType SummaryMessageType;
};

/// <summary>
///  Struct for Timestamp 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Timestamp1 {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Timestamp 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Timestamp2 {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Trade
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Trade {
    public TradeMessageType TradeMessageType;
};

/// <summary>
///  Struct for Trade Cancel Error Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelErrorMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public fixed byte SaleConditions[0];
    public ulong TradePrice;
    public uint TradeVolume;
    public byte SellersSaleDays;
    public StopStockIndicator StopStockIndicator;
    public TradeThroughExemptIndicator TradeThroughExemptIndicator;
    public TradeReportingFacilityId TradeReportingFacilityId;
    public fixed byte OriginalParticipantReferenceNumberOfOriginalTransactionBeingCancelledOrErrored[0];
    public fixed byte Timestamp2[0];
    public CancelErrorAction CancelErrorAction;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public fixed byte ConsolidatedData[0];
    public fixed byte ParticipantData[0];
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public fixed byte CorrectedTrade[0];
    public TradeReportingFacilityId TradeReportingFacilityId;
    public fixed byte Timestamp2[0];
    public long OriginalParticipantReferenceNumber;
    public fixed byte OriginalTrade[0];
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public fixed byte ConsolidatedData[0];
    public fixed byte ParticipantData[0];
};

/// <summary>
///  Struct for Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingStatusMessage {
    public ParticipantId ParticipantId;
    public fixed byte Timestamp1[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbol[11];
    public InstrumentType InstrumentType;
    public ulong LastPrice;
    public ulong HighIndicationPriceUpperLimitPriceBand;
    public ulong LowIndicationPriceLowerLimitPriceBand;
    public uint BuyVolume;
    public uint SellVolume;
    public SecurityStatus SecurityStatus;
    public HaltReason HaltReason;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public LimitUpLimitDownIndicator LimitUpLimitDownIndicator;
};

