// C# Structs For Eurex Derivatives T7 Eobi 8.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    Buy = 1,
    Sell = 2,
    AggressorSide = 2,
    AggressorSide = 1,
};

/// <summary>
///  Algorithmic Trade Indicator Values
/// </summary>
public enum AlgorithmicTradeIndicator : byte {
    AlgorithmicTrade = 1,
    AlgorithmicTradeIndicator = 1,
    AlgorithmicTradeIndicator = 1,
};

/// <summary>
///  Application Sequence Reset Indicator Values
/// </summary>
public enum ApplicationSequenceResetIndicator : byte {
    NoReset = 0,
    Reset = 1,
    ApplSeqResetIndicator = 1,
    ApplSeqResetIndicator = 0,
};

/// <summary>
///  Bid Ord Type Values
/// </summary>
public enum BidOrdType : byte {
    Market = 1,
    BidOrdType = 1,
    BidOrdType = 1,
};

/// <summary>
///  Completion Indicator Values
/// </summary>
public enum CompletionIndicator : byte {
    Incomplete = 0,
    Complete = 1,
    CompletionIndicator = 1,
    CompletionIndicator = 0,
};

/// <summary>
///  Cross Request Type Values
/// </summary>
public enum CrossRequestType : byte {
    CrossAnnouncement = 1,
    LiquidityImprovementCross = 2,
    CrossRequestType = 2,
    CrossRequestType = 1,
};

/// <summary>
///  Fast Market Indicator Values
/// </summary>
public enum FastMarketIndicator : byte {
    No = 0,
    Yes = 1,
    FastMarketIndicator = 1,
    FastMarketIndicator = 0,
};

/// <summary>
///  Implied Market Indicator Values
/// </summary>
public enum ImpliedMarketIndicator : byte {
    NotImplied = 0,
    ImpliedInOut = 3,
    ImpliedMarketIndicator = 3,
    ImpliedMarketIndicator = 0,
};

/// <summary>
///  Input Source Values
/// </summary>
public enum InputSource : byte {
    ClipClientBroker = 1,
    InputSource = 1,
    InputSource = 1,
};

/// <summary>
///  Instrument Scope Product Complex Values
/// </summary>
public enum InstrumentScopeProductComplex : byte {
    SimpleInstrument = 1,
    StandardOptionStrategy = 2,
    NonStandardOptionStrategy = 3,
    VolatilityStrategy = 4,
    FuturesSpread = 5,
    InterProductSpread = 6,
    StandardFuturesStrategy = 7,
    PackAndBundle = 8,
    Strip = 9,
    InstrumentScopeProductComplex = 9,
    InstrumentScopeProductComplex = 1,
};

/// <summary>
///  Last Fragment Values
/// </summary>
public enum LastFragment : byte {
    N = 0,
    Y = 1,
    LastFragment = 1,
    LastFragment = 0,
};

/// <summary>
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    LegSecurityMultiLeg = 1,
    LegSecurityUnderlyingLeg = 2,
    LegSecurityType = 2,
    LegSecurityType = 1,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = 1,
    Sell = 2,
    LegSide = 2,
    LegSide = 1,
};

/// <summary>
///  Market Condition Values
/// </summary>
public enum MarketCondition : byte {
    Normal = 0,
    Stressed = 1,
    MarketCondition = 1,
    MarketCondition = 0,
};

/// <summary>
///  Mass Market Condition Values
/// </summary>
public enum MassMarketCondition : byte {
    Normal = 0,
    Stressed = 1,
    MassMarketCondition = 1,
    MassMarketCondition = 0,
};

/// <summary>
///  Mass Sold Out Indicator Values
/// </summary>
public enum MassSoldOutIndicator : byte {
    SoldOut = 1,
    MassSoldOutIndicator = 1,
    MassSoldOutIndicator = 1,
};

