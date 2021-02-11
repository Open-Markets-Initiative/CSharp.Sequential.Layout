// C# Structs For Memx Equities Sbe MemoirLastSale 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    HeartbeatMessage = 0,
    SessionShutdownMessage = 1,
    SequencedMessage = 2,
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
    public byte IsTestSymbol;
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
    public byte ShortSaleRestriction;
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
    public fixed sbyte SecurityTradingStatus[1];
    public fixed sbyte SecurityTradingStatusReason[1];
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
    public fixed sbyte SaleCondition1[1];
    public fixed sbyte SaleCondition2[1];
    public fixed sbyte SaleCondition3[1];
    public fixed sbyte SaleCondition4[1];
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
    public fixed sbyte OriginalSaleCondition1[1];
    public fixed sbyte OriginalSaleCondition2[1];
    public fixed sbyte OriginalSaleCondition3[1];
    public fixed sbyte OriginalSaleCondition4[1];
    public uint CorrectedTradeQty;
    public long CorrectedTradePrice;
    public fixed sbyte CorrectedSaleCondition1[1];
    public fixed sbyte CorrectedSaleCondition2[1];
    public fixed sbyte CorrectedSaleCondition3[1];
    public fixed sbyte CorrectedSaleCondition4[1];
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
    public fixed sbyte SaleCondition1[1];
    public fixed sbyte SaleCondition2[1];
    public fixed sbyte SaleCondition3[1];
    public fixed sbyte SaleCondition4[1];
};

/// <summary>
///  Struct for Trading Session Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionStatusMessage {
    public ulong Timestamp;
    public fixed sbyte TradingSession[1];
};

