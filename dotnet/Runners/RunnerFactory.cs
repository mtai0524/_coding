using Microsoft.Extensions.DependencyInjection;

namespace dotnet.Runners;

public class RunnerFactory
{
    private static ServiceProvider _provider;

    public static void Init(ServiceProvider provider)
    {
        _provider = provider;
    }

    public static T Get<T>() where T : class
    {
        return ActivatorUtilities.CreateInstance<T>(_provider);
    }
}