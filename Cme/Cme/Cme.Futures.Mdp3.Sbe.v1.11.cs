// C# Structs For Cme Futures Sbe Mdp3 1.11 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Indicator Values
/// </summary>
public enum AggressorIndicator : byte {
    NoValue = 255,
    NotAggressor = 0,
    Aggressor = 1,
};

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    NoValue = 255,
    NoAggressor = 0,
    Buy = 1,
    Sell = 2,
};

/// <summary>
///  Event Type Values
/// </summary>
public enum EventType : byte {
    Activation = 5,
    LastEligibleTradeDate = 7,
};

/// <summary>
///  Halt Reason Values
/// </summary>
public enum HaltReason : byte {
    GroupSchedule = 0,
    SurveillanceIntervention = 1,
    MarketEvent = 2,
    InstrumentActivation = 3,
    InstrumentExpiration = 4,
    Unknown = 5,
    RecoveryInProcess = 6,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    BuySide = 1,
    SellSide = 2,
};

/// <summary>
///  Md Entry Type  Values
/// </summary>
public enum MdEntryType : byte {
    Bid = (byte)'0',
    Offer = (byte)'1',
    Trade = (byte)'2',
    OpenPrice = (byte)'4',
    SettlementPrice = (byte)'6',
    TradingSessionHighPrice = (byte)'7',
    TradingSessionLowPrice = (byte)'8',
    Vwap = (byte)'9',
    ClearedVolume = (byte)'B',
    OpenInterest = (byte)'C',
    ImpliedBid = (byte)'E',
    ImpliedOffer = (byte)'F',
    BookReset = (byte)'J',
    SessionHighBid = (byte)'N',
    SessionLowOffer = (byte)'O',
    FixingPrice = (byte)'W',
    ElectronicVolume = (byte)'e',
    ThresholdLimitsandPriceBandVariation = (byte)'g',
};

/// <summary>
///  Md Entry Type Book Values
/// </summary>
public enum MdEntryTypeBook : byte {
    Bid = (byte)'0',
    Offer = (byte)'1',
    ImpliedBid = (byte)'E',
    ImpliedOffer = (byte)'F',
    BookReset = (byte)'J',
};

/// <summary>
///  Md Entry Type Daily Statistics Values
/// </summary>
public enum MdEntryTypeDailyStatistics : byte {
    SettlementPrice = (byte)'6',
    ClearedVolume = (byte)'B',
    OpenInterest = (byte)'C',
    FixingPrice = (byte)'W',
};

/// <summary>
///  Md Entry Type Statistics Values
/// </summary>
public enum MdEntryTypeStatistics : byte {
    OpenPrice = (byte)'4',
    HighTrade = (byte)'7',
    LowTrade = (byte)'8',
    Vwap = (byte)'9',
    HighestBid = (byte)'N',
    LowestOffer = (byte)'O',
};

/// <summary>
///  Md Security Trading Status Values
/// </summary>
public enum MdSecurityTradingStatus : byte {
    NoValue = 255,
    TradingHalt = 2,
    Close = 4,
    NewPriceIndication = 15,
    ReadyToTrade = 17,
    NotAvailableForTrading = 18,
    UnknownorInvalid = 20,
    PreOpen = 21,
    PreCross = 24,
    Cross = 25,
    PostClose = 26,
    NoChange = 103,
    PrivateWorkup = 201,
    PublicWorkup = 202,
};

/// <summary>
///  Md Stream Id Values
/// </summary>
public enum MdStreamId : byte {
    NoValue = 255,
    MarketPlaceAssistant = 0,
    Globex = 1,
    Refinitiv = 2,
    Icap = 3,
};

/// <summary>
///  Md Update Action Values
/// </summary>
public enum MdUpdateAction : byte {
    New = 0,
    Change = 1,
    Delete = 2,
    DeleteThru = 3,
    DeleteFrom = 4,
    Overlay = 5,
};

/// <summary>
///  Money Or Par Values
/// </summary>
public enum MoneyOrPar : byte {
    NoValue = 255,
    Money = 1,
    Par = 2,
};

