// C# Structs For Tmx Mx Sola Hsvf Multicast 1.11 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Bulletin Type Values
/// </summary>
public enum BulletinType : byte {
    RegularTextBulletin = (byte)'1',
    SpecialTextBulletin = (byte)'2',
};

/// <summary>
///  Call Put Code Values
/// </summary>
public enum CallPutCode : byte {
    Call = (byte)'C',
    Put = (byte)'P',
};

/// <summary>
///  Day Count Convention Values
/// </summary>
public enum DayCountConvention : byte {
    Act365 = (byte)'A',
    Act360 = (byte)'B',
    30360 = (byte)'C',
    StartOfDay = (byte)'S',
    EndOfDay = (byte)'E',
    InstrumentNewOrUpdate = (byte)'U',
    TradeCancellation = (byte)'C',
};

/// <summary>
///  Delivery Type Values
/// </summary>
public enum DeliveryType : byte {
    Cash = (byte)'C',
    Physical = (byte)'P',
};

/// <summary>
///  Leg Ratio Sign Values
/// </summary>
public enum LegRatioSign : byte {
    BuyOfTheUnderlying = (byte)'+',
    SellOfTheUnderlying = (byte)'-',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    American = (byte)'A',
    European = (byte)'E',
};

/// <summary>
///  Requested Market Side Values
/// </summary>
public enum RequestedMarketSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    Both = (byte)'2',
};

/// <summary>
///  Strategy Allow Implied Values
/// </summary>
public enum StrategyAllowImplied : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Tick Values
/// </summary>
public enum Tick : byte {
    Uptick = (byte)'+',
    Downtick = (byte)'-',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Beginning Of Future Options Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfFutureOptionsSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
};

/// <summary>
///  Struct for Beginning Of Futures Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfFuturesSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
};

/// <summary>
///  Struct for Beginning Of Options Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfOptionsSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
};

/// <summary>
///  Struct for Beginning Of Strategy Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BeginningOfStrategySummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
};

/// <summary>
///  Struct for Bulletins Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BulletinsMessage {
    public fixed sbyte Reserved[1];
    public BulletinType BulletinType;
};

/// <summary>
///  Struct for Circuit Assurance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CircuitAssuranceMessage {
    public fixed sbyte Time[6];
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
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte Time[6];
};

/// <summary>
///  Struct for Future Options Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsInstrumentKeysMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte StrikePriceCurrency[3];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPriceX6[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPriceX6[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public fixed sbyte MarketFlowIndicator[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public fixed sbyte ContractSize[8];
    public fixed sbyte TickValue[6];
    public fixed sbyte TickValueFractionIndicator[1];
    public fixed sbyte Currency[3];
    public DeliveryType DeliveryType;
};

/// <summary>
///  Struct for Future Options Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsMarketDepthMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte NumberOfLevel[1];
};

/// <summary>
///  Struct for Future Options Market Depth Trading Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsMarketDepthTradingInstrument {
    public fixed sbyte LevelOfMarketDepth[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Future Options Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsQuoteMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte FillerX1[1];
};

/// <summary>
///  Struct for Future Options Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsRfqMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte RequestedSize[8];
    public RequestedMarketSide RequestedMarketSide;
};

