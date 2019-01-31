// C# Structs For Cme Sbe Mdp3 9.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    AggressorSide = "0",
    AggressorSide = "1",
    AggressorSide = "2",
};

/// <summary>
///  Event Type Values
/// </summary>
public enum EventType : byte {
    EventType = "5",
    EventType = "7",
};

/// <summary>
///  Halt Reason Values
/// </summary>
public enum HaltReason : byte {
    HaltReason = "0",
    HaltReason = "1",
    HaltReason = "2",
    HaltReason = "3",
    HaltReason = "4",
    HaltReason = "5",
    HaltReason = "6",
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    LegSide = "1",
    LegSide = "2",
};

/// <summary>
///  Md Entry Type Values
/// </summary>
public enum MdEntryType : byte {
    MdEntryType = (byte)'0',
    MdEntryType = (byte)'1',
    MdEntryType = (byte)'2',
    MdEntryType = (byte)'4',
    MdEntryType = (byte)'6',
    MdEntryType = (byte)'7',
    MdEntryType = (byte)'8',
    MdEntryType = (byte)'B',
    MdEntryType = (byte)'C',
    MdEntryType = (byte)'E',
    MdEntryType = (byte)'F',
    MdEntryType = (byte)'J',
    MdEntryType = (byte)'N',
    MdEntryType = (byte)'O',
    MdEntryType = (byte)'W',
    MdEntryType = (byte)'e',
    MdEntryType = (byte)'g',
};

/// <summary>
///  Md Update Action Values
/// </summary>
public enum MdUpdateAction : byte {
    MdUpdateAction = "0",
    MdUpdateAction = "1",
    MdUpdateAction = "2",
    MdUpdateAction = "3",
    MdUpdateAction = "4",
    MdUpdateAction = "5",
};

/// <summary>
///  Open Close Settl Flag Values
/// </summary>
public enum OpenCloseSettlFlag : byte {
    OpenCloseSettlFlag = "0",
    OpenCloseSettlFlag = "5",
};

/// <summary>
///  Order Update Action Values
/// </summary>
public enum OrderUpdateAction : byte {
    OrderUpdateAction = "0",
    OrderUpdateAction = "1",
    OrderUpdateAction = "2",
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    PutOrCall = "0",
    PutOrCall = "1",
};

/// <summary>
///  Security Trading Event Values
/// </summary>
public enum SecurityTradingEvent : byte {
    SecurityTradingEvent = "0",
    SecurityTradingEvent = "1",
    SecurityTradingEvent = "4",
    SecurityTradingEvent = "5",
    SecurityTradingEvent = "6",
};

/// <summary>
///  Security Trading Status Values
/// </summary>
public enum SecurityTradingStatus : byte {
    SecurityTradingStatus = "2",
    SecurityTradingStatus = "4",
    SecurityTradingStatus = "15",
    SecurityTradingStatus = "17",
    SecurityTradingStatus = "18",
    SecurityTradingStatus = "20",
    SecurityTradingStatus = "21",
    SecurityTradingStatus = "24",
    SecurityTradingStatus = "25",
    SecurityTradingStatus = "26",
    SecurityTradingStatus = "103",
};

