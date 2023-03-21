// C# Structs For Euronext Optiq Sbe OrderEntryGateway 4.2.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Account Type Values
/// </summary>
public enum AccountType : byte {
    Client = 1,
    House = 2,
    Ro = 4,
    LiquidityProvider = 6,
    RelatedParty = 7,
    StructuredProductMarketMaker = 8,
    OmegaClient = 14,
    CeresClient = 15,
    NoValue = 255,
};

/// <summary>
///  Account Type Cross Values
/// </summary>
public enum AccountTypeCross : byte {
    Client = 1,
    House = 2,
    Ro = 4,
    LiquidityProvider = 6,
    RelatedParty = 7,
    StructuredProductMarketMaker = 8,
    OmegaClient = 14,
    CeresClient = 15,
    NoValue = 255,
};

/// <summary>
///  Ack Phase Values
/// </summary>
public enum AckPhase : byte {
    ContinuousTradingPhase = 1,
    CallPhase = 2,
    HaltPhase = 3,
    ClosedPhase = 4,
    TradingAtLastPhase = 5,
    Reserved = 6,
    Suspended = 7,
    RandomUncrossingPhase = 8,
    NoValue = 255,
};

/// <summary>
///  Ack Type Values
/// </summary>
public enum AckType : byte {
    NewOrderAck = 0,
    ReplaceAck = 1,
    OrderCreationByMarketOperations = 2,
    StopTriggeredAck = 3,
    CollarConfirmationAck = 4,
    RefilledIcebergAck = 5,
    MtlSecondAck = 6,
    KnockInByIssuerKibiAck = 7,
    KnockOutByIssuerKobiAck = 8,
    PaymentAfterKnockOutPakoAck = 9,
    PriceInputAck = 10,
    RfqAck = 11,
    BidOnlyAck = 12,
    OfferOnlyAck = 13,
    IcebergTransformedtoLimit = 14,
    OwnershipRequestAck = 15,
    VfuvfcTriggeredAck = 16,
    OpenOrderRequestAck = 17,
    RfieAck = 21,
};

/// <summary>
///  Action Type Values
/// </summary>
public enum ActionType : byte {
    DeclarationCancellationRequest = 1,
    DeclarationRefusal = 2,
    TradeCancellationRequest = 3,
};

/// <summary>
///  Afq Reason Values
/// </summary>
public enum AfqReason : byte {
    QuotecancelledbytheLiquidityProvider = 1,
    QuotecancelledbyMarketControl = 2,
    NoquoteMminutesbeforeanuncrossing = 3,
    NoquoteSsecondsbeforeanuncrossing = 4,
    Quotecompletelymatched = 5,
};

/// <summary>
///  Breach Action Values
/// </summary>
public enum BreachAction : byte {
    Ignore = 0,
    Pull = 1,
    NoValue = 255,
};

/// <summary>
///  Buy Revision Flag Values
/// </summary>
public enum BuyRevisionFlag : byte {
    New = 0,
    Replacement = 1,
    Cancellation = 2,
    NoValue = 255,
};

/// <summary>
///  Ccpid Values
/// </summary>
public enum Ccpid : byte {
    Lchsa = 1,
    EuroCcp = 6,
    NoValue = 255,
};

/// <summary>
///  Clearing Instruction Values
/// </summary>
public enum ClearingInstruction : ushort {
    ProcessnormallyformerlySystematicposting = 0,
    Manualmode = 8,
    Automaticpostingmode = 9,
    Automaticgiveupmode = 10,
    Automaticandaccountauthorization = 4008,
    Manualandaccountauthorization = 4009,
    Giveuptosinglefirm = 4010,
    NoValue = 65535,
};

/// <summary>
///  Collar Rej Type Values
/// </summary>
public enum CollarRejType : byte {
    Lowdynamiccollar = 1,
    Highdynamiccollar = 2,
    NoValue = 255,
};

