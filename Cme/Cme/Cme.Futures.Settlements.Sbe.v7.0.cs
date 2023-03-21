// C# Structs For Cme Futures Sbe Settlements 7.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  High Px Ind Values
/// </summary>
public enum HighPxInd : byte {
    Ask = (byte)'A',
    Bid = (byte)'B',
    Trade = (byte)'T',
};

/// <summary>
///  Low Px Ind Values
/// </summary>
public enum LowPxInd : byte {
    Ask = (byte)'A',
    Bid = (byte)'B',
    Trade = (byte)'T',
};

/// <summary>
///  Md Update Action Values
/// </summary>
public enum MdUpdateAction : byte {
    New = 0,
    Change = 1,
    Delete = 2,
};

/// <summary>
///  Open Close Settl Flag Values
/// </summary>
public enum OpenCloseSettlFlag : byte {
    Estimated = 3,
    ActualAdjusted = 4,
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    NoValue = 255,
    Put = 0,
    Call = 1,
};

/// <summary>
///  Template Id Values
/// </summary>
public enum TemplateId : ushort {
    MdIncrementalRefreshSettle = 401,
    MdIncrementalRefreshVoi = 402,
    MdIncrementalRefreshHighLow = 403,
    AdminHeartbeat = 407,
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
///  Struct for Formatted Last Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FormattedLastPx {
    public long Mantissa;
    public sbyte Exponent;
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
///  Struct for High Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct HighPx {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Low Px
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LowPx {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for M D Incremental Refresh High Low Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshHighLowGroup {
    public ulong ProductGuid;
    public fixed sbyte ClearingProductCode[12];
    public fixed sbyte SecurityType[6];
    public fixed sbyte SecurityExchange[8];
    public fixed byte MaturityMonthYear[0];
    public PutOrCall PutOrCall;
    public fixed byte StrikePrice[0];
    public ulong UnderlyingProductGuid;
    public fixed sbyte UnderlyingClearingProductCode[12];
    public fixed sbyte UnderlyingSecurityType[6];
    public fixed sbyte UnderlyingSecurityExchange[8];
    public fixed byte UnderlyingMaturityMonthYear[0];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public uint SecurityId;
    public fixed byte LowPx[0];
    public LowPxInd LowPxInd;
    public fixed byte HighPx[0];
    public HighPxInd HighPxInd;
    public ushort TradingReferenceDate;
};

/// <summary>
///  Struct for M D Incremental Refresh High Low Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshHighLowGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Settle Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSettleGroup {
    public MdUpdateAction MdUpdateAction;
    public fixed sbyte MdEntryType[1];
    public ulong ProductGuid;
    public fixed sbyte ClearingProductCode[12];
    public fixed sbyte SecurityType[6];
    public fixed sbyte SecurityExchange[8];
    public fixed byte MaturityMonthYear[0];
    public PutOrCall PutOrCall;
    public fixed byte StrikePrice[0];
    public ulong UnderlyingProductGuid;
    public fixed sbyte UnderlyingClearingProductCode[12];
    public fixed sbyte UnderlyingSecurityType[6];
    public fixed sbyte UnderlyingSecurityExchange[8];
    public fixed byte UnderlyingMaturityMonthYear[0];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public uint SecurityId;
    public fixed byte FormattedLastPx[0];
    public long MdEntryPx;
    public fixed byte SettlPriceType[0];
    public ushort TradingReferenceDate;
    public fixed sbyte MdStatisticDesc[40];
};

/// <summary>
///  Struct for M D Incremental Refresh Settle Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshSettleGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for M D Incremental Refresh Voi Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshVoiGroup {
    public ulong ProductGuid;
    public fixed sbyte ClearingProductCode[12];
    public fixed sbyte SecurityType[6];
    public fixed sbyte SecurityExchange[8];
    public fixed byte MaturityMonthYear[0];
    public PutOrCall PutOrCall;
    public fixed byte StrikePrice[0];
    public ulong UnderlyingProductGuid;
    public fixed sbyte UnderlyingClearingProductCode[12];
    public fixed sbyte UnderlyingSecurityType[6];
    public fixed sbyte UnderlyingSecurityExchange[8];
    public fixed byte UnderlyingMaturityMonthYear[0];
    public fixed sbyte Symbol[20];
    public ulong InstrumentGuid;
    public uint SecurityId;
    public uint ClearedVolume;
    public uint OpenInterestQty;
    public OpenCloseSettlFlag OpenCloseSettlFlag;
    public ushort TradingReferenceDate;
};

/// <summary>
///  Struct for M D Incremental Refresh Voi Groups
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MDIncrementalRefreshVoiGroups {
    public fixed byte GroupSize[0];
};

/// <summary>
///  Struct for Maturity Month Year
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MaturityMonthYear {
    public ushort Year;
    public byte Month;
    public byte Day;
    public byte Week;
};

/// <summary>
///  Struct for Md Incremental Refresh High Low
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshHighLow {
    public ulong TransactTime;
};

/// <summary>
///  Struct for Md Incremental Refresh Settle
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshSettle {
    public ulong TransactTime;
};

/// <summary>
///  Struct for Md Incremental Refresh Voi
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MdIncrementalRefreshVoi {
    public ulong TransactTime;
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

/// <summary>
///  Struct for Settl Price Type
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SettlPriceType {
    public fixed byte NullValue[1];
    public fixed byte ReservedBits[2];
    public fixed byte Cabinet[1];
    public fixed byte Intraday[1];
    public fixed byte Rounded[1];
    public fixed byte Actual[1];
    public fixed byte FinalDaily[1];
};

/// <summary>
///  Struct for Strike Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StrikePrice {
    public long Mantissa;
    public sbyte Exponent;
};

/// <summary>
///  Struct for Underlying Maturity Month Year
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnderlyingMaturityMonthYear {
    public ushort Year;
    public byte Month;
    public byte Day;
    public byte Week;
};

