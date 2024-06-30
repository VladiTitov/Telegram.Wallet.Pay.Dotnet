namespace Wallet.Pay.Responses;

/// <summary>
/// API response
/// </summary>
#nullable disable
public class Response : IResponse
{
    /// <summary>
    /// Operation result status, always present
    /// </summary>
    public ResponseStatus Status { get; set; }

    /// <summary>
    /// Verbose reason of non-success result
    /// </summary>
    public string Message { get; set; }
}

/// <summary>
/// API response
/// </summary>
/// <typeparam name="TResponse">Type of result expected in result</typeparam>

public class Response<TResponse> : Response, IResponse<TResponse>
{
    /// <summary>
    /// Response payload, present if status is SUCCESS
    /// </summary>
    public TResponse Data { get; set; }
}
