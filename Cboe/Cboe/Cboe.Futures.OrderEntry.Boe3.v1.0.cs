// C# Structs For Cboe Futures Boe3 OrderEntry 1.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Acknowledgement Style Values
/// </summary>
public enum AcknowledgementStyle : byte {
    OrderCancelledMessagesAreSentForEachCancelledOrder = (byte)'M',
    ASingleMassCancelAcknowledgementMessageIsSent = (byte)'S',
    BothIndividualOrderCancelledAndMassCancelAcknowledgementMessagesWillBeSent = (byte)'B',
};

/// <summary>
///  Base Liquidity Indicator Values
/// </summary>
public enum BaseLiquidityIndicator : byte {
    AddedLiquidity = (byte)'A',
    RemovedLiquidity = (byte)'R',
    MarketOpeningOrReopeningTrade = (byte)'C',
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
///  Clearing Firm Filter Values
/// </summary>
public enum ClearingFirmFilter : byte {
    NoFilteringByClearingFirm = (byte)'A',
    SpecifiedClearingFirmOptionalField = (byte)'F',
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
///  Cust Order Handling Inst Values
/// </summary>
public enum CustOrderHandlingInst : byte {
    Desk = (byte)'W',
    Electronic = (byte)'Y',
    VendorprovidedPlatform = (byte)'C',
    SponsoredAccessViaExchangeApiOrFix = (byte)'G',
    PremiumAlgorithmicTradingProvider = (byte)'H',
    Other = (byte)'D',
};

/// <summary>
///  Gtc Order Filter Values
/// </summary>
public enum GtcOrderFilter : byte {
    CancelGtcAndGtdOrders = (byte)'C',
    PreserveGtcAndGtdOrders = (byte)'P',
};

/// <summary>
///  Instrument Type Filter Values
/// </summary>
public enum InstrumentTypeFilter : byte {
    BothSimpleAndComplexOrders = (byte)'B',
    SimpleOrdersOnly = (byte)'S',
    SpreadOrdersOnly = (byte)'C',
};

/// <summary>
///  Lockout Instruction Values
/// </summary>
public enum LockoutInstruction : byte {
    NoLockout = (byte)'N',
    LockoutUntilCorrespondingResetRiskReceived = (byte)'L',
};

/// <summary>
///  Login Response Status Values
/// </summary>
public enum LoginResponseStatus : byte {
    Accepted = (byte)'A',
    SessionInUse = (byte)'B',
    Disabled = (byte)'D',
    InvalidUnit = (byte)'I',
    InvalidMessage = (byte)'M',
    NotAuthorized = (byte)'N',
    SequenceAhead = (byte)'Q',
    InvalidSession = (byte)'S',
};

/// <summary>
///  Logout Reason Values
/// </summary>
public enum LogoutReason : byte {
    UserRequested = (byte)'U',
    Administrative = (byte)'A',
    ProtocolViolation = (byte)'!',
};

/// <summary>
///  Manual Order Indicator Values
/// </summary>
public enum ManualOrderIndicator : byte {
    ManualOrderEntry = (byte)'Y',
    AutomatedOrderEntry = (byte)'N',
};

/// <summary>
///  Mass Cancel Reject Reason Values
/// </summary>
public enum MassCancelRejectReason : byte {
    Admin = (byte)'A',
    UnknownMaturityDate = (byte)'B',
    UnknownProductName = (byte)'C',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
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
    OrderPersisted = (byte)'h',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : ushort {
    LoginRequestMessage = 1,
    LogoutRequestMessage = 2,
    ClientHeartbeatMessage = 3,
    LoginResponseMessage = 501,
    ReplayCompleteMessage = 502,
    LogoutResponseMessage = 503,
    ReplayCompleteMessage = 504,
    NewOrderMessage = 1001,
    ModifyOrderMessage = 1002,
    CancelOrderMessage = 1003,
    MassCancelOrderMessage = 1004,
    PurgeOrdersMessage = 1005,
    QuoteUpdateMessage = 1006,
    ResetRiskMessage = 1007,
    OrderAcknowledgementMessage = 1501,
    OrderRejectedMessage = 1502,
    OrderModifiedMessage = 1503,
    ModifyRejectedMessage = 1504,
    OrderExecutionMessage = 1505,
    OrderCancelledMessage = 1506,
    CancelRejectedMessage = 1507,
    MassCancelAcknowledgementMessage = 1508,
    MassCancelRejectedMessage = 1509,
    PurgeAcknowledgementMessage = 1510,
    PurgeRejectedMessage = 1511,
    TradeCancelOrCorrectMessage = 1512,
    TasRestatementMessage = 1513,
    VarianceRestatementMessage = 1514,
    QuoteUpdateAcknowledgmentMessage = 1515,
    QuoteUpdateRejectedMessage = 1516,
    QuoteRestatedMessage = 1517,
    QuoteExecutionMessage = 1518,
    QuoteCancelledMessage = 1519,
    TasQuoteRestatementMessage = 1520,
    VarianceQuoteRestatementMessage = 1521,
    ResetRiskAcknowledgementMessage = 1522,
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
    OrderPersisted = (byte)'h',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Mtp Modifier Values
/// </summary>
public enum MtpModifier : byte {
    CancelNewest = (byte)'N',
    CancelOldest = (byte)'O',
    CancelBoth = (byte)'B',
};

/// <summary>
///  Multileg Reporting Type Values
/// </summary>
public enum MultilegReportingType : byte {
    SimpleInstrumentExecution = (byte)'1',
    SimpleInstrumentExecutionThatIsPartOfASpreadExecution = (byte)'2',
    SpreadInstrumentExecution = (byte)'3',
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
    OrderPersisted = (byte)'h',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
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
    OrderPersisted = (byte)'h',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    MaxOpenOrdersCountExceeded = (byte)'o',
    RiskManagementProductLevel = (byte)'s',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
};

/// <summary>
///  Quote Reject Reason Values
/// </summary>
public enum QuoteRejectReason : byte {
    InvalidEfid = (byte)'C',
    InvalidWashId = (byte)'D',
    NotEnabledForQuotes = (byte)'F',
    IncorrectDataCenter = (byte)'I',
    OrderRateThresholdExceeded = (byte)'K',
    InvalidQuoteCnt = (byte)'L',
    SymbolsNotOnSameMatchingEngine = (byte)'M',
    InvalidManualOrderIndicator = (byte)'O',
    InvalidQuoteUpdateId = (byte)'Q',
    FuturesRootDoesNotMatchAcrossQuotes = (byte)'R',
    SymbolNotFound = (byte)'S',
    InvalidWashPreventType = (byte)'W',
    Admin = (byte)'a',
    InvalidCapacity = (byte)'c',
    InvalidOeoid = (byte)'e',
    RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
    InvalidCtiCode = (byte)'i',
    InvalidWashMethod = (byte)'m',
    ExceedsMaxNotionalValuePerOrder = (byte)'n',
    InvalidOpenClose = (byte)'o',
    RiskManagementProductLevel = (byte)'p',
    InvalidRemove = (byte)'r',
    InvalidSide = (byte)'s',
    SymbolRangeUnreachable = (byte)'u',
    ExceedsMaxSizePerOrder = (byte)'x',
    OrderReceivedByCfeDuringReplay = (byte)'y',
    InvalidSizeModifier = (byte)'z',
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
    RiskManagementConfigurationIsInsufficient = (byte)'n',
    RejectedOtherReason = (byte)'u',
};

/// <summary>
///  Replay Unspecified Unit Values
/// </summary>
public enum ReplayUnspecifiedUnit : byte {
    FailIfUnitNotSpecified = (byte)'F',
    ReplayAnyUnspecifiedUnitFromZero = (byte)'R',
    SkipReplayOfUnspecifiedUnits = (byte)'S',
};

/// <summary>
///  Restatement Reason Values
/// </summary>
public enum RestatementReason : byte {
    Liquidity = (byte)'Q',
    Wash = (byte)'W',
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

/// <summary>
///  Unique Id Level Values
/// </summary>
public enum UniqueIdLevel : byte {
    CancelNewest = (byte)'N',
    Tph = (byte)'F',
    Efid = (byte)'M',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderMessage {
    public fixed sbyte OrigClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
};

/// <summary>
///  Struct for Cancel Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public CancelRejectReason CancelRejectReason;
    public fixed sbyte Text[60];
};

/// <summary>
///  Struct for Login Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRequestMessage {
    public fixed sbyte SessionId[4];
    public fixed sbyte SessionSubId[4];
    public fixed sbyte Password[10];
    public ReplayUnspecifiedUnit ReplayUnspecifiedUnit;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for Login Response Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginResponseMessage {
    public LoginResponseStatus LoginResponseStatus;
    public fixed sbyte LoginResponseText[60];
    public uint ClientSequence;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for Logout Response Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutResponseMessage {
    public LogoutReason LogoutReason;
    public fixed sbyte LogoutReasonText[60];
};

/// <summary>
///  Struct for Mass Cancel Acknowledgement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelAcknowledgementMessage {
    public ulong TransactionTime;
    public fixed sbyte MassCancelId[20];
    public uint CancelledOrderCount;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Mass Cancel Inst
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelInst {
    public ClearingFirmFilter ClearingFirmFilter;
    public AcknowledgementStyle AcknowledgementStyle;
    public LockoutInstruction LockoutInstruction;
    public InstrumentTypeFilter InstrumentTypeFilter;
    public GtcOrderFilter GtcOrderFilter;
    public fixed byte InstructionDetails[11];
};

/// <summary>
///  Struct for Mass Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelOrderMessage {
    public fixed sbyte MassCancelId[20];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ProductName[6];
    public fixed byte MassCancelInst[0];
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
};

/// <summary>
///  Struct for Mass Cancel Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte MassCancelId[20];
    public MassCancelRejectReason MassCancelRejectReason;
    public fixed sbyte Text[60];
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
    public byte ReservedField;
    public uint SequenceNumber;
};

/// <summary>
///  Struct for Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderMessage {
    public fixed sbyte ClOrdId[20];
    public fixed sbyte OrigClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public uint OrderQty;
    public long Price;
    public OrdType OrdType;
    public CancelOrigOnReject CancelOrigOnReject;
    public long StopPx;
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
    public fixed sbyte FrequentTraderId[6];
    public CustOrderHandlingInst CustOrderHandlingInst;
};

/// <summary>
///  Struct for Modify Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte OrigClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public ModifyRejectReason ModifyRejectReason;
    public fixed sbyte Text[60];
};

/// <summary>
///  Struct for New Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderMessage {
    public fixed sbyte ClOrdId[20];
    public Side Side;
    public uint OrderQty;
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public long Price;
    public OrdType OrdType;
    public TimeInForce TimeInForce;
    public uint MinQty;
    public fixed sbyte Symbol[8];
    public Capacity Capacity;
    public fixed sbyte Account[16];
    public fixed byte PreventMatch[0];
    public ulong ExpireTime;
    public uint MaturityDate;
    public OpenClose OpenClose;
    public uint CmtaNumber;
    public long StopPx;
    public ushort CustomGroupId;
    public CtiCode CtiCode;
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
    public fixed sbyte FrequentTraderId[6];
    public CustOrderHandlingInst CustOrderHandlingInst;
};

/// <summary>
///  Struct for Order Acknowledgement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgementMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public ulong OrderId;
    public Side Side;
    public long Price;
    public OrdType OrdType;
    public TimeInForce TimeInForce;
    public uint MinQty;
    public fixed sbyte Symbol[8];
    public Capacity Capacity;
    public fixed sbyte Account[16];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public uint OrderQty;
    public fixed byte PreventMatch[0];
    public uint MaturityDate;
    public OpenClose OpenClose;
    public uint LeavesQty;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public ulong ExpireTime;
    public SubLiquidityIndicator SubLiquidityIndicator;
    public long StopPx;
    public uint CmtaNumber;
    public CtiCode CtiCode;
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
    public uint CumQty;
    public fixed sbyte FrequentTraderId[6];
    public CustOrderHandlingInst CustOrderHandlingInst;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Order Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public CancelReason CancelReason;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Order Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public ulong ExecId;
    public uint LastShares;
    public long LastPx;
    public uint LeavesQty;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public SubLiquidityIndicator SubLiquidityIndicator;
    public Side Side;
    public fixed sbyte Symbol[8];
    public fixed sbyte ClearingFirm[4];
    public uint MaturityDate;
    public fixed sbyte FeeCode[2];
    public uint TradeDate;
    public uint ClearingSize;
    public PendingStatus PendingStatus;
    public MultilegReportingType MultilegReportingType;
    public ulong SecondaryExecId;
};

