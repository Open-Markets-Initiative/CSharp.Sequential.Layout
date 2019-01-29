// C# Structs For Nyse Equities Xdp Bqt 2.1.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Ask Quote Condition Values
/// </summary>
public enum AskQuoteCondition : byte {
    Closing = (byte)'C',
    OpeningQuote = (byte)'O',
    RegularQuote = (byte)'R',
    SlowOnTheBidAndAsk = (byte)'W',
};

/// <summary>
///  Bid Quote Condition Values
/// </summary>
public enum BidQuoteCondition : byte {
    Closing = (byte)'C',
    OpeningQuote = (byte)'O',
    RegularQuote = (byte)'R',
    SlowOnTheBidAndAsk = (byte)'W',
};

/// <summary>
///  Complete Values
/// </summary>
public enum Complete : byte {
    Normal = "0",
    Abnormal = "1",
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
    NyseAmerican = (byte)'A',
    GlobalOtc = (byte)'B',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    Otcbb = (byte)'U',
    OtherOtc = (byte)'V',
    Bats = (byte)'Z',
};

/// <summary>
///  Halt Condition Values
/// </summary>
public enum HaltCondition : byte {
    SecurityNotDelayedhalted = (byte)'~',
    NotApplicable = (byte)' ',
    NewsDissemination = (byte)'D',
    OrderImbalance = (byte)'I',
    NewsPending = (byte)'P',
    VolatilityTradingPause = (byte)'M',
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
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseArcaOptions = "4",
    NyseBonds = "5",
    GlobalOtc = "6",
    NyseAmexOptions = "8",
    NyseAmerican = "9",
    NyseNational = "10",
};

/// <summary>
///  Market Id Of Best Ask Values
/// </summary>
public enum MarketIdOfBestAsk : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market Id Of Best Bid Values
/// </summary>
public enum MarketIdOfBestBid : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market Id Of High Price Values
/// </summary>
public enum MarketIdOfHighPrice : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market Id Of Low Price Values
/// </summary>
public enum MarketIdOfLowPrice : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market Id Of Open Price Values
/// </summary>
public enum MarketIdOfOpenPrice : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market ID of the Close Values
/// </summary>
public enum MarketIdOfTheClose : ushort {
    NyseGroupBqt = "0",
    Nyse = "1",
    NyseArca = "3",
    NyseAmerican = "9",
};