/// <summary>
///  Declaration Status Values
/// </summary>
public enum DeclarationStatus : byte {
    NewWaitingforCounterpartyConfirmation = 1,
    ConfirmedbyCounterparty = 2,
    RefusedbyCounterparty = 3,
    PendingCancellation = 4,
    Cancelled = 5,
    TimeOut = 6,
    Filled = 7,
    Restated = 8,
    Expirationofapendingdeclaration = 9,
    Eliminationofapendingdeclaration = 10,
    EliminationofaprematcheddeclarationfollowingaCe = 11,
    EliminationofaprematcheddeclarationbyMoc = 12,
    PreMatched = 13,
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
///  Execution Phase Values
/// </summary>
public enum ExecutionPhase : byte {
    ContinuousTradingPhase = 1,
    UncrossingPhase = 2,
    TradingAtLastPhase = 3,
    ContinuousUncrossingPhase = 4,
    Ipo = 5,
};

/// <summary>
///  Guarantee Flag Values
/// </summary>
public enum GuaranteeFlag : byte {
    ClearedbutnotGuaranteed = 1,
    ClearedandGuaranteed = 2,
    NoValue = 255,
};

/// <summary>
///  Input Price Type Values
/// </summary>
public enum InputPriceType : byte {
    ValuationPrice = 1,
    AlternativeIndicativePriceAip = 2,
};

/// <summary>
///  Kill Reason Values
/// </summary>
public enum KillReason : ushort {
    OrderCancelledbyClient = 1,
    OrderExpired = 2,
    OrderCancelledbyMarketOperations = 3,
    OrderEliminatedduetoCorporateEvent = 4,
    Doneforday = 5,
    CancelledMtLinanemptyOrderBook = 6,
    CancelledbyStp = 7,
    RemainingquantitykilledIoc = 8,
    BeginningofPakoPeriod = 9,
    OrderCancelledduetoCancelOnDisconnectMechanism = 11,
    RfQexpired = 12,
    RfQpartiallyorfullymatchedwithothercounterparts = 13,
    RfQcancelledbytheissuer = 14,
    RfqNotmatchedduetoissuerordersfeatures = 15,
    QuotecancelledduetoKnockOut = 16,
    OrdercancelledduetoaKillcommand = 17,
    LpOrdercancelledduetoRfQexpiration = 19,
    LpOrdercancelledduetoRfQcancellation = 20,
    RfqRemainingquantitykilled = 21,
    LpOrdercancelledduetoRfQconfirmation = 22,
    OrdercancelledduetoMarketMakerProtection = 23,
    Ordercancelledbyclearingriskmanager = 24,
    Ordercancelledbymemberriskmanager = 25,
    OrdercancelledduetoTradePriceValidation = 26,
    ConditionalOrdercancelledduetoPotentialMatching = 30,
    OrderCancelledduetoapotentialtradeoutsideFsPlimits = 36,
};

/// <summary>
///  Leg Put Or Call Values
/// </summary>
public enum LegPutOrCall : byte {
    Call = 1,
    Put = 0,
    NoValue = 255,
};

/// <summary>
///  Leg Security Type Values
/// </summary>
public enum LegSecurityType : byte {
    Future = 0,
    Option = 1,
    Cash = 2,
};

/// <summary>
///  Leg Side Values
/// </summary>
public enum LegSide : byte {
    Buy = 1,
    Sell = 2,
    NoValue = 255,
};

/// <summary>
///  Log Out Reason Code Values
/// </summary>
public enum LogOutReasonCode : byte {
    RegularLogout = 0,
    EndOfDay = 1,
    Toomanyunknownmessages = 2,
    ExcessiveNumberofMessages = 3,
    ExcessiveAmountofDatainBytes = 4,
    ExcessiveNumberofMessagesAmountofDatainBytes = 5,
};

/// <summary>
///  Logon Reject Code Values
/// </summary>
public enum LogonRejectCode : byte {
    UnknownConnectionIdentifier = 1,
    Systemunavailable = 2,
    Invalidsequencenumber = 3,
    Clientsessionalreadyloggedon = 4,
    Clientsessiondisabled = 5,
    InvalidQueueingIndicator = 6,
    InvalidLogonformat = 7,
};

/// <summary>
///  Lp Action Code Values
/// </summary>
public enum LpActionCode : byte {
    KnockInByIssuerKibi = 1,
    KnockOutByIssuerKobi = 2,
    PaymentAfterKnockOutPako = 3,
    BidOnly = 4,
    OfferOnly = 5,
};

/// <summary>
///  Lp Role Values
/// </summary>
public enum LpRole : byte {
    LiquidityProviderorMarketMaker = 1,
    RetailLiquidityProvider = 3,
    RfqLiquidityProvider = 12,
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
///  Operation Type Values
/// </summary>
public enum OperationType : byte {
    Declarationofatradeoutsidethebook = 1,
    Fundorderquantity = 4,
    DeclarationofaVwaPtransaction = 5,
    Fundordercashamount = 6,
    DeclarationofatradeonaSecondarylistingplace = 7,
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
///  Order Actor Type Values
/// </summary>
public enum OrderActorType : byte {
    Initiator = 1,
    Reactor = 2,
};

/// <summary>
///  Order Category Values
/// </summary>
public enum OrderCategory : byte {
    LitOrder = 1,
    LisOrder = 2,
    QuoteRequest = 3,
    RfqlpAnswer = 4,
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
};

/// <summary>
///  Pre Matching Type Values
/// </summary>
public enum PreMatchingType : byte {
    Notprematched = 1,
    Prematchedforthenextfixing = 2,
    Prematchedforthesecondnextfixing = 3,
    Prematchedforthethirdnextfixing = 4,
    Prematchedforthefourthnextfixing = 5,
    Prematchedforthefifthnextfixing = 6,
    NoValue = 255,
};

/// <summary>
///  Protection Type Values
/// </summary>
public enum ProtectionType : byte {
    Delta = 1,
    Volume = 2,
    NoValue = 255,
};

/// <summary>
///  Recipient Type Values
/// </summary>
public enum RecipientType : byte {
    RfqIssuer = 1,
    RfQrecipientLp = 2,
};

/// <summary>
///  Request Type Values
/// </summary>
public enum RequestType : byte {
    Set = 1,
    Get = 2,
    Adjust = 3,
};

/// <summary>
///  Response Type Values
/// </summary>
public enum ResponseType : byte {
    Accept = 0,
    Reject = 1,
};

/// <summary>
///  Rfq Update Type Values
/// </summary>
public enum RfqUpdateType : byte {
    New = 1,
    CancelledbytheRfQissuer = 2,
    Expired = 3,
    PartiallyorFullyMatched = 4,
};

/// <summary>
///  Sell Revision Flag Values
/// </summary>
public enum SellRevisionFlag : byte {
    New = 0,
    Replacement = 1,
    Cancellation = 2,
    NoValue = 255,
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = 1,
    Sell = 2,
    Cross = 3,
    NoValue = 255,
};

/// <summary>
///  Stop Triggered Time In Force Values
/// </summary>
public enum StopTriggeredTimeInForce : byte {
    Day = 0,
    GoodTillCancel = 1,
    GoodtillDate = 6,
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
    NoValue = (byte)'0',
};

/// <summary>
///  Technical Origin Values
/// </summary>
public enum TechnicalOrigin : byte {
    Indextradingarbitrage = 1,
    Portfoliostrategy = 2,
    Unwindorder = 3,
    Otherordersdefault = 4,
    Crossmargining = 5,
    NoValue = 255,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    NewOrderMessage = 1,
    AckMessage = 3,
    FillMessage = 4,
    KillMessage = 5,
    CancelReplaceMessage = 6,
    RejectMessage = 7,
    QuotesMessage = 8,
    QuoteAckMessage = 9,
    QuoteRequestMessage = 10,
    CancelRequestMessage = 12,
    MassCancelMessage = 13,
    MassCancelAckMessage = 14,
    OpenOrderRequestMessage = 15,
    OwnershipRequestAckMessage = 17,
    OwnershipRequestMessage = 18,
    TradeBustNotificationMessage = 19,
    CollarBreachConfirmationMessage = 20,
    PriceInputMessage = 28,
    LiquidityProviderCommandMessage = 32,
    AskForQuoteMessage = 33,
    RequestForExecutionMessage = 34,
    RfqNotificationMessage = 35,
    RfqMatchingStatusMessage = 36,
    RfqlpMatchingStatusMessage = 37,
    UserNotificationMessage = 39,
    MmSignInMessage = 47,
    MmSignInAckMessage = 48,
    InstrumentSynchronizationListMessage = 50,
    SynchronizationTimeMessage = 51,
    SecurityDefinitionRequestMessage = 60,
    SecurityDefinitionAckMessage = 61,
    MmProtectionRequestMessage = 62,
    MmProtectionAckMessage = 63,
    NewWholesaleOrderMessage = 64,
    WholesaleOrderAckMessage = 65,
    RequestForImpliedExecutionMessage = 66,
    CrossOrderMessage = 67,
    LogonMessage = 100,
    LogonAckMessage = 101,
    LogonRejectMessage = 102,
    LogoutMessage = 103,
    HeartbeatMessage = 106,
    TestRequestMessage = 107,
    TechnicalRejectMessage = 108,
    DeclarationEntryMessage = 40,
    DeclarationEntryAckMessage = 41,
    DeclarationNoticeMessage = 42,
    DeclarationCancelAndRefusalMessage = 43,
    FundPriceInputMessage = 44,
    FundPriceInputAckMessage = 45,
    DeclarationEntryRejectMessage = 46,
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = 0,
    GoodTillCancel = 1,
    ValidforUncrossing = 2,
    ImmediateorCancel = 3,
    FillorKill = 4,
    GoodtillTime = 5,
    GoodtillDate = 6,
    ValidforClosingUncrossing = 7,
    ValidforSession = 8,
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
    LargeinScaleTradeinbasispoints = 42,
    LargeinScalePackageTradeinbasispoints = 43,
    StrategyLegLargeinScaleTradeinbasispoints = 44,
    LargeinScaleTrade = 41,
    ConventionalTradeProvisionalprice = 100,
    LargeinScaleLiSTradeProvisionalprice = 101,
    LargeinScaleLiSPackageTradeProvisionalprice = 102,
};

/// <summary>
///  Trading Capacity Values
/// </summary>
public enum TradingCapacity : byte {
    Dealingonownaccount = 1,
    Matchedprincipal = 2,
    Anyothercapacity = 3,
    NoValue = 255,
};

/// <summary>
///  Trading Capacity Cross Values
/// </summary>
public enum TradingCapacityCross : byte {
    Dealingonownaccount = 1,
    Matchedprincipal = 2,
    Anyothercapacity = 3,
    NoValue = 255,
};

/// <summary>
///  Transaction Price Type Values
/// </summary>
public enum TransactionPriceType : byte {
    PlainVanillaTrade = 1,
    NonPriceFormingTrade = 2,
    TradeNotContributingtoPriceDiscoveryProcess = 3,
    DarkTrade = 4,
    NoValue = 255,
};

/// <summary>
///  Undisclosed Iceberg Type Values
/// </summary>
public enum UndisclosedIcebergType : byte {
    Limit = 1,
    PegMidPoint = 2,
    PegPrimary = 3,
    PegMarket = 4,
    NoValue = 255,
};

/// <summary>
///  User Status Values
/// </summary>
public enum UserStatus : byte {
    TraderAlgoSuspended = 1,
    TraderAlgoSuspensionCleared = 2,
    TraderAlgoKilled = 3,
    TraderAlgoKillCleared = 4,
    FirmSuspended = 5,
    FirmSuspensionCleared = 6,
    FirmKilled = 7,
    FirmKillCleared = 8,
    DeaSuspended = 9,
    DeaSuspensionCleared = 10,
    DeaKilled = 11,
    DeaKillCleared = 12,
    TraderAlgoSuspendedbyRiskManager = 13,
    TraderAlgoUnsuspendedbyRiskManager = 14,
    FirmSuspendedbyRiskManager = 15,
    FirmUnsuspendedbyRiskManager = 16,
    DeaSuspendedbyRiskManager = 17,
    DeaUnsuspendedbyRiskManager = 18,
    LogicalAccessSuspendedbyRiskManager = 19,
    LogicalAccessUnsuspendedbyRiskManager = 20,
    TraderAlgoBlockedbyRiskManager = 21,
    TraderAlgoUnblockedbyRiskManager = 22,
    FirmBlockedbyRiskManager = 23,
    FirmUnblockedbyRiskManager = 24,
    DeaBlockedbyRiskManager = 25,
    DeaUnblockedbyRiskManager = 26,
    LogicalAccessBlockedbyRiskManager = 27,
    LogicalAccessUnblockedbyRiskManager = 28,
    OrderSizeLimitActivatedbyRiskManager = 29,
    OrderSizeLimitDeactivatedbyRiskManager = 30,
};

/// <summary>
///  Wholesale Side Values
/// </summary>
public enum WholesaleSide : byte {
    Buy = 1,
    Sell = 2,
    Cross = 3,
};

/// <summary>
///  Wholesale Trade Type Values
/// </summary>
public enum WholesaleTradeType : byte {
    LargeinScaleTradeFormerlyBlockTrade = 0,
    AgainstActual = 1,
    ExchangeForSwaps = 2,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public long OrigClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public OrderSide OrderSide;
    public AckType AckType;
    public AckPhase AckPhase;
    public ulong OrderId;
    public ulong OrderPriority;
    public long OrderPx;
    public ulong OrderQty;
    public fixed byte AckQualifiers[0];
};

/// <summary>
///  Struct for Ack Qualifiers
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AckQualifiers {
    public fixed byte ExecutedUponEntryFlag[1];
    public fixed byte ExecutionUponEntryFlagEnabled[1];
    public fixed byte Internal2[1];
    public fixed byte Internal1[1];
    public fixed byte UseOfCrossPartition[1];
    public fixed byte RequestWithClientOrderId[1];
    public fixed byte QueueIndicator[1];
    public fixed byte DarkIndicator[1];
};

/// <summary>
///  Struct for Additional Infos Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdditionalInfosGroup {
    public fixed sbyte LongClientId[16];
};

/// <summary>
///  Struct for Additional Infos Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdditionalInfosGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Ask For Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AskForQuoteMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public uint SymbolIndex;
    public Emm Emm;
    public AfqReason AfqReason;
};

/// <summary>
///  Struct for Clearing Dataset Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingDatasetGroup {
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte ClientId[8];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public fixed sbyte FreeText[18];
};

