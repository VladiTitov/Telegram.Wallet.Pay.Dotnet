using Newtonsoft.Json.Converters;

namespace Wallet.Pay.Enums;

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

[JsonConverter(typeof(StringEnumConverter))]
public enum ConversionCurrency
{
    TON,
    NOT,
    BTC,
    USDT
}
