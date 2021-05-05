// C# Structs For Iex Equities IexTp UdpHeader 1.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Iex Tp Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct IexTpHeader {
    public byte Version;
    public fixed byte Reserved[1];
    public ushort MessageProtocolId;
    public uint ChannelId;
    public uint SessionId;
    public ushort PayloadLength;
    public ushort MessageCount;
    public ulong StreamOffset;
    public ulong FirstMessageSequenceNumber;
    public ulong SendTime;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort MessageLength;
    public fixed sbyte MessageType[1];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte IexTpHeader[0];
};