/// <summary>
///  Struct for Clearing Dataset Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingDatasetGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Clearing Fields Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingFieldsGroup {
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte ClientId[8];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public AccountTypeCross AccountTypeCross;
};

/// <summary>
///  Struct for Clearing Fields Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingFieldsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Clearing Fields X Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingFieldsXGroup {
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte LongClientId[16];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public AccountType AccountType;
    public TradingCapacity TradingCapacity;
};

/// <summary>
///  Struct for Clearing Fields X Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ClearingFieldsXGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Collar Breach Confirmation Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollarBreachConfirmationMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public ulong OrderId;
    public long OrigClientOrderId;
};

/// <summary>
///  Struct for Collar Fields Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollarFieldsGroup {
    public CollarRejType CollarRejType;
    public long BreachedCollarPrice;
};

/// <summary>
///  Struct for Collar Fields Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CollarFieldsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Dark Execution Instruction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DarkExecutionInstruction {
    public fixed byte Reserved3[3];
    public fixed byte MinimumQuantityType[1];
    public fixed byte SweepOrderIndicator[1];
    public fixed byte DisplayedOrderInteraction[1];
    public fixed byte DeferredTradeIndicator[1];
    public fixed byte DarkIndicator[1];
};

/// <summary>
///  Struct for Declaration Cancel And Refusal Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeclarationCancelAndRefusalMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public ulong DeclarationId;
    public ActionType ActionType;
};

