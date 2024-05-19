using Newtonsoft.Json;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShareInvest.Bithumb.Models;

public class RealTicker
{
    public string? Type
    {
        get; set;
    }

    [DataMember, JsonProperty("content"), JsonPropertyName("content")]
    public TickerContent? Content
    {
        get; set;
    }
}