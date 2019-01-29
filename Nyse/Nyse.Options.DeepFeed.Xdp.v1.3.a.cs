// C# Structs For Nyse Options Xdp DeepFeed 1.3.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Delivery Flag Values
/// </summary>
public enum DeliveryFlag : byte {
    Heartbeat = "1",
    XdpFailover = "10",
    OriginalMessage = "11",
    SequenceNumberResetMessage = "12",
    OneRetransmissionPacket = "13",
    RetransmissionSequenceMessage = "15",
    OneRefreshPacket = "17",
    RefreshSequenceStart = "18",
    RefreshSequenceMessage = "19",
    RefreshSequenceEnd = "20",
    MessageUnavailable = "21",
};

/// <summary>
///  Exchange Code Values
/// </summary>
public enum ExchangeCode : byte {
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    NyseMkt = (byte)'A',
    GlobalOtc = (byte)'1',
    ArcaLocalNontapebIndex = (byte)'2',
};

/// <summary>
///  Market Id Values
/// </summary>
public enum MarketId : ushort {
    NyseCash = "1",
    EuropeCash = "2",
    NyseArcaCash = "3",
    NyseArcaOptions = "4",
    NyseArcaBonds = "5",
    ArcaEdge = "6",
    Liffe = "7",
    NyseAmericanOptions = "8",
    NyseMktCash = "9",
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    OutrightMarketDepthBuyMessage = "403",
    OutrightMarketDepthSellMessage = "405",
    UnderlyingStatusMessage = "419",
    OutrightSeriesStatusMessage = "421",
    RefreshOutrightMarketDepthBuyMessage = "503",
    RefreshOutrightMarketDepthSellMessage = "505",
    UnderlyingIndexMappingMessage = "435",
    SeriesIndexMappingMessage = "437",
    StreamIdMessage = "455",
    SequenceNumberResetMessage = "1",
};

/// <summary>
///  Price Resolution Values
/// </summary>
public enum PriceResolution : byte {
    AllPenny = "0",
    PennyNickel = "1",
    NickelDime = "5",
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = "0",
    Call = "1",
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
///  Security Type Values
/// </summary>
public enum SecurityType : byte {
    Adr = (byte)'A',
    CommonStock = (byte)'C',
    Debentures = (byte)'D',
    Etf = (byte)'E',
    Foreign = (byte)'F',
    AmericanDepositoryShares = (byte)'H',
    Units = (byte)'I',
    MiscliquidTrust = (byte)'M',
    OrdinaryShares = (byte)'O',
    PreferredStock = (byte)'P',
    Rights = (byte)'R',
    SharesOfBeneficiaryInterest = (byte)'S',
    Test = (byte)'T',
    Units = (byte)'U',
    Warrant = (byte)'W',
    Index = (byte)'X',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

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
///  Struct for Outright Market Depth Buy Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightMarketDepthBuyMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int FirstLevelPrice;
    public int SecondLevelPrice;
    public int ThirdLevelPrice;
    public ushort FirstLevelVolume;
    public ushort SecondLevelVolume;
    public ushort ThirdLevelVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public ushort FirstLevelCustomerVolume;
    public ushort SecondLevelCustomerVolume;
    public ushort ThirdLevelCustomerVolume;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Outright Market Depth Sell Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightMarketDepthSellMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int FirstLevelPrice;
    public int SecondLevelPrice;
    public int ThirdLevelPrice;
    public ushort FirstVolume;
    public ushort SecondVolume;
    public ushort ThirdVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public ushort FirstLevelCustomerVolume;
    public ushort SecondLevelCustomerVolume;
    public ushort ThirdLevelCustomerVolume;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Outright Series Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightSeriesStatusMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public SecurityStatus SecurityStatus;
    public fixed sbyte HaltCondition[1];
    public fixed byte Reserved2[2];
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
///  Struct for Refresh Outright Market Depth Buy Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshOutrightMarketDepthBuyMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int FirstLevelPrice;
    public int SecondLevelPrice;
    public int ThirdLevelPrice;
    public ushort FirstVolume;
    public ushort SecondVolume;
    public ushort ThirdVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public ushort FirstLevelCustomerVolume;
    public ushort SecondLevelCustomerVolume;
    public ushort ThirdLevelCustomerVolume;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Refresh Outright Market Depth Sell Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshOutrightMarketDepthSellMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int FirstLevelPrice;
    public int SecondLevelPrice;
    public int ThirdLevelPrice;
    public ushort FirstVolume;
    public ushort SecondVolume;
    public ushort ThirdVolume;
    public QuoteCondition QuoteCondition;
    public fixed byte Reserved1[1];
    public ushort FirstLevelCustomerVolume;
    public ushort SecondLevelCustomerVolume;
    public ushort ThirdLevelCustomerVolume;
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
///  Struct for Series Index Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SeriesIndexMappingMessage {
    public uint SeriesIndex;
    public byte ChannelId;
    public fixed byte ReservedA1[1];
    public MarketId MarketId;
    public byte SystemId;
    public fixed byte ReservedB1[1];
    public ushort StreamId;
    public uint UnderlyingIndex;
    public ushort ContractMultiplier;
    public fixed sbyte MaturityDate[6];
    public PutOrCall PutOrCall;
    public fixed sbyte StrikePrice[10];
    public byte PriceScaleCode;
    public fixed sbyte UnderlyingSymbol[11];
    public fixed sbyte OptionSymbolRoot[5];
    public uint GroupId;
};

/// <summary>
///  Struct for Stream Id Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StreamIdMessage {
    public ushort StreamId;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Underlying Index Mapping Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingIndexMappingMessage {
    public uint UnderlyingIndex;
    public fixed sbyte UnderlyingSymbol[11];
    public byte ChannelId;
    public MarketId MarketId;
    public byte SystemId;
    public ExchangeCode ExchangeCode;
    public byte PriceScaleCode;
    public SecurityType SecurityType;
    public PriceResolution PriceResolution;
    public fixed byte Reserved1[1];
};

/// <summary>
///  Struct for Underlying Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingStatusMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint UnderlyingIndex;
    public uint UnderlyingSeqNum;
    public SecurityStatus SecurityStatus;
    public fixed sbyte HaltCondition[1];
    public fixed byte Reserved2[2];
};

