using System.Net;

namespace Wallet.Pay;

public class WalletPayClient(
    WalletPayClientOptions options, HttpClient? httpClient = default) : IWalletPayClient
{
    readonly WalletPayClientOptions _options = options 
        ?? throw new ArgumentNullException(nameof(options));
    readonly HttpClient _httpClient = httpClient 
        ?? new HttpClient().AddRequestHeader("Wpay-Store-Api-Key", options.Token);

    public WalletPayClient(string token, HttpClient? httpClient = default) 
        : this(new WalletPayClientOptions(token), httpClient)
    { }

    public async Task<ResponseBase<TResponse>?> MakeRequestAsync<TResponse>(
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
            //Error
            throw new NotImplementedException();
        }

        var content = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<ResponseBase<TResponse>>(value: content);
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

            throw new RequestException(
                message: "Request timed out", 
                exception: ex);
        }
        catch (Exception ex)
        {
            throw new RequestException
                (message: "Exception during making request", 
                exception: ex);
        }

        return httpResponseMessage;
    }
}
