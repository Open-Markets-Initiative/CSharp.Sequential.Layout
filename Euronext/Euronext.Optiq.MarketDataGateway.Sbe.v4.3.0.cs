// C# Structs For Euronext Optiq Sbe MarketDataGateway 4.3.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    StartOfDayMessage = 1101,
    EndOfDayMessage = 1102,
    HealthStatusMessage = 1103,
    TechnicalNotificationMessage = 1106,
    MarketUpdateMessage = 1001,
    OrderUpdateMessage = 1002,
    PriceUpdateMessage = 1003,
    FullTradeInformationMessage = 1004,
    MarketStatusChangeMessage = 1005,
    TimetableMessage = 1006,
    StandingDataMessage = 1007,
    RealTimeIndexMessage = 1008,
    StatisticsMessage = 1009,
    IndexSummaryMessage = 1011,
    StrategyStandingDataMessage = 1012,
    ContractStandingDataMessage = 1013,
    OutrightStandingDataMessage = 1014,
    LongOrderUpdateMessage = 1015,
    LisPackageStructureMessage = 1016,
    ApaQuotesMessage = 1026,
    ApaStandingDataMessage = 1027,
    ApaFullTradeInformationMessage = 1028,
    BfInstrumentReferenceMessage = 1201,
    BfTradeMessage = 1202,
    BfnaVMessage = 1203,
    BfInstrumentSuspensionMessage = 1204,
    StartOfSnapshotMessage = 2101,
    EndOfSnapshotMessage = 2102,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Apa Full Trade Information Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApaFullTradeInformationMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
    public fixed sbyte TradingDateTime[27];
    public fixed sbyte PublicationDateTime[27];
    public byte TradeType;
    public fixed sbyte MifidInstrumentIdType[4];
    public fixed sbyte MifidInstrumentId[12];
    public fixed sbyte MiFidTransactionId[52];
    public fixed sbyte MifidPrice[20];
    public fixed sbyte MifidQuantity[20];
    public fixed sbyte MifidPriceNotation[4];
    public fixed sbyte MifidCurrency[3];
    public fixed sbyte MiFidQtyinMsrmtUnitNotation[25];
    public fixed sbyte MifidQuantityMeasurementUnit[20];
    public fixed sbyte MiFidNotionalAmount[20];
    public fixed sbyte NotionalCurrency[3];
    public fixed sbyte MiFidClearingFlag[5];
    public byte EfficientMmtMarketMechanism;
    public fixed sbyte EfficientMmtTradingMode[1];
    public fixed sbyte EfficientMmtTransactionCategory[1];
    public fixed sbyte EfficientMmtNegotiationIndicator[1];
    public fixed sbyte EfficientMmtAgencyCrossTradeIndicator[1];
    public fixed sbyte EfficientMmtModificationIndicator[1];
    public fixed sbyte EfficientMmtBenchmarkIndicator[1];
    public fixed sbyte EfficientMmtSpecialDividendIndicator[1];
    public fixed sbyte EfficientMmtOffBookAutomatedIndicator[1];
    public fixed sbyte EfficientMmtContributiontoPrice[1];
    public fixed sbyte EfficientMmtAlgorithmicIndicator[1];
    public fixed sbyte EfficientMmtPublicationMode[1];
    public fixed sbyte EfficientMmtPostTradeDeferral[1];
    public fixed sbyte EfficientMmtDuplicativeIndicator[1];
    public fixed sbyte TradeReference[30];
    public ulong OriginalReportTimestamp;
    public uint PriceMultiplier;
    public byte PriceMultiplierDecimals;
    public fixed sbyte Venue[11];
    public fixed sbyte MiFidEmissionAllowanceType[4];
    public fixed sbyte LongTradeReference[52];
};

