// C# Structs For Cboe Options Csm OpeningAuction 1.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Eop Type Values
/// </summary>
public enum EopType : byte {
    Undefined = 0,
    OpeningPrice = 1,
    NeedMoreSellers = 2,
    NeedMoreBuyers = 3,
    NoOpeningTrades = 4,
    MultipleOpeningPrices = 5,
    NeedQuoteToOpen = 6,
    PriceNotInQuoteRange = 7,
    NeedDpmQuoteToOpen = 8,
    DpmQuoteInvalid = 9,
    PriceNotInBotrRange = 10,
};

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
///  Legal Market Values
/// </summary>
public enum LegalMarket : byte {
    NotALegalMarket = 0,
    LegalMarket = 1,
};

/// <summary>
///  Md Entry Type Values
/// </summary>
public enum MdEntryType : byte {
    Bid = (byte)'0',
    Ask = (byte)'1',
    Trade = (byte)'2',
    IndexValue = (byte)'3',
    OpeningPrice = (byte)'4',
    SettlementValue = (byte)'6',
    High = (byte)'7',
    Low = (byte)'8',
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
///  Security Exchange Values
/// </summary>
public enum SecurityExchange : byte {
    Cboe = (byte)'C',
    OneChicagoNotSupported = (byte)'O',
    CbsxNotSupported = (byte)'W',
    Cfecof = (byte)'F',
    Cboe2Options = (byte)'2',
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
    MarketDataRefreshMessage = 20,
    CurrentMarketUpdateMessage = 12,
    ExpectedOpeningPriceAndSizeMessage = 15,
    HeartbeatMessage = 16,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Currency Code
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CurrencyCode {
    public byte CurrencyCodeLength;
};

/// <summary>
///  Struct for Current Market Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CurrentMarketUpdateMessage {
    public uint ClassKey;
    public uint SecurityId;
    public SecurityTradingStatus SecurityTradingStatus;
    public byte PriceType;
    public byte NoEntries;
};

/// <summary>
///  Struct for Eop
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Eop {
    public sbyte EopExponent;
    public int EopMantissa;
};

/// <summary>
///  Struct for Expected Opening Price And Size Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExpectedOpeningPriceAndSizeMessage {
    public uint ClassKey;
    public uint SecurityId;
    public fixed byte Eop[0];
    public uint Eos;
    public EopType EopType;
    public LegalMarket LegalMarket;
};

/// <summary>
///  Struct for Market Data Refresh Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketDataRefreshMessage {
    public uint ClassKey;
    public uint SecurityId;
    public SecurityTradingStatus SecurityTradingStatus;
    public byte PriceType;
    public uint ApplSeqNum;
    public fixed byte PrevClosePx[0];
    public uint TradeVolume;
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
///  Struct for Md Entry
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdEntry {
    public MdEntryType MdEntryType;
    public fixed byte MdEntryPx[0];
    public uint MdEntrySize;
    public MdVolumeType MdVolumeType;
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
///  Struct for Prev Close Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PrevClosePx {
    public sbyte PrevClosePxExponent;
    public int PrevClosePxMantissa;
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
///  Struct for Security Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityType {
    public byte SecurityTypeLength;
};

/// <summary>
///  Struct for Strike Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrikePrice {
    public sbyte StrikePriceExponent;
    public int StrikePriceMantissa;
};

/// <summary>
///  Struct for Symbol
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Symbol {
    public byte SymbolLength;
};

/// <summary>
///  Struct for Target Location Id
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TargetLocationId {
    public byte TargetLocationIdLength;
};

/// <summary>
///  Struct for Underlying Symbol
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingSymbol {
    public byte UnderlyingSymbolLength;
};

/// <summary>
///  Struct for Underlying Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingType {
    public byte UnderlyingTypeLength;
};