/// <summary>
///  Security Update Action Values
/// </summary>
public enum SecurityUpdateAction : byte {
    SecurityUpdateAction = (byte)'A',
    SecurityUpdateAction = (byte)'D',
    SecurityUpdateAction = (byte)'M',
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    ChannelReset = "4",
    AdminHeartbeat = "12",
    AdminLogin = "15",
    AdminLogout = "16",
    MdInstrumentDefinitionFuture = "27",
    MdInstrumentDefinitionSpread = "29",
    SecurityStatus = "30",
    MdIncrementalRefreshBook = "32",
    MdIncrementalRefreshDailyStatistics = "33",
    MdIncrementalRefreshLimitsBanding = "34",
    MdIncrementalRefreshSessionStatistics = "35",
    MdIncrementalRefreshVolume = "37",
    SnapshotFullRefresh = "38",
    QuoteRequest = "39",
    MdInstrumentDefinitionOption = "41",
    MdIncrementalRefreshTradeSummary = "42",
    MdIncrementalRefreshOrderBook = "43",
    SnapshotFullRefreshOrderBook = "44",
    MdIncrementalRefreshBook = "46",
    MdIncrementalRefreshOrderBook = "47",
    MdIncrementalRefreshTradeSummary = "48",
    MdIncrementalRefreshDailyStatistics = "49",
    MdIncrementalRefreshLimitsBanding = "50",
    MdIncrementalRefreshSessionStatistics = "51",
    SnapshotFullRefresh = "52",
    SnapshotFullRefreshOrderBook = "53",
    MdInstrumentDefinitionFuture = "54",
    MdInstrumentDefinitionOption = "55",
    MdInstrumentDefinitionSpread = "56",
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Admin Login 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogin15 {
    public sbyte HeartBtInt;
};

/// <summary>
///  Struct for Admin Logout 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogout16 {
    public fixed sbyte Text[180];
};

/// <summary>
///  Struct for Channel Reset 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ChannelReset4 {
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
///  Struct for Group Size8 Byte
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
    public fixed byte Reserved10[10];
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
///  Struct for Legs Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegsGroup {
    public int LegSecurityId;
    public LegSide LegSide;
    public sbyte LegRatioQty;
    public long LegPrice;
    public int LegOptionDelta;
};

/// <summary>
///  Struct for Legs Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegsGroups {
    public fixed byte GroupSize[0];
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
///  Struct for MD Feed Types Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdFeedTypesGroup {
    public fixed sbyte MdFeedType[3];
    public sbyte MarketDepth;
};

/// <summary>
///  Struct for MD Feed Types Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdFeedTypesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for MD Incremental Refresh Book Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshBookGroup {
    public long MdEntryPx;
    public int MdEntrySize;
    public int SecurityId;
    public uint RptSeq;
    public int NumberOfOrders;
    public byte MdPriceLevel;
    public MdUpdateAction MdUpdateAction;
    public MdEntryType MdEntryType;
    public fixed byte Padding5[5];
};

/// <summary>
///  Struct for MD Incremental Refresh Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshBookGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for MD Incremental Refresh Book Order Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshBookOrderGroup {
    public ulong OrderId;
    public ulong MdOrderPriority;
    public int MdDisplayQty;
    public byte ReferenceId;
    public OrderUpdateAction OrderUpdateAction;
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Book Order Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshBookOrderGroups {
    public fixed byte GroupSize8Byte[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Daily Statistics 33
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshDailyStatistics33 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Daily Statistics 49
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshDailyStatistics49 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Daily Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshDailyStatisticsGroup {
    public long MdEntryPx;
    public int MdEntrySize;
    public int SecurityId;
    public uint RptSeq;
    public ushort TradingReferenceDate;
    public fixed byte SettlPriceType[0];
    public MdUpdateAction MdUpdateAction;
    public MdEntryType MdEntryType;
    public fixed byte Padding7[7];
};

/// <summary>
///  Struct for MD Incremental Refresh Daily Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshDailyStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Limits Banding 34
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshLimitsBanding34 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Limits Banding 50
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshLimitsBanding50 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Limits Banding Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshLimitsBandingGroup {
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
    public int SecurityId;
    public uint RptSeq;
};

/// <summary>
///  Struct for MD Incremental Refresh Limits Banding Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshLimitsBandingGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Order Book 43
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOrderBook43 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Order Book 47
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOrderBook47 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Order Book Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOrderBookGroup {
    public ulong OrderId;
    public ulong MdOrderPriority;
    public long MdEntryPx;
    public int MdDisplayQty;
    public int SecurityId;
    public MdUpdateAction MdUpdateAction;
    public MdEntryType MdEntryType;
    public fixed byte Padding6[6];
};

/// <summary>
///  Struct for MD Incremental Refresh Order Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOrderBookGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Session Statistics 35
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSessionStatistics35 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for Md Incremental Refresh Session Statistics 51
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSessionStatistics51 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Session Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSessionStatisticsGroup {
    public long MdEntryPx;
    public int SecurityId;
    public uint RptSeq;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public MdUpdateAction MdUpdateAction;
    public MdEntryType MdEntryType;
    public int MdEntrySize;
    public fixed byte Padding1[1];
};

/// <summary>
///  Struct for MD Incremental Refresh Session Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSessionStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for MD Incremental Refresh Trade Summary Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeSummaryGroup {
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
///  Struct for MD Incremental Refresh Trade Summary Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeSummaryGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for MD Incremental Refresh Trade Summary Order Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeSummaryOrderGroup {
    public ulong OrderId;
    public int LastQty;
    public fixed byte Padding4[4];
};

/// <summary>
///  Struct for MD Incremental Refresh Trade Summary Order Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeSummaryOrderGroups {
    public fixed byte GroupSize8Byte[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Volume 37
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshVolume37 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed byte Padding2[2];
};

/// <summary>
///  Struct for MD Incremental Refresh Volume Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshVolumeGroup {
    public int MdEntrySize;
    public int SecurityId;
    public uint RptSeq;
    public MdUpdateAction MdUpdateAction;
    public fixed byte Padding3[3];
};

