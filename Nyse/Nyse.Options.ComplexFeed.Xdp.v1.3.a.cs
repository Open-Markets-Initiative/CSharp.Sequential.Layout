// C# Structs For Nyse Options Xdp ComplexFeed 1.3.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

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
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    OptionsSeriesLeg = (byte)'O',
    EquityStockLeg = (byte)'E',
};

/// <summary>
///  Market Id Values
/// </summary>
public enum MarketId : ushort {
    NyseCash = 1,
    EuropeCash = 2,
    NyseArcaCash = 3,
    NyseArcaOptions = 4,
    NyseArcaBonds = 5,
    ArcaEdge = 6,
    Liffe = 7,
    NyseAmericanOptions = 8,
    NyseMktCash = 9,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    ComplexQuoteMessage = 423,
    ComplexTradeMessage = 425,
    ComplexCrossingRfqMessage = 429,
    ComplexCubeRfqMessage = 472,
    ComplexStatusMessage = 433,
    RefreshComplexQuoteMessage = 511,
    RefreshComplexTradeMessage = 513,
    ComplexSymbolDefinitionMessage = 439,
    StreamIdMessage = 455,
    SequenceNumberResetMessage = 1,
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    RegularTrading = (byte)'1',
    Rotation = (byte)'2',
    TradingHalted = (byte)'3',
    Preopen = (byte)'4',
    RotationLegalWidthQuotePending = (byte)'5',
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    LightUpADarkSeries = (byte)'L',
    OpenADarkSeries = (byte)'N',
    Open = (byte)'O',
    Close = (byte)'X',
    Halt = (byte)'S',
    Unhalt = (byte)'U',
    UnhaltADarkSeries = (byte)'T',
    EndOfRfqAuction = (byte)'Q',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Trade Cond 1 Values
/// </summary>
public enum TradeCond1 : byte {
    RegularTrade = (byte)' ',
    LateReport = (byte)'I',
    FloorTrade = (byte)'R',
    SoSweepTrade = (byte)'S',
};

/// <summary>
///  Trade Cond 2 Values
/// </summary>
public enum TradeCond2 : byte {
    ComplexTradeWithEquity = (byte)'P',
    ComplexTrade = (byte)'L',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Complex Crossing Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexCrossingRfqMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public Side Side;
    public fixed byte Reserved1[1];
    public ushort Volume2;
    public int Price;
};

/// <summary>
///  Struct for Complex Cube Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexCubeRfqMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public Side Side;
    public fixed byte Reserved1[1];
    public ushort Volume2;
    public int Price;
};

/// <summary>
///  Struct for Complex Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexQuoteMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public int AskPrice;
    public int BidPrice;
    public ushort AskVolume;
    public ushort BidVolume;
    public ushort AskCustomerVolume;
    public ushort BidCustomerVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Complex Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexStatusMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public SecurityStatus SecurityStatus;
    public fixed sbyte HaltCondition[1];
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Complex Symbol Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexSymbolDefinitionMessage {
    public uint ComplexIndex;
    public fixed sbyte ComplexSymbol[21];
    public byte ChannelId;
    public MarketId MarketId;
    public byte SystemId;
    public fixed byte Reserved1[1];
    public ushort StreamId;
    public ushort NoOfLegs;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Complex Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexTradeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
    public int Price;
    public uint Volume4;
    public TradeCond1 TradeCond1;
    public TradeCond2 TradeCond2;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegDefinition {
    public uint SymbolIndex;
    public ushort LegRatioQty;
    public Side Side;
    public LegSecurityType LegSecurityType;
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
///  Struct for Refresh Complex Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshComplexQuoteMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public int AskPrice;
    public int BidPrice;
    public ushort AskVolume;
    public ushort BidVolume;
    public ushort AskCustomerVolume;
    public ushort BidCustomerVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Refresh Complex Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshComplexTradeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint ComplexIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
    public int Price;
    public uint Volume4;
    public TradeCond1 TradeCond1;
    public TradeCond2 TradeCond2;
    public fixed byte Reserved2[2];
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
///  Struct for Stream Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamIdMessage {
    public ushort StreamId;
    public fixed byte Reserved2[2];
};

