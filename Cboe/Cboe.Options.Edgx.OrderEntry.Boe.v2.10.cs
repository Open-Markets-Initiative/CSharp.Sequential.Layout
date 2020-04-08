// C# Structs For Cboe Options Edgx Boe OrderEntry 2.10 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Application Message Type Values
/// </summary>
public enum ApplicationMessageType : byte {
    OrderAcknowledgment = 0x25,
    CrossOrderAcknowledgment = 0x43,
    OrderRejected = 0x26,
    CrossOrderRejected = 0x44,
    OrderModified = 0x27,
    OrderRestated = 0x28,
    UserModifyRejected = 0x29,
    OrderCancelled = 0x2A,
    CrossOrderCancelled = 0x46,
    CancelRejected = 0x2B,
    OrderExecution = 0x2C,
    TradeCancelOrCorrect = 0x2D,
    PurgeRejected = 0x48,
    ComplexInstrumentAccepted = 0x4D,
    ComplexInstrumentRejected = 0x4E,
};

/// <summary>
///  Attributed Quote Values
/// </summary>
public enum AttributedQuote : byte {
    DoNotAttributeFirmExecutingBrokerId = (byte)'N',
    AttributeFirmExecutingBrokerId = (byte)'Y',
    AttributeClientIdOnly = (byte)'C',
    AttributeBothClearingFirmAndClientId = (byte)'Z',
};

/// <summary>
///  Auto Match Values
/// </summary>
public enum AutoMatch : byte {
    Disabled = (byte)'0',
    Market = (byte)'1',
    Limit = (byte)'1',
    AttributeBothClearingFirmAndClientId = (byte)'Z',
};

/// <summary>
///  Base Liquidity Indicator Values
/// </summary>
public enum BaseLiquidityIndicator : byte {
    AddedLiquidity = (byte)'A',
    RemovedLiquidity = (byte)'R',
    RoutedToAnotherMarket = (byte)'X',
    AuctionOrUncrossing = (byte)'C',
};

/// <summary>
///  Cancel Orig On Reject Values
/// </summary>
public enum CancelOrigOnReject : byte {
    LeaveOriginalOrderAlone = (byte)'N',
    CancelOriginalOrderIfModificationFails = (byte)'Y',
};

/// <summary>
///  Cancel Reason Values
/// </summary>
public enum CancelReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Cancel Reject Reason Values
/// </summary>
public enum CancelRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    Customer = (byte)'C',
    MarketMaker = (byte)'M',
    Firm = (byte)'F',
    ProfessionalCustomer = (byte)'U',
    NonCboeMarketMaker = (byte)'N',
    BrokerDealer = (byte)'B',
    JointBackOffice = (byte)'J',
};

/// <summary>
///  Cross Exclusion Indicator Values
/// </summary>
public enum CrossExclusionIndicator : byte {
    No = (byte)'N',
    Yes = (byte)'Y',
};

/// <summary>
///  Cross Prioritization Values
/// </summary>
public enum CrossPrioritization : byte {
    Buy = (byte)'1',
    Sell = (byte)'2',
};

/// <summary>
///  Display Indicator Values
/// </summary>
public enum DisplayIndicator : byte {
    DeterminedByPortLevelSetting = (byte)'V',
    PriceAdjust = (byte)'P',
    MultiplePriceAdjust = (byte)'m',
    RejectTheOrderIfItCannotBeBookedAndDisplayedWithoutAdjustment = (byte)'m',
};

/// <summary>
///  Equity Ex Destination Values
/// </summary>
public enum EquityExDestination : byte {
    Cowen = (byte)'C',
};

/// <summary>
///  Equity Leg Short Sell Values
/// </summary>
public enum EquityLegShortSell : byte {
    SellShort = (byte)'5',
    SellShortExempt = (byte)'6',
    Disabled = (byte)'0',
    Enabled = (byte)'1',
};

/// <summary>
///  Equity Trade Venue Values
/// </summary>
public enum EquityTradeVenue : byte {
    NyseAmerican = (byte)'A',
    NasdaqBx = (byte)'B',
    NyseNational = (byte)'C',
    InvestorsExchange = (byte)'I',
    CboeEdgaExchange = (byte)'J',
    CboeEdgxExchange = (byte)'K',
    Chx = (byte)'M',
    Nyse = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    NasdaqPsx = (byte)'X',
    CboeByxExchange = (byte)'Y',
    CboeBzxExchange = (byte)'Z',
};

/// <summary>
///  Ex Destination Values
/// </summary>
public enum ExDestination : byte {
    NyseArca = (byte)'A',
    NasdaqIse = (byte)'E',
    Miax = (byte)'F',
    MiaxPearl = (byte)'P',
    MiaxEmerald = (byte)'D',
    EdgxOptions = (byte)'G',
    C2 = (byte)'H',
    Box = (byte)'K',
    Nasdaq = (byte)'N',
    NasdaqBx = (byte)'S',
    NyseAmerican = (byte)'U',
    C1 = (byte)'W',
    NasdaqPhlx = (byte)'X',
    BzxOptions = (byte)'Z',
    NasdaqGemx = (byte)'g',
};

/// <summary>
///  Exec Inst Values
/// </summary>
public enum ExecInst : byte {
    IntermarketSweep = (byte)'f',
    AllOrNone = (byte)'G',
    Sweep = (byte)'s',
};

/// <summary>
///  Login Response Status Values
/// </summary>
public enum LoginResponseStatus : byte {
    LoginAccepted = (byte)'A',
    NotAuthorized = (byte)'N',
    SessionIsDisabled = (byte)'D',
    SessionInUse = (byte)'B',
    InvalidSession = (byte)'S',
    SequenceAheadInLoginMessage = (byte)'Q',
    InvalidUnitGivenInLoginMessage = (byte)'I',
    InvalidReturnBitFieldInLoginMessage = (byte)'F',
    InvalidLoginRequestMessageStructure = (byte)'M',
};

/// <summary>
///  Logout Reason Values
/// </summary>
public enum LogoutReason : byte {
    UserRequested = (byte)'U',
    EndOfDay = (byte)'E',
    Administrative = (byte)'A',
    ProtocolViolation = (byte)'!',
};

/// <summary>
///  Mass Cancel Lockout Values
/// </summary>
public enum MassCancelLockout : byte {
    NoLockout = (byte)'0',
    Lockout = (byte)'0',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    LoginRequestMessage = 0x37,
    LogoutRequestMessage = 0x02,
    ClientHeartbeatMessage = 0x03,
    LoginResponseMessage = 0x24,
    LogoutMessage = 0x02,
    ServerHeartbeatMessage = 0x09,
    ReplayCompleteMessage = 0x13,
    NewOrderMessage = 0x38,
    NewOrderCrossMessage = 0x41,
    NewOrderComplexMessage = 0x4B,
    NewOrderCrossMultilegMessage = 0x5A,
    CancelOrderMessage = 0x39,
    ModifyOrderMessage = 0x3A,
    QuoteUpdateMessage = 0x55,
    ShortQuoteUpdateMessage = 0x59,
    PurgeOrderMessage = 0x47,
    RiskResetMessage = 0x56,
    NewComplexInstrumentMessage = 0x4C,
    OrderAcknowledgmentMessage = 0x25,
    CrossOrderAcknowledgmentMessage = 0x43,
    QuoteUpdateAcknowledgmentMessage = 0x25,
    OrderRejectedMessage = 0x26,
    CrossOrderRejectedMessage = 0x44,
    QuoteUpdateRejectedMessage = 0x58,
    OrderModifiedMessage = 0x27,
    OrderRestatedMessage = 0x28,
    QuoteRestatedMessage = 0x52,
    UserModifyRejectedMessage = 0x29,
    OrderCancelledMessage = 0x2a,
    QuoteCancelledMessage = 0x53,
    CrossOrderCancelledMessage = 0x46,
    CancelRejectedMessage = 0x2B,
    QuoteExecutionMessage = 0x54,
    TradeCancelOrCorrectMessage = 0x2D,
    PurgeRejectedMessage = 0x48,
    ResetRiskAcknowledgmentMessage = 0x57,
    MassCancelAcknowledgmentMessage = 0x36,
    ComplexInstrumentAcceptedMessage = 0x4D,
    ComplexInstrumentRejectedMessage = 0x4D,
};

