// C# Structs For Box Options Sola Hsvf Unicast 4.5.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Ask Price Sign Values
/// </summary>
public enum AskPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Auction Type Values
/// </summary>
public enum AuctionType : byte {
    RegularPip = (byte)'G',
    Solicitation = (byte)'B',
    Facilitation = (byte)'C',
    ExposedOrder = (byte)'F',
};

/// <summary>
///  Bulletin Type Values
/// </summary>
public enum BulletinType : byte {
    Regular = (byte)'1',
    Special = (byte)'2',
};

/// <summary>
///  Complex Order Instrument Allow Implied Values
/// </summary>
public enum ComplexOrderInstrumentAllowImplied : byte {
    No = (byte)'N',
    ContinuousImplied = (byte)'C',
    SnapshotImplied = (byte)'S',
};

/// <summary>
///  Continue Marker Values
/// </summary>
public enum ContinueMarker : byte {
    BulletinContinuesInNextRecord = (byte)'0',
    BulletinEnded = (byte)'1',
};

/// <summary>
///  Deletion Type Values
/// </summary>
public enum DeletionType : byte {
    PreciseOrder = (byte)'1',
    AllPreviousOrdersInTheSpecifiedSide = (byte)'2',
    AllOrders = (byte)'3',
};

/// <summary>
///  Delivery Month Values
/// </summary>
public enum DeliveryMonth : byte {
    JanuaryPut = (byte)'M',
    FebruaryPut = (byte)'N',
    MarchPut = (byte)'O',
    AprilPut = (byte)'P',
    MayPut = (byte)'Q',
    JunePut = (byte)'R',
    JulyPut = (byte)'S',
    AugustPut = (byte)'T',
    SeptemberPut = (byte)'U',
    OctoberPut = (byte)'V',
    NovemberPut = (byte)'W',
};

/// <summary>
///  Expiry Month Code Values
/// </summary>
public enum ExpiryMonthCode : byte {
    JanuaryPut = (byte)'M',
    FebruaryPut = (byte)'N',
    MarchPut = (byte)'O',
    AprilPut = (byte)'P',
    MayPut = (byte)'Q',
    JunePut = (byte)'R',
    JulyPut = (byte)'S',
    AugustPut = (byte)'T',
    SeptemberPut = (byte)'U',
    OctoberPut = (byte)'V',
    NovemberPut = (byte)'W',
};

/// <summary>
///  Gap Control Values
/// </summary>
public enum GapControl : byte {
    WillReceiveGapMessages = (byte)'0',
    WillNotReceiveGapMessages = (byte)'1',
};

/// <summary>
///  Group Status Values
/// </summary>
public enum GroupStatus : byte {
    PreopeningPhase = (byte)'Y',
    OpeningPhase = (byte)'O',
    OpenedForTrading = (byte)'T',
    ForbiddenPhase = (byte)'F',
    TradingHalted = (byte)'H',
    SurveillanceInterventionPhase = (byte)'A',
    Closed = (byte)'C',
    BeginningOfDayInquiries = (byte)'C',
};

/// <summary>
///  High Price Sign Values
/// </summary>
public enum HighPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Improvement Order Side Values
/// </summary>
public enum ImprovementOrderSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    All = (byte)' ',
};

/// <summary>
///  Initial Order Price Sign Values
/// </summary>
public enum InitialOrderPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Initial Order Side Values
/// </summary>
public enum InitialOrderSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Instrument Status Marker Values
/// </summary>
public enum InstrumentStatusMarker : byte {
    PreopeningPhase = (byte)'Y',
    OpeningPhase = (byte)'O',
    OpenedForTrading = (byte)'T',
    ForbiddenPhase = (byte)'F',
    TradingHalted = (byte)'H',
    ReservedPhase = (byte)'R',
    SuspendedPhase = (byte)'S',
    Frozen = (byte)'Z',
    SurveillanceInterventionPhase = (byte)'A',
    Closed = (byte)'C',
    BeginningOfDayInquiries = (byte)'C',
};

