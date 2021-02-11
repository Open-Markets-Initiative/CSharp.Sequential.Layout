// C# Structs For Cboe Options Csm MarketLevel2 1.0.4 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Exercise Style Values
/// </summary>
public enum ExerciseStyle : byte {
    American = 0,
    European = 1,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    BuyBid = (byte)'B',
    SellAsk = (byte)'S',
};

/// <summary>
///  Md Entry Type Values
/// </summary>
public enum MdEntryType : byte {
    BuyBid = (byte)'0',
    SellAsk = (byte)'1',
};

/// <summary>
///  Md Update Action Values
/// </summary>
public enum MdUpdateAction : byte {
    Insert = 0,
    Change = 1,
    Delete = 2,
    Overlay = 5,
};

/// <summary>
///  Md Volume Type Values
/// </summary>
public enum MdVolumeType : byte {
    TotalLimit = 0,
    CustomerLimit = 1,
    TotalContingencyAllOrNone = 2,
    CustomerContingencyAllOrNone = 3,
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = 0,
    Call = 1,
};

/// <summary>
///  Refresh Indicator Values
/// </summary>
public enum RefreshIndicator : byte {
    MandatoryRefresh = (byte)'Y',
    ProcessIfNecessary = (byte)'N',
};

/// <summary>
///  Security Exchange Values
/// </summary>
public enum SecurityExchange : byte {
    Cboe = (byte)'C',
    OneChicagoNotSupported = (byte)'O',
    CbsxNotSupported = (byte)'W',
    CfecofNotSupported = (byte)'F',
    Cboe2OptionsNotSupported = (byte)'2',
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    Halted = 2,
    Open = 17,
    Closed = 18,
    PreOpen = 21,
    OpeningRotation = 22,
    FastMarket = 23,
    StrategyMarketInOpeningRotation = 24,
    StrategyMarketQuotesNonFirm = 25,
    Suspended = 26,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : byte {
    SecurityDefinitionMessage = 13,
    SnapshotFullRefreshMessage = 17,
    IncrementalRefreshMessage = 18,
    SecurityStatusMessage = 19,
    HeartbeatMessage = 16,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Incremental Refresh Md Entry
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IncrementalRefreshMdEntry {
    public MdUpdateAction MdUpdateAction;
    public MdEntryType MdEntryType;
    public byte MdPriceLevel;
    public fixed byte MdEntryPx[0];
    public byte NoLegs;
};

/// <summary>
///  Struct for Incremental Refresh Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IncrementalRefreshMessage {
    public uint ClassKey;
    public uint SecurityId;
    public uint RptSeq;
    public SecurityTradingStatus SecurityTradingStatus;
    public byte PriceType;
    public byte NoEntries;
};

/// <summary>
///  Struct for Max Strike Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MaxStrikePrice {
    public sbyte MaxStrikePriceExponent;
    public int MaxStrikePriceMantissa;
};

/// <summary>
///  Struct for Md Entry Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdEntryPx {
    public sbyte MdEntryPxExponent;
    public int MdEntryPxMantissa;
};

/// <summary>
///  Struct for Md Volume Entry
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdVolumeEntry {
    public MdVolumeType MdVolumeType;
    public uint MdEntrySize;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort MessageLength;
    public TemplateId TemplateId;
    public fixed sbyte MessageType[1];
    public uint MsgSeqNum;
};

/// <summary>
///  Struct for Minimum Above Premium Fraction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MinimumAbovePremiumFraction {
    public sbyte MinimumAbovePremiumFractionExponent;
    public int MinimumAbovePremiumFractionMantissa;
};

/// <summary>
///  Struct for Minimum Below Premium Fraction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MinimumBelowPremiumFraction {
    public sbyte MinimumBelowPremiumFractionExponent;
    public int MinimumBelowPremiumFractionMantissa;
};

/// <summary>
///  Struct for Minimum Strike Price Fraction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MinimumStrikePriceFraction {
    public sbyte MinimumStrikePriceFractionExponent;
    public int MinimumStrikePriceFractionMantissa;
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public byte Version;
    public ushort PacketLength;
    public ulong SendingTime;
    public byte MessageCount;
    public uint FirstMsgSeqNum;
};

/// <summary>
///  Struct for Premium Break Point
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PremiumBreakPoint {
    public sbyte PremiumBreakPointExponent;
    public int PremiumBreakPointMantissa;
};

/// <summary>
///  Struct for Security Definition Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionLeg {
    public uint LegRatioQty;
    public uint LegSecurityId;
    public LegSide LegSide;
};

/// <summary>
///  Struct for Security Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusMessage {
    public uint ClassKey;
    public uint SecurityId;
    public uint RptSeq;
    public SecurityTradingStatus SecurityTradingStatus;
};

/// <summary>
///  Struct for Snapshot Full Refresh Md Entry
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshMdEntry {
    public MdEntryType MdEntryType;
    public byte MdPriceLevel;
    public fixed byte MdEntryPx[0];
    public byte NoLegs;
};

/// <summary>
///  Struct for Snapshot Full Refresh Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshMessage {
    public uint ClassKey;
    public uint SecurityId;
    public uint RptSeq;
    public SecurityTradingStatus SecurityTradingStatus;
    public byte PriceType;
    public RefreshIndicator RefreshIndicator;
    public byte NoEntries;
};

/// <summary>
///  Struct for Strike Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrikePrice {
    public sbyte StrikePriceExponent;
    public int StrikePriceMantissa;
};

