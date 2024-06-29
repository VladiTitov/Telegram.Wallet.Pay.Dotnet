namespace Wallet.Pay.Responses;

/// <summary>
/// API response
/// </summary>
/// <typeparam name="TResponse">Type of result expected in result</typeparam>
#nullable disable
public class Response<TResponse> : IResponse<TResponse>
{
    /// <summary>
    /// Operation result status, always present
    /// </summary>
    public ResponseStatus Status { get; set; }

    /// <summary>
    /// Verbose reason of non-success result
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Response payload, present if status is SUCCESS
    /// </summary>
    public TResponse Data { get; set; }
}