/// <summary>
///  Leg Ratio Sign Values
/// </summary>
public enum LegRatioSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Level Of Market Depth Values
/// </summary>
public enum LevelOfMarketDepth : byte {
    Level1 = (byte)'1',
    Level2 = (byte)'2',
    Level3 = (byte)'3',
    Level4 = (byte)'4',
    Level5 = (byte)'5',
    Level6 = (byte)'6',
    ImpliedPrice = (byte)'A',
    PublicCustomerVolume = (byte)'P',
};

/// <summary>
///  Limit Entered For An Order Sign Values
/// </summary>
public enum LimitEnteredForAnOrderSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Low Price Sign Values
/// </summary>
public enum LowPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Market Summaries Values
/// </summary>
public enum MarketSummaries : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Max Threshold Price Sign Values
/// </summary>
public enum MaxThresholdPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Min Threshold Price Sign Values
/// </summary>
public enum MinThresholdPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Net Change Sign Values
/// </summary>
public enum NetChangeSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Open Price Sign Values
/// </summary>
public enum OpenPriceSign : byte {
    Positive = (byte)'+',
    Negative = (byte)'-',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    American = (byte)'A',
    European = (byte)'E',
};

/// <summary>
///  Order Side Values
/// </summary>
public enum OrderSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Price Indicator Marker Values
/// </summary>
public enum PriceIndicatorMarker : byte {
    AsOfTrade = (byte)'A',
    TradesPerformedAtTheEndOfAPipAllocationPhase = (byte)'C',
    LateTrade = (byte)'L',
    TradesPerformedDuringTheOpening = (byte)'O',
    ReferencePrice = (byte)'S',
    TradesResultingFromTheTransmissionOfAnIsoInboundOrder = (byte)'W',
    TradesPerformedWhenTheMarketIsCrossed = (byte)'X',
    ContingentTradePriceOfTheTradeWasNotControlledAgainstTheNbbo = (byte)'G',
    TradeInvolvingAnImpliedOrderOrLegTradeOfAComplexOrderInstrument = (byte)'I',
    TradeDoneOnAComplexOrderInstrument = (byte)'P',
    ActualTransactionTookPlace = (byte)' ',
};

/// <summary>
///  Tick Values
/// </summary>
public enum Tick : byte {
    Uptick = (byte)'+',
    Downtick = (byte)'-',
};

/// <summary>
///  Type Of Clearing Account Values
/// </summary>
public enum TypeOfClearingAccount : byte {
    PublicCustomer = (byte)'6',
    BrokerDealer = (byte)'7',
    MarketMaker = (byte)'8',
    ProfessionalCustomer = (byte)'T',
    BrokerDealerClearedAsCustomer = (byte)'W',
    AwayMarketMaker = (byte)'X',
};

/// <summary>
///  Type Of Instrument Values
/// </summary>
public enum TypeOfInstrument : byte {
    Options = (byte)'O',
    LongTerm = (byte)'L',
};

/// <summary>
///  Type Of Market Data Values
/// </summary>
public enum TypeOfMarketData : byte {
    MarketDepthMessagesOnTheTop5BidsasksForTheTypeOfTradingInstrumentsChosen = (byte)'Y',
    Best = (byte)'N',
    Trade = (byte)'T',
    PriceImprovementAndExposedOrderMessages = (byte)'P',
    MarketDepthMessagesOnTheTop5AndTheCalculatedImpliedBestLimit = (byte)'I',
    QuoteMessageOnTheFirstLevelAndTheCalculatedImpliedBestLimit = (byte)'G',
};

/// <summary>
///  Type Of Options Values
/// </summary>
public enum TypeOfOptions : byte {
    Regular = (byte)' ',
};

/// <summary>
///  Type Of Order Values
/// </summary>
public enum TypeOfOrder : byte {
    InitialOrder = (byte)'A',
    ExposedOrder = (byte)'P',
};

