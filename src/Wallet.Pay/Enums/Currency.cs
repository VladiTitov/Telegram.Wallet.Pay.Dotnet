using Newtonsoft.Json.Converters;

namespace Wallet.Pay.Enums;

/// <summary>
/// Currency code
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Currency
{
    TON,
    NOT,
    BTC,
    USDT,
    EUR,
    USD,
    RUB
}

/// <summary>
/// Crypto currency you want to receive no matter what crypto currency the payer will choose to pay
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConversionCurrency
{
    TON,
    NOT,
    BTC,
    USDT
}
