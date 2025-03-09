using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using ShareInvest.Bithumb.Models;
using ShareInvest.Crypto.Models;

namespace ShareInvest.Bithumb.EventHandler;

public class ResponseEventArgs : EventArgs
{
    public Response? Response
    {
        get;
    }

    public ResponseEventArgs(string json)
    {
        Response = JsonConvert.DeserializeObject<Response>(json, jsonSettings);
    }

    readonly JsonSerializerSettings jsonSettings = new()
    {
        Converters = [new ResponseConvert()],
        TypeNameHandling = TypeNameHandling.Auto
    };
}

public class ResponseConvert : JsonConverter<Response>
{
    public override Response? ReadJson(JsonReader reader, Type objectType, Response? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var obj = JObject.Load(reader);

        var type = obj.GetValue("type")?.ToString();

        if (string.IsNullOrEmpty(type))
        {
            return null;
        }

        return type switch
        {
            "ticker" => obj.ToObject<RealTicker>(),
            "orderbook" => obj.ToObject<Orderbook>(),
            _ => obj.ToObject<Response>()
        };
    }

    public override void WriteJson(JsonWriter writer, Response? value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}