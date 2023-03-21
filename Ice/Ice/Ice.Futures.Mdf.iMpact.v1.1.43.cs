// C# Structs For Ice Futures iMpact Mdf 1.1.43 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    None = (byte)'',
    Buy = (byte)'1',
    Sell = (byte)'2',
};

/// <summary>
///  Allow Options Values
/// </summary>
public enum AllowOptions : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Allows Implied Values
/// </summary>
public enum AllowsImplied : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Cross Order Supported Values
/// </summary>
public enum CrossOrderSupported : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Endex Status Values
/// </summary>
public enum EndexStatus : byte {
    Current = (byte)'C',
    Default = (byte)'D',
    Final = (byte)'F',
    NonEndexSpotMarket = (byte)'',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    NormalTrade = (byte)'0',
    CancelledTrade = (byte)'1',
    AdjustedTrade = (byte)'2',
};

/// <summary>
///  Event Type Values
/// </summary>
public enum EventType : byte {
    ImplicationDisabledForTheMarket = (byte)'A',
};

/// <summary>
///  Exchange Silo Values
/// </summary>
public enum ExchangeSilo : byte {
    Ice = (byte)'0',
    Endex = (byte)'1',
    Liffe = (byte)'2',
};

/// <summary>
///  Fixing Status Values
/// </summary>
public enum FixingStatus : byte {
    Closed = (byte)'C',
    Preopen = (byte)'P',
    Lockdown = (byte)'L',
};

/// <summary>
///  Flex Allowed Values
/// </summary>
public enum FlexAllowed : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Gt Allowed Values
/// </summary>
public enum GtAllowed : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Guaranteed Cross Supported Values
/// </summary>
public enum GuaranteedCrossSupported : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Has Previous Day Settlement Price Values
/// </summary>
public enum HasPreviousDaySettlementPrice : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Hedge Only Values
/// </summary>
public enum HedgeOnly : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Hedge Side Values
/// </summary>
public enum HedgeSide : byte {
    None = (byte)'',
    Bid = (byte)'1',
    Offer = (byte)'2',
};

/// <summary>
///  Investigation Status Values
/// </summary>
public enum InvestigationStatus : byte {
    UnderInvestigation = (byte)'1',
    InvestigationCompleted = (byte)'2',
};

/// <summary>
///  Ipl Hold Type Values
/// </summary>
public enum IplHoldType : byte {
    IplHoldStart = (byte)'S',
    IplHoldEnd = (byte)'E',
};

/// <summary>
///  Is Balanced Values
/// </summary>
public enum IsBalanced : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Block Only Values
/// </summary>
public enum IsBlockOnly : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Final Values
/// </summary>
public enum IsFinal : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Implied Values
/// </summary>
public enum IsImplied : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Official Values
/// </summary>
public enum IsOfficial : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Rfq Values
/// </summary>
public enum IsRfq : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Settle Price Official Values
/// </summary>
public enum IsSettlePriceOfficial : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is System Priced Leg Values
/// </summary>
public enum IsSystemPricedLeg : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Tradable Values
/// </summary>
public enum IsTradable : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Transaction End Values
/// </summary>
public enum IsTransactionEnd : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Up Values
/// </summary>
public enum IsUp : byte {
    IplUpperBoundViolation = (byte)'Y',
    IplLowerBoundViolation = (byte)'N',
    Final = (byte)'F',
    NonEndexSpotMarket = (byte)'',
};

/// <summary>
///  Leg Deal Suppressed Values
/// </summary>
public enum LegDealSuppressed : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    None = (byte)'',
    Bid = (byte)'1',
    Offer = (byte)'2',
};

