// C# Structs For Siac Opra Obi Recipient 4.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Bbo Indicator Values
/// </summary>
public enum BboIndicator : byte {
    NoBestBidChangeOrBestOfferChange = (byte)'A',
    NoBestBidChangeQuoteContainsBestOffer = (byte)'B',
    NoBestBidChangeBestOfferAppendage = (byte)'C',
    NoBestBidChangeNoBestOffer = (byte)'D',
    QuoteContainsBestBidNoBestOfferChange = (byte)'E',
    QuoteContainsBestBidQuoteContainsBestOffer = (byte)'F',
    QuoteContainsBestBidBestOfferAppendage = (byte)'G',
    QuoteContainsBestBidNoBestOffer = (byte)'H',
    NoBestBidNoBestOfferChange = (byte)'I',
    NoBestBidQuoteContainsBestOffer = (byte)'J',
    NoBestBidBestOfferAppendage = (byte)'K',
    NoBestBidNoBestOffer = (byte)'L',
    BestBidAppendageNoBestOfferChange = (byte)'M',
    BestBidAppendageQuoteContainsBestOffer = (byte)'N',
    BestBidAppendageBestOfferAppendage = (byte)'O',
    BestBidAppendageNoBestOffer = (byte)'P',
    NotIncludedInTheBbo = (byte)' ',
};

/// <summary>
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfTestCycle = (byte)'A',
    EndOfTestCycle = (byte)'B',
    StartOfDay = (byte)'C',
    GoodMorning = (byte)'D',
    StartOfSummary = (byte)'E',
    EndOfSummary = (byte)'F',
    EarlyMarketClose = (byte)'G',
    EndOfTransactionReporting = (byte)'H',
    GoodNight = (byte)'I',
    EndOfDay = (byte)'J',
    ResetBlockSequenceNumber = (byte)'K',
    StartOfOpenInterest = (byte)'L',
    EndOfOpenInterest = (byte)'M',
    LineIntegrity = (byte)'N',
    DisasterRecoveryDataCenterActivation = (byte)'P',
};

/// <summary>
///  Expiration Month Values
/// </summary>
public enum ExpirationMonth : byte {
    January = (byte)'A',
    January = (byte)'M',
    February = (byte)'B',
    February = (byte)'N',
    March = (byte)'C',
    March = (byte)'O',
    April = (byte)'D',
    April = (byte)'P',
    May = (byte)'E',
    May = (byte)'Q',
    June = (byte)'F',
    June = (byte)'R',
    July = (byte)'G',
    July = (byte)'S',
    August = (byte)'H',
    August = (byte)'T',
    September = (byte)'I',
    September = (byte)'U',
    October = (byte)'J',
    October = (byte)'V',
    November = (byte)'K',
    November = (byte)'W',
    December = (byte)'L',
    December = (byte)'X',
};

/// <summary>
///  Index Value Denominator Code Values
/// </summary>
public enum IndexValueDenominatorCode : byte {
    Ten = (byte)'A',
    Hundred = (byte)'B',
    Thousand = (byte)'C',
    TenThousand = (byte)'D',
    HundredThousand = (byte)'E',
    Million = (byte)'F',
    TenMillion = (byte)'G',
    NoFraction = (byte)'I',
};

/// <summary>
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    EquityAndIndexLastSaleMessage = (byte)'a',
    OpenInterestMessage = (byte)'d',
    EquityAndIndexEndOfDaySummaryMessage = (byte)'f',
    LongEquityAndIndexQuoteMessage = (byte)'k',
    ShortEquityAndIndexQuoteMessage = (byte)'q',
    AdministrativeMessage = (byte)'C',
    ControlMessage = (byte)'H',
    UnderlyingValueMessage = (byte)'Y',
};

/// <summary>
///  Participant Id Values
/// </summary>
public enum ParticipantId : byte {
    NyseAmerican = (byte)'A',
    BostonOptionsExchange = (byte)'B',
    CboeOptionsExchange = (byte)'C',
    MiaxEmerald = (byte)'D',
    CboeEdgxOptions = (byte)'E',
    NasdaqGemx = (byte)'H',
    NasdaqIse = (byte)'I',
    NasdaqMrx = (byte)'J',
    MiamiInternationalSecuritiesExchange = (byte)'M',
    NyseArca = (byte)'N',
    OptionsPriceReportingAuthority = (byte)'O',
    MiaxPearl = (byte)'P',
    NasdaqOptionsMarket = (byte)'Q',
    NasdaqBxOptions = (byte)'T',
    CboeC2Options = (byte)'W',
    NasdaqPhlx = (byte)'X',
    CboeBzxOptionsExchange = (byte)'Z',
};

/// <summary>
///  Premium Price Denominator Code Values
/// </summary>
public enum PremiumPriceDenominatorCode : byte {
    Ten = (byte)'A',
    Hundred = (byte)'B',
    Thousand = (byte)'C',
    TenThousand = (byte)'D',
    HundredThousand = (byte)'E',
    Million = (byte)'F',
    TenMillion = (byte)'G',
    NoFraction = (byte)'I',
};

/// <summary>
///  Quote Message Type Values
/// </summary>
public enum QuoteMessageType : byte {
    RegularTrading = (byte)' ',
    NonFirmQuote = (byte)'F',
    IndicativeValue = (byte)'I',
    Rotation = (byte)'R',
    TradingHalted = (byte)'T',
    EligibleForAutomaticExecution = (byte)'A',
    BidContainsCustomerTradingInterest = (byte)'B',
    OfferContainsCustomerTradingInterest = (byte)'O',
    BothBidAndOfferContainCustomerTradingInterest = (byte)'C',
    OfferSideOfQuoteNotFirmBidSideFirm = (byte)'X',
    BidSideOfQuoteNotFirmOfferSideFirm = (byte)'Y',
};

/// <summary>
///  Session Indicator Values
/// </summary>
public enum SessionIndicator : byte {
    Regular = 0,
    PreMarket = 88,
};

/// <summary>
///  Strike Price Denominator Code Values
/// </summary>
public enum StrikePriceDenominatorCode : byte {
    Ten = (byte)'A',
    Hundred = (byte)'B',
    Thousand = (byte)'C',
    TenThousand = (byte)'D',
    HundredThousand = (byte)'E',
    NoFraction = (byte)'I',
};

/// <summary>
///  Trade Message Type Values
/// </summary>
public enum TradeMessageType : byte {
    Regular = (byte)' ',
    Canc = (byte)'A',
    Oseq = (byte)'B',
    Cncl = (byte)'C',
    Late = (byte)'D',
    Cnco = (byte)'E',
    Open = (byte)'F',
    Cnol = (byte)'G',
    Opnl = (byte)'H',
    Auto = (byte)'I',
    Reop = (byte)'J',
    Ajst = (byte)'K',
    Sprd = (byte)'L',
    Stdl = (byte)'M',
    Stpd = (byte)'N',
    Cstp = (byte)'O',
    Bwrt = (byte)'P',
    Cmbo = (byte)'Q',
    Spim = (byte)'R',
    Isoi = (byte)'S',
    Bnmt = (byte)'T',
    Xmpt = (byte)'X',
};

/// <summary>
///  Underlying Price Denominator Code Values
/// </summary>
public enum UnderlyingPriceDenominatorCode : byte {
    Ten = (byte)'A',
    Hundred = (byte)'B',
    Thousand = (byte)'C',
    TenThousand = (byte)'D',
    HundredThousand = (byte)'E',
    Million = (byte)'F',
    TenMillion = (byte)'G',
    HundredMillion = (byte)'H',
    NoFraction = (byte)'I',
};

/// <summary>
///  Underlying Value Message Type Values
/// </summary>
public enum UnderlyingValueMessageType : byte {
    UnderlyingValueLastSaleMessage = (byte)' ',
    UnderlyingValueBidAndOfferMessage = (byte)'I',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Administrative Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdministrativeMessage {
    public fixed sbyte MessageType[1];
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public ushort MessageDataLength;
};

/// <summary>
///  Struct for Best Bid Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidAppendage {
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public fixed byte Size[0];
};

/// <summary>
///  Struct for Best Offer Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestOfferAppendage {
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public fixed byte Size[0];
};

/// <summary>
///  Struct for Block Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BlockHeader {
    public byte Version;
    public ushort BlockSize;
    public fixed sbyte DataFeedIndicator[1];
    public fixed sbyte RetransmissionIndicator[1];
    public SessionIndicator SessionIndicator;
    public uint BlockSequenceNumber;
    public byte MessagesInBlock;
    public fixed byte BlockTimestamp[0];
    public ushort BlockChecksum;
};

/// <summary>
///  Struct for Block Timestamp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BlockTimestamp {
    public uint Seconds;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Control Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ControlMessage {
    public ControlMessageType ControlMessageType;
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public ushort MessageDataLength;
};

/// <summary>
///  Struct for Equity And Index End Of Day Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityAndIndexEndOfDaySummaryMessage {
    public fixed sbyte MessageType[1];
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Reserved1[1];
    public fixed byte ExpirationBlock[0];
    public StrikePriceDenominatorCode StrikePriceDenominatorCode;
    public uint StrikePrice;
    public uint Volume;
    public uint OpenInterestVolume;
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
    public int OpenPrice;
    public int HighPrice;
    public int LowPrice;
    public int LastPrice;
    public int NetChange;
    public UnderlyingPriceDenominatorCode UnderlyingPriceDenominatorCode;
    public long UnderlyingPrice;
    public int BidPrice;
    public int OfferPrice;
};

/// <summary>
///  Struct for Equity And Index Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityAndIndexLastSaleMessage {
    public TradeMessageType TradeMessageType;
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Reserved1[1];
    public fixed byte ExpirationBlock[0];
    public StrikePriceDenominatorCode StrikePriceDenominatorCode;
    public uint StrikePrice;
    public uint Volume;
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
    public int PremiumPrice;
    public uint TradeIdentifier;
    public fixed byte Reserved4[4];
};

/// <summary>
///  Struct for Expiration Block
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExpirationBlock {
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ParticipantId ParticipantId;
    public MessageCategory MessageCategory;
};

/// <summary>
///  Struct for Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenInterestMessage {
    public fixed sbyte MessageType[1];
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Reserved1[1];
    public fixed byte ExpirationBlock[0];
    public StrikePriceDenominatorCode StrikePriceDenominatorCode;
    public uint StrikePrice;
    public uint OpenInterestVolume;
};

/// <summary>
///  Struct for Underlying Value Bid And Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingValueBidAndOfferMessage {
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Reserved1[1];
    public IndexValueDenominatorCode IndexValueDenominatorCode;
    public int BidIndexValue;
    public long OfferIndexValue;
};

/// <summary>
///  Struct for Underlying Value Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingValueLastSaleMessage {
    public fixed sbyte MessageIndicator[1];
    public ulong TransactionId;
    public fixed sbyte SecuritySymbol[5];
    public fixed byte Reserved1[1];
    public IndexValueDenominatorCode IndexValueDenominatorCode;
    public int IndexValue;
    public fixed byte Reserved4[4];
};

/// <summary>
///  Struct for Underlying Value Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingValueMessage {
    public UnderlyingValueMessageType UnderlyingValueMessageType;
};

