// C# Structs For Cboe Options C1 Pitch AuctionFeed 1.1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    AuctionInstructionMechanism = (byte)'B',
    SolicitationAuctionMechanism = (byte)'S',
    StepUpMechanism = (byte)'T',
    AllOrNone = (byte)'A',
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
    AuctionUpdateMessage = "0xD1",
    AuctionSummaryMessage = "0x96",
    WidthUpdateMessage = "0xD2",
    SymbolMappingMessage = "0x2E",
    EndOfSessionMessage = "0x2D",
};

/// <summary>
///  Opening Type Values
/// </summary>
public enum OpeningType : byte {
    GthOpening = (byte)'G',
    RthOpening = (byte)'O',
    HaltReopening = (byte)'H',
    VolatilityOpening = (byte)'V',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Symbol Condition Values
/// </summary>
public enum SymbolCondition : byte {
    Normal = (byte)'N',
    ClosingOnly = (byte)'C',
};

/// <summary>
///  Width Type Values
/// </summary>
public enum WidthType : byte {
    Regular = (byte)'R',
    Volatility = (byte)'V',
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
    public fixed sbyte Symbol6[6];
    public ulong AuctionId;
    public AuctionType AuctionType;
    public Side Side;
    public ulong Price;
    public uint Contracts;
    public CustomerIndicator CustomerIndicator;
    public fixed sbyte ParticipantId[4];
    public uint AuctionEndOffset;
    public fixed sbyte ClientId[4];
};

/// <summary>
///  Struct for Auction Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionSummaryMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol8[8];
    public OpeningType OpeningType;
    public ulong Price;
    public uint Quantity;
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
///  Struct for Auction Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionUpdateMessage {
    public uint TimeOffset;
    public fixed sbyte Symbol8[8];
    public OpeningType OpeningType;
    public ulong ReferencePrice;
    public uint BuyContracts;
    public uint SellContracts;
    public ulong IndicativePrice;
    public ulong AuctionOnlyPrice;
    public fixed sbyte OpeningCondition[1];
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
    public SymbolCondition SymbolCondition;
    public fixed sbyte Underlying[8];
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

/// <summary>
///  Struct for Width Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WidthUpdateMessage {
    public uint TimeOffset;
    public fixed sbyte Underlying[8];
    public WidthType WidthType;
    public uint Multiplier;
};

