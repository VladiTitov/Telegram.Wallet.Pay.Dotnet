namespace Wallet.Pay.Extensions;

internal static class StringExtensions
{
    public static TEnum ToEnum<TEnum>(this string valueToEnum) where TEnum : struct
        => string.IsNullOrEmpty(valueToEnum)
            ? throw new ArgumentNullException(nameof(valueToEnum))
            : Enum.TryParse(valueToEnum, out TEnum result)
                ? result
                : throw new InvalidCastException(nameof(valueToEnum));
}
