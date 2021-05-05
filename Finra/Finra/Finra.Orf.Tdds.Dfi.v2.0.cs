// C# Structs For Finra Orf Dfi Tdds 2.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Action Values
/// </summary>
public enum Action : byte {
    TradingHalt = (byte)'H',
    QuotationResumption = (byte)'Q',
    TradingResumption = (byte)'T',
    QuotationAndTradingResumption = (byte)'X',
};

/// <summary>
///  Administrative Message Type Values
/// </summary>
public enum AdministrativeMessageType : byte {
    GeneralAdministrativeMessage = (byte)'A',
    ClosingTradeSummaryReportMessage = (byte)'2',
    TradingActionMessage = (byte)'H',
    MarketWideCircuitBreakerEventMessage = (byte)'M',
};

/// <summary>
///  As Of Indicator Values
/// </summary>
public enum AsOfIndicator : byte {
    AsOf = (byte)'A',
    Reversal = (byte)'R',
    CurrentDayTransaction = (byte)' ',
};

/// <summary>
///  Closing Price Market Center Values
/// </summary>
public enum ClosingPriceMarketCenter : byte {
    Otcbb = (byte)'U',
    Ootc = (byte)'u',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Control Message Type Values
/// </summary>
public enum ControlMessageType : byte {
    StartOfDayMessage = (byte)'I',
    EndOfDayMessage = (byte)'J',
    MarketSessionOpenMessage = (byte)'O',
    MarketSessionCloseMessage = (byte)'O',
    EndOfRetransmissionRequestsMessage = (byte)'K',
    EndOfTransmissionsMessage = (byte)'Z',
    LineIntegrityMessage = (byte)'T',
    SequenceNumberResetMessage = (byte)'L',
    EndOfTradeReportingMessage = (byte)'X',
};

/// <summary>
///  Last Sale Price Market Center Values
/// </summary>
public enum LastSalePriceMarketCenter : byte {
    Otcbb = (byte)'U',
    Ootc = (byte)'u',
    NotApplicable = (byte)' ',
};

/// <summary>
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    Trade = (byte)'T',
    Administrative = (byte)'A',
    Control = (byte)'C',
};

/// <summary>
///  Net Change Direction Values
/// </summary>
public enum NetChangeDirection : byte {
    PositiveOrZeroNetChange = (byte)'+',
    NegativeNetChange = (byte)'-',
    NoTradeOrUnaffected = (byte)' ',
};

/// <summary>
///  Price Change Indicator Values
/// </summary>
public enum PriceChangeIndicator : byte {
    NoPriceChange = (byte)'0',
    LastPriceChanged = (byte)'1',
    LowPriceChanged = (byte)'2',
    LastAndLowPricesChanged = (byte)'3',
    HighPriceChanged = (byte)'4',
    LastAndHighPricesChanged = (byte)'5',
    HighAndLowPricesChanged = (byte)'6',
    AllPricesChanged = (byte)'7',
};

/// <summary>
///  Report Function Values
/// </summary>
public enum ReportFunction : byte {
    Cancel = (byte)'C',
    Error = (byte)'E',
    Correction = (byte)'N',
};

/// <summary>
///  Sale Condition Level 1 Values
/// </summary>
public enum SaleConditionLevel1 : byte {
    RegularTrade = (byte)'@',
    CashTrade = (byte)'C',
    NextDay = (byte)'N',
    Seller = (byte)'R',
};

