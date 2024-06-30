namespace Wallet.Pay;

/// <summary>
/// A client interface to use the Telegram Wallet Pay API
/// </summary>
public interface IWalletPayClient
{
    /// <summary>
    /// Send a request to Wallet Pay API
    /// </summary>
    /// <typeparam name="TResponse">Type of expected result in the response object</typeparam>
    /// <param name="request">API request object</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Result of the API request</returns>
    Task<TResponse> MakeRequestAsync<TResponse>(
        IRequest<TResponse> request,
        CancellationToken cancellationToken = default) where TResponse : class, IResponse;
}
