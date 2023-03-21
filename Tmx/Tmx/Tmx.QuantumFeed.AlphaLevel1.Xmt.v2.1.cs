// C# Structs For Tmx QuantumFeed Xmt AlphaLevel1 2.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Ack Required Poss Dup Values
/// </summary>
public enum AckRequiredPossDup : byte {
    ReceiverNeedsToAck = (byte)'A',
    PossibleDuplicates = (byte)'D',
};

/// <summary>
///  Bypass Values
/// </summary>
public enum Bypass : byte {
    TheOrderIsABypass = (byte)'Y',
    TheOrderIsNotABypass = (byte)'N',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    Internal = (byte)'I',
    Basis = (byte)'B',
    Contingent = (byte)'C',
    DerivativeRelated = (byte)'D',
    Regular = (byte)'R',
    VolumeWeightedAveragePrice = (byte)'V',
    DefaultTradeWasNotACross = (byte)' ',
};

/// <summary>
///  Currency Values
/// </summary>
public enum Currency : byte {
    Usd = (byte)'U',
    Cad = (byte)'C',
};

/// <summary>
///  Listing Market Values
/// </summary>
public enum ListingMarket : byte {
    Tsx = (byte)'T',
    Tsxv = (byte)'V',
};

/// <summary>
///  Msg Type Values
/// </summary>
public enum MsgType : byte {
    SymbolStatusMessage = (byte)'J',
    TradeMessage = (byte)'s',
    TradeCancelledMessage = (byte)'t',
    StockStatusMessage = (byte)'v',
    EquityQuoteMessage = (byte)'w',
};

/// <summary>
///  Opening Trade Values
/// </summary>
public enum OpeningTrade : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Product Type Values
/// </summary>
public enum ProductType : byte {
    Debenture = (byte)'B',
    Equity = (byte)'E',
    MutualFund = (byte)'M',
    Etf = (byte)'F',
};

/// <summary>
///  Settlement Terms Values
/// </summary>
public enum SettlementTerms : byte {
    Cash = (byte)'C',
    Nn = (byte)'N',
    MsDerivativesrelatedContingentEquityTrade = (byte)'M',
    CtCashToday = (byte)'T',
    IfThereIsAValidSettlementDateAssociatedWithTheOrder = (byte)'D',
    NoSettlementTerms = (byte)' ',
};

/// <summary>
///  Test Symbol Values
/// </summary>
public enum TestSymbol : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Body {
    public fixed byte BodyHeader[0];
};

/// <summary>
///  Struct for Body Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BodyHeader {
    public ushort MsgLength;
    public MsgType MsgType;
};

/// <summary>
///  Struct for Business Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BusinessHeader {
    public byte MsgVersion;
    public fixed sbyte SourceId[1];
    public ushort StreamId;
    public byte Sequence0;
    public uint Sequence1;
};

/// <summary>
///  Struct for Equity Quote Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityQuoteBody {
    public fixed sbyte Symbol[12];
    public ulong BidPrice;
    public uint BidSize;
    public ulong AskPrice;
    public uint AskSize;
};

/// <summary>
///  Struct for Equity Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquityQuoteMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte EquityQuoteBody[0];
};

/// <summary>
///  Struct for Frame Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FrameHeader {
    public fixed byte StartOfFrame;
    public fixed sbyte ProtocolName[1];
    public fixed sbyte ProtocolVersion[1];
    public ushort MessageLength;
    public uint SessionId;
    public AckRequiredPossDup AckRequiredPossDup;
    public byte NumBody;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte FrameHeader[0];
};

/// <summary>
///  Struct for Stock Status Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockStatusBody {
    public fixed sbyte Symbol[12];
    public fixed sbyte Comment[40];
    public fixed sbyte StockState[2];
    public ulong TradingSystemTimeStamp;
    public uint ResumeTradeTime;
};

/// <summary>
///  Struct for Stock Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockStatusMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte StockStatusBody[0];
};

/// <summary>
///  Struct for Symbol Status Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolStatusBody {
    public fixed sbyte Symbol[12];
    public byte StockGroup;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
    public fixed sbyte Cusip[12];
    public ushort BoardLot;
    public Currency Currency;
    public ulong FaceValue;
    public ulong LastSale;
    public uint MinPoQty;
    public fixed sbyte StockState[2];
    public TestSymbol TestSymbol;
};

/// <summary>
///  Struct for Symbol Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolStatusMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte SymbolStatusBody[0];
};

/// <summary>
///  Struct for Trade Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBody {
    public fixed sbyte Symbol[12];
    public ulong Price;
    public uint Volume;
    public ushort BuyBrokerNumber;
    public ushort SellBrokerNumber;
    public Bypass Bypass;
    public uint TradeTimeStamp;
    public SettlementTerms SettlementTerms;
    public CrossType CrossType;
    public ulong LastSale;
    public OpeningTrade OpeningTrade;
    public fixed sbyte IsDark[1];
    public uint TradeNumber;
};

/// <summary>
///  Struct for Trade Cancelled Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledBody {
    public fixed sbyte Symbol[12];
    public uint Volume;
    public ulong Price;
    public ushort BuyBrokerNumber;
    public ushort SellBrokerNumber;
    public uint TradeTimeStamp;
    public ulong LastSale;
    public uint TradeNumber;
};

/// <summary>
///  Struct for Trade Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeCancelledBody[0];
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeBody[0];
};