/// <summary>
///  Open Close Settl Flag Values
/// </summary>
public enum OpenCloseSettlFlag : byte {
    NoValue = 255,
    DailyOpenPrice = 0,
    IndicativeOpeningPrice = 5,
    IntradayVwap = 100,
    RepoAverage830Am = 101,
    RepoAverage10Am = 102,
    PrevSessionRepoAverage10Am = 103,
};

/// <summary>
///  Order Update Action Values
/// </summary>
public enum OrderUpdateAction : byte {
    New = 0,
    Update = 1,
    Delete = 2,
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = 0,
    Call = 1,
};

/// <summary>
///  Repo Sub Type Values
/// </summary>
public enum RepoSubType : byte {
    Special = 0,
    Gc = 1,
    GcForDbv = 2,
};

/// <summary>
///  Security Alt Id Source Values
/// </summary>
public enum SecurityAltIdSource : byte {
    NoValue = 255,
    Cusip = 1,
    Isin = 4,
};

/// <summary>
///  Security Trading Event Values
/// </summary>
public enum SecurityTradingEvent : byte {
    NoEvent = 0,
    NoCancel = 1,
    ResetStatistics = 4,
    ImpliedMatchingOn = 5,
    ImpliedMatchingOff = 6,
    EndOfWorkup = 7,
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    NoValue = 255,
    TradingHalt = 2,
    Close = 4,
    NewPriceIndication = 15,
    ReadyToTrade = 17,
    NotAvailableForTrading = 18,
    UnknownorInvalid = 20,
    PreOpen = 21,
    PreCross = 24,
    Cross = 25,
    PostClose = 26,
    NoChange = 103,
    PrivateWorkup = 201,
    PublicWorkup = 202,
};

/// <summary>
///  Security Update Action Values
/// </summary>
public enum SecurityUpdateAction : byte {
    Add = (byte)'A',
    Delete = (byte)'D',
    Modify = (byte)'M',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    ChannelReset = 4,
    AdminHeartbeat = 12,
    AdminLogin = 15,
    AdminLogout = 16,
    SecurityStatus = 30,
    MdIncrementalRefreshVolume = 37,
    QuoteRequest = 39,
    MdIncrementalRefreshBook = 46,
    MdIncrementalRefreshOrderBook = 47,
    MdIncrementalRefreshTradeSummary = 48,
    MdIncrementalRefreshDailyStatistics = 49,
    MdIncrementalRefreshLimitsBanding = 50,
    MdIncrementalRefreshSessionStatistics = 51,
    SnapshotFullRefresh = 52,
    SnapshotFullRefreshOrderBook = 53,
    MdInstrumentDefinitionFuture = 54,
    MdInstrumentDefinitionOption = 55,
    MdInstrumentDefinitionSpread = 56,
    MdInstrumentDefinitionFixedIncome = 57,
    MdInstrumentDefinitionRepo = 58,
    SnapshotRefreshTopOrders = 59,
    SecurityStatusWorkup = 60,
    SnapshotFullRefreshTcp = 61,
    CollateralMarketValue = 62,
};

/// <summary>
///  Underlying Security Alt Id Source Values
/// </summary>
public enum UnderlyingSecurityAltIdSource : byte {
    NoValue = 255,
    Cusip = 1,
    Isin = 4,
};

/// <summary>
///  Workup Trading Status Values
/// </summary>
public enum WorkupTradingStatus : byte {
    ReadyToTrade = 17,
    NotAvailableForTrading = 18,
    PrivateWorkup = 201,
    PublicWorkup = 202,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Admin Login
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogin {
    public sbyte HeartBtInt;
};

/// <summary>
///  Struct for Admin Logout
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogout {
    public fixed sbyte Text[180];
};

/// <summary>
///  Struct for Binary Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BinaryPacketHeader {
    public uint MessageSequenceNumber;
    public ulong SendingTime;
};

/// <summary>
///  Struct for Channel Reset
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ChannelReset {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
};

/// <summary>
///  Struct for Channel Reset Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ChannelResetGroup {
    public short ApplId;
};