/// <summary>
///  Struct for Apa Quotes Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApaQuotesMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public fixed sbyte MifidInstrumentIdType[4];
    public fixed sbyte MifidInstrumentId[12];
    public fixed sbyte Mic[4];
    public fixed sbyte Currency[3];
    public fixed sbyte LeiCode[20];
    public ulong EventTime;
    public byte QuoteUpdateType;
    public fixed sbyte MifidPrice[20];
    public fixed sbyte MifidQuantity[20];
};

/// <summary>
///  Struct for Apa Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApaStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public fixed sbyte MifidInstrumentIdType[4];
    public fixed sbyte MifidInstrumentId[12];
    public fixed sbyte FullInstrumentName[102];
    public fixed sbyte Cfi[6];
    public fixed sbyte NotionalCurrency[3];
    public fixed sbyte SecondNotionalCurrency[3];
    public uint PriceMultiplier;
    public byte PriceMultiplierDecimals;
    public fixed sbyte UnderlyingIsinCode[12];
    public fixed sbyte UnderlyingIndexName[25];
    public fixed sbyte UnderlyingIndexTerm[8];
    public byte OptionType;
    public long StrikePrice;
    public byte StrikePriceDecimals;
    public byte ExerStyle;
    public fixed sbyte MaturityDate[8];
    public fixed sbyte ExpiryDate[8];
    public fixed sbyte SettlementMethod[1];
};

/// <summary>
///  Struct for Bf Instrument Reference Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BfInstrumentReferenceMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public byte OptiqSegment;
    public fixed sbyte IsinCode[12];
    public fixed sbyte SedolCode[7];
    public fixed sbyte LongIssuerName[250];
    public fixed sbyte LongInstrumentName[250];
    public fixed sbyte Currency[3];
    public ushort DateOfInitialListing;
    public long ShareAmountInIssue;
    public fixed sbyte OpenedClosedFund[1];
    public long LastNavPrice;
    public fixed sbyte GrossOfCdscIndicator[1];
    public long Coupon;
    public fixed sbyte MaturityDate[8];
    public long ClosingPrice;
    public fixed sbyte Mic[4];
    public long GrossDividendPayablePerUnit;
    public fixed sbyte DividendCurrency[3];
    public ushort DividendRecordDate;
    public ulong DividendRate;
    public ushort ExDividendDate;
    public ushort DividendPaymentDate;
    public fixed sbyte TaxDescriptionAttachingToADividend[1];
    public fixed sbyte NextMeeting[8];
    public long GrossDividendInEuros;
    public ushort IssueDate;
    public fixed sbyte IssuingCountry[3];
    public fixed sbyte Cfi[6];
    public byte PaymentFrequency;
    public long MinimumAmount;
    public byte InstrumentCategory;
    public fixed sbyte SecurityCondition[1];
    public fixed sbyte MifidPriceNotation[4];
    public byte PriceIndexLevelDecimals;
    public byte QuantityDecimals;
    public byte AmountDecimals;
    public byte RatioMultiplierDecimals;
};

/// <summary>
///  Struct for Bf Instrument Suspension Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BfInstrumentSuspensionMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public ulong EventTime;
    public fixed sbyte SecurityCondition[1];
};

/// <summary>
///  Struct for Bf Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BfTradeMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public fixed sbyte MiFidTransactionId[52];
    public ulong EventTime;
    public ulong BidOfferDateTime;
    public fixed sbyte MmtModificationIndicator[4];
    public long Price;
    public long BidPrice;
    public long OfferPrice;
    public ulong Quantity;
    public fixed sbyte MmtAgencyCrossTradeIndicator[4];
    public fixed sbyte MmtBenchmarkIndicator[4];
    public fixed sbyte MmtSpecialDividendIndicator[4];
    public fixed sbyte MmtTradingMode[1];
    public fixed sbyte MifidPriceNotation[4];
    public fixed sbyte QuantityNotation[3];
    public long NotionalAmountTraded;
    public fixed sbyte TradingCurrency[3];
};