/// <summary>
///  Struct for MD Incremental Refresh Volume Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshVolumeGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort MessageSize;
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public uint MessageSequenceNumber;
    public ulong SendingTime;
};

/// <summary>
///  Struct for Quote Request 39
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequest39 {
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
    public sbyte Side;
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
///  Struct for Security Status 30
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityStatus30 {
    public ulong TransactTime;
    public fixed sbyte SecurityGroup[6];
    public fixed sbyte Asset[6];
    public int SecurityId;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public SecurityTradingStatus SecurityTradingStatus;
    public HaltReason HaltReason;
    public SecurityTradingEvent SecurityTradingEvent;
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
///  Struct for Snapshot Full Refresh 38
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefresh38 {
    public uint LastMsgSeqNumProcessed;
    public uint TotNumReports;
    public int SecurityId;
    public uint RptSeq;
    public ulong TransactTime;
    public ulong LastUpdateTime;
    public ushort TradeDate;
    public byte MdSecurityTradingStatus;
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
};

/// <summary>
///  Struct for Snapshot Full Refresh 52
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefresh52 {
    public uint LastMsgSeqNumProcessed;
    public uint TotNumReports;
    public int SecurityId;
    public uint RptSeq;
    public ulong TransactTime;
    public ulong LastUpdateTime;
    public ushort TradeDate;
    public byte MdSecurityTradingStatus;
    public long HighLimitPrice;
    public long LowLimitPrice;
    public long MaxPriceVariation;
};

/// <summary>
///  Struct for Snapshot Full Refresh Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshGroup {
    public long MdEntryPx;
    public int MdEntrySize;
    public int NumberOfOrders;
    public byte MdPriceLevel;
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
///  Struct for Snapshot Full Refresh Order Book 44
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBook44 {
    public uint LastMsgSeqNumProcessed;
    public uint TotNumReports;
    public int SecurityId;
    public uint NoChunks;
    public uint CurrentChunk;
    public ulong TransactTime;
};

/// <summary>
///  Struct for Snapshot Full Refresh Order Book 53
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBook53 {
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
    public ulong MdOrderPriority;
    public long MdEntryPx;
    public int MdDisplayQty;
    public MdEntryType MdEntryType;
};

/// <summary>
///  Struct for Snapshot Full Refresh Order Book Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SnapshotFullRefreshOrderBookGroups {
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

