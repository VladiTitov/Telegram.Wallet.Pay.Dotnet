namespace Wallet.Pay.Responses;

#nullable disable
internal class ResponseBase<TResponse> : IResponse<TResponse>
{
    public string Status { get; set; }
    public string Message { get; set; }
    public TResponse Data { get; set; }
}
