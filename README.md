# [![NuGet](https://img.shields.io/nuget/v/ShareInvest.Bithumb?label=ShareInvest.Bithumb&style=plastic&logo=nuget&color=004880)](https://www.nuget.org/packages/ShareInvest.Bithumb)
```C#
using Newtonsoft.Json;

using ShareInvest.Bithumb;
using ShareInvest.Bithumb.Models;

IEnumerable<Ticker> tickers;

using (var api = new Quotation())
{
    var market = await api.GetMarketAsync();

    tickers = await api.GetTickerAsync(market);

    foreach (var ticker in tickers)
    {
        Console.WriteLine(ticker.Code);
    }
}
using (var socket = new WebSocket())
{
    socket.SendTicker += (sender, e) =>
    {
        Console.WriteLine(JsonConvert.SerializeObject(e.Ticker, Formatting.Indented));
    };
    await socket.ConnectAsync();

    var task = Task.Run(socket.ReceiveAsync);

    static string swapStr(string? str)
    {
        var parts = str?.Split('-');

        return string.Join('_', parts?[^1], parts?[0]);
    }

    var bithumb = from ticker in tickers
                  where !string.IsNullOrEmpty(ticker.Code)
                  select swapStr(ticker.Code);

    await socket.RequestAsync("ticker", [.. bithumb], "30M", "1H", "12H", "24H", "MID");

    await task;
}
```