/// <summary>
///  Struct for Future Options Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte BidPriceN6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPrice[6];
    public fixed sbyte SettlementPriceFractionIndicatorX1[1];
    public fixed sbyte OpenInterest[7];
    public Tick Tick;
    public fixed sbyte Volume[8];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte OpeningPrice[6];
    public fixed sbyte OpeningPriceFractionIndicator[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte FillerX2[2];
    public fixed sbyte UnderlyingSymbolRootA3[3];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN1[1];
    public fixed sbyte SettlementPrice[6];
    public fixed sbyte SettlementPriceFractionIndicatorX1[1];
    public fixed sbyte PreviousSettlementPrice[6];
    public fixed sbyte PreviousSettlementPriceFractionIndicator[1];
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Future Options Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsTradeCancellationMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte Volume[8];
    public fixed sbyte Price[6];
    public fixed sbyte PriceFractionIndicator[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte FillerX6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX2[2];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Future Options Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsTradeCorrectionMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte NetChangeSignA1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorA1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX2[2];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Future Options Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureOptionsTradeMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte NetChangeSignA1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorA1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX2[2];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Futures Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesInstrumentKeysMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPriceN6[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPriceN6[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public fixed sbyte MarketFlowIndicator[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public fixed sbyte ContractSize[8];
    public fixed sbyte TickValue[6];
    public fixed sbyte TickValueFractionIndicator[1];
    public fixed sbyte Currency[3];
    public fixed sbyte UnderlyingSymbol[10];
    public DeliveryType DeliveryType;
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte ExpiryDay[2];
};

/// <summary>
///  Struct for Futures Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesMarketDepthMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte NumberOfLevel[1];
};

/// <summary>
///  Struct for Futures Market Depth Trading Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesMarketDepthTradingInstrument {
    public fixed sbyte LevelOfMarketDepth[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Futures Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesQuoteMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte InstrumentStatusMarkerA1[1];
};

/// <summary>
///  Struct for Futures Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesRfqMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte RequestedSize[8];
    public RequestedMarketSide RequestedMarketSide;
};

/// <summary>
///  Struct for Futures Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte BidPriceN6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte SettlementPrice[6];
    public fixed sbyte SettlementPriceFractionIndicatorX1[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte Volume[8];
    public fixed sbyte PreviousSettlement[6];
    public fixed sbyte PreviousSettlementFractionIndicator[1];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte Reason[1];
    public fixed sbyte ExternalPriceAtSource[6];
    public fixed sbyte ExternalPriceFractionIndicator[1];
};

/// <summary>
///  Struct for Futures Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesTradeCancellationMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Futures Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesTradeCorrectionMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Futures Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FuturesTradeMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Group Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupStatusMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte GroupStatus[1];
};

/// <summary>
///  Struct for Instrument Schedule Notice Future Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentScheduleNoticeFutureMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte DeliveryYearN2[2];
    public fixed sbyte DeliveryDay[2];
    public fixed sbyte SeriesStatus[1];
    public fixed sbyte ScheduledStatusChangeTime[6];
};

/// <summary>
///  Struct for Instrument Schedule Notice Futures Option Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentScheduleNoticeFuturesOptionMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ContractMonthCode[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public CallPutCode CallPutCode;
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte SeriesStatus[1];
    public fixed sbyte ScheduledStatusChangeTime[6];
};

/// <summary>
///  Struct for Instrument Schedule Notice Option Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentScheduleNoticeOptionMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceX7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte SeriesStatus[1];
    public fixed sbyte ScheduledStatusChangeTime[6];
};

/// <summary>
///  Struct for Instrument Schedule Notice Strategy Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentScheduleNoticeStrategyMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte StrategySymbol[30];
    public fixed sbyte SeriesStatus[1];
    public fixed sbyte ScheduledStatusChangeTime[6];
};

/// <summary>
///  Struct for Instrument Schedule Notice Swap Future Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentScheduleNoticeSwapFutureMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte SeriesStatus[1];
    public fixed sbyte ScheduledStatusChangeTime[6];
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
///  Struct for Option Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionInstrumentKeysMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte StrikePriceCurrency[3];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPriceX6[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPriceX6[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public OptionType OptionType;
    public fixed sbyte MarketFlowIndicator[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public fixed sbyte OptionMarker[2];
    public fixed sbyte UnderlyingSymbolRootX10[10];
    public fixed sbyte ContractSize[8];
    public fixed sbyte TickValue[6];
    public fixed sbyte TickValueFractionIndicator[1];
    public fixed sbyte Currency[3];
    public DeliveryType DeliveryType;
};

/// <summary>
///  Struct for Option Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionMarketDepthMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte NumberOfLevel[1];
};

/// <summary>
///  Struct for Option Market Depth Trading Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionMarketDepthTradingInstrument {
    public fixed sbyte LevelOfMarketDepth[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Option Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionQuoteMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte FillerX1[1];
    public fixed sbyte InstrumentStatusMarkerA1[1];
};

/// <summary>
///  Struct for Option Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionRfqMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte RequestedSize[8];
    public RequestedMarketSide RequestedMarketSide;
};

