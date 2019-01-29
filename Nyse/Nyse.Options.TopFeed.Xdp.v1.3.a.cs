// C# Structs For Nyse Options Xdp TopFeed 1.3.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    Opening = (byte)'O',
    Halt = (byte)'H',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    NotSpecified = (byte)' ',
    Customer = (byte)'0',
    Firm = (byte)'1',
    BrokerDealer = (byte)'2',
    MarketMaker = (byte)'3',
    ProfessionalCustomer = (byte)'8',
};

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
///  Imbalance Side Values
/// </summary>
public enum ImbalanceSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalance = (byte)' ',
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
///  Market Imbalance Side Values
/// </summary>
public enum MarketImbalanceSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalance = (byte)' ',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    OutrightQuoteMessage = "401",
    OutrightTradeMessage = "407",
    OutrightTradeCancelMessage = "409",
    OutrightTradeCorrectionMessage = "411",
    OutrightImbalanceMessage = "413",
    OutrightCrossingRfqMessage = "415",
    OutrightBoldRfqMessage = "471",
    OutrightSummaryMessage = "417",
    UnderlyingStatusMessage = "419",
    OutrightSeriesStatusMessage = "421",
    RefreshOutrightQuoteMessage = "501",
    RefreshOutrightTradeMessage = "507",
    RefreshOutrightImbalanceMessage = "509",
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
///  Struct for Outright Bold Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightBoldRfqMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public Side Side;
    public Capacity Capacity;
    public ushort Contracts;
    public int Price;
    public fixed sbyte Participant[4];
};

/// <summary>
///  Struct for Outright Crossing Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightCrossingRfqMessage {
    public uint SourceTime;
    public uint SourceNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public Side Side;
    public fixed byte Reserved1[1];
    public ushort Volume2;
    public int Price;
};

/// <summary>
///  Struct for Outright Imbalance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightImbalanceMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int ReferencePrice;
    public ushort PairedQty;
    public ushort TotalImbalanceQty;
    public ushort MarketImbalanceQty;
    public AuctionType AuctionType;
    public ImbalanceSide ImbalanceSide;
    public MarketImbalanceSide MarketImbalanceSide;
    public fixed byte Reserved3[3];
};

/// <summary>
///  Struct for Outright Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightQuoteMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
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
///  Struct for Outright Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightSummaryMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int HighPrice;
    public int LowPrice;
    public int Open;
    public int Close;
    public uint TotalVolume;
};

/// <summary>
///  Struct for Outright Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightTradeCancelMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public uint OriginalTradeId;
};

/// <summary>
///  Struct for Outright Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightTradeCorrectionMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public uint OriginalTradeId;
    public uint TradeId;
    public int Price;
    public uint Volume4;
    public TradeCond1 TradeCond1;
    public TradeCond2 TradeCond2;
    public fixed byte Reserved2[2];
};

/// <summary>
///  Struct for Outright Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightTradeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
    public int Price;
    public uint Volume4;
    public TradeCond1 TradeCond1;
    public TradeCond2 TradeCond2;
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
///  Struct for Refresh Outright Imbalance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshOutrightImbalanceMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
    public uint SymbolSeqNum;
    public int ReferencePrice;
    public ushort PairedQty;
    public ushort TotalImbalanceQty;
    public ushort MarketImbalanceQty;
    public AuctionType AuctionType;
    public ImbalanceSide ImbalanceSide;
    public MarketImbalanceSide MarketImbalanceSide;
    public fixed byte Reserved3[3];
};

/// <summary>
///  Struct for Refresh Outright Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshOutrightQuoteMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
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
///  Struct for Refresh Outright Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RefreshOutrightTradeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SeriesIndex;
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