/// <summary>
///  Struct for Order Modified Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte OrigClOrdId[20];
    public ulong OrderId;
    public fixed sbyte ClearingFirm[4];
    public long Price;
    public OrdType OrdType;
    public uint OrderQty;
    public uint LeavesQty;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public long StopPx;
    public fixed sbyte FrequentTraderId[6];
    public CustOrderHandlingInst CustOrderHandlingInst;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Order Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public OrderRejectReason OrderRejectReason;
    public fixed sbyte Text[60];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Prevent Match
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PreventMatch {
    public MtpModifier MtpModifier;
    public UniqueIdLevel UniqueIdLevel;
    public fixed sbyte TradingGroupId[1];
};

/// <summary>
///  Struct for Purge Acknowledgement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeAcknowledgementMessage {
    public fixed sbyte MassCancelId[20];
    public uint CancelledOrderCount;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Purge Orders Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeOrdersMessage {
    public fixed sbyte MassCancelId[20];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ProductName[6];
    public fixed byte MassCancelInst[0];
    public ManualOrderIndicator ManualOrderIndicator;
    public fixed sbyte Oeoid[18];
    public byte CustomGroupIdCnt;
};

/// <summary>
///  Struct for Purge Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte MassCancelId[20];
    public PurgeRejectReason PurgeRejectReason;
    public fixed sbyte Text[60];
};

