// C# Structs For Nasdaq Bx Equities Ouch Orders 4.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Bbo Weight Indicator Values
/// </summary>
public enum BboWeightIndicator : byte {
    002 = (byte)'0',
    021 = (byte)'1',
    12 = (byte)'2',
    GreaterThan2 = (byte)'3',
    SetsTheQbbo = (byte)'S',
    ImprovesTheNbbo = (byte)'N',
};

/// <summary>
///  Broken Trade Reason Values
/// </summary>
public enum BrokenTradeReason : byte {
    Erroneous = (byte)'E',
    Consent = (byte)'C',
    Supervisory = (byte)'S',
    External = (byte)'X',
};

/// <summary>
///  Buy Sell Indicator Values
/// </summary>
public enum BuySellIndicator : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    SellShort = (byte)'T',
    SellShortExempt = (byte)'E',
};

/// <summary>
///  Canceled Reason Values
/// </summary>
public enum CanceledReason : byte {
    UserRequestedCancel = (byte)'U',
    ImmediateOrCancelOrder = (byte)'I',
    Timeout = (byte)'T',
    Supervisory = (byte)'S',
    ThisOrderCannotBeExecutedBecauseOfARegulatoryRestriction = (byte)'D',
    SelfMatchPrevention = (byte)'Q',
    SystemCancel = (byte)'Z',
    Closed = (byte)'E',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    Other = (byte)'O',
    Agency = (byte)'A',
    Principal = (byte)'P',
    Riskless = (byte)'R',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    NoCross = (byte)'N',
    Opening = (byte)'O',
    Closing = (byte)'C',
    Retail = (byte)'R',
};

/// <summary>
///  Display Values
/// </summary>
public enum Display : byte {
    AttributablePrice = (byte)'A',
    AnonymousPrice = (byte)'Y',
    NonDisplay = (byte)'N',
    PostOnly = (byte)'P',
    ImbalanceOnly = (byte)'I',
    ChangedToNondisplayed = (byte)'Z',
    MidPoint = (byte)'M',
    RetailOrderType1 = (byte)'O',
    RetailOrderType2 = (byte)'T',
    RetailPriceImprovementOrder = (byte)'Q',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfDay = (byte)'S',
    EndOfDay = (byte)'E',
};

/// <summary>
///  Intermarket Sweep Eligibility Values
/// </summary>
public enum IntermarketSweepEligibility : byte {
    Eligible = (byte)'Y',
    NotEligible = (byte)'N',
    Tradeat = (byte)'y',
};

/// <summary>
///  Liquidity Flag Values
/// </summary>
public enum LiquidityFlag : byte {
    Added = (byte)'A',
    Removed = (byte)'R',
    Nondisplayed = (byte)'J',
    Removed = (byte)'m',
    Added = (byte)'k',
    Rpi = (byte)'j',
    RmoRetailOrderRemovesRpiLiquidity = (byte)'r',
    RmoRetailOrderRemovesPriceImprovingNondisplayedLiquidityOtherThanRpiLiquidity = (byte)'t',
    RmoRetailOrderRemovesNonRpiMidpointLiquidity = (byte)'q',
    DisplayedLiquidityaddingOrderImprovesTheNbbo = (byte)'7',
    DisplayedLiquidityaddingOrderSetsTheBxbboWhileJoiningTheNbbo = (byte)'8',
    RemovedPriceImprovingNondisplayedLiquidity = (byte)'p',
    PassiveMidpointExecution = (byte)'N',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    EnterOrderMessage = (byte)'O',
    ReplaceOrderMessage = (byte)'U',
    CancelOrderMessage = (byte)'X',
    ModifyOrderMessage = (byte)'M',
    TradeNowMessage = (byte)'N',
    SystemEventMessage = (byte)'S',
    AcceptedMessage = (byte)'A',
    ReplacedMessage = (byte)'U',
    CanceledMessage = (byte)'C',
    AiqCanceledMessage = (byte)'D',
    ExecutedMessage = (byte)'E',
    BrokenTradeMessage = (byte)'B',
    RejectedMessage = (byte)'J',
    CancelPendingMessage = (byte)'P',
    CancelRejectMessage = (byte)'I',
    OrderPriorityUpdateMessage = (byte)'T',
    OrderModifiedMessage = (byte)'M',
};

/// <summary>
///  Order State Values
/// </summary>
public enum OrderState : byte {
    Live = (byte)'L',
    Dead = (byte)'D',
};

/// <summary>
///  Packet Type Values
/// </summary>
public enum PacketType : byte {
    DebugPacket = (byte)'+',
    LoginAcceptedPacket = (byte)'A',
    LoginRejectedPacket = (byte)'J',
    SequencedDataPacket = (byte)'S',
    ServerHeartbeatPacket = (byte)'H',
    EndOfSessionPacket = (byte)'Z',
    LoginRequestPacket = (byte)'L',
    UnsequencedDataPacket = (byte)'U',
    ClientHeartbeatPacket = (byte)'R',
    LogoutRequestPacket = (byte)'O',
};

