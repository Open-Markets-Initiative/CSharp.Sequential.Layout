// C# Structs For Euronext Optiq Sbe MarketDataGateway 4.3.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Action Type Values
/// </summary>
public enum ActionType : byte {
    NewOrder = 1,
    DeletionOfIdentifiedOrder = 2,
    DeletionOfAllOrdersBySide = 3,
    ModificationOfExistingOrderWithoutLossOfPriority = 4,
    RetransmissionOfAllOrders = 5,
    ModificationOfExistingOrderWithLossOfPriority = 6,
    RfqAnswercreation = 7,
    RfqAnswerdeletion = 8,
};

/// <summary>
///  Anonymous Values
/// </summary>
public enum Anonymous : byte {
    No = 0,
    Yes = 1,
    NoValue = 255,
};

/// <summary>
///  Block Trade Code Values
/// </summary>
public enum BlockTradeCode : byte {
    BlockTrade = (byte)'B',
    RegulartradeorNegotiateddeal = (byte)'N',
    Undefined = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Book State Values
/// </summary>
public enum BookState : byte {
    Inaccessible = 1,
    Closed = 2,
    Call = 3,
    Uncrossing = 4,
    Continuous = 5,
    Halted = 6,
    ContinuousUncrossing = 7,
    Suspended = 8,
    Reserved = 9,
    NoValue = 255,
};

/// <summary>
///  Change Type Values
/// </summary>
public enum ChangeType : byte {
    StatusChanges = 0,
    ScheduledEventNotification = 1,
    StatusChangeandScheduledEventNotification = 2,
};

/// <summary>
///  Contract Trading Type Values
/// </summary>
public enum ContractTradingType : byte {
    Tradedasanoutright = 1,
    NottradedbutlistedincontractdataTradersmaysubscribeto = 2,
    Tradedasasimpleintercommodityspread = 3,
    Tradedasanintercommodityspread = 4,
};

/// <summary>
///  Contract Type Values
/// </summary>
public enum ContractType : byte {
    Future = (byte)'F',
    Option = (byte)'O',
    Underlying = (byte)'U',
    NoValue = (byte)'0',
};

/// <summary>
///  Derivatives Instrument Type Values
/// </summary>
public enum DerivativesInstrumentType : byte {
    CallOption = 0,
    PutOption = 1,
    Strategy = 2,
    IndividualFuture = 3,
    Underlying = 4,
    NoValue = 255,
};

/// <summary>
///  Derivatives Market Model Values
/// </summary>
public enum DerivativesMarketModel : byte {
    NoSyntheticQuote = 0,
    SpontaneousImpliedMatching = 1,
    EventDrivenImpliedMatching = 2,
    NoValue = 255,
};

/// <summary>
///  Dynamic Collar Logic Values
/// </summary>
public enum DynamicCollarLogic : byte {
    NotActive = 0,
    NoHaltwithReject = 2,
    HaltwithAcceptation = 3,
    NoValue = 255,
};

/// <summary>
///  Effective Date Indicator Values
/// </summary>
public enum EffectiveDateIndicator : byte {
    Sellerdeclarationisreceivedonthecurtradingsessionday = 0,
    Sellerdeclarationreceivedbeforethecurtradingsessionday = 1,
    NoValue = 255,
};

/// <summary>
///  Efficient Mmt Agency Cross Trade Indicator Values
/// </summary>
public enum EfficientMmtAgencyCrossTradeIndicator : byte {
    Actx = (byte)'X',
    NoAgencyCrossTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Algorithmic Indicator Values
/// </summary>
public enum EfficientMmtAlgorithmicIndicator : byte {
    Algo = (byte)'H',
    NoAlgorithmicTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Benchmark Indicator Values
/// </summary>
public enum EfficientMmtBenchmarkIndicator : byte {
    Benc = (byte)'B',
    Rfpt = (byte)'S',
    NoBenchmarkorReferencePriceTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Contributionto Price Values
/// </summary>
public enum EfficientMmtContributiontoPrice : byte {
    Tncp = (byte)'J',
    Pndg = (byte)'N',
    PlainVanillaTrade = (byte)'P',
    Npft = (byte)'T',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Duplicative Indicator Values
/// </summary>
public enum EfficientMmtDuplicativeIndicator : byte {
    Dupl = (byte)'1',
    UniqueTradeReport = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Market Mechanism Values
/// </summary>
public enum EfficientMmtMarketMechanism : byte {
    CentralLimitOrderBook = 1,
    QuoteDrivenMarket = 2,
    DarkOrderBook = 3,
    OffBookincludingVoiceorMessagingTrading = 4,
    PeriodicAuctionequalUncrossing = 5,
    RequestforQuotes = 6,
    Other = 7,
    NoValue = 255,
};

/// <summary>
///  Efficient Mmt Modification Indicator Values
/// </summary>
public enum EfficientMmtModificationIndicator : byte {
    Amnd = (byte)'A',
    Canc = (byte)'C',
    NewTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Negotiation Indicator Values
/// </summary>
public enum EfficientMmtNegotiationIndicator : byte {
    Nliq = (byte)'1',
    Oilq = (byte)'2',
    Pric = (byte)'3',
    Ilqd = (byte)'4',
    Size = (byte)'5',
    Ilqdsize = (byte)'6',
    NegotiatedTrade = (byte)'N',
    NoNegotiatedTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Off Book Automated Indicator Values
/// </summary>
public enum EfficientMmtOffBookAutomatedIndicator : byte {
    OffBookNonAutomated = (byte)'M',
    OffBookAutomated = (byte)'Q',
    Unspecifiedordoesnotapply = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Post Trade Deferral Values
/// </summary>
public enum EfficientMmtPostTradeDeferral : byte {
    Lmtf = (byte)'1',
    Datf = (byte)'2',
    Volo = (byte)'3',
    Fwaf = (byte)'4',
    Idaf = (byte)'5',
    Volw = (byte)'6',
    Fulf = (byte)'7',
    Fula = (byte)'8',
    Fulv = (byte)'9',
    Fulj = (byte)'V',
    Coaf = (byte)'W',
    NotApplicable = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Publication Mode Values
/// </summary>
public enum EfficientMmtPublicationMode : byte {
    NonImmediatePublication = (byte)'1',
    Lrgs = (byte)'2',
    Ilqd = (byte)'3',
    Size = (byte)'4',
    Ilqdsize = (byte)'5',
    Ilqdlrgs = (byte)'6',
    ImmediatePublication = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Special Dividend Indicator Values
/// </summary>
public enum EfficientMmtSpecialDividendIndicator : byte {
    Sdiv = (byte)'E',
    NoSpecialDividendTrade = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Trading Mode Values
/// </summary>
public enum EfficientMmtTradingMode : byte {
    UndefinedAuctionequalUncrossing = (byte)'1',
    ContinuousTrading = (byte)'2',
    AtMarketCloseTrading = (byte)'3',
    OutofMainSessionTrading = (byte)'4',
    TradeReportingOnExchange = (byte)'5',
    TradeReportingOffExchange = (byte)'6',
    TradeReportingSystematicInternaliser = (byte)'7',
    ScheduledIntradayAuctionequalUncrossing = (byte)'I',
    ScheduledClosingAuctionequalUncrossing = (byte)'K',
    ScheduledOpeningAuctionequalUncrossing = (byte)'O',
    UnscheduledAuctionequalUncrossing = (byte)'U',
    NoValue = (byte)'0',
};

/// <summary>
///  Efficient Mmt Transaction Category Values
/// </summary>
public enum EfficientMmtTransactionCategory : byte {
    DarkTrade = (byte)'D',
    Rpri = (byte)'R',
    Xfph = (byte)'Y',
    Tpac = (byte)'Z',
    Noneapply = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Emm Values
/// </summary>
public enum Emm : byte {
    CashandDerivativeCentralOrderBook = 1,
    NavTradingFacility = 2,
    DerivativesWholesales = 4,
    CashOnExchangeOffbook = 5,
    Euronextoffexchangetradereports = 6,
    DerivativesOnExchangeOffbook = 7,
    EtfmtfnavCentralOrderBook = 8,
    Listednottraded = 9,
    DeltaNeutralContingencyLeg = 15,
    NotApplicable = 99,
    NoValue = 255,
};

/// <summary>
///  Exchange Code Values
/// </summary>
public enum ExchangeCode : byte {
    AmsterdamEquityDerivatives = (byte)'A',
    BrusselsEquityDerivatives = (byte)'B',
    ParisEquityUnderlyings = (byte)'C',
    BrusselsCashUnderlyings = (byte)'D',
    BrusselsIndexDerivatives = (byte)'F',
    AmsterdamCashUnderlyings = (byte)'G',
    LisbonCashUnderlyings = (byte)'H',
    ParisIndexDerivatives = (byte)'J',
    AmsterdamIndexDerivatives = (byte)'K',
    LisbonIndexDerivatives = (byte)'M',
    ParisEquityDerivatives = (byte)'P',
    AmsterdamCommoditiesDerivatives = (byte)'R',
    LisbonEquityDerivatives = (byte)'S',
    ParisCommoditiesDerivatives = (byte)'Y',
    AmsterdamCurrencyDerivatives = (byte)'Z',
    OsloIndexDerivatives = (byte)'N',
    OsloEquityDerivatives = (byte)'O',
    OsloCashUnderlying = (byte)'L',
};

/// <summary>
///  Exer Style Values
/// </summary>
public enum ExerStyle : byte {
    European = 0,
    American = 1,
    Asian = 2,
    Bermudan = 3,
    Other = 4,
    NoValue = 255,
};

/// <summary>
///  Expiry Cycle Type Values
/// </summary>
public enum ExpiryCycleType : byte {
    Daily = 1,
    Weekly = 2,
    Monthly = 3,
    NoValue = 255,
};

/// <summary>
///  Gross Of Cdsc Indicator Values
/// </summary>
public enum GrossOfCdscIndicator : byte {
    No = (byte)'N',
    Yes = (byte)'Y',
    NoValue = (byte)'0',
};

/// <summary>
///  Guarantee Indicator Values
/// </summary>
public enum GuaranteeIndicator : byte {
    Thisinstrumentisnotguaranteed = 0,
    Thisinstrumentisguaranteed = 1,
    Thisinstrumentisnotclearable = 2,
    GuaranteedClearedBorrowingLendingService = 8,
    NoValue = 255,
};

/// <summary>
///  Imbalance Qty Side Values
/// </summary>
public enum ImbalanceQtySide : byte {
    Noimbalance = 0,
    Buy = 1,
    Sell = 2,
    NoValue = 255,
};

/// <summary>
///  Index Level Type Values
/// </summary>
public enum IndexLevelType : byte {
    IndicativeIndex = 0,
    OfficialOpeningIndex = 1,
    RealTimeIndex = 2,
    AutomaticIndicativeIndex = 3,
    PreliminaryReferenceIndex = 4,
    ClosingReferenceIndex = 5,
    ConfirmedReferenceIndex = 6,
    OptionsLiquidationIndex = 7,
};

/// <summary>
///  Index Price Code Values
/// </summary>
public enum IndexPriceCode : byte {
    OnlyIndex = 0,
    IndexandSessionHigh = 1,
    IndexandSessionLow = 2,
    IndexandSessionHighandLowtypicallyfirstprice = 3,
    OnlySessionHigh = 4,
    OnlySessionLow = 5,
    PreviousDayClose = 6,
};

/// <summary>
///  Inst Unit Exp Values
/// </summary>
public enum InstUnitExp : byte {
    Units = 1,
    PercentageofNominalExcludingAccruedInterestClean = 2,
    BasisPoints = 3,
    PercentageofNominalIncludingAccruedInterestDirty = 5,
    Yield = 7,
    Kilograms = 8,
    Ounces = 9,
    NoValue = 255,
};

/// <summary>
///  Instrument Category Values
/// </summary>
public enum InstrumentCategory : byte {
    Equities = 1,
    FixedIncome = 2,
    WarrantsAndCertificates = 3,
    Trackers = 6,
    Futures = 7,
    Options = 10,
    Indices = 11,
    EuronextFundsServices = 12,
    InavIndicativeNetAssetValue = 14,
    Fund = 15,
    Miscellaneous = 254,
};

/// <summary>
///  Instrument State Values
/// </summary>
public enum InstrumentState : byte {
    Scheduled = 1,
    SuspendedduetoUnderlying = 2,
    SuspendedKobi = 3,
    SuspendedKobe = 4,
    SuspendedNewListing = 5,
    SuspendedbyMo = 6,
    SuspendedTechnical = 7,
    ReservedDynamicCollars = 8,
    ReservedStaticCollars = 9,
    ReservedWaitingForLp = 10,
    ReservedLpLimit = 11,
    InstrumentDeletion = 12,
    SuspendedWaitingforBbo = 13,
    SuspendedWaitingforTradableState = 14,
    RandomUncrossingPeriod = 15,
    Expired = 16,
    Uncrossing = 17,
    ReservedduetoLeg = 18,
    SuspendedduetoLeg = 19,
    NoValue = 255,
};

/// <summary>
///  Leg Buy Sell Values
/// </summary>
public enum LegBuySell : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Market Model Values
/// </summary>
public enum MarketModel : byte {
    OrderDriven = 1,
    QuoteDriven = 2,
    Ipo = 3,
    PrimaryMarket = 4,
    Rfq = 5,
    ConditionalUncrossing = 6,
    NoValue = 255,
};

/// <summary>
///  Message Price Notation Values
/// </summary>
public enum MessagePriceNotation : byte {
    Price = 1,
    Spreadinbasispoints = 2,
    Spread = 3,
    NoValue = 255,
};

/// <summary>
///  Mmt Market Mechanism Values
/// </summary>
public enum MmtMarketMechanism : byte {
    CentralLimitOrderBook = 1,
    QuoteDrivenMarket = 2,
    DarkOrderBook = 3,
    OffBookincludingVoiceorMessagingTrading = 4,
    PeriodicAuctionequalUncrossing = 5,
    RequestforQuotes = 6,
    NoValue = 255,
};

/// <summary>
///  Mmt Off Book Automated Indicator Values
/// </summary>
public enum MmtOffBookAutomatedIndicator : byte {
    OffBookNonAutomated = (byte)'M',
    OffBookAutomated = (byte)'Q',
    Unspecifiedordoesnotapply = (byte)'-',
    NoValue = (byte)'0',
};

/// <summary>
///  Mmt Trading Mode Values
/// </summary>
public enum MmtTradingMode : byte {
    UndefinedAuctionequalUncrossing = (byte)'1',
    ContinuousTrading = (byte)'2',
    AtMarketCloseTrading = (byte)'3',
    OutofMainSessionTrading = (byte)'4',
    TradeReportingOnExchange = (byte)'5',
    TradeReportingOffExchange = (byte)'6',
    TradeReportingSystematicInternaliser = (byte)'7',
    ScheduledIntradayAuctionequalUncrossing = (byte)'I',
    ScheduledClosingAuctionequalUncrossing = (byte)'K',
    ScheduledOpeningAuctionequalUncrossing = (byte)'O',
    UnscheduledAuctionequalUncrossing = (byte)'U',
    NoValue = (byte)'0',
};

/// <summary>
///  Opened Closed Fund Values
/// </summary>
public enum OpenedClosedFund : byte {
    Open = (byte)'O',
    Closed = (byte)'C',
    NoValue = (byte)'0',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Call = 1,
    Put = 2,
    NoValue = 255,
};

/// <summary>
///  Optiq Segment Values
/// </summary>
public enum OptiqSegment : byte {
    Equities = 1,
    Funds = 2,
    FixedIncome = 3,
    WarrantsandCertificates = 4,
    BoursedeLuxembourg = 5,
    Options = 6,
    Futures = 7,
    Commodities = 8,
    Indices = 9,
    TradeReportingandPublication = 10,
    Block = 14,
    IndexDerivatives = 11,
    EquityDerivatives = 12,
    FinancialDerivatives = 13,
    Forex = 15,
    Ibf = 16,
};

/// <summary>
///  Order Entry Qualifier Values
/// </summary>
public enum OrderEntryQualifier : byte {
    OrderEntryCancelModifyDisabled = 0,
    OrderEntryCancelModifyEnabled = 1,
    CancelandModifyOnly = 2,
    CancelOnly = 3,
    NoValue = 255,
};

/// <summary>
///  Order Side Values
/// </summary>
public enum OrderSide : byte {
    Buy = 1,
    Sell = 2,
    Cross = 3,
    NoValue = 255,
};

/// <summary>
///  Order Type Values
/// </summary>
public enum OrderType : byte {
    Market = 1,
    Limit = 2,
    StopmarketorStopmarketonquote = 3,
    StoplimitorStoplimitonquote = 4,
    PrimaryPeg = 5,
    Markettolimit = 6,
    MarketPeg = 7,
    MidPointPeg = 8,
    AveragePrice = 9,
    Iceberg = 10,
    NoValue = 255,
};

/// <summary>
///  Payment Frequency Values
/// </summary>
public enum PaymentFrequency : byte {
    Annual = 1,
    SemiAnnual = 2,
    Quarterly = 3,
    Monthly = 4,
    BiMonthly = 5,
    Daily = 6,
    MigrationNa = 7,
    Other = 8,
    NoValue = 255,
};

/// <summary>
///  Phase Id Values
/// </summary>
public enum PhaseId : byte {
    Inaccessible = 1,
    Closed = 2,
    Call = 3,
    Uncrossing = 4,
    Continuous = 5,
    ContinuousUncrossing = 7,
};

/// <summary>
///  Price Limits Values
/// </summary>
public enum PriceLimits : byte {
    PriceLimitsEnabledNormal = 1,
    PriceLimitsEnabledWide = 2,
    PriceLimitsEnabledWidest = 3,
    PriceLimitsDisabled = 4,
    NoValue = 255,
};

/// <summary>
///  Price Type Values
/// </summary>
public enum PriceType : byte {
    OfficialDaily = 2,
    OfficialMarketClose = 4,
    OfficialExpiry = 6,
    ProvisionalIntraday = 7,
    OfficialIntraday = 8,
    OfficialYdsp = 9,
    NaVfortheinstrumentseligibletotheNavTradingFacility = 10,
    AdjustedClosingPrice = 12,
    SubscriptionPrice = 13,
    IndicativeMatchingPrice = 14,
    MinPriceOutofSessionTrades = 19,
    MaxPriceOutofSessionTrades = 20,
    MinPriceOutofSessionBlockTrades = 21,
    MaxPriceOutofSessionBlockTrades = 22,
    ValuationPrice = 23,
    FundSubscription = 24,
    FundRedemption = 25,
    UncrossingPrice = 26,
    LastTradedPrice = 27,
    Aip = 28,
    NetAssetValue = 30,
    ExternalReferencePrice = 31,
};

/// <summary>
///  Pricing Algorithm Values
/// </summary>
public enum PricingAlgorithm : byte {
    Standard = 0,
    TotalReturnFuture = 1,
    MarketOnClose = 2,
};

/// <summary>
///  Quote Spread Multiplier Values
/// </summary>
public enum QuoteSpreadMultiplier : byte {
    QuoteSpreadMultiplier1 = 1,
    QuoteSpreadMultiplier2 = 2,
    QuoteSpreadMultiplier3 = 3,
    NoValue = 255,
};

/// <summary>
///  Quote Update Type Values
/// </summary>
public enum QuoteUpdateType : byte {
    BestBid = 1,
    BestOffer = 2,
    CancelBid = 5,
    CancelOffer = 6,
};

/// <summary>
///  Reference Price Origin In Continuous Values
/// </summary>
public enum ReferencePriceOriginInContinuous : byte {
    Internal = 1,
    External = 2,
    ExternalBbo = 3,
    OpeningCallPrice = 4,
    MidBbOorFairValue = 5,
    FairValue = 6,
    FutureMarketPrice = 7,
    NoValue = 255,
};

/// <summary>
///  Reference Price Origin In Opening Call Values
/// </summary>
public enum ReferencePriceOriginInOpeningCall : byte {
    Internal = 1,
    External = 2,
    ExternalBbo = 3,
    OpeningCallPrice = 4,
    MidBbOorFairValue = 5,
    FairValue = 6,
    FutureMarketPrice = 7,
    NoValue = 255,
};

/// <summary>
///  Reference Price Origin In Trading Interruption Values
/// </summary>
public enum ReferencePriceOriginInTradingInterruption : byte {
    Internal = 1,
    External = 2,
    ExternalBbo = 3,
    OpeningCallPrice = 4,
    MidBbOorFairValue = 5,
    FairValue = 6,
    FutureMarketPrice = 7,
    NoValue = 255,
};

/// <summary>
///  Repo Indicator Values
/// </summary>
public enum RepoIndicator : byte {
    InstrneithereligibleforSrDorLoanandLendingMkt = 0,
    InstreligibleforSrDandforLoanandLendingMarket = 1,
    InstreligiblefortheSrDlongonly = 2,
    InstreligibleforLoanandLendingMktandforSrDlongonly = 3,
    EasytoborrowInstreligibleforSrDandforLoanandLendingMkt = 4,
    InstreligiblefortheLoanandLendingMarket = 5,
    Nonsignificant = 8,
    NoValue = 255,
};

/// <summary>
///  Scheduled Event Values
/// </summary>
public enum ScheduledEvent : byte {
    CancelPreviouslyScheduledEvent = 0,
    Reopening = 1,
    Resumptionoftrading = 3,
    Closed = 4,
    Expiry = 5,
    WholesaleLargeinScaleLiStradesopenextension = 6,
    WholesaleBasistradesopenextension = 7,
    WholesaleAgainstActualstradesopenextension = 8,
    WholesaleLargeinScaleLiSPackagetradesopenextension = 9,
    WholesaleExchangeForSwapstradesopenextension = 10,
    WholesaleTradesOpenExtension = 11,
    Suspension = 12,
    CollarsNormal = 13,
    CollarsWide = 14,
    PreExpiry = 15,
    NoValue = 255,
};

/// <summary>
///  Security Condition Values
/// </summary>
public enum SecurityCondition : byte {
    Normal = (byte)'O',
    ExDividend = (byte)'D',
    ExCap = (byte)'C',
    ExRights = (byte)'R',
    ExEntitlement = (byte)'E',
    Dealingstemporarilysuspended = (byte)'S',
    NotListed = (byte)'N',
    NoValue = (byte)'0',
};

/// <summary>
///  Session Values
/// </summary>
public enum Session : byte {
    Session0 = 0,
    Session1 = 1,
    Session2 = 2,
    Session3 = 3,
    Session4 = 4,
    Session5 = 5,
    Session6 = 6,
    Session7 = 7,
    Session8 = 8,
    Session9 = 9,
};

/// <summary>
///  Stats Update Type Values
/// </summary>
public enum StatsUpdateType : byte {
    DailyHigh = 5,
    DailyLow = 6,
    YearlyHigh = 7,
    YearlyLow = 8,
    LifetimeHigh = 9,
    LifetimeLow = 10,
    VariationLastPrice = 14,
    OpenPrice = 15,
    TradeCount = 16,
    LastTradedPrice = 17,
    PercentVariationPreviousClose = 18,
    OffBookCumulQty = 19,
    OnBookAuctionCumulQty = 21,
    OnBookContinuousCumulQty = 22,
    OnandOffBookCumulQty = 23,
};

/// <summary>
///  Status Reason Values
/// </summary>
public enum StatusReason : byte {
    Scheduled = 0,
    CollarsBreach = 4,
    AutomaticReopening = 7,
    NoLiquidityProvider = 8,
    KnockInbyIssuer = 11,
    KnockOutbyExchange = 12,
    KnockOutbyIssuer = 13,
    ActionbyMarketOperations = 15,
    WaitingforTradableState = 16,
    NewListing = 20,
    DuetoUnderlying = 21,
    OutsideofLPquotes = 22,
    Technical = 23,
    DuetoLeg = 24,
    NoValue = 255,
};

/// <summary>
///  Strategy Code Values
/// </summary>
public enum StrategyCode : byte {
    JellyRoll = (byte)'A',
    Butterfly = (byte)'B',
    CallorPutCabinet = (byte)'C',
    Spread = (byte)'D',
    CalendarSpread = (byte)'E',
    DiagonalCalendarSpread = (byte)'F',
    Guts = (byte)'G',
    TwobyOneRatioSpread = (byte)'H',
    IronButterfly = (byte)'I',
    Combo = (byte)'J',
    Strangle = (byte)'K',
    Ladder = (byte)'L',
    Strip = (byte)'M',
    StraddleCalendarSpread = (byte)'N',
    Pack = (byte)'O',
    DiagonalStraddleCalendarSpread = (byte)'P',
    SimpleInterCommoditySpread = (byte)'Q',
    ConversionReversal = (byte)'R',
    Straddle = (byte)'S',
    VolatilityTrade = (byte)'V',
    Condor = (byte)'W',
    Box = (byte)'X',
    Bundle = (byte)'Y',
    ReducedTickSpread = (byte)'Z',
    LadderversusUnderlying = (byte)'a',
    ButterflyversusUnderlying = (byte)'b',
    CallSpreadversusPutversusUnderlying = (byte)'c',
    CallorPutSpreadversusUnderlying = (byte)'d',
    CallorPutCalendarSpreadversusUnderlying = (byte)'e',
    CallPutDiagonalCalendarSpreadversusUnderlying = (byte)'f',
    GutsversusUnderlying = (byte)'g',
    TwobyOneCallorPutRatioSpreadversusUnderlying = (byte)'h',
    IronButterflyversusUnderlying = (byte)'i',
    ComboversusUnderlying = (byte)'j',
    StrangleversusUnderlying = (byte)'k',
    ExchangeforPhysical = (byte)'m',
    StraddleCalendarSpreadversusUnderlying = (byte)'n',
    PutSpreadversusCallversusUnderlying = (byte)'p',
    DiagonalStraddleCalendarSpreadversusUnderlying = (byte)'q',
    Synthetic = (byte)'r',
    StraddleversusUnderlying = (byte)'s',
    CondorversusUnderlying = (byte)'t',
    BuyWrite = (byte)'u',
    IronCondorversusUnderlying = (byte)'v',
    IronCondor = (byte)'w',
    CallSpreadversusSellaPut = (byte)'x',
    PutSpreadversusSellaCall = (byte)'y',
    PutStraddleversusSellaCalloraPut = (byte)'z',
};

/// <summary>
///  Strike Currency Indicator Values
/// </summary>
public enum StrikeCurrencyIndicator : byte {
    Changeratenotappliedtothestrikeprice = 0,
    Changerateappliedtothestrikeprice = 1,
    NoValue = 255,
};

/// <summary>
///  Tax Code Values
/// </summary>
public enum TaxCode : byte {
    NoteligibletoPeaThestockhasneverbeenaMonorystock = 0,
    EligibletoPea = 3,
    Notprovided = 9,
    NoValue = 255,
};

/// <summary>
///  Tax Description Attaching To A Dividend Values
/// </summary>
public enum TaxDescriptionAttachingToADividend : byte {
    DeducedatSource = (byte)'D',
    NoValue = (byte)'0',
};

/// <summary>
///  Technical Notification Type Values
/// </summary>
public enum TechnicalNotificationType : byte {
    InstrumentBookRetransmissionEnd = 1,
    TradeRetransmissionStart = 10,
    TradeRetransmissionEnd = 11,
};

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
    BfnavMessage = 1203,
    BfInstrumentSuspensionMessage = 1204,
    StartOfSnapshotMessage = 2101,
    EndOfSnapshotMessage = 2102,
};

/// <summary>
///  Trade Type Values
/// </summary>
public enum TradeType : byte {
    ConventionalTrade = 1,
    LargeinScaleLiSTrade = 2,
    BasisTrade = 3,
    LargeinScaleLiSPackageTrade = 4,
    GuaranteedCrossTrade = 5,
    AgainstActualTrade = 6,
    AssetAllocationTrade = 7,
    ExchangeforSwapTrade = 9,
    ExchangeforPhysicalTradeCashLeg = 10,
    StrategyLegConventionalTrade = 11,
    StrategyLegLargeinScaleLiSTrade = 12,
    StrategyLegBasisTrade = 13,
    StrategyLegGuaranteedCrossTrade = 14,
    StrategyLegAgainstActualTrade = 15,
    StrategyLegAssetAllocationTrade = 16,
    StrategyLegExchangeForSwapTrade = 18,
    StrategyLegExchangeForPhysicalTrade = 19,
    BoBTrade = 20,
    AtomXTrade = 22,
    TradeCancellation = 24,
    OutofMarketTrade = 25,
    DeltaNeutralTradeUnderlyingCashLeg = 26,
    MarketVwapOperationTrade = 27,
    EuronextFundServiceTrade = 28,
    SecondaryListingTrade = 29,
    RequestforCrossTrade = 30,
    RequestforcrossstrategyLegTrade = 31,
    TradePublication = 32,
    DarkTrade = 33,
    DeltaNeutralTradeUnderlyingFutureLeg = 34,
    TotalTradedVolume = 36,
    EtfmtfnavTradepriceinbp = 37,
    EtfmtfnavDarkTradepriceinbp = 38,
    GuaranteedCrossNegotiateddealNliq = 39,
    GuaranteedCrossNegotiateddealOilq = 40,
    LargeinScaleTrade = 41,
    LargeinScaleTradeinbasispoints = 42,
    LargeinScalePackageTradeinbasispoints = 43,
    StrategyLegLargeinScaleTradeinbasispoints = 44,
    TradeReversal = 45,
    NonStandardSettlement = 46,
    RepurchaseAgreementRepo = 47,
    ExchangeGrantedTrade = 48,
    Other = 49,
    OddLot = 50,
    ConventionalTradeProvisionalprice = 100,
    LargeinScaleLiSTradeProvisionalprice = 101,
    LargeinScaleLiSPackageTradeProvisionalprice = 102,
};

/// <summary>
///  Trading Currency Indicator Values
/// </summary>
public enum TradingCurrencyIndicator : byte {
    Changeratenotappliedtothetradedprice = 0,
    Changerateappliedtothetradedprice = 1,
    NoValue = 255,
};

/// <summary>
///  Trading Period Values
/// </summary>
public enum TradingPeriod : byte {
    Opening = 1,
    Standard = 2,
    Closing = 3,
    NoValue = 255,
};

/// <summary>
///  Trading Policy Values
/// </summary>
public enum TradingPolicy : byte {
    PriceExplicitTime = 1,
    PriceProRata = 2,
    NoValue = 255,
};

/// <summary>
///  Trading Side Values
/// </summary>
public enum TradingSide : byte {
    BidOnly = 1,
    OfferOnly = 2,
    Pako = 3,
    BothSides = 4,
    NoValue = 255,
};

/// <summary>
///  Transaction Type Values
/// </summary>
public enum TransactionType : byte {
    PlainVanillaTrade = 1,
    DarkTrade = 2,
    BenchmarkTrade = 3,
    TechnicalTrade = 4,
    GiveupGiveinTrade = 5,
    ExCumdividendTrade = 6,
    TradeWithCondition = 7,
    SummaryReport = 15,
    NoValue = 255,
};

/// <summary>
///  Transparency Indicator Values
/// </summary>
public enum TransparencyIndicator : byte {
    LitRegularTrade = 0,
    DarkTradeandImmediatePublication = 1,
    DarkTradeandDeferredPublication = 2,
    NoValue = 255,
};

/// <summary>
///  Type Of Market Admission Values
/// </summary>
public enum TypeOfMarketAdmission : byte {
    Instrumentstradedontheprimarymarket = (byte)'A',
    Instrumentstradedonthesecondarymarket = (byte)'B',
    InstrumentstradedontheNewMarket = (byte)'C',
    Nonregulatedmarketinstrumentstradedonthefreemarket = (byte)'D',
    NonregulatedmarketAlternext = (byte)'E',
    Nonlisted = (byte)'F',
    RegulatedMarketNonequities = (byte)'G',
    RegulatedMarketEquitiesSegmentA = (byte)'H',
    RegulatedMarketEquitiesSegmentB = (byte)'I',
    RegulatedMarketEquitiesSegmentC = (byte)'J',
    RegulatedMarketAllsecuritiesSpecialSegment = (byte)'K',
    RegulatedMarketEquitiesOtherinstruments = (byte)'L',
    OpcvmsicomInonlistedFrenchInvestmentFunds = (byte)'S',
    OffMarket = (byte)'6',
    GoldCurrenciesandIndices = (byte)'7',
    Foreign = (byte)'9',
    NoValue = (byte)'0',
};

/// <summary>
///  Underlying Subtype Values
/// </summary>
public enum UnderlyingSubtype : byte {
    Basket = 0,
    Dividend = 1,
    Etf = 2,
    Share = 3,
    DividendIndex = 4,
    EquityIndex = 5,
    TrfIndex = 6,
    VolatilityIndex = 7,
    FutureOnCommodities = 8,
    FxCrossRates = 9,
    FxEmergingMarkets = 10,
    FxMajors = 11,
    Agricultural = 12,
    Environmental = 13,
    Freight = 14,
    Fertilizer = 15,
    Industrialproducts = 16,
    Inflation = 17,
    MultiCommodityExotic = 18,
    Metals = 19,
    Energy = 20,
    Officialeconomicstatistics = 21,
    OtherC10 = 22,
    Other = 23,
    Paper = 24,
    Polypropylene = 25,
    NoValue = 255,
};

/// <summary>
///  Underlying Type Values
/// </summary>
public enum UnderlyingType : byte {
    Commodity = (byte)'C',
    Future = (byte)'F',
    Index = (byte)'I',
    Stock = (byte)'S',
    ExchangeRate = (byte)'X',
};

/// <summary>
///  Update Type Values
/// </summary>
public enum UpdateType : byte {
    BestBid = 1,
    BestOffer = 2,
    NewBid = 3,
    NewOffer = 4,
    UpdatedBid = 5,
    UpdatedOffer = 6,
    TotalTradedVolume = 7,
    ImpliedBid = 8,
    ImpliedOffer = 9,
    RequestforQuote = 10,
    RequestforQuoteBid = 11,
    RequestforSize = 12,
    RequestforQuoteOffer = 13,
    HighDynamicCollar = 14,
    LowDynamicCollar = 15,
    NewBidRlp = 16,
    NewOfferRlp = 17,
    UpdatedBidRlp = 18,
    UpdatedOfferRlp = 19,
    ConventionalTrade = 24,
    RequestforCrossRfcQueued = 25,
    RequestforCrossRfc = 26,
    LargeinScaleLiSTrade = 27,
    BasisTrade = 28,
    LargeinScaleLiSPackageTrade = 29,
    GuaranteedCrossTrade = 30,
    AgainstActualTrade = 31,
    AssetAllocationTrade = 32,
    ExchangeforSwapTrade = 34,
    DarkTrade = 35,
    ExchangeforPhysicalTradeCashLeg = 36,
    StrategyLegConventionalTrade = 37,
    StrategyLegLargeinScaleLiSTrade = 38,
    StrategyLegBasisTrade = 39,
    StrategyLegGuaranteedCrossTrade = 40,
    StrategyLegAgainstActualTrade = 41,
    StrategyLegAssetAllocationTrade = 42,
    StrategyLegExchangeForSwapTrade = 44,
    StrategyLegExchangeForPhysicalTrade = 45,
    BoBTrade = 46,
    AtomXTrade = 48,
    TradeCancellation = 50,
    OutofMarketTrade = 51,
    DeltaNeutralTradeUnderlyingCashLeg = 52,
    DeltaNeutralTradeUnderlyingFutureLeg = 53,
    EuronextFundServiceTrade = 54,
    SecondaryListingTrade = 55,
    RequestforCrossTrade = 56,
    RequestforCrossStrategyLegTrade = 57,
    NewBidWithLiquidityProvider = 58,
    NewOfferWithLiquidityProvider = 59,
    UpdatedBidWithLiquidityProvider = 60,
    UpdatedOfferWithLiquidityProvider = 61,
    LowStaticCollar = 63,
    HighStaticCollar = 64,
    MarketVwapOperationTrade = 65,
    RequestforSizeBid = 66,
    RequestforSizeOffer = 67,
    LowLpCollar = 70,
    HighLpCollar = 71,
    EtfmtfnavTradepriceinbp = 72,
    EtfmtfnavDarkTradepriceinbp = 73,
    NewBidonWholesaleRfc = 74,
    NewOfferonWholesaleRfc = 75,
    UpdatedBidonWholesaleRfc = 76,
    UpdatedOfferonWholesaleRfc = 77,
    ClearWholesaleRfc = 78,
    GuaranteedCrossNegotiateddealNliq = 79,
    GuaranteedCrossNegotiateddealOilq = 80,
    LargeinScaleTrade = 81,
    LargeinScaleTradeinbasispoints = 82,
    LargeinScalePackageTradeinbasispoints = 83,
    StrategyLegLargeinScaleTradeinbasispoints = 84,
    NewBidRfqAnswer = 86,
    NewOfferRfqAnswer = 87,
    UpdatedBidRfqAnswer = 88,
    UpdatedOfferRfqAnswer = 89,
    BidExecutionSummary = 90,
    AqsExpansionFactor = 91,
    CollarsExpansionFactor = 92,
    CollarsEnabled = 93,
    CollarsDisabled = 94,
    DcrpInterMonthSpread = 95,
    FspReferencePrice = 96,
    OfferExecutionSummary = 97,
    FspTriggered = 98,
    MidPointBbo = 99,
    ConventionalTradeProvisionalprice = 100,
    ClearBook = 254,
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
    public Emm Emm;
    public ulong EventTime;
    public fixed sbyte TradingDateTime[27];
    public fixed sbyte PublicationDateTime[27];
    public TradeType TradeType;
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
    public EfficientMmtMarketMechanism EfficientMmtMarketMechanism;
    public EfficientMmtTradingMode EfficientMmtTradingMode;
    public EfficientMmtTransactionCategory EfficientMmtTransactionCategory;
    public EfficientMmtNegotiationIndicator EfficientMmtNegotiationIndicator;
    public EfficientMmtAgencyCrossTradeIndicator EfficientMmtAgencyCrossTradeIndicator;
    public EfficientMmtModificationIndicator EfficientMmtModificationIndicator;
    public EfficientMmtBenchmarkIndicator EfficientMmtBenchmarkIndicator;
    public EfficientMmtSpecialDividendIndicator EfficientMmtSpecialDividendIndicator;
    public EfficientMmtOffBookAutomatedIndicator EfficientMmtOffBookAutomatedIndicator;
    public EfficientMmtContributiontoPrice EfficientMmtContributiontoPrice;
    public EfficientMmtAlgorithmicIndicator EfficientMmtAlgorithmicIndicator;
    public EfficientMmtPublicationMode EfficientMmtPublicationMode;
    public EfficientMmtPostTradeDeferral EfficientMmtPostTradeDeferral;
    public EfficientMmtDuplicativeIndicator EfficientMmtDuplicativeIndicator;
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
    public QuoteUpdateType QuoteUpdateType;
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
    public OptionType OptionType;
    public long StrikePrice;
    public byte StrikePriceDecimals;
    public ExerStyle ExerStyle;
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
    public OptiqSegment OptiqSegment;
    public fixed sbyte IsinCode[12];
    public fixed sbyte SedolCode[7];
    public fixed sbyte LongIssuerName[250];
    public fixed sbyte LongInstrumentName[250];
    public fixed sbyte Currency[3];
    public ushort DateOfInitialListing;
    public long ShareAmountInIssue;
    public OpenedClosedFund OpenedClosedFund;
    public long LastNavPrice;
    public GrossOfCdscIndicator GrossOfCdscIndicator;
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
    public TaxDescriptionAttachingToADividend TaxDescriptionAttachingToADividend;
    public fixed sbyte NextMeeting[8];
    public long GrossDividendInEuros;
    public ushort IssueDate;
    public fixed sbyte IssuingCountry[3];
    public fixed sbyte Cfi[6];
    public PaymentFrequency PaymentFrequency;
    public long MinimumAmount;
    public InstrumentCategory InstrumentCategory;
    public SecurityCondition SecurityCondition;
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
    public SecurityCondition SecurityCondition;
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
    public MmtTradingMode MmtTradingMode;
    public fixed sbyte MifidPriceNotation[4];
    public fixed sbyte QuantityNotation[3];
    public long NotionalAmountTraded;
    public fixed sbyte TradingCurrency[3];
};

/// <summary>
///  Struct for Bfnav Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BfnavMessage {
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
///  Struct for Contract Em M Properties Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContractEmMPropertiesGroup {
    public Emm Emm;
    public ushort TickSizeIndexId;
    public ushort PatternId;
    public ulong LotSize;
    public fixed byte StrategyAuthorized[0];
    public DynamicCollarLogic DynamicCollarLogic;
    public byte CollarMaxUnhaltNb;
    public uint CollarUnhaltDelay;
};

/// <summary>
///  Struct for Contract Em M Properties Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContractEmMPropertiesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Contract Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ContractStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public OptiqSegment OptiqSegment;
    public ushort PartitionId;
    public ushort ContractEventDate;
    public ExchangeCode ExchangeCode;
    public ExerStyle ExerStyle;
    public fixed sbyte ContractName[60];
    public ContractType ContractType;
    public UnderlyingType UnderlyingType;
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
    public fixed byte OrderTypeRules[0];
    public fixed sbyte SettlementMethod[1];
    public fixed sbyte TradingCurrency[3];
    public byte StrikePriceDecimalsRatio;
    public fixed byte MmProtections[0];
    public ContractTradingType ContractTradingType;
    public InstUnitExp InstUnitExp;
    public UnderlyingSubtype UnderlyingSubtype;
    public fixed sbyte MotherStockIsin[12];
    public ulong SettlementTickSize;
    public ulong EdspTickSize;
    public uint UnderlyingSymbolIndex;
    public TradingPolicy TradingPolicy;
    public ushort ReferenceSpreadTableId;
    public DerivativesMarketModel DerivativesMarketModel;
    public ulong TradingUnit;
    public ReferencePriceOriginInOpeningCall ReferencePriceOriginInOpeningCall;
    public ReferencePriceOriginInContinuous ReferencePriceOriginInContinuous;
    public ReferencePriceOriginInTradingInterruption ReferencePriceOriginInTradingInterruption;
    public byte CollarExpansionFactor;
    public byte MifidiiLiquidFlag;
    public PricingAlgorithm PricingAlgorithm;
};

/// <summary>
///  Struct for Em M Pattern Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EmMPatternRepGroup {
    public Emm Emm;
    public ushort PatternId;
    public ushort TickSizeIndexId;
    public MarketModel MarketModel;
    public ulong LotSize;
    public InstUnitExp InstUnitExp;
    public Anonymous Anonymous;
};

/// <summary>
///  Struct for Em M Pattern Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EmMPatternRepGroups {
    public fixed byte GroupSizeEncoding[0];
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
    public Emm Emm;
    public ulong EventTime;
    public uint SymbolIndex;
    public fixed sbyte TradingDateTime[27];
    public fixed sbyte PublicationDateTime[27];
    public TradeType TradeType;
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
    public MmtMarketMechanism MmtMarketMechanism;
    public MmtTradingMode MmtTradingMode;
    public fixed sbyte MmtTransactionCategory[4];
    public fixed sbyte MmtNegotiationIndicator[4];
    public fixed sbyte MmtAgencyCrossTradeIndicator[4];
    public fixed sbyte MmtModificationIndicator[4];
    public fixed sbyte MmtBenchmarkIndicator[4];
    public fixed sbyte MmtSpecialDividendIndicator[4];
    public MmtOffBookAutomatedIndicator MmtOffBookAutomatedIndicator;
    public fixed sbyte MmtContributiontoPrice[4];
    public fixed sbyte MmtAlgorithmicIndicator[4];
    public fixed sbyte MmtPublicationMode[4];
    public fixed sbyte MmtPostTradeDeferral[4];
    public fixed sbyte MmtDuplicativeIndicator[4];
    public fixed byte TradeQualifier[0];
    public TransactionType TransactionType;
    public EffectiveDateIndicator EffectiveDateIndicator;
    public BlockTradeCode BlockTradeCode;
    public fixed sbyte TradeReference[30];
    public ulong OriginalReportTimestamp;
    public TransparencyIndicator TransparencyIndicator;
    public uint CurrencyCoefficient;
    public uint PriceMultiplier;
    public byte PriceMultiplierDecimals;
    public fixed sbyte Venue[11];
    public uint StartTimeVwap;
    public uint EndTimeVwap;
    public fixed sbyte MiFidEmissionAllowanceType[4];
    public fixed sbyte MarketOfReferenceMic[4];
    public long EvaluatedPrice;
    public MessagePriceNotation MessagePriceNotation;
    public ushort SettlementDate;
    public ushort RepoSettlementDate;
};

/// <summary>
///  Struct for Group Size Encoding
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSizeEncoding {
    public byte BlockLengthUint8;
    public byte NumInGroup;
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
    public Emm Emm;
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
///  Struct for Interest Payment Date Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InterestPaymentDateRepGroup {
    public ushort InterestPaymentDate;
};

/// <summary>
///  Struct for Interest Payment Date Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InterestPaymentDateRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Lis Package Structure Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LisPackageStructureMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
    public ulong EventTime;
    public uint ContractSymbolIndex;
    public fixed sbyte MifidExecutionId[52];
    public StrategyCode StrategyCode;
};

/// <summary>
///  Struct for Long Order Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LongOrderUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
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
///  Struct for Market States Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatesGroup {
    public ChangeType ChangeType;
    public uint SymbolIndex;
    public ulong EventTime;
    public BookState BookState;
    public StatusReason StatusReason;
    public fixed byte PhaseQualifier[0];
    public TradingPeriod TradingPeriod;
    public TradingSide TradingSide;
    public PriceLimits PriceLimits;
    public QuoteSpreadMultiplier QuoteSpreadMultiplier;
    public OrderEntryQualifier OrderEntryQualifier;
    public Session Session;
    public ScheduledEvent ScheduledEvent;
    public ulong ScheduledEventTime;
    public InstrumentState InstrumentState;
};

/// <summary>
///  Struct for Market States Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Market Status Change Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatusChangeMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
};

/// <summary>
///  Struct for Market Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
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
    public ushort BlockLengthUint16;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Mm Protections
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmProtections {
    public fixed byte Reserved6[6];
    public fixed byte Volume[1];
    public fixed byte Delta[1];
};

/// <summary>
///  Struct for New Stats Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewStatsGroup {
    public StatsUpdateType StatsUpdateType;
    public long StatsUpdateValue;
};

/// <summary>
///  Struct for New Stats Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewStatsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Not Used Group 1 Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotUsedGroup1Groups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Order Type Rules
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderTypeRules {
    public fixed byte Reserved10[10];
    public fixed byte TradeAtSettlement[1];
    public fixed byte MarketOnOpenMoo[1];
    public fixed byte StopLimit[1];
    public fixed byte StopStopLoss[1];
    public fixed byte Limit[1];
    public fixed byte Market[1];
};

/// <summary>
///  Struct for Order Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Orders Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrdersGroup {
    public uint SymbolIndex;
    public ActionType ActionType;
    public ulong OrderPriority;
    public ulong PreviousPriority;
    public OrderType OrderType;
    public long OrderPx;
    public OrderSide OrderSide;
    public ulong OrderQuantity;
    public sbyte PegOffset;
};

/// <summary>
///  Struct for Orders Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrdersGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Outright Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightRepGroup {
    public Emm Emm;
};

/// <summary>
///  Struct for Outright Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightRepGroups {
    public fixed byte GroupSizeEncoding[0];
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
    public DerivativesInstrumentType DerivativesInstrumentType;
    public ExpiryCycleType ExpiryCycleType;
    public fixed sbyte UnderlyingDerivativesInstrumentTradingCode[18];
    public uint UnderlyingSymbolIndex;
    public ulong TradingUnit;
};

/// <summary>
///  Struct for Package Components Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PackageComponentsGroup {
    public uint LegSymbolIndex;
    public uint LegRatio;
    public long LegLastPx;
    public ulong LegLastQty;
};

