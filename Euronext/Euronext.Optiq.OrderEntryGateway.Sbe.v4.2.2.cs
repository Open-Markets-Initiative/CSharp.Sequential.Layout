// C# Structs For Euronext Optiq Sbe OrderEntryGateway 4.2.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

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
    public byte Emm;
    public byte OrderSide;
    public byte AckType;
    public byte AckPhase;
    public ulong OrderId;
    public ulong OrderPriority;
    public long OrderPx;
    public ulong OrderQty;
    public byte AckQualifiers;
};

/// <summary>
///  Struct for Ask For Quote Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AskForQuoteMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public uint SymbolIndex;
    public byte Emm;
    public byte AfqReason;
};

/// <summary>
///  Struct for Cancel Replace Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelReplaceMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public ulong OrderId;
    public long OrigClientOrderId;
    public long OrderPx;
    public ulong OrderQty;
    public uint SymbolIndex;
    public byte Emm;
    public byte OrderSide;
    public byte OrderType;
    public byte TimeInForce;
    public byte AccountType;
    public byte LpRole;
    public byte ExecutionInstruction;
    public byte DarkExecutionInstruction;
    public byte MiFidIndicators;
    public ushort Stpid;
};

/// <summary>
///  Struct for Cancel Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRequestMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public ulong OrderId;
    public long OrigClientOrderId;
    public uint SymbolIndex;
    public byte Emm;
    public byte OrderSide;
    public byte OrderType;
    public byte OrderCategory;
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
    public byte Emm;
    public ulong OrderId;
    public long OrigClientOrderId;
};

/// <summary>
///  Struct for Cross Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint SymbolIndex;
    public byte Emm;
    public byte OrderSide;
    public byte OrderType;
    public long OrderPx;
    public ulong OrderQty;
    public int ExecutionWithinFirmShortCode;
    public byte MiFidIndicators;
    public ushort NonExecutingClientId;
    public byte OrderActorType;
    public byte MessagePriceNotation;
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
    public byte Emm;
    public ulong DeclarationId;
    public byte ActionType;
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
    public byte Emm;
    public fixed sbyte MiCofSecondaryListing[4];
    public byte OperationType;
    public byte PreMatchingType;
    public byte WaiverIndicator;
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
    public byte OperationType;
    public uint SymbolIndex;
    public byte Emm;
    public fixed sbyte EnteringCounterparty[8];
    public byte Side;
    public ulong Quantity;
    public long Price;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public fixed sbyte MiCofSecondaryListing[4];
    public fixed sbyte CentralisationDate[10];
    public fixed sbyte ClearingFirmId[8];
    public byte AccountType;
    public byte AccountTypeCross;
    public byte TradingCapacity;
    public byte TradingCapacityCross;
    public byte SettlementPeriod;
    public byte SettlementFlag;
    public byte GuaranteeFlag;
    public byte MiFidIndicators;
    public byte TransactionPriceType;
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
    public byte Emm;
    public fixed sbyte MiCofSecondaryListing[4];
    public byte OperationType;
    public ushort ErrorCode;
    public byte RejectedMessage;
    public ushort RejectedMessageId;
};

/// <summary>
///  Struct for Declaration Notice Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeclarationNoticeMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public long ClientOrderId;
    public ulong DeclarationId;
    public byte DeclarationStatus;
    public byte OperationType;
    public uint SymbolIndex;
    public byte Emm;
    public fixed sbyte EnteringCounterparty[8];
    public byte Side;
    public ulong Quantity;
    public long Price;
    public byte PreMatchingType;
    public ulong TradeTime;
    public fixed sbyte MiCofSecondaryListing[4];
    public fixed sbyte CentralisationDate[10];
    public fixed sbyte ClearingFirmId[8];
    public byte AccountType;
    public byte AccountTypeCross;
    public byte TradingCapacity;
    public byte TradingCapacityCross;
    public byte SettlementFlag;
    public byte SettlementPeriod;
    public byte GuaranteeFlag;
    public byte TransactionPriceType;
    public fixed sbyte PrincipalCode[8];
    public fixed sbyte PrincipalCodeCross[8];
    public uint StartTimeVwap;
    public uint EndTimeVwap;
    public long GrossTradeAmount;
    public fixed sbyte AccountNumber[12];
    public fixed sbyte AccountNumberCross[12];
    public fixed sbyte FreeText[18];
    public fixed sbyte FreeTextCross[18];
    public byte WaiverIndicator;
    public byte PreviousDayIndicator;
    public long MiscellaneousFeeAmount;
    public byte Ccpid;
};

/// <summary>
///  Struct for Fill Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FillMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong TradeTime;
    public ulong BookOutTime;
    public ulong OeginFromMe;
    public ulong OegoutToMember;
    public long ClientOrderId;
    public uint SymbolIndex;
    public byte Emm;
    public byte OrderSide;
    public byte TradeType;
    public byte TradeQualifier;
    public ulong OrderId;
    public long LastTradedPx;
    public ulong LastShares;
    public ulong LeavesQty;
    public uint ExecutionId;
    public byte ExecutionPhase;
    public uint LisTransactionId;
    public byte EscbMembership;
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
    public byte Emm;
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
    public byte Emm;
    public long Price;
    public byte BypassIndicator;
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
    public byte Emm;
    public ushort KillReason;
    public byte AckQualifiers;
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
    public byte Emm;
    public byte LpActionCode;
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
    public byte LogonRejectCode;
    public uint LastClMsgSeqNum;
    public uint LastMsgSeqNum;
};