/// <summary>
///  Type Of Underlying Values
/// </summary>
public enum TypeOfUnderlying : byte {
    Index = (byte)'X',
    Equities = (byte)'E',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Beginning Of Complex Order Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfComplexOrderSummaryMessage {
    public fixed sbyte ExchangeId[1];
};

/// <summary>
///  Struct for Beginning Of Options Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfOptionsSummaryMessage {
    public fixed sbyte ExchangeId[1];
};

/// <summary>
///  Struct for Bulletins Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BulletinsMessage {
    public fixed sbyte Filler1[1];
    public BulletinType BulletinType;
    public fixed sbyte BulletinContents[79];
    public ContinueMarker ContinueMarker;
};

/// <summary>
///  Struct for Circuit Assurance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CircuitAssuranceMessage {
    public fixed sbyte Time[6];
};

/// <summary>
///  Struct for Complex Market Depth Level
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexMarketDepthLevel {
    public LevelOfMarketDepth LevelOfMarketDepth;
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public AskPriceSign AskPriceSign;
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Complex Order Group Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderGroupStatusMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte GroupOfTheComplexOrderInstrument[2];
    public GroupStatus GroupStatus;
};

/// <summary>
///  Struct for Complex Order Improvement Process Beginning Message Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderImprovementProcessBeginningMessageMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public InitialOrderPriceSign InitialOrderPriceSign;
    public fixed sbyte InitialOrderPrice[6];
    public fixed sbyte InitialOrderPriceFractionIndicator[1];
    public fixed sbyte InitialOrderQuantity[8];
    public InitialOrderSide InitialOrderSide;
    public fixed sbyte ImprovementPhaseExpiryTime[8];
    public fixed sbyte ImprovementProcessExpiryDuration[4];
    public fixed sbyte MinimumQuantityForImprovementOrder[8];
    public fixed sbyte PercentageAssuredToInitialOrder[8];
    public AuctionType AuctionType;
};

/// <summary>
///  Struct for Complex Order Initial And Improvement Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderInitialAndImprovementOrderMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public DeletionType DeletionType;
    public fixed sbyte OrderSequenceNumber[6];
    public OrderSide OrderSide;
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public AuctionType AuctionType;
};

/// <summary>
///  Struct for Complex Order Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderInstrumentKeysMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte ExpiryYear[2];
    public DeliveryMonth DeliveryMonth;
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte MaxNumberOfContractsPerOrder[6];
    public fixed sbyte MinNumberOfContractsPerOrder[6];
    public MaxThresholdPriceSign MaxThresholdPriceSign;
    public fixed sbyte MaxThresholdPrice[6];
    public fixed sbyte MaxThresholdPriceFractionIndicator[1];
    public MinThresholdPriceSign MinThresholdPriceSign;
    public fixed sbyte MinThresholdPrice[6];
    public fixed sbyte MinThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public fixed sbyte FillerX2[2];
    public fixed sbyte Group[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public ComplexOrderInstrumentAllowImplied ComplexOrderInstrumentAllowImplied;
    public fixed sbyte NumberOfLegs[2];
};

/// <summary>
///  Struct for Complex Order Instrument Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderInstrumentTradeMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePriceSign[1];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public NetChangeSign NetChangeSign;
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicator[1];
    public fixed sbyte Filler6[6];
    public fixed sbyte Timestamp[6];
    public PriceIndicatorMarker PriceIndicatorMarker;
};

/// <summary>
///  Struct for Complex Order Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderMarketDepthMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public InstrumentStatusMarker InstrumentStatusMarker;
    public fixed sbyte NumberOfLevels[1];
};