/// <summary>
///  Struct for Declaration Entry Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeclarationEntryAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong DeclarationId;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public fixed sbyte MiCofSecondaryListing[4];
    public OperationType OperationType;
    public PreMatchingType PreMatchingType;
    public fixed byte WaiverIndicator[0];
};

/// <summary>
///  Struct for Declaration Entry Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeclarationEntryMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public OperationType OperationType;
    public uint SymbolIndex;
    public Emm Emm;
    public fixed sbyte EnteringCounterparty[8];
    public Side Side;
    public ulong Quantity;
    public long Price;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public fixed sbyte MiCofSecondaryListing[4];
    public fixed sbyte CentralisationDate[10];
    public fixed sbyte ClearingFirmId[8];
    public AccountType AccountType;
    public AccountTypeCross AccountTypeCross;
    public TradingCapacity TradingCapacity;
    public TradingCapacityCross TradingCapacityCross;
    public byte SettlementPeriod;
    public byte SettlementFlag;
    public GuaranteeFlag GuaranteeFlag;
    public fixed byte MiFidIndicators[0];
    public TransactionPriceType TransactionPriceType;
    public fixed sbyte PrincipalCode[8];
    public fixed sbyte PrincipalCodeCross[8];
    public uint StartTimeVwap;
    public uint EndTimeVwap;
    public long GrossTradeAmount;
    public fixed sbyte AccountNumber[12];
    public fixed sbyte AccountNumberCross[12];
    public fixed sbyte FreeText[18];
    public fixed sbyte FreeTextCross[18];
    public int InvestmentDecisionWFirmShortCode;
    public int ClientIdentificationShortCodeCross;
};

