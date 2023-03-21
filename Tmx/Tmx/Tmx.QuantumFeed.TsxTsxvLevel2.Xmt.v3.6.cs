// C# Structs For Tmx QuantumFeed Xmt TsxTsxvLevel2 3.6 protocol

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

/// <summary>
///  Bypass Values
/// </summary>
public enum Bypass : byte {
    TheOrderIsABypass = (byte)'Y',
    TheOrderIsNotABypass = (byte)'N',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    Internal = (byte)'I',
    Basis = (byte)'B',
    Contingent = (byte)'C',
    DerivativeRelated = (byte)'D',
    Regular = (byte)'R',
    VSpecialTradingSession = (byte)'S',
    VolumeWeightedAveragePrice = (byte)'V',
    DefaultTradeWasNotACross = (byte)' ',
};

/// <summary>
///  Currency Values
/// </summary>
public enum Currency : byte {
    Usd = (byte)'U',
    Cad = (byte)'C',
};

/// <summary>
///  Imbalance Side Values
/// </summary>
public enum ImbalanceSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalanceExists = (byte)' ',
};

/// <summary>
///  Initiated By Values
/// </summary>
public enum InitiatedBy : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    Both = (byte)'C',
};

/// <summary>
///  Is Conditional Values
/// </summary>
public enum IsConditional : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Dark Values
/// </summary>
public enum IsDark : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Is Mid Only Values
/// </summary>
public enum IsMidOnly : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Listing Market Values
/// </summary>
public enum ListingMarket : byte {
    Tsx = (byte)'T',
    TsxVenture = (byte)'V',
    TsxNaVex = (byte)'N',
    Nasdaq = (byte)'Q',
    Nyse = (byte)'S',
    NyseMkt = (byte)'M',
    NNoMarket = (byte)'X',
};

/// <summary>
///  Market Order Imbalance Side Values
/// </summary>
public enum MarketOrderImbalanceSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalanceExists = (byte)' ',
};

/// <summary>
///  Market State Values
/// </summary>
public enum MarketState : byte {
    Preopen = (byte)'P',
    Opening = (byte)'O',
    Open = (byte)'S',
    MocImbalance = (byte)'M',
    MocFreeze = (byte)'T',
    CcpDetermination = (byte)'A',
    PriceMovementExtension = (byte)'E',
    Closing = (byte)'L',
    ExtendedHoursCxls = (byte)'N',
    ExtendedHoursOpen = (byte)'R',
    Closed = (byte)'C',
    NavExClosed = (byte)'J',
    NavExOrderEntry = (byte)'G',
    NavExOrderEntryClose = (byte)'H',
    NavExAmExecution = (byte)'K',
    NavExPmExecution = (byte)'X',
    NavExClose = (byte)'Y',
};

/// <summary>
///  Moc Eligible Values
/// </summary>
public enum MocEligible : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Msg Type Values
/// </summary>
public enum MsgType : byte {
    SymbolStatusMessage = (byte)'J',
    OrderBookMessage = (byte)'G',
    OrderBookTermsMessage = (byte)'j',
    AssignCopOrdersMessage = (byte)'A',
    AssignCopNoOrdersMessage = (byte)'B',
    AssignLimitMessage = (byte)'C',
    MarketStateUpdateMessage = (byte)'E',
    MocImbalanceMessage = (byte)'F',
    OrderBookedMessage = (byte)'P',
    OrderBookedTermsMessage = (byte)'m',
    OrderCancelledMessage = (byte)'Q',
    OrderCancelledTermsMessage = (byte)'n',
    OrderPriceTimeAssignedMessage = (byte)'R',
    OrderPriceTimeAssignedTermsMessage = (byte)'o',
    StockStatusMessage = (byte)'I',
    TradeReportMessage = (byte)'S',
    TradeReportTermsMessage = (byte)'P',
    TradeCancelledMessage = (byte)'T',
    TradeCancelledTermsMessage = (byte)'q',
    TradeCorrectionMessage = (byte)'U',
    TradeCorrectionTermsMessage = (byte)'r',
};

/// <summary>
///  Non Resident Values
/// </summary>
public enum NonResident : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Order Side Values
/// </summary>
public enum OrderSide : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Product Type Values
/// </summary>
public enum ProductType : byte {
    Debenture = (byte)'B',
    Equity = (byte)'E',
    MutualFund = (byte)'M',
    Etf = (byte)'F',
    UsEquity = (byte)'U',
    Bond = (byte)'O',
};

/// <summary>
///  Settlement Terms Values
/// </summary>
public enum SettlementTerms : byte {
    Cash = (byte)'C',
    Nn = (byte)'N',
    Ms = (byte)'M',
    Ct = (byte)'T',
    ValidSettlementDate = (byte)'D',
    NoSettlementTerms = (byte)' ',
};

/// <summary>
///  Test Symbol Values
/// </summary>
public enum TestSymbol : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Assign Cop No Orders Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignCopNoOrdersBody {
    public fixed sbyte Symbol[12];
    public ulong CalculatedOpeningPrice;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Assign Cop No Orders Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignCopNoOrdersMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte AssignCopNoOrdersBody[0];
};