/// <summary>
///  Struct for Logout Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutMessage {
    public byte LogOutReasonCode;
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
    public byte Emm;
    public fixed sbyte InstrumentGroupCode[2];
    public byte OrderSide;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public uint ContractId;
    public fixed sbyte Maturity[8];
    public byte AccountType;
    public byte OptionType;
    public byte OrderCategory;
    public byte AckQualifiers;
    public int TargetExecutionWithinFirmShortCode;
};

/// <summary>
///  Struct for Mass Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public long ClientOrderId;
    public uint SymbolIndex;
    public byte Emm;
    public fixed sbyte InstrumentGroupCode[2];
    public byte OrderSide;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public uint ContractId;
    public fixed sbyte Maturity[8];
    public byte AccountType;
    public byte OptionType;
    public byte OrderCategory;
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
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
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
    public byte Emm;
    public byte MmpExecutionType;
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
    public byte Emm;
    public byte RequestType;
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
    public byte Emm;
    public int ExecutionWithinFirmShortCode;
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte AccountNumber[12];
    public byte TechnicalOrigin;
    public ushort OpenClose;
    public ushort ClearingInstruction;
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
    public byte Emm;
    public int ExecutionWithinFirmShortCode;
    public fixed sbyte ClearingFirmId[8];
    public fixed sbyte AccountNumber[12];
    public byte TechnicalOrigin;
    public ushort OpenClose;
    public ushort ClearingInstruction;
    public fixed sbyte FreeText[18];
    public fixed sbyte LongClientId[16];
};

/// <summary>
///  Struct for New Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint SymbolIndex;
    public byte Emm;
    public byte OrderSide;
    public byte OrderType;
    public byte TimeInForce;
    public long OrderPx;
    public ulong OrderQty;
    public int ExecutionWithinFirmShortCode;
    public byte TradingCapacity;
    public byte AccountType;
    public byte LpRole;
    public byte ExecutionInstruction;
    public byte DarkExecutionInstruction;
    public byte MiFidIndicators;
    public ushort Stpid;
    public ushort NonExecutingClientId;
};

/// <summary>
///  Struct for New Wholesale Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewWholesaleOrderMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public uint ContractSymbolIndex;
    public byte WholesaleTradeType;
    public uint LisTransactionId;
    public fixed sbyte StrategyCode[1];
    public long Price;
    public ulong Quantity;
    public int ExecutionWithinFirmShortCode;
    public byte MiFidIndicators;
    public byte WholesaleSide;
    public byte EscbMembership;
    public byte MessagePriceNotation;
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
    public byte Emm;
    public byte OrderCategory;
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
    public byte OrderCategory;
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
    public byte Emm;
    public uint LogicalAccessId;
    public ushort OePartitionId;
    public byte OrderCategory;
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
    public byte Emm;
    public byte InputPriceType;
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
    public byte AccountType;
    public byte LpRole;
    public int ExecutionWithinFirmShortCode;
    public byte AckQualifiers;
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
    public byte Emm;
    public byte OrderSide;
    public byte FirmIdPublication;
    public fixed sbyte EndClient[11];
    public byte DarkExecutionInstruction;
    public ulong MinOrderQty;
};

/// <summary>
///  Struct for Quotes Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuotesMessage {
    public uint ClMsgSeqNum;
    public fixed sbyte FirmId[8];
    public ulong SendingTime;
    public long ClientOrderId;
    public int ExecutionWithinFirmShortCode;
    public byte TradingCapacity;
    public byte AccountType;
    public byte LpRole;
    public byte MiFidIndicators;
    public byte RfeAnswer;
    public byte ExecutionInstruction;
};

/// <summary>
///  Struct for Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RejectMessage {
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
    public ulong OrderId;
    public uint SymbolIndex;
    public byte Emm;
    public byte RejectedMessage;
    public ushort ErrorCode;
    public ushort RejectedMessageId;
    public byte AckQualifiers;
};

/// <summary>
///  Struct for Request For Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForExecutionMessage {
    public uint MsgSeqNum;
    public fixed sbyte FirmId[8];
    public uint SymbolIndex;
    public byte Emm;
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
    public byte Emm;
    public ulong OrderId;
    public int ExecutionWithinFirmShortCode;
    public int ClientIdentificationShortcode;
    public byte MiFidIndicators;
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
    public byte Emm;
    public byte OrderSide;
    public byte NumberOfLPs;
    public byte RecipientType;
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
    public byte Emm;
    public byte RfqUpdateType;
    public byte OrderSide;
    public fixed sbyte EndClient[11];
    public byte DarkExecutionInstruction;
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
    public byte Emm;
    public byte OrderSide;
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
    public fixed sbyte StrategyCode[1];
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
    public byte Emm;
    public uint ExecutionId;
    public long LastTradedPx;
    public ulong LastShares;
    public uint LisTransactionId;
    public uint ParentExecId;
    public uint ParentSymbolIndex;
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
    public byte UserStatus;
    public uint LogicalAccessId;
    public ulong OrderSizeLimit;
};

/// <summary>
///  Struct for Wholesale Order Ack Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WholesaleOrderAckMessage {
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
    public uint ContractSymbolIndex;
    public byte WholesaleTradeType;
    public uint LisTransactionId;
    public fixed sbyte StrategyCode[1];
    public long Price;
    public ulong Quantity;
    public int ExecutionWithinFirmShortCode;
    public byte MiFidIndicators;
    public byte WholesaleSide;
    public byte EscbMembership;
    public byte ResponseType;
    public ushort ErrorCode;
    public byte AckQualifiers;
};

