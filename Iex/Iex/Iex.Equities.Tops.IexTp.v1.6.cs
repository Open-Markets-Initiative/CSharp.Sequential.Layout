// C# Structs For Iex Equities IexTp Tops 1.6 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    OpeningAuction = (byte)'O',
    ClosingAuction = (byte)'C',
    IpoAuction = (byte)'I',
    HaltAuction = (byte)'H',
    VolatilityAuction = (byte)'V',
};

/// <summary>
///  Detail Values
/// </summary>
public enum Detail : byte {
    NoPriceTestInPlace = (byte)' ',
    ShortSalePriceTestRestrictionInEffectDueToAnIntradayPriceDropInTheSecurity = (byte)'A',
    ShortSalePriceTestRestrictionRemainsInEffectFromPriorDay = (byte)'C',
    ShortSalePriceTestRestrictionDeactivated = (byte)'D',
    DetailNotAvailable = (byte)'N',
};

/// <summary>
///  Imbalance Side Values
/// </summary>
public enum ImbalanceSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    None = (byte)'N',
};

/// <summary>
///  Luld Tier Values
/// </summary>
public enum LuldTier : byte {
    NotApplicable = 0,
    Tier1NmsStock = 1,
    Tier2NmsStock = 2,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    SecurityDirectoryMessage = (byte)'D',
    TradingStatusMessage = (byte)'H',
    OperationalHaltStatusMessage = (byte)'O',
    ShortSalePriceTestStatusMessage = (byte)'P',
    SecurityEventMessage = (byte)'E',
    QuoteUpdateMessage = (byte)'Q',
    TradeReportMessage = (byte)'T',
    OfficialPriceMessage = (byte)'X',
    TradeBreakMessage = (byte)'B',
    AuctionInformationMessage = (byte)'A',
};

/// <summary>
///  Operational Halt Status Values
/// </summary>
public enum OperationalHaltStatus : byte {
    IexSpecificOperationalTradingHalt = (byte)'O',
    NotOperationallyHaltedOnIex = (byte)'N',
};

/// <summary>
///  Price Type Values
/// </summary>
public enum PriceType : byte {
    IexOfficialOpeningPrice = (byte)'Q',
    IexOfficialClosingPrice = (byte)'M',
};

/// <summary>
///  Security Event Values
/// </summary>
public enum SecurityEvent : byte {
    OpeningProcessComplete = (byte)'O',
    ClosingProcessComplete = (byte)'C',
};

/// <summary>
///  Short Sale Price Test Status Values
/// </summary>
public enum ShortSalePriceTestStatus : byte {
    NotInEffect = 0,
    InEffect = 1,
};

/// <summary>
///  System Event Values
/// </summary>
public enum SystemEvent : byte {
    StartOfSystemHours = (byte)'S',
    StartOfRegularMarketHours = (byte)'R',
    EndOfRegularMarketHours = (byte)'M',
    EndOfSystemHours = (byte)'E',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    TradingHaltedAcrossAllUsEquityMarkets = (byte)'H',
    TradingPausedAndOrderAcceptancePeriodOnIex = (byte)'P',
    TradingOnIex = (byte)'T',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Auction Information Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionInformationMessage {
    public AuctionType AuctionType;
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public uint PairedShares;
    public long ReferencePrice;
    public long IndicativeClearingPrice;
    public uint ImbalanceShares;
    public ImbalanceSide ImbalanceSide;
    public fixed sbyte ExtensionNumber[1];
    public uint ScheduledAuctionTime;
    public long AuctionBookClearingPrice;
    public long CollarReferencePrice;
    public long LowerAuctionCollar;
    public long UpperAuctionCollar;
};

/// <summary>
///  Struct for Iex Tp Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IexTpHeader {
    public byte Version;
    public fixed byte Reserved[1];
    public ushort MessageProtocolId;
    public uint ChannelId;
    public uint SessionId;
    public ushort PayloadLength;
    public ushort MessageCount;
    public ulong StreamOffset;
    public ulong FirstMessageSequenceNumber;
    public ulong SendTime;
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
    public MessageType MessageType;
};

/// <summary>
///  Struct for Official Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OfficialPriceMessage {
    public PriceType PriceType;
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public long OfficialPrice;
};

/// <summary>
///  Struct for Operational Halt Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OperationalHaltStatusMessage {
    public OperationalHaltStatus OperationalHaltStatus;
    public long Timestamp;
    public fixed sbyte Symbol[8];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte IexTpHeader[0];
};

/// <summary>
///  Struct for Quote Update Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateFlags {
    public fixed byte SymbolAvailability[1];
    public fixed byte MarketSession[1];
    public fixed byte Unused6[6];
};

/// <summary>
///  Struct for Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateMessage {
    public fixed byte QuoteUpdateFlags[0];
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public uint BidSize;
    public long BidPrice;
    public long AskPrice;
    public uint AskSize;
};

/// <summary>
///  Struct for Sale Condition Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SaleConditionFlags {
    public fixed byte IntermarketSweep[1];
    public fixed byte ExtendedHours[1];
    public fixed byte OddLot[1];
    public fixed byte TradeThroughExempt[1];
    public fixed byte SinglepriceCrossTrade[1];
    public fixed byte Unused3[3];
};

/// <summary>
///  Struct for Security Directory Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDirectoryFlags {
    public fixed byte Etp[1];
    public fixed byte WhenIssued[1];
    public fixed byte TestSecurity[1];
    public fixed byte Unused5[5];
};

/// <summary>
///  Struct for Security Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDirectoryMessage {
    public fixed byte SecurityDirectoryFlags[0];
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public uint RoundLotSize;
    public long AdjustedPocPrice;
    public LuldTier LuldTier;
};

/// <summary>
///  Struct for Security Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityEventMessage {
    public SecurityEvent SecurityEvent;
    public long Timestamp;
    public fixed sbyte Symbol[8];
};

/// <summary>
///  Struct for Short Sale Price Test Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortSalePriceTestStatusMessage {
    public ShortSalePriceTestStatus ShortSalePriceTestStatus;
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public Detail Detail;
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public SystemEvent SystemEvent;
    public long Timestamp;
};

/// <summary>
///  Struct for Trade Break Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBreakMessage {
    public fixed sbyte SaleConditionFlags[1];
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public uint Size;
    public long Price;
    public ulong TradeId;
};

/// <summary>
///  Struct for Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessage {
    public fixed sbyte SaleConditionFlags[1];
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public uint Size;
    public long Price;
    public ulong TradeId;
};

/// <summary>
///  Struct for Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingStatusMessage {
    public TradingStatus TradingStatus;
    public long Timestamp;
    public fixed sbyte Symbol[8];
    public fixed sbyte Reason[4];
};

