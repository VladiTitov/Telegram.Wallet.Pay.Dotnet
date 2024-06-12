namespace Wallet.Pay.Tests.Integrations;

public class BaseClientScenarios
{
    private readonly string? Token;
    internal readonly IWalletPayClient _walletPayClient;

    public BaseClientScenarios()
    {
        Token = Environment.GetEnvironmentVariable(nameof(Token));
        _walletPayClient = GetWalletPayClient();
    }

    private IWalletPayClient GetWalletPayClient()
    {
        ArgumentNullException.ThrowIfNull(Token);
        return new WalletPayClient(Token);
    }
}