/// <summary>
///  Market Type Id Values
/// </summary>
public enum MarketTypeId : short {
    FinancialGas = 0,
    FinancialPower = 1,
    Oil = 2,
    IpeNaturalGasFutures = 3,
    IpeGasOilFutures = 4,
    IpeBrentFutures = 5,
    IpeUkElectricityFuturesPeak = 7,
    IpeUkElectricityFuturesBase = 8,
    IceWtiCrudeFutures = 9,
    GCNewcastleCoalFutures = 10,
    IceBrentWtiFuturesSpread = 11,
    IpeecxEuropeanEmissions = 12,
    IceHeatingOilFutures = 13,
    IceHeatingOilWtiFuturesCrack = 14,
    IceNyhRbobGasolineFutures = 15,
    IceNyhRbobGasolineWtiFuturesCrack = 16,
    IceRotterdamCoalFutures = 17,
    IceRichardsBayCoalFutures = 18,
    IceRotterdamRichardsBayCoalFuturesSpread = 19,
    Cocoa = 20,
    CoffeeC = 21,
    CottonNo2 = 22,
    FcojA = 23,
    SugarNo11 = 24,
    HeatRateSpread = 25,
    UsDollarIndex = 26,
    CanadianOilseeds = 36,
    EcxCerFutures = 38,
    ForeignExchange = 39,
    FinancialIndexData = 40,
    SugarNo16 = 41,
    EcxEuacerFuturesSpread = 42,
    HenryHub = 44,
    DutchTtfGasFutures = 48,
    GermanNaturalGasFutures = 50,
    EuropeanGasSpreads = 51,
    CanadianFinancialGas = 53,
    NgxCanadianPhysicalCrude = 54,
    UsCoalFutures = 55,
    FobIndoSubbitCoalFutures = 57,
    HeatingOilBrentFuturesCrack = 58,
    NyhRbobGasolineBrentFuturesCrack = 59,
    WetFreight = 60,
    DryFreight = 61,
    FerrousMetals = 62,
    PlattsVariableOil = 63,
    NyhRbobGasolineHeatingOilSpread = 66,
    PhysicalEnvironmental = 69,
    HeatingOilLsGasoilFuturesSpread = 70,
    LsGasoilBrentFuturesCrack = 71,
    NyhRbobGasolineLsGasoilFuturesSpread = 72,
    EcxEuaaFutures = 84,
    EcxCereuaaFuturesSpread = 85,
    EcxEuaaeuaFuturesSpread = 86,
    Soybean = 89,
    EcxEuaEibAuction = 92,
    FinancialLng = 93,
    EuaUkAuction = 95,
    EuaaUkAuction = 96,
    CfrSouthChinaCoalFutures = 97,
    BelgianPowerFutures = 98,
    DutchPowerFutures = 99,
    GCNewcastleFobIndoSubbitCoalFuturesSpread = 100,
    RichardsBaygCNewcastleCoalFuturesSpread = 101,
    FcojAMini = 102,
    CifUs = 104,
    D6Rin = 108,
    EuropeanPowerSpreads = 111,
    Taqa = 112,
    BelgianZtpGasSpot = 113,
    DutchTtfGasSpot = 114,
    DutchTtfGasStorage = 115,
    EuropeanGasSpotSpreads = 116,
    BelgianZtpGasFutures = 117,
    UkOcmGasSpot = 118,
    BelgianGasSpreads = 119,
    FinancialOlefins = 124,
    FinancialMonomers = 125,
    PlattsVariableOilUrals = 126,
    EndexSpotMarketIndices = 127,
    InterestRateFutures = 131,
    SingaporeEnergy = 133,
    SingaporeFinancials = 134,
    SingaporeMetals = 135,
    ItalianNaturalGasFutures = 136,
    ItalianPowerFutures = 137,
    CreditSwapData = 139,
    GoldFixing = 140,
    NorthSeaPartials = 141,
    EuFinancialPowerSpreads = 142,
    EuFinancialPowerFutures = 143,
    OilCad = 144,
    SilverFixing = 147,
    UkSparkSpread = 149,
    UkOcmPhysicalGasSpot = 150,
    JapanDomesticWaterborne = 152,
    DailyMetals = 154,
    BrixEnergiaFin = 155,
    JapanDomesticRack = 156,
    FinancialUsLng = 157,
    IceRotterdamNewcastleCoalFuturesSpread = 160,
    OilAmericas = 165,
    PlattsPetrochemical = 167,
    PermianWtiFutures = 168,
    EndexEquityIndices = 170,
    EndexSingleStockOptions = 171,
    IfusIceIndices = 172,
    PlattsAsiaBunker = 173,
    SofrFutures = 177,
    DigitalAssetFutures = 178,
    PermianBrentFuturesSpread = 179,
    PermianWtiFuturesSpread = 180,
    LiffeStiRs = 200,
    LiffeBonds = 202,
    LiffeSwapnotes = 203,
    1 = 205,
    Metals = 206,
    IfusEquityIndices = 207,
    GcfRepo = 208,
    LiffeThreeMonthEuroAndEonia = 209,
    Eurodollar = 210,
    LiffeEquityDerivativesNonUsBased = 211,
    LiffeEquityDerivativesUsBased = 212,
    LiffeIndexOptions = 213,
    LiffeIndexFuturesUsRestricted = 214,
    LiffeIndexFuturesNonUsRestricted = 215,
    PhysicalGas = 305,
    Power = 306,
    NgxPhysicalGas = 314,
    NgxFinancialPower = 315,
    NgxFinancialGas = 316,
    FinancialNgl = 317,
    OlefinsPolymers = 318,
    PhysicalNgl = 319,
    PhysicalOil = 320,
    TestIpe = 600,
    TestNybot = 601,
    TestNdex = 602,
    TestLiffeuk1 = 603,
    TestLiffeuk2 = 604,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    MarketSnapshotMessage = (byte)'C',
    TradeMessage = (byte)'G',
    SpotMarketTradeMessage = (byte)'Y',
    InvestigatedTradeMessage = (byte)'H',
    CancelledTradeMessage = (byte)'I',
    MarketStatisticsMessage = (byte)'J',
    MarketStateChangeMessage = (byte)'K',
    SystemTextMessage = (byte)'L',
    OpenInterestMessage = (byte)'M',
    OpenPriceMessage = (byte)'N',
    ClosePriceMessage = (byte)'c',
    SettlementPriceMessage = (byte)'O',
    IndexPricesMessage = (byte)'z',
    EndOfDayMarketSummaryMessage = (byte)'u',
    MarketEventMessage = (byte)'f',
    PreOpenPriceIndicatorMessage = (byte)'g',
    StripInfoMessage = (byte)'i',
    IntervalPriceLimitNotificationMessage = (byte)'V',
    NewFuturesStrategyDefinitionMessage = (byte)'9',
    NewExpiryMessage = (byte)'R',
    SpecialFieldMessage = (byte)'b',
    FragmentWrapperMessage = (byte)'Z',
    MarketSnapshotOrderMessage = (byte)'D',
    AddOrModifyOrderMessage = (byte)'E',
    DeleteOrderMessage = (byte)'F',
    MessageBundleMarker = (byte)'T',
    FixingTransitionMessage = (byte)'3',
    FixingLockdownMessage = (byte)'4',
    FixingIndicativePriceMessage = (byte)'0',
    MarketSnapshotPriceLevelMessage = (byte)'m',
    AddPriceLevelMessage = (byte)'t',
    ChangePriceLevelMessage = (byte)'s',
    DeletePriceLevelMessage = (byte)'r',
    NewOptionsStrategyDefinitionMessage = (byte)'U',
    NewOptionsMarketDefinitionMessage = (byte)'l',
    RfqMessage = (byte)'k',
    OptionOpenInterestMessage = (byte)'v',
    OptionSettlementPriceMessage = (byte)'w',
    OldStyleOptionsTradeAndMarketStatsMessage = (byte)'W',
};

