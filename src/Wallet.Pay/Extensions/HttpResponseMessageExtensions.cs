namespace Wallet.Pay.Extensions;

internal static class HttpResponseMessageExtensions
{
    internal static async Task<T> DeserializeContentAsync<T>(
        this HttpResponseMessage httpResponse, 
        CancellationToken cancellationToken = default) where T : class
    {
        if (httpResponse.Content is null)
        {
            throw new RequestException(
                message: "Response doesn't contain any content",
                httpStatusCode: httpResponse.StatusCode);
        }

        T? deserializedObject;

        try
        {
            var content = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
            deserializedObject = JsonConvert.DeserializeObject<T>(content);
        }
        catch (Exception exception)
        {
            throw CreateRequestException(
                httpResponse: httpResponse,
                message: "Required properties not found in response",
                exception: exception
            );
        }

        if (deserializedObject is null)
        {
            throw CreateRequestException(
                httpResponse: httpResponse,
                message: "Required properties not found in response"
            );
        }

        return deserializedObject;
    }

    static RequestException CreateRequestException(
        HttpResponseMessage httpResponse,
        string message,
        Exception? exception = default) 
        => exception is null
            ? new(message, httpResponse.StatusCode)
            : new(message, httpResponse.StatusCode, exception);
}
