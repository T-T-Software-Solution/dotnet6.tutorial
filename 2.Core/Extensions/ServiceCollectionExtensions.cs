using Microsoft.Extensions.DependencyInjection;

namespace _2.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<ITokenService, TokenService>();
        services.AddScoped<IProvinceService, ProvinceService>();

        return services;
    }
}
