// C# Structs For Miax Pearl Equities Mach DepthOfMarket 1.3.a protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Market State Values
/// </summary>
public enum MarketState : byte {
    PreOpening = 1,
    EarlyTrading = 2,
    RegularTrading = 3,
    AfterHoursTrading = 4,
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemTimeMessage = (byte)'49',
    SymbolUpdateMessage = (byte)'1',
    SystemStateMessage = (byte)'83',
    SecurityTradingStatusNotificationMessage = (byte)'4',
    SymbolClearMessage = (byte)'5',
    AddOrderMessage = (byte)'20',
    ModifyOrderMessage = (byte)'21',
    DeleteOrderMessage = (byte)'23',
    OrderExecutionMessage = (byte)'24',
    TradeMessage = (byte)'10',
    TradeCancelMessage = (byte)'11',
};

/// <summary>
///  Order Side Values
/// </summary>
public enum OrderSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
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
///  Primary Market Code Values
/// </summary>
public enum PrimaryMarketCode : byte {
    NyseAmerican = (byte)'A',
    NasdaqBx = (byte)'B',
    NyseNational = (byte)'C',
    MiaxPearlEquities = (byte)'H',
    NasdaqIse = (byte)'I',
    CboeEdgaExchange = (byte)'J',
    CboeEdgxExchange = (byte)'K',
    LongTermStockExchange = (byte)'L',
    NyseChicago = (byte)'M',
    NewYorkStockExchange = (byte)'N',
    NyseArca = (byte)'P',
    Nasdaq = (byte)'Q',
    MembersExchange = (byte)'U',
    InvestorsExchange = (byte)'V',
    CboeStockExchange = (byte)'W',
    NasdaqPhlx = (byte)'X',
    CboeByxExchange = (byte)'Y',
    CboeBzxExchange = (byte)'Z',
};

/// <summary>
///  Short Sale Restriction Values
/// </summary>
public enum ShortSaleRestriction : byte {
    SsrInEffect = (byte)'Y',
    SsrNotInEffect = (byte)'N',
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

/// <summary>
///  Test Security Indicator Values
/// </summary>
public enum TestSecurityIndicator : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    PreOpen = 1,
    Trading = 2,
    Halt = 3,
    OperationalHalt = 4,
    Closed = 5,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong OrderId;
    public OrderSide OrderSide;
    public ulong Price;
    public uint Size;
    public fixed sbyte AttributableId[4];
};

/// <summary>
///  Struct for Application Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApplicationMessage {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Delete Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct DeleteOrderMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong OrderId;
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
///  Struct for Modify Order Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderFlags {
    public fixed byte Undefined[7];
    public fixed byte OrderPosition[1];
};

/// <summary>
///  Struct for Modify Order Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong OrderId;
    public ulong Price;
    public uint Size;
    public fixed byte ModifyOrderFlags[0];
};

/// <summary>
///  Struct for Order Execution Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionFlags {
    public fixed byte Undefined[7];
    public fixed byte Reportable[1];
};

/// <summary>
///  Struct for Order Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong OrderId;
    public ulong TradeId;
    public ulong Price;
    public uint Size;
    public fixed byte OrderExecutionFlags[0];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
};

/// <summary>
///  Struct for Security Trading Status Notification Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SecurityTradingStatusNotificationMessage {
    public uint Timestamp;
    public uint SymbolId;
    public TradingStatus TradingStatus;
    public MarketState MarketState;
    public ShortSaleRestriction ShortSaleRestriction;
};

/// <summary>
///  Struct for Symbol Clear Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolClearMessage {
    public uint Timestamp;
    public uint SymbolId;
};

/// <summary>
///  Struct for Symbol Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolUpdateMessage {
    public uint Timestamp;
    public uint SymbolId;
    public fixed sbyte TickerSymbol[11];
    public byte Reserved;
    public TestSecurityIndicator TestSecurityIndicator;
    public byte Reserved;
    public ushort LotSize;
    public fixed sbyte OpeningTime[8];
    public fixed sbyte ClosingTime[8];
    public PrimaryMarketCode PrimaryMarketCode;
};

/// <summary>
///  Struct for System State Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemStateMessage {
    public uint Timestamp;
    public fixed sbyte DoMVersion[8];
    public byte SessionId;
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
    public uint SymbolId;
    public ulong TradeId;
    public byte CorrectionNumber;
    public ulong Price;
    public uint Size;
};

/// <summary>
///  Struct for Trade Flags
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeFlags {
    public fixed byte Undefined[7];
    public fixed byte Reportable[1];
};

/// <summary>
///  Struct for Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong TradeId;
    public byte CorrectionNumber;
    public ulong Price;
    public uint Size;
    public fixed byte TradeFlags[0];
};