/// <summary>
///  Struct for Bfna V Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BfnaVMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public ulong BidOfferDateTime;
    public fixed sbyte MiFidTransactionId[52];
    public fixed sbyte MmtModificationIndicator[4];
    public long NavPrice;
    public ulong EventTime;
    public long NavBidPrice;
    public long NavOfferPrice;
};

/// <summary>
///  Struct for Contract Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContractStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public byte OptiqSegment;
    public ushort PartitionId;
    public ushort ContractEventDate;
    public fixed sbyte ExchangeCode[1];
    public byte ExerStyle;
    public fixed sbyte ContractName[60];
    public fixed sbyte ContractType[1];
    public fixed sbyte UnderlyingType[1];
    public byte PriceDecimals;
    public byte QuantityDecimals;
    public byte AmountDecimals;
    public byte RatioDecimals;
    public fixed sbyte MainDepositary[5];
    public fixed sbyte Mic[4];
    public fixed sbyte CountryOfExchange[3];
    public fixed sbyte ProductCode[4];
    public fixed sbyte UnderlyingMic[4];
    public fixed sbyte UnderlyingIsinCode[12];
    public uint UnderlyingExpiry;
    public ushort OrderTypeRules;
    public fixed sbyte SettlementMethod[1];
    public fixed sbyte TradingCurrency[3];
    public byte StrikePriceDecimalsRatio;
    public byte MmProtections;
    public byte ContractTradingType;
    public byte InstUnitExp;
    public byte UnderlyingSubtype;
    public fixed sbyte MotherStockIsin[12];
    public ulong SettlementTickSize;
    public ulong EdspTickSize;
    public uint UnderlyingSymbolIndex;
    public byte TradingPolicy;
    public ushort ReferenceSpreadTableId;
    public byte DerivativesMarketModel;
    public ulong TradingUnit;
    public byte ReferencePriceOriginInOpeningCall;
    public byte ReferencePriceOriginInContinuous;
    public byte ReferencePriceOriginInTradingInterruption;
    public byte CollarExpansionFactor;
    public byte MifidiiLiquidFlag;
    public byte PricingAlgorithm;
};

/// <summary>
///  Struct for End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMessage {
    public ulong MdSeqNum;
    public ushort SessionTradingDay;
};

/// <summary>
///  Struct for End Of Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSnapshotMessage {
    public ulong LastMdSeqNum;
    public ulong SnapshotTime;
};

/// <summary>
///  Struct for Full Trade Information Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FullTradeInformationMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
    public uint SymbolIndex;
    public fixed sbyte TradingDateTime[27];
    public fixed sbyte PublicationDateTime[27];
    public byte TradeType;
    public fixed sbyte MifidInstrumentIdType[4];
    public fixed sbyte MifidInstrumentId[12];
    public fixed sbyte MifidExecutionId[52];
    public fixed sbyte MifidPrice[20];
    public fixed sbyte MifidQuantity[20];
    public fixed sbyte MifidPriceNotation[4];
    public fixed sbyte MifidCurrency[3];
    public fixed sbyte MiFidQtyinMsrmtUnitNotation[25];
    public fixed sbyte MifidQuantityMeasurementUnit[20];
    public fixed sbyte MiFidNotionalAmount[20];
    public fixed sbyte NotionalCurrency[3];
    public fixed sbyte MiFidClearingFlag[5];
    public byte MmtMarketMechanism;
    public fixed sbyte MmtTradingMode[1];
    public fixed sbyte MmtTransactionCategory[4];
    public fixed sbyte MmtNegotiationIndicator[4];
    public fixed sbyte MmtAgencyCrossTradeIndicator[4];
    public fixed sbyte MmtModificationIndicator[4];
    public fixed sbyte MmtBenchmarkIndicator[4];
    public fixed sbyte MmtSpecialDividendIndicator[4];
    public fixed sbyte MmtOffBookAutomatedIndicator[1];
    public fixed sbyte MmtContributiontoPrice[4];
    public fixed sbyte MmtAlgorithmicIndicator[4];
    public fixed sbyte MmtPublicationMode[4];
    public fixed sbyte MmtPostTradeDeferral[4];
    public fixed sbyte MmtDuplicativeIndicator[4];
    public byte TradeQualifier;
    public byte TransactionType;
    public byte EffectiveDateIndicator;
    public fixed sbyte BlockTradeCode[1];
    public fixed sbyte TradeReference[30];
    public ulong OriginalReportTimestamp;
    public byte TransparencyIndicator;
    public uint CurrencyCoefficient;
    public uint PriceMultiplier;
    public byte PriceMultiplierDecimals;
    public fixed sbyte Venue[11];
    public uint StartTimeVwap;
    public uint EndTimeVwap;
    public fixed sbyte MiFidEmissionAllowanceType[4];
    public fixed sbyte MarketOfReferenceMic[4];
    public long EvaluatedPrice;
    public byte MessagePriceNotation;
    public ushort SettlementDate;
    public ushort RepoSettlementDate;
};

