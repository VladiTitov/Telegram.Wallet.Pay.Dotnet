namespace Wallet.Pay.Requests;

/// <summary>
/// Represents a request interface to Wallet Pay API
/// </summary>
/// <typeparam name="TResponse">Type of result expected in result</typeparam>
public interface IRequest<TResponse>
{
    /// <summary>
    /// HTTP method of request
    /// </summary>
    HttpMethod Method { get; }

    /// <summary>
    /// API uri path
    /// </summary>
    string UriPath { get; }

    /// <summary>
    /// Generate content of HTTP message
    /// </summary>
    /// <returns>Content of HTTP request</returns>
    HttpContent? ToHttpContent();
}
