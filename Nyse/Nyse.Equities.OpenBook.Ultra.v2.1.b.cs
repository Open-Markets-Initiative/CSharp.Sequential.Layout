// C# Structs For Nyse Ultra OpenBook 2.1.b protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    FullUpdateMessage = 230,
    DeltaUpdateMessage = 231,
    SequenceNumberResetMessage = 1,
    HeartbeatMessage = 2,
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    NoSpecialQuoteCondition = (byte)' ',
    SlowQuote = (byte)'W',
};

/// <summary>
///  Reason Code Values
/// </summary>
public enum ReasonCode : byte {
    NewOrderadditionalInterestAdded = (byte)'O',
    Cancel = (byte)'C',
    Execution = (byte)'E',
    MultipleEvents = (byte)'X',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    PreOpening = (byte)'P',
    CoreSession = (byte)'O',
    Closed = (byte)'X',
    Halted = (byte)'H',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Delta Price Point
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeltaPricePoint {
    public int PriceNumerator;
    public int Volume;
    public int ChgQty;
    public short NumOrders;
    public Side Side;
    public ReasonCode ReasonCode;
    public int LinkId1;
    public int LinkId2;
    public int LinkId3;
};

/// <summary>
///  Struct for Delta Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeltaUpdateMessage {
    public short DeltaSize;
    public int SymbolIndex;
    public int SourceTime;
    public short SourceTimeMicroSecs;
    public int SourceSeqNum;
    public sbyte SourceSessionId;
    public QuoteCondition QuoteCondition;
    public TradingStatus TradingStatus;
    public sbyte PriceScaleCode;
};

/// <summary>
///  Struct for Delta Update Messages
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeltaUpdateMessages {
};

/// <summary>
///  Struct for Full Price Point
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullPricePoint {
    public int PriceNumerator;
    public int Volume;
    public short NumOrders;
    public Side Side;
    public fixed byte Reserved1[1];
};

/// <summary>
///  Struct for Full Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullUpdateMessage {
    public short UpdateSize;
    public int SymbolIndex;
    public int SourceTime;
    public short SourceTimeMicroSecs;
    public int SymbolSeqNum;
    public sbyte SourceSessionId;
    public fixed sbyte Symbol[11];
    public sbyte PriceScaleCode;
    public QuoteCondition QuoteCondition;
    public TradingStatus TradingStatus;
    public fixed byte Reserved1[1];
    public short Mpv;
};

/// <summary>
///  Struct for Full Update Messages
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullUpdateMessages {
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public ushort PacketSize;
    public MessageType MessageType;
    public uint SequenceNumber;
    public uint Timestamp;
    public byte ProductId;
    public byte RetransmissionFlag;
    public byte MessageCount;
    public byte LinkFlag;
};

/// <summary>
///  Struct for Sequence Number Reset Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequenceNumberResetMessage {
    public int NextSequenceNumber;
};

