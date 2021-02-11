// C# Structs For Miax Options Mach TopOfMarket 2.2 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Packet Type Values
/// </summary>
public enum PacketType : byte {
    Heartbeat = 0,
    StartOfSession = 1,
    EndOfSession = 2,
    ApplicationMessage = 3,
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Application Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ApplicationMessage {
    public fixed sbyte MessageType[1];
    public fixed byte Data[0];
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