/// <summary>
///  Match Sub Type Values
/// </summary>
public enum MatchSubType : byte {
    OpeningAuction = 1,
    ClosingAuction = 2,
    IntradayAuction = 3,
    CircuitBreakerAuction = 4,
    IpoAuction = 5,
    MatchSubType = 5,
    MatchSubType = 1,
};

/// <summary>
///  Match Type Values
/// </summary>
public enum MatchType : byte {
    ConfirmedTradeReport = 3,
    CrossAuction = 5,
    CallAuction = 7,
    LiquidityImprovementCross = 13,
    ContinuousAuction = 14,
    MatchType = 14,
    MatchType = 3,
};

/// <summary>
///  Md Entry Type Values
/// </summary>
public enum MdEntryType : byte {
    Trade = 2,
    OpeningPrice = 4,
    ClosingPrice = 5,
    HighPrice = 7,
    LowPrice = 8,
    TradeVolume = 66,
    PreviousClosingPrice = 101,
    OpeningAuction = 200,
    IntradayAuction = 201,
    CircuitBreakerAuction = 202,
    ClosingAuction = 203,
    IpoAuction = 204,
    MdEntryType = 204,
    MdEntryType = 2,
};

/// <summary>
///  Offer Ord Type Values
/// </summary>
public enum OfferOrdType : byte {
    Market = 1,
    OfferOrdType = 1,
    OfferOrdType = 1,
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = 1,
    OrdType = 1,
    OrdType = 1,
};

/// <summary>
///  Potential Security Trading Event Values
/// </summary>
public enum PotentialSecurityTradingEvent : byte {
    None = 0,
    PriceVolatilityAuctionIsExtended = 10,
    PotentialSecurityTradingEvent = 10,
    PotentialSecurityTradingEvent = 0,
};

/// <summary>
///  Product Complex Values
/// </summary>
public enum ProductComplex : byte {
    SimpleInstrument = 1,
    StandardOptionStrategy = 2,
    NonStandardOptionStrategy = 3,
    VolatilityStrategy = 4,
    FuturesSpread = 5,
    InterProductSpread = 6,
    StandardFuturesStrategy = 7,
    PackAndBundle = 8,
    Strip = 9,
    ProductComplex = 9,
    ProductComplex = 1,
};

/// <summary>
///  Security Mass Status Values
/// </summary>
public enum SecurityMassStatus : byte {
    Active = 1,
    Inactive = 2,
    Expired = 4,
    KnockedOut = 6,
    KnockOutRevoked = 7,
    Suspended = 9,
    PendingDeletion = 11,
    KnockedOutAndSuspended = 12,
    SecurityMassStatus = 12,
    SecurityMassStatus = 1,
};

/// <summary>
///  Security Mass Trading Event Values
/// </summary>
public enum SecurityMassTradingEvent : byte {
    PriceVolatilityAuctionIsExtended = 10,
    PriceVolatilityAuctionIsExtendedAgain = 11,
    SecurityMassTradingEvent = 11,
    SecurityMassTradingEvent = 10,
};

/// <summary>
///  Security Mass Trading Status Values
/// </summary>
public enum SecurityMassTradingStatus : byte {
    TradingHalt = 2,
    MarketImbalanceBuy = 7,
    MarketImbalanceSell = 8,
    Closed = 200,
    Restricted = 201,
    Book = 202,
    Continuous = 203,
    OpeningAuction = 204,
    OpeningAuctionFreeze = 205,
    IntradayAuction = 206,
    IntradayAuctionFreeze = 207,
    CircuitBreakerAuction = 208,
    CircuitBreakerAuctionFreeze = 209,
    ClosingAuction = 210,
    ClosingAuctionFreeze = 211,
    IpoAuction = 212,
    IpoAuctionFreeze = 213,
    PreCall = 214,
    Call = 215,
    Freeze = 216,
    SecurityMassTradingStatus = 216,
    SecurityMassTradingStatus = 2,
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    Active = 1,
    Inactive = 2,
    Expired = 4,
    KnockedOut = 6,
    KnockOutRevoked = 7,
    Suspended = 9,
    PendingDeletion = 11,
    KnockedOutAndSuspended = 12,
    SecurityStatus = 12,
    SecurityStatus = 1,
};

