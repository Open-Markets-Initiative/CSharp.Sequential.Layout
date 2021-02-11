// C# Structs For Otc Markets Ats Multicast 4.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Asset Class Values
/// </summary>
public enum AssetClass : byte {
    Equity = 1,
    FixedIncome = 2,
};

/// <summary>
///  Disclosure Status Values
/// </summary>
public enum DisclosureStatus : byte {
    NoDisclosureStatus = 0,
    CurrentInformation = 2,
    LimitedInformation = 3,
    NoInformation = 4,
};

/// <summary>
///  Reference Price Action Values
/// </summary>
public enum ReferencePriceAction : byte {
    Add = 2,
    Delete = 3,
    Spin = 4,
};

/// <summary>
///  Reporting Status Values
/// </summary>
public enum ReportingStatus : byte {
    AlternativeReportingStandard = (byte)'A',
    BankThrift = (byte)'B',
    SecReporting = (byte)'F',
    InternationalReporting = (byte)'G',
    InsuranceCompany = (byte)'I',
    NoReporting = (byte)'N',
    OtherReportingStandard = (byte)'O',
    FinraReporting = (byte)'R',
    SecReportingInvestmentCompany = (byte)'V',
    SecReportingRegA = (byte)'W',
};

/// <summary>
///  Security Action Values
/// </summary>
public enum SecurityAction : byte {
    Update = 1,
    Add = 2,
    Delete = 3,
    Spin = 4,
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    Active = (byte)'A',
    QuoteOnly = (byte)'Q',
    Suspended = (byte)'S',
    Halted = (byte)'H',
    InternalHalt = (byte)'I',
    Revoked = (byte)'R',
    Deleted = (byte)'D',
};

/// <summary>
///  Spin Type Values
/// </summary>
public enum SpinType : byte {
    Reference = 1,
    MarketData = 2,
    Opening = 3,
};

/// <summary>
///  Tier Values
/// </summary>
public enum Tier : byte {
    NoTier = 0,
    OtcqxUsPremier = 1,
    OtcqxUs = 2,
    OtcqxInternationalPremier = 5,
    OtcqxInternational = 6,
    Otcqb = 10,
    OtcbbOnly = 11,
    PinkCurrent = 20,
    PinkLimited = 21,
    PinkNoInformation = 22,
    GreyMarket = 30,
    ExpertMarket = 40,
    OtcBonds = 50,
};

/// <summary>
///  Trade Action Values
/// </summary>
public enum TradeAction : byte {
    Add = 2,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for End Of Spin Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSpinMessage {
    public uint ChannelSeqNum;
    public SpinType SpinType;
    public uint SpinMsgCt;
    public ulong SpinEndTimeMilli;
    public uint SpinLastSeqNum;
};

/// <summary>
///  Struct for Extended Quote Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExtendedQuoteFlags {
    public fixed byte ReservedExtendedQuoteFlagBits[4];
    public fixed byte NmsConditionalQuote[1];
    public fixed byte OfferAutoEx[1];
    public fixed byte BidAutoEx[1];
    public fixed byte QuoteSaturated[1];
};

/// <summary>
///  Struct for Inside Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InsideUpdateMessage {
    public uint ChannelSeqNum;
    public uint InsideId;
    public fixed byte QuoteFlags[0];
    public ulong Price;
    public uint Size;
    public ulong InsideTimeMilli;
    public byte NumPricedMp;
};

/// <summary>
///  Struct for Market Close Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketCloseMessage {
    public uint ChannelSeqNum;
    public ulong MarketCloseTimeMilli;
    public uint MarketMsgCt;
};

/// <summary>
///  Struct for Market Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketOpenMessage {
    public uint ChannelSeqNum;
    public ulong MarketOpen;
    public ulong MarketClose;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort MessageSize;
    public byte MessageType;
};

/// <summary>
///  Struct for Packet Flag
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketFlag {
    public fixed byte Test[1];
    public fixed byte Replay[1];
    public fixed byte ReservedPacketFlags[4];
    public fixed byte SeqNumReset[1];
    public fixed byte Heartbeat[1];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public ushort PacketSize;
    public uint SeqNum;
    public fixed byte PacketFlag[0];
    public byte Messages;
    public uint PacketMilli;
};

