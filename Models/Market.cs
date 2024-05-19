using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShareInvest.Bithumb.Models;

public class Market
{
    /// <summary>빗썸에서 거래 가능한 마켓 목록</summary>
    [DataMember, JsonProperty("market"), JsonPropertyName("market"), Key]
    public string? Code
    {
        get; set;
    }

    [DataMember, JsonProperty("korean_name"), JsonPropertyName("korean_name")]
    public string? KoreanName
    {
        get; set;
    }

    [DataMember, JsonProperty("english_name"), JsonPropertyName("english_name")]
    public string? EnglishName
    {
        get; set;
    }

    [DataMember, JsonProperty("market_warning"), JsonPropertyName("market_warning")]
    public string? Warning
    {
        get; set;
    }
}