/// <summary>
///  Struct for Declaration Entry Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeclarationEntryRejectMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public fixed sbyte MiCofSecondaryListing[4];
    public OperationType OperationType;
    public ushort ErrorCode;
    public byte RejectedMessage;
    public ushort RejectedMessageId;
};

/// <summary>
///  Struct for Execution Instruction
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutionInstruction {
    public fixed byte Reserved1[1];
    public fixed byte ConditionalOrder[1];
    public fixed byte RfqConfirmation[1];
    public fixed byte RfqAnswer[1];
    public fixed byte DisabledCancelOnDisconnectIndicator[1];
    public fixed byte DisclosedQuantityRandomization[1];
    public fixed byte StpIncomingOrder[1];
    public fixed byte StpRestingOrder[1];
};

/// <summary>
///  Struct for Free Text Section Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FreeTextSectionGroup {
    public fixed sbyte FreeText[18];
};

/// <summary>
///  Struct for Free Text Section Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FreeTextSectionGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Fund Price Input Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FundPriceInputAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public long Price;
    public byte BypassIndicator;
};

/// <summary>
///  Struct for Fund Price Input Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FundPriceInputMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public long Price;
    public byte BypassIndicator;
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
///  Struct for Instrument Synchronization List Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentSynchronizationListMessage {
    public uint MsgSeqNum;
    public ulong OegoutToMember;
    public ushort ResynchronizationId;
};

/// <summary>
///  Struct for Instrument Synchronization Section Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentSynchronizationSectionGroup {
    public uint SymbolIndex;
    public Emm Emm;
};