/// <summary>
///  Mifid Regulated Market Values
/// </summary>
public enum MifidRegulatedMarket : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Call = (byte)'C',
    Put = (byte)'P',
};

/// <summary>
///  Options Expiration Type Values
/// </summary>
public enum OptionsExpirationType : byte {
    Monthly = (byte)'M',
    Daily = (byte)'D',
};

/// <summary>
///  Options Style Values
/// </summary>
public enum OptionsStyle : byte {
    American = (byte)'A',
    European = (byte)'E',
    None = (byte)'0',
    Asian = (byte)'3',
    OneTime = (byte)'4',
};

/// <summary>
///  Security Sub Type Values
/// </summary>
public enum SecuritySubType : short {
    None = 0,
    Call = 1,
    Put = 2,
    FuturesButterfly = 3,
    CallButterfly = 4,
    PutButterfly = 5,
    CallSpread = 6,
    PutSpread = 7,
    DiagonalCallSpread = 9,
    DiagonalPutSpread = 10,
    GutStrangle = 11,
    1X2CallSpreadToThe2 = 12,
    1X2PutSpreadToThe2 = 13,
    IronButterfly = 14,
    Strangle = 16,
    CallLadderTree = 17,
    PutLadderTree = 18,
    StraddleSpread = 19,
    ReversalConversionToTheCall = 21,
    ReversalConversionToThePut = 21,
    Straddle = 22,
    FuturesCondor = 23,
    CallCondor = 24,
    PutCondor = 25,
    Box = 26,
    SyntheticUnderlying = 33,
    CallSpreadVsPut3Way = 34,
    PutSpreadVsCall3Way = 35,
    StraddleVsCall3Way = 36,
    StraddleVsPut3Way = 37,
    CallCalendarSpread = 38,
    PutCalendarSpread = 39,
    IronCondor = 40,
    JellyRoll = 41,
    Hedged1X2CallSpreadToThe2 = 42,
    Hedged1X2PutSpreadToThe2 = 43,
    CallSpreadVersusSellPutHedge = 44,
    PutSpreadVersusSellCallHedge = 45,
    HedgedCallCalendar = 46,
    HedgedPutCalendar = 47,
    HedgedCallLadderTree = 48,
    HedgedPutLadderTree = 49,
    HedgedCallSpread = 50,
    HedgedPutSpread = 51,
    HedgedStraddle = 53,
    HedgedStrangle = 54,
    HedgedCall = 55,
    HedgedPut = 56,
    Custom = 58,
    HedgedStraddleSpread = 59,
    HedgedCallCondor = 60,
    HedgedPutCondor = 61,
    HedgedDiagonalCallSpread = 63,
    HedgedDiagonalPutSpread = 64,
    HedgedCallButterlfy = 65,
    HedgedPutButterlfy = 66,
    HedgedGutsStrangle = 67,
    HedgedIronCondor = 68,
    HedgedIronButterfly = 69,
    FenceToTheCall = 70,
    FenceToThePut = 71,
    HedgedFenceToTheCall = 72,
    HedgedFenceToThePut = 73,
    1X2CallSpreadToThe1 = 74,
    1X2PutSpreadToThe1 = 75,
    Hedged1X2CallSpreadToThe1 = 76,
    Hedged1X2PutSpreadToThe1 = 77,
    DiscountSpreads = 88,
    LocationSpreads = 89,
    PlattsDiffSpread = 90,
    PlattsSpread = 91,
    OtcGasOilCrack = 92,
    BalmoOverMonth = 93,
    RatioSpread = 94,
    VolumetricSpread = 95,
    HeatRate = 96,
    CrackSpread = 97,
    ComboSpread = 98,
    SpreadS = 99,
    PacknoColor = 100,
    PackWhite = 101,
    PackRed = 102,
    PackGreen = 103,
    PackBlue = 104,
    PackGold = 105,
    PackPurple = 106,
    PackOrange = 107,
    PackPink = 108,
    PackSilver = 109,
    PackCopper = 110,
    BundleNoColor = 200,
    Bundle2Yr = 201,
    Bundle3Yr = 202,
    Bundle4Yr = 203,
    Bundle5Yr = 204,
    Bundle6Yr = 205,
    Bundle7Yr = 206,
    Bundle8Yr = 207,
    Bundle9Yr = 208,
    Bundle10Yr = 209,
    Balmo = 400,
    NextDay = 410,
    Cfd = 411,
    Weekend = 412,
    SingleDay = 413,
    CustomDaily = 414,
    Hourly = 415,
    Month = 416,
    Balweek = 450,
    Basket = 500,
    CustomMonthly = 550,
    NextWeek = 600,
    Period = 700,
    CustomDailyCfd = 711,
    CustomDaily7X8 = 712,
    CustomDaily7X16 = 713,
    CustomDaily7X6 = 714,
    CustomDailyOffPeakX16 = 715,
    Quarter = 800,
    Year = 900,
};

