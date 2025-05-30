using Business;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet.Configs;

public static class ServiceProviderFactory
{
    public static ServiceProvider Create()
    {
        var services = new ServiceCollection();
        services.AddBusiness();
        return services.BuildServiceProvider();
    }
}