/// <summary>
///  Struct for Option Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte BidPriceN6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public fixed sbyte OpenInterest[7];
    public Tick Tick;
    public fixed sbyte Volume[8];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte OptionMarker[2];
    public fixed sbyte UnderlyingSymbolRootX10[10];
    public fixed sbyte SettlementPrice[6];
    public fixed sbyte SettlementPriceFractionIndicatorN1[1];
    public fixed sbyte PreviousSettlementPrice[6];
    public fixed sbyte PreviousSettlementPriceFractionIndicator[1];
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Option Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionTradeCancellationMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX1[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Option Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionTradeCorrectionMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignA1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX1[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Option Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionTradeMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte FillerA1[1];
    public fixed sbyte StrikePriceN7[7];
    public fixed sbyte StrikePriceFractionIndicator[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignA1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte FillerX1[1];
    public fixed sbyte PriceIndicatorMarkerA1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Regular Text Bulletin
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegularTextBulletin {
    public fixed sbyte RegularBulletinContents[79];
    public fixed sbyte ContinueMarker[1];
};

/// <summary>
///  Struct for Special Text Bulletin
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpecialTextBulletin {
    public fixed sbyte Symbol[30];
    public fixed sbyte BulletinContentsX49[49];
    public fixed sbyte ContinueMarker[1];
};

/// <summary>
///  Struct for Strategies Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategiesMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte GroupStatus[1];
};

/// <summary>
///  Struct for Strategy Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyInstrumentKeysMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte StrategySymbol[30];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte DeliveryMonth[1];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPriceX6[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPriceX6[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public fixed sbyte MarketFlowIndicator[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
    public StrategyAllowImplied StrategyAllowImplied;
};

/// <summary>
///  Struct for Strategy Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyMarketDepthMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte NumberOfLevel[1];
};

/// <summary>
///  Struct for Strategy Market Depth Trading Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyMarketDepthTradingInstrument {
    public fixed sbyte LevelOfMarketDepth[1];
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPriceSign[1];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Strategy Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyQuoteMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceSign[1];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte InstrumentStatusMarkerX1[1];
};

/// <summary>
///  Struct for Strategy Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyRfqMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte RequestedSize[8];
    public RequestedMarketSide RequestedMarketSide;
};

/// <summary>
///  Struct for Strategy Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategySummaryMessage {
    public fixed sbyte ExchangeIdX1[1];
    public fixed sbyte StrategySymbol[30];
    public fixed sbyte BidPriceSign[1];
    public fixed sbyte BidPriceN6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceSign[1];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPriceSign[1];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public fixed sbyte OpenPriceSign[1];
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public fixed sbyte HighPriceSign[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPriceSign[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte Volume[8];
    public fixed sbyte Reason[1];
    public fixed sbyte NumberOfLegs[2];
};

/// <summary>
///  Struct for Strategy Summary Strategy Leg
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategySummaryStrategyLeg {
    public LegRatioSign LegRatioSign;
    public fixed sbyte LegRatio[2];
    public fixed sbyte LegSymbol[30];
};

/// <summary>
///  Struct for Strategy Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyTradeCancellationMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePriceSign[1];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte FillerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Strategy Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyTradeCorrectionMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePriceSign[1];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Strategy Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyTradeMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte Symbol[30];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePriceSign[1];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte FillerN6[6];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Swap Future Beginning Of Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureBeginningOfSummaryMessage {
    public fixed sbyte ExchangeIdA1[1];
};

/// <summary>
///  Struct for Swap Future Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureInstrumentKeysMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte MaximumNumberOfContractsPerOrder[6];
    public fixed sbyte MinimumNumberOfContractsPerOrder[6];
    public fixed sbyte MaximumThresholdPriceX6[6];
    public fixed sbyte MaximumThresholdPriceFractionIndicator[1];
    public fixed sbyte MinimumThresholdPriceX6[6];
    public fixed sbyte MinimumThresholdPriceFractionIndicator[1];
    public fixed sbyte TickIncrement[6];
    public fixed sbyte TickIncrementFractionIndicator[1];
    public fixed sbyte MarketFlow[2];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte InstrumentId[4];
    public fixed sbyte ExternalSymbol[30];
    public fixed sbyte ContractSize[8];
    public fixed sbyte TickValue[6];
    public fixed sbyte TickValueFractionIndicator[1];
    public fixed sbyte Currency[3];
    public fixed sbyte EffectiveDate[6];
    public fixed sbyte InitialEffectiveDate[6];
    public fixed sbyte CashFlowAlignmentDate[6];
    public fixed sbyte PaymentFrequency[2];
    public fixed sbyte ResetFrequency[2];
    public fixed sbyte NotionalPrincipalAmount[8];
    public fixed sbyte NotionalPrincipalAmountFactionIndicator[1];
    public DayCountConvention DayCountConvention;
    public fixed sbyte FirstPaymentDate[6];
    public fixed sbyte NextPaymentDate[6];
    public fixed sbyte FirstResetDate[6];
    public fixed sbyte NextResetDate[6];
    public fixed sbyte PreviousResetDate[6];
    public DeliveryType DeliveryType;
};