/// <summary>
///  Struct for Quote Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteFlags {
    public fixed byte BidAskWanted[1];
    public fixed byte BidPriced[1];
    public fixed byte BidUnsolicited[1];
    public fixed byte AskBidWanted[1];
    public fixed byte AskPriced[1];
    public fixed byte AskUnsolicited[1];
    public fixed byte State[1];
    public fixed byte UpdateSide[1];
};

/// <summary>
///  Struct for Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteMessage {
    public uint ChannelSeqNum;
    public uint QuoteId;
    public byte QuoteAction;
    public fixed byte QuoteFlags[0];
    public uint SecurityId;
    public fixed sbyte Mpid[4];
    public ulong AskPrice;
    public uint AskSize;
    public sbyte AskQap;
    public ulong AskTimeMilli;
    public ulong BidPrice;
    public uint BidSize;
    public sbyte BidQap;
    public ulong BidTimeMilli;
    public ushort QuoteReferenceId;
    public fixed byte ExtendedQuoteFlags[0];
};

/// <summary>
///  Struct for Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateMessage {
    public uint ChannelSeqNum;
    public uint QuoteId;
    public fixed byte QuoteFlags[0];
    public ulong Price;
    public uint Size;
    public sbyte Qap;
    public ulong QuoteTimeMilli;
    public ushort QuoteReferenceId;
    public fixed byte ExtendedQuoteFlags[0];
};

/// <summary>
///  Struct for Reference Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReferencePriceMessage {
    public uint ChannelSeqNum;
    public uint ReferencePriceId;
    public ReferencePriceAction ReferencePriceAction;
    public fixed byte QuoteFlags[0];
    public uint SecurityId;
    public ulong AskPrice;
    public uint AskSize;
    public ulong AskTimeMilli;
    public ulong BidPrice;
    public uint BidSize;
    public ulong BidTimeMilli;
};

/// <summary>
///  Struct for Reference Price Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReferencePriceUpdateMessage {
    public uint ChannelSeqNum;
    public uint ReferencePriceId;
    public fixed byte QuoteFlags[0];
    public ulong Price;
    public uint Size;
    public ulong TimeMilli;
};

/// <summary>
///  Struct for Security Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityFlags {
    public fixed byte SaturationEligible[1];
    public fixed byte OtcLinkMessagingDisabled[1];
    public fixed byte OtcLinkEcnEligible[1];
    public fixed byte BbQuoted[1];
    public fixed byte UnsolicitedOnly[1];
    public fixed byte QualifiedInstitutionalBuyersOnly[1];
    public fixed byte CaveatEmptorWarning[1];
    public fixed byte Piggyback[1];
};

/// <summary>
///  Struct for Security Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityMessage {
    public uint ChannelSeqNum;
    public fixed sbyte Symbol[10];
    public ulong LastUpdateMilli;
    public SecurityAction SecurityAction;
    public AssetClass AssetClass;
    public uint SecurityId;
    public fixed byte SecurityFlags[0];
    public Tier Tier;
    public ReportingStatus ReportingStatus;
    public SecurityStatus SecurityStatus;
};

/// <summary>
///  Struct for Start Of Spin Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfSpinMessage {
    public uint ChannelSeqNum;
    public SpinType SpinType;
    public ulong SpinStartTimeMilli;
    public uint SpinLastSeqNum;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint ChannelSeqNum;
    public uint TradeId;
    public TradeAction TradeAction;
    public byte TradeFlags;
    public uint SecurityId;
    public fixed byte TradeStatus[0];
    public fixed sbyte Deprecated[8];
    public ulong TradePrice;
    public uint TradeSize;
    public ulong TradeTimeMilli;
};

/// <summary>
///  Struct for Trade Status
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeStatus {
    public fixed byte ReservedTradeStatusBits[7];
    public fixed byte Irregular[1];
};

