// C# Structs For Miax Pearl Equities Mach TopOfMarket 1.1.a protocol

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
    CompactTopOfMarketBestBidAndOfferMessage = (byte)'2',
    WideTopOfMarketBestBidAndOfferMessage = (byte)'3',
    LastSaleMessage = (byte)'10',
    TradeCancelMessage = (byte)'11',
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
///  Struct for Application Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApplicationMessage {
    public MessageType MessageType;
};

/// <summary>
///  Struct for Compact Top Of Market Best Bid And Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CompactTopOfMarketBestBidAndOfferMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort OfferPrice;
    public ushort OfferSize;
};

/// <summary>
///  Struct for Last Sale Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LastSaleMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ulong TradeId;
    public byte CorrectionNumber;
    public ulong Price;
    public uint Size;
    public fixed byte Flags[0];
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
    public fixed sbyte ToMVersion[8];
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
///  Struct for Wide Top Of Market Best Bid And Offer Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct WideTopOfMarketBestBidAndOfferMessage {
    public uint Timestamp;
    public uint SymbolId;
    public ushort BidPrice;
    public ushort BidSize;
    public ushort OfferPrice;
    public ushort OfferSize;
};