/// <summary>
///  Struct for Package Components Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PackageComponentsGroups {
    public fixed byte GroupSizeEncoding[0];
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
///  Struct for Phase Qualifier
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PhaseQualifier {
    public fixed byte Reserved10[10];
    public fixed byte WholesaleAllowed[1];
    public fixed byte Suspended[1];
    public fixed byte RandomUncrossing[1];
    public fixed byte TradingAtLast[1];
    public fixed byte CallBboOnly[1];
    public fixed byte NoQualifier[1];
};

/// <summary>
///  Struct for Price Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriceUpdateMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
    public ulong EventTime;
};

/// <summary>
///  Struct for Prices Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PricesGroup {
    public PriceType PriceType;
    public uint SymbolIndex;
    public long Price;
    public ulong Quantity;
    public ulong ImbalanceQty;
    public ImbalanceQtySide ImbalanceQtySide;
};

/// <summary>
///  Struct for Prices Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PricesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Real Time Index Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RealTimeIndexMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
    public ulong EventTime;
    public uint SymbolIndex;
    public long IndexLevel;
    public ulong PctgOfCapitalization;
    public long PrctVarfromPrevClose;
    public ushort NumTradedInstruments;
    public IndexLevelType IndexLevelType;
    public IndexPriceCode IndexPriceCode;
};

