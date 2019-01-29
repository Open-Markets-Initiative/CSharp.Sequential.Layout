// C# Structs For Cboe Options Edgx Pitch AuctionFeed 1.1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    BatsAuctionMechanism = (byte)'B',
    StepUpMechanism = (byte)'T',
};

/// <summary>
///  Customer Indicator Values
/// </summary>
public enum CustomerIndicator : byte {
    NonCustomer = (byte)'N',
    Customer = (byte)'C',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = "0x20",
    UnitClearMessage = "0x97",
    AuctionNotificationMessage = "0xAD",
    AuctionCancelMessage = "0xAE",
    AuctionTradeMessage = "0xAF",
    SymbolMappingMessage = "0x2E",
    EndOfSessionMessage = "0x2D",
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Auction Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionCancelMessage {
    public uint TimeOffset;
    public ulong AuctionId;
};

/// <summary>
///  Struct for Auction Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionNotificationMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol[6];
    public ulong AuctionId;
    public AuctionType AuctionType;
    public Side Side;
    public ulong Price;
    public uint Contracts;
    public CustomerIndicator CustomerIndicator;
    public fixed sbyte ParticipantId[4];
    public uint AuctionEndOffset;
};

/// <summary>
///  Struct for Auction Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionTradeMessage {
    public uint TimeOffset;
    public ulong AuctionId;
    public ulong ExecutionId;
    public ulong Price;
    public uint Contracts;
};

/// <summary>
///  Struct for End Of Session Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSessionMessage {
    public uint Timestamp;
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
    public byte MessageLength;
    public MessageType MessageType;
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
    public ushort Length;
    public byte Count;
    public byte Unit;
    public uint Sequence;
};

/// <summary>
///  Struct for Symbol Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolMappingMessage {
    public fixed sbyte FeedSymbol[6];
    public fixed sbyte OsiSymbol[21];
    public fixed sbyte SymbolCondition[1];
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Time;
};

/// <summary>
///  Struct for Unit Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitClearMessage {
    public uint TimeOffset;
};

