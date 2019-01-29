// C# Structs For Nyse Equities Xdp Bbo 2.4.g protocol

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
    NyseAmerican = (byte)'A',
    NyseNational = (byte)'C',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    Iex = (byte)'V',
    Bats = (byte)'Z',
    GlobalOtc = (byte)'B',
    Otcbb = (byte)'U',
    OtherOtc = (byte)'V',
};

/// <summary>
///  Halt Condition Values
/// </summary>
public enum HaltCondition : byte {
    SecurityNotDelayedhalted = (byte)'~',
    NotDelayedhaltedNyseTapeAOnly = (byte)' ',
    NewsDissemination = (byte)'D',
    OrderImbalance = (byte)'I',
    NewsPending = (byte)'P',
    LuldPause = (byte)'M',
    RelatedSecurityNotUsed = (byte)'S',
    EquipmentChangeover = (byte)'X',
    NoOpenNoResume = (byte)'Z',
    MarketWideCircuitBreakerHaltLevel1 = (byte)'1',
    MarketWideCircuitBreakerHaltLevel2 = (byte)'2',
    MarketWideCircuitBreakerHaltLevel3 = (byte)'3',
};

/// <summary>
///  Market Id Values
/// </summary>
public enum MarketId : ushort {
    NyseEquities = "1",
    NyseArcaEquities = "3",
    NyseArcaOptions = "4",
    NyseBonds = "5",
    GlobalOtc = "6",
    NyseAmexOptions = "8",
    NyseAmericanEquities = "9",
    NyseNationalOptions = "10",
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    SequenceNumberResetMessage = "1",
    SourceTimeReferenceMessage = "2",
    SymbolIndexMappingMessage = "3",
    RetransmissionRequestMessage = "10",
    RequestResponseMessage = "11",
    HeartbeatResponseMessage = "12",
    SymbolIndexMappingRequestMessage = "13",
    RefreshRequestMessage = "15",
    MessageUnavailableMessage = "31",
    SymbolClearMessage = "32",
    TradingSessionChangeMessage = "33",
    SecurityStatusMessage = "34",
    RefreshHeaderMessage = "35",
    QuoteMessage = "140",
};

/// <summary>
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    Closing = (byte)'C',
    OpeningQuote = (byte)'O',
    RegularQuote = (byte)'R',
    SlowOnTheBidAndAsk = (byte)'W',
};

/// <summary>
///  Retransmit Method Values
/// </summary>
public enum RetransmitMethod : byte {
    Udp = "0",
};

/// <summary>
///  Rpi Indicator Values
/// </summary>
public enum RpiIndicator : byte {
    NoRetailInterest = (byte)' ',
    RetailInterestOnBidSide = (byte)'A',
    RetailInterestOnOfferSide = (byte)'B',
    RetailInterestOnTheBidAndOfferSide = (byte)'C',
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    OpeningDelay = (byte)'3',
    TradingHalt = (byte)'4',
    Resume = (byte)'5',
    NoOpennoResume = (byte)'6',
    ShortSaleRestrictionActivatedDay1 = (byte)'A',
    ShortSaleRestrictionContinuedDay2 = (byte)'C',
    ShortSaleRestrictionDeactivated = (byte)'D',
    Preopening = (byte)'P',
    EarlySession = (byte)'E',
    CoreSession = (byte)'O',
    LateSessionNonNyseOnly = (byte)'L',
    Closed = (byte)'X',
    Time = (byte)'T',
    PriceIndication = (byte)'I',
    PreOpeningPriceIndication = (byte)'G',
    Rule15Indication = (byte)'R',
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
    UsDepositaryShares = (byte)'H',
    Units = (byte)'I',
    IndexLinkedNotes = (byte)'L',
    MiscliquidTrust = (byte)'M',
    OrdinaryShares = (byte)'O',
    PreferredStock = (byte)'P',
    Rights = (byte)'R',
    SharesOfBeneficiaryInterest = (byte)'S',
    Test = (byte)'T',
    Units = (byte)'U',
    Warrant = (byte)'W',
};

/// <summary>
///  Ssr Triggering Exchange Id Values
/// </summary>
public enum SsrTriggeringExchangeId : byte {
    NyseAmerican = (byte)'A',
    NasdaqOmxBx = (byte)'B',
    NyseNational = (byte)'C',
    Finra = (byte)'D',
    Ise = (byte)'I',
    Edga = (byte)'J',
    Edgx = (byte)'K',
    Chx = (byte)'M',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    Cts = (byte)'S',
    NasdaqOmx = (byte)'T',
    Iex = (byte)'V',
    Cbsx = (byte)'W',
    NasdaqOmxPsx = (byte)'X',
    BatsY = (byte)'Y',
    Bats = (byte)'Z',
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
///  Struct for Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint AskPrice;
    public uint AskVolume;
    public uint BidPrice;
    public uint BidVolume;
    public QuoteCondition QuoteCondition;
    public RpiIndicator RpiIndicator;
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
    public SecurityStatus SecurityStatus;
    public HaltCondition HaltCondition;
    public fixed byte Reserved4[4];
    public uint Price1;
    public uint Price2;
    public SsrTriggeringExchangeId SsrTriggeringExchangeId;
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
///  Struct for Source Time Reference Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SourceTimeReferenceMessage {
    public uint Id;
    public uint SymbolSeqNum;
    public uint SourceTime;
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
    public MarketId MarketId;
    public byte SystemId;
    public ExchangeCode ExchangeCode;
    public byte PriceScaleCode;
    public SecurityType SecurityType;
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
    public RetransmitMethod RetransmitMethod;
};

/// <summary>
///  Struct for Trading Session Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSessionChangeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public byte TradingSession;
};