/// <summary>
///  Struct for Assign Cop Orders Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignCopOrdersBody {
    public fixed sbyte Symbol[12];
    public ulong CalculatedOpeningPrice;
    public OrderSide OrderSide;
    public fixed byte CopOrder1[0];
    public fixed byte CopOrder2[0];
    public fixed byte CopOrder3[0];
    public fixed byte CopOrder4[0];
    public fixed byte CopOrder5[0];
    public fixed byte CopOrder6[0];
    public fixed byte CopOrder7[0];
    public fixed byte CopOrder8[0];
    public fixed byte CopOrder9[0];
    public fixed byte CopOrder10[0];
    public fixed byte CopOrder11[0];
    public fixed byte CopOrder12[0];
    public fixed byte CopOrder13[0];
    public fixed byte CopOrder14[0];
    public fixed byte CopOrder15[0];
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Assign Cop Orders Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignCopOrdersMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte AssignCopOrdersBody[0];
};

/// <summary>
///  Struct for Assign Limit Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignLimitBody {
    public fixed sbyte Symbol[12];
    public ulong CalculatedOpeningPrice;
    public OrderSide OrderSide;
    public fixed byte CopLimit1[0];
    public fixed byte CopLimit2[0];
    public fixed byte CopLimit3[0];
    public fixed byte CopLimit4[0];
    public fixed byte CopLimit5[0];
    public fixed byte CopLimit6[0];
    public fixed byte CopLimit7[0];
    public fixed byte CopLimit8[0];
    public fixed byte CopLimit9[0];
    public fixed byte CopLimit10[0];
    public fixed byte CopLimit11[0];
    public fixed byte CopLimit12[0];
    public fixed byte CopLimit13[0];
    public fixed byte CopLimit14[0];
    public fixed byte CopLimit15[0];
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Assign Limit Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AssignLimitMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte AssignLimitBody[0];
};

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
    public MsgType MsgType;
};

/// <summary>
///  Struct for Business Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BusinessHeader {
    public byte MsgVersion;
    public fixed sbyte SourceId[1];
    public ushort StreamId;
    public byte Sequence0;
    public uint Sequence1;
};

/// <summary>
///  Struct for Cop Limit 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit1 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit10 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit11 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit12 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit13 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit14 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit15 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit2 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit3 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit4 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit5 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit6 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit7 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit8 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Limit 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopLimit9 {
    public ushort BrokerNumber;
    public ulong OrderId;
    public ulong Price;
};

/// <summary>
///  Struct for Cop Order 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder1 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder10 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder11 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder12 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder13 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder14 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder15 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder2 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder3 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder4 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder5 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder6 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder7 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder8 {
    public ushort BrokerNumber;
    public ulong OrderId;
};

/// <summary>
///  Struct for Cop Order 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CopOrder9 {
    public ushort BrokerNumber;
    public ulong OrderId;
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
///  Struct for Market State Update Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStateUpdateBody {
    public MarketState MarketState;
    public byte StockGroup;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Market State Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketStateUpdateMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte MarketStateUpdateBody[0];
};

/// <summary>
///  Struct for Moc Imbalance Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MocImbalanceBody {
    public fixed sbyte Symbol[12];
    public ImbalanceSide ImbalanceSide;
    public uint ImbalanceVolume;
    public ulong TradingSystemTimeStamp;
    public ulong ImbalanceReferencePrice;
    public uint PairedVolume;
    public uint MarketOrderImbalanceVolume;
    public MarketOrderImbalanceSide MarketOrderImbalanceSide;
    public ulong NearIndicativeClosingPrice;
    public ulong FarIndicativeClosingPrice;
};

/// <summary>
///  Struct for Moc Imbalance Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MocImbalanceMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte MocImbalanceBody[0];
};

/// <summary>
///  Struct for Order Book Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public NonResident NonResident;
    public SettlementTerms SettlementTerms;
    public uint SettlementDate;
    public ulong PriorityTimeStamp;
};

/// <summary>
///  Struct for Order Book Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderBookBody[0];
};

/// <summary>
///  Struct for Order Book Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookTermsBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public NonResident NonResident;
    public SettlementTerms SettlementTerms;
    public uint SettlementDate;
    public ulong PriorityTimeStamp;
};

/// <summary>
///  Struct for Order Book Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderBookTermsBody[0];
};

/// <summary>
///  Struct for Order Booked Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookedBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public ulong PriorityTimeStamp;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Booked Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookedMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderBookedBody[0];
};

/// <summary>
///  Struct for Order Booked Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookedTermsBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public NonResident NonResident;
    public SettlementTerms SettlementTerms;
    public uint SettlementDate;
    public ulong PriorityTimeStamp;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Booked Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookedTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderBookedTermsBody[0];
};

/// <summary>
///  Struct for Order Cancelled Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderCancelledBody[0];
};

