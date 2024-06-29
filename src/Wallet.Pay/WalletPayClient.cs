using System.Net;

namespace Wallet.Pay;

/// <summary>
/// A client to use the Telegram Wallet Pay API
/// </summary>
/// <param name="options">Configuration for <see cref="WalletPayClient" /></param>
/// <param name="httpClient">A custom <see cref="HttpClient"/></param>
public class WalletPayClient(
    WalletPayClientOptions options, HttpClient? httpClient = default)
    : IWalletPayClient
{
    readonly WalletPayClientOptions _options = options 
        ?? throw new ArgumentNullException(nameof(options));
    readonly HttpClient _httpClient = httpClient 
        ?? new HttpClient().AddRequestHeader("Wpay-Store-Api-Key", options.Token);

    public WalletPayClient(string token, HttpClient? httpClient = default) 
        : this(new WalletPayClientOptions(token), httpClient)
    { }

    public async Task<TResponse> MakeRequestAsync<TResponse>(
        IRequest<TResponse> request,
        CancellationToken cancellationToken = default) where TResponse : class
    {
        ArgumentNullException.ThrowIfNull(request);

        using var httpRequest = new HttpRequestMessage(
            method: request.Method, 
            requestUri: string.Concat(_options.BaseWalletPayUri, "/", request.UriPath))
        {
            Content = request.ToHttpContent()
        };

        using var httpResponse = await SendRequestAsync(
            httpClient: _httpClient,
            httpRequest: httpRequest,
            cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        if (httpResponse.StatusCode != HttpStatusCode.OK)
        {
            var failedApiResponse = await httpResponse
                .DeserializeContentAsync<ApiResponse>(cancellationToken);
            throw new RequestException(
                message: failedApiResponse.Message, 
                httpStatusCode: httpResponse.StatusCode);
        }
        return await httpResponse
            .DeserializeContentAsync<TResponse>(cancellationToken);
    }

    static async Task<HttpResponseMessage> SendRequestAsync(
        HttpClient httpClient,
        HttpRequestMessage httpRequest,
        CancellationToken cancellationToken = default)
    {
        HttpResponseMessage? httpResponseMessage;

        try
        {
            httpResponseMessage = await httpClient
                    .SendAsync(request: httpRequest, cancellationToken: cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
        }
        catch (TaskCanceledException ex)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                throw;
            }

            throw new RequestException("Request timed out", ex);
        }
        catch (Exception ex)
        {
            throw new RequestException("Exception during making request", ex);
        }

        return httpResponseMessage;
    }
}