/// <summary>
///  Struct for Instrument Synchronization Section Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrumentSynchronizationSectionGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Kill Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct KillMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public long OrigClientOrderId;
    public ulong OrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public KillReason KillReason;
    public fixed byte AckQualifiers[0];
};

/// <summary>
///  Struct for Liquidity Provider Command Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LiquidityProviderCommandMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public LpActionCode LpActionCode;
};

/// <summary>
///  Struct for Logon Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonAckMessage {
    public fixed sbyte ExchangeId[8];
    public uint LastClMsgSeqNum;
};

/// <summary>
///  Struct for Logon Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonMessage {
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public uint LastMsgSeqNum;
    public fixed sbyte SoftwareProvider[8];
    public byte QueueingIndicator;
};

/// <summary>
///  Struct for Logon Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogonRejectMessage {
    public fixed sbyte ExchangeId[8];
    public LogonRejectCode LogonRejectCode;
    public uint LastClMsgSeqNum;
    public uint LastMsgSeqNum;
};

/// <summary>
///  Struct for Logout Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutMessage {
    public LogOutReasonCode LogOutReasonCode;
};

/// <summary>
///  Struct for Mass Cancel Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public int TotalAffectedOrders;
    public uint SymbolIndex;
    public Emm Emm;
    public fixed sbyte InstrumentGroupCode[2];
    public OrderSide OrderSide;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public uint ContractId;
    public fixed sbyte Maturity[8];
    public AccountType AccountType;
    public OptionType OptionType;
    public OrderCategory OrderCategory;
    public fixed byte AckQualifiers[0];
    public int TargetExecutionWithinFirmShortCode;
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
///  Struct for Mi Fi D Fields Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MiFiDFieldsGroup {
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public fixed byte MiFidIndicators[0];
};

/// <summary>
///  Struct for Mi Fi D Fields Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MiFiDFieldsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Mi Fi D Shortcodes Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MiFiDShortcodesGroup {
    public int InvestmentDecisionWFirmShortCode;
    public int NonExecutingBrokerShortCode;
    public int ClientIdentificationShortcode;
};

/// <summary>
///  Struct for Mi Fi D Shortcodes Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MiFiDShortcodesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Mi Fid Indicators
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MiFidIndicators {
    public fixed byte Reserved2[2];
    public fixed byte Frmaramplp[1];
    public fixed byte DeferralIndicator[1];
    public fixed byte CommodityDerivativeIndicator[1];
    public fixed byte ExecutionAlgoIndicator[1];
    public fixed byte InvestmentAlgoIndicator[1];
    public fixed byte DeaIndicator[1];
};

/// <summary>
///  Struct for Mm P Section 2 Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmPSection2Group {
    public ProtectionType ProtectionType;
    public ulong ProtectionThreshold;
    public BreachAction BreachAction;
    public long CurrentMmpPosition;
    public byte BreachStatus;
};

/// <summary>
///  Struct for Mm P Section 2 Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmPSection2Groups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Mm P Section Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmPSectionGroup {
    public ProtectionType ProtectionType;
    public ulong ProtectionThreshold;
    public BreachAction BreachAction;
};

/// <summary>
///  Struct for Mm P Section Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmPSectionGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Mm Protection Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmProtectionAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public int ExecutionWithinFirmShortCode;
    public uint SymbolIndex;
    public Emm Emm;
    public fixed byte MmpExecutionType[0];
};

/// <summary>
///  Struct for Mm Protection Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmProtectionRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public int ExecutionWithinFirmShortCode;
    public uint SymbolIndex;
    public Emm Emm;
    public RequestType RequestType;
};

/// <summary>
///  Struct for Mm Sign In Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmSignInAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public int ExecutionWithinFirmShortCode;
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public fixed sbyte FreeText[18];
    public fixed sbyte LongClientId[16];
};

/// <summary>
///  Struct for Mm Sign In Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmSignInMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public int ExecutionWithinFirmShortCode;
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public fixed sbyte FreeText[18];
    public fixed sbyte LongClientId[16];
};

/// <summary>
///  Struct for Mmp Execution Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MmpExecutionType {
    public fixed byte Reserved5[5];
    public fixed byte Pull[1];
    public fixed byte Acknowledgement[1];
    public fixed byte Notification[1];
};

/// <summary>
///  Struct for Not Used Group 1 Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotUsedGroup1Groups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Not Used Group 2 Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NotUsedGroup2Groups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Open Close
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenClose {
    public fixed byte Reserved6[6];
    public fixed byte Leg9[1];
    public fixed byte Leg8[1];
    public fixed byte Leg7[1];
    public fixed byte Leg6[1];
    public fixed byte Leg5[1];
    public fixed byte Leg4[1];
    public fixed byte Leg3[1];
    public fixed byte Leg2[1];
    public fixed byte Leg1[1];
    public fixed byte FieldActivelyUsed[1];
};

