// C# Structs For Cme Futures Sbe Derived 12.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Aggressor Side Values
/// </summary>
public enum AggressorSide : byte {
    NoValue = 255,
    Buy = 1,
    Sell = 2,
};

/// <summary>
///  Md Entry Type Spectrum Entry Type Values
/// </summary>
public enum MdEntryTypeSpectrumEntryType : byte {
    Vwap = (byte)'9',
    Twap = (byte)'t',
};

/// <summary>
///  Md Entry Type Ticker Entry Type Values
/// </summary>
public enum MdEntryTypeTickerEntryType : byte {
    TouchHigh = (byte)'k',
    TouchLow = (byte)'l',
    OpenBestBid = (byte)'m',
    OpenBestOffer = (byte)'n',
    CloseBestBid = (byte)'o',
    CloseBestOffer = (byte)'p',
    MarketHigh = (byte)'q',
    MarketLow = (byte)'r',
    MarketBestOffer = (byte)'w',
    MarketBestBid = (byte)'x',
    Paid = (byte)'y',
    Given = (byte)'z',
};

/// <summary>
///  Open Close Settl Flag Values
/// </summary>
public enum OpenCloseSettlFlag : byte {
    CurrentDay = 0,
    PreviousDay = 4,
};

/// <summary>
///  Security Trading Event Values
/// </summary>
public enum SecurityTradingEvent : byte {
    GlobalDayRoll = 4,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    AdminHeartbeat = 302,
    MdIncrementalRefreshSpectrum = 303,
    MdIncrementalRefreshTicker = 304,
    MdSnapshotRefreshSpectrum = 305,
    MdSnapshotRefreshTicker = 306,
    GlobalDayRoll = 307,
};

/// <summary>
///  Trading Session Id Values
/// </summary>
public enum TradingSessionId : byte {
    NoValue = 255,
    Gl = 0,
    Sy = 1,
    Tk = 2,
    Hk = 3,
    Ln = 4,
    Ny = 5,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Binary Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BinaryPacketHeader {
    public uint MessageSequenceNumber;
    public ulong SendingTime;
};

/// <summary>
///  Struct for Global Day Roll
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GlobalDayRoll {
    public ulong TransactTime;
    public SecurityTradingEvent SecurityTradingEvent;
};

/// <summary>
///  Struct for Group Size
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct GroupSize {
    public ushort BlockLength;
    public byte NumInGroupUint8;
};

/// <summary>
///  Struct for M D Incremental Refresh Spectrum Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSpectrumGroup {
    public MdEntryTypeSpectrumEntryType MdEntryTypeSpectrumEntryType;
    public fixed sbyte FinancialInstrumentFullName[35];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public int SecurityId;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public ulong MdEntryTime;
};

/// <summary>
///  Struct for M D Incremental Refresh Spectrum Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSpectrumGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Ticker Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTickerGroup {
    public MdEntryTypeTickerEntryType MdEntryTypeTickerEntryType;
    public int SecurityId;
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public fixed sbyte FinancialInstrumentFullName[35];
    public long MdEntryPx;
    public ulong MdEntrySize;
    public ulong MdEntryTime;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public TradingSessionId TradingSessionId;
    public AggressorSide AggressorSide;
};

/// <summary>
///  Struct for M D Incremental Refresh Ticker Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshTickerGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Snapshot Refresh Spectrum Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDSnapshotRefreshSpectrumGroup {
    public MdEntryTypeSpectrumEntryType MdEntryTypeSpectrumEntryType;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public ulong MdEntryTime;
};

/// <summary>
///  Struct for M D Snapshot Refresh Spectrum Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDSnapshotRefreshSpectrumGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Snapshot Refresh Ticker Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDSnapshotRefreshTickerGroup {
    public MdEntryTypeTickerEntryType MdEntryTypeTickerEntryType;
    public long MdEntryPx;
    public ulong MdEntrySize;
    public ulong MdEntryTime;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public TradingSessionId TradingSessionId;
    public AggressorSide AggressorSide;
};

/// <summary>
///  Struct for M D Snapshot Refresh Ticker Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDSnapshotRefreshTickerGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Spectrum
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSpectrum {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
};

/// <summary>
///  Struct for Md Incremental Refresh Ticker
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshTicker {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
};

/// <summary>
///  Struct for Md Snapshot Refresh Spectrum
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdSnapshotRefreshSpectrum {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed sbyte FinancialInstrumentFullName[35];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public int SecurityId;
};

/// <summary>
///  Struct for Md Snapshot Refresh Ticker
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdSnapshotRefreshTicker {
    public ulong TransactTime;
    public fixed byte MatchEventIndicator[0];
    public fixed sbyte FinancialInstrumentFullName[35];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public int SecurityId;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public ushort MessageSize;
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
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte BinaryPacketHeader[0];
};

