using Wallet.Pay.Enums;

namespace Wallet.Pay.Responses;

internal interface IResponse<TResponse>
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; }
    public TResponse Data { get; set; }
}