/// <summary>
///  Struct for Open Order Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenOrderRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public ulong OrderId;
    public long OrigClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public OrderCategory OrderCategory;
};

/// <summary>
///  Struct for Optional Fields Derivatives Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsDerivativesGroup {
    public long EvaluatedPrice;
    public MessagePriceNotation MessagePriceNotation;
};

/// <summary>
///  Struct for Optional Fields Derivatives Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsDerivativesGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Optional Fields Fill Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsFillGroup {
    public fixed sbyte CounterpartFirmId[8];
    public long OtherLegLastPx;
    public fixed sbyte PackageId[12];
    public uint UnderlyingInstrumentId;
};

/// <summary>
///  Struct for Optional Fields Fill Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsFillGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Optional Fields Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsGroup {
    public long StopPx;
    public long UndisclosedPrice;
    public ulong DisclosedQty;
    public ulong MinOrderQty;
    public ulong QuoteReqId;
    public uint OrderExpirationTime;
    public ushort OrderExpirationDate;
    public sbyte PegOffset;
    public fixed byte TradingSession[0];
    public UndisclosedIcebergType UndisclosedIcebergType;
    public StopTriggeredTimeInForce StopTriggeredTimeInForce;
};

/// <summary>
///  Struct for Optional Fields Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionalFieldsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Ownership Request Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OwnershipRequestAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public long ClientOrderId;
    public ulong OrderId;
    public uint SymbolIndex;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public int TotalAffectedOrders;
    public OrderCategory OrderCategory;
};

/// <summary>
///  Struct for Ownership Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OwnershipRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public ulong OrderId;
    public long OrigClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public OrderCategory OrderCategory;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
};

/// <summary>
///  Struct for Price Input Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PriceInputMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public InputPriceType InputPriceType;
    public long Price;
};

/// <summary>
///  Struct for Quote Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public AccountType AccountType;
    public LpRole LpRole;
    public int ExecutionWithinFirmShortCode;
    public fixed byte AckQualifiers[0];
};

/// <summary>
///  Struct for Quote Acks Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteAcksGroup {
    public ulong BidOrderId;
    public ulong OfferOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public BuyRevisionFlag BuyRevisionFlag;
    public SellRevisionFlag SellRevisionFlag;
    public ushort BidErrorCode;
    public ushort OfferErrorCode;
};

/// <summary>
///  Struct for Quote Acks Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteAcksGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Quote Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public ulong OrderQty;
    public uint SymbolIndex;
    public Emm Emm;
    public OrderSide OrderSide;
    public byte FirmIdPublication;
    public fixed sbyte EndClient[11];
    public fixed byte DarkExecutionInstruction[0];
    public ulong MinOrderQty;
};

/// <summary>
///  Struct for Quotes Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuotesRepGroup {
    public ulong BidSize;
    public long BidPx;
    public ulong OfferSize;
    public long OfferPx;
    public uint SymbolIndex;
    public Emm Emm;
};

/// <summary>
///  Struct for Quotes Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuotesRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Request For Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForExecutionMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public uint SymbolIndex;
    public Emm Emm;
};

/// <summary>
///  Struct for Request For Implied Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForImpliedExecutionMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint SymbolIndex;
    public Emm Emm;
    public ulong OrderId;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public fixed byte MiFidIndicators[0];
};

/// <summary>
///  Struct for Rfq Matching Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqMatchingStatusMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public ulong QuoteReqId;
    public long PotentialMatchingPx;
    public ulong PotentialMatchingQty;
    public uint SymbolIndex;
    public Emm Emm;
    public OrderSide OrderSide;
    public byte NumberOfLPs;
    public RecipientType RecipientType;
};

/// <summary>
///  Struct for Rfq Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqNotificationMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public ulong QuoteReqId;
    public ulong OrderQty;
    public fixed sbyte CounterpartFirmId[8];
    public uint SymbolIndex;
    public Emm Emm;
    public RfqUpdateType RfqUpdateType;
    public OrderSide OrderSide;
    public fixed sbyte EndClient[11];
    public fixed byte DarkExecutionInstruction[0];
    public ulong MinOrderQty;
};

/// <summary>
///  Struct for Rfqlp Matching Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RfqlpMatchingStatusMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public ulong QuoteReqId;
    public ulong PotentialMatchingQty;
    public uint SymbolIndex;
    public Emm Emm;
    public OrderSide OrderSide;
};

/// <summary>
///  Struct for Security Definition Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionAckMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public ulong OeginFromMember;
    public ulong OegoutTimeToMe;
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long SecurityReqId;
    public uint SymbolIndex;
};

