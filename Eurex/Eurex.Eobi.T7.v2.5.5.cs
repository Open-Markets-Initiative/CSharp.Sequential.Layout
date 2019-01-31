// C# Structs For Eurex T7 Eobi 2.5.5 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    Buy = "1",
    Sell = "2",
    AggressorSide = "2",
    AggressorSide = "1",
};

/// <summary>
///  Application Sequence Reset Indicator Values
/// </summary>
public enum ApplicationSequenceResetIndicator : byte {
    NoReset = "0",
    Reset = "1",
    ApplSeqResetIndicator = "1",
    ApplSeqResetIndicator = "0",
};

/// <summary>
///  Completion Indicator Values
/// </summary>
public enum CompletionIndicator : byte {
    Incomplete = "0",
    Complete = "1",
    CompletionIndicator = "1",
    CompletionIndicator = "0",
};

/// <summary>
///  Fast Market Indicator Values
/// </summary>
public enum FastMarketIndicator : byte {
    No = "0",
    Yes = "1",
    FastMarketIndicator = "1",
    FastMarketIndicator = "0",
};

/// <summary>
///  Implied Market Indicator Values
/// </summary>
public enum ImpliedMarketIndicator : byte {
    NotImplied = "0",
    ImpliedInOut = "3",
    ImpliedMarketIndicator = "3",
    ImpliedMarketIndicator = "0",
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = "1",
    Sell = "2",
    LegSide = "2",
    LegSide = "1",
};

/// <summary>
///  Match Sub Type Values
/// </summary>
public enum MatchSubType : byte {
    OpeningAuction = "1",
    ClosingAuction = "2",
    IntradayAuction = "3",
    CircuitBreakerAuction = "4",
    MatchSubType = "4",
    MatchSubType = "1",
};

/// <summary>
///  Match Type Values
/// </summary>
public enum MatchType : byte {
    ConfirmedTradeReport = "3",
    CrossAuction = "5",
    CallAuction = "7",
    MatchType = "7",
    MatchType = "3",
};

/// <summary>
///  Md Entry Type Values
/// </summary>
public enum MdEntryType : byte {
    Trade = "2",
    OpeningPrice = "4",
    ClosingPrice = "5",
    HighPrice = "7",
    LowPrice = "8",
    TradeVolume = "66",
    PreviousClosingPrice = "101",
    OpeningAuction = "200",
    IntradayAuction = "201",
    CircuitBreakerAuction = "202",
    ClosingAuction = "203",
    MdEntryType = "203",
    MdEntryType = "2",
};

/// <summary>
///  Product Complex Values
/// </summary>
public enum ProductComplex : byte {
    FuturesSpread = "5",
    InterProductSpread = "6",
    StandardFuturesStrategy = "7",
    PackAndBundle = "8",
    Strip = "9",
    ProductComplex = "9",
    ProductComplex = "5",
};

/// <summary>
///  Security Status Values
/// </summary>
public enum SecurityStatus : byte {
    Active = "1",
    Inactive = "2",
    Expired = "4",
    Suspended = "9",
    SecurityStatus = "9",
    SecurityStatus = "1",
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    Closed = "200",
    Restricted = "201",
    Book = "202",
    Continuous = "203",
    OpeningAuction = "204",
    OpeningAuctionFreeze = "205",
    IntradayAuction = "206",
    IntradayAuctionFreeze = "207",
    CircuitBreakerAuction = "208",
    CircuitBreakerAuctionFreeze = "209",
    ClosingAuction = "210",
    ClosingAuctionFreeze = "211",
    SecurityTradingStatus = "211",
    SecurityTradingStatus = "200",
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = "1",
    Sell = "2",
    Side = "2",
    Side = "1",
};

/// <summary>
///  Trad Ses Status Values
/// </summary>
public enum TradSesStatus : byte {
    Halted = "1",
    Open = "2",
    Closed = "3",
    TradSesStatus = "3",
    TradSesStatus = "1",
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    ImpliedTrade = "1",
    TradeCondition = "1",
    TradeCondition = "1",
};