/// <summary>
///  Struct for Swap Future Market Depth Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureMarketDepthMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte InstrumentStatusMarkerA1[1];
    public fixed sbyte NumberOfLevel[1];
};

/// <summary>
///  Struct for Swap Future Market Depth Trading Instrument
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureMarketDepthTradingInstrument {
    public fixed sbyte Level[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte NumberOfBidOrders[2];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte NumberOfAskOrders[2];
};

/// <summary>
///  Struct for Swap Future Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureQuoteMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte BidPriceX6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceX6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte InstrumentStatusMarkerX1[1];
};

/// <summary>
///  Struct for Swap Future Rfq Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureRfqMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte RequestedSize[8];
    public RequestedMarketSide RequestedMarketSide;
};

/// <summary>
///  Struct for Swap Future Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureSummaryMessage {
    public fixed sbyte ExchangeIdX1[1];
    public fixed sbyte RootSymbolA6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte BidPriceN6[6];
    public fixed sbyte BidPriceFractionIndicator[1];
    public fixed sbyte BidSize[5];
    public fixed sbyte AskPriceN6[6];
    public fixed sbyte AskPriceFractionIndicator[1];
    public fixed sbyte AskSize[5];
    public fixed sbyte LastPrice[6];
    public fixed sbyte LastPriceFractionIndicator[1];
    public fixed sbyte OpenPrice[6];
    public fixed sbyte OpenPriceFractionIndicator[1];
    public fixed sbyte HighPrice[6];
    public fixed sbyte HighPriceFractionIndicator[1];
    public fixed sbyte LowPrice[6];
    public fixed sbyte LowPriceFractionIndicator[1];
    public fixed sbyte SettlementPrice[6];
    public fixed sbyte SettlementPriceFractionIndicatorX1[1];
    public fixed sbyte NetPresentValueA[11];
    public fixed sbyte NetPresentValueFractionIndicator[1];
    public fixed sbyte HistoricalCouponB[11];
    public fixed sbyte HistoricalCouponFractionIndicator[1];
    public fixed sbyte PriceAlignmentInterestC[11];
    public fixed sbyte PriceAlignmentInterestFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte Volume[8];
    public fixed sbyte PreviousSettlementPrice[6];
    public fixed sbyte PreviousSettlementPriceFractionIndicator[1];
    public fixed sbyte PreviousResetRate[6];
    public fixed sbyte PreviousResetRateFractionIndicator[1];
    public fixed sbyte OpenInterest[7];
    public fixed sbyte Reason[1];
};

/// <summary>
///  Struct for Swap Future Trade Cancellation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureTradeCancellationMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte Volume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte Timestamp[9];
    public fixed sbyte MarketPriceIndicator[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Swap Future Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureTradeCorrectionMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte TradeVolume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Swap Future Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SwapFutureTradeMessage {
    public fixed sbyte ExchangeID[1];
    public fixed sbyte RootSymbolX6[6];
    public fixed sbyte ExpiryMonth[1];
    public fixed sbyte ExpiryYear[2];
    public fixed sbyte ExpiryDay[2];
    public fixed sbyte Tenor[2];
    public fixed sbyte FixedRate[5];
    public fixed sbyte FixedRateFractionIndicator[1];
    public fixed sbyte TradeVolume[8];
    public fixed sbyte TradePrice[6];
    public fixed sbyte TradePriceFractionIndicator[1];
    public fixed sbyte NetChangeSignX1[1];
    public fixed sbyte NetChange[6];
    public fixed sbyte NetChangeFractionIndicatorX1[1];
    public fixed sbyte Timestamp[9];
    public fixed sbyte PriceIndicatorMarkerX1[1];
    public fixed sbyte TradeNumber[8];
};

/// <summary>
///  Struct for Tick Entry Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TickEntryGroup {
    public fixed sbyte MinPrice[6];
    public fixed sbyte MinPriceFractionIndicator[1];
    public fixed sbyte TickPrice[6];
    public fixed sbyte TickPriceFractionIndicator[1];
};

/// <summary>
///  Struct for Tick Table Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TickTableMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte TickTableName[50];
    public fixed sbyte TickTableShortName[2];
    public fixed sbyte NumberOfEntries[2];
};

/// <summary>
///  Struct for Underlying Instrument Keys Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingInstrumentKeysMessage {
    public fixed sbyte ExchangeIdA1[1];
    public fixed sbyte GroupInstrument[2];
    public fixed sbyte Instrument[4];
    public fixed sbyte InstrumentExternalCode[30];
};