/// <summary>
///  Security Trading Event Values
/// </summary>
public enum SecurityTradingEvent : byte {
    PriceVolatilityAuctionIsExtended = 10,
    PriceVolatilityAuctionIsExtendedAgain = 11,
    SecurityTradingEvent = 11,
    SecurityTradingEvent = 10,
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    TradingHalt = 2,
    MarketImbalanceBuy = 7,
    MarketImbalanceSell = 8,
    Closed = 200,
    Restricted = 201,
    Book = 202,
    Continuous = 203,
    OpeningAuction = 204,
    OpeningAuctionFreeze = 205,
    IntradayAuction = 206,
    IntradayAuctionFreeze = 207,
    CircuitBreakerAuction = 208,
    CircuitBreakerAuctionFreeze = 209,
    ClosingAuction = 210,
    ClosingAuctionFreeze = 211,
    IpoAuction = 212,
    IpoAuctionFreeze = 213,
    PreCall = 214,
    Call = 215,
    Freeze = 216,
    SecurityTradingStatus = 216,
    SecurityTradingStatus = 2,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
    Side = 2,
    Side = 1,
};

/// <summary>
///  Sold Out Indicator Values
/// </summary>
public enum SoldOutIndicator : byte {
    SoldOut = 1,
    SoldOutIndicator = 1,
    SoldOutIndicator = 1,
};

