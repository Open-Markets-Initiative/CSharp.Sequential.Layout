// C# Structs For Nyse Equities Xdp ImbalancesFeed 2.2.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Status Values
/// </summary>
public enum AuctionStatus : byte {
    WillRunOpenClose = 0,
    WillRunInterest = 1,
    WillNotRunImbalance = 2,
    WillNotRunTransitionToClosing = 3,
};

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    EarlyOpening = (byte)'O',
    CoreOpening = (byte)'M',
    Reopening = (byte)'H',
    Closing = (byte)'C',
    RegulatoryImbalance = (byte)'R',
};

/// <summary>
///  Delivery Flag Values
/// </summary>
public enum DeliveryFlag : byte {
    Heartbeat = 1,
    XdpFailover = 10,
    OriginalMessage = 11,
    SequenceNumberResetMessage = 12,
    OneRetransmissionPacket = 13,
    RetransmissionSequenceMessage = 15,
    OneRefreshPacket = 17,
    RefreshSequenceStart = 18,
    RefreshSequenceMessage = 19,
    RefreshSequenceEnd = 20,
    MessageUnavailable = 21,
};

/// <summary>
///  Freeze Status Values
/// </summary>
public enum FreezeStatus : byte {
    NoImbalanceFreeze = 0,
    ImbalanceFreeze = 1,
};

/// <summary>
///  Imbalance Side Values
/// </summary>
public enum ImbalanceSide : byte {
    NoImbalance = (byte)' ',
    BuySide = (byte)'B',
    SellSide = (byte)'S',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    SequenceNumberResetMessage = 1,
    SymbolIndexMappingMessage = 3,
    RetransmissionRequestMessage = 10,
    RequestResponseMessage = 11,
    HeartbeatResponseMessage = 12,
    SymbolIndexMappingRequestMessage = 13,
    RefreshRequestMessage = 15,
    MessageUnavailableMessage = 31,
    SymbolClearMessage = 32,
    SecurityStatusMessage = 34,
    RefreshHeaderMessage = 35,
    ImbalanceMessage = 105,
};

/// <summary>
///  Significant Imbalance Values
/// </summary>
public enum SignificantImbalance : byte {
    NotApplicable = (byte)' ',
    Yes = (byte)'Y',
};

/// <summary>
///  Unpaired Side Values
/// </summary>
public enum UnpairedSide : byte {
    NotApplicable = (byte)' ',
    BuySide = (byte)'B',
    SellSide = (byte)'S',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Heartbeat Response Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HeartbeatResponseMessage {
    public fixed sbyte SourceId[10];
};

/// <summary>
///  Struct for Imbalance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImbalanceMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint ReferencePrice;
    public uint PairedQty;
    public uint TotalImbalanceQty;
    public uint MarketImbalanceQty;
    public ushort AuctionTime;
    public AuctionType AuctionType;
    public ImbalanceSide ImbalanceSide;
    public uint ContinuousBookClearingPrice;
    public uint ClosingOnlyClearingPrice;
    public uint SsrFilingPrice;
    public uint IndicativeMatchPrice;
    public uint UpperCollar;
    public uint LowerCollar;
    public AuctionStatus AuctionStatus;
    public FreezeStatus FreezeStatus;
    public byte NumExtensions;
    public uint UnpairedQty;
    public UnpairedSide UnpairedSide;
    public SignificantImbalance SignificantImbalance;
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
    public ushort MessageSize;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Message Unavailable Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageUnavailableMessage {
    public uint BeginSeqNum;
    public uint EndSeqNum;
    public byte ProductId;
    public byte ChannelId;
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
    public ushort PacketSize;
    public DeliveryFlag DeliveryFlag;
    public byte MessageCount;
    public uint SequenceNumber;
    public uint Timestamp;
    public uint Nanoseconds;
};

/// <summary>
///  Struct for Refresh Header Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshHeaderMessage {
    public ushort CurrentRefreshPkt;
    public ushort TotalRefreshPkts;
    public uint LastSeqNum;
    public uint LastSymbolSeqNum;
};

/// <summary>
///  Struct for Refresh Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshRequestMessage {
    public uint SymbolIndex;
    public fixed sbyte SourceId[10];
    public byte ProductId;
    public byte ChannelId;
};

/// <summary>
///  Struct for Request Response Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestResponseMessage {
    public uint RequestSeqNum;
    public uint BeginSeqNum;
    public uint EndSeqNum;
    public fixed sbyte SourceId[10];
    public byte ProductId;
    public byte ChannelId;
    public fixed sbyte Status[1];
};

/// <summary>
///  Struct for Retransmission Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmissionRequestMessage {
    public uint BeginSeqNum;
    public uint EndSeqNum;
    public fixed sbyte SourceId[10];
    public byte ProductId;
    public byte ChannelId;
};

/// <summary>
///  Struct for Security Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public fixed sbyte SecurityStatus[1];
    public fixed sbyte HaltCondition[1];
    public fixed byte Reserved4[4];
    public uint Price1;
    public uint Price2;
    public fixed sbyte SsrTriggeringExchangeId[1];
    public uint SsrTriggeringVolume;
    public uint Time;
    public fixed sbyte SsrState[1];
    public fixed sbyte MarketState[1];
    public fixed sbyte SessionState[1];
};

/// <summary>
///  Struct for Sequence Number Reset Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequenceNumberResetMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public byte ProductId;
    public byte ChannelId;
};

/// <summary>
///  Struct for Symbol Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolClearMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint NextSourceSeqNum;
};

/// <summary>
///  Struct for Symbol Index Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolIndexMappingMessage {
    public uint SymbolIndex;
    public fixed sbyte Symbol[11];
    public fixed byte Reserved1[1];
    public ushort MarketId;
    public byte SystemId;
    public fixed sbyte ExchangeCode[1];
    public byte PriceScaleCode;
    public fixed sbyte SecurityType[1];
    public ushort LotSize;
    public uint PrevClosePrice;
    public uint PrevCloseVolume;
    public byte PriceResolution;
    public fixed sbyte RoundLot[1];
    public ushort Mpv;
    public ushort UnitOfTrade;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Symbol Index Mapping Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolIndexMappingRequestMessage {
    public uint SymbolIndex;
    public fixed sbyte SourceId[10];
    public byte ProductId;
    public byte ChannelId;
    public byte RetransmitMethod;
};

