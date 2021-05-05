// C# Structs For Siac Cqs Cta Output 1.91 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Administrative Message Type Values
/// </summary>
public enum AdministrativeMessageType : byte {
    AdministrativeUnformattedMessage = (byte)'H',
};

/// <summary>
///  Best Bid Participant Id Values
/// </summary>
public enum BestBidParticipantId : byte {
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
    Cqs = (byte)'S',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Best Offer Participant Id Values
/// </summary>
public enum BestOfferParticipantId : byte {
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
    Cqs = (byte)'S',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfDayMessage = (byte)'A',
    FinraCloseMessage = (byte)'C',
    ResetBlockSequenceNumberMessage = (byte)'L',
    StartOfTestCycleMessage = (byte)'M',
    EndOfTestCycleMessage = (byte)'N',
    FinraOpenMessage = (byte)'O',
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
///  Finra Bbo Indicator Values
/// </summary>
public enum FinraBboIndicator : byte {
    NotApplicable = (byte)' ',
    NoFinraBboChange = (byte)'A',
    NoFinraBboExists = (byte)'B',
};

/// <summary>
///  Finra Bbo Luld Indicator Values
/// </summary>
public enum FinraBboLuldIndicator : byte {
    LimitUpLimitDownNotApplicable = (byte)'',
    FinraBestBidAndOrFinraBestOfferAreExecutable = (byte)'A',
    FinraBestBidBelowLowerLimitPriceBandAndFinraBestBidIsNonExecutable = (byte)'B',
    FinraBestOfferAboveUpperLimitPriceBandAndFinraBestOfferIsNonExecutable = (byte)'C',
    BestBidBelowLowerLimitPriceBandAndBestOfferAboveUpperLimitPriceBandBestBidAndBestOfferAreNonExecutableForFinra = (byte)'D',
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
///  Market Condition Values
/// </summary>
public enum MarketCondition : byte {
    NormalAuctionMarket = (byte)' ',
    CrossedMarket = (byte)'A',
    LockedMarket = (byte)'B',
};

/// <summary>
///  Market Status Message Type Values
/// </summary>
public enum MarketStatusMessageType : byte {
    MarketWideCircuitBreakerDeclineLevelStatusMessage = (byte)'M',
    MarketWideCircuitBreakerStatusMessage = (byte)'L',
};

/// <summary>
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    Administrative = (byte)'A',
    Control = (byte)'C',
    MarketStatus = (byte)'M',
    Quote = (byte)'Q',
};

/// <summary>
///  National Bbo Indicator Values
/// </summary>
public enum NationalBboIndicator : byte {
    NotIncluded = (byte)' ',
    NoBestBidChangeOrBestOfferChange = (byte)'A',
    NoBestBidChangeQuoteContainsBestOffer = (byte)'B',
    NoBestBidChangeBestOfferShortAppendage = (byte)'C',
    NoBestBidChangeBestOfferLongAppendage = (byte)'D',
    NoBestBidChangeNoBestOffer = (byte)'E',
    QuoteContainsBestBidNoBestOfferChange = (byte)'F',
    QuoteContainsBestBidQuoteContainsBestOffer = (byte)'G',
    QuoteContainsBestBidBestOfferShortAppendage = (byte)'H',
    QuoteContainsBestBidBestOfferLongAppendage = (byte)'I',
    QuoteContainsBestBidNoBestOffer = (byte)'J',
    NoBestBidNoBestOfferChange = (byte)'K',
    NoBestBidQuoteContainsBestOffer = (byte)'L',
    NoBestBidBestOfferShortAppendage = (byte)'M',
    NoBestBidBestOfferLongAppendage = (byte)'N',
    NoBestBidNoBestOffer = (byte)'O',
    BestBidShortAppendageNoBestOfferChange = (byte)'P',
    BestBidLongAppendageNoBestOfferChange = (byte)'Q',
    BestBidShortAppendageQuoteContainsBestOffer = (byte)'R',
    BestBidLongAppendageQuoteContainsBestOffer = (byte)'S',
    BestBidShortAppendageBestOfferShortAppendage = (byte)'T',
    BestBidLongAppendageBestOfferLongAppendage = (byte)'U',
    BestBidShortAppendageNoBestOffer = (byte)'V',
    BestBidLongAppendageNoBestOffer = (byte)'W',
};

/// <summary>
///  National Bbo Luld Indicator Values
/// </summary>
public enum NationalBboLuldIndicator : byte {
    NotApplicable = (byte)' ',
    NationalBestBidAndOrNationalBestOfferAreExecutable = (byte)'A',
    NationalBestBidBelowLowerLimitPriceBandAndIsNonExecutable = (byte)'B',
    NationalBestOfferAboveUpperLimitPriceBandAndIsNonExecutable = (byte)'C',
    NationalBestBidBelowLowerLimitPriceBandAndNationalBestOfferAboveUpperLimitPriceBandBothAreNonExecutable = (byte)'D',
    NationalBestBidEqualsUpperLimitPriceBandAndIsInLimitState = (byte)'E',
    NationalBestOfferEqualsLowerLimitPriceBandAndIsInLimitState = (byte)'F',
    NationalBestBidEqualsUpperLimitPriceBandAndIsInLimitStateAndNationalBestOfferAboveUpperLimitPriceBandAndIsNonExecutable = (byte)'G',
    NationalBestBidBelowLowerLimitPriceBandAndIsNonExecutableAndNationalBestOfferEqualsLowerLimitPriceBandAndIsInLimitState = (byte)'H',
    NationalBestBidEqualsUpperLimitPriceBandAndNationalBestOfferEqualsLowerLimitPriceBand = (byte)'I',
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
    Cqs = (byte)'S',
    Nasdaq = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Primary Listing Market Participant Id Values
/// </summary>
public enum PrimaryListingMarketParticipantId : byte {
    PrimaryListingMarketParticipantIdNotApplicable = (byte)'Space',
    NyseAmerican = (byte)'A',
    NasdaqOmxBx = (byte)'B',
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
    NasdaqOmxPsx = (byte)'X',
    CboeByx = (byte)'Y',
    CboeBzx = (byte)'Z',
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    QuoteConditionNotApplicable = (byte)' ',
    SlowQuoteOnOfferSide = (byte)'A',
    SlowQuoteOnBidSide = (byte)'B',
    Closing = (byte)'C',
    SlowQuoteDueToLrpOrGapQuoteOnTheBidSide = (byte)'E',
    SlowQuoteDueToLrpOrGapQuoteOnTheOfferSide = (byte)'F',
    SlowQuoteOnTheBidAndOfferSides = (byte)'H',
    ClosedMarketMaker = (byte)'L',
    NonFirmQuote = (byte)'N',
    OpeningQuote = (byte)'O',
    RegularFinraOpen = (byte)'R',
    SlowQuoteDueToLiquidityReplenishmentPointOrGapQuoteOnBothTheBidAndOfferSides = (byte)'U',
    SlowQuoteDueToSetSlowListOnBothTheBidAndOfferSides = (byte)'W',
    OnDemandIntraDayAuction = (byte)'4',
};

/// <summary>
///  Quote Message Type Values
/// </summary>
public enum QuoteMessageType : byte {
    AuctionStatusMessage = (byte)'A',
    LongQuoteMessage = (byte)'L',
    ShortQuoteMessage = (byte)'Q',
    SpecialLongQuoteMessage = (byte)'S',
};

/// <summary>
///  Retail Interest Indicator Values
/// </summary>
public enum RetailInterestIndicator : byte {
    NotApplicable = (byte)' ',
    RetailInterestOnBidQuote = (byte)'A',
    RetailInterestOnOfferQuote = (byte)'B',
    RetailInterestOnBothTheBidAndOfferQuotes = (byte)'C',
};

/// <summary>
///  Retransmission Indicator Values
/// </summary>
public enum RetransmissionIndicator : byte {
    Original = (byte)'O',
    Retransmitted = (byte)'V',
};

/// <summary>
///  Security Status Indicator Values
/// </summary>
public enum SecurityStatusIndicator : byte {
    NotApplicable = (byte)' ',
    NewsDissemination = (byte)'D',
    TradingRangeIndication = (byte)'G',
    OrderImbalance = (byte)'I',
    LuldTradingPause = (byte)'M',
    NewsPending = (byte)'P',
    Resume = (byte)'T',
    Operational = (byte)'X',
    SupPennyTrading = (byte)'Y',
    NoOpenNoResume = (byte)'Z',
    LuldPriceBand = (byte)'0',
    MarketWideCircuitBreakerLevel1Breached = (byte)'1',
    MarketWideCircuitBreakerLevel2Breached = (byte)'2',
    MarketWideCircuitBreakerLevel3Breached = (byte)'3',
    RepublishedLuldPriceBand = (byte)'9',
};

/// <summary>
///  Settlement Condition Values
/// </summary>
public enum SettlementCondition : byte {
    RegularWaySettlement = (byte)' ',
    CashOnlySettlement = (byte)'A',
    NextDayOnlySettlement = (byte)'B',
};

/// <summary>
///  Short Sale Restriction Indicator Values
/// </summary>
public enum ShortSaleRestrictionIndicator : byte {
    NotInEffect = (byte)' ',
    ShortSaleRestrictionActivated = (byte)'A',
    ShortSaleRestrictionContinued = (byte)'C',
    ShortSaleRestrictionDeactivated = (byte)'D',
    ShortSaleRestrictionInEffect = (byte)'E',
};

/// <summary>
///  Sip Generated Message Identifier Values
/// </summary>
public enum SipGeneratedMessageIdentifier : byte {
    NotApplicable = (byte)' ',
    ConsolidatedQuotationSystem = (byte)'S',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Adf Timestamp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdfTimestamp {
    public uint Seconds;
    public uint Nanoseconds;
};

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
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed byte Text[0];
};

/// <summary>
///  Struct for Auction Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionStatusMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
    public fixed sbyte SecuritySymbolLong[11];
    public InstrumentType InstrumentType;
    public fixed byte AuctionCollarReferencePrice[0];
    public fixed byte AuctionCollarUpperThresholdPrice[0];
    public fixed byte AuctionCollarLowerThresholdPrice[0];
    public byte NumberOfExtensions;
    public ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
    public PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public fixed sbyte Future[1];
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
///  Struct for Control
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Control {
    public ControlMessageType ControlMessageType;
};

/// <summary>
///  Struct for Disaster Recovery Data Center Activation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DisasterRecoveryDataCenterActivationMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
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
    public fixed byte ParticipantTimestamp[0];
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
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Finra Close Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FinraCloseMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Finra Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FinraOpenMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

/// <summary>
///  Struct for Line Integrity Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LineIntegrityMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
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
    public fixed byte ParticipantTimestamp[0];
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
    public fixed byte ParticipantTimestamp[0];
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
///  Struct for National Best Bid Long Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NationalBestBidLongAppendage {
    public BestBidParticipantId BestBidParticipantId;
    public fixed sbyte BestBidQuoteCondition[1];
    public ulong BestBidPriceLong;
    public uint BestBidSizeLong;
    public fixed sbyte FinraBestBidMarketMakerId[4];
};

/// <summary>
///  Struct for National Best Bid Short Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NationalBestBidShortAppendage {
    public BestBidParticipantId BestBidParticipantId;
    public ushort BestBidPriceShort;
    public ushort BestBidSizeShort;
};

/// <summary>
///  Struct for National Best Offer Long Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NationalBestOfferLongAppendage {
    public BestOfferParticipantId BestOfferParticipantId;
    public fixed sbyte BestOfferQuoteCondition[1];
    public ulong BestOfferPriceLong;
    public uint BestOfferSizeLong;
    public fixed sbyte FinraBestOfferMarketMakerId[4];
};

/// <summary>
///  Struct for National Best Offer Short Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NationalBestOfferShortAppendage {
    public BestOfferParticipantId BestOfferParticipantId;
    public ushort BestOfferPriceShort;
    public ushort BestOfferSizeShort;
};

/// <summary>
///  Struct for Participant Timestamp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParticipantTimestamp {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Quote
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Quote {
    public QuoteMessageType QuoteMessageType;
};

/// <summary>
///  Struct for Reset Block Sequence Number Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetBlockSequenceNumberMessage {
    public ParticipantId ParticipantId;
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
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
    public fixed byte ParticipantTimestamp[0];
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
    public fixed byte ParticipantTimestamp[0];
    public byte MessageId;
    public uint TransactionId;
    public long ParticipantReferenceNumber;
};

