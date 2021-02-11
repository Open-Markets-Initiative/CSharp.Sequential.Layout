// C# Structs For Eurex Derivatives T7 Eobi 8.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    Buy = 1,
    Sell = 2,
    AggressorSideMinimumValue = 2,
    AggressorSideMinimumValue = 1,
};

/// <summary>
///  Algorithmic Trade Indicator Values
/// </summary>
public enum AlgorithmicTradeIndicator : byte {
    AlgorithmicTrade = 1,
    AlgorithmicTradeIndicatorMinimumValue = 1,
    AlgorithmicTradeIndicatorMinimumValue = 1,
};

/// <summary>
///  Appl Seq Reset Indicator Values
/// </summary>
public enum ApplSeqResetIndicator : byte {
    NoReset = 0,
    Reset = 1,
    ApplSeqResetIndicatorMinimumValue = 1,
    ApplSeqResetIndicatorMinimumValue = 0,
};

/// <summary>
///  Bid Ord Type Values
/// </summary>
public enum BidOrdType : byte {
    Market = 1,
    BidOrdTypeMinimumValue = 1,
    BidOrdTypeMinimumValue = 1,
};

/// <summary>
///  Completion Indicator Values
/// </summary>
public enum CompletionIndicator : byte {
    Incomplete = 0,
    Complete = 1,
    CompletionIndicatorMinimumValue = 1,
    CompletionIndicatorMinimumValue = 0,
};

/// <summary>
///  Cross Request Type Values
/// </summary>
public enum CrossRequestType : byte {
    CrossAnnouncement = 1,
    LiquidityImprovementCross = 2,
    CrossRequestTypeMinimumValue = 2,
    CrossRequestTypeMinimumValue = 1,
};

/// <summary>
///  Fast Market Indicator Values
/// </summary>
public enum FastMarketIndicator : byte {
    No = 0,
    Yes = 1,
    FastMarketIndicatorMinimumValue = 1,
    FastMarketIndicatorMinimumValue = 0,
};

/// <summary>
///  Implied Market Indicator Values
/// </summary>
public enum ImpliedMarketIndicator : byte {
    NotImplied = 0,
    ImpliedInOut = 3,
    ImpliedMarketIndicatorMinimumValue = 3,
    ImpliedMarketIndicatorMinimumValue = 0,
};

/// <summary>
///  Input Source Values
/// </summary>
public enum InputSource : byte {
    ClipClientBroker = 1,
    InputSourceMinimumValue = 1,
    InputSourceMinimumValue = 1,
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
    InstrumentScopeProductComplexMinimumValue = 9,
    InstrumentScopeProductComplexMinimumValue = 1,
};

/// <summary>
///  Last Fragment Values
/// </summary>
public enum LastFragment : byte {
    N = 0,
    Y = 1,
    LastFragmentMinimumValue = 1,
    LastFragmentMinimumValue = 0,
};

/// <summary>
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    LegSecurityMultiLeg = 1,
    LegSecurityUnderlyingLeg = 2,
    LegSecurityTypeMinimumValue = 2,
    LegSecurityTypeMinimumValue = 1,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = 1,
    Sell = 2,
    LegSideMinimumValue = 2,
    LegSideMinimumValue = 1,
};

/// <summary>
///  Market Condition Values
/// </summary>
public enum MarketCondition : byte {
    Normal = 0,
    Stressed = 1,
    MarketConditionMinimumValue = 1,
    MarketConditionMinimumValue = 0,
};

/// <summary>
///  Mass Market Condition Values
/// </summary>
public enum MassMarketCondition : byte {
    Normal = 0,
    Stressed = 1,
    MassMarketConditionMinimumValue = 1,
    MassMarketConditionMinimumValue = 0,
};

/// <summary>
///  Mass Sold Out Indicator Values
/// </summary>
public enum MassSoldOutIndicator : byte {
    SoldOut = 1,
    MassSoldOutIndicatorMinimumValue = 1,
    MassSoldOutIndicatorMinimumValue = 1,
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
    MatchSubTypeMinimumValue = 5,
    MatchSubTypeMinimumValue = 1,
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
    MatchTypeMinimumValue = 14,
    MatchTypeMinimumValue = 3,
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
    MdEntryTypeMinimumValue = 204,
    MdEntryTypeMinimumValue = 2,
};

/// <summary>
///  Offer Ord Type Values
/// </summary>
public enum OfferOrdType : byte {
    Market = 1,
    OfferOrdTypeMinimumValue = 1,
    OfferOrdTypeMinimumValue = 1,
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = 1,
    OrdTypeMinimumValue = 1,
    OrdTypeMinimumValue = 1,
};

