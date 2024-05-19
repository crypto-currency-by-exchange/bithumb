namespace ShareInvest.Bithumb.Models;

public class TickerContent
{
    /// <summary>통화코드</summary>
    public string? Symbol
    {
        get; set;
    }

    /// <summary>변동 기준시간- 30M, 1H, 12H, 24H, MID</summary>
    public string? TickType
    {
        get; set;
    }

    /// <summary>일자</summary>
    public string? Date
    {
        get; set;
    }

    /// <summary>시간</summary>
    public string? Time
    {
        get; set;
    }

    /// <summary>시가</summary>
    public string? OpenPrice
    {
        get; set;
    }

    /// <summary>종가</summary>
	public string? ClosePrice
    {
        get; set;
    }

    /// <summary>저가</summary>
	public string? LowPrice
    {
        get; set;
    }

    /// <summary>고가</summary>
	public string? HighPrice
    {
        get; set;
    }

    /// <summary>누적거래금액</summary>
	public string? Value
    {
        get; set;
    }

    /// <summary>누적거래량</summary>
	public string? Volume
    {
        get; set;
    }

    /// <summary>매도누적거래량</summary>
	public string? SellVolume
    {
        get; set;
    }

    /// <summary>매수누적거래량</summary>
	public string? BuyVolume
    {
        get; set;
    }

    /// <summary>전일종가</summary>
	public string? PrevClosePrice
    {
        get; set;
    }

    /// <summary>변동률</summary>
	public string? ChgRate
    {
        get; set;
    }

    /// <summary>변동금액</summary>
	public string? ChgAmt
    {
        get; set;
    }

    /// <summary>체결강도</summary>
	public string? VolumePower
    {
        get; set;
    }
}