/// <summary>
///  Struct for Health Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HealthStatusMessage {
    public ulong MdSeqNum;
    public ulong EventTime;
};

/// <summary>
///  Struct for Index Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IndexSummaryMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
    public uint SymbolIndex;
    public long OpeningLevel;
    public ulong OpeningTime;
    public long ConfirmedReferenceLevel;
    public ulong ConfirmedReferenceTime;
    public long ClosingReferenceLevel;
    public ulong ClosingReferenceTime;
    public long PrctVarfromPrevClose;
    public long HighLevel;
    public ulong HighTime;
    public long LowLevel;
    public ulong LowTime;
    public long LiquidationLevel;
    public ulong LiquidationTime;
};

/// <summary>
///  Struct for Lis Package Structure Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LisPackageStructureMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
    public uint ContractSymbolIndex;
    public fixed sbyte MifidExecutionId[52];
    public fixed sbyte StrategyCode[1];
};

/// <summary>
///  Struct for Long Order Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongOrderUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Market Data Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketDataPacketHeader {
    public ulong PacketTime;
    public uint PacketSequenceNumber;
    public fixed byte PacketFlags[0];
    public ushort ChannelId;
};

/// <summary>
///  Struct for Market Status Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatusChangeMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
};

/// <summary>
///  Struct for Market Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ushort Frame;
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
///  Struct for Order Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Outright Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public uint ContractSymbolIndex;
    public ushort InstrumentEventDate;
    public fixed sbyte IsinCode[12];
    public fixed sbyte Cfi[6];
    public fixed sbyte MaturityDate[8];
    public ulong LotSize;
    public long StrikePrice;
    public ushort LastTradingDate;
    public ushort DaysToExpiry;
    public fixed sbyte DerivativesInstrumentTradingCode[18];
    public byte DerivativesInstrumentType;
    public byte ExpiryCycleType;
    public fixed sbyte UnderlyingDerivativesInstrumentTradingCode[18];
    public uint UnderlyingSymbolIndex;
    public ulong TradingUnit;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte MarketDataPacketHeader[0];
};

/// <summary>
///  Struct for Packet Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketFlags {
    public fixed byte ReservedBits[6];
    public fixed byte HasStatusMessage[1];
    public fixed byte HasEndOfDaySnapshot[1];
    public fixed byte HasStartOfDaySnapshot[1];
    public fixed byte PsnHighWeight[3];
    public fixed byte MdgRestartCount[3];
    public fixed byte Compression[1];
};

/// <summary>
///  Struct for Price Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriceUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Real Time Index Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RealTimeIndexMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ulong EventTime;
    public uint SymbolIndex;
    public long IndexLevel;
    public ulong PctgOfCapitalization;
    public long PrctVarfromPrevClose;
    public ushort NumTradedInstruments;
    public byte IndexLevelType;
    public byte IndexPriceCode;
};