/// <summary>
///  Trading Session Id Values
/// </summary>
public enum TradingSessionId : byte {
    Day = "1",
    Morning = "3",
    Evening = "5",
    Holiday = "7",
    TradingSessionId = "7",
    TradingSessionId = "1",
};

/// <summary>
///  Trading Session Sub Id Values
/// </summary>
public enum TradingSessionSubId : byte {
    PreTrading = "1",
    Trading = "3",
    Closing = "4",
    PostTrading = "5",
    Quiescent = "7",
    TradingSessionSubId = "7",
    TradingSessionSubId = "1",
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
};

/// <summary>
///  Struct for Auction Clearing Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AuctionClearingPrice {
    public ulong TransactTime;
    public long SecurityId;
    public ulong LastPx;
};

/// <summary>
///  Struct for Cross Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossRequest {
    public long SecurityId;
    public int LastQty;
    public fixed byte Pad4[4];
    public ulong TransactTime;
};

/// <summary>
///  Struct for Execution Summary
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionSummary {
    public long SecurityId;
    public ulong AggressorTimestamp;
    public ulong RequestTime;
    public ulong ExecId;
    public int LastQty;
    public AggressorSide AggressorSide;
    public TradeCondition TradeCondition;
    public fixed byte Pad2[2];
    public ulong LastPx;
    public int RestingHiddenQty;
    public fixed byte Pad4[4];
};

/// <summary>
///  Struct for Full Order Execution
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullOrderExecution {
    public Side Side;
    public fixed byte Pad7[7];
    public ulong Price;
    public ulong TrdRegTsTimePriority;
    public long SecurityId;
    public uint TrdMatchId;
    public int LastQty;
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
    public int LegRatioQty;
    public LegSide LegSide;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Instrument State Change
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentStateChange {
    public long SecurityId;
    public SecurityStatus SecurityStatus;
    public SecurityTradingStatus SecurityTradingStatus;
    public FastMarketIndicator FastMarketIndicator;
    public fixed byte Pad5[5];
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
    public FastMarketIndicator FastMarketIndicator;
    public byte NoMdEntries;
    public fixed byte Pad2[2];
};

/// <summary>
///  Struct for Md Instrument Entry Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdInstrumentEntryGrp {
    public ulong MdEntryPx;
    public int MdEntrySize;
    public MdEntryType MdEntryType;
    public fixed byte Pad3[3];
};

/// <summary>
///  Struct for Md Trade Entry Grp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdTradeEntryGrp {
    public ulong MdEntryPx;
    public int MdEntrySize;
    public MdEntryType MdEntryType;
    public fixed byte Pad3[3];
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
    public int DisplayQty;
    public Side Side;
    public fixed byte Pad3[3];
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
    public int PrevDisplayQty;
    public fixed byte Pad4[4];
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
    public int PrevDisplayQty;
    public fixed byte Pad4[4];
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
    public fixed byte Pad7[7];
    public ulong Price;
    public ulong TrdRegTsTimePriority;
    public long SecurityId;
    public uint TrdMatchId;
    public int LastQty;
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
    public FastMarketIndicator FastMarketIndicator;
    public fixed byte Pad4[4];
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
    public FastMarketIndicator FastMarketIndicator;
};

/// <summary>
///  Struct for Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequest {
    public long SecurityId;
    public int LastQty;
    public Side Side;
    public fixed byte Pad3[3];
    public ulong TransactTime;
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
};

/// <summary>
///  Struct for Trade Report
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReport {
    public long SecurityId;
    public ulong TransactTime;
    public uint TrdMatchId;
    public int LastQty;
    public ulong LastPx;
    public MatchType MatchType;
    public MatchSubType MatchSubType;
    public fixed byte Pad6[6];
};

/// <summary>
///  Struct for Trade Reversal
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReversal {
    public long SecurityId;
    public ulong TransactTime;
    public uint TrdMatchId;
    public int LastQty;
    public ulong LastPx;
    public ulong TrdRegTsExecutionTime;
    public byte NoMdEntries;
    public fixed byte Pad7[7];
};