/// <summary>
///  Modify Reject Reason Values
/// </summary>
public enum ModifyRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Multi Class Sprd Values
/// </summary>
public enum MultiClassSprd : byte {
    No = (byte)'N',
    Yes = (byte)'Y',
};

/// <summary>
///  No Unspecified Unit Replay Values
/// </summary>
public enum NoUnspecifiedUnitReplay : byte {
    False = (byte)'0',
    True = (byte)'1',
    Test = (byte)'T',
};

/// <summary>
///  Open Close Values
/// </summary>
public enum OpenClose : byte {
    Open = (byte)'O',
    Close = (byte)'C',
    None = (byte)'N',
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = (byte)'1',
    Limit = (byte)'2',
    Stop = (byte)'3',
    StopLimit = (byte)'4',
};

/// <summary>
///  Order Reject Reason Values
/// </summary>
public enum OrderRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Ors Values
/// </summary>
public enum Ors : byte {
    No = (byte)'N',
    Yes = (byte)'Y',
};

/// <summary>
///  Param Group Type Values
/// </summary>
public enum ParamGroupType : byte {
    UnitSequences = 0x80,
    ReturnBitfields = 0x81,
};

/// <summary>
///  Posting Instruction Values
/// </summary>
public enum PostingInstruction : byte {
    PostOnly = (byte)'P',
    BookOnly = (byte)'B',
    BookOnlyNoSlide = (byte)'N',
    PostOnlyNoSlide = (byte)'R',
};

/// <summary>
///  Price Type Values
/// </summary>
public enum PriceType : byte {
    FixedCabinetTradePrice = (byte)'0',
    Percentage = (byte)'1',
    PricePerUnit = (byte)'2',
    FixedAmount = (byte)'3',
};

/// <summary>
///  Purge Reject Reason Values
/// </summary>
public enum PurgeRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = (byte)'0',
    Call = (byte)'1',
};

/// <summary>
///  Quote Liquidity Indicator Values
/// </summary>
public enum QuoteLiquidityIndicator : byte {
    Normal = (byte)'N',
    NbboSetter = (byte)'S',
    NbboJoiner = (byte)'J',
    MarketTurner = (byte)'U',
    NoQuoteOnBook = (byte)' ',
};

/// <summary>
///  Quote Reject Reason Values
/// </summary>
public enum QuoteRejectReason : byte {
    InvalidEfid = (byte)'C',
    InvalidWashId = (byte)'D',
    InvalidSessionEligibility = (byte)'E',
    NotEnabledForQuotes = (byte)'F',
    IncorrectDataCenter = (byte)'I',
    InvalidQuoteCnt = (byte)'L',
    SymbolsNotOnSameMatchingEngine = (byte)'M',
    InvalidPostingInstruction = (byte)'P',
    InvalidQuoteUpdateId = (byte)'Q',
    RiskRootDoesNotMatchAcrossQuotes = (byte)'R',
    SymbolNotFound = (byte)'S',
    InvalidWashPreventType = (byte)'W',
    Admin = (byte)'a',
    InvalidCapacity = (byte)'C',
    CloseOnly = (byte)'d',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    InvalidWashMethod = (byte)'m',
    InvalidOpenClose = (byte)'p',
    RiskManagementRiskRootLevel = (byte)'p',
    InvalidRemove = (byte)'r',
    InvalidSide = (byte)'s',
    SymbolRangeUnreachable = (byte)'u',
    QuoteReceivedByCboeDuringReplay = (byte)'y',
};

/// <summary>
///  Quote Result Values
/// </summary>
public enum QuoteResult : byte {
    NewQuote = (byte)'A',
    ModifiedLossOfPriority = (byte)'L',
    ModifiedRetainsPriority = (byte)'R',
    NoChangeMatchesExistingQuote = (byte)'N',
    NewQuoteButMayRemoveLiquidity = (byte)'D',
    ModifiedButMayRemoveLiquidity = (byte)'d',
    UserCancelled = (byte)'U',
    AdminRejection = (byte)'a',
    RejectedCan’TPost = (byte)'P',
    RiskManagementFirmOrCustomGroupIdLevel = (byte)'f',
    RejectedSymbolNotFound = (byte)'S',
    RejectedInvalidPrice = (byte)'p',
    InvalidRemove = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    RejectedOtherReason = (byte)'u',
    RiskManagementEfidGroupLevel = (byte)'+',
    RejectedClosingOnlySeries = (byte)'c',
};

/// <summary>
///  Restatement Reason Values
/// </summary>
public enum RestatementReason : byte {
    Reload = (byte)'L',
    PriceSlidingReprice = (byte)'P',
    LiquidityUpdated = (byte)'Q',
    Reroute = (byte)'R',
    ShipAndPost = (byte)'S',
    Wash = (byte)'W',
    Liquidity = (byte)'Q',
};

/// <summary>
///  Revised Legs Values
/// </summary>
public enum RevisedLegs : byte {
    NotReordered = (byte)'1',
    Reordered = (byte)'2',
};

/// <summary>
///  Risk Reset Result Values
/// </summary>
public enum RiskResetResult : byte {
    Ignored = (byte)' ',
    Success = (byte)'Y',
    RejectedExceedsFirmResetLimit = (byte)'F',
    RejectedExceedsCustomGroupIdLimit = (byte)'C',
    RejectedAutomaticRiskResetsAreDisabled = (byte)'D',
    RejectedEmptyResetRiskField = (byte)'E',
    RejectedIncorrectDataCenter = (byte)'I',
    RejectedExceedsRiskRootResetLimit = (byte)'S',
    RejectedInvalidRiskRoot = (byte)'U',
    RejectedInvalidEfidOrClearingFirm = (byte)'c',
    RejectedInReplay = (byte)'y',
};

/// <summary>
///  Session Eligibility Values
/// </summary>
public enum SessionEligibility : byte {
    All = (byte)'A',
    Rth = (byte)'R',
    BookOnlyNoSlide = (byte)'N',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Aim = (byte)'1',
    Qcc = (byte)'2',
    Buy = (byte)'1',
    Sell = (byte)'2',
    SellShort = (byte)'5',
    SellShortExempt = (byte)'6',
};

/// <summary>
///  Strategy Id Values
/// </summary>
public enum StrategyId : byte {
    Conversion = (byte)'C',
    Reversal = (byte)'R',
    Merger = (byte)'M',
    ShortStockInterest = (byte)'S',
    JellyRoll = (byte)'J',
};

