// C# Structs For Miax Pearl Options Mach TopOfMarket 1.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Active On Pearl Values
/// </summary>
public enum ActiveOnPearl : byte {
    ActiveTradable = (byte)'A',
    InactiveNotTradable = (byte)'I',
};

/// <summary>
///  Bid Condition Values
/// </summary>
public enum BidCondition : byte {
    Regular = (byte)'A',
    QuoteContainsPublicCustomerInterest = (byte)'B',
    QuoteIsNotFirm = (byte)'C',
    ReservedForFutureUse = (byte)'R',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Call Or Put Values
/// </summary>
public enum CallOrPut : byte {
    Call = (byte)'C',
    Put = (byte)'P',
};

/// <summary>
///  Event Reason Values
/// </summary>
public enum EventReason : byte {
    ResultedFromAutomaticmarketDrivenEvent = (byte)'A',
    ManuallyInitiated = (byte)'M',
};

/// <summary>
///  Liquidity Acceptance Increment Indicator Values
/// </summary>
public enum LiquidityAcceptanceIncrementIndicator : byte {
    Penny001 = (byte)'P',
    Penny001 = (byte)'N',
    Nickel005 = (byte)'D',
};

/// <summary>
///  Long Term Option Values
/// </summary>
public enum LongTermOption : byte {
    FarMonth = (byte)'“Y',
    NearMonth = (byte)'N',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    PearlSystemTimeMessage = (byte)'1',
    SeriesUpdateMessage = (byte)'P',
    SystemStateMessage = (byte)'S',
    CompactTopOfMarketBidMessage = (byte)'B',
    CompactTopOfMarketBestOfferMessage = (byte)'O',
    WideTopOfMarketBestBidMessage = (byte)'W',
    WideTopOfMarketBestOfferMessage = (byte)'A',
    CompactDoubleSidedTopOfMarketMessage = (byte)'d',
    WideDoubleSidedTopOfMarketMessage = (byte)'D',
    LastSaleMessage = (byte)'T',
    TradeCancelMessage = (byte)'X',
    UnderlyingTradingStatusNotification = (byte)'H',
};

/// <summary>
///  Offer Condition Values
/// </summary>
public enum OfferCondition : byte {
    Regular = (byte)'A',
    QuoteContainsPublicCustomerInterest = (byte)'B',
    QuoteIsNotFirm = (byte)'C',
    ReservedForFutureUse = (byte)'R',
    TradingHalt = (byte)'T',
    CancelOfTrade = (byte)'A',
    TradeThatIsLateAndIsOutOfSequence = (byte)'B',
    CancelOfTheLastReportedTrade = (byte)'C',
    TradeThatIsLateAndIsInCorrectSequence = (byte)'D',
    CancelOfTheFirstOpeningReportedTrade = (byte)'E',
    TradeThatIsLateReportOfTheOpeningTradeAndIsOutOfSequence = (byte)'F',
    CancelOfTheOnlyReportedTrade = (byte)'G',
    TradeThatIsLateReportOfTheOpeningTradeAndIsInCorrectSequence = (byte)'H',
    ReservedForFutureUse = (byte)'I',
    TradeDueToReopeningOfAnOptionInWhichTradingHasBeenPreviouslyHalted = (byte)'J',
    ReservedForFutureUse = (byte)'K',
    ReservedForFutureUse = (byte)'L',
    ReservedForFutureUse = (byte)'M',
    ReservedForFutureUse = (byte)'N',
    ReservedForFutureUse = (byte)'O',
    ReservedForFutureUse = (byte)'P',
    ReservedForFutureUse = (byte)'Q',
    TradeWasTheExecutionOfAnOrderWhichWasStoppedAtAPriceThatDidNotConstituteATradeThroughOnAnotherMarketAtTheTimeOfTheStop = (byte)'R',
    TradeWasTheExecutionOfAnOrderIdentified = (byte)'S',
    ReservedForFutureUse = (byte)'T',
    TradeThatIsTradeThroughExempt = (byte)'X',
};

/// <summary>
///  Opening Underlying Market Code Values
/// </summary>
public enum OpeningUnderlyingMarketCode : byte {
    NyseAmex = (byte)'A',
    NasdaqOmxBx = (byte)'B',
    NationalStock = (byte)'C',
    FinraAdf = (byte)'D',
    MarketIndependent = (byte)'E',
    InternationalSecurities = (byte)'I',
    EdgaExchange = (byte)'J',
    EdgxExchange = (byte)'K',
    ChicagoStock = (byte)'M',
    NyseEuronext = (byte)'N',
    NyseArca = (byte)'P',
    NasdaqOmx = (byte)'Q',
    NasdaqOmx = (byte)'T',
    Iex = (byte)'V',
    NasdaqOmxPhlx = (byte)'X',
    BatsYExchange = (byte)'Y',
    BatsExchange = (byte)'Z',
};

/// <summary>
///  Packet Type Values
/// </summary>
public enum PacketType : byte {
    Heartbeat = 0,
    StartOfSession = 1,
    EndOfSession = 2,
    ApplicationMessage = 3,
};

/// <summary>
///  Pbbo Condition Values
/// </summary>
public enum PbboCondition : byte {
    Regular = (byte)'A',
    QuoteContainsPublicCustomerInterest = (byte)'B',
    QuoteIsNotFirm = (byte)'C',
    ReservedForFutureUse = (byte)'R',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Pearl Bbo Posting Increment Indicator Values
/// </summary>
public enum PearlBboPostingIncrementIndicator : byte {
    Penny001 = (byte)'P',
    Penny001 = (byte)'N',
    Nickel005 = (byte)'D',
};

/// <summary>
///  Restricted Option Values
/// </summary>
public enum RestrictedOption : byte {
    PositionClosingOrdersOnly = (byte)'Y',
    OpenAndClosePositions = (byte)'N',
};

/// <summary>
///  System Status Values
/// </summary>
public enum SystemStatus : byte {
    Start = (byte)'S',
    End = (byte)'C',
    Start = (byte)'1',
    End = (byte)'2',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Application Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApplicationMessage {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Compact Double Sided Top Of Market Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CompactDoubleSidedTopOfMarketMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort BidPriorityCustomerSize;
    public BidCondition BidCondition;
    public ushort OfferPrice;
    public ushort OfferSize;
    public ushort OfferPriorityCustomerSize;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Compact Top Of Market Best Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CompactTopOfMarketBestOfferMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort PbboPrice;
    public ushort PbboSize;
    public ushort PbboPriorityCustomerSize;
    public PbboCondition PbboCondition;
};

/// <summary>
///  Struct for Compact Top Of Market Bid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CompactTopOfMarketBidMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort PbboPrice;
    public ushort PbboSize;
    public ushort PbboPriorityCustomerSize;
    public PbboCondition PbboCondition;
};

/// <summary>
///  Struct for Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LastSaleMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint TradeId;
    public byte CorrectionNumber;
    public uint ReferenceTradeId;
    public byte ReferenceCorrectionNumber;
    public uint TradePrice;
    public uint TradeSize;
    public fixed sbyte TradeCondition[1];
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ulong SequenceNumber;
    public ushort PacketLength;
    public PacketType PacketType;
    public byte SessionNumber;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
};

/// <summary>
///  Struct for Pearl System Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PearlSystemTimeMessage {
    public uint Timestamp;
};

