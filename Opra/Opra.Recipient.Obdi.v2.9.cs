// C# Structs For Opra Obdi Recipient 2.9 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

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
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    EquityAndIndexLastSaleMessage = (byte)'a',
    OpenInterestMessage = (byte)'d',
    EquityEodMessage = (byte)'f',
    LongQuoteAMessage = (byte)'k',
    LongQuoteBMessage = (byte)'k',
    LongQuoteCMessage = (byte)'k',
    LongQuoteDMessage = (byte)'k',
    LongQuoteEMessage = (byte)'k',
    LongQuoteFMessage = (byte)'k',
    LongQuoteGMessage = (byte)'k',
    LongQuoteHMessage = (byte)'k',
    LongQuoteIMessage = (byte)'k',
    LongQuoteJMessage = (byte)'k',
    LongQuoteKMessage = (byte)'k',
    LongQuoteLMessage = (byte)'k',
    LongQuoteMMessage = (byte)'k',
    LongQuoteNMessage = (byte)'k',
    LongQuoteOMessage = (byte)'k',
    LongQuotePMessage = (byte)'k',
    LongQuoteSpaceMessage = (byte)'k',
    ShortQuoteAMessage = (byte)'q',
    ShortQuoteBMessage = (byte)'q',
    ShortQuoteCMessage = (byte)'q',
    ShortQuoteDMessage = (byte)'q',
    ShortQuoteEMessage = (byte)'q',
    ShortQuoteFMessage = (byte)'q',
    ShortQuoteGMessage = (byte)'q',
    ShortQuoteHMessage = (byte)'q',
    ShortQuoteIMessage = (byte)'q',
    ShortQuoteJMessage = (byte)'q',
    ShortQuoteKMessage = (byte)'q',
    ShortQuoteLMessage = (byte)'q',
    ShortQuoteMMessage = (byte)'q',
    ShortQuoteNMessage = (byte)'q',
    ShortQuoteOMessage = (byte)'q',
    ShortQuotePMessage = (byte)'q',
    ShortQuoteSpaceMessage = (byte)'q',
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
    ChicagoBoardOptionsExchange = (byte)'C',
    MiaxEmerald = (byte)'D',
    EdgxOptions = (byte)'E',
    IseGemini = (byte)'H',
    InternationalSecuritiesExchange = (byte)'I',
    IseMercuryExchange = (byte)'J',
    MiamiInternationalSecuritiesExchange = (byte)'M',
    NyseArca = (byte)'N',
    OptionsPriceReportingAuthority = (byte)'O',
    MiaxPearl = (byte)'P',
    NasdaqStockMarket = (byte)'Q',
    NasdaqOmxBxOptions = (byte)'T',
    C2 = (byte)'W',
    NasdaqOmxPhlx = (byte)'X',
    Bats = (byte)'Z',
};

/// <summary>
///  Session Indicator Values
/// </summary>
public enum SessionIndicator : byte {
    Regular = "0",
    PreMarket = "88",
};

/// <summary>
///  Volume Values
/// </summary>
public enum Volume : uint {
    NyseAmerican = "A",
    Box = "B",
    Cboe = "C",
    Edgx = "E",
    Gemini = "H",
    Ise = "I",
    Mercury = "J",
    Miax = "M",
    NyseArca = "N",
    Opra = "O",
    MiaxPearl = "P",
    Nasdaq = "Q",
    C2 = "W",
    NasdaqBx = "T",
    NasdaqPhlx = "X",
    Bats = "Z",
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for ADMINISTRATIVE Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdministrativeCategory {
    public fixed byte AdministrativeMessageType[0];
    public fixed byte AdministrativeMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Administrative Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdministrativeMessage {
    public ushort MessageDataLength;
};

/// <summary>
///  Struct for CONTROL Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ControlCategory {
    public fixed byte ControlMessageType[0];
    public fixed byte ControlMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Control Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ControlMessage {
    public ushort MessageDataLength;
};

/// <summary>
///  Struct for Equity And Index Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityAndIndexLastSaleMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public Volume Volume;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int PremiumPrice;
    public uint TradeIdentifier;
    public fixed byte Reserved4[4];
};

/// <summary>
///  Struct for Equity EOD Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityEodCategory {
    public fixed byte EquityEodMessageType[0];
    public fixed byte EquityEodMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Equity Eod Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityEodMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public Volume Volume;
    public uint OpenInterestVolume;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int OpenPrice;
    public int HighPrice;
    public int LowPrice;
    public int LastPrice;
    public int NetChange;
    public fixed sbyte UnderlyingPriceDenominatorCode[1];
    public long UnderlyingPrice;
    public int BidPrice4;
    public int OfferPrice4;
};