/// <summary>
///  Sale Condition Level 3 Values
/// </summary>
public enum SaleConditionLevel3 : byte {
    ExecutedOutsideNormalMarketHours = (byte)'T',
    ExecutedOutsideNormalMarketHoursAndTradeReportedLate = (byte)'U',
    ExecutedDuringNormalMarketHoursAndTradeReportedLate = (byte)'Z',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Sale Condition Level 4 Values
/// </summary>
public enum SaleConditionLevel4 : byte {
    OddLotTrade = (byte)'I',
    PriorReferencePrice = (byte)'P',
    AveragePriceTrade = (byte)'W',
    NotAvailable = (byte)' ',
};

/// <summary>
///  Session Identifier Values
/// </summary>
public enum SessionIdentifier : byte {
    AllMarketSessionsOrSessionIndependent = (byte)'A',
    UsMarketSession = (byte)'U',
};

/// <summary>
///  Trade Message Type Values
/// </summary>
public enum TradeMessageType : byte {
    TradeReportShortFormMessage = (byte)'5',
    TradeReportLongFormMessage = (byte)'6',
    TradeCancelErrorMessage = (byte)'7',
    TradeCorrectionMessage = (byte)'8',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Action Datetime
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ActionDatetime {
    public fixed sbyte Year[4];
    public fixed sbyte Month[2];
    public fixed sbyte Day[2];
    public fixed sbyte Hour[2];
    public fixed sbyte Minute[2];
    public fixed sbyte Second[2];
    public fixed sbyte Millisecond[3];
};

/// <summary>
///  Struct for Administrative
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Administrative {
    public AdministrativeMessageType AdministrativeMessageType;
};

/// <summary>
///  Struct for Closing Trade Summary Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClosingTradeSummaryReportMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbol[14];
    public fixed sbyte DailyHighPriceDenominator[1];
    public fixed sbyte DailyHighPrice[12];
    public fixed sbyte DailyLowPriceDenominator[1];
    public fixed sbyte DailyLowPrice[12];
    public ClosingPriceMarketCenter ClosingPriceMarketCenter;
    public fixed sbyte ClosingPriceDenominator[1];
    public fixed sbyte ClosingPrice[12];
    public fixed sbyte Reserved[1];
    public fixed sbyte NetChangeDenominator[1];
    public fixed sbyte NetChangeAmount[12];
    public NetChangeDirection NetChangeDirection;
    public fixed sbyte Currency[3];
    public fixed sbyte TotalSecurityVolume[11];
};

/// <summary>
///  Struct for Control
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Control {
    public ControlMessageType ControlMessageType;
};

/// <summary>
///  Struct for Corrected Trade Information
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CorrectedTradeInformation {
    public fixed sbyte ReportVolume[8];
    public fixed sbyte TradePriceDenominator[1];
    public fixed sbyte TradePrice[12];
    public fixed sbyte Currency[3];
    public AsOfIndicator AsOfIndicator;
    public fixed byte ExecutionDatetime[0];
    public SaleConditionLevel1 SaleConditionLevel1;
    public fixed sbyte SaleConditionLevel2[1];
    public SaleConditionLevel3 SaleConditionLevel3;
    public SaleConditionLevel4 SaleConditionLevel4;
    public fixed sbyte SellersSaleDays[2];
};

/// <summary>
///  Struct for Datetime
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Datetime {
    public fixed sbyte Year[4];
    public fixed sbyte Month[2];
    public fixed sbyte Day[2];
    public fixed sbyte Hour[2];
    public fixed sbyte Minute[2];
    public fixed sbyte Second[2];
    public fixed sbyte Millisecond[3];
};

/// <summary>
///  Struct for End Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfDayMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for End Of Retransmission Requests Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfRetransmissionRequestsMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for End Of Trade Reporting Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTradeReportingMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for End Of Transmissions Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfTransmissionsMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Execution Datetime
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionDatetime {
    public fixed sbyte Year[4];
    public fixed sbyte Month[2];
    public fixed sbyte Day[2];
    public fixed sbyte Hour[2];
    public fixed sbyte Minute[2];
    public fixed sbyte Second[2];
    public fixed sbyte Millisecond[3];
};

/// <summary>
///  Struct for General Administrative Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GeneralAdministrativeMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte Text[2];
};

/// <summary>
///  Struct for Line Integrity Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LineIntegrityMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Market Session Close Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSessionCloseMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Market Session Open Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSessionOpenMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Market Wide Circuit Breaker Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketWideCircuitBreakerEventMessage {
    public fixed byte MessageHeader[0];
    public Action Action;
    public fixed byte ActionDatetime[0];
    public fixed sbyte ReasonCode[6];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public SessionIdentifier SessionIdentifier;
    public fixed sbyte RetransmissionRequester[2];
    public fixed sbyte MessageSequenceNumber[8];
    public fixed sbyte MarketCenterOriginatorId[2];
    public fixed byte Datetime[0];
};

