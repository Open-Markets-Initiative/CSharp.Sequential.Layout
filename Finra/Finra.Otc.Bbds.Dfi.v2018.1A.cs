// C# Structs For Finra Otc Dfi Bbds 2018.1A protocol

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
};

/// <summary>
///  Administrative Message Type Values
/// </summary>
public enum AdministrativeMessageType : byte {
    GeneralAdministrativeMessage = (byte)'A',
    TradingActionMessage = (byte)'H',
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
///  Inside Appendage Indicator Values
/// </summary>
public enum InsideAppendageIndicator : byte {
    NoChangeToInsideQuote = (byte)'1',
    NoInsideExists = (byte)'2',
    InsideQuoteAppendageIsAttached = (byte)'3',
};

/// <summary>
///  Inside Quote Condition Values
/// </summary>
public enum InsideQuoteCondition : byte {
    Open = (byte)'O',
    Closed = (byte)'C',
};

/// <summary>
///  Market Participant Quote Condition Values
/// </summary>
public enum MarketParticipantQuoteCondition : byte {
    Open = (byte)'O',
    Closed = (byte)'C',
    Bid = (byte)'B',
    NotApplicable = (byte)'N',
    Offer = (byte)'O',
    BidAndOffer = (byte)'W',
    PeriodicIndicativeOtherSecurities = (byte)'I',
    RealtimeQuotes = (byte)'K',
    PeriodicIndicativeQuotes = (byte)'L',
};

/// <summary>
///  Market Participant Status Values
/// </summary>
public enum MarketParticipantStatus : byte {
    Active = (byte)'A',
    Deleted = (byte)'D',
    Excused = (byte)'E',
    Withdrawn = (byte)'W',
    Suspended = (byte)'S',
};

/// <summary>
///  Message Category Values
/// </summary>
public enum MessageCategory : byte {
    Quotation = (byte)'Q',
    Administrative = (byte)'A',
    Control = (byte)'C',
};

/// <summary>
///  Quotation Message Type Values
/// </summary>
public enum QuotationMessageType : byte {
    MarketParticipantQuoteUpdateMessage = (byte)'1',
};

/// <summary>
///  Session Identifier Values
/// </summary>
public enum SessionIdentifier : byte {
    AllMarketSessionsOrSessionIndependent = (byte)'A',
    UsMarketSession = (byte)'U',
};

/// <summary>
///  Unsolicited Indicator Values
/// </summary>
public enum UnsolicitedIndicator : byte {
    UnsolicitedAsk = (byte)'A',
    UnsolicitedBid = (byte)'B',
    UnsolicitedBidAndAsk = (byte)'U',
    NotApplicable = (byte)' ',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Action Datetime
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ActionDatetime {
    public fixed sbyte Year[2];
    public fixed sbyte Month[1];
    public fixed sbyte Day[1];
    public fixed sbyte Hour[1];
    public fixed sbyte Minute[1];
    public fixed sbyte Second[1];
};

/// <summary>
///  Struct for Administrative
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Administrative {
    public AdministrativeMessageType AdministrativeMessageType;
};

/// <summary>
///  Struct for Control
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Control {
    public ControlMessageType ControlMessageType;
};

/// <summary>
///  Struct for Datetime
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Datetime {
    public fixed sbyte Year[2];
    public fixed sbyte Month[1];
    public fixed sbyte Day[1];
    public fixed sbyte Hour[1];
    public fixed sbyte Minute[1];
    public fixed sbyte Second[1];
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
///  Struct for General Administrative Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GeneralAdministrativeMessage {
    public fixed byte MessageHeader[0];
    public fixed sbyte Text[2];
};

/// <summary>
///  Struct for Inside Appendage
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InsideAppendage {
    public InsideQuoteCondition InsideQuoteCondition;
    public fixed sbyte InsideBidPriceDenominator[1];
    public fixed sbyte InsideBidPrice[12];
    public fixed sbyte InsideBidSize[12];
    public fixed sbyte InsideAskPriceDenominator[1];
    public fixed sbyte InsideAskPrice[12];
    public fixed sbyte InsideAskSize[12];
};

/// <summary>
///  Struct for Line Integrity Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LineIntegrityMessage {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Market Participant Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketParticipantQuoteUpdateMessage {
    public fixed sbyte OtcbbSymbol[11];
    public fixed sbyte OtcbbType[1];
    public fixed sbyte MarketParticipantIdentifier[1];
    public fixed sbyte MarketParticipantLocationId[1];
    public MarketParticipantStatus MarketParticipantStatus;
    public MarketParticipantQuoteCondition MarketParticipantQuoteCondition;
    public fixed sbyte Reserved[1];
    public fixed sbyte WantedIndicator[1];
    public UnsolicitedIndicator UnsolicitedIndicator;
    public fixed sbyte BidPriceDenominator[1];
    public fixed sbyte BidPrice[12];
    public fixed sbyte BidSize[7];
    public fixed sbyte AskPriceDenominator[1];
    public fixed sbyte AskPrice[12];
    public fixed sbyte AskSize[7];
    public fixed sbyte Currency[3];
    public InsideAppendageIndicator InsideAppendageIndicator;
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
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public SessionIdentifier SessionIdentifier;
    public fixed sbyte RetransmissionRequester[2];
    public fixed sbyte MessageSequenceNumber[8];
    public fixed sbyte MarketCenterOriginatorId[2];
    public fixed byte Datetime[0];
    public fixed sbyte Reserved[1];
};

/// <summary>
///  Struct for Quotation
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Quotation {
    public QuotationMessageType QuotationMessageType;
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
///  Struct for Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingActionMessage {
    public fixed byte MessageHeader[0];
    public fixed byte SecuritySymbol[0];
    public Action Action;
    public fixed byte ActionDatetime[0];
    public fixed sbyte ReasonCode[6];
};