/// <summary>
///  Settlement Type Values
/// </summary>
public enum SettlementType : byte {
    Financial = (byte)'0',
    Physical = (byte)'1',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    None = (byte)'',
    Bid = (byte)'1',
    Offer = (byte)'2',
};

/// <summary>
///  Start Or End Values
/// </summary>
public enum StartOrEnd : byte {
    Start = (byte)'S',
    End = (byte)'E',
};

/// <summary>
///  System Priced Leg Type Values
/// </summary>
public enum SystemPricedLegType : byte {
    SystemPricedCrackSpreadLeg = (byte)'C',
    SystemPricedLeg = (byte)'S',
};

/// <summary>
///  Test Market Indicator Values
/// </summary>
public enum TestMarketIndicator : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Open = (byte)'O',
    Close = (byte)'C',
    Expired = (byte)'E',
    PreOpen = (byte)'1',
    PreClose = (byte)'2',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Or Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrModifyOrderMessage {
    public int MarketId;
    public long OrderId;
    public short OrderSequenceId;
    public Side Side;
    public long Price;
    public int Quantity;
    public IsImplied IsImplied;
    public IsRfq IsRfq;
    public long OrderEntryDateTime;
    public sbyte ExtraFlags;
    public int SequenceWithinMillis;
    public long ModificationTimestamp;
    public long RequestTradingEngineReceivedTimestamp;
};