/// <summary>
///  Struct for Channel Reset Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ChannelResetGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Collateral Market Value
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollateralMarketValue {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Collateral Market Value Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollateralMarketValueGroup {
    public fixed sbyte UnderlyingSecurityAltId[12];
    public UnderlyingSecurityAltIdSource UnderlyingSecurityAltIdSource;
    public long CollateralMarketPrice;
    public long DirtyPrice;
    public ulong UnderlyingInstrumentGuid;
    public MdStreamId MdStreamId;
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Collateral Market Value Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollateralMarketValueGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Events Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventsGroup {
    public EventType EventType;
    public ulong EventTime;
};

/// <summary>
///  Struct for Events Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Group Size
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSize {
    public ushort BlockLength;
    public byte NumInGroup;
};

/// <summary>
///  Struct for Group Size 8 Byte
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSize8Byte {
    public ushort BlockLength;
    public fixed byte Padding5[5];
    public byte NumInGroup;
};

/// <summary>
///  Struct for Inst Attrib Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstAttribGroup {
    public fixed byte InstAttribValue[0];
};

/// <summary>
///  Struct for Inst Attrib Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstAttribGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Inst Attrib Value
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstAttribValue {
    public fixed byte Reserved8[8];
    public fixed byte IsAoNInstrument[1];
    public fixed byte InvertedBook[1];
    public fixed byte VariableCabEligible[1];
    public fixed byte TriangulationEligible[1];
    public fixed byte ImpliedMatchingEligibility[1];
    public fixed byte GtOrdersEligibility[1];
    public fixed byte DailyProductEligibility[1];
    public fixed byte VariableProductEligibility[1];
    public fixed byte DecayingProductEligibility[1];
    public fixed byte ZeroPriceOutrightEligible[1];
    public fixed byte RfqCrossEligible[1];
    public fixed byte VolatilityQuotedOption[1];
    public fixed byte IsFractional[1];
    public fixed byte NegativePriceOutrightEligible[1];
    public fixed byte NegativeStrikeEligible[1];
    public fixed byte ILinkIndicativeMassQuotingEligible[1];
    public fixed byte OtcEligible[1];
    public fixed byte EfrEligible[1];
    public fixed byte EfsEligible[1];
    public fixed byte EbfEligible[1];
    public fixed byte EfpEligible[1];
    public fixed byte BlockTradeEligible[1];
    public fixed byte OrderCrossEligible[1];
    public fixed byte ElectronicMatchEligible[1];
};

/// <summary>
///  Struct for Lot Type Rules Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LotTypeRulesGroup {
    public sbyte LotType;
    public int MinLotSize;
};

/// <summary>
///  Struct for Lot Type Rules Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LotTypeRulesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Feed Types Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDFeedTypesGroup {
    public fixed sbyte MdFeedType[3];
    public sbyte MarketDepth;
};

/// <summary>
///  Struct for M D Feed Types Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDFeedTypesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Book Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshBookGroup {
    public long MdEntryPxOptional;
    public int MdEntrySizeOptional;
    public int SecurityId;
    public uint RptSeq;
    public int NumberOfOrdersOptional;
    public byte MdPriceLevel;
    public MdUpdateAction MdUpdateAction;
    public MdEntryTypeBook MdEntryTypeBook;
    public int TradeableSize;
    public fixed byte Padding1[1];
};