/// <summary>
///  Trad Ses Status Values
/// </summary>
public enum TradSesStatus : byte {
    Halted = 1,
    Open = 2,
    Closed = 3,
    TradSesStatus = 3,
    TradSesStatus = 1,
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : ushort {
    ImpliedTrade = 1,
    OutOfSequence = 107,
    SystematicInternalizer = 153,
    MidpointPrice = 155,
    TradingOnTermsOfIssue = 156,
    SpecialAuction = 596,
    TradeCondition = 596,
    TradeCondition = 1,
};

/// <summary>
///  Trading Session Id Values
/// </summary>
public enum TradingSessionId : byte {
    Day = 1,
    Morning = 3,
    Evening = 5,
    AfterHours = 6,
    Holiday = 7,
    TradingSessionId = 7,
    TradingSessionId = 1,
};

/// <summary>
///  Trading Session Sub Id Values
/// </summary>
public enum TradingSessionSubId : byte {
    PreTrading = 1,
    Continuous = 3,
    Closing = 4,
    PostTrading = 5,
    Quiescent = 7,
    TradingSessionSubId = 7,
    TradingSessionSubId = 1,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Complex Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddComplexInstrument {
    public long SecurityId;
    public ulong TransactTime;
    public int SecuritySubType;
    public ProductComplex ProductComplex;
    public ImpliedMarketIndicator ImpliedMarketIndicator;
    public byte NoLegs;
    public fixed byte Pad1[1];
};

/// <summary>
///  Struct for Auction Bbo
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionBbo {
    public ulong TransactTime;
    public long SecurityId;
    public ulong BidPx;
    public ulong OfferPx;
    public ulong BidSize;
    public ulong OfferSize;
    public PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
    public BidOrdType BidOrdType;
    public OfferOrdType OfferOrdType;
    public fixed byte Pad5[5];
};

/// <summary>
///  Struct for Auction Clearing Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionClearingPrice {
    public ulong TransactTime;
    public long SecurityId;
    public ulong LastPx;
    public ulong LastQty;
    public ulong ImbalanceQty;
    public SecurityTradingStatus SecurityTradingStatus;
    public PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Cross Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossRequest {
    public long SecurityId;
    public ulong LastPx;
    public ulong LastQty;
    public Side Side;
    public CrossRequestType CrossRequestType;
    public InputSource InputSource;
    public fixed byte Pad5[5];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionSummary {
    public long SecurityId;
    public ulong AggressorTime;
    public ulong RequestTime;
    public ulong ExecId;
    public ulong LastQty;
    public AggressorSide AggressorSide;
    public fixed byte Pad1[1];
    public TradeCondition TradeCondition;
    public fixed byte Pad4[4];
    public ulong LastPx;
    public ulong RestingHiddenQty;
    public ulong RestingCxlQty;
};

/// <summary>
///  Struct for Full Order Execution
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullOrderExecution {
    public Side Side;
    public OrdType OrdType;
    public AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
    public fixed byte Pad1[1];
    public uint TrdMatchId;
    public ulong Price;
    public ulong TrdRegTsTimePriority;
    public long SecurityId;
    public ulong LastQty;
    public ulong LastPx;
};

/// <summary>
///  Struct for Heartbeat
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Heartbeat {
    public uint LastMsgSeqNumProcessed;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Instrmt Leg Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrmtLegGrp {
    public int LegSymbol;
    public fixed byte Pad4[4];
    public long LegSecurityId;
    public ulong LegPrice;
    public int LegRatioQty;
    public LegSecurityType LegSecurityType;
    public LegSide LegSide;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Instrument State Change
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentStateChange {
    public long SecurityId;
    public SecurityStatus SecurityStatus;
    public SecurityTradingStatus SecurityTradingStatus;
    public MarketCondition MarketCondition;
    public FastMarketIndicator FastMarketIndicator;
    public SecurityTradingEvent SecurityTradingEvent;
    public SoldOutIndicator SoldOutIndicator;
    public fixed byte Pad2[2];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Instrument Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentSummary {
    public long SecurityId;
    public ulong LastUpdateTime;
    public ulong TrdRegTsExecutionTime;
    public ushort TotNoOrders;
    public SecurityStatus SecurityStatus;
    public SecurityTradingStatus SecurityTradingStatus;
    public MarketCondition MarketCondition;
    public FastMarketIndicator FastMarketIndicator;
    public SecurityTradingEvent SecurityTradingEvent;
    public SoldOutIndicator SoldOutIndicator;
    public ProductComplex ProductComplex;
    public byte NoMdEntries;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Mass Instrument State Change
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassInstrumentStateChange {
    public InstrumentScopeProductComplex InstrumentScopeProductComplex;
    public SecurityMassStatus SecurityMassStatus;
    public SecurityMassTradingStatus SecurityMassTradingStatus;
    public MassMarketCondition MassMarketCondition;
    public FastMarketIndicator FastMarketIndicator;
    public SecurityMassTradingEvent SecurityMassTradingEvent;
    public MassSoldOutIndicator MassSoldOutIndicator;
    public fixed byte Pad1[1];
    public ulong TransactTime;
    public LastFragment LastFragment;
    public byte NoRelatedSym;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Md Instrument Entry Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdInstrumentEntryGrp {
    public ulong MdEntryPx;
    public ulong MdEntrySize;
    public MdEntryType MdEntryType;
    public fixed byte Pad1[1];
    public TradeCondition TradeCondition;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Md Trade Entry Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdTradeEntryGrp {
    public ulong MdEntryPx;
    public ulong MdEntrySize;
    public MdEntryType MdEntryType;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort BodyLen;
    public ushort TemplateId;
    public uint MsgSeqNum;
};

/// <summary>
///  Struct for Order Add
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAdd {
    public ulong TrdRegTsTimeIn;
    public long SecurityId;
    public fixed byte OrderDetails[0];
};

/// <summary>
///  Struct for Order Delete
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDelete {
    public ulong TrdRegTsTimeIn;
    public ulong TransactTime;
    public long SecurityId;
    public fixed byte OrderDetails[0];
};

/// <summary>
///  Struct for Order Details
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDetails {
    public ulong TrdRegTsTimePriority;
    public ulong DisplayQty;
    public Side Side;
    public OrdType OrdType;
    public fixed byte Pad6[6];
    public ulong Price;
};

/// <summary>
///  Struct for Order Mass Delete
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderMassDelete {
    public long SecurityId;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Order Modify
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModify {
    public ulong TrdRegTsTimeIn;
    public ulong TrdRegTsPrevTimePriority;
    public ulong PrevPrice;
    public ulong PrevDisplayQty;
    public long SecurityId;
    public fixed byte OrderDetails[0];
};

/// <summary>
///  Struct for Order Modify Same Prio
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifySamePrio {
    public ulong TrdRegTsTimeIn;
    public ulong TransactTime;
    public ulong PrevDisplayQty;
    public long SecurityId;
    public fixed byte OrderDetails[0];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public fixed byte PacketInfo[0];
    public uint ApplicationSequenceNumber;
    public int MarketSegmentId;
    public byte PartitionId;
    public CompletionIndicator CompletionIndicator;
    public ApplicationSequenceResetIndicator ApplicationSequenceResetIndicator;
    public fixed byte Pad5[5];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Packet Info
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketInfo {
    public ushort HeaderLength;
    public ushort PacketId;
    public uint PacketSeqNum;
};

/// <summary>
///  Struct for Partial Order Execution
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PartialOrderExecution {
    public Side Side;
    public OrdType OrdType;
    public AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
    public fixed byte Pad1[1];
    public uint TrdMatchId;
    public ulong Price;
    public ulong TrdRegTsTimePriority;
    public long SecurityId;
    public ulong LastQty;
    public ulong LastPx;
};

/// <summary>
///  Struct for Product State Change
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ProductStateChange {
    public TradingSessionId TradingSessionId;
    public TradingSessionSubId TradingSessionSubId;
    public TradSesStatus TradSesStatus;
    public MarketCondition MarketCondition;
    public FastMarketIndicator FastMarketIndicator;
    public fixed byte Pad3[3];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Product Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ProductSummary {
    public uint LastMsgSeqNumProcessed;
    public TradingSessionId TradingSessionId;
    public TradingSessionSubId TradingSessionSubId;
    public TradSesStatus TradSesStatus;
    public MarketCondition MarketCondition;
    public FastMarketIndicator FastMarketIndicator;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequest {
    public long SecurityId;
    public ulong LastQty;
    public Side Side;
    public fixed byte Pad7[7];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Sec Mass Stat Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecMassStatGrp {
    public long SecurityId;
    public SecurityStatus SecurityStatus;
    public SecurityTradingStatus SecurityTradingStatus;
    public MarketCondition MarketCondition;
    public SecurityTradingEvent SecurityTradingEvent;
    public SoldOutIndicator SoldOutIndicator;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Snapshot Order
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotOrder {
    public fixed byte OrderDetails[0];
};

/// <summary>
///  Struct for Top Of Book
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TopOfBook {
    public ulong TransactTime;
    public long SecurityId;
    public ulong BidPx;
    public ulong OfferPx;
    public ulong BidSize;
    public ulong OfferSize;
};

/// <summary>
///  Struct for Trade Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReport {
    public long SecurityId;
    public ulong TransactTime;
    public ulong LastQty;
    public ulong LastPx;
    public uint TrdMatchId;
    public MatchType MatchType;
    public MatchSubType MatchSubType;
    public AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
    public fixed byte Pad1[1];
    public TradeCondition TradeCondition;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Trade Reversal
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReversal {
    public long SecurityId;
    public ulong TransactTime;
    public ulong LastQty;
    public ulong LastPx;
    public ulong TrdRegTsExecutionTime;
    public uint TrdMatchId;
    public TradeCondition TradeCondition;
    public fixed byte Pad2[2];
    public byte NoMdEntries;
    public fixed byte Pad7[7];
};

