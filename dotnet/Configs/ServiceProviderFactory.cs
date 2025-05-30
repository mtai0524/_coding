using Business;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet.Configs;

public static class ServiceProviderFactory
{
    internal static ServiceProvider Create()
    {
        var services = new ServiceCollection();
        services.AddBusiness();
        return services.BuildServiceProvider();
    }
}