/// <summary>
///  Struct for Add Price Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddPriceLevelMessage {
    public int MarketId;
    public Side Side;
    public sbyte PriceLevelPosition;
    public long Price;
    public int Quantity;
    public short OrderCount;
    public int ImpliedQuantity;
    public short ImpliedOrderCount;
    public long Timestamp;
};

/// <summary>
///  Struct for Cancelled Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelledTradeMessage {
    public int MarketId;
    public long TradeId;
    public long Price;
    public int Quantity;
    public fixed sbyte OldOffMarketTradeType[1];
    public long DateTime;
    public fixed sbyte OffMarketTradeType[3];
};

/// <summary>
///  Struct for Change Price Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ChangePriceLevelMessage {
    public int MarketId;
    public Side Side;
    public sbyte PriceLevelPosition;
    public long Price;
    public int Quantity;
    public short OrderCount;
    public int ImpliedQuantity;
    public short ImpliedOrderCount;
    public long Timestamp;
};

/// <summary>
///  Struct for Close Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClosePriceMessage {
    public int MarketId;
    public long ClosePrice;
    public long DateTime;
};

/// <summary>
///  Struct for Delete Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderMessage {
    public int MarketId;
    public long OrderId;
    public long DateTime;
    public int SequenceWithinMillis;
    public long RequestTradingEngineReceivedTimestamp;
};

/// <summary>
///  Struct for Delete Price Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeletePriceLevelMessage {
    public int MarketId;
    public Side Side;
    public sbyte PriceLevelPosition;
    public long Timestamp;
};

/// <summary>
///  Struct for End Of Day Market Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMarketSummaryMessage {
    public int MarketId;
    public int Volume;
    public int BlockVolume;
    public int EfsVolume;
    public int EfpVolume;
    public long OpeningPrice;
    public long High;
    public long Low;
    public long Vwap;
    public long SettlementPriceWithDealPricePrecision;
    public int OpenInterest;
    public long DateTime;
    public long SettlementPrice;
};

/// <summary>
///  Struct for Extra Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExtraLegDefinition {
    public sbyte LegBodyLength;
    public int LegMarketId;
    public fixed byte Reserved2Bytes[2];
    public LegSide LegSide;
    public short LegStrategyCode;
    public int LegRatioQtyNumerator;
    public int LegRatioQtyDenominator;
    public int LegRatioPriceNumerator;
    public int LegRatioPriceDenominator;
};

/// <summary>
///  Struct for Extra Strategy Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExtraStrategyLegDefinition {
    public sbyte LegBodyLength;
    public int LegMarketId;
    public int LegUnderlyingMarketId;
    public fixed byte Reserved2Bytes[2];
    public LegSide LegSide;
    public short LegStrategyCode;
    public int LegRatioQtyNumerator;
    public int LegRatioQtyDenominator;
    public int LegRatioPriceNumerator;
    public int LegRatioPriceDenominator;
};

/// <summary>
///  Struct for Fixing Indicative Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FixingIndicativePriceMessage {
    public int MarketId;
    public fixed sbyte IbaCurrency[3];
    public long Price;
    public long PriceInGram;
    public sbyte NumDecimalsPrice;
    public sbyte NumDecimalsPriceInGram;
};

/// <summary>
///  Struct for Fixing Lockdown Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FixingLockdownMessage {
    public int MarketId;
    public fixed sbyte AuctionDate[10];
    public long Time;
    public fixed sbyte Description[20];
    public short Round;
    public int AggBidQty;
    public int AggOfferQty;
    public long UsdPrice;
    public IsBalanced IsBalanced;
    public IsFinal IsFinal;
    public long GbpPrice;
    public long EurPrice;
};

/// <summary>
///  Struct for Fixing Transition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FixingTransitionMessage {
    public int MarketId;
    public FixingStatus FixingStatus;
    public long AuctionEndTime;
    public int ThresholdImbalanceQty;
    public long DateTime;
};

/// <summary>
///  Struct for Fragment Wrapper Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FragmentWrapperMessage {
    public short TotalLength;
    public short FragmentOffset;
    public short FragmentLength;
    public fixed byte FragmentBytes[0];
};

/// <summary>
///  Struct for Hedge Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HedgeDefinition {
    public sbyte HedgeBodyLength;
    public int HedgeMarketId;
    public fixed sbyte HedgeSecurityType[1];
    public HedgeSide HedgeSide;
    public long HedgePrice;
    public fixed sbyte HedgePriceDenominator[1];
    public short HedgeDeltaObsolete;
    public short HedgeStrategyCode;
    public int HedgeDelta;
};

/// <summary>
///  Struct for Index Prices Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IndexPricesMessage {
    public int MarketId;
    public long Price;
    public fixed sbyte ShortName[30];
    public long PublishedDateTime;
    public fixed sbyte ValuationDate[10];
    public EndexStatus EndexStatus;
    public fixed byte Reserved2Bytes[2];
    public fixed sbyte IndexPriceDenominator[1];
};

/// <summary>
///  Struct for Interval Price Limit Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IntervalPriceLimitNotificationMessage {
    public int MarketId;
    public IplHoldType IplHoldType;
    public long NotificationDateTime;
    public IsUp IsUp;
    public int IplHoldDuration;
    public long IplUp;
    public long IplDown;
};

/// <summary>
///  Struct for Investigated Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InvestigatedTradeMessage {
    public int MarketId;
    public long TradeId;
    public long Price;
    public int Quantity;
    public fixed sbyte FfMarketTradeIndicator[1];
    public long DateTime;
    public InvestigationStatus InvestigationStatus;
    public fixed sbyte OffMarketTradeType[3];
};

/// <summary>
///  Struct for Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LegDefinition {
    public sbyte LegBodyLength;
    public int LegMarketId;
    public short LegRatioObsolete;
    public LegSide LegSide;
    public short LegStrategyCode;
    public int LegRatioQtyNumerator;
    public int LegRatioQtyDenominator;
    public int LegRatioPriceNumerator;
    public int LegRatioPriceDenominator;
};

/// <summary>
///  Struct for Market Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketEventMessage {
    public int MarketId;
    public EventType EventType;
    public long DateTime;
};

/// <summary>
///  Struct for Market Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSnapshotMessage {
    public int MarketId;
    public short MarketType;
    public TradingStatus TradingStatus;
    public int Volume;
    public int BlockVolume;
    public int EfsVolume;
    public int EfpVolume;
    public int OpenInterest;
    public long OpeningPrice;
    public long SettlementPriceWithDealPricePrecision;
    public long High;
    public long Low;
    public long Vwap;
    public int NumOfBookEntries;
    public long LastTradePrice;
    public int LastTradeQuantity;
    public long LastTradeDateTime;
    public long SettlePriceDateTime;
    public int LastMessageSequenceId;
    public fixed byte Reserved2Bytes[2];
    public fixed sbyte OpenInterestDate[10];
    public IsSettlePriceOfficial IsSettlePriceOfficial;
    public long SettlementPrice;
    public HasPreviousDaySettlementPrice HasPreviousDaySettlementPrice;
    public long PreviousDaySettlementPrice;
};

/// <summary>
///  Struct for Market Snapshot Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSnapshotOrderMessage {
    public int MarketId;
    public long OrderId;
    public short OrderSequenceId;
    public Side Side;
    public long Price;
    public int Quantity;
    public IsImplied IsImplied;
    public IsRfq IsRfq;
    public long OrderEntryDateTime;
    public int SequenceWithinMillis;
};

/// <summary>
///  Struct for Market Snapshot Price Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSnapshotPriceLevelMessage {
    public int MarketId;
    public Side Side;
    public sbyte PriceLevelPosition;
    public long Price;
    public int Quantity;
    public short OrderCount;
    public int ImpliedQuantity;
    public short ImpliedOrderCount;
};

/// <summary>
///  Struct for Market State Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStateChangeMessage {
    public int MarketId;
    public TradingStatus TradingStatus;
    public long DateTime;
};

/// <summary>
///  Struct for Market Statistics Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatisticsMessage {
    public int MarketId;
    public int Volume;
    public int BlockVolume;
    public int EfsVolume;
    public int EfpVolume;
    public long High;
    public long Low;
    public long Vwap;
    public long DateTime;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Message Bundle Marker
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageBundleMarker {
    public StartOrEnd StartOrEnd;
    public long TradeTransactionId;
    public IsTransactionEnd IsTransactionEnd;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public MessageType MessageType;
    public ushort Length;
};

/// <summary>
///  Struct for New Expiry Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewExpiryMessage {
    public int MarketId;
    public MarketTypeId MarketTypeId;
    public fixed sbyte OrderPriceDenominator[1];
    public int IncrementPrice;
    public int IncrementQty;
    public int LotSize;
    public fixed sbyte MarketDesc[120];
    public short MaturityYear;
    public short MaturityMonth;
    public short MaturityDay;
    public fixed sbyte DealPriceDenominator[1];
    public int MinQty;
    public int UnitQuantity;
    public fixed sbyte Currency[20];
    public fixed sbyte ClearedAlias[15];
    public long MinPrice;
    public long MaxPrice;
    public int ProductId;
    public fixed sbyte ProductName[62];
    public int HubId;
    public fixed sbyte HubAlias[80];
    public int StripId;
    public fixed sbyte StripName[39];
    public fixed sbyte SettlePriceDenominator[1];
    public fixed sbyte MicCode[4];
    public fixed sbyte UnitQtyDenominator[1];
    public fixed sbyte OffExchangeIncrementQtyDenominator[1];
    public int OffExchangeIncrementQty;
    public int OffExchangeIncrementPrice;
    public int OffExchangeIncrementOptionPrice;
    public fixed sbyte ContractSymbol[35];
    public fixed sbyte Isin[12];
    public fixed sbyte NumDecimalsOptionsPrice[1];
    public int HedgeMarketId;
    public SettlementType SettlementType;
    public GtAllowed GtAllowed;
    public CrossOrderSupported CrossOrderSupported;
    public fixed sbyte UnitOfMeasure[30];
    public MifidRegulatedMarket MifidRegulatedMarket;
    public short ScreenLastTradeYear;
    public short ScreenLastTradeMonth;
    public short ScreenLastTradeDay;
    public short OldNumOfCycles;
    public int NumOfCycles;
};

/// <summary>
///  Struct for New Options Market Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOptionsMarketDefinitionMessage {
    public int MarketId;
    public int UnderlyingMarketId;
    public fixed sbyte FuturesContractSymbol[70];
    public TradingStatus TradingStatus;
    public fixed sbyte OrderPriceDenominator[1];
    public int IncrementQty;
    public int LotSize;
    public fixed sbyte MarketDesc[120];
    public OptionType OptionType;
    public long StrikePrice;
    public fixed sbyte DealPriceDenominator[1];
    public int MinQty;
    public fixed sbyte Currency[20];
    public fixed sbyte NumDecimalsStrikePrice[1];
    public long MinOptionsPrice;
    public long MaxOptionsPrice;
    public int IncrementPremiumPrice;
    public short OptionsExpirationYear;
    public short OptionsExpirationMonth;
    public short OptionsExpirationDay;
    public OptionsStyle OptionsStyle;
    public OptionsExpirationType OptionsExpirationType;
    public int HedgeMarketId;
    public fixed sbyte SettlePriceDenominator[1];
    public fixed sbyte UnitQtyDenominator[1];
    public long TickValue;
    public FlexAllowed FlexAllowed;
    public SettlementType SettlementType;
    public IsBlockOnly IsBlockOnly;
    public GtAllowed GtAllowed;
    public CrossOrderSupported CrossOrderSupported;
    public GuaranteedCrossSupported GuaranteedCrossSupported;
    public fixed sbyte UnitOfMeasure[30];
    public MifidRegulatedMarket MifidRegulatedMarket;
    public short ScreenLastTradeYear;
    public short ScreenLastTradeMonth;
    public short ScreenLastTradeDay;
    public IsTradable IsTradable;
    public short OldNumOfCycles;
    public MarketTypeId MarketTypeId;
    public int NumOfCycles;
};

/// <summary>
///  Struct for Old Style Options Trade And Market Stats Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OldStyleOptionsTradeAndMarketStatsMessage {
    public int UnderlyingMarketId;
    public long TradeId;
    public long Price;
    public int Quantity;
    public fixed sbyte OldOffMarketTradeType[1];
    public long TransactDateTime;
    public OptionType OptionType;
    public long StrikePrice;
    public EventCode EventCode;
    public int TotalVolume;
    public int BlockVolume;
    public int EfsVolume;
    public int EfpVolume;
    public long High;
    public long Low;
    public long Vwap;
};

