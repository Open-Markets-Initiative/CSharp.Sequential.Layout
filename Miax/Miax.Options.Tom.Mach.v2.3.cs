// C# Structs For Miax Options Mach Tom 2.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Active On Miax Values
/// </summary>
public enum ActiveOnMiax : byte {
    Active = (byte)'A',
    Inactive = (byte)'I',
};

/// <summary>
///  Bid Condition Values
/// </summary>
public enum BidCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    Reserved = (byte)'R',
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
    Automatic = (byte)'A',
    Manual = (byte)'M',
};

/// <summary>
///  Liquidity Acceptance Increment Indicator Values
/// </summary>
public enum LiquidityAcceptanceIncrementIndicator : byte {
    Penny = (byte)'P',
    PennyOrNickel = (byte)'N',
    NickelOrDime = (byte)'D',
};

/// <summary>
///  Long Term Option Values
/// </summary>
public enum LongTermOption : byte {
    FarMonthExpiration = (byte)'Y',
    NearMonthExpiration = (byte)'N',
};

/// <summary>
///  Mbbo Condition Values
/// </summary>
public enum MbboCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    Reserved = (byte)'R',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemTimeMessage = (byte)'1',
    SimpleSeriesUpdateMessage = (byte)'P',
    SystemStateMessage = (byte)'S',
    SimpleTopOfMarketBidCompactMessage = (byte)'B',
    SimpleTopOfMarketOfferCompactMessage = (byte)'O',
    SimpleTopOfMarketBidWideMessage = (byte)'W',
    SimpleTopOfMarketOfferWideMessage = (byte)'A',
    SimpleDoubleSidedTopOfMarketCompactMessage = (byte)'d',
    SimpleDoubleSidedTopOfMarketWideMessage = (byte)'D',
    LastSaleMessage = (byte)'T',
    TradeCancelMessage = (byte)'X',
    UnderlyingTradingStatusNotificationMessage = (byte)'H',
};

/// <summary>
///  Miax Bbo Posting Increment Indicator Values
/// </summary>
public enum MiaxBboPostingIncrementIndicator : byte {
    Penny = (byte)'P',
    PennyOrNickel = (byte)'N',
    NickelOrDime = (byte)'D',
};

/// <summary>
///  Offer Condition Values
/// </summary>
public enum OfferCondition : byte {
    Regular = (byte)'A',
    PublicCustomerInterest = (byte)'B',
    NotFirm = (byte)'C',
    Reserved = (byte)'R',
    TradingHalt = (byte)'T',
};

