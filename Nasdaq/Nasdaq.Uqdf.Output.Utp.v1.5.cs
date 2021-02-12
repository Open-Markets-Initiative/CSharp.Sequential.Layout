// C# Structs For Nasdaq Uqdf Utp Output 1.5 protocol

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
    SessionCloseRecapMessage = (byte)'R',
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
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfDayMessage = (byte)'I',
    EndOfDayMessage = (byte)'J',
    MarketSessionOpenMessage = (byte)'O',
    MarketSessionCloseMessage = (byte)'C',
    EndOfTransmissionsMessage = (byte)'Z',
    QuoteWipeOutMessage = (byte)'P',
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
///  Finra Adf Mpid Appendage Indicator Values
/// </summary>
public enum FinraAdfMpidAppendageIndicator : byte {
    NotApplicable = (byte)' ',
    NoAdfMpidChanges = (byte)'0',
    NoAdfMpidExists = (byte)'1',
    AdfMpiDsAttached = (byte)'2',
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
///  Luld Bbo Indicator Values
/// </summary>
public enum LuldBboIndicator : byte {
    NotApplicable = (byte)' ',
    BidPriceAboveUpperLimitPriceBand = (byte)'A',
    AskPriceBelowLowerLimitPriceBand = (byte)'B',
    BidAndAskOutsidePriceBand = (byte)'C',
};

/// <summary>
///  Luld National Bbo Indicator Values
/// </summary>
public enum LuldNationalBboIndicator : byte {
    NotApplicable = (byte)' ',
    NationalBestBidAndNationalBestAskAreExecutable = (byte)'A',
    NationalBestBidBelowLowerLimitPriceBand = (byte)'B',
    NationalBestAskAboveUpperLimitPriceBand = (byte)'C',
    NationalBestBidBelowLowerLimitPriceBandAndNationalBestAskAboveUpperLimitPriceBand = (byte)'D',
    NationalBestBidEqualsUpperLimitPriceBand = (byte)'E',
    NationalBestOfferEqualsLowerLimitPriceBand = (byte)'F',
    NationalBestBidEqualsUpperLimitPriceBand = (byte)'G',
    NationalBestAskEqualsLowerLimitPriceBand = (byte)'H',
    NationalBestBidEqualsUpperLimitPriceBandAndNationalBestAskEqualsLowerLimitPriceBand = (byte)'I',
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
///  Nbbo Appendage Indicator Values
/// </summary>
public enum NbboAppendageIndicator : byte {
    NoNationalBboChange = (byte)'0',
    NoNationalBboCanBeCalculated = (byte)'1',
    ShortFormNationalBboAppendage = (byte)'2',
    LongFormNationalBboAppendage = (byte)'3',
    QuoteContainsAllNationalBboInformation = (byte)'4',
};

/// <summary>
///  Nbbo Quote Condition Values
/// </summary>
public enum NbboQuoteCondition : byte {
    ManualAskAutomatedBid = (byte)'A',
    ManualBidAutomatedAsk = (byte)'B',
    FastTrading = (byte)'F',
    ManualBidAndAsk = (byte)'H',
    OrderImbalance = (byte)'I',
    ClosedQuote = (byte)'L',
    NonFirmQuote = (byte)'N',
    OpeningQuoteAutomated = (byte)'O',
    RegularTwoSidedOpenQuoteAutomated = (byte)'R',
    ManualBidAndAskNonFirm = (byte)'U',
    OrderInflux = (byte)'X',
    AutomatedBidNoOfferOrAutomatedOfferNoBid = (byte)'Y',
    NoOpenNoResume = (byte)'Z',
    IntradayAuction = (byte)'4',
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    ManualAskAutomatedBid = (byte)'A',
    ManualBidAutomatedAsk = (byte)'B',
    FastTrading = (byte)'F',
    ManualBidAndAsk = (byte)'H',
    OrderImbalance = (byte)'I',
    ClosedQuote = (byte)'L',
    NonFirmQuote = (byte)'N',
    OpeningQuoteAutomated = (byte)'O',
    RegularTwoSidedOpenQuoteAutomated = (byte)'R',
    ManualBidAndAskNonFirm = (byte)'U',
    OrderInflux = (byte)'X',
    AutomatedBidNoOfferOrAutomatedOfferNoBid = (byte)'Y',
    NoOpenNoResume = (byte)'Z',
    IntradayAuction = (byte)'4',
};

/// <summary>
///  Quote Message Type Values
/// </summary>
public enum QuoteMessageType : byte {
    QuoteShortFormMessage = (byte)'E',
    QuoteLongFormMessage = (byte)'F',
    FinraAdfMarketParticipantQuotationMessage = (byte)'M',
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
///  Retail Interest Indicator Values
/// </summary>
public enum RetailInterestIndicator : byte {
    NotApplicable = (byte)' ',
    OnBidQuote = (byte)'A',
    OnAskQuote = (byte)'B',
    OnBothBidAndAskQuote = (byte)'C',
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
///  Sip Generated Update Values
/// </summary>
public enum SipGeneratedUpdate : byte {
    OriginatedFromTheMarketParticipant = (byte)' ',
    SiPgeneratedTransaction = (byte)'E',
};

/// <summary>
///  Special Condition Values
/// </summary>
public enum SpecialCondition : byte {
    OneSidedNationalBboAtMarketClose = (byte)'O',
    TradingHaltInEffectAtMarketClose = (byte)'H',
    NoEligibleMarketParticipantQuotesInIssueAtMarketClose = (byte)'M',
    NoSpecialConditionExists = (byte)' ',
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
///  Trading Action Code Values
/// </summary>
public enum TradingActionCode : byte {
    TradingHalt = (byte)'H',
    QuotationResumptionIncludingAfterEma = (byte)'Q',
    TradingResumption = (byte)'T',
    VolatilityTradingPause = (byte)'P',
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
///  Struct for Auction Collar Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionCollarMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
    public uint TradingActionSequenceNumber;
    public ulong CollarReferencePrice;
    public ulong CollarUpPrice;
    public ulong CollarDownPrice;
    public fixed sbyte CollarExtensionIndicator[1];
};

/// <summary>
///  Struct for Control
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Control {
    public ControlMessageType ControlMessageType;
};

/// <summary>
///  Struct for Cross Sro Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossSroTradingActionMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
    public TradingActionCode TradingActionCode;
    public uint TradingActionSequenceNumber;
    public ulong ActionTimestamp;
    public fixed sbyte TradingActionReason[6];
};

/// <summary>
///  Struct for End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMessage {
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
///  Struct for Finra Adf Market Participant Quotation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FinraAdfMarketParticipantQuotationMessage {
    public fixed byte MessageInfo[0];
    public ulong FinraTimestamp;
    public fixed sbyte Symbol[11];
    public ulong BidPrice;
    public uint BidSize;
    public ulong AskPrice;
    public uint AskSize;
    public QuoteCondition QuoteCondition;
    public fixed sbyte FinraMarketParticipant[4];
};

/// <summary>
///  Struct for Finra Adf Mpid Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FinraAdfMpidAppendage {
    public fixed sbyte BidAdfMpid[4];
    public fixed sbyte AskAdfMpid[4];
};

/// <summary>
///  Struct for General Administrative Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GeneralAdministrativeMessage {
    public fixed byte MessageInfo[0];
    public ushort TextLength;
};

/// <summary>
///  Struct for Issue Symbol Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IssueSymbolDirectoryMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
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
    public fixed sbyte Symbol[11];
    public LuldPriceBandIndicator LuldPriceBandIndicator;
    public ulong LuldTimestamp;
    public ulong LimitDownPrice;
    public ulong LimitUpPrice;
};