/// <summary>
///  Struct for M D Incremental Refresh Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshBookGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Book Order Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshBookOrderGroup {
    public ulong OrderId;
    public ulong MdOrderPriorityOptional;
    public int MdDisplayQtyOptional;
    public byte ReferenceId;
    public OrderUpdateAction OrderUpdateAction;
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for M D Incremental Refresh Book Order Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshBookOrderGroups {
    public fixed byte GroupSize8Byte[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Daily Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshDailyStatisticsGroup {
    public long MdEntryPxOptional;
    public int MdEntrySizeOptional;
    public int SecurityId;
    public uint RptSeq;
    public ushort TradingReferenceDate;
    public fixed byte SettlPriceType[0];
    public MdUpdateAction MdUpdateAction;
    public MdEntryTypeDailyStatistics MdEntryTypeDailyStatistics;
    public fixed byte Padding7[7];
};

/// <summary>
///  Struct for M D Incremental Refresh Daily Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshDailyStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Limits Banding Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshLimitsBandingGroup {
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
    public int SecurityId;
    public uint RptSeq;
};

/// <summary>
///  Struct for M D Incremental Refresh Limits Banding Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshLimitsBandingGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Order Book Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshOrderBookGroup {
    public ulong OrderIdOptional;
    public ulong MdOrderPriorityOptional;
    public long MdEntryPxOptional;
    public int MdDisplayQtyOptional;
    public int SecurityId;
    public MdUpdateAction MdUpdateAction;
    public MdEntryTypeBook MdEntryTypeBook;
    public fixed byte Padding6[6];
};

/// <summary>
///  Struct for M D Incremental Refresh Order Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshOrderBookGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Session Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSessionStatisticsGroup {
    public long MdEntryPx;
    public int SecurityId;
    public uint RptSeq;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public MdUpdateAction MdUpdateAction;
    public MdEntryTypeStatistics MdEntryTypeStatistics;
    public int MdEntrySizeOptional;
    public fixed byte Padding1[1];
};