/// <summary>
///  Struct for Original Dissemination Date
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OriginalDisseminationDate {
    public fixed sbyte Year[4];
    public fixed sbyte Month[2];
    public fixed sbyte Day[2];
};

/// <summary>
///  Struct for Original Trade Information
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OriginalTradeInformation {
    public fixed sbyte ReportVolume[8];
    public fixed sbyte TradePriceDenominator[1];
    public fixed sbyte TradePrice[12];
    public fixed sbyte Currency[3];
    public AsOfIndicator AsOfIndicator;
    public fixed byte ExecutionDatetime[0];
    public SaleConditionLevel1 SaleConditionLevel1;
    public fixed sbyte SaleConditionLevel2[1];
    public SaleConditionLevel3 SaleConditionLevel3;
    public SaleConditionLevel4 SaleConditionLevel4;
    public fixed sbyte SellersSaleDays[2];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public byte BlockSoh;
};

/// <summary>
///  Struct for Sequence Number Reset Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequenceNumberResetMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Start Of Day Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfDayMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Trade
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Trade {
    public TradeMessageType TradeMessageType;
};

/// <summary>
///  Struct for Trade Cancel Error Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelErrorMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbol[14];
    public fixed byte OriginalDisseminationDate[0];
    public fixed sbyte OriginalMessageSequenceNumber[8];
    public ReportFunction ReportFunction;
    public fixed byte OriginalTradeInformation[0];
    public fixed byte TradeSummaryInformation[0];
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbol[14];
    public fixed byte OriginalDisseminationDate[0];
    public fixed sbyte OriginalMessageSequenceNumber[8];
    public ReportFunction ReportFunction;
    public fixed byte OriginalTradeInformation[0];
    public fixed byte CorrectedTradeInformation[0];
    public fixed byte TradeSummaryInformation[0];
};

/// <summary>
///  Struct for Trade Information
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeInformation {
    public fixed sbyte ReportVolume[8];
    public fixed sbyte TradePriceDenominator[1];
    public fixed sbyte TradePrice[12];
    public fixed sbyte Currency[3];
    public AsOfIndicator AsOfIndicator;
    public fixed byte ExecutionDatetime[0];
    public SaleConditionLevel1 SaleConditionLevel1;
    public fixed sbyte SaleConditionLevel2[1];
    public SaleConditionLevel3 SaleConditionLevel3;
    public SaleConditionLevel4 SaleConditionLevel4;
    public fixed sbyte SellersSaleDays[2];
    public PriceChangeIndicator PriceChangeIndicator;
};

/// <summary>
///  Struct for Trade Report Long Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportLongFormMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbol[14];
    public fixed byte OriginalDisseminationDate[0];
    public fixed byte TradeInformation[0];
};

/// <summary>
///  Struct for Trade Report Short Form Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportShortFormMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbolShort[5];
    public SaleConditionLevel1 SaleConditionLevel1;
    public fixed sbyte TradePriceDenominator[1];
    public fixed sbyte TradePriceShort[6];
    public fixed sbyte ReportVolumeShort[6];
    public PriceChangeIndicator PriceChangeIndicator;
};

/// <summary>
///  Struct for Trade Summary Information
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeSummaryInformation {
    public fixed sbyte HighPriceDenominator[1];
    public fixed sbyte HighPrice[12];
    public fixed sbyte LowPriceDenominator[1];
    public fixed sbyte LowPrice[12];
    public fixed sbyte LastSalePriceDenominator[1];
    public fixed sbyte LastSalePrice[12];
    public LastSalePriceMarketCenter LastSalePriceMarketCenter;
    public fixed sbyte TotalSecurityVolume[11];
    public PriceChangeIndicator PriceChangeIndicator;
};

/// <summary>
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte SecuritySymbol[14];
    public Action Action;
    public fixed byte ActionDatetime[0];
    public fixed sbyte ReasonCode[6];
};