/// <summary>
///  Potential Security Trading Event Values
/// </summary>
public enum PotentialSecurityTradingEvent : byte {
    None = 0,
    PriceVolatilityAuctionIsExtended = 10,
    PotentialSecurityTradingEventMinimumValue = 10,
    PotentialSecurityTradingEventMinimumValue = 0,
};

/// <summary>
///  Product Complex Values
/// </summary>
public enum ProductComplex : byte {
    StandardOptionStrategy = 2,
    NonStandardOptionStrategy = 3,
    VolatilityStrategy = 4,
    FuturesSpread = 5,
    InterProductSpread = 6,
    StandardFuturesStrategy = 7,
    PackAndBundle = 8,
    Strip = 9,
    ProductComplexMinimumValue = 9,
    ProductComplexMinimumValue = 2,
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
    SecurityMassStatusMinimumValue = 12,
    SecurityMassStatusMinimumValue = 1,
};

/// <summary>
///  Security Mass Trading Event Values
/// </summary>
public enum SecurityMassTradingEvent : byte {
    PriceVolatilityAuctionIsExtended = 10,
    PriceVolatilityAuctionIsExtendedAgain = 11,
    SecurityMassTradingEventMinimumValue = 11,
    SecurityMassTradingEventMinimumValue = 10,
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
    SecurityMassTradingStatusMinimumValue = 216,
    SecurityMassTradingStatusMinimumValue = 2,
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
    SecurityStatusMinimumValue = 12,
    SecurityStatusMinimumValue = 1,
};

/// <summary>
///  Security Trading Event Values
/// </summary>
public enum SecurityTradingEvent : byte {
    PriceVolatilityAuctionIsExtended = 10,
    PriceVolatilityAuctionIsExtendedAgain = 11,
    SecurityTradingEventMinimumValue = 11,
    SecurityTradingEventMinimumValue = 10,
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
    SecurityTradingStatusMinimumValue = 216,
    SecurityTradingStatusMinimumValue = 2,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
    SideMinimumValue = 2,
    SideMinimumValue = 1,
};

/// <summary>
///  Sold Out Indicator Values
/// </summary>
public enum SoldOutIndicator : byte {
    SoldOut = 1,
    SoldOutIndicatorMinimumValue = 1,
    SoldOutIndicatorMinimumValue = 1,
};

/// <summary>
///  Trad Ses Status Values
/// </summary>
public enum TradSesStatus : byte {
    Halted = 1,
    Open = 2,
    Closed = 3,
    TradSesStatusMinimumValue = 3,
    TradSesStatusMinimumValue = 1,
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    ImpliedTrade = 1,
    SpecialAuctionPrice = 86,
    OutOfSequence = 107,
    SystematicInternalizer = 153,
    MidpointPrice = 155,
    TradedBeforeIssueDate = 156,
    TradeConditionMinimumValue = 156,
    TradeConditionMinimumValue = 1,
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
    TradingSessionIDMinimumValue = 7,
    TradingSessionIDMinimumValue = 1,
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
    TradingSessionSubIDMinimumValue = 7,
    TradingSessionSubIDMinimumValue = 1,
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
    public TradeCondition TradeCondition;
    public fixed byte Pad6[6];
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
///  Struct for Instrmt Leg Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrmtLegGrpComp {
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
    public byte NoMdEntries;
    public fixed byte Pad7[7];
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
///  Struct for Md Instrument Entry Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdInstrumentEntryGrpComp {
    public ulong MdEntryPx;
    public ulong MdEntrySize;
    public MdEntryType MdEntryType;
    public TradeCondition TradeCondition;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Md Trade Entry Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdTradeEntryGrpComp {
    public ulong MdEntryPx;
    public ulong MdEntrySize;
    public MdEntryType MdEntryType;
    public fixed byte Pad7[7];
};

/// <summary>
///  Struct for Message Header Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeaderComp {
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
    public fixed byte OrderDetailsComp[0];
};

/// <summary>
///  Struct for Order Delete
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDelete {
    public ulong TrdRegTsTimeIn;
    public ulong TransactTime;
    public long SecurityId;
    public fixed byte OrderDetailsComp[0];
};

/// <summary>
///  Struct for Order Details Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDetailsComp {
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
    public fixed byte OrderDetailsComp[0];
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
    public fixed byte OrderDetailsComp[0];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public fixed byte PacketInfo[0];
    public uint ApplSeqNum;
    public int MarketSegmentId;
    public byte PartitionId;
    public CompletionIndicator CompletionIndicator;
    public ApplSeqResetIndicator ApplSeqResetIndicator;
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
    public uint PacketSequenceNumber;
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
///  Struct for Sec Mass Stat Grp Comp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecMassStatGrpComp {
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
    public fixed byte OrderDetailsComp[0];
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
    public TradeCondition TradeCondition;
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
};

