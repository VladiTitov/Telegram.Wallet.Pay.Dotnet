namespace Wallet.Pay.Responses;

#nullable disable
public class ResponseBase<TResponse> : IResponse<TResponse>
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; }
    public TResponse Data { get; set; }
}
