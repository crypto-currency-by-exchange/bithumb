using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShareInvest.Bithumb.Models;

public class RealTicker : Ticker
{
    [DataMember, JsonProperty("type"), JsonPropertyName("type")]
    public override string? Type
    {
        get; set;
    }

    [DataMember, JsonProperty("code"), JsonPropertyName("code"), Key]
    public override string? Code
    {
        get; set;
    }

    [DataMember, JsonProperty("ask_bid"), JsonPropertyName("ask_bid")]
    public Order OrderState
    {
        get; set;
    }

    [DataMember, JsonProperty("acc_ask_volume"), JsonPropertyName("acc_ask_volume")]
    public double AccAskVolume
    {
        get; set;
    }

    [DataMember, JsonProperty("acc_bid_volume"), JsonPropertyName("acc_bid_volume")]
    public double AccBidVolume
    {
        get; set;
    }

    /// <summary>
    /// PREVIEW: 입금지원
    /// ACTIVE: 거래지원가능
    /// DELISTED: 거래지원종료
    /// </summary>
    [DataMember, JsonProperty("market_state"), JsonPropertyName("market_state")]
    public MarketState MarketState
    {
        get; set;
    }

    [DataMember, JsonProperty("is_trading_suspended"), JsonPropertyName("is_trading_suspended")]
    public bool IsTradingSuspended
    {
        get; set;
    }

    [DataMember, JsonProperty("delisting_date"), JsonPropertyName("delisting_date")]
    public string? DelistingDate
    {
        get; set;
    }

    /// <summary>
    /// NONE
    /// CAUTION: 투자유의
    /// </summary>
    [DataMember, JsonProperty("market_warning"), JsonPropertyName("market_warning")]
    public MarketWarning MarketWarning
    {
        get; set;
    }

    /// <summary>
    /// SNAPSHOT
    /// REALTIME
    /// </summary>
    [DataMember, JsonProperty("stream_type"), JsonPropertyName("stream_type")]
    public StreamType StreamType
    {
        get; set;
    }

    [DataMember, JsonProperty("timestamp"), JsonPropertyName("timestamp"), Key]
    public override long TimeStamp
    {
        get; set;
    }
}