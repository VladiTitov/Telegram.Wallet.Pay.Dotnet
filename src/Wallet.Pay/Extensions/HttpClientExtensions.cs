namespace Wallet.Pay.Extensions;

internal static class HttpClientExtensions
{
    internal static HttpClient AddRequestHeader(this HttpClient httpClient, string headerName, string value)
    {
        httpClient.DefaultRequestHeaders.Add(headerName, value);
        return httpClient;
    }
}
