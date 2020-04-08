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
    public fixed byte ControlMessageType[0];
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
    public fixed byte TradeMessageType[0];
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

