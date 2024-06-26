﻿using System.Text;

namespace Wallet.Pay.Requests;

/// <summary>
/// Represents a request to Wallet Pay API
/// </summary>
/// <typeparam name="TResponse">Type of result expected in result</typeparam>
/// <param name="uriPath">API uri path</param>
/// <param name="method">HTTP method of request</param>
public class Request<TResponse>(
    string uriPath, HttpMethod method) : IRequest<TResponse> 
    where TResponse : class, IResponse
{
    [JsonIgnore]
    public HttpMethod Method { get; } = method;

    [JsonIgnore]
    public string UriPath { get; } = uriPath;

    public Request(string uriPath) 
        : this(uriPath, HttpMethod.Get)
    { }

    /// <summary>
    /// Generate content of HTTP message
    /// </summary>
    /// <returns>Content of HTTP request</returns>
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
