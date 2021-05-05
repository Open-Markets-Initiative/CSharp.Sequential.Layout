// C# Structs For Cme Futures Sbe Streamline 5.9 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

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
///  Event Type Indices Values
/// </summary>
public enum EventTypeIndices : byte {
    Activation = 5,
    Deletion = 6,
    Modification = 120,
};

/// <summary>
///  Md Entry Code Values
/// </summary>
public enum MdEntryCode : byte {
    NoValue = 255,
    Indicative = 1,
    PreMarket = 2,
    PreliminaryClose = 3,
    SessionClose = 4,
    Close = 5,
};

/// <summary>
///  Md Entry Type Indices Values
/// </summary>
public enum MdEntryTypeIndices : byte {
    Bid = (byte)'0',
    Offer = (byte)'1',
    Trade = (byte)'2',
    IndexValue = (byte)'3',
    OpeningValue = (byte)'4',
    ClosingPrice = (byte)'5',
    SettlementPrice = (byte)'6',
    SessionHighPrice = (byte)'7',
    SessionLowPrice = (byte)'8',
    TradeVolume = (byte)'e',
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
///  Security Update Action Values
/// </summary>
public enum SecurityUpdateAction : byte {
    Add = (byte)'A',
    Delete = (byte)'D',
    Modify = (byte)'M',
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
///  Struct for Accrued Coupons
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AccruedCoupons {
    public long Mantissa;
    public sbyte Exponent;
};

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
///  Struct for Binary Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BinaryPacketHeader {
    public uint MessageSequenceNumber;
    public ulong SendingTime;
};

/// <summary>
///  Struct for Cal Fut Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CalFutPx {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Cal Fut Px Optional
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CalFutPxOptional {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Coupon Rate Optional
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CouponRateOptional {
    public int Mantissa32;
    public sbyte Exponent;
};

/// <summary>
///  Struct for D V 01
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DV01 {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Daily Incremental Eris Pai
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DailyIncrementalErisPai {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Eris Pai
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ErisPai {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Events Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EventsGroup {
    public EventTypeIndices EventTypeIndices;
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
///  Struct for Fair Coupon Pct
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FairCouponPct {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Fed Funds Rate
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FedFundsRate {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Final Settlement Futures Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FinalSettlementFuturesPrice {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Fixed Npv
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FixedNpv {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Fixed Payment
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FixedPayment {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Float Npv
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FloatNpv {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Floating Payment
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FloatingPayment {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Group Size
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSize {
    public ushort BlockLength;
    public byte NumInGroupUint8;
};

/// <summary>
///  Struct for Group Size Encoding
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSizeEncoding {
    public ushort BlockLength;
    public ushort NumInGroup16;
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
///  Struct for Interpolation Factor
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InterpolationFactor {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Leg Contract Multiplier
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegContractMultiplier {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Leg Purchase Rate
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegPurchaseRate {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Lines Of Text Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LinesOfTextGroup {
    public fixed sbyte Text500[500];
};

/// <summary>
///  Struct for Lines Of Text Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LinesOfTextGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Feed Types Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDFeedTypesGroup {
    public fixed sbyte MdFeedType3[3];
    public byte MarketDepth;
};

/// <summary>
///  Struct for M D Feed Types Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDFeedTypesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Eris Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshErisGroup {
    public fixed sbyte MdUpdateActionChar[1];
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public fixed byte MdEntryPxDecimal[0];
    public ulong MdEntrySizeOptional;
    public fixed byte CalFutPx[0];
    public int MdEntryPositionNo;
    public int NumberOfOrders;
    public int TradeId;
    public AggressorSide AggressorSide;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup26[26];
    public fixed sbyte SecurityType[9];
    public fixed sbyte SecurityExchange[4];
    public byte ProductOptional;
    public ushort MaturityDate;
    public fixed sbyte ReferenceId50[50];
};

/// <summary>
///  Struct for M D Incremental Refresh Eris Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshErisGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Eris Reference Data And Daily Statistics Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup {
    public fixed sbyte MdUpdateActionChar[1];
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public fixed byte MdEntryPxDecimalOptional[0];
    public byte OpenCloseSettlFlag;
    public fixed byte SettlPriceType[0];
    public fixed byte CalFutPxOptional[0];
    public fixed sbyte ReferenceId50[50];
    public ulong MdEntrySizeOptional;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup26[26];
    public byte ProductOptional;
    public fixed sbyte SecurityType[9];
    public fixed sbyte SecurityExchange[4];
    public ushort MaturityDate;
    public fixed byte CouponRateOptional[0];
    public ushort TradeDate;
    public fixed byte FairCouponPct[0];
    public fixed byte LegPurchaseRate[0];
    public fixed byte FixedNpv[0];
    public fixed byte FloatNpv[0];
    public fixed byte Npv[0];
    public fixed byte AccruedCoupons[0];
    public fixed byte DailyIncrementalErisPai[0];
    public fixed byte ErisPai[0];
    public fixed byte FedFundsRate[0];
    public fixed byte MinPriceIncrementOptional[0];
    public fixed byte FixedPayment[0];
    public fixed byte FloatingPayment[0];
    public ushort NextFixedPaymentDate;
    public fixed byte NextFixedPaymentAmount[0];
    public fixed byte NextFloatingPaymentAmount[0];
    public ushort TradingReferenceDate;
    public fixed byte PreviousErisPai[0];
    public ushort FedFundsDate;
    public uint AccrualDays;
    public ulong Nominal;
    public fixed sbyte LegCreditRating[6];
    public fixed byte LegContractMultiplier[0];
    public ushort NextFloatingPaymentDate;
    public fixed byte PV01[0];
    public fixed byte DV01[0];
    public fixed byte SettlementNpv[0];
    public fixed byte FinalSettlementFuturesPrice[0];
    public fixed sbyte SecurityDescription[30];
};

/// <summary>
///  Struct for M D Incremental Refresh Eris Reference Data And Daily Statistics Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Indices Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshIndicesGroup {
    public MdEntryTypeIndices MdEntryTypeIndices;
    public uint RptSeq;
    public fixed byte MdEntryPxDecimal[0];
    public ulong MdEntrySizeOptional;
    public fixed sbyte Symbol[50];
    public sbyte OpenCloseSettlFlag;
    public fixed sbyte YieldType[8];
    public fixed byte Yield[0];
    public fixed byte NetChgPrevDay[0];
    public fixed byte NetPctChg[0];
    public fixed byte PercentTrading[0];
    public MdEntryCode MdEntryCode;
    public int MdEntryDate;
    public int MdEntryTime;
    public fixed sbyte ReferenceId50[50];
};

/// <summary>
///  Struct for M D Incremental Refresh Indices Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshIndicesGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Otc Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshOtcGroup {
    public fixed sbyte MdEntryType[1];
    public uint RptSeq;
    public long MdEntryPxOptional;
    public fixed byte MdEntrySize[0];
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup12[12];
    public fixed sbyte SecurityType[9];
    public fixed byte MaturityMonthYear[0];
    public fixed sbyte SecurityExchange[4];
    public byte ProductOptional;
    public ushort MaturityDate;
    public int CouponRate;
    public fixed sbyte RestructuringType[2];
    public fixed sbyte Seniority[2];
    public int NotionalPercentageOutstanding;
    public byte PutOrCall;
    public fixed byte StrikePriceDecimal[0];
    public fixed sbyte UnitOfMeasure[5];
    public fixed sbyte UnitOfMeasureCurrency[3];
    public fixed byte UnitOfMeasureQtyDecimal[0];
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
    public fixed sbyte ReferenceId100[100];
};

/// <summary>
///  Struct for M D Incremental Refresh Otc Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshOtcGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Blocks Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeBlocksGroup {
    public MdUpdateAction MdUpdateAction;
    public ulong SecurityId;
    public uint RptSeq;
    public long MdEntryPxOptional;
    public ulong MdEntrySizeOptional;
    public int NumberOfOrders;
    public int TradeId;
    public AggressorSide AggressorSide;
    public fixed sbyte Symbol[50];
    public fixed sbyte SecurityGroup12[12];
    public fixed sbyte SecurityType[9];
    public fixed sbyte SecuritySubType[2];
    public fixed byte MaturityMonthYear[0];
    public fixed sbyte SecurityExchange4[4];
    public ushort MaturityDate;
    public fixed sbyte UnitOfMeasure[5];
    public fixed sbyte UnitOfMeasureCurrency3[3];
    public long UnitOfMeasureQtyOptional;
    public int CouponRate;
    public ushort PriceType;
    public byte TrdType;
    public fixed sbyte MdEntryId[26];
    public byte PutOrCall;
    public long StrikePrice;
    public fixed sbyte RestructuringType[2];
    public fixed sbyte Seniority[2];
    public fixed sbyte ReferenceId100[100];
    public fixed sbyte StrategyLinkId[26];
    public fixed sbyte LegRefId[17];
};

/// <summary>
///  Struct for M D Incremental Refresh Trade Blocks Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTradeBlocksGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Instrument Definition Eris Leg Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDInstrumentDefinitionErisLegGroup {
    public fixed sbyte LegBenchmarkCurveName[5];
    public fixed sbyte RateDescriptor[8];
    public ushort PreviousFixingDate;
    public fixed sbyte LegPayFrequencey[3];
    public fixed byte PreviousFixingRate[0];
    public fixed sbyte LegSymbol[50];
    public int LegRatioQty;
    public byte LegSide;
    public fixed sbyte LegCurrency[3];
    public fixed sbyte LegSecurityType[8];
    public fixed sbyte LegSecurityGroup[12];
    public sbyte LegDateOffset;
    public fixed byte InterpolationFactor[0];
};

/// <summary>
///  Struct for M D Instrument Definition Eris Leg Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDInstrumentDefinitionErisLegGroups {
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
///  Struct for Md Entry Px Decimal
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdEntryPxDecimal {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Md Entry Px Decimal Optional
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdEntryPxDecimalOptional {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Md Entry Size
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdEntrySize {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Md Incremental Refresh Eris 351
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshEris351 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
};

/// <summary>
///  Struct for Md Incremental Refresh Eris 353
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshEris353 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
};

/// <summary>
///  Struct for Md Incremental Refresh Eris Reference Data And Daily Statistics 333
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatistics333 {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
};

/// <summary>
///  Struct for Md Incremental Refresh Indices 348
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshIndices348 {
    public ulong TransactTime;
    public fixed sbyte MdFeedType[2];
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
};

/// <summary>
///  Struct for Md Incremental Refresh Ot C 356
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtC356 {
    public ulong TransactTime;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
};

/// <summary>
///  Struct for Md Incremental Refresh Ot C 366
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshOtC366 {
    public ulong TransactTime;
    public ushort TradeDate;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessagesOptional;
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
    public ulong TransactTimeOptional;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
    public ushort TradeDate;
};

/// <summary>
///  Struct for Md Incremental Refresh Trade Blocks 365
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTradeBlocks365 {
    public ulong TransactTimeOptional;
    public fixed byte MatchEventIndicator[0];
    public ushort BatchTotalMessages;
    public ushort TradeDate;
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
///  Struct for Min Price Increment
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MinPriceIncrement {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Min Price Increment Optional
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MinPriceIncrementOptional {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Net Chg Prev Day
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NetChgPrevDay {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Net Pct Chg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NetPctChg {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Next Fixed Payment Amount
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NextFixedPaymentAmount {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Next Floating Payment Amount
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NextFloatingPaymentAmount {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Npv
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Npv {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for P V 01
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PV01 {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte BinaryPacketHeader[0];
};

/// <summary>
///  Struct for Percent Trading
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PercentTrading {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Previous Eris Pai
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PreviousErisPai {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Previous Fixing Rate
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PreviousFixingRate {
    public long Mantissa;
    public sbyte Exponent;
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

/// <summary>
///  Struct for Settlement Npv
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlementNpv {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Strike Price Decimal
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrikePriceDecimal {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Unit Of Measure Qty Decimal
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitOfMeasureQtyDecimal {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Yield
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Yield {
    public long Mantissa;
    public sbyte Exponent;
};

