﻿namespace Wallet.Pay.Responses;

/// <summary>
/// API response interface
/// </summary>
public interface IResponse
{
    /// <summary>
    /// Response status
    /// </summary>
    public ResponseStatus Status { get; set; }

    /// <summary>
    /// Verbose reason of non-success result
    /// </summary>
    public string Message { get; set; }
}

/// <summary>
/// API response interface
/// </summary>
/// <typeparam name="TResponse">Type of result expected in result</typeparam>
public interface IResponse<TResponse> : IResponse
{
    /// <summary>
    /// Response payload, present if status is SUCCESS
    /// </summary>
    public TResponse Data { get; set; }
}