/// <summary>
///  Struct for Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public uint SymbolIndex;
    public OptiqSegment OptiqSegment;
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
    public GuaranteeIndicator GuaranteeIndicator;
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
    public TradingCurrencyIndicator TradingCurrencyIndicator;
    public StrikeCurrencyIndicator StrikeCurrencyIndicator;
    public ulong NumberInstrumentCirculating;
    public ulong ParValue;
    public fixed sbyte QuantityNotation[3];
    public InstUnitExp InstUnitExp;
    public fixed sbyte SettlementDelay[2];
    public fixed sbyte StrikeCurrency[3];
    public TaxCode TaxCode;
    public fixed sbyte TypeOfCorporateEvent[2];
    public TypeOfMarketAdmission TypeOfMarketAdmission;
    public RepoIndicator RepoIndicator;
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
///  Struct for Strategy Authorized
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyAuthorized {
    public fixed byte Reserved16[16];
    public fixed byte PutStraddleVersusSellACallOrAPut[1];
    public fixed byte PutSpreadVersusSellACall[1];
    public fixed byte CallSpreadVersusSellAPut[1];
    public fixed byte IronCondor[1];
    public fixed byte IronCondorVersusUnderlying[1];
    public fixed byte BuyWrite[1];
    public fixed byte CondorVersusUnderlying[1];
    public fixed byte StraddleVersusUnderlying[1];
    public fixed byte Synthetic[1];
    public fixed byte DiagonalStraddleCalendarSpreadVersusUnderlying[1];
    public fixed byte PutSpreadVersusCallVersusUnderlying[1];
    public fixed byte StraddleCalendarSpreadVersusUnderlying[1];
    public fixed byte ExchangeForPhysical[1];
    public fixed byte StrangleVersusUnderlying[1];
    public fixed byte ComboVersusUnderlying[1];
    public fixed byte IronButterflyVersusUnderlying[1];
    public fixed byte TwoByOneCallOrPutRatioSpreadVersusUnderlying[1];
    public fixed byte GutsVersusUnderlying[1];
    public fixed byte CallPutDiagonalCalendarSpreadVersusUnderlying[1];
    public fixed byte CallOrPutCalendarSpreadVersusUnderlying[1];
    public fixed byte CallOrPutSpreadVersusUnderlying[1];
    public fixed byte CallSpreadVersusPutVersusUnderlying[1];
    public fixed byte ButterflyVersusUnderlying[1];
    public fixed byte LadderVersusUnderlying[1];
    public fixed byte ReducedTickSpread[1];
    public fixed byte Bundle[1];
    public fixed byte Box[1];
    public fixed byte Condor[1];
    public fixed byte VolatilityTrade[1];
    public fixed byte Straddle[1];
    public fixed byte ConversionReversal[1];
    public fixed byte SimpleInterCommoditySpread[1];
    public fixed byte DiagonalStraddleCalendarSpread[1];
    public fixed byte Pack[1];
    public fixed byte StraddleCalendarSpread[1];
    public fixed byte Strip[1];
    public fixed byte Ladder[1];
    public fixed byte Strangle[1];
    public fixed byte Combo[1];
    public fixed byte IronButterfly[1];
    public fixed byte TwoByOneRatioSpread[1];
    public fixed byte Guts[1];
    public fixed byte DiagonalCalendarSpread[1];
    public fixed byte CalendarSpread[1];
    public fixed byte Spread[1];
    public fixed byte CallOrPutCabinet[1];
    public fixed byte Butterfly[1];
    public fixed byte JellyRoll[1];
};