/// <summary>
///  Struct for Equity Index Last Sale Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityIndexLastSaleCategory {
    public fixed byte EquityIndexLastSaleMessageType[0];
    public fixed byte EquityIndexLastSaleMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Long Quote A Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteAMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote B Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteBMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote C Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteCMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Long Quote Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteCategory {
    public fixed byte LongQuoteMessageType[0];
    public fixed byte LongQuoteMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Long Quote D Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteDMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote E Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteEMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote F Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteFMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote G Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteGMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Long Quote H Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteHMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote I Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteIMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote J Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteJMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote K Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteKMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Long Quote L Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteLMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote M Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteMMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public fixed byte BestBidPrice4[0];
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Long Quote N Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteNMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public int BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Long Quote O Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteOMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
};

/// <summary>
///  Struct for Long Quote P Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuotePMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public int BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Long Quote Space Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongQuoteSpaceMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public fixed sbyte PremiumPriceDenominatorCode[1];
    public int BidPrice4;
    public uint BidSize4;
    public int OfferPrice4;
    public uint OfferSize4;
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
    public ParticipantId ParticipantId;
    public MessageCategory MessageCategory;
};

/// <summary>
///  Struct for Open Interest Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenInterestCategory {
    public fixed byte OpenInterestMessageType[0];
    public fixed byte OpenInterestMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenInterestMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public fixed sbyte StrikePriceDenominatorCode[1];
    public uint StrikePrice4;
    public uint OpenInterestVolume;
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
    public byte Version;
    public ushort Size;
    public fixed sbyte DataFeedIndicator[1];
    public fixed sbyte RetransmissionIndicator[1];
    public SessionIndicator SessionIndicator;
    public uint BlockSeqNum;
    public byte MessageCount;
    public fixed byte BlockTimestamp[0];
    public ushort Checksum;
};

/// <summary>
///  Struct for Short Quote A Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteAMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote B Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteBMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote C Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteCMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Short Quote Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteCategory {
    public fixed byte ShortQuoteMessageType[0];
    public fixed byte ShortQuoteMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Short Quote D Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteDMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote E Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteEMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote F Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteFMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote G Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteGMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Short Quote H Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteHMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote I Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteIMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote J Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteJMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote K Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteKMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public ParticipantId ParticipantId;
    public fixed sbyte DenominatorCode[1];
    public uint Price;
    public ushort Size;
};

/// <summary>
///  Struct for Short Quote L Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteLMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote M Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteMMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public int BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Short Quote N Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteNMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public fixed byte BidPrice[0];
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public int BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Short Quote O Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteOMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for Short Quote P Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuotePMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
    public fixed sbyte BestBidParticipantId[1];
    public fixed sbyte BestBidDenominatorCode[1];
    public int BestBidPrice;
    public uint BestBidSize;
    public fixed sbyte BestOfferParticipantId[1];
    public fixed sbyte BestOfferDenominatorCode[1];
    public int BestOfferPrice;
    public uint BestOfferSize;
};

/// <summary>
///  Struct for Short Quote Space Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteSpaceMessage {
    public fixed sbyte SecuritySymbol4[4];
    public ExpirationMonth ExpirationMonth;
    public byte ExpirationDay;
    public byte ExpirationYear;
    public ushort StrikePrice2;
    public short BidPrice2;
    public ushort BidSize2;
    public short OfferPrice2;
    public ushort OfferSize2;
};

/// <summary>
///  Struct for UNDERLYING VALUE Category
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingValueCategory {
    public fixed byte UnderlyingValueMessageType[0];
    public fixed byte UnderlyingValueMessageIndicator[0];
    public ulong TransactionId;
};

/// <summary>
///  Struct for Underlying Value Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingValueMessage {
    public fixed sbyte SecuritySymbol5[5];
    public fixed byte Reserved1[1];
    public fixed sbyte IndexValueDenominatorCode[1];
    public int IndexValue;
    public fixed byte Reserved4[4];
};

