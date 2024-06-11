using System.Text;

namespace Wallet.Pay.Requests;

public class RequestBase<TResponse>(
    string uriPath, HttpMethod method) : IRequest<TResponse>
{
    [JsonIgnore]
    public HttpMethod Method { get; } = method;

    [JsonIgnore]
    public string UriPath { get; } = uriPath;

    public RequestBase(string uriPath) 
        : this(uriPath, HttpMethod.Post)
    { }

    public HttpContent? ToHttpContent()
    {
        var content = JsonConvert.SerializeObject(
            value: this,
            new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

        return new StringContent(
            content: content,
            encoding: Encoding.UTF8,
            mediaType: "application/json");
    }
}
