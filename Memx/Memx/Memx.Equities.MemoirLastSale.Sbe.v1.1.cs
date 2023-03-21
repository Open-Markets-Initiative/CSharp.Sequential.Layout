// C# Structs For Memx Equities Sbe MemoirLastSale 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Corrected Sale Condition 1 Values
/// </summary>
public enum CorrectedSaleCondition1 : byte {
    Regular = (byte)'@',
};

/// <summary>
///  Corrected Sale Condition 2 Values
/// </summary>
public enum CorrectedSaleCondition2 : byte {
    IntermarketSweep = (byte)'F',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Corrected Sale Condition 3 Values
/// </summary>
public enum CorrectedSaleCondition3 : byte {
    FormT = (byte)'T',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Corrected Sale Condition 4 Values
/// </summary>
public enum CorrectedSaleCondition4 : byte {
    PriceVariation = (byte)'H',
    OddLot = (byte)'I',
    Cross = (byte)'X',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Is Test Symbol Values
/// </summary>
public enum IsTestSymbol : byte {
    False = 0,
    True = 1,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    HeartbeatMessage = 0,
    SessionShutdownMessage = 1,
    SequencedMessage = 2,
};

/// <summary>
///  Original Sale Condition 1 Values
/// </summary>
public enum OriginalSaleCondition1 : byte {
    Regular = (byte)'@',
};

/// <summary>
///  Original Sale Condition 2 Values
/// </summary>
public enum OriginalSaleCondition2 : byte {
    IntermarketSweep = (byte)'F',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Original Sale Condition 3 Values
/// </summary>
public enum OriginalSaleCondition3 : byte {
    FormT = (byte)'T',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Original Sale Condition 4 Values
/// </summary>
public enum OriginalSaleCondition4 : byte {
    PriceVariation = (byte)'H',
    OddLot = (byte)'I',
    Cross = (byte)'X',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Sale Condition 1 Values
/// </summary>
public enum SaleCondition1 : byte {
    Regular = (byte)'@',
};

/// <summary>
///  Sale Condition 2 Values
/// </summary>
public enum SaleCondition2 : byte {
    IntermarketSweep = (byte)'F',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Sale Condition 3 Values
/// </summary>
public enum SaleCondition3 : byte {
    FormT = (byte)'T',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Sale Condition 4 Values
/// </summary>
public enum SaleCondition4 : byte {
    PriceVariation = (byte)'H',
    OddLot = (byte)'I',
    Cross = (byte)'X',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    Halted = (byte)'H',
    Paused = (byte)'P',
    Quoting = (byte)'Q',
    Trading = (byte)'T',
};

/// <summary>
///  Security Trading Status Reason Values
/// </summary>
public enum SecurityTradingStatusReason : byte {
    None = (byte)'X',
    Regulatory = (byte)'R',
    Administrative = (byte)'A',
};

/// <summary>
///  Short Sale Restriction Values
/// </summary>
public enum ShortSaleRestriction : byte {
    False = 0,
    True = 1,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : byte {
    InstrumentDirectoryMessage = 1,
    RegShoRestrictionMessage = 2,
    SecurityTradingStatusMessage = 3,
    TradingSessionStatusMessage = 5,
    TradeReportMessage = 10,
    TradeCancelMessage = 11,
    TradeCorrectMessage = 12,
};

/// <summary>
///  Trading Session Values
/// </summary>
public enum TradingSession : byte {
    Opening = (byte)'1',
    Trading = (byte)'2',
    PostTrading = (byte)'3',
    Closed = (byte)'4',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Common Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CommonHeader {
    public MessageType MessageType;
    public byte HeaderLength;
    public ulong SessionId;
    public ulong SequenceNumber;
};

/// <summary>
///  Struct for Instrument Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentDirectoryMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public fixed sbyte Symbol[6];
    public fixed sbyte SymbolSfx[6];
    public uint RoundLot;
    public IsTestSymbol IsTestSymbol;
    public long Mpv;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ushort MessageLength;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte CommonHeader[0];
};

/// <summary>
///  Struct for Reg Sho Restriction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoRestrictionMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ShortSaleRestriction ShortSaleRestriction;
};

/// <summary>
///  Struct for Sbe Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SbeHeader {
    public ushort BlockLength;
    public TemplateId TemplateId;
    public byte SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Sbe Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SbeMessage {
    public fixed byte SbeHeader[0];
};

/// <summary>
///  Struct for Security Trading Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityTradingStatusMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public SecurityTradingStatus SecurityTradingStatus;
    public SecurityTradingStatusReason SecurityTradingStatusReason;
};

/// <summary>
///  Struct for Sequenced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequencedMessage {
    public ushort MessageCount;
};

/// <summary>
///  Struct for Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint TradeQty;
    public long LastPrice;
    public SaleCondition1 SaleCondition1;
    public SaleCondition2 SaleCondition2;
    public SaleCondition3 SaleCondition3;
    public SaleCondition4 SaleCondition4;
};

/// <summary>
///  Struct for Trade Correct Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint OriginalTradeQty;
    public long OriginalTradePrice;
    public OriginalSaleCondition1 OriginalSaleCondition1;
    public OriginalSaleCondition2 OriginalSaleCondition2;
    public OriginalSaleCondition3 OriginalSaleCondition3;
    public OriginalSaleCondition4 OriginalSaleCondition4;
    public uint CorrectedTradeQty;
    public long CorrectedTradePrice;
    public CorrectedSaleCondition1 CorrectedSaleCondition1;
    public CorrectedSaleCondition2 CorrectedSaleCondition2;
    public CorrectedSaleCondition3 CorrectedSaleCondition3;
    public CorrectedSaleCondition4 CorrectedSaleCondition4;
};

/// <summary>
///  Struct for Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint TradeQty;
    public long TradePrice;
    public SaleCondition1 SaleCondition1;
    public SaleCondition2 SaleCondition2;
    public SaleCondition3 SaleCondition3;
    public SaleCondition4 SaleCondition4;
};

/// <summary>
///  Struct for Trading Session Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionStatusMessage {
    public ulong Timestamp;
    public TradingSession TradingSession;
};

