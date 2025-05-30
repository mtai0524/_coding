using Business.FindPairWithSum;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class DependencyInjection
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddScoped<IFindPairWithSum, FindPairWithSum.FindPairWithSum>();
        return services;
    }
}
    