/// <summary>
///  Opening Underlying Market Code Values
/// </summary>
public enum OpeningUnderlyingMarketCode : byte {
    NyseAmex = (byte)'A',
    NasdaqOmxBx = (byte)'B',
    Nse = (byte)'C',
    FinraAdf = (byte)'D',
    MarketIndependent = (byte)'E',
    Ise = (byte)'I',
    Edga = (byte)'J',
    Edgx = (byte)'K',
    Cse = (byte)'M',
    NyseEuronext = (byte)'N',
    NyseArca = (byte)'P',
    NasdaqOmxUtp = (byte)'Q',
    NasdaqOmxCta = (byte)'T',
    Iex = (byte)'V',
    NasdaqOmxPhlx = (byte)'X',
    BatsY = (byte)'Y',
    Bats = (byte)'Z',
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
///  Restricted Option Values
/// </summary>
public enum RestrictedOption : byte {
    AcceptPositionClosing = (byte)'Y',
    AcceptOpenAndClose = (byte)'N',
};

/// <summary>
///  System Status Values
/// </summary>
public enum SystemStatus : byte {
    StartOfSystemHours = (byte)'S',
    EndOfSystemHours = (byte)'C',
    StartTestSession = (byte)'1',
    EndOfTestSession = (byte)'2',
};

/// <summary>
///  Trade Condition Values
/// </summary>
public enum TradeCondition : byte {
    Regular = (byte)' ',
    CancelOfTradePreviouslyReportedOtherThanAsTheLastOrOpening = (byte)'A',
    LateAndIsOutOfSequence = (byte)'B',
    CancelOfTheLastReportedTrade = (byte)'C',
    LateAndIsInCorrectSequence = (byte)'D',
    CancelOfTheFirstReportedTrade = (byte)'E',
    LateReportOfTheOpeningTradeAndIsOutOfSequence = (byte)'F',
    CancelOfTheOnlyReportedTrade = (byte)'G',
    LateReportOfTheOpeningTradeAndIsInCorrectSequence = (byte)'H',
    Reserved = (byte)'I',
    ReopeningOfAnOption = (byte)'J',
    Reserved = (byte)'K',
    ABuyAndASellInTheSameClass = (byte)'L',
    ABuyAndASellInAPutAndACall = (byte)'M',
    Reserved = (byte)'N',
    Reserved = (byte)'O',
    BuyOrSellOfACallOrPut = (byte)'P',
    BuyOfACallAndASellOfAPutForTheSameUnderlyingStockOrIndex = (byte)'Q',
    ExecutionOfAnOrderWhichWasStoppedAtAPriceThatDidNotConstituteATradeThroughOnAnotherMarketAtTheTimeOfTheStop = (byte)'R',
    ExecutionOfAnIsoOrder = (byte)'S',
    Reserved = (byte)'T',
    TradeThroughExempt = (byte)'X',
    PairedPrime = (byte)'a',
    Reserved = (byte)'b',
    PrimeCustomerToCustomerCrossOrPrimeQcc = (byte)'c',
    Reserved = (byte)'d',
    Reserved = (byte)'e',
    ComplexTransactionThatIsNotComplexStocktiedAndDoesNotInvolveLegging = (byte)'f',
    ComplexPrimeTransactionThatIsNotComplexStocktiedAndDoesNotInvolveLegging = (byte)'g',
    ComplexPrimeCustomerToCustomerCrossOrComplexPrimeQccTransactionThatIsNotComplexStocktied = (byte)'h',
    Reserved = (byte)'i',
    ComplexLeggingTransactionThatIsNotComplexStocktied = (byte)'j',
    ComplexPrimeStocktiedTransactionThatDoesNotInvolveLegging = (byte)'k',
    ComplexPrimeLeggingTransactionThatIsNotComplexStocktied = (byte)'l',
    Reserved = (byte)'m',
    ComplexStocktiedTransactionThatDoesNotInvolveLegging = (byte)'n',
    ComplexCustomerToCustomerCrossStocktiedOrComplexQccStocktiedTransaction = (byte)'o',
    Reserved = (byte)'p',
    Reserved = (byte)'q',
    Reserved = (byte)'r',
    Reserved = (byte)'s',
    Reserved = (byte)'t',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Halted = (byte)'H',
    Resumed = (byte)'R',
    Opened = (byte)'O',
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
    public TradeCondition TradeCondition;
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
///  Struct for Simple Double Sided Top Of Market Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleDoubleSidedTopOfMarketCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort BidPrice2;
    public ushort BidSize2;
    public ushort BidPriorityCustomerSize2;
    public BidCondition BidCondition;
    public ushort OfferPrice2;
    public ushort OfferSize2;
    public ushort OfferPriorityCustomerSize2;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Simple Double Sided Top Of Market Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleDoubleSidedTopOfMarketWideMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint BidPrice4;
    public uint BidSize4;
    public uint BidPriorityCustomerSize4;
    public BidCondition BidCondition;
    public uint OfferPrice4;
    public uint OfferSize4;
    public uint OfferPriorityCustomerSize4;
    public OfferCondition OfferCondition;
};

/// <summary>
///  Struct for Simple Series Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleSeriesUpdateMessage {
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
    public ActiveOnMiax ActiveOnMiax;
    public MiaxBboPostingIncrementIndicator MiaxBboPostingIncrementIndicator;
    public LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
    public OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
    public uint PriorityQuoteWidth;
    public ulong Reserved;
};

/// <summary>
///  Struct for Simple Top Of Market Bid Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleTopOfMarketBidCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort MbboPrice2;
    public ushort MbboSize2;
    public ushort MbboPriorityCustomerSize2;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Simple Top Of Market Bid Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleTopOfMarketBidWideMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint MbboPrice4;
    public uint MbboSize4;
    public uint MbboPriorityCustomerSize4;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Simple Top Of Market Offer Compact Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleTopOfMarketOfferCompactMessage {
    public uint Timestamp;
    public uint ProductId;
    public ushort MbboPrice2;
    public ushort MbboSize2;
    public ushort MbboPriorityCustomerSize2;
    public MbboCondition MbboCondition;
};

/// <summary>
///  Struct for Simple Top Of Market Offer Wide Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SimpleTopOfMarketOfferWideMessage {
    public uint Timestamp;
    public uint ProductId;
    public uint MbboPrice4;
    public uint MbboSize4;
    public uint MbboPriorityCustomerSize4;
    public MbboCondition MbboCondition;
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
///  Struct for System Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemTimeMessage {
    public uint Timestamp;
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
    public TradeCondition TradeCondition;
};

/// <summary>
///  Struct for Underlying Trading Status Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingTradingStatusNotificationMessage {
    public uint Timestamp;
    public fixed sbyte UnderlyingSymbol[11];
    public TradingStatus TradingStatus;
    public EventReason EventReason;
    public uint ExpectedEventTimeSeconds;
    public uint ExpectedEventTimeNanoSeconds;
};