/// <summary>
///  Struct for Quote
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Quote {
    public fixed sbyte QuoteSymbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
};

/// <summary>
///  Struct for Quote Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelledMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public fixed sbyte QuoteSymbol[6];
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
    public fixed sbyte QuoteSymbol[6];
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
///  Struct for Quote Restated Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRestatedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public uint LeavesQty;
    public long WorkingPrice;
    public fixed sbyte QuoteSymbol[6];
    public Side Side;
    public RestatementReason RestatementReason;
};

/// <summary>
///  Struct for Quote Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdate {
    public ulong OrderId;
    public QuoteResult QuoteResult;
    public SubLiquidityIndicator SubLiquidityIndicator;
};

/// <summary>
///  Struct for Quote Update Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong RequestReceivedTime;
    public byte QuoteCnt;
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
    public byte QuoteCnt;
};

/// <summary>
///  Struct for Quote Update Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public QuoteRejectReason QuoteRejectReason;
};

/// <summary>
///  Struct for Reset Risk Acknowledgement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetRiskAcknowledgementMessage {
    public fixed sbyte RiskStatusId[16];
    public RiskResetResult RiskResetResult;
    public ulong RequestReceivedTime;
};

/// <summary>
///  Struct for Reset Risk Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetRiskMessage {
    public fixed sbyte RiskStatusId[16];
    public fixed sbyte RiskReset[8];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ProductName[6];
    public ushort CustomGroupId;
};

