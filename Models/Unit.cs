using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.Bithumb.Models;

public class Unit
{
    [DataMember, JsonProperty("ask_price")]
    public int AskPrice
    {
        get; set;
    }

    [DataMember, JsonProperty("bid_price")]
    public int BidPrice
    {
        get; set;
    }

    [DataMember, JsonProperty("ask_size")]
    public int AskSize
    {
        get; set;
    }

    [DataMember, JsonProperty("bid_size")]
    public int BidSize
    {
        get; set;
    }
}