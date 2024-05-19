using Newtonsoft.Json;

using ShareInvest.Bithumb.EventHandler;
using ShareInvest.Crypto;

namespace ShareInvest.Bithumb;

public class WebSocket : ShareWebSocket<TickerEventArgs>
{
    public WebSocket() : base("pubwss.bithumb.com/pub/ws")
    {

    }

    /// <summary>
    /// symbols: BTC_KRW, ETH_KRW, …
    /// type: 구독 메시지 종류("ticker" / "transaction" / "orderbookdepth")
    /// (optional)tickTypes: tick 종류 ("30M"/"1H"/"12H"/"24H"/"MID")
    /// </summary>
    public async Task RequestAsync(string type, string[] symbols, params string[] tickTypes)
    {
        await base.RequestAsync(JsonConvert.SerializeObject(new
        {
            type,
            symbols,
            tickTypes
        }));
    }

    public async Task RequestAsync(string type, params string[] symbols)
    {
        await base.RequestAsync(JsonConvert.SerializeObject(new
        {
            type,
            symbols
        }));
    }

    public override async Task RequestAsync(string json)
    {
        await base.RequestAsync(json);
    }

    public override async Task ReceiveAsync()
    {
        await base.ReceiveAsync();
    }

    public override async Task ConnectAsync(string? token = null, TimeSpan? interval = null)
    {
        await base.ConnectAsync(token, interval: interval ?? TimeSpan.FromMilliseconds(0xFFFFFFFE));
    }
}