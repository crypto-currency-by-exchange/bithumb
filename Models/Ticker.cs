using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShareInvest.Bithumb.Models;

public class Ticker
{
    /// <summary>종목 구분 코드</summary>
    [DataMember, JsonProperty("market"), JsonPropertyName("market")]
    public virtual string? Code
    {
        get; set;
    }

    /// <summary>최근 거래 일자(UTC)</summary>
    [DataMember, JsonProperty("trade_date"), JsonPropertyName("trade_date"), StringLength(8)]
    public string? TradeDate
    {
        get; set;
    }

    /// <summary>최근 거래 시각(UTC)</summary>
    [DataMember, JsonProperty("trade_time"), JsonPropertyName("trade_time"), StringLength(6)]
    public string? TradeTime
    {
        get; set;
    }

    /// <summary>최근 거래 일자(KST)</summary>
    [DataMember, JsonProperty("trade_date_kst"), JsonPropertyName("trade_date_kst"), StringLength(8)]
    public string? TradeDateKst
    {
        get; set;
    }

    /// <summary>최근 거래 시각(KST)</summary>
    [DataMember, JsonProperty("trade_time_kst"), JsonPropertyName("trade_time_kst"), StringLength(6)]
    public string? TradeTimeKst
    {
        get; set;
    }

    /// <summary>최근 거래 일시(UTC)</summary>
    [DataMember, JsonProperty("trade_timestamp"), JsonPropertyName("trade_timestamp")]
    public long TradeTimeStamp
    {
        get; set;
    }

    /// <summary>시가</summary>
    [DataMember, JsonProperty("opening_price"), JsonPropertyName("opening_price")]
    public double OpeningPrice
    {
        get; set;
    }

    /// <summary>고가</summary>
    [DataMember, JsonProperty("high_price"), JsonPropertyName("high_price")]
    public double HighPrice
    {
        get; set;
    }

    /// <summary>저가</summary>
    [DataMember, JsonProperty("low_price"), JsonPropertyName("low_price")]
    public double LowPrice
    {
        get; set;
    }

    /// <summary>현재가</summary>
    [DataMember, JsonProperty("trade_price"), JsonPropertyName("trade_price")]
    public double TradePrice
    {
        get; set;
    }

    /// <summary>전일 종가</summary>
    [DataMember, JsonProperty("prev_closing_price"), JsonPropertyName("prev_closing_price")]
    public double PrevClosingPrice
    {
        get; set;
    }

    [DataMember, JsonProperty("change"), JsonPropertyName("change")]
    public Change Change
    {
        get; set;
    }

    /// <summary>변화액의 절대값</summary>
    [DataMember, JsonProperty("change_price"), JsonPropertyName("change_price")]
    public double ChangePrice
    {
        get; set;
    }

    /// <summary>변화율의 절대값</summary>
    [DataMember, JsonProperty("change_rate"), JsonPropertyName("change_rate")]
    public double ChangeRate
    {
        get; set;
    }

    /// <summary>부호가 있는 변화액</summary>
    [DataMember, JsonProperty("signed_change_price"), JsonPropertyName("signed_change_price")]
    public double SignedChangePrice
    {
        get; set;
    }

    /// <summary>부호가 있는 변화율</summary>
    [DataMember, JsonProperty("signed_change_rate"), JsonPropertyName("signed_change_rate")]
    public double SignedChangeRate
    {
        get; set;
    }

    /// <summary>가장 최근 거래량</summary>
    [DataMember, JsonProperty("trade_volume"), JsonPropertyName("trade_volume")]
    public double TradeVolume
    {
        get; set;
    }

    /// <summary>누적 거래대금(UTC 0시 기준)</summary>
    [DataMember, JsonProperty("acc_trade_price"), JsonPropertyName("acc_trade_price")]
    public double AccTradePrice
    {
        get; set;
    }

    /// <summary>24시간 누적 거래대금</summary>
    [DataMember, JsonProperty("acc_trade_price_24h"), JsonPropertyName("acc_trade_price_24h")]
    public double AccTradePrice24H
    {
        get; set;
    }

    /// <summary>누적 거래량(UTC 0시 기준)</summary>
    [DataMember, JsonProperty("acc_trade_volume"), JsonPropertyName("acc_trade_volume")]
    public double AccTradeVolume
    {
        get; set;
    }

    /// <summary>24시간 누적 거래량</summary>
    [DataMember, JsonProperty("acc_trade_volume_24h"), JsonPropertyName("acc_trade_volume_24h")]
    public double AccTradeVolume24H
    {
        get; set;
    }

    /// <summary>52주 신고가</summary>
    [DataMember, JsonProperty("highest_52_week_price"), JsonPropertyName("highest_52_week_price")]
    public double Highest52WeekPrice
    {
        get; set;
    }

    /// <summary>52주 신고가 달성일</summary>
    [DataMember, JsonProperty("highest_52_week_date"), JsonPropertyName("highest_52_week_date"), StringLength(0xA)]
    public string? Highest52WeekDate
    {
        get; set;
    }

    /// <summary>52주 신저가</summary>
    [DataMember, JsonProperty("lowest_52_week_price"), JsonPropertyName("lowest_52_week_price")]
    public double Lowest52WeekPrice
    {
        get; set;
    }

    /// <summary>52주 신저가 달성일</summary>
    [DataMember, JsonProperty("lowest_52_week_date"), JsonPropertyName("lowest_52_week_date"), StringLength(0xA)]
    public string? Lowest52WeekDate
    {
        get; set;
    }

    [DataMember, JsonProperty("timestamp"), JsonPropertyName("timestamp")]
    public virtual long TimeStamp
    {
        get; set;
    }
}