/// <summary>
///  Struct for Strategy Standing Data Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyStandingDataMessage {
    public ulong MdSeqNum;
    public byte RebroadcastIndicator;
    public Emm Emm;
    public uint SymbolIndex;
    public fixed sbyte DerivativesInstrumentTradingCode[18];
    public ExchangeCode ExchangeCode;
    public fixed sbyte MaturityDate[8];
    public StrategyCode StrategyCode;
    public uint ContractSymbolIndex;
    public fixed sbyte Cfi[6];
};

/// <summary>
///  Struct for Strategy Standing Datarep 1 Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyStandingDatarep1Group {
    public uint LegSymbolIndex;
    public long LegPrice;
    public uint LegRatio;
    public LegBuySell LegBuySell;
};

/// <summary>
///  Struct for Strategy Standing Datarep 1 Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyStandingDatarep1Groups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Technical Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TechnicalNotificationMessage {
    public ulong MdSeqNum;
    public TechnicalNotificationType TechnicalNotificationType;
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
    public Emm Emm;
    public ushort PatternId;
    public uint SymbolIndex;
};

/// <summary>
///  Struct for Timetables Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimetablesGroup {
    public ulong PhaseTime;
    public PhaseId PhaseId;
    public fixed byte PhaseQualifier[0];
    public TradingPeriod TradingPeriod;
    public OrderEntryQualifier OrderEntryQualifier;
    public Session Session;
    public ScheduledEvent ScheduledEvent;
};

/// <summary>
///  Struct for Timetables Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimetablesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Trade Qualifier
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeQualifier {
    public fixed byte DeferredPublication[1];
    public fixed byte NavTradeExpressedInPriceCurrency[1];
    public fixed byte NavTradeExpressedInBps[1];
    public fixed byte TradeCreationByMarketOperations[1];
    public fixed byte AggressiveOrder[1];
    public fixed byte PassiveOrder[1];
    public fixed byte FirstTradePrice[1];
    public fixed byte UncrossingTrade[1];
};

/// <summary>
///  Struct for Updates Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UpdatesGroup {
    public UpdateType UpdateType;
    public uint SymbolIndex;
    public ushort NumberOfOrders;
    public long Price;
    public ulong Quantity;
};

/// <summary>
///  Struct for Updates Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UpdatesGroups {
    public fixed byte GroupSizeEncoding[0];
};

