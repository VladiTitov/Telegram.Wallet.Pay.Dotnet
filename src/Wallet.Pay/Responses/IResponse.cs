namespace Wallet.Pay.Responses;

internal interface IResponse<TResponse>
{
    public string Status { get; set; }
    public string Message { get; set; }
    public TResponse Data { get; set; }
}