/// <summary>
///  Struct for Long Form National Bbo Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongFormNationalBboAppendage {
    public NbboQuoteCondition NbboQuoteCondition;
    public fixed sbyte BestBidMarketCenter[1];
    public ulong BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestAskMarketCenter[1];
    public ulong BestAskPrice;
    public uint BestAskSize;
};

/// <summary>
///  Struct for Market Center Close Recap
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCenterCloseRecap {
    public fixed sbyte MarketCenterIdentifier[1];
    public ulong MarketCenterBidPrice;
    public ulong MarketCenterBidSize;
    public ulong MarketCenterAskPrice;
    public ulong MarketCenterAskSize;
};

/// <summary>
///  Struct for Market Center Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCenterTradingActionMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
    public TradingActionCode TradingActionCode;
    public ulong ActionTimestamp;
    public fixed sbyte MarketCenterIdentifier[1];
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
///  Struct for Quote
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Quote {
    public QuoteMessageType QuoteMessageType;
};

/// <summary>
///  Struct for Quote Wipe Out Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteWipeOutMessage {
    public fixed byte MessageInfo[0];
};

/// <summary>
///  Struct for Regulation Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegulationShoShortSalePriceTestRestrictedIndicatorMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Session Close Recap Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SessionCloseRecapMessage {
    public fixed byte MessageInfo[0];
    public fixed sbyte Symbol[11];
    public fixed sbyte NationalBestBidMarketCenter[1];
    public ulong NationalBestBidPrice;
    public ulong NationalBestBidSize;
    public fixed sbyte NationalBestAskMarketCenter[1];
    public ulong NationalBestAskPrice;
    public ulong NationalBestAskSize;
    public SpecialCondition SpecialCondition;
    public ushort NumberOfMarketCenterAttachments;
};

/// <summary>
///  Struct for Short Form National Bbo Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortFormNationalBboAppendage {
    public NbboQuoteCondition NbboQuoteCondition;
    public fixed sbyte NationalBestBidMarketCenter[1];
    public ushort NationalBestBidPriceShort;
    public ushort NationalBestBidSizeShort;
    public fixed sbyte NationalBestAskMarketCenter[1];
    public ushort NationalBestAskPriceShort;
    public ushort NationalBestAskSizeShort;
};

/// <summary>
///  Struct for Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfDayMessage {
    public fixed byte MessageInfo[0];
};

