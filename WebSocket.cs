using Newtonsoft.Json;

using ShareInvest.Bithumb.EventHandler;
using ShareInvest.Bithumb.Models;
using ShareInvest.Crypto;

using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;

namespace ShareInvest.Bithumb;

public class WebSocket : ShareWebSocket<ResponseEventArgs>
{
    public WebSocket() : base("ws-api.bithumb.com/websocket/v1")
    {

    }

    public async Task RequestAsync(params object[] objArr)
    {
        Queue<object> queue = new();

        foreach (var obj in objArr)
        {
            queue.Enqueue(obj);
        }
        await base.RequestAsync(JsonConvert.SerializeObject(queue));
    }

    public override async Task RequestAsync(string json)
    {
        await base.RequestAsync(json);
    }

    public override async Task ReceiveAsync()
    {
        while (WebSocketState.Open == Socket.State)
        {
            var buffer = new byte[0x400 * 3];

            var res = await Socket.ReceiveAsync(new ArraySegment<byte>(buffer), cts.Token);

            OnReceiveTicker(Encoding.UTF8.GetString(buffer, 0, res.Count));
        }

        Console.WriteLine(new
        {
            CryptoExchange = nameof(Bithumb),
            DateTime.Now,
            Socket = Socket.State
        });
    }

    public override async Task ConnectAsync(string? token = null, TimeSpan? interval = null)
    {
        await base.ConnectAsync(token, interval: interval ?? TimeSpan.FromMilliseconds(0xFFFFFFFE));
    }

    public void SetQuotes(Orderbook orderbook)
    {
        if (string.IsNullOrEmpty(orderbook.Code) is false)
        {
            quotes[orderbook.Code] = orderbook;
        }
    }

    readonly CancellationTokenSource cts = new();
    readonly ConcurrentDictionary<string, Orderbook> quotes = new();
}