/// <summary>
///  Struct for Order Cancelled Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledTermsBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Cancelled Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderCancelledTermsBody[0];
};

/// <summary>
///  Struct for Order Price Time Assigned Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriceTimeAssignedBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public ulong PriorityTimeStamp;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Price Time Assigned Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriceTimeAssignedMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderPriceTimeAssignedBody[0];
};

/// <summary>
///  Struct for Order Price Time Assigned Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriceTimeAssignedTermsBody {
    public fixed sbyte Symbol[12];
    public ushort BrokerNumber;
    public OrderSide OrderSide;
    public ulong OrderId;
    public ulong Price;
    public uint Volume;
    public ulong PriorityTimeStamp;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Order Price Time Assigned Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderPriceTimeAssignedTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte OrderPriceTimeAssignedTermsBody[0];
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte FrameHeader[0];
};

/// <summary>
///  Struct for Stock Status Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockStatusBody {
    public fixed sbyte Symbol[12];
    public fixed sbyte Comment[40];
    public fixed sbyte StockState[2];
    public ulong TradingSystemTimeStamp;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
};

/// <summary>
///  Struct for Stock Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockStatusMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte StockStatusBody[0];
};

/// <summary>
///  Struct for Symbol Status Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolStatusBody {
    public fixed sbyte Symbol[12];
    public byte StockGroup;
    public fixed sbyte Cusip[12];
    public ushort BoardLot;
    public Currency Currency;
    public ulong FaceValue;
    public ulong LastSale;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
    public uint BuyMaximumQuantity;
    public uint BuyMinimumQuantity;
    public uint SellMaximumQuantity;
    public uint SellMinimumQuantity;
    public fixed sbyte StockState[2];
    public TestSymbol TestSymbol;
    public MocEligible MocEligible;
};

/// <summary>
///  Struct for Symbol Status Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SymbolStatusMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte SymbolStatusBody[0];
};

/// <summary>
///  Struct for Trade Cancelled Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong TradingSystemTimeStamp;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
    public uint TradeDate;
};

/// <summary>
///  Struct for Trade Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeCancelledBody[0];
};

/// <summary>
///  Struct for Trade Cancelled Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledTermsBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Trade Cancelled Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelledTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeCancelledTermsBody[0];
};

/// <summary>
///  Struct for Trade Correction Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong Price;
    public uint Volume;
    public ushort BuyBrokerNumber;
    public ushort SellBrokerNumber;
    public InitiatedBy InitiatedBy;
    public uint OrigTradeNumber;
    public Bypass Bypass;
    public uint TradeTimeStamp;
    public CrossType CrossType;
    public ulong TradingSystemTimeStamp;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
    public uint TradeDate;
    public IsMidOnly IsMidOnly;
    public IsDark IsDark;
    public IsConditional IsConditional;
};

/// <summary>
///  Struct for Trade Correction Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeCorrectionBody[0];
};

/// <summary>
///  Struct for Trade Correction Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionTermsBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong Price;
    public uint Volume;
    public ushort BuyBrokerNumber;
    public ushort SellBrokerNumber;
    public InitiatedBy InitiatedBy;
    public uint OrigTradeNumber;
    public uint TradeTimeStamp;
    public NonResident NonResident;
    public SettlementTerms SettlementTerms;
    public uint SettlementDate;
    public CrossType CrossType;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Trade Correction Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCorrectionTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeCorrectionTermsBody[0];
};

/// <summary>
///  Struct for Trade Report Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong Price;
    public uint Volume;
    public ushort BuyBrokerNumber;
    public ulong BuyOrderId;
    public uint BuyDisplayVolume;
    public ushort SellBrokerNumber;
    public ulong SellOrderId;
    public uint SellDisplayVolume;
    public Bypass Bypass;
    public uint TradeTimeStamp;
    public CrossType CrossType;
    public ulong TradingSystemTimeStamp;
    public ListingMarket ListingMarket;
    public ProductType ProductType;
    public uint TradeDate;
    public IsMidOnly IsMidOnly;
    public IsDark IsDark;
    public IsConditional IsConditional;
};

/// <summary>
///  Struct for Trade Report Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeReportBody[0];
};

/// <summary>
///  Struct for Trade Report Terms Body
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportTermsBody {
    public fixed sbyte Symbol[12];
    public uint TradeNumber;
    public ulong Price;
    public uint Volume;
    public ushort BuyBrokerNumber;
    public ulong BuyOrderId;
    public uint BuyDisplayVolume;
    public ushort SellBrokerNumber;
    public ulong SellOrderId;
    public uint SellDisplayVolume;
    public uint TradeTimeStamp;
    public NonResident NonResident;
    public SettlementTerms SettlementTerms;
    public uint SettlementDate;
    public CrossType CrossType;
    public ulong TradingSystemTimeStamp;
};

/// <summary>
///  Struct for Trade Report Terms Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeReportTermsMessage {
    public fixed byte BusinessHeader[0];
    public fixed byte TradeReportTermsBody[0];
};

