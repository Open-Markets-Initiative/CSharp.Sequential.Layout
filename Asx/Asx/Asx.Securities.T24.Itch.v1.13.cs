// C# Structs For Asx Securities Itch T24 1.13 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Activated Values
/// </summary>
public enum Activated : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Contract Type Values
/// </summary>
public enum ContractType : byte {
    Cfut = (byte)'F',
    Copta = (byte)'O',
    Eopta = (byte)'E',
    Oopt = (byte)'N',
    Csprd = (byte)'S',
    Sprd = (byte)'A',
    Sfut = (byte)'D',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    Open = (byte)'O',
    Start = (byte)'S',
    End = (byte)'C',
    Paused = (byte)'P',
    Resumed = (byte)'R',
};

/// <summary>
///  Financial Type Values
/// </summary>
public enum FinancialType : byte {
    Commodity = (byte)'C',
    Cfd = (byte)'D',
    Equity = (byte)'E',
    GovernmentBond = (byte)'X',
    BankBill = (byte)'B',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    TimeMessage = (byte)'T',
    SystemEvent = (byte)'S',
    FutureSymbolDirectory = (byte)'f',
    SpreadSymbolDirectory = (byte)'g',
    OptionSymbolDirectory = (byte)'h',
    OrderBookState = (byte)'O',
    OrderAdded = (byte)'A',
    OrderReplaced = (byte)'U',
    OrderVolumeCancelled = (byte)'X',
    OrderDeleted = (byte)'D',
    ImpliedOrderAdded = (byte)'j',
    ImpliedOrderReplaced = (byte)'l',
    ImpliedOrderDeleted = (byte)'k',
    CustomMarketOrderAdded = (byte)'m',
    CustomMarketOrderReplaced = (byte)'n',
    CustomMarketOrderDeleted = (byte)'r',
    OrderExecuted = (byte)'E',
    OrderExecutedWithPrice = (byte)'C',
    SpreadExecuted = (byte)'e',
    TradeSpreadExecutionChain = (byte)'P',
    CustomMarketExecuted = (byte)'u',
    CustomMarketTrade = (byte)'p',
    TradeCancellation = (byte)'B',
    EquilibriumPriceAuctionInfo = (byte)'Z',
    OpenHighLowLastTradeAdjustment = (byte)'t',
    MarketSettlement = (byte)'Y',
    AdHocText = (byte)'x',
    RequestForQuote = (byte)'q',
    AnomalousOrderThresholdPublish = (byte)'W',
    VolumeAndOpenInterest = (byte)'V',
};

/// <summary>
///  Option Type Values
/// </summary>
public enum OptionType : byte {
    Put = (byte)'P',
    Call = (byte)'C',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    Yes = (byte)'Y',
    No = (byte)'N',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Sell = (byte)'S',
    Buy = (byte)'B',
};

/// <summary>
///  Trade Type Values
/// </summary>
public enum TradeType : byte {
    Normal = (byte)'T',
    CrossingNormal = (byte)'t',
    Sweeping = (byte)'W',
    CrossingSweeping = (byte)'w',
    Levelling = (byte)'L',
    CrossingLevelling = (byte)'l',
    SpreadToUnderlying = (byte)'S',
    CrossingSpreadToUnderlying = (byte)'s',
    IntraSpread = (byte)'R',
    CrossingIntraSpread = (byte)'r',
    InterSpread = (byte)'Q',
    CrossingInterSpread = (byte)'q',
    Custom = (byte)'U',
    CrossingCustom = (byte)'u',
};