/// <summary>
///  Sub Liquidity Indicator Values
/// </summary>
public enum SubLiquidityIndicator : byte {
    ExecutionFromOrderThatSetTheNbbo = (byte)'S',
    StepUpMechanism = (byte)'B',
    MarketTurner = (byte)'U',
    Aim = (byte)'b',
    Carried = (byte)'C',
    DoneForDay = (byte)'D',
    Qcc = (byte)'q',
    Sam = (byte)'s',
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = (byte)'0',
    Gtc = (byte)'1',
    Ato = (byte)'2',
    Ioc = (byte)'3',
    Fok = (byte)'4',
    Gtd = (byte)'6',
    Atc = (byte)'6',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderByte1 {
    public fixed byte CancelOrderReservedBit8Exists[1];
    public fixed byte CancelOrderReservedBit7Exists[1];
    public fixed byte CancelOrderRoutingFirmIdExists[1];
    public fixed byte CancelOrderMassCancelIdExists[1];
    public fixed byte CancelOrderRiskRootExists[1];
    public fixed byte CancelOrderMassCancelExists[1];
    public fixed byte CancelOrderMassCancelLockoutExists[1];
    public fixed byte CancelOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for Cancel Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderByte2 {
    public fixed byte CancelOrderReservedBit8Exists[1];
    public fixed byte CancelOrderReservedBit7Exists[1];
    public fixed byte CancelOrderReservedBit6Exists[1];
    public fixed byte CancelOrderReservedBit5Exists[1];
    public fixed byte CancelOrderReservedBit4Exists[1];
    public fixed byte CancelOrderReservedBit3Exists[1];
    public fixed byte CancelOrderReservedBit2Exists[1];
    public fixed byte CancelOrderMassCancelInstExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte1 {
    public fixed byte CancelRejectedMaxRemovePctExists[1];
    public fixed byte CancelRejectedMinQtyExists[1];
    public fixed byte CancelRejectedTimeInForceExists[1];
    public fixed byte CancelRejectedOrdTypeExists[1];
    public fixed byte CancelRejectedExecInstExists[1];
    public fixed byte CancelRejectedPriceExists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedSideExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte10 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedCrossExclusionIndicatorExists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedRoutingFirmIdExists[1];
    public fixed byte CancelRejectedGiveUpFirmIdExists[1];
    public fixed byte CancelRejectedAllocQtyExists[1];
    public fixed byte CancelRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte11 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte12 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte13 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte14 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte15 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedMassCancelIdExists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte16 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte17 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte2 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedCapacityExists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedSymbolExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte3 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte4 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedCorrectedSizeExists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedOpenCloseExists[1];
    public fixed byte CancelRejectedPutOrCallExists[1];
    public fixed byte CancelRejectedStrikePriceExists[1];
    public fixed byte CancelRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte5 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte6 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte7 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte8 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedStopPxExists[1];
    public fixed byte CancelRejectedEchoTextExists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte9 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedCmtaNumberExists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedAuctionIdExists[1];
    public fixed byte CancelRejectedTargetPartyIdExists[1];
    public fixed byte CancelRejectedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte1 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte10 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte11 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte12 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte13 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte14 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedLegStrikePriceExists[1];
    public fixed byte ComplexInstrumentAcceptedLegMaturityDateExists[1];
    public fixed byte ComplexInstrumentAcceptedLegCfiCodeExists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte15 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte16 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte17 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte2 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte3 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte4 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte5 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte6 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte7 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte8 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Accepted Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentAcceptedByte9 {
    public fixed byte ComplexInstrumentAcceptedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentAcceptedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte1 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte10 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte11 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte12 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte13 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte14 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte15 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte16 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte17 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte2 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte3 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte4 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte5 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte6 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte7 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte8 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Complex Instrument Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ComplexInstrumentRejectedByte9 {
    public fixed byte ComplexInstrumentRejectedReservedBit8Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit7Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit6Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit5Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit4Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit3Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit2Exists[1];
    public fixed byte ComplexInstrumentRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte1 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentExecInstExists[1];
    public fixed byte CrossOrderAcknowledgmentPriceExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentSideExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte10 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentRoutingFirmIdExists[1];
    public fixed byte CrossOrderAcknowledgmentGiveUpFirmIdExists[1];
    public fixed byte CrossOrderAcknowledgmentAllocQtyExists[1];
    public fixed byte CrossOrderAcknowledgmentCrossIdExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte11 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte12 {
    public fixed byte CrossOrderAcknowledgmentClearingOptionalDataExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte13 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte14 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte15 {
    public fixed byte CrossOrderAcknowledgmentClientIdAttrExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentEquityPartyIdExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte16 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte17 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte2 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentCapacityExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentSymbolExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte3 {
    public fixed byte CrossOrderAcknowledgmentPreventMatchExists[1];
    public fixed byte CrossOrderAcknowledgmentOrderQtyExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentClearingAccountExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentAccountExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte4 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentOpenCloseExists[1];
    public fixed byte CrossOrderAcknowledgmentPutOrCallExists[1];
    public fixed byte CrossOrderAcknowledgmentStrikePriceExists[1];
    public fixed byte CrossOrderAcknowledgmentMaturityDateExists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte5 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte6 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentAttributedQuoteExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte7 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte8 {
    public fixed byte CrossOrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Acknowledgment Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderAcknowledgmentByte9 {
    public fixed byte CrossOrderAcknowledgmentCrossPrioritizationExists[1];
    public fixed byte CrossOrderAcknowledgmentCrossTypeExists[1];
    public fixed byte CrossOrderAcknowledgmentCmtaNumberExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte CrossOrderAcknowledgmentAuctionIdExists[1];
    public fixed byte CrossOrderAcknowledgmentTargetPartyIdExists[1];
    public fixed byte CrossOrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte1 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledExecInstExists[1];
    public fixed byte CrossOrderCancelledPriceExists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte10 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledRoutingFirmIdExists[1];
    public fixed byte CrossOrderCancelledGiveUpFirmIdExists[1];
    public fixed byte CrossOrderCancelledAllocQtyExists[1];
    public fixed byte CrossOrderCancelledCrossIdExists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte11 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte12 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte13 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte14 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte15 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledEquityPartyIdExists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte16 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte17 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte2 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledCapacityExists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledSymbolExists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte3 {
    public fixed byte CrossOrderCancelledPreventMatchExists[1];
    public fixed byte CrossOrderCancelledOrderQtyExists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledClearingFirmExists[1];
    public fixed byte CrossOrderCancelledAccountExists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte4 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledPutOrCallExists[1];
    public fixed byte CrossOrderCancelledStrikePriceExists[1];
    public fixed byte CrossOrderCancelledMaturityDateExists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte5 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte6 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledAttributedQuoteExists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte7 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte8 {
    public fixed byte CrossOrderCancelledReservedBit8Exists[1];
    public fixed byte CrossOrderCancelledReservedBit7Exists[1];
    public fixed byte CrossOrderCancelledReservedBit6Exists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledReservedBit3Exists[1];
    public fixed byte CrossOrderCancelledReservedBit2Exists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Cancelled Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderCancelledByte9 {
    public fixed byte CrossOrderCancelledCrossPrioritizationExists[1];
    public fixed byte CrossOrderCancelledCrossTypeExists[1];
    public fixed byte CrossOrderCancelledCmtaNumberExists[1];
    public fixed byte CrossOrderCancelledReservedBit5Exists[1];
    public fixed byte CrossOrderCancelledReservedBit4Exists[1];
    public fixed byte CrossOrderCancelledTargetPartyIdExists[1];
    public fixed byte CrossOrderCancelledTargetPartyIdExists[1];
    public fixed byte CrossOrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte1 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedExecInstExists[1];
    public fixed byte CrossOrderRejectedPriceExists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte10 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedRoutingFirmIdExists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte11 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte12 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte13 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte14 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte15 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedEquityPartyIdExists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte16 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte17 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte2 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedSymbolExists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte3 {
    public fixed byte CrossOrderRejectedPreventMatchExists[1];
    public fixed byte CrossOrderRejectedOrderQtyExists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte4 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedPutOrCallExists[1];
    public fixed byte CrossOrderRejectedStrikePriceExists[1];
    public fixed byte CrossOrderRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte5 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte6 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedAttributedQuoteExists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte7 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte8 {
    public fixed byte CrossOrderRejectedReservedBit8Exists[1];
    public fixed byte CrossOrderRejectedReservedBit7Exists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedReservedBit2Exists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedByte9 {
    public fixed byte CrossOrderRejectedCrossPrioritizationExists[1];
    public fixed byte CrossOrderRejectedCrossTypeExists[1];
    public fixed byte CrossOrderRejectedReservedBit6Exists[1];
    public fixed byte CrossOrderRejectedReservedBit5Exists[1];
    public fixed byte CrossOrderRejectedReservedBit4Exists[1];
    public fixed byte CrossOrderRejectedReservedBit3Exists[1];
    public fixed byte CrossOrderRejectedTargetPartyIdExists[1];
    public fixed byte CrossOrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Logout Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutMessage {
    public LogoutReason LogoutReason;
    public fixed sbyte LogoutReasonText[60];
    public uint LastReceivedSequenceNumber;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for Mass Cancel Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte MassCancelId[20];
    public uint CancelledOrderCount;
    public fixed sbyte ReservedInternal[1];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort StartOfMessage;
    public ushort MessageLength;
    public MessageType MessageType;
    public byte MatchingUnit;
    public uint SequenceNumber;
};

/// <summary>
///  Struct for Modify Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderByte1 {
    public fixed byte ModifyOrderSideExists[1];
    public fixed byte ModifyOrderExecInstExists[1];
    public fixed byte ModifyOrderCancelOrigOnRejectExists[1];
    public fixed byte ModifyOrderOrdTypeExists[1];
    public fixed byte ModifyOrderPriceExists[1];
    public fixed byte ModifyOrderOrderQtyExists[1];
    public fixed byte ModifyOrderReservedBit2Exists[1];
    public fixed byte ModifyOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for Modify Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderByte2 {
    public fixed byte ModifyOrderReservedBit8Exists[1];
    public fixed byte ModifyOrderReservedBit7Exists[1];
    public fixed byte ModifyOrderFrequentTraderIdExists[1];
    public fixed byte ModifyOrderReservedBit5Exists[1];
    public fixed byte ModifyOrderReservedBit4Exists[1];
    public fixed byte ModifyOrderRoutingFirmIdExists[1];
    public fixed byte ModifyOrderStopPxExists[1];
    public fixed byte ModifyOrderMaxFloorExists[1];
};

/// <summary>
///  Struct for New Complex Instrument Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewComplexInstrumentByte1 {
    public fixed byte NewComplexInstrumentReservedBit8Exists[1];
    public fixed byte NewComplexInstrumentReservedBit7Exists[1];
    public fixed byte NewComplexInstrumentReservedBit6Exists[1];
    public fixed byte NewComplexInstrumentReservedBit5Exists[1];
    public fixed byte NewComplexInstrumentClearingFirmExists[1];
    public fixed byte NewComplexInstrumentLegStrikePriceExists[1];
    public fixed byte NewComplexInstrumentLegMaturityDateExists[1];
    public fixed byte NewComplexInstrumentLegCfiCodeExists[1];
};

/// <summary>
///  Struct for New Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte1 {
    public fixed byte NewOrderMaxFloorExists[1];
    public fixed byte NewOrderMinQtyExists[1];
    public fixed byte NewOrderTimeInForceExists[1];
    public fixed byte NewOrderOrdTypeExists[1];
    public fixed byte NewOrderExecInstExists[1];
    public fixed byte NewOrderPriceExists[1];
    public fixed byte NewOrderClearingAccountExists[1];
    public fixed byte NewOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for New Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte2 {
    public fixed byte NewOrderRoutingInstExists[1];
    public fixed byte NewOrderCapacityExists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderSymbolSfxExists[1];
    public fixed byte NewOrderSymbolExists[1];
};

/// <summary>
///  Struct for New Order Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte3 {
    public fixed byte NewOrderExpireTimeExists[1];
    public fixed byte NewOrderLocateReqdExists[1];
    public fixed byte NewOrderPreventMatchExists[1];
    public fixed byte NewOrderPegDifferenceExists[1];
    public fixed byte NewOrderDiscretionAmountExists[1];
    public fixed byte NewOrderMaxRemovePctExists[1];
    public fixed byte NewOrderDisplayIndicatorExists[1];
    public fixed byte NewOrderAccountExists[1];
};

/// <summary>
///  Struct for New Order Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte4 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderTargetPartyIdExists[1];
    public fixed byte NewOrderCmtaNumberExists[1];
    public fixed byte NewOrderOpenCloseExists[1];
    public fixed byte NewOrderRiskResetExists[1];
    public fixed byte NewOrderPutOrCallExists[1];
    public fixed byte NewOrderStrikePriceExists[1];
    public fixed byte NewOrderMaturityDateExists[1];
};

/// <summary>
///  Struct for New Order Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte5 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderExtExecInstExists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderAttributedQuoteExists[1];
    public fixed byte NewOrderSessionEligibilityExists[1];
};

/// <summary>
///  Struct for New Order Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte6 {
    public fixed byte NewOrderRoutingFirmIdExists[1];
    public fixed byte NewOrderAuctionIdExists[1];
    public fixed byte NewOrderEchoTextExists[1];
    public fixed byte NewOrderExDestinationExists[1];
    public fixed byte NewOrderRouteDeliveryMethodExists[1];
    public fixed byte NewOrderRouteStrategyExists[1];
    public fixed byte NewOrderStopPxExists[1];
    public fixed byte NewOrderDisplayRangeExists[1];
};

/// <summary>
///  Struct for New Order Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte7 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderCustomGroupIdExists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte8 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderFrequentTraderIdExists[1];
    public fixed byte NewOrderClientIdAttrExists[1];
    public fixed byte NewOrderClearingOptionalDataExists[1];
    public fixed byte NewOrderCustomGroupIdExists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte9 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderPriceTypeExists[1];
    public fixed byte NewOrderOrsExists[1];
    public fixed byte NewOrderOrderOriginExists[1];
};

/// <summary>
///  Struct for New Order Complex Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderComplexMessage {
    public fixed sbyte ClOrdId[20];
    public Side Side;
    public uint OrderQty;
};

/// <summary>
///  Struct for New Order Cross Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossByte1 {
    public fixed byte NewOrderCrossPreventMatchExists[1];
    public fixed byte NewOrderCrossTargetPartyIdExists[1];
    public fixed byte NewOrderCrossAttributeQuoteExists[1];
    public fixed byte NewOrderCrossExecInstExists[1];
    public fixed byte NewOrderCrossPutOrCallExists[1];
    public fixed byte NewOrderCrossStrikePriceExists[1];
    public fixed byte NewOrderCrossMaturityDateExists[1];
    public fixed byte NewOrderCrossSymbolExists[1];
};

/// <summary>
///  Struct for New Order Cross Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossByte2 {
    public fixed byte NewOrderCrossClearingOptionalDataExists[1];
    public fixed byte NewOrderCrossRoutingFirmIdExists[1];
    public fixed byte NewOrderCrossClearingAccountExists[1];
    public fixed byte NewOrderCrossCmtaNumberExists[1];
    public fixed byte NewOrderCrossAccountExists[1];
    public fixed byte NewOrderCrossLastPriorityExists[1];
    public fixed byte NewOrderCrossAutoMatchPriceExists[1];
    public fixed byte NewOrderCrossAutoMatchExists[1];
};

/// <summary>
///  Struct for New Order Cross Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossByte3 {
    public fixed byte NewOrderCrossSessionEligibilityExists[1];
    public fixed byte NewOrderCrossEquitySellClearingFirmExists[1];
    public fixed byte NewOrderCrossEquityBuyClearingFirmExists[1];
    public fixed byte NewOrderCrossEquityTransactTimeExists[1];
    public fixed byte NewOrderCrossEquityTradeVenueExists[1];
    public fixed byte NewOrderCrossEquityTradeSizeExists[1];
    public fixed byte NewOrderCrossEquityTradePriceExists[1];
    public fixed byte NewOrderCrossClientIdAttrExists[1];
};

/// <summary>
///  Struct for New Order Cross Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossByte4 {
    public fixed byte NewOrderCrossReservedBit8Exists[1];
    public fixed byte NewOrderCrossReservedBit7Exists[1];
    public fixed byte NewOrderCrossReservedBit6Exists[1];
    public fixed byte NewOrderCrossReservedBit5Exists[1];
    public fixed byte NewOrderCrossReservedBit4Exists[1];
    public fixed byte NewOrderCrossFrequentTraderIdExists[1];
    public fixed byte NewOrderCrossOrsExists[1];
    public fixed byte NewOrderCrossReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Cross Multileg Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossMultilegByte1 {
    public fixed byte NewOrderCrossMultilegPreventMatchExists[1];
    public fixed byte NewOrderCrossMultilegTargetPartyIdExists[1];
    public fixed byte NewOrderCrossMultilegAttributeQuoteExists[1];
    public fixed byte NewOrderCrossMultilegExecInstExists[1];
    public fixed byte NewOrderCrossMultilegReservedBit4Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit3Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit2Exists[1];
    public fixed byte NewOrderCrossMultilegSymbolExists[1];
};

/// <summary>
///  Struct for New Order Cross Multileg Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossMultilegByte2 {
    public fixed byte NewOrderCrossMultilegClearingOptionalDataExists[1];
    public fixed byte NewOrderCrossMultilegRoutingFirmIdExists[1];
    public fixed byte NewOrderCrossMultilegClearingAccountExists[1];
    public fixed byte NewOrderCrossMultilegCmtaNumberExists[1];
    public fixed byte NewOrderCrossMultilegAccountExists[1];
    public fixed byte NewOrderCrossMultilegLastPriorityExists[1];
    public fixed byte NewOrderCrossMultilegAutoMatchPriceExists[1];
    public fixed byte NewOrderCrossMultilegAutoMatchExists[1];
};

/// <summary>
///  Struct for New Order Cross Multileg Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossMultilegByte3 {
    public fixed byte NewOrderCrossMultilegSessionEligibilityExists[1];
    public fixed byte NewOrderCrossMultilegEquitySellClearingFirmExists[1];
    public fixed byte NewOrderCrossMultilegEquityBuyClearingFirmExists[1];
    public fixed byte NewOrderCrossMultilegEquityTransactTimeExists[1];
    public fixed byte NewOrderCrossMultilegEquityTradeVenueExists[1];
    public fixed byte NewOrderCrossMultilegEquityTradeSizeExists[1];
    public fixed byte NewOrderCrossMultilegEquityTradePriceExists[1];
    public fixed byte NewOrderCrossMultilegClientIdAttrExists[1];
};

/// <summary>
///  Struct for New Order Cross Multileg Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossMultilegByte4 {
    public fixed byte NewOrderCrossMultilegReservedBit8Exists[1];
    public fixed byte NewOrderCrossMultilegEquityExDestinationExists[1];
    public fixed byte NewOrderCrossMultilegReservedBit6Exists[1];
    public fixed byte NewOrderCrossMultilegDrillThruProtectionExists[1];
    public fixed byte NewOrderCrossMultilegReservedBit4Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit3Exists[1];
    public fixed byte NewOrderCrossMultilegEquityLegShortSellExists[1];
    public fixed byte NewOrderCrossMultilegEquityPartyIdExists[1];
};

/// <summary>
///  Struct for New Order Cross Multileg Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderCrossMultilegByte5 {
    public fixed byte NewOrderCrossMultilegReservedBit8Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit7Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit6Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit5Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit4Exists[1];
    public fixed byte NewOrderCrossMultilegReservedBit3Exists[1];
    public fixed byte NewOrderCrossMultilegFrequentTraderIdExists[1];
    public fixed byte NewOrderCrossMultilegOrsExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte1 {
    public fixed byte OrderAcknowledgmentMaxRemovePctExists[1];
    public fixed byte OrderAcknowledgmentMinQtyExists[1];
    public fixed byte OrderAcknowledgmentTimeInForceExists[1];
    public fixed byte OrderAcknowledgmentOrdTypeExists[1];
    public fixed byte OrderAcknowledgmentExecInstExists[1];
    public fixed byte OrderAcknowledgmentPriceExists[1];
    public fixed byte OrderAcknowledgmentPegDifferenceExists[1];
    public fixed byte OrderAcknowledgmentSideExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte10 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentCrossExclusionIndicatorExists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentRoutingFirmIdExists[1];
    public fixed byte OrderAcknowledgmentGiveUpFirmIdExists[1];
    public fixed byte OrderAcknowledgmentAllocQtyExists[1];
    public fixed byte OrderAcknowledgmentCrossIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte11 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte12 {
    public fixed byte OrderAcknowledgmentClearingOptionalDataExists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte13 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentDrillThruProtectionExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte14 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte15 {
    public fixed byte OrderAcknowledgmentClientIdAttrExists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentEquityPartyIdExists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte16 {
    public fixed byte OrderAcknowledgmentOrderOriginExists[1];
    public fixed byte OrderAcknowledgmentMultiClassSprdExists[1];
    public fixed byte OrderAcknowledgmentFloorRoutingInstExists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentSessionEligibilityExists[1];
    public fixed byte OrderAcknowledgmentFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte17 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentStrategyIdExists[1];
    public fixed byte OrderAcknowledgmentPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte2 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentCapacityExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSymbolExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte3 {
    public fixed byte OrderAcknowledgmentPreventMatchExists[1];
    public fixed byte OrderAcknowledgmentOrderQtyExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentMaxFloorExists[1];
    public fixed byte OrderAcknowledgmentDisplayIndicatorExists[1];
    public fixed byte OrderAcknowledgmentClearingAccountExists[1];
    public fixed byte OrderAcknowledgmentClearingFirmExists[1];
    public fixed byte OrderAcknowledgmentAccountExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte4 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentCorrectedSizeExists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentOpenCloseExists[1];
    public fixed byte OrderAcknowledgmentPutOrCallExists[1];
    public fixed byte OrderAcknowledgmentStrikePriceExists[1];
    public fixed byte OrderAcknowledgmentMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte5 {
    public fixed byte OrderAcknowledgmentExpireTimeExists[1];
    public fixed byte OrderAcknowledgmentBaseLiquidityIndicatorExists[1];
    public fixed byte OrderAcknowledgmentWorkingPriceExists[1];
    public fixed byte OrderAcknowledgmentDisplayPriceExists[1];
    public fixed byte OrderAcknowledgmentLastPxExists[1];
    public fixed byte OrderAcknowledgmentLastSharesExists[1];
    public fixed byte OrderAcknowledgmentLeavesQtyExists[1];
    public fixed byte OrderAcknowledgmentOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte6 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentAttributedQuoteExists[1];
    public fixed byte OrderAcknowledgmentContraCapacityExists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte7 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte8 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentExDestinationExists[1];
    public fixed byte OrderAcknowledgmentRouteDeliveryMethodExists[1];
    public fixed byte OrderAcknowledgmentRouteStrategyExists[1];
    public fixed byte OrderAcknowledgmentRoutingInstExists[1];
    public fixed byte OrderAcknowledgmentStopPxExists[1];
    public fixed byte OrderAcknowledgmentEchoTextExists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte9 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentAuctionIdExists[1];
    public fixed byte OrderAcknowledgmentTargetPartyIdExists[1];
    public fixed byte OrderAcknowledgmentMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte1 {
    public fixed byte OrderCancelledMaxRemovePctExists[1];
    public fixed byte OrderCancelledMinQtyExists[1];
    public fixed byte OrderCancelledTimeInForceExists[1];
    public fixed byte OrderCancelledOrdTypeExists[1];
    public fixed byte OrderCancelledExecInstExists[1];
    public fixed byte OrderCancelledPriceExists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSideExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte10 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledCrossExclusionIndicatorExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledRoutingFirmIdExists[1];
    public fixed byte OrderCancelledGiveUpFirmIdExists[1];
    public fixed byte OrderCancelledAllocQtyExists[1];
    public fixed byte OrderCancelledCrossIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte11 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte12 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte13 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte14 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte15 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledEquityPartyIdExists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte16 {
    public fixed byte OrderCancelledOrderOriginExists[1];
    public fixed byte OrderCancelledMultiClassSprdExists[1];
    public fixed byte OrderCancelledFloorRoutingInstExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte17 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledStrategyIdExists[1];
    public fixed byte OrderCancelledPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte2 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledCapacityExists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSymbolExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte3 {
    public fixed byte OrderCancelledPreventMatchExists[1];
    public fixed byte OrderCancelledOrderQtyExists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledMaxFloorExists[1];
    public fixed byte OrderCancelledDisplayIndicatorExists[1];
    public fixed byte OrderCancelledClearingAccountExists[1];
    public fixed byte OrderCancelledClearingFirmExists[1];
    public fixed byte OrderCancelledAccountExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte4 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledCorrectedSizeExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledOpenCloseExists[1];
    public fixed byte OrderCancelledPutOrCallExists[1];
    public fixed byte OrderCancelledStrikePriceExists[1];
    public fixed byte OrderCancelledMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte5 {
    public fixed byte OrderCancelledExpireTimeExists[1];
    public fixed byte OrderCancelledBaseLiquidityIndicatorExists[1];
    public fixed byte OrderCancelledWorkingPriceExists[1];
    public fixed byte OrderCancelledDisplayPriceExists[1];
    public fixed byte OrderCancelledLastPxExists[1];
    public fixed byte OrderCancelledLastSharesExists[1];
    public fixed byte OrderCancelledLeavesQtyExists[1];
    public fixed byte OrderCancelledOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte6 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledAttributedQuoteExists[1];
    public fixed byte OrderCancelledContraCapacityExists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte7 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte8 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledExDestinationExists[1];
    public fixed byte OrderCancelledRouteDeliveryMethodExists[1];
    public fixed byte OrderCancelledRouteStrategyExists[1];
    public fixed byte OrderCancelledRoutingInstExists[1];
    public fixed byte OrderCancelledStopPxExists[1];
    public fixed byte OrderCancelledEchoTextExists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte9 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledCmtaNumberExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledAuctionIdExists[1];
    public fixed byte OrderCancelledTargetPartyIdExists[1];
    public fixed byte OrderCancelledMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte1 {
    public fixed byte OrderExecutionMaxRemovePctExists[1];
    public fixed byte OrderExecutionMinQtyExists[1];
    public fixed byte OrderExecutionTimeInForceExists[1];
    public fixed byte OrderExecutionOrdTypeExists[1];
    public fixed byte OrderExecutionExecInstExists[1];
    public fixed byte OrderExecutionPriceExists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionSideExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte10 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionCrossExclusionIndicatorExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionRoutingFirmIdExists[1];
    public fixed byte OrderExecutionGiveUpFirmIdExists[1];
    public fixed byte OrderExecutionAllocQtyExists[1];
    public fixed byte OrderExecutionCrossIdExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte11 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte12 {
    public fixed byte OrderExecutionClearingOptionalDataExists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte13 {
    public fixed byte OrderExecutionMultilegReportingTypeExists[1];
    public fixed byte OrderExecutionDrillThruProtectionExists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionDayAvgPxExists[1];
    public fixed byte OrderExecutionAvgPxExists[1];
    public fixed byte OrderExecutionDayCumQtyExists[1];
    public fixed byte OrderExecutionDayOrderQtyExists[1];
    public fixed byte OrderExecutionCumQtyExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte14 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionSecondaryExecIdExists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte15 {
    public fixed byte OrderExecutionClientIdAttrExists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionEquityPartyIdExists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte16 {
    public fixed byte OrderExecutionOrderOriginExists[1];
    public fixed byte OrderExecutionMultiClassSprdExists[1];
    public fixed byte OrderExecutionFloorRoutingInstExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte17 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionFloorTraderAcronymExists[1];
    public fixed byte OrderExecutionSenderLocationIdExists[1];
    public fixed byte OrderExecutionTradeThroughAlertTypeExists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionStrategyIdExists[1];
    public fixed byte OrderExecutionPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte2 {
    public fixed byte OrderExecutionContraTraderExists[1];
    public fixed byte OrderExecutionCapacityExists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionSymbolExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte3 {
    public fixed byte OrderExecutionPreventMatchExists[1];
    public fixed byte OrderExecutionOrderQtyExists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionMaxFloorExists[1];
    public fixed byte OrderExecutionDisplayIndicatorExists[1];
    public fixed byte OrderExecutionClearingAccountExists[1];
    public fixed byte OrderExecutionClearingFirmExists[1];
    public fixed byte OrderExecutionAccountExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte4 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionCorrectedSizeExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionOpenCloseExists[1];
    public fixed byte OrderExecutionPutOrCallExists[1];
    public fixed byte OrderExecutionStrikePriceExists[1];
    public fixed byte OrderExecutionMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte5 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte6 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionAttributedQuoteExists[1];
    public fixed byte OrderExecutionContraCapacityExists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte7 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte8 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionExDestinationExists[1];
    public fixed byte OrderExecutionRouteDeliveryMethodExists[1];
    public fixed byte OrderExecutionRouteStrategyExists[1];
    public fixed byte OrderExecutionRoutingInstExists[1];
    public fixed byte OrderExecutionStopPxExists[1];
    public fixed byte OrderExecutionEchoTextExists[1];
    public fixed byte OrderExecutionFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte9 {
    public fixed byte OrderExecutionCrossPrioritizationExists[1];
    public fixed byte OrderExecutionCrossTypeExists[1];
    public fixed byte OrderExecutionCmtaNumberExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionAuctionIdExists[1];
    public fixed byte OrderExecutionTargetPartyIdExists[1];
    public fixed byte OrderExecutionMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte1 {
    public fixed byte OrderModifiedMaxRemovePctExists[1];
    public fixed byte OrderModifiedMinQtyExists[1];
    public fixed byte OrderModifiedTimeInForceExists[1];
    public fixed byte OrderModifiedOrdTypeExists[1];
    public fixed byte OrderModifiedExecInstExists[1];
    public fixed byte OrderModifiedPriceExists[1];
    public fixed byte OrderModifiedPegDifferenceExists[1];
    public fixed byte OrderModifiedSideExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte10 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedCrossExclusionIndicatorExists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedRoutingFirmIdExists[1];
    public fixed byte OrderModifiedGiveUpFirmIdExists[1];
    public fixed byte OrderModifiedAllocQtyExists[1];
    public fixed byte OrderModifiedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte11 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte12 {
    public fixed byte OrderModifiedClearingOptionalDataExists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte13 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedDrillThruProtectionExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte14 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte15 {
    public fixed byte OrderModifiedClientIdAttrExists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedEquityPartyIdExists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte16 {
    public fixed byte OrderModifiedOrderOriginExists[1];
    public fixed byte OrderModifiedMultiClassSprdExists[1];
    public fixed byte OrderModifiedFloorRoutingInstExists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedSessionEligibilityExists[1];
    public fixed byte OrderModifiedFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte17 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedStrategyIdExists[1];
    public fixed byte OrderModifiedPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte2 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedCapacityExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSymbolExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte3 {
    public fixed byte OrderModifiedPreventMatchExists[1];
    public fixed byte OrderModifiedOrderQtyExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedMaxFloorExists[1];
    public fixed byte OrderModifiedDisplayIndicatorExists[1];
    public fixed byte OrderModifiedClearingAccountExists[1];
    public fixed byte OrderModifiedClearingFirmExists[1];
    public fixed byte OrderModifiedAccountExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte4 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedCorrectedSizeExists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedOpenCloseExists[1];
    public fixed byte OrderModifiedPutOrCallExists[1];
    public fixed byte OrderModifiedStrikePriceExists[1];
    public fixed byte OrderModifiedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte5 {
    public fixed byte OrderModifiedExpireTimeExists[1];
    public fixed byte OrderModifiedBaseLiquidityIndicatorExists[1];
    public fixed byte OrderModifiedWorkingPriceExists[1];
    public fixed byte OrderModifiedDisplayPriceExists[1];
    public fixed byte OrderModifiedLastPxExists[1];
    public fixed byte OrderModifiedLastSharesExists[1];
    public fixed byte OrderModifiedLeavesQtyExists[1];
    public fixed byte OrderModifiedOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte6 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedAttributedQuoteExists[1];
    public fixed byte OrderModifiedContraCapacityExists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte7 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte8 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedExDestinationExists[1];
    public fixed byte OrderModifiedRouteDeliveryMethodExists[1];
    public fixed byte OrderModifiedRouteStrategyExists[1];
    public fixed byte OrderModifiedRoutingInstExists[1];
    public fixed byte OrderModifiedStopPxExists[1];
    public fixed byte OrderModifiedEchoTextExists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte9 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedAuctionIdExists[1];
    public fixed byte OrderModifiedTargetPartyIdExists[1];
    public fixed byte OrderModifiedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte1 {
    public fixed byte OrderRejectedMaxRemovePctExists[1];
    public fixed byte OrderRejectedMinQtyExists[1];
    public fixed byte OrderRejectedTimeInForceExists[1];
    public fixed byte OrderRejectedOrdTypeExists[1];
    public fixed byte OrderRejectedExecInstExists[1];
    public fixed byte OrderRejectedPriceExists[1];
    public fixed byte OrderRejectedPegDifferenceExists[1];
    public fixed byte OrderRejectedSideExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte10 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedCrossExclusionIndicatorExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedRoutingFirmIdExists[1];
    public fixed byte OrderRejectedGiveUpFirmIdExists[1];
    public fixed byte OrderRejectedAllocQtyExists[1];
    public fixed byte OrderRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte11 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte12 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte13 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte14 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte15 {
    public fixed byte OrderRejectedClientIdAttrExists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedEquityPartyIdExists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte16 {
    public fixed byte OrderRejectedOrderOriginExists[1];
    public fixed byte OrderRejectedMultiClassSprdExists[1];
    public fixed byte OrderRejectedFloorRoutingInstExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedSessionEligibilityExists[1];
    public fixed byte OrderRejectedFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte17 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedStrategyIdExists[1];
    public fixed byte OrderRejectedPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte2 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedCapacityExists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedSymbolExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte3 {
    public fixed byte OrderRejectedPreventMatchExists[1];
    public fixed byte OrderRejectedOrderQtyExists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedMaxFloorExists[1];
    public fixed byte OrderRejectedDisplayIndicatorExists[1];
    public fixed byte OrderRejectedClearingAccountExists[1];
    public fixed byte OrderRejectedClearingFirmExists[1];
    public fixed byte OrderRejectedAccountExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte4 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedCorrectedSizeExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedOpenCloseExists[1];
    public fixed byte OrderRejectedPutOrCallExists[1];
    public fixed byte OrderRejectedStrikePriceExists[1];
    public fixed byte OrderRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte5 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte6 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedAttributedQuoteExists[1];
    public fixed byte OrderRejectedContraCapacityExists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte7 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte8 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedExDestinationExists[1];
    public fixed byte OrderRejectedRouteDeliveryMethodExists[1];
    public fixed byte OrderRejectedRouteStrategyExists[1];
    public fixed byte OrderRejectedRoutingInstExists[1];
    public fixed byte OrderRejectedStopPxExists[1];
    public fixed byte OrderRejectedEchoTextExists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte9 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedCmtaNumberExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedAuctionIdExists[1];
    public fixed byte OrderRejectedTargetPartyIdExists[1];
    public fixed byte OrderRejectedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte1 {
    public fixed byte OrderRestatedMaxRemovePctExists[1];
    public fixed byte OrderRestatedMinQtyExists[1];
    public fixed byte OrderRestatedTimeInForceExists[1];
    public fixed byte OrderRestatedOrdTypeExists[1];
    public fixed byte OrderRestatedExecInstExists[1];
    public fixed byte OrderRestatedPriceExists[1];
    public fixed byte OrderRestatedPegDifferenceExists[1];
    public fixed byte OrderRestatedSideExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte10 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedCrossExclusionIndicatorExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedRoutingFirmIdExists[1];
    public fixed byte OrderRestatedGiveUpFirmIdExists[1];
    public fixed byte OrderRestatedAllocQtyExists[1];
    public fixed byte OrderRestatedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte11 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte12 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte13 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte14 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte15 {
    public fixed byte OrderRestatedClientIdAttrExists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte16 {
    public fixed byte OrderRestatedOrderOriginExists[1];
    public fixed byte OrderRestatedMultiClassSprdExists[1];
    public fixed byte OrderRestatedFloorRoutingInstExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte17 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedStrategyIdExists[1];
    public fixed byte OrderRestatedPriceTypeExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte2 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedCapacityExists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedSymbolExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte3 {
    public fixed byte OrderRestatedPreventMatchExists[1];
    public fixed byte OrderRestatedOrderQtyExists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedMaxFloorExists[1];
    public fixed byte OrderRestatedDisplayIndicatorExists[1];
    public fixed byte OrderRestatedClearingAccountExists[1];
    public fixed byte OrderRestatedClearingFirmExists[1];
    public fixed byte OrderRestatedAccountExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte4 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedCorrectedSizeExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedOpenCloseExists[1];
    public fixed byte OrderRestatedPutOrCallExists[1];
    public fixed byte OrderRestatedStrikePriceExists[1];
    public fixed byte OrderRestatedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte5 {
    public fixed byte OrderRestatedExpireTimeExists[1];
    public fixed byte OrderRestatedBaseLiquidityIndicatorExists[1];
    public fixed byte OrderRestatedWorkingPriceExists[1];
    public fixed byte OrderRestatedDisplayPriceExists[1];
    public fixed byte OrderRestatedLastPxExists[1];
    public fixed byte OrderRestatedLastSharesExists[1];
    public fixed byte OrderRestatedLeavesQtyExists[1];
    public fixed byte OrderRestatedOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte6 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedAttributedQuoteExists[1];
    public fixed byte OrderRestatedContraCapacityExists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte7 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte8 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedExDestinationExists[1];
    public fixed byte OrderRestatedRouteDeliveryMethodExists[1];
    public fixed byte OrderRestatedRouteStrategyExists[1];
    public fixed byte OrderRestatedRoutingInstExists[1];
    public fixed byte OrderRestatedStopPxExists[1];
    public fixed byte OrderRestatedEchoTextExists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte9 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedCmtaNumberExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedAuctionIdExists[1];
    public fixed byte OrderRestatedTargetPartyIdExists[1];
    public fixed byte OrderRestatedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Param Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParamHeader {
    public ushort ParamGroupLength;
    public ParamGroupType ParamGroupType;
};

/// <summary>
///  Struct for Purge Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte1 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte10 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte11 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte12 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte13 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte14 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte15 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedMassCancelIdExists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte16 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte17 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte2 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte3 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte4 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte5 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte6 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte7 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte8 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte9 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Quote Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelledMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public fixed sbyte Symbol[6];
    public Side Side;
    public CancelReason CancelReason;
};

/// <summary>
///  Struct for Quote Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteExecutionMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public ulong ExecId;
    public fixed sbyte Symbol[6];
    public fixed sbyte ClearingFirm[4];
    public uint LastShares;
    public long LastPx;
    public uint LeavesQty;
    public fixed sbyte ContraTrader[4];
    public fixed sbyte ContraCapacity[1];
    public Side Side;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public SubLiquidityIndicator SubLiquidityIndicator;
    public fixed sbyte FeeCode[2];
    public fixed sbyte MarketingFeeCode[2];
};

/// <summary>
///  Struct for Quote Restated Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRestatedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public uint LeavesQty;
    public ulong WorkingPrice;
    public fixed sbyte Symbol[6];
    public Side Side;
    public fixed sbyte QuoteRestatementReason[1];
};

/// <summary>
///  Struct for Quote Result Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteResultGroup {
    public ulong OrderId;
    public QuoteResult QuoteResult;
    public QuoteLiquidityIndicator QuoteLiquidityIndicator;
    public fixed byte Reserved6;
};

/// <summary>
///  Struct for Quote Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdate {
    public fixed sbyte Symbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
    public fixed byte Reserved12[12];
};

/// <summary>
///  Struct for Quote Update Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public QuoteRejectReason QuoteRejectReason;
    public fixed byte Reserved17[17];
    public byte NumberOfQuoteResults;
};

/// <summary>
///  Struct for Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateMessage {
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public uint CmtaNumber;
    public fixed sbyte Account[16];
    public ushort CustomGroupId;
    public Capacity Capacity;
    public fixed byte Reserved15[15];
    public ulong SendTime;
    public PostingInstruction PostingInstruction;
    public SessionEligibility SessionEligibility;
    public byte NumberOfQuoteUpdates;
};

/// <summary>
///  Struct for Quote Update Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public QuoteRejectReason QuoteRejectReason;
    public fixed byte Reserved17[17];
};

/// <summary>
///  Struct for Reset Risk Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetRiskAcknowledgmentMessage {
    public fixed sbyte RiskStatusId[16];
    public RiskResetResult RiskResetResult;
};

/// <summary>
///  Struct for Risk Reset Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RiskResetMessage {
    public fixed sbyte RiskStatusId[16];
    public fixed sbyte RiskReset[8];
    public uint Reserved4;
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte RiskRoot[6];
    public ushort CustomGroupId;
};

/// <summary>
///  Struct for Short Quote Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteUpdate {
    public fixed sbyte Symbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
    public ushort Reserved2;
};

/// <summary>
///  Struct for Short Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteUpdateMessage {
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public ushort CustomGroupId;
    public Capacity Capacity;
    public fixed byte Reserved3;
    public ulong SendTime;
    public PostingInstruction PostingInstruction;
    public SessionEligibility SessionEligibility;
    public byte NumberOfShortQuoteUpdates;
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte1 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte10 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectCrossExclusionIndicatorExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectRoutingFirmIdExists[1];
    public fixed byte TradeCancelOrCorrectGiveUpFirmIdExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectCrossIdExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte11 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte12 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte13 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte14 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte15 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte16 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte17 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte2 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectCapacityExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectSymbolExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte3 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte4 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectCorrectedSizeExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectOpenCloseExists[1];
    public fixed byte TradeCancelOrCorrectPutOrCallExists[1];
    public fixed byte TradeCancelOrCorrectStrikePriceExists[1];
    public fixed byte TradeCancelOrCorrectMaturityDateExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte5 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte6 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte7 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte8 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte9 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectCmtaNumberExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectAuctionIdExists[1];
    public fixed byte TradeCancelOrCorrectTargetPartyIdExists[1];
    public fixed byte TradeCancelOrCorrectMarketingFeeCodeExists[1];
};

/// <summary>
///  Struct for Unit Sequence
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitSequence {
    public byte UnitNumber;
    public uint SequenceNumber;
};

/// <summary>
///  Struct for Unit Sequences
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitSequences {
    public NoUnspecifiedUnitReplay NoUnspecifiedUnitReplay;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for User Modify Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte1 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte10 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedCrossExclusionIndicatorExists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedRoutingFirmIdExists[1];
    public fixed byte UserModifyRejectedGiveUpFirmIdExists[1];
    public fixed byte UserModifyRejectedAllocQtyExists[1];
    public fixed byte UserModifyRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte11 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte12 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte13 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte14 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte15 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte16 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte17 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte2 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte3 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte4 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte5 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte6 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte7 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte8 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte9 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