/// <summary>
///  Struct for Complex Order Market Sheet Initial And Improvement Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderMarketSheetInitialAndImprovementOrderMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public OrderSide OrderSide;
    public TypeOfOrder TypeOfOrder;
    public LimitEnteredForAnOrderSign LimitEnteredForAnOrderSign;
    public fixed sbyte Filler1[1];
    public fixed sbyte LimitFractionIndicator[1];
    public fixed sbyte OrderQuantity[8];
    public fixed sbyte OrderSequenceNumber[6];
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public TypeOfClearingAccount TypeOfClearingAccount;
    public fixed sbyte Filler1[1];
    public fixed sbyte EndOfTheExposition[8];
    public AuctionType AuctionType;
    public fixed sbyte FirmId[4];
    public fixed sbyte Cmta[4];
};

/// <summary>
///  Struct for Complex Order Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderQuoteMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public AskPriceSign AskPriceSign;
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public InstrumentStatusMarker InstrumentStatusMarker;
    public fixed sbyte PublicCustomerBidSize[5];
    public fixed sbyte PublicCustomerAskSize[5];
};

/// <summary>
///  Struct for Complex Order Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderSummaryMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public AskPriceSign AskPriceSign;
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPriceSign[1];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public OpenPriceSign OpenPriceSign;
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public HighPriceSign HighPriceSign;
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public LowPriceSign LowPriceSign;
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public NetChangeSign NetChangeSign;
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicator[1];
    public fixed sbyte Volume[8];
};

/// <summary>
///  Struct for Complex Order Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexOrderTradeCancellationMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte ComplexOrderInstrumentSymbol[30];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePriceSign[1];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte Filler6[6];
    public fixed sbyte Timestamp[6];
    public PriceIndicatorMarker PriceIndicatorMarker;
};

/// <summary>
///  Struct for Connection Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ConnectionMessage {
    public fixed sbyte ResetSequence[10];
    public fixed sbyte SystemDefault[1];
    public fixed sbyte SystemValue[1];
    public TypeOfMarketData TypeOfMarketData;
    public fixed sbyte ComplexOrder[1];
    public MarketSummaries MarketSummaries;
    public GapControl GapControl;
    public fixed sbyte HsvfProtocol[2];
    public fixed sbyte NumberOfOptionClassesRequested[3];
    public fixed byte OptionClassesRequested[0];
};

/// <summary>
///  Struct for End Of Sales Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSalesMessage {
    public fixed sbyte Reserved[1];
    public fixed sbyte Time[6];
};

/// <summary>
///  Struct for End Of Transmission Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTransmissionMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte Time[6];
};

/// <summary>
///  Struct for Gap Sequence Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GapSequenceMessage {
    public fixed sbyte SequenceNumbersSkipped[9];
};

/// <summary>
///  Struct for Group Opening Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupOpeningTimeMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte RootSymbol[6];
    public GroupStatus GroupStatus;
    public fixed sbyte ScheduledTime[6];
};

/// <summary>
///  Struct for Group Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupStatusMessage {
    public fixed sbyte ExchangeId[1];
    public fixed sbyte RootSymbol[6];
    public GroupStatus GroupStatus;
};

/// <summary>
///  Struct for Initial And Improvement Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InitialAndImprovementOrderMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public DeletionType DeletionType;
    public fixed sbyte OrderSequenceNumber[6];
    public ImprovementOrderSide ImprovementOrderSide;
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public AuctionType AuctionType;
};

/// <summary>
///  Struct for Instrument Description
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentDescription {
    public fixed sbyte RootSymbol[6];
    public ExpiryMonthCode ExpiryMonthCode;
    public fixed sbyte Filler1[1];
    public fixed sbyte StrikePrice[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
};

/// <summary>
///  Struct for Instrument Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentLeg {
    public LegRatioSign LegRatioSign;
    public fixed sbyte LegRatio[8];
    public fixed sbyte LegSymbol[30];
};