/// <summary>
///  Struct for Series Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SeriesUpdateMessage {
    public uint ProductAddUpdateTime;
    public uint ProductId;
    public fixed sbyte UnderlyingSymbol[11];
    public fixed sbyte SecuritySymbol[6];
    public fixed sbyte ExpirationDate[8];
    public uint StrikePrice;
    public CallOrPut CallOrPut;
    public fixed sbyte OpeningTime[8];
    public fixed sbyte ClosingTime[8];
    public RestrictedOption RestrictedOption;
    public LongTermOption LongTermOption;
    public ActiveOnPearl ActiveOnPearl;
    public PearlBboPostingIncrementIndicator PearlBboPostingIncrementIndicator;
    public LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
    public OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
    public fixed byte Reserved[12];
};

/// <summary>
///  Struct for System State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemStateMessage {
    public uint NotificationTime;
    public fixed sbyte ToMVersion[8];
    public uint SessionId;
    public SystemStatus SystemStatus;
};

/// <summary>
///  Struct for Trade Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint TradeId;
    public byte CorrectionNumber;
    public uint TradePrice;
    public uint TradeSize;
    public fixed sbyte TradeCondition[1];
};

/// <summary>
///  Struct for Underlying Trading Status Notification
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingTradingStatusNotification {
    public uint Timestamp;
    public fixed sbyte UnderlyingSymbol[11];
    public fixed sbyte TradingStatus[1];
    public EventReason EventReason;
    public uint ExpectedEventTimeSecondsPart;
    public uint ExpectedEventTimeNanoSecondsPart;
};

/// <summary>
///  Struct for Wide Double Sided Top Of Market Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideDoubleSidedTopOfMarketMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint WideBidPrice;
    public uint WideBidSize;
    public uint WideBidPriorityCustomerSize;
    public BidCondition BidCondition;
    public uint WideOfferPrice;
    public uint WideOfferSize;
    public uint WideOfferPriorityCustomerSize;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Wide Top Of Market Best Bid Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideTopOfMarketBestBidMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint WidePbboPrice;
    public uint WidePbboSize;
    public uint WidePbboPriorityCustomerSize;
    public PbboCondition PbboCondition;
};

/// <summary>
///  Struct for Wide Top Of Market Best Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideTopOfMarketBestOfferMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint WidePbboPrice;
    public uint WidePbboSize;
    public uint WidePbboPriorityCustomerSize;
    public PbboCondition PbboCondition;
};