/// <summary>
///  Struct for Tas Quote Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasQuoteRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong ExecId;
    public fixed sbyte QuoteSymbol[6];
    public fixed sbyte ClearingSymbol[8];
    public long ClearingPrice;
};

/// <summary>
///  Struct for Tas Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TasRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public ulong ExecId;
    public Side Side;
    public long Price;
    public fixed sbyte Symbol[8];
    public uint MaturityDate;
    public uint LastShares;
    public long LastPx;
    public fixed sbyte FeeCode[2];
    public uint TradeDate;
    public long ClearingPrice;
    public fixed sbyte ClearingSymbol[8];
    public MultilegReportingType MultilegReportingType;
    public ulong SecondaryExecId;
};

/// <summary>
///  Struct for Trade Cancel Or Correct Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public ulong ExecRefId;
    public Side Side;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public uint LastShares;
    public long LastPx;
    public long CorrectedPrice;
    public ulong OrigTime;
    public fixed sbyte Symbol[8];
    public Capacity Capacity;
    public uint MaturityDate;
    public OpenClose OpenClose;
    public uint CmtaNumber;
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
///  Struct for Variance Quote Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceQuoteRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong ExecId;
    public fixed sbyte QuoteSymbol[6];
    public fixed sbyte ClearingSymbol[8];
    public long ClearingPrice;
    public uint ClearingSize;
};

/// <summary>
///  Struct for Variance Restatement Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VarianceRestatementMessage {
    public ulong TransactionTime;
    public fixed sbyte ClOrdId[20];
    public fixed sbyte ClearingFirm[4];
    public ulong ExecId;
    public Side Side;
    public long Price;
    public fixed sbyte Symbol[8];
    public uint MaturityDate;
    public uint LastShares;
    public long LastPx;
    public fixed sbyte FeeCode[2];
    public uint TradeDate;
    public long ClearingPrice;
    public uint ClearingSize;
    public fixed sbyte ClearingSymbol[8];
    public MultilegReportingType MultilegReportingType;
    public ulong SecondaryExecId;
};

