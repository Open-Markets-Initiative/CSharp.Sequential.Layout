// C# Structs For Tmx QuantumFeed Xmt UdpHeader 1.1 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Ack Required Poss Dup Values
/// </summary>
public enum AckRequiredPossDup : byte {
    ReceiverNeedsToAck = (byte)'A',
    PossibleDuplicates = (byte)'D',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Body {
    public fixed byte BodyHeader[0];
};

/// <summary>
///  Struct for Body Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BodyHeader {
    public ushort MsgLength;
    public fixed sbyte MsgType[1];
};

/// <summary>
///  Struct for Frame Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FrameHeader {
    public fixed byte StartOfFrame;
    public fixed sbyte ProtocolName[1];
    public fixed sbyte ProtocolVersion[1];
    public ushort MessageLength;
    public uint SessionId;
    public AckRequiredPossDup AckRequiredPossDup;
    public byte NumBody;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte FrameHeader[0];
};