/// <summary>
///  Struct for Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public byte OptiqSegment;
    public ushort PartitionId;
    public fixed sbyte FullInstrumentName[102];
    public fixed sbyte InstrumentName[18];
    public fixed sbyte InstrumentTradingCode[15];
    public fixed sbyte InstrumentGroupCode[2];
    public fixed sbyte IsinCode[12];
    public byte PriceDecimals;
    public byte QuantityDecimals;
    public byte AmountDecimals;
    public byte RatioDecimals;
    public fixed sbyte Cfi[6];
    public ushort InstrumentEventDate;
    public long StrikePrice;
    public byte DarkEligibility;
    public ulong DarkLisThreshold;
    public uint DarkMinQuantity;
    public ushort DateOfLastTrade;
    public fixed sbyte DepositaryList[20];
    public fixed sbyte MainDepositary[5];
    public ushort FirstSettlementDate;
    public byte GuaranteeIndicator;
    public fixed sbyte Icb[16];
    public fixed sbyte IssuingCountry[3];
    public long LastAdjustedClosingPrice;
    public ulong LotSize;
    public fixed sbyte MaturityDate[8];
    public byte MaximumDecimalsInQuantity;
    public fixed sbyte Mic[4];
    public fixed sbyte MicList[20];
    public fixed sbyte CountryOfExchange[3];
    public fixed sbyte Mnemonic[5];
    public fixed sbyte UnderlyingMic[4];
    public fixed sbyte UnderlyingIsinCode[12];
    public fixed sbyte TradingCurrency[3];
    public uint CurrencyCoefficient;
    public byte TradingCurrencyIndicator;
    public byte StrikeCurrencyIndicator;
    public ulong NumberInstrumentCirculating;
    public ulong ParValue;
    public fixed sbyte QuantityNotation[3];
    public byte InstUnitExp;
    public fixed sbyte SettlementDelay[2];
    public fixed sbyte StrikeCurrency[3];
    public byte TaxCode;
    public fixed sbyte TypeOfCorporateEvent[2];
    public fixed sbyte TypeOfMarketAdmission[1];
    public byte RepoIndicator;
    public long IssuePrice;
    public fixed sbyte NominalCurrency[3];
    public byte IssuePriceDecimals;
    public byte StrikePriceDecimals;
    public byte LiquidInstrumentIndicator;
    public fixed sbyte MarketOfReferenceMic[4];
    public fixed sbyte IcbCode[8];
    public ulong ThresholdLisPostTrade60Mn;
    public ulong ThresholdLisPostTrade120Mn;
    public ulong ThresholdLisPostTradeEod;
};

/// <summary>
///  Struct for Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfDayMessage {
    public ulong MdSeqNum;
    public ushort SessionTradingDay;
};

/// <summary>
///  Struct for Start Of Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfSnapshotMessage {
    public ulong LastMdSeqNum;
    public ulong SnapshotTime;
};

/// <summary>
///  Struct for Statistics Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StatisticsMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
};

/// <summary>
///  Struct for Strategy Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public uint SymbolIndex;
    public fixed sbyte DerivativesInstrumentTradingCode[18];
    public fixed sbyte ExchangeCode[1];
    public fixed sbyte MaturityDate[8];
    public fixed sbyte StrategyCode[1];
    public uint ContractSymbolIndex;
    public fixed sbyte Cfi[6];
};

/// <summary>
///  Struct for Technical Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TechnicalNotificationMessage {
    public ulong MdSeqNum;
    public byte TechnicalNotificationType;
    public byte RebroadcastIndicator;
    public ulong RetransmissionStartTime;
    public ulong RetransmissionEndTime;
    public uint SymbolIndex;
};

/// <summary>
///  Struct for Timetable Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimetableMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public byte Emm;
    public ushort PatternId;
    public uint SymbolIndex;
};