/// <summary>
///  Struct for M D Incremental Refresh Session Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSessionStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Summary Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeSummaryGroup {
    public long MdEntryPx;
    public int MdEntrySize;
    public int SecurityId;
    public uint RptSeq;
    public int NumberOfOrders;
    public AggressorSide AggressorSide;
    public MdUpdateAction MdUpdateAction;
    public uint MdTradeEntryId;
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Summary Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeSummaryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Summary Order Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeSummaryOrderGroup {
    public ulong OrderId;
    public int LastQty;
    public fixed byte Padding4[4];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Summary Order Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeSummaryOrderGroups {
    public fixed byte GroupSize8Byte[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Volume Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshVolumeGroup {
    public int MdEntrySize;
    public int SecurityId;
    public uint RptSeq;
    public MdUpdateAction MdUpdateAction;
    public fixed byte Padding3[3];
};

/// <summary>
///  Struct for M D Incremental Refresh Volume Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshVolumeGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Instrument Definition Spread Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDInstrumentDefinitionSpreadLegGroup {
    public int LegSecurityId;
    public LegSide LegSide;
    public sbyte LegRatioQty;
    public long LegPrice;
    public int LegOptionDelta;
};

/// <summary>
///  Struct for M D Instrument Definition Spread Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDInstrumentDefinitionSpreadLegGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Match Event Indicator
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MatchEventIndicator {
    public fixed byte EndOfEvent[1];
    public fixed byte Reserved[1];
    public fixed byte RecoveryMsg[1];
    public fixed byte LastImpliedMsg[1];
    public fixed byte LastStatsMsg[1];
    public fixed byte LastQuoteMsg[1];
    public fixed byte LastVolumeMsg[1];
    public fixed byte LastTradeMsg[1];
};

/// <summary>
///  Struct for Maturity Month Year
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MaturityMonthYear {
    public ushort Year;
    public byte Month;
    public byte Day;
    public byte Week;
};

/// <summary>
///  Struct for Md Incremental Refresh Daily Statistics
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshDailyStatistics {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Limits Banding
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshLimitsBanding {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Order Book
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOrderBook {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Session Statistics
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSessionStatistics {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Volume
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshVolume {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ushort MessageSize;
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte BinaryPacketHeader[0];
};

/// <summary>
///  Struct for Quote Request
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequest {
    public ulong TransactTime;
    public fixed sbyte QuoteReqId[23];
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding3[3];
};

/// <summary>
///  Struct for Related Instruments Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedInstrumentsGroup {
    public int RelatedSecurityId;
    public fixed sbyte RelatedSymbol[20];
};

/// <summary>
///  Struct for Related Instruments Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedInstrumentsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Related Sym Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroup {
    public fixed sbyte Symbol[20];
    public int SecurityId;
    public int OrderQty;
    public sbyte QuoteType;
    public sbyte SideOptional;
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Related Sym Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Security Status
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatus {
    public ulong TransactTime;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte Asset[6];
    public int SecurityIdOptional;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public SecurityTradingStatus SecurityTradingStatus;
    public HaltReason HaltReason;
    public SecurityTradingEvent SecurityTradingEvent;
};

/// <summary>
///  Struct for Security Status Workup
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusWorkup {
    public ulong TransactTime;
    public long MdEntryPxOptional;
    public int SecurityId;
    public fixed byte MatchEventIndicator[0];
    public ushort TradeDate;
    public uint TradeLinkId;
    public WorkupTradingStatus WorkupTradingStatus;
    public HaltReason HaltReason;
    public SecurityTradingEvent SecurityTradingEvent;
};

/// <summary>
///  Struct for Security Status Workup Order Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusWorkupOrderGroup {
    public ulong OrderId;
    public Side Side;
    public AggressorIndicator AggressorIndicator;
};

/// <summary>
///  Struct for Security Status Workup Order Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatusWorkupOrderGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Settl Price Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlPriceType {
    public fixed byte NullValue[1];
    public fixed byte ReservedBits[3];
    public fixed byte Intraday[1];
    public fixed byte Rounded[1];
    public fixed byte Actual[1];
    public fixed byte FinalDaily[1];
};

/// <summary>
///  Struct for Snapshot Full Refresh
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefresh {
    public uint LastMsgSeqNumProcessed;
    public uint TotNumReports;
    public int SecurityId;
    public uint RptSeq;
    public ulong TransactTime;
    public ulong LastUpdateTime;
    public ushort TradeDate;
    public MdSecurityTradingStatus MdSecurityTradingStatus;
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
};

/// <summary>
///  Struct for Snapshot Full Refresh Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshGroup {
    public long MdEntryPxOptional;
    public int MdEntrySizeOptional;
    public int NumberOfOrdersOptional;
    public sbyte MdPriceLevelOptional;
    public ushort TradingReferenceDate;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public fixed byte SettlPriceType[0];
    public MdEntryType MdEntryType;
};

/// <summary>
///  Struct for Snapshot Full Refresh Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Snapshot Full Refresh Order Book
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBook {
    public uint LastMsgSeqNumProcessed;
    public uint TotNumReports;
    public int SecurityId;
    public uint NoChunks;
    public uint CurrentChunk;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Snapshot Full Refresh Order Book Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBookGroup {
    public ulong OrderId;
    public ulong MdOrderPriorityOptional;
    public long MdEntryPx;
    public int MdDisplayQty;
    public MdEntryTypeBook MdEntryTypeBook;
};

/// <summary>
///  Struct for Snapshot Full Refresh Order Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBookGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Snapshot Full Refresh Tcp
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshTcp {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public int SecurityId;
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
};

/// <summary>
///  Struct for Snapshot Full Refresh Tcp Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshTcpGroup {
    public long MdEntryPxOptional;
    public int MdEntrySizeOptional;
    public int TradeableSize;
    public int NumberOfOrdersOptional;
    public sbyte MdPriceLevelOptional;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public MdEntryType MdEntryType;
    public ushort TradingReferenceDate;
    public fixed byte SettlPriceType[0];
};

/// <summary>
///  Struct for Snapshot Full Refresh Tcp Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshTcpGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Snapshot Refresh Top Orders
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotRefreshTopOrders {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public int SecurityId;
};

/// <summary>
///  Struct for Snapshot Refresh Top Orders Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotRefreshTopOrdersGroup {
    public ulong OrderId;
    public ulong MdOrderPriority;
    public long MdEntryPx;
    public int MdDisplayQty;
    public MdEntryTypeBook MdEntryTypeBook;
};

/// <summary>
///  Struct for Snapshot Refresh Top Orders Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotRefreshTopOrdersGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Underlyings Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingsGroup {
    public int UnderlyingSecurityId;
    public fixed sbyte UnderlyingSymbol[20];
};

/// <summary>
///  Struct for Underlyings Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingsGroups {
    public fixed byte GroupSize[0];
};