/// <summary>
///  Struct for Market Depth Level
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketDepthLevel {
    public LevelOfMarketDepth LevelOfMarketDepth;
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Market Flow Indicator
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketFlowIndicator {
    public TypeOfInstrument TypeOfInstrument;
    public TypeOfUnderlying TypeOfUnderlying;
};

/// <summary>
///  Struct for Market Sheet Initial And Improvement Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSheetInitialAndImprovementOrderMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public OrderSide OrderSide;
    public TypeOfOrder TypeOfOrder;
    public fixed sbyte Filler1[1];
    public fixed sbyte LimitFractionIndicator[1];
    public fixed sbyte OrderQuantity[8];
    public fixed sbyte OrderSequenceNumber[6];
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public TypeOfClearingAccount TypeOfClearingAccount;
    public fixed sbyte Filler1[1];
    public fixed sbyte EndOfTheExposition[8];
    public AuctionType AuctionType;
    public fixed sbyte FirmId[4];
    public fixed sbyte Cmta[4];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public fixed sbyte SequenceNumber[9];
    public fixed sbyte MessageType[2];
};

/// <summary>
///  Struct for Option Improvement Process Beginning Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionImprovementProcessBeginningMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte ImprovementPhaseSequentialNumber[6];
    public fixed sbyte InitialOrderPrice[6];
    public fixed sbyte InitialOrderPriceFractionIndicator[1];
    public fixed sbyte InitialOrderQuantity[8];
    public InitialOrderSide InitialOrderSide;
    public fixed sbyte ImprovementPhaseExpiryTime[8];
    public fixed sbyte ImprovementProcessExpiryDuration[4];
    public fixed sbyte MinimumQuantityForImprovementOrder[8];
    public fixed sbyte PercentageAssuredToInitialOrder[8];
    public AuctionType AuctionType;
    public fixed sbyte Filler1[1];
};

/// <summary>
///  Struct for Option Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionInstrumentKeysMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte StrikePriceCurrency[3];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPrice[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPrice[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public OptionType OptionType;
    public fixed sbyte MarketFlowIndicator[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public fixed sbyte OptionMarker[2];
    public fixed sbyte UnderlyingSymbolRoot[10];
};

/// <summary>
///  Struct for Option Marker
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionMarker {
    public fixed sbyte TypeOfMarket[1];
    public TypeOfOptions TypeOfOptions;
};

/// <summary>
///  Struct for Option Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionMarketDepthMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public InstrumentStatusMarker InstrumentStatusMarker;
    public fixed sbyte NumberOfLevels[1];
};

/// <summary>
///  Struct for Option Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionQuoteMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte Filler1[1];
    public InstrumentStatusMarker InstrumentStatusMarker;
    public fixed sbyte PublicCustomerBidSize[5];
    public fixed sbyte PublicCustomerAskSize[5];
};

/// <summary>
///  Struct for Option Request For Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionRequestForQuoteMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte RequestedSize[8];
};

/// <summary>
///  Struct for Option Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionSummaryMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte BidPrice[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPrice[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public fixed sbyte OpenInterest[7];
    public Tick Tick;
    public fixed sbyte Volume[8];
    public NetChangeSign NetChangeSign;
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicator[1];
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte OptionMarker[2];
    public fixed sbyte UnderlyingSymbol[10];
    public fixed sbyte ReferencePrice[6];
    public fixed sbyte ReferencePriceFractionIndicator[1];
};

/// <summary>
///  Struct for Option Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionTradeCancellationMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte Filler6[6];
    public fixed sbyte Timestamp[6];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte Filler1[1];
    public PriceIndicatorMarker PriceIndicatorMarker;
};

/// <summary>
///  Struct for Option Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionTradeMessage {
    public fixed sbyte ExchangeId[1];
    public fixed byte InstrumentDescription[0];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public NetChangeSign NetChangeSign;
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicator[1];
    public fixed sbyte Filler6[6];
    public fixed sbyte Timestamp[6];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte Filler1[1];
    public PriceIndicatorMarker PriceIndicatorMarker;
};

/// <summary>
///  Struct for System Timestamp Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemTimestampMessage {
    public fixed sbyte TradingEngineTimestamp[9];
};

