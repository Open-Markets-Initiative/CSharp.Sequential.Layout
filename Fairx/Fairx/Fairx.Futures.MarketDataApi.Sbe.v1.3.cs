// C# Structs For Fairx Futures Sbe MarketDataApi 1.3 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Product Group Values
/// </summary>
public enum ProductGroup : sbyte {
    Currency = 0,
    Equity = 1,
    Energy = 2,
    Metals = 3,
    Interestrate = 4,
    Agriculture = 5,
};

/// <summary>
///  Reason Values
/// </summary>
public enum Reason : sbyte {
    Seqtoolow = 1,
    Seqtoohigh = 2,
    Ratelimitexceeded = 3,
    Othererror = 4,
};

/// <summary>
///  Spread Buy Convention Values
/// </summary>
public enum SpreadBuyConvention : sbyte {
    Usefarbid = 1,
    Usenearbid = -1,
};

/// <summary>
///  Stat Type Values
/// </summary>
public enum StatType : byte {
    Dayopeningprice = (byte)'4',
    Closingprice = (byte)'5',
    Settlementprice = (byte)'6',
    Tradingsessionhighprice = (byte)'7',
    Tradingsessionlowprice = (byte)'8',
    Referenceprice = (byte)'F',
    Indicativeopeningprice = (byte)'I',
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    OutrightInstrumentDefinitionMessage = 10,
    SpreadInstrumentDefinitionMessage = 11,
    OptionInstrumentDefinitionMessage = 12,
    TradingStatusUpdateMessage = 17,
    OrderPutMessage = 20,
    OrderDeleteMessage = 21,
    ImpliedOrderUpdateMessage = 22,
    TradeSummaryMessage = 33,
    TradeMessage = 30,
    TradeAmendMessage = 31,
    SpreadTradeAmendMessage = 34,
    TradeBustMessage = 32,
    MarketStatMessage = 40,
    TradeSessionVolumeMessage = 41,
    OpenInterestMessage = 42,
    StartOfOutrightInstrumentSnapshotMessage = 110,
    StartOfSpreadInstrumentSnapshotMessage = 111,
    StartOfOptionInstrumentSnapshotMessage = 112,
    OrderSnapshotMessage = 120,
    EndOfSnapshotMessage = 122,
    RetransmitRequestMessage = 200,
    RetransmitRejectMessage = 202,
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : sbyte {
    Preopen = 0,
    Open = 1,
    Halt = 2,
    Pause = 3,
    Close = 4,
    Preopennocancel = 5,
    Expired = 6,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Definition Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DefinitionFlags {
    public fixed byte Reserved13[13];
    public fixed byte IsCall[1];
    public fixed byte IsAnnounced[1];
    public fixed byte IsPriorSettlementTheoretical[1];
};

/// <summary>
///  Struct for End Of Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EndOfSnapshotMessage {
    public ushort SnapshotSeqNum;
    public int TradeVolume;
    public long IndicativeOpenPrice;
    public long DayOpenPrice;
    public long ClosePrice;
    public long LowPrice;
    public long HighPrice;
    public long VwapPrice;
    public long SettlementPrice;
    public long LastTradePrice;
    public long LastTradeTime;
    public long BestBidImpliedPrice;
    public long BestAskImpliedPrice;
    public long NextBidImpliedPrice;
    public long NextAskImpliedPrice;
    public long LimitDownPrice;
    public long LimitUpPrice;
    public int LastTradeQty;
    public int OpenInterest;
    public int BestBidImpliedQty;
    public int BestAskImpliedQty;
    public int NextBidImpliedQty;
    public int NextAskImpliedQty;
    public long PriorSettlementPrice;
    public fixed byte DefinitionFlags[0];
};

/// <summary>
///  Struct for Implied Order Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderUpdateMessage {
    public fixed byte InstrHeader[0];
    public long BestPrice;
    public long NextPrice;
    public int BestQty;
    public int NextQty;
};

/// <summary>
///  Struct for Instr Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct InstrHeader {
    public byte InstrumentFlags;
    public sbyte InstrumentSide;
    public int InstrumentId;
    public uint InstrSeqNum;
    public ushort TradingSessionDate;
    public short Reserved;
    public long TransactTime;
};

/// <summary>
///  Struct for Market Stat Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStatMessage {
    public fixed byte InstrHeader[0];
    public long Price;
    public StatType StatType;
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort FrameLength;
    public ushort BlockLength;
    public TemplateId TemplateId;
    public ushort SchemaId;
    public ushort Version;
};

/// <summary>
///  Struct for Open Interest Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenInterestMessage {
    public fixed byte InstrHeader[0];
    public int Quantity;
};

/// <summary>
///  Struct for Option Instrument Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionInstrumentDefinitionMessage {
    public fixed byte InstrHeader[0];
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long SmallTick;
    public fixed sbyte CfiCode[8];
    public long LargeTick;
    public long LargeTickThreshold;
    public long StrikePrice;
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public long PriorSettlementPrice;
    public long SettlementPrice;
    public int ProductId;
    public int UnderlyingInstrumentId;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
    public fixed byte DefinitionFlags[0];
};

/// <summary>
///  Struct for Order Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeleteMessage {
    public fixed byte InstrHeader[0];
    public long OrderId;
};

/// <summary>
///  Struct for Order Put Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPutMessage {
    public fixed byte InstrHeader[0];
    public long OrderId;
    public long Price;
    public int Quantity;
};