/// <summary>
///  Market State Values
/// </summary>
public enum MarketState : byte {
    Preopening = (byte)'P',
    EarlySession = (byte)'E',
    CoreSession = (byte)'O',
    LateSession = (byte)'L',
    Closed = (byte)'X',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    SequenceNumberResetMessage = "1",
    SymbolIndexMappingMessage = "3",
    RetransmissionRequestMessage = "10",
    RequestResponseMessage = "11",
    HeartbeatResponseMessage = "12",
    SymbolIndexMappingRequestMessage = "13",
    RefreshRequestMessage = "15",
    MessageUnavailableMessage = "31",
    ConsolidatedSymbolClearMessage = "32",
    ConsolidatedTradingSessionChangeMessage = "33",
    ConsolidatedSecurityStatusMessage = "34",
    RefreshHeaderMessage = "35",
    BqtMessage = "142",
    ConsolidatedSingleSidedQuoteMessage = "143",
    ConsolidatedTradeMessage = "220",
    ConsolidatedTradeCancelMessage = "221",
    ConsolidatedTradeCorrectionMessage = "222",
    ConsolidatedStockSummaryMessage = "229",
    ConsolidatedVolumeMessage = "240",
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
///  Quote Condition Values
/// </summary>
public enum QuoteCondition : byte {
    Closing = (byte)'C',
    OpeningQuote = (byte)'O',
    RegularQuote = (byte)'R',
    SlowOnTheBidAndAsk = (byte)'W',
    EmptyQuote = (byte)'OxOO',
};

/// <summary>
///  Reason Values
/// </summary>
public enum Reason : byte {
    NewTrade = "0",
    TradeCancellation = "1",
    TradeError = "2",
    TradeCorrection = "3",
    ClosingEndTradeSummary = "4",
};

/// <summary>
///  Retail Pricing Indicator Values
/// </summary>
public enum RetailPricingIndicator : byte {
    NoRetailInterest = "0x00",
    RetailInterestOnTheBidSide = "0x01",
    RetailInterestOnTheAskSide = "0x02",
    CombinationOfRetailInterestOnBidAndAskSide = "0x04",
};

/// <summary>
///  Retransmit Method Values
/// </summary>
public enum RetransmitMethod : byte {
    Udp = "0",
};

/// <summary>
///  Round Lot Values
/// </summary>
public enum RoundLot : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Rpi Indicator Values
/// </summary>
public enum RpiIndicator : byte {
    NoRetailInterest = (byte)' ',
    InterestOnBid = (byte)'A',
    InterestOnOffer = (byte)'B',
    InterestOnBidAndOffer = (byte)'C',
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
///  Session State Values
/// </summary>
public enum SessionState : byte {
    EarlySessionState = (byte)'X',
    CoreSessionState = (byte)'Y',
    LateSessionState = (byte)'Z',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Ssr State Values
/// </summary>
public enum SsrState : byte {
    NoShortSaleRestrictionInEffect = (byte)'~',
    ShortSaleRestrictionInEffect = (byte)'E',
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

/// <summary>
///  Status Values
/// </summary>
public enum Status : byte {
    MessageWasAccepted = (byte)'0',
    RejectedDueToAnInvalidSourceId = (byte)'1',
    InvalidSequenceRange = (byte)'2',
    MaximumSequenceRange = (byte)'3',
    MaximumRequestInADay = (byte)'4',
    MaximumRefreshRequestsInADay = (byte)'5',
    OldSeqNumTtl = (byte)'6',
    InvalidChannelId = (byte)'7',
    InvalidProductId = (byte)'8',
    InvalidMsgTypeOrMismatchBetweenMsgTypeAndMsgSize = (byte)'9',
};

/// <summary>
///  Trade Condition 1 Values
/// </summary>
public enum TradeCondition1 : byte {
    RegularSale = (byte)'@',
    Cash = (byte)'C',
    NextDayTrade = (byte)'N',
    Seller = (byte)'R',
};

/// <summary>
///  Trade Condition 2 Values
/// </summary>
public enum TradeCondition2 : byte {
    Na = (byte)' ',
    IntermarketSweepOrder = (byte)'F',
    MarketCenterOpeningTrade = (byte)'O',
    DerivativelyPriced = (byte)'4',
    MarketCenterReopeningTrade = (byte)'5',
    MarketCenterClosingTrade = (byte)'6',
    CorrectedLastSalePrice = (byte)'9',
};

/// <summary>
///  Trade Condition 3 Values
/// </summary>
public enum TradeCondition3 : byte {
    Na = (byte)' ',
    SoldLast = (byte)'L',
    ExtendedHoursTrade = (byte)'T',
    ExtendedHoursSoldOutOfSequence = (byte)'U',
    Sold = (byte)'Z',
};

/// <summary>
///  Trade Condition 4 Values
/// </summary>
public enum TradeCondition4 : byte {
    Na = (byte)' ',
    RegularSale = (byte)'@',
    AveragePriceTrade = (byte)'B',
    AutomaticExecution = (byte)'E',
    PriceVariationTrade = (byte)'H',
    OddLotTrade = (byte)'I',
    Rule127NyseOnlyOrRule155NyseAmericanOnly = (byte)'K',
    OfficialClosingPrice = (byte)'M',
    PriorReferencePrice = (byte)'P',
    OfficialOpenPrice = (byte)'Q',
    StockOptionTrade = (byte)'V',
    CrossTrade = (byte)'X',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Bqt Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BqtMessage {
    public uint SymbolIndex;
    public uint SymbolSeqNumber;
    public uint AskPrice;
    public uint AskVolume;
    public uint BidPrice;
    public uint BidVolume;
    public AskQuoteCondition AskQuoteCondition;
    public BidQuoteCondition BidQuoteCondition;
    public RetailPricingIndicator RetailPricingIndicator;
    public MarketIdOfBestAsk MarketIdOfBestAsk;
    public MarketIdOfBestBid MarketIdOfBestBid;
};

/// <summary>
///  Struct for Close Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClosePrice {
    public MarketIdOfTheClose MarketIdOfTheClose;
    public uint ClosingPrice;
};

/// <summary>
///  Struct for Consolidated Security Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedSecurityStatusMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public SecurityStatus SecurityStatus;
    public HaltCondition HaltCondition;
    public MarketId MarketId;
    public fixed byte Reserved2[2];
    public uint Price1;
    public uint Price2;
    public SsrTriggeringExchangeId SsrTriggeringExchangeId;
    public uint SsrTriggeringVolume;
    public uint Time;
    public SsrState SsrState;
    public MarketState MarketState;
    public SessionState SessionState;
};

/// <summary>
///  Struct for Consolidated Single Sided Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedSingleSidedQuoteMessage {
    public uint SymbolIndex;
    public uint SymbolSeqNumber;
    public Side Side;
    public uint Price;
    public uint Volume;
    public QuoteCondition QuoteCondition;
    public RpiIndicator RpiIndicator;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Stock Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedStockSummaryMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint HighPrice;
    public uint LowPrice;
    public uint Open;
    public uint TotalVolume;
    public MarketIdOfHighPrice MarketIdOfHighPrice;
    public MarketIdOfLowPrice MarketIdOfLowPrice;
    public MarketIdOfOpenPrice MarketIdOfOpenPrice;
    public byte NumberOfClosePrices;
};

/// <summary>
///  Struct for Consolidated Symbol Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedSymbolClearMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint NextSourceSeqNum;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedTradeCancelMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNumber;
    public uint TradeId;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedTradeCorrectionMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNumber;
    public uint OriginalTradeId;
    public uint TradeId;
    public uint Price;
    public uint Volume;
    public TradeCondition1 TradeCondition1;
    public TradeCondition2 TradeCondition2;
    public TradeCondition3 TradeCondition3;
    public TradeCondition4 TradeCondition4;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedTradeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
    public uint Price;
    public uint Volume;
    public TradeCondition1 TradeCondition1;
    public TradeCondition2 TradeCondition2;
    public TradeCondition3 TradeCondition3;
    public TradeCondition4 TradeCondition4;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Trading Session Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedTradingSessionChangeMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public byte TradeSession;
    public MarketId MarketId;
};

/// <summary>
///  Struct for Consolidated Volume Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConsolidatedVolumeMessage {
    public uint SymbolIndex;
    public uint SymbolSeqNumber;
    public uint TotalVolume;
    public Reason Reason;
    public Complete Complete;
};

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
    public Status Status;
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
    public PriceResolution PriceResolution;
    public RoundLot RoundLot;
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
///  Struct for Trade Session
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeSession {
    public fixed byte Reserved[5];
    public fixed byte OkForLateHours[1];
    public fixed byte OkForNationalHours[1];
    public fixed byte OkForMorningHours[1];
};

