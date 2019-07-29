// C# Structs For Cme Sbe Streamline 9.5 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    AggressorSide = 0,
    AggressorSide = 1,
    AggressorSide = 2,
};

/// <summary>
///  Md Entry Code Values
/// </summary>
public enum MdEntryCode : byte {
    MdEntryCode = 1,
    MdEntryCode = 2,
    MdEntryCode = 3,
    MdEntryCode = 4,
    MdEntryCode = 5,
};

/// <summary>
///  Md Update Action Values
/// </summary>
public enum MdUpdateAction : byte {
    MdUpdateAction = 0,
    MdUpdateAction = 1,
    MdUpdateAction = 2,
    MdUpdateAction = 3,
    MdUpdateAction = 4,
    MdUpdateAction = 5,
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
    AdminHeartbeat = 312,
    AdminLogin = 315,
    AdminLogout = 316,
    MdIncrementalRefreshErisReferenceDataAndDailyStatistics = 333,
    MdNewsIndices = 339,
    MdIncrementalRefreshTradeBlocks = 340,
    QuoteRequest = 345,
    MdInstrumentDefinitionIndices = 347,
    MdIncrementalRefreshIndices = 348,
    MdIncrementalRefreshTradeBlocks = 349,
    MdIncrementalRefreshEris = 351,
    MdIncrementalRefreshEris = 353,
    MdIncrementalRefreshOtc = 356,
    MdInstrumentDefinitionEris = 363,
    MdIncrementalRefreshTradeBlocks = 365,
    MdIncrementalRefreshOtc = 366,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Admin Login 315
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogin315 {
    public sbyte HeartBtInt;
};

/// <summary>
///  Struct for Admin Logout 316
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdminLogout316 {
    public fixed sbyte Text[180];
};

/// <summary>
///  Struct for Events Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventsGroup {
    public byte EventType;
    public ulong EventTime;
};

/// <summary>
///  Struct for Events Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventsGroups {
    public fixed byte GroupSizeEncoding[0];
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
///  Struct for Group Size Encoding
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSizeEncoding {
    public ushort BlockLength;
    public byte NumInGroup;
};

/// <summary>
///  Struct for Inst Attrib Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstAttribGroup {
    public byte InstAttribType;
    public fixed sbyte InstAttribValue[100];
};

/// <summary>
///  Struct for Inst Attrib Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstAttribGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Legs Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegsGroup {
    public fixed sbyte LegBenchmarkCurveName[5];
    public fixed sbyte RateDescriptor[8];
    public ushort PreviousFixingDate;
    public fixed sbyte LegPayFrequencey[3];
    public long PreviousFixingRate;
    public fixed sbyte LegSymbol[50];
    public int LegRatioQty;
    public byte LegSide;
    public fixed sbyte LegCurrency[3];
    public fixed sbyte LegSecurityType[8];
    public fixed sbyte LegSecurityGroup[12];
    public sbyte LegDateOffset;
    public long InterpolationFactor;
};

/// <summary>
///  Struct for Legs Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Lines Of Text Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LinesOfTextGroup {
    public fixed sbyte Text[180];
};

/// <summary>
///  Struct for Lines Of Text Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LinesOfTextGroups {
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
    public fixed sbyte MdFeedType[2];
    public byte MarketDepth;
};

/// <summary>
///  Struct for MD Feed Types Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdFeedTypesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Eris 351
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshEris351 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for Md Incremental Refresh Eris 353
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshEris353 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for MD Incremental Refresh Eris Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisGroup {
    public MdUpdateAction MdUpdateAction;
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public long CalFutPx;
    public int MdEntryPositionNo;
    public int NumberOfOrders;
    public int TradeId;
    public AggressorSide AggressorSide;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup[12];
    public fixed sbyte SecurityType[4];
    public fixed sbyte SecurityExchange[4];
    public sbyte Product;
    public ushort MaturityDate;
    public fixed sbyte ReferenceId[50];
};

/// <summary>
///  Struct for MD Incremental Refresh Eris Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Eris Reference Data And Daily Statistics 333
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatistics333 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for MD Incremental Refresh Eris Reference Data And Daily Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup {
    public MdUpdateAction MdUpdateAction;
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public long MdEntryPx;
    public byte OpenCloseSettlFlag;
    public fixed byte SettlPriceType[0];
    public long CalFutPx;
    public fixed sbyte ReferenceId[50];
    public ulong MdEntrySize;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup[12];
    public sbyte Product;
    public fixed sbyte SecurityType[4];
    public fixed sbyte SecurityExchange[4];
    public ushort MaturityDate;
    public int CouponRate;
    public ushort TradeDate;
    public long FairCouponPct;
    public long LegPurchaseRate;
    public long FixedNpv;
    public long FloatNpv;
    public long Npv;
    public long AccruedCoupons;
    public long DailyIncrementalErisPai;
    public long ErisPai;
    public long FedFundsRate;
    public long MinPriceIncrement;
    public long FixedPayment;
    public long FloatingPayment;
    public ushort NextFixedPaymentDate;
    public long NextFixedPaymentAmount;
    public long NextFloatingPaymentAmount;
    public ushort TradingReferenceDate;
    public long PreviousErisPai;
    public ushort FedFundsDate;
    public uint AccrualDays;
    public ulong Nominal;
    public fixed sbyte LegCreditRating[6];
    public long LegContractMultiplier;
    public ushort NextFloatingPaymentDate;
    public long Pv01;
    public long Dv01;
    public long SettlementNpv;
    public long FinalSettlementFuturesPrice;
    public fixed sbyte SecurityDescription[30];
};