/// <summary>
///  Struct for Order Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderSnapshotMessage {
    public ushort SnapshotSeqNum;
    public int Quantity;
    public long TransactTime;
    public long OrderId;
    public long Price;
};

/// <summary>
///  Struct for Outright Instrument Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OutrightInstrumentDefinitionMessage {
    public fixed byte InstrHeader[0];
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long PriceIncrement;
    public fixed sbyte CfiCode[8];
    public fixed sbyte Currency[8];
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public int ContractSize;
    public long PriorSettlementPrice;
    public long SettlementPrice;
    public long LimitDownPrice;
    public long LimitUpPrice;
    public int ProductId;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
    public fixed byte DefinitionFlags[0];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte PacketHeader[0];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public long SendingTime;
    public long SeqNum;
    public ushort ChannelId;
    public byte PacketFlags;
    public byte MessageCount;
    public int SnapshotInstrumentId;
};

/// <summary>
///  Struct for Retransmit Reject Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitRejectMessage {
    public long RetryDelayNanos;
    public fixed sbyte Details[40];
    public Reason Reason;
};

/// <summary>
///  Struct for Retransmit Request Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RetransmitRequestMessage {
    public long BeginSeqNum;
    public byte MessageCount;
};

/// <summary>
///  Struct for Spread Instrument Definition Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpreadInstrumentDefinitionMessage {
    public fixed byte InstrHeader[0];
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long PriceIncrement;
    public fixed sbyte CfiCode[8];
    public fixed sbyte Currency[8];
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public int ContractSize;
    public long PriorSettlementPrice;
    public long SettlementPrice;
    public long LimitDownPrice;
    public long LimitUpPrice;
    public int ProductId;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
    public int Leg1InstrumentId;
    public int Leg2InstrumentId;
    public SpreadBuyConvention SpreadBuyConvention;
    public fixed byte DefinitionFlags[0];
};

/// <summary>
///  Struct for Spread Trade Amend Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpreadTradeAmendMessage {
    public fixed byte InstrHeader[0];
    public long MatchId;
    public long BuyOrderId;
    public long SellOrderId;
    public long OldPrice;
    public long NewPrice;
    public long OldLeg1Price;
    public long NewLeg1Price;
    public long OldLeg2Price;
    public long NewLeg2Price;
};

/// <summary>
///  Struct for Start Of Option Instrument Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfOptionInstrumentSnapshotMessage {
    public ushort SnapshotSeqNum;
    public uint LastInstrSeqNum;
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long SmallTick;
    public fixed sbyte CfiCode[8];
    public long LargeTick;
    public long LargeTickThreshold;
    public long StrikePrice;
    public int ProductId;
    public int UnderlyingInstrumentId;
    public int OrderCount;
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public ushort TradingSessionDate;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
    public fixed byte DefinitionFlags[0];
};

/// <summary>
///  Struct for Start Of Outright Instrument Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfOutrightInstrumentSnapshotMessage {
    public ushort SnapshotSeqNum;
    public uint LastInstrSeqNum;
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long PriceIncrement;
    public fixed sbyte CfiCode[8];
    public fixed sbyte Currency[8];
    public int ProductId;
    public int ContractSize;
    public int OrderCount;
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public ushort TradingSessionDate;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
};

/// <summary>
///  Struct for Start Of Spread Instrument Snapshot Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StartOfSpreadInstrumentSnapshotMessage {
    public ushort SnapshotSeqNum;
    public uint LastInstrSeqNum;
    public fixed sbyte Symbol[24];
    public fixed sbyte ProductCode[8];
    public fixed sbyte Description[32];
    public long PriceIncrement;
    public fixed sbyte CfiCode[8];
    public fixed sbyte Currency[8];
    public int ProductId;
    public int ContractSize;
    public int OrderCount;
    public ushort FirstTradingSessionDate;
    public ushort LastTradingSessionDate;
    public ushort TradingSessionDate;
    public ProductGroup ProductGroup;
    public TradingStatus TradingStatus;
    public int Leg1InstrumentId;
    public int Leg2InstrumentId;
    public SpreadBuyConvention SpreadBuyConvention;
};

/// <summary>
///  Struct for Trade Amend Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeAmendMessage {
    public fixed byte InstrHeader[0];
    public long MatchId;
    public long BuyOrderId;
    public long SellOrderId;
    public long OldPrice;
    public long NewPrice;
};

/// <summary>
///  Struct for Trade Bust Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeBustMessage {
    public fixed byte InstrHeader[0];
    public long MatchId;
    public long BuyOrderId;
    public long SellOrderId;
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public fixed byte InstrHeader[0];
    public long MatchId;
    public long BuyOrderId;
    public long SellOrderId;
    public long Price;
    public int Quantity;
};

/// <summary>
///  Struct for Trade Session Volume Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeSessionVolumeMessage {
    public fixed byte InstrHeader[0];
    public long VwapPrice;
    public int TradeVolume;
};

/// <summary>
///  Struct for Trade Summary Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeSummaryMessage {
    public fixed byte InstrHeader[0];
    public long AggressorOrderId;
    public long AggressorReceiveTime;
    public long VwapPrice;
    public long DeepestPrice;
    public int Quantity;
};

/// <summary>
///  Struct for Trading Status Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradingStatusUpdateMessage {
    public fixed byte InstrHeader[0];
    public long LimitDownPrice;
    public long LimitUpPrice;
    public TradingStatus TradingStatus;
};

