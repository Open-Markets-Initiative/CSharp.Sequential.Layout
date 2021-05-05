// C# Structs For Nyse Amex Equities Xdp IntegratedFeed 2.1.g protocol

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
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    EarlyOpening = (byte)'E',
    Opening = (byte)'O',
    Reopening = (byte)'5',
    Closing = (byte)'6',
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
///  Freeze Status Values
/// </summary>
public enum FreezeStatus : byte {
    NoImbalanceFreeze = 0,
    ImbalanceFreeze = 1,
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
///  Imbalance Side Values
/// </summary>
public enum ImbalanceSide : byte {
    NoImbalance = (byte)' ',
    BuySide = (byte)'B',
    SellSide = (byte)'S',
};

/// <summary>
///  Market Id Values
/// </summary>
public enum MarketId : ushort {
    NyseEquities = 1,
    NyseArcaEquities = 3,
    NyseArcaOptions = 4,
    NyseBonds = 5,
    GlobalOtc = 6,
    NyseAmexOptions = 8,
    NyseAmericanEquities = 9,
    NyseNationalEquities = 10,
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
    SequenceNumberResetMessage = 1,
    SourceTimeReferenceMessage = 2,
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
    AddOrderMessage = 100,
    ModifyOrderMessage = 101,
    ReplaceOrderMessage = 104,
    DeleteOrderMessage = 102,
    TradeCancelMessage = 112,
    CrossTradeMessage = 111,
    CrossCorrectionMessage = 113,
    RetailPriceImprovementMessage = 114,
    AddOrderRefreshMessage = 106,
    ImbalanceMessage = 105,
    OrderExecutionMessage = 103,
    NonDisplayedTradeMessage = 110,
    StockSummaryMessage = 223,
};

/// <summary>
///  Position Change Values
/// </summary>
public enum PositionChange : byte {
    Kept = 0,
    Lost = 1,
};

/// <summary>
///  Price Resolution Values
/// </summary>
public enum PriceResolution : byte {
    AllPenny = 0,
    PennyNickel = 1,
    NickelDime = 5,
};

/// <summary>
///  Printable Flag Values
/// </summary>
public enum PrintableFlag : byte {
    NotPrinted = 0,
    Printed = 1,
};

/// <summary>
///  Retransmit Method Values
/// </summary>
public enum RetransmitMethod : byte {
    Udp = 0,
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
    1InvalidMsgTypeOr2MismatchBetweenMsgTypeAndMsgSize = (byte)'9',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public uint Price;
    public uint Volume;
    public Side Side;
    public fixed sbyte FirmId[5];
    public byte NumParitySplits;
};

/// <summary>
///  Struct for Add Order Refresh Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderRefreshMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public uint Price;
    public uint Volume;
    public Side Side;
    public fixed sbyte FirmId[5];
    public byte NumParitySplits;
};

/// <summary>
///  Struct for Cross Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossCorrectionMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint CrossId;
    public uint Volume;
};

/// <summary>
///  Struct for Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossTradeMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint CrossId;
    public uint Price;
    public uint Volume;
    public CrossType CrossType;
};

/// <summary>
///  Struct for Delete Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public byte NumParitySplits;
};

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
///  Struct for Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public uint Price;
    public uint Volume;
    public PositionChange PositionChange;
    public byte PrevPriceParitySplits;
    public byte NewPriceParitySplits;
};

/// <summary>
///  Struct for Non Displayed Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NonDisplayedTradeMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
    public uint Price;
    public uint Volume;
    public PrintableFlag PrintableFlag;
    public uint DbExecId;
};

/// <summary>
///  Struct for Order Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public uint TradeId;
    public uint Price;
    public uint Volume;
    public PrintableFlag PrintableFlag;
    public byte NumParitySplits;
    public uint DbExecId;
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
///  Struct for Replace Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplaceOrderMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public ulong OrderId;
    public ulong NewOrderId;
    public uint Price;
    public uint Volume;
    public byte PrevPriceParitySplits;
    public byte NewPriceParitySplits;
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
///  Struct for Retail Price Improvement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetailPriceImprovementMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public RpiIndicator RpiIndicator;
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
    public SsrState SsrState;
    public MarketState MarketState;
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
///  Struct for Stock Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockSummaryMessage {
    public uint SourceTime;
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint HighPrice;
    public uint LowPrice;
    public uint Open;
    public uint Close;
    public uint TotalVolume;
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
///  Struct for Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelMessage {
    public uint SourceTimeNs;
    public uint SymbolIndex;
    public uint SymbolSeqNum;
    public uint TradeId;
};