/// <summary>
///  Trading Status Values
/// </summary>
public enum TradingStatus : byte {
    Pending = (byte)'p',
    Halted = (byte)'H',
    PreOpen = (byte)'P',
    Closed = (byte)'C',
    Levelling = (byte)'l',
    Locked = (byte)'L',
    Opened = (byte)'O',
    Unavailable = (byte)'U',
    PrePriceDiscovery = (byte)'d',
    Inactive = (byte)'I',
    PriceDiscovery = (byte)'D',
    Activated = (byte)'A',
    RegulatoryHalt = (byte)'R',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Ad Hoc Text
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AdHocText {
    public uint Timestamp;
    public ushort TradeDate;
    public fixed sbyte SourceId[6];
    public fixed sbyte TextMessage[100];
};

/// <summary>
///  Struct for Anomalous Order Threshold Publish
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AnomalousOrderThresholdPublish {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public int AotPrice;
    public int AotUpperPrice;
    public int AotLowerPrice;
    public int EtrPrice;
    public int EtrUpperPrice;
    public int EtrLowerPrice;
};

/// <summary>
///  Struct for Custom Market Executed
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CustomMarketExecuted {
    public uint Timestamp;
    public ushort TradeDate;
    public ulong OrderNumber;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
    public uint TradedContractNumber;
    public fixed sbyte TradeSideOfLeg[1];
    public Printable Printable;
};

/// <summary>
///  Struct for Custom Market Order Added
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CustomMarketOrderAdded {
    public uint Timestamp;
    public ushort TradeDate;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
    public byte Legs;
    public uint ContractNumberLeg1;
    public fixed sbyte SideLeg1[1];
    public ushort RatioLeg1;
    public int PriceLeg1;
    public uint ContractNumberLeg2;
    public fixed sbyte SideLeg2[1];
    public ushort RatioLeg2;
    public int PriceLeg2;
    public uint ContractNumberLeg3;
    public fixed sbyte SideLeg3[1];
    public ushort RatioLeg3;
    public int PriceLeg3;
    public uint ContractNumberLeg4;
    public fixed sbyte SideLeg4[1];
    public ushort RatioLeg4;
    public int PriceLeg4;
    public uint ContractNumberLeg5;
    public fixed sbyte SideLeg5[1];
    public ushort RatioLeg5;
    public int PriceLeg5;
    public uint ContractNumberLeg6;
    public fixed sbyte SideLeg6[1];
    public ushort RatioLeg6;
    public int PriceLeg6;
};

/// <summary>
///  Struct for Custom Market Order Deleted
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CustomMarketOrderDeleted {
    public uint Timestamp;
    public ushort TradeDate;
    public ulong OrderNumber;
};

/// <summary>
///  Struct for Custom Market Order Replaced
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CustomMarketOrderReplaced {
    public uint Timestamp;
    public ushort TradeDate;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
};

/// <summary>
///  Struct for Custom Market Trade
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CustomMarketTrade {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint QuantityRemaining;
    public ulong CustomMarketOrderNumber;
    public uint CustomMarketQuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
    public uint TradedContractNumber;
    public fixed sbyte TradeSideOfNonCustomOrder[1];
    public Printable Printable;
};

/// <summary>
///  Struct for Equilibrium Price Auction Info
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct EquilibriumPriceAuctionInfo {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public int EquilibriumPrice;
    public int BestBidPrice;
    public int BestAskPrice;
    public uint BestBidQuantity;
    public uint BestAskQuantity;
};

/// <summary>
///  Struct for Future Symbol Directory
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct FutureSymbolDirectory {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public fixed sbyte Exchange[6];
    public fixed sbyte Instrument[6];
    public ContractType ContractType;
    public ushort ExpiryYear;
    public byte ExpiryMonth;
    public byte PriceDecimalPosition;
    public uint PriceFractionalDenominator;
    public ushort PriceMinimumTick;
    public uint LastTradingDate;
    public int PriorDaySettlement;
    public FinancialType FinancialType;
    public fixed sbyte Currency[3];
    public uint LotSizeOrFaceValue;
    public byte MaturityValue;
    public ushort CouponRate;
    public byte PaymentsPerYear;
};

/// <summary>
///  Struct for Implied Order Added
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderAdded {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
    public int Price;
};

/// <summary>
///  Struct for Implied Order Deleted
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderDeleted {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
};

/// <summary>
///  Struct for Implied Order Replaced
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ImpliedOrderReplaced {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
    public int Price;
};

/// <summary>
///  Struct for Market Settlement
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketSettlement {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public int SettlementPrice;
    public uint Volatility;
    public fixed sbyte SettlementType[1];
};

/// <summary>
///  Struct for Market Updates
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketUpdates {
    public fixed byte Reserved[2];
    public fixed byte LastTradedVolume[1];
    public fixed byte LastTradedPrice[1];
    public fixed byte TotalTradedVolumeAndTotalTrades[1];
    public fixed byte LowestTradedPrice[1];
    public fixed byte HighestTradedPrice[1];
    public fixed byte OpeningTradePrice[1];
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
    public ushort Length;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Open High Low Last Trade Adjustment
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OpenHighLowLastTradeAdjustment {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public int OpeningTrade;
    public int HighestTrade;
    public int LowestTrade;
    public int LastTrade;
    public uint LastVolume;
    public uint TotalTradedVolume;
    public uint TotalTrades;
    public byte MarketUpdates;
};

/// <summary>
///  Struct for Option Symbol Directory
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OptionSymbolDirectory {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public fixed sbyte Exchange[6];
    public fixed sbyte Instrument[6];
    public ContractType ContractType;
    public ushort ExpiryYear;
    public byte ExpiryMonth;
    public OptionType OptionType;
    public uint Strike;
    public uint UnderlyingContractNumber;
    public byte PriceDecimalPosition;
    public uint PriceFractionalDenominator;
    public ushort PriceMinimumTick;
    public byte StrikePriceDecimalPosition;
    public uint StrikePriceFractionalDenominator;
    public ushort StrikePriceMinimumTick;
    public uint LastTradingDate;
    public int PriorDaySettlement;
    public uint Volatility;
    public FinancialType FinancialType;
    public fixed sbyte Currency[3];
    public uint LotSizeOrFaceValue;
    public byte MaturityValue;
    public ushort CouponRate;
    public byte PaymentsPerYear;
    public Activated Activated;
};

/// <summary>
///  Struct for Order Added
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAdded {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
    public int Price;
};

/// <summary>
///  Struct for Order Book State
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderBookState {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public TradingStatus TradingStatus;
};

/// <summary>
///  Struct for Order Deleted
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeleted {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
};

/// <summary>
///  Struct for Order Executed
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecuted {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
};

/// <summary>
///  Struct for Order Executed With Price
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedWithPrice {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public ulong BuyingOrderNumber;
    public uint BuyerQuantityRemaining;
    public ulong SellingOrderNumber;
    public uint SellerQuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
};

/// <summary>
///  Struct for Order Replaced
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplaced {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint OrderBookPriority;
    public uint Quantity;
    public int Price;
};

/// <summary>
///  Struct for Order Volume Cancelled
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderVolumeCancelled {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint Quantity;
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
    public fixed sbyte Session[10];
    public ulong Sequence;
    public ushort Count;
};

/// <summary>
///  Struct for Request For Quote
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RequestForQuote {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public int Price;
    public uint Quantity;
};

/// <summary>
///  Struct for Session
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Session {
    public fixed sbyte ProtocolVersion[3];
    public fixed sbyte SessionYear[2];
    public fixed sbyte SessionWeek[2];
    public fixed sbyte TradingService[3];
};

/// <summary>
///  Struct for Spread Executed
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpreadExecuted {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public Side Side;
    public ulong OrderNumber;
    public uint QuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
    public uint TradedContractNumber;
    public int SpreadTradePrice;
    public fixed sbyte TradeSideOfLeg[1];
    public Printable Printable;
};

/// <summary>
///  Struct for Spread Symbol Directory
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SpreadSymbolDirectory {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public fixed sbyte Exchange[6];
    public ContractType ContractType;
    public uint FirstLegContractNumber;
    public uint SecondLegContractNumber;
    public byte PrimaryRatio;
    public byte SecondaryRatio;
    public byte PriceDecimalPosition;
    public uint PriceFractionalDenominator;
    public ushort PriceMinimumTick;
};

/// <summary>
///  Struct for System Event
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEvent {
    public uint Timestamp;
    public ushort TradeDate;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Time Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TimeMessage {
    public uint Second;
};

/// <summary>
///  Struct for Trade Cancellation
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancellation {
    public uint Timestamp;
    public ushort TradeDate;
    public uint MatchNumber;
};

/// <summary>
///  Struct for Trade Spread Execution Chain
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeSpreadExecutionChain {
    public uint Timestamp;
    public ushort TradeDate;
    public uint Buyer;
    public fixed sbyte SideOfBuyer[1];
    public ulong BuyerOrderNumber;
    public uint BuyerQuantityRemaining;
    public uint SellerContractNumber;
    public fixed sbyte SideOfSeller[1];
    public ulong SellingOrderNumber;
    public uint SellerQuantityRemaining;
    public TradeType TradeType;
    public uint MatchNumber;
    public uint ExecutedQuantity;
    public int TradePrice;
    public uint TradedContractNumber;
    public int SpreadTradePrice;
    public Printable Printable;
};

/// <summary>
///  Struct for Volume And Open Interest
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct VolumeAndOpenInterest {
    public uint Timestamp;
    public ushort TradeDate;
    public uint ContractNumber;
    public uint CumulativeVolume;
    public uint OpenInterest;
    public ushort VoiTradeDate;
};