/// <summary>
///  Struct for MD Incremental Refresh Eris Reference Data And Daily Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Indices 348
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshIndices348 {
    public ulong TransactTime;
    public fixed sbyte MdFeedType[2];
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for MD Incremental Refresh Indices Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshIndicesGroup {
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public fixed sbyte Symbol[50];
    public byte OpenCloseSettlFlag;
    public fixed sbyte YieldType[8];
    public long Yield;
    public long NetChgPrevDay;
    public long NetPctChg;
    public long PercentTrading;
    public MdEntryCode MdEntryCode;
    public int MdEntryDate;
    public int MdEntryTime;
    public fixed sbyte ReferenceId[50];
};

/// <summary>
///  Struct for MD Incremental Refresh Indices Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshIndicesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Ot C 356
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtC356 {
    public ulong TransactTime;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for Md Incremental Refresh Ot C 366
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtC366 {
    public ulong TransactTime;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for MD Incremental Refresh Otc Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtcGroup {
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup[12];
    public fixed sbyte SecurityType[4];
    public fixed byte MaturityMonthYear[0];
    public fixed sbyte SecurityExchange[4];
    public sbyte Product;
    public ushort MaturityDate;
    public int CouponRate;
    public fixed sbyte RestructuringType[2];
    public fixed sbyte Seniority[2];
    public int NotionalPercentageOutstanding;
    public byte PutOrCall;
    public long StrikePrice;
    public fixed sbyte UnitOfMeasure[5];
    public fixed sbyte UnitOfMeasureCurrency[3];
    public long UnitOfMeasureQty;
    public int MdEntryDate;
    public byte OpenCloseSettlFlag;
    public ushort PriceType;
    public ushort SettlDate;
    public fixed sbyte QuoteCondition[1];
    public fixed sbyte MarketSector[26];
    public fixed sbyte SectorGroup[2];
    public fixed sbyte SectorSubGroup[26];
    public fixed sbyte ProductComplex[26];
    public fixed sbyte SecuritySubType[2];
    public ushort VolType;
    public fixed sbyte ReferenceId[50];
};

/// <summary>
///  Struct for MD Incremental Refresh Otc Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtcGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Trade Blocks 340
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocks340 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
};

/// <summary>
///  Struct for Md Incremental Refresh Trade Blocks 349
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocks349 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
    public ushort TradeDate;
};

/// <summary>
///  Struct for Md Incremental Refresh Trade Blocks 365
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocks365 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
    public ushort TradeDate;
};

/// <summary>
///  Struct for MD Incremental Refresh Trade Blocks Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocksGroup {
    public MdUpdateAction MdUpdateAction;
    public ulong SecurityId;
    public uint RptSeq;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public int NumberOfOrders;
    public int TradeId;
    public AggressorSide AggressorSide;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup[12];
    public fixed sbyte SecurityType[4];
    public fixed sbyte SecuritySubType[2];
    public fixed byte MaturityMonthYear[0];
    public fixed sbyte SecurityExchange[4];
    public ushort MaturityDate;
    public fixed sbyte UnitOfMeasure[5];
    public fixed sbyte UnitOfMeasureCurrency[3];
    public long UnitOfMeasureQty;
    public int CouponRate;
    public ushort PriceType;
    public byte TrdType;
    public fixed sbyte MdEntryId[26];
    public byte PutOrCall;
    public long StrikePrice;
    public fixed sbyte RestructuringType[2];
    public fixed sbyte Seniority[2];
    public fixed sbyte ReferenceId[50];
    public fixed sbyte StrategyLinkId[26];
    public fixed sbyte LegRefId[17];
};

/// <summary>
///  Struct for MD Incremental Refresh Trade Blocks Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocksGroups {
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
///  Struct for Quote Request 345
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequest345 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed sbyte QuoteReqId[26];
};

/// <summary>
///  Struct for Related Sym Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroup {
    public fixed sbyte Symbol[50];
};

/// <summary>
///  Struct for Related Sym Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RelatedSymGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Security Alt Id Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityAltIdGroup {
    public fixed sbyte SecurityAltId[26];
    public fixed sbyte SecurityAltIdSource[1];
};

/// <summary>
///  Struct for Security Alt Id Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityAltIdGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Settl Price Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlPriceType {
    public fixed byte NullValue[1];
    public fixed byte ReservedBits[4];
    public fixed byte Rounded[1];
    public fixed byte Actual[1];
    public fixed byte FinalDaily[1];
};

