// C# Structs For Memx Equities Sbe MemoirTopOfBook 1.1 protocol

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
    SnapshotCompleteMessage = 4,
    TradingSessionStatusMessage = 5,
    BestBidOfferMessage = 10,
    BestBidMessage = 11,
    BestOfferMessage = 12,
    BestBidShortMessage = 13,
    BestOfferShortMessage = 14,
    ClearBookMessage = 15,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Best Bid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public uint BidSize;
    public long BidPrice;
};

/// <summary>
///  Struct for Best Bid Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidOfferMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public uint BidSize;
    public long BidPrice;
    public uint OfferSize;
    public long OfferPrice;
};

/// <summary>
///  Struct for Best Bid Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestBidShortMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public uint BidSize;
    public long BidPrice;
};

/// <summary>
///  Struct for Best Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestOfferMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public uint OfferSize;
    public long OfferPrice;
};

/// <summary>
///  Struct for Best Offer Short Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BestOfferShortMessage {
    public ulong Timestamp;
    public ushort SecurityId;
    public uint OfferSize;
    public long OfferPrice;
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
///  Struct for Snapshot Complete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotCompleteMessage {
    public ulong Timestamp;
    public ulong AsOfSequenceNumber;
};

/// <summary>
///  Struct for Trading Session Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionStatusMessage {
    public ulong Timestamp;
    public fixed sbyte TradingSession[1];
};