/// <summary>
///  Struct for Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenInterestMessage {
    public int MarketId;
    public int OpenInterest;
    public int OpenInterestChange;
    public long DateTime;
    public fixed sbyte OpenInterestDate[10];
};

/// <summary>
///  Struct for Open Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenPriceMessage {
    public int MarketId;
    public long OpenPrice;
    public long DateTime;
};

/// <summary>
///  Struct for Option Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionOpenInterestMessage {
    public int MarketId;
    public int OpenInterest;
    public long DateTime;
    public fixed sbyte OpenInterestDate[10];
};

/// <summary>
///  Struct for Option Settlement Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionSettlementPriceMessage {
    public int MarketId;
    public long SettlementPriceWithDealPricePrecision;
    public long DateTime;
    public IsOfficial IsOfficial;
    public long ValuationDateTime;
    public long Volatility;
    public long SettlementPrice;
    public long Delta;
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
    public ushort Session;
    public uint Sequence;
    public ushort Count;
    public long Timestamp;
};

/// <summary>
///  Struct for Pre Open Price Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PreOpenPriceIndicatorMessage {
    public int MarketId;
    public long PreOpenPrice;
    public long DateTime;
    public fixed sbyte HasPreOpenVolume[1];
    public int PreOpenVolume;
};

/// <summary>
///  Struct for Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqMessage {
    public int MarketId;
    public long MessageTimestamp;
    public long RfqSystemId;
    public MarketTypeId MarketTypeId;
    public int UnderlyingMarketId;
    public int Quantity;
    public Side Side;
};

/// <summary>
///  Struct for Settlement Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlementPriceMessage {
    public int MarketId;
    public long SettlementPriceWithDealPricePrecision;
    public long DateTime;
    public IsOfficial IsOfficial;
    public long ValuationDateTime;
    public long SettlementPrice;
};

/// <summary>
///  Struct for Special Field
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpecialField {
    public byte SpecialFieldId;
    public ushort SpecialFieldLength;
};

/// <summary>
///  Struct for Special Field Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpecialFieldMessage {
    public sbyte NumberOfSpecialFields;
};

/// <summary>
///  Struct for Spot Market Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpotMarketTradeMessage {
    public int MarketId;
    public long TradeId;
    public long Price;
    public int Quantity;
    public long TransactDateTime;
    public sbyte ExtraFlags;
    public long DeliveryBeginDateTime;
    public long DeliveryEndDateTime;
    public IsSystemPricedLeg IsSystemPricedLeg;
};

/// <summary>
///  Struct for Strategy Leg Definition
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyLegDefinition {
    public sbyte LegBodyLength;
    public int LegMarketId;
    public int LegUnderlyingMarketId;
    public short LegRatioObsolete;
    public LegSide LegSide;
    public short LegStrategyCode;
    public int LegRatioQtyNumerator;
    public int LegRatioQtyDenominator;
    public int LegRatioPriceNumerator;
    public int LegRatioPriceDenominator;
};

/// <summary>
///  Struct for Strip Info Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StripInfoMessage {
    public short OldStripId;
    public fixed sbyte StripType[20];
    public short BeginYear;
    public short BeginMonth;
    public short BeginDay;
    public short EndYear;
    public short EndMonth;
    public short EndDay;
    public fixed sbyte StripInfo[50];
    public int StripId;
};

/// <summary>
///  Struct for System Text Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemTextMessage {
    public fixed sbyte TextMessage[200];
    public long DateTime;
    public fixed sbyte TextMessageExtraFld[800];
};

/// <summary>
///  Struct for Trade Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeFlags {
    public fixed byte IsRfcCrossing[1];
    public fixed byte IsLegDealOutsideIpl[1];
    public fixed byte IsImpliedOrder[1];
    public fixed byte IsVerticalSplit[1];
    public fixed byte FutureTradeFlags[4];
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public int MarketId;
    public long TradeId;
    public IsSystemPricedLeg IsSystemPricedLeg;
    public long Price;
    public int Quantity;
    public fixed sbyte OldOffMarketTradeType[1];
    public long TransactDateTime;
    public SystemPricedLegType SystemPricedLegType;
    public fixed sbyte IsImpliedSpreadAtMarketOpen[1];
    public fixed sbyte IsAdjustedTrade[1];
    public AggressorSide AggressorSide;
    public fixed byte TradeFlags[0];
    public fixed sbyte OffMarketTradeType[3];
    public int SequenceWithinMillis;
    public long RequestTradingEngineReceivedTimestamp;
};