/// <summary>
///  Struct for Security Definition Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityDefinitionRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long SecurityReqId;
    public uint ContractSymbolIndex;
    public StrategyCode StrategyCode;
};

/// <summary>
///  Struct for Strategy Fields Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyFieldsGroup {
    public long LegLastPx;
    public ulong LegLastQty;
    public uint LegInstrumentId;
    public LegSide LegSide;
    public uint ExecutionId;
};

/// <summary>
///  Struct for Strategy Fields Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyFieldsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Strategy Legs Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyLegsGroup {
    public uint LegSymbolIndex;
    public uint LegRatio;
    public LegSecurityType LegSecurityType;
    public LegPutOrCall LegPutOrCall;
    public long LegPrice;
    public long LegStrikePrice;
    public fixed sbyte LegLastTradingDate[8];
    public LegSide LegSide;
};

/// <summary>
///  Struct for Strategy Legs Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrategyLegsGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Synchronization Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SynchronizationTimeMessage {
    public uint MsgSeqNum;
    public ulong OegoutToMember;
    public ushort ResynchronizationId;
    public ulong LastBookInTime;
};

/// <summary>
///  Struct for Technical Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TechnicalRejectMessage {
    public ulong OegoutToMember;
    public uint RejectedClientMessageSequenceNumber;
    public byte RejectedMessage;
    public ushort ErrorCode;
    public ushort RejectedMessageId;
};

/// <summary>
///  Struct for Trade Bust Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBustNotificationMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong BookIn;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public uint SymbolIndex;
    public Emm Emm;
    public uint ExecutionId;
    public long LastTradedPx;
    public ulong LastShares;
    public uint LisTransactionId;
    public uint ParentExecId;
    public uint ParentSymbolIndex;
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
///  Struct for Trading Session
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingSession {
    public fixed byte Reserved4[4];
    public fixed byte Session3[1];
    public fixed byte Session2[1];
    public fixed byte Session1[1];
    public fixed byte Reserved1[1];
};

/// <summary>
///  Struct for User Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserNotificationMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public fixed sbyte FamilyId[8];
    public uint SymbolIndex;
    public UserStatus UserStatus;
    public uint LogicalAccessId;
    public ulong OrderSizeLimit;
};

/// <summary>
///  Struct for Waiver Indicator
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WaiverIndicator {
    public fixed byte Omf[1];
    public fixed byte Ilqd[1];
    public fixed byte Size[1];
    public fixed byte Pric[1];
    public fixed byte Oilq[1];
    public fixed byte Nliq[1];
    public fixed byte Rfpt[1];
    public fixed byte Lrgs[1];
};

/// <summary>
///  Struct for Wholesale Ack Clearing Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleAckClearingRepGroup {
    public uint SymbolIndex;
    public Side Side;
    public int InvestmentDecisionWFirmShortCode;
    public int NonExecutingBrokerShortCode;
    public int ClientIdentificationShortcode;
    public ushort NonExecutingClientId;
};

/// <summary>
///  Struct for Wholesale Ack Clearing Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleAckClearingRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Wholesale Ack Legs Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleAckLegsRepGroup {
    public uint LegSymbolIndex;
    public ulong LegBidOrderId;
    public ulong LegOfferOrderId;
    public LegSide LegSide;
    public ushort LegErrorCode;
};

/// <summary>
///  Struct for Wholesale Ack Legs Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleAckLegsRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Wholesale Client Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleClientRepGroup {
    public uint SymbolIndex;
    public Side Side;
    public AccountType AccountType;
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte LongClientId[16];
    public fixed sbyte AccountNumber[12];
    public TechnicalOrigin TechnicalOrigin;
    public fixed byte OpenClose[0];
    public ClearingInstruction ClearingInstruction;
    public fixed sbyte FreeText[18];
    public ushort NonExecutingClientId;
    public int InvestmentDecisionWFirmShortCode;
    public int NonExecutingBrokerShortCode;
    public int ClientIdentificationShortcode;
    public TradingCapacity TradingCapacity;
};

/// <summary>
///  Struct for Wholesale Client Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleClientRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

/// <summary>
///  Struct for Wholesale Legs Rep Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleLegsRepGroup {
    public uint LegSymbolIndex;
    public long LegPrice;
    public ulong BidQuantity;
    public ulong OfferQuantity;
    public LegSide LegSide;
    public long LegStrikePrice;
    public uint LegRatio;
    public LegPutOrCall LegPutOrCall;
    public LegSecurityType LegSecurityType;
    public fixed sbyte LegLastTradingDate[8];
};

/// <summary>
///  Struct for Wholesale Legs Rep Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleLegsRepGroups {
    public fixed byte GroupSizeEncoding[0];
};

