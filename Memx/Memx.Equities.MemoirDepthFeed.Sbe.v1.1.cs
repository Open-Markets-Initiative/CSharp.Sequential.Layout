// C# Structs For Memx Equities Sbe MemoirDepthFeed 1.1 protocol

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
    OrderAddedMessage = 10,
    OrderDeletedMessage = 11,
    OrderReducedMessage = 12,
    OrderExecutedMessage = 13,
    TradeMessage = 14,
    BrokenTradeMessage = 15,
    CorrectedTradeMessage = 16,
    ClearBookMessage = 18,
    SnapshotCompleteMessage = 100,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Broken Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint OriginalQuantity;
    public long OriginalPrice;
};

/// <summary>
///  Struct for Clear Book Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearBookMessage {
    public ulong Timestamp;
    public ushort SecurityId;
};

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
///  Struct for Corrected Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CorrectedTradeMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint OriginalQuantity;
    public long OriginalPrice;
    public uint CorrectedQuantity;
    public long CorrectedPrice;
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
    public byte Reserved;
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
///  Struct for Order Added Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAddedMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong OrderId;
    public fixed sbyte Side[1];
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Order Deleted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeletedMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong OrderId;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong OrderId;
    public ulong TradeId;
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Order Reduced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReducedMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong OrderId;
    public uint Quantity;
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
///  Struct for Snapshot Complete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotCompleteMessage {
    public ulong Timestamp;
    public ulong AsOfSequenceNumber;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public ulong TradeId;
    public uint Quantity;
    public long Price;
};

/// <summary>
///  Struct for Trading Session Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionStatusMessage {
    public ulong Timestamp;
    public fixed sbyte TradingSession[1];
};