/// <summary>
///  Rejected Reason Values
/// </summary>
public enum RejectedReason : byte {
    TestMode = (byte)'T',
    Halted = (byte)'H',
    SharesExceedsConfiguredSafetyThreshold = (byte)'Z',
    InvalidStock = (byte)'S',
    InvalidDisplayType = (byte)'D',
    NasdaqOmxBxIsClosed = (byte)'C',
    RequestedFirmNotAuthorizedForRequestedClearingTypeOnThisAccount = (byte)'L',
    OutsideOfPermittedTimes = (byte)'M',
    ThisOrderIsNotAllowedInThisTypeOfCross = (byte)'R',
    InvalidPrice = (byte)'X',
    InvalidMinimum = (byte)'N',
    InvalidMidpoint = (byte)'W',
    MidpointPegOrdersAreNotAccepted = (byte)'q',
    Reject = (byte)'a',
    EasyToBorrowEtb = (byte)'b',
    Restricted = (byte)'c',
    Iso = (byte)'d',
    Odd = (byte)'e',
    MidPoint = (byte)'f',
    PreMarket = (byte)'g',
    PostMarket = (byte)'h',
    ShortSale = (byte)'i',
    OnOpen = (byte)'j',
    OnClose = (byte)'k',
    TwoSided = (byte)'l',
    Exceeded = (byte)'m',
    Exceeded = (byte)'n',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Accepted Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AcceptedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public ulong OrderReferenceNumber;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
    public OrderState OrderState;
    public BboWeightIndicator BboWeightIndicator;
};

/// <summary>
///  Struct for Aiq Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AiqCanceledMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint DecrementShares;
    public fixed sbyte AiqCanceledReason[1];
    public uint QuantityPreventedFromTrading;
    public uint ExecutionPrice;
    public LiquidityFlag LiquidityFlag;
};

/// <summary>
///  Struct for Broken Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public ulong MatchNumber;
    public BrokenTradeReason BrokenTradeReason;
};

/// <summary>
///  Struct for Cancel Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderMessage {
    public fixed sbyte OrderToken[14];
    public uint Shares;
};

/// <summary>
///  Struct for Cancel Pending Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelPendingMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Cancel Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Canceled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CanceledMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint DecrementShares;
    public CanceledReason CanceledReason;
};

/// <summary>
///  Struct for Debug Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DebugPacket {
    public fixed sbyte Text[1];
};

/// <summary>
///  Struct for Enter Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EnterOrderMessage {
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
};

/// <summary>
///  Struct for Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ExecutedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint ExecutedShares;
    public uint ExecutionPrice;
    public LiquidityFlag LiquidityFlag;
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Login Accepted Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginAcceptedPacket {
    public fixed sbyte Session[10];
    public fixed sbyte SequenceNumber[20];
};

/// <summary>
///  Struct for Login Rejected Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRejectedPacket {
    public fixed sbyte RejectReasonCode[1];
};

/// <summary>
///  Struct for Login Request Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LoginRequestPacket {
    public fixed sbyte Username[6];
    public fixed sbyte Password[10];
    public fixed sbyte RequestedSession[10];
    public fixed sbyte RequestedSequenceNumber[20];
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderMessage {
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
};

/// <summary>
///  Struct for Order Modified Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
};

/// <summary>
///  Struct for Order Priority Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriorityUpdateMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public uint Price;
    public Display Display;
    public ulong OrderReferenceNumber;
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public ushort PacketLength;
    public PacketType PacketType;
};

/// <summary>
///  Struct for Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RejectedMessage {
    public ulong Timestamp;
    public fixed sbyte OrderToken[14];
    public RejectedReason RejectedReason;
};

/// <summary>
///  Struct for Replace Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplaceOrderMessage {
    public fixed sbyte ExistingOrderToken[14];
    public fixed sbyte ReplacementOrderToken[14];
    public uint Shares;
    public uint Price;
    public uint TimeInForce;
    public Display Display;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
};

/// <summary>
///  Struct for Replaced Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ReplacedMessage {
    public ulong Timestamp;
    public fixed sbyte ReplacementOrderToken[14];
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public uint Price;
    public uint TimeInForce;
    public fixed sbyte Firm[4];
    public Display Display;
    public ulong OrderReferenceNumber;
    public Capacity Capacity;
    public IntermarketSweepEligibility IntermarketSweepEligibility;
    public uint MinimumQuantity;
    public CrossType CrossType;
    public OrderState OrderState;
    public fixed sbyte PreviousOrderToken[14];
    public BboWeightIndicator BboWeightIndicator;
};

/// <summary>
///  Struct for Sequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SequencedDataPacket {
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public ulong Timestamp;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Trade Now Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeNowMessage {
    public fixed sbyte OrderToken[14];
};

/// <summary>
///  Struct for Unsequenced Data Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnsequencedDataPacket {
};

