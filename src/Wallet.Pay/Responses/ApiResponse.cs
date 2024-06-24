namespace Wallet.Pay.Responses;

public class ApiResponse(string status, string message)
{
    public ResponseStatus Status { get; private set; } = status.ToEnum<ResponseStatus>();
    public string Message { get; private set; } = message;
}
