// C# Structs For Cboe Futures Boe OrderEntry 1.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Application Message Type Values
/// </summary>
public enum ApplicationMessageType : byte {
    NewOrder = 0x38,
    CancelOrder = 0x39,
    ModifyOrder = 0x3A,
    PurgeOrder = 0x47,
    OrderAcknowledgment = 0x25,
    OrderRejected = 0x26,
    OrderModified = 0x27,
    UserModifyRejected = 0x29,
    OrderCancelled = 0x2A,
    CancelRejected = 0x2B,
    OrderExecution = 0x2C,
    TradeCancelOrCorrect = 0x2D,
    PurgeRejected = 0x48,
    TasRestatement = 0x49,
    VarianceRestatement = 0x4A,
};

/// <summary>
///  Base Liquidity Indicator Values
/// </summary>
public enum BaseLiquidityIndicator : byte {
    AddedLiquidity = (byte)'A',
    RemovedLiquidity = (byte)'R',
    MarketOpening = (byte)'C',
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
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    LiquidityAvailableExceedsOrderSize = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Cancel Reject Reason Values
/// </summary>
public enum CancelRejectReason : byte {
    Admin = (byte)'A',
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    LiquidityAvailableExceedsOrderSize = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    Customer = (byte)'C',
    Firm = (byte)'F',
};

/// <summary>
///  Cti Code Values
/// </summary>
public enum CtiCode : byte {
    Cti2 = (byte)'1',
    Cti2 = (byte)'2',
    Cti3 = (byte)'3',
    Cti4 = (byte)'4',
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
///  Manual Order Indicator Values
/// </summary>
public enum ManualOrderIndicator : byte {
    ManualOrderEntry = (byte)'Y',
    AutomatedOrderEntry = (byte)'N',
    SimpleInstrumentExecution = (byte)'1',
    SimpleInstrumentExecutionThatIsPartOfASpreadExecution = (byte)'2',
    SpreadInstrumentExecution = (byte)'3',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    LoginRequestMessage = 0x37,
    LogoutRequestMessage = 0x02,
    ClientHeartbeatMessage = 0x03,
    LoginResponseMessage = 0x24,
    LogoutMessage = 0x08,
    ServerHeartbeatMessage = 0x09,
    ReplayCompleteMessage = 0x13,
    NewOrderMessage = 0x38,
    CancelOrderMessage = 0x39,
    ModifyOrderMessage = 0x3A,
    QuoteUpdateMessage = 0x70,
    PurgeOrderMessage = 0x47,
    ResetRiskMessage = 0x56,
    OrderAcknowledgmentMessage = 0x25,
    QuoteUpdateAcknowledgmentMessage = 0x71,
    OrderRejectedMessage = 0x26,
    QuoteUpdateRejectedMessage = 0x78,
    OrderModifiedMessage = 0x27,
    QuoteRestatedMessage = 0x72,
    UserModifyRejectedMessage = 0x29,
    OrderCancelledMessage = 0x2A,
    QuoteCancelledMessage = 0x73,
    CancelRejectedMessage = 0x2B,
    OrderExecutionMessage = 0x2C,
    QuoteExecutionMessage = 0x74,
    TradeCancelOrCorrectMessage = 0x2D,
    PurgeRejectedMessage = 0x48,
    RiskResetAcknowledgmentMessage = 0x57,
    MassCancelAcknowledgmentMessage = 0x36,
    TasRestatementMessage = 0x49,
    VarianceRestatementMessage = 0x4A,
    TasQuoteRestatementMessage = 0x75,
    VarianceQuoteRestatementMessage = 0x76,
};

/// <summary>
///  Modify Reject Reason Values
/// </summary>
public enum ModifyRejectReason : byte {
    Admin = (byte)'A',
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    LiquidityAvailableExceedsOrderSize = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  No Unspecified Unit Replay Values
/// </summary>
public enum NoUnspecifiedUnitReplay : byte {
    False = (byte)'0',
    True = (byte)'1',
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
    StopLimit = (byte)'4',
};

/// <summary>
///  Order Reject Reason Values
/// </summary>
public enum OrderRejectReason : byte {
    Admin = (byte)'A',
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    LiquidityAvailableExceedsOrderSize = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Param Group Type Values
/// </summary>
public enum ParamGroupType : byte {
    UnitSequences = 0x80,
    ReturnBitfields = 0x81,
};

/// <summary>
///  Pending Status Values
/// </summary>
public enum PendingStatus : byte {
    NotApplicable = (byte)'N',
    Pending = (byte)'P',
};

/// <summary>
///  Purge Reject Reason Values
/// </summary>
public enum PurgeRejectReason : byte {
    Admin = (byte)'A',
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    LiquidityAvailableExceedsOrderSize = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Quote Liquidity Indicator Values
/// </summary>
public enum QuoteLiquidityIndicator : byte {
    CarriedOrderIndicator = (byte)'C',
    MarketTurner = (byte)'U',
    Normal = (byte)'N',
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
    RejectedCantPost = (byte)'P',
    RiskManagementFirmOrCustomGroupIdLevel = (byte)'f',
    RejectedSymbolNotFound = (byte)'S',
    RejectedInvalidPrice = (byte)'p',
    RiskManagementRiskRootLevel = (byte)'s',
    RejectedOtherReason = (byte)'u',
};

/// <summary>
///  Risk Reset Result Values
/// </summary>
public enum RiskResetResult : byte {
    Ignored = (byte)' ',
    Success = (byte)'Y',
    RejectedExceedsFirmResetLimit = (byte)'F',
    RejectedExceedsCustomGroupIdLimit = (byte)'C',
    RejectedEmptyResetRiskField = (byte)'E',
    RejectedIncorrectDataCenter = (byte)'I',
    RejectedExceedsProductLevelResetLimit = (byte)'S',
    RejectedInvalidRiskRoot = (byte)'U',
    RejectedInvalidEfidOrClearingFirm = (byte)'c',
    RejectedInReplay = (byte)'y',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'1',
    Sell = (byte)'2',
};

/// <summary>
///  Size Modifier Values
/// </summary>
public enum SizeModifier : byte {
    Reduce = (byte)'R',
};

/// <summary>
///  Sub Liquidity Indicator Values
/// </summary>
public enum SubLiquidityIndicator : byte {
    CarriedOrderIndicator = (byte)'C',
    QualifyingMarketTurnerOrder = (byte)'U',
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = (byte)'0',
    Gtc = (byte)'1',
    Ioc = (byte)'3',
    Fok = (byte)'4',
    Gtd = (byte)'6',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderByte1 {
    public fixed byte CancelOrderOeoidExists[1];
    public fixed byte CancelOrderManualOrderIndicatorExists[1];
    public fixed byte CancelOrderReservedBit6Exists[1];
    public fixed byte CancelOrderMassCancelIdExists[1];
    public fixed byte CancelOrderProductNameExists[1];
    public fixed byte CancelOrderReservedBit3Exists[1];
    public fixed byte CancelOrderReservedBit2Exists[1];
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
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedMinQtyExists[1];
    public fixed byte CancelRejectedTimeInForceExists[1];
    public fixed byte CancelRejectedOrdTypeExists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
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
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
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
    public fixed byte CancelRejectedOeoidExists[1];
    public fixed byte CancelRejectedManualOrderIndicatorExists[1];
    public fixed byte CancelRejectedCtiCodeExists[1];
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
    public fixed byte CancelRejectedReservedBit4Exists[1];
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
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedOpenCloseExists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte5 {
    public fixed byte CancelRejectedExpireTimeExists[1];
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
    public fixed byte CancelRejectedReservedBit2Exists[1];
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
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
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
    public fixed byte ModifyOrderOeoidExists[1];
    public fixed byte ModifyOrderManualOrderIndicatorExists[1];
    public fixed byte ModifyOrderReservedBit3Exists[1];
    public fixed byte ModifyOrderStopPxExists[1];
    public fixed byte ModifyOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte1 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderMinQtyExists[1];
    public fixed byte NewOrderTimeInForceExists[1];
    public fixed byte NewOrderOrdTypeExists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderPriceExists[1];
    public fixed byte NewOrderClearingAccountExists[1];
    public fixed byte NewOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for New Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte2 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderCapacityExists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
    public fixed byte NewOrderSymbolExists[1];
};

/// <summary>
///  Struct for New Order Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte3 {
    public fixed byte NewOrderExpireTimeExists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderPreventMatchExists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
    public fixed byte NewOrderAccountExists[1];
};

/// <summary>
///  Struct for New Order Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte4 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderCmtaNumberExists[1];
    public fixed byte NewOrderOpenCloseExists[1];
    public fixed byte NewOrderRiskResetExists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
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
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte6 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderStopPxExists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte7 {
    public fixed byte NewOrderOeoidExists[1];
    public fixed byte NewOrderManualOrderIndicatorExists[1];
    public fixed byte NewOrderCtiCodeExists[1];
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
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte1 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentMinQtyExists[1];
    public fixed byte OrderAcknowledgmentTimeInForceExists[1];
    public fixed byte OrderAcknowledgmentOrdTypeExists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentPriceExists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSideExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte10 {
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
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentOeoidExists[1];
    public fixed byte OrderAcknowledgmentManualOrderIndicatorExists[1];
    public fixed byte OrderAcknowledgmentCtiCodeExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte13 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentDayAvgPxExists[1];
    public fixed byte OrderAcknowledgmentAvgPxExists[1];
    public fixed byte OrderAcknowledgmentDayCumQtyExists[1];
    public fixed byte OrderAcknowledgmentDayOrderQtyExists[1];
    public fixed byte OrderAcknowledgmentCumQtyExists[1];
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
///  Struct for Order Acknowledgment Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte16 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
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
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
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
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
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
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentOpenCloseExists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte5 {
    public fixed byte OrderAcknowledgmentExpireTimeExists[1];
    public fixed byte OrderAcknowledgmentBaseLiquidityIndicatorExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentLeavesQtyExists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
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
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
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
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentStopPxExists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte9 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentCmtaNumberExists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte1 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledMinQtyExists[1];
    public fixed byte OrderCancelledTimeInForceExists[1];
    public fixed byte OrderCancelledOrdTypeExists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
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
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
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
    public fixed byte OrderCancelledOeoidExists[1];
    public fixed byte OrderCancelledManualOrderIndicatorExists[1];
    public fixed byte OrderCancelledCtiCodeExists[1];
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
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte16 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
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
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
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
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
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
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledOpenCloseExists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte5 {
    public fixed byte OrderCancelledExpireTimeExists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledLastPxExists[1];
    public fixed byte OrderCancelledLastSharesExists[1];
    public fixed byte OrderCancelledLeavesQtyExists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
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
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
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
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledStopPxExists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
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
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte1 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionMinQtyExists[1];
    public fixed byte OrderExecutionTimeInForceExists[1];
    public fixed byte OrderExecutionOrdTypeExists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
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
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
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
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionClearingSizeExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionTradeDateExists[1];
    public fixed byte OrderExecutionOeoidExists[1];
    public fixed byte OrderExecutionManualOrderIndicatorExists[1];
    public fixed byte OrderExecutionCtiCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte13 {
    public fixed byte OrderExecutionMultilegReportingTypeExists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionPendingStatusExists[1];
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
///  Struct for Order Execution Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte16 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
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
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte2 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
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
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
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
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionOpenCloseExists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte5 {
    public fixed byte OrderExecutionExpireTimeExists[1];
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
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
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
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionStopPxExists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte9 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionCmtaNumberExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte1 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedMinQtyExists[1];
    public fixed byte OrderModifiedTimeInForceExists[1];
    public fixed byte OrderModifiedOrdTypeExists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedPriceExists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSideExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte10 {
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
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedOeoidExists[1];
    public fixed byte OrderModifiedManualOrderIndicatorExists[1];
    public fixed byte OrderModifiedCtiCodeExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte13 {
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
///  Struct for Order Modified Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte16 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
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
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
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
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
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
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedOpenCloseExists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte5 {
    public fixed byte OrderModifiedExpireTimeExists[1];
    public fixed byte OrderModifiedBaseLiquidityIndicatorExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
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
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
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
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte8 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedStopPxExists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte9 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedCmtaNumberExists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte1 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedMinQtyExists[1];
    public fixed byte OrderRejectedTimeInForceExists[1];
    public fixed byte OrderRejectedOrdTypeExists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedPriceExists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedSideExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte10 {
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
    public fixed byte OrderRejectedOeoidExists[1];
    public fixed byte OrderRejectedManualOrderIndicatorExists[1];
    public fixed byte OrderRejectedCtiCodeExists[1];
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
///  Struct for Order Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte16 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
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
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
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
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
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
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedOpenCloseExists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
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
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
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
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedStopPxExists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
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
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
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
///  Struct for Purge Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeOrderByte1 {
    public fixed byte PurgeOrderOeoidExists[1];
    public fixed byte PurgeOrderManualOrderIndicatorExists[1];
    public fixed byte PurgeOrderReservedBit6Exists[1];
    public fixed byte PurgeOrderMassCancelIdExists[1];
    public fixed byte PurgeOrderProductNameExists[1];
    public fixed byte PurgeOrderMassCancelInstExists[1];
    public fixed byte PurgeOrderReservedBit2Exists[1];
    public fixed byte PurgeOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for Purge Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeOrderByte2 {
    public fixed byte PurgeOrderReservedBit8Exists[1];
    public fixed byte PurgeOrderReservedBit7Exists[1];
    public fixed byte PurgeOrderReservedBit6Exists[1];
    public fixed byte PurgeOrderReservedBit5Exists[1];
    public fixed byte PurgeOrderReservedBit4Exists[1];
    public fixed byte PurgeOrderReservedBit3Exists[1];
    public fixed byte PurgeOrderReservedBit2Exists[1];
    public fixed byte PurgeOrderReservedBit1Exists[1];
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
    public Side Side;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public SubLiquidityIndicator SubLiquidityIndicator;
    public fixed sbyte FeeCode[2];
};

/// <summary>
///  Struct for Quote Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteGroup {
    public fixed sbyte Symbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
    public fixed byte Reserved12[12];
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
    public fixed byte Reserved6[6];
};

/// <summary>
///  Struct for Quote Update Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte QuoteRejectReason[1];
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
    public CtiCode CtiCode;
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
    public SizeModifier SizeModifier;
    public fixed byte Reserved6[6];
    public byte NumberOfQuotes;
};

/// <summary>
///  Struct for Quote Update Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte QuoteRejectReason[1];
    public fixed byte Reserved17[17];
};

/// <summary>
///  Struct for Reset Risk Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetRiskMessage {
    public fixed sbyte RiskStatusId[16];
    public fixed sbyte RiskReset[8];
    public fixed sbyte RiskReset[8];
    public fixed byte Reserved4[4];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ProductName[6];
    public ushort CustomGroupId;
};

/// <summary>
///  Struct for Risk Reset Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RiskResetAcknowledgmentMessage {
    public fixed sbyte RiskStatusId[16];
    public RiskResetResult RiskResetResult;
};

/// <summary>
///  Struct for Tas Quote Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasQuoteRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong ExecId;
    public fixed sbyte Symbol[6];
    public fixed sbyte ClearingSymbol[6];
    public long ClearingPrice;
    public fixed byte Reserved16[16];
};

/// <summary>
///  Struct for Tas Restatement Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte1 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementMinQtyExists[1];
    public fixed byte TasRestatementTimeInForceExists[1];
    public fixed byte TasRestatementOrdTypeExists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementPriceExists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementSideExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte10 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte11 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte12 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementClearingSymbolExists[1];
    public fixed byte TasRestatementClearingSizeExists[1];
    public fixed byte TasRestatementClearingPriceExists[1];
    public fixed byte TasRestatementTradeDateExists[1];
    public fixed byte TasRestatementOeoidExists[1];
    public fixed byte TasRestatementManualOrderIndicatorExists[1];
    public fixed byte TasRestatementCtiCodeExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte13 {
    public fixed byte TasRestatementMultilegReportingTypeExists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte14 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementSecondaryExecIdExists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte15 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte16 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte17 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte2 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementCapacityExists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementSymbolExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte3 {
    public fixed byte TasRestatementPreventMatchExists[1];
    public fixed byte TasRestatementOrderQtyExists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementClearingAccountExists[1];
    public fixed byte TasRestatementClearingFirmExists[1];
    public fixed byte TasRestatementAccountExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte4 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementOpenCloseExists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementMaturityDateExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte5 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementLastPxExists[1];
    public fixed byte TasRestatementLastSharesExists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte6 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte7 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte8 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementReservedBit6Exists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementStopPxExists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementFeeCodeExists[1];
};

/// <summary>
///  Struct for Tas Restatement Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementByte9 {
    public fixed byte TasRestatementReservedBit8Exists[1];
    public fixed byte TasRestatementReservedBit7Exists[1];
    public fixed byte TasRestatementCmtaNumberExists[1];
    public fixed byte TasRestatementReservedBit5Exists[1];
    public fixed byte TasRestatementReservedBit4Exists[1];
    public fixed byte TasRestatementReservedBit3Exists[1];
    public fixed byte TasRestatementReservedBit2Exists[1];
    public fixed byte TasRestatementReservedBit1Exists[1];
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
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
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
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
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
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
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
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
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
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
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

/// <summary>
///  Struct for Variance Quote Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceQuoteRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong ExecId;
    public fixed sbyte Symbol[6];
    public fixed sbyte ClearingSymbol[6];
    public long ClearingPrice;
    public uint ClearingSize;
    public fixed byte Reserved16[16];
};

/// <summary>
///  Struct for Variance Restatement Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte1 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementMinQtyExists[1];
    public fixed byte VarianceRestatementTimeInForceExists[1];
    public fixed byte VarianceRestatementOrdTypeExists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementPriceExists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementSideExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte10 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte11 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte12 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementClearingSymbolExists[1];
    public fixed byte VarianceRestatementClearingSizeExists[1];
    public fixed byte VarianceRestatementClearingPriceExists[1];
    public fixed byte VarianceRestatementTradeDateExists[1];
    public fixed byte VarianceRestatementOeoidExists[1];
    public fixed byte VarianceRestatementManualOrderIndicatorExists[1];
    public fixed byte VarianceRestatementCtiCodeExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte13 {
    public fixed byte VarianceRestatementMultilegReportingTypeExists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte14 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementSecondaryExecIdExists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte15 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte16 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementFrequentTraderIdExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte17 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte2 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementCapacityExists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementSymbolExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte3 {
    public fixed byte VarianceRestatementPreventMatchExists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementClearingAccountExists[1];
    public fixed byte VarianceRestatementClearingFirmExists[1];
    public fixed byte VarianceRestatementAccountExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte4 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementOpenCloseExists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementMaturityDateExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte5 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementLastPxExists[1];
    public fixed byte VarianceRestatementLastSharesExists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte6 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte7 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte8 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementReservedBit6Exists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementStopPxExists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementFeeCodeExists[1];
};

/// <summary>
///  Struct for Variance Restatement Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementByte9 {
    public fixed byte VarianceRestatementReservedBit8Exists[1];
    public fixed byte VarianceRestatementReservedBit7Exists[1];
    public fixed byte VarianceRestatementCmtaNumberExists[1];
    public fixed byte VarianceRestatementReservedBit5Exists[1];
    public fixed byte VarianceRestatementReservedBit4Exists[1];
    public fixed byte VarianceRestatementReservedBit3Exists[1];
    public fixed byte VarianceRestatementReservedBit2Exists[1];
    public fixed byte VarianceRestatementReservedBit1Exists[1];
};

