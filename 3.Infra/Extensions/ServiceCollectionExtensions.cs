using _2.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3.Infra.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfraDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ITransientService, TransientService>();
        services.AddScoped<IScopedService, ScopedService>();
        services.AddSingleton<ISingletonService, SingletonService>();

        // Try to switch between Sendgrid and Mailgun
        //services.AddTransient<IEmailProvider, SendgridEmailProvider>();
        services.AddTransient<IEmailProvider, MailGunEmailProvider>();

        services.AddScoped<IProvinceRepository, ProvinceRepository>();

        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

        return services;
    }

    public static IServiceCollection ConfigureInfraOptions(this IServiceCollection services)
    {
        // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-6.0

        services.AddOptions<MailGunEmailProviderOptions>().BindConfiguration(MailGunEmailProviderOptions.ConfigItem);

        services.AddOptions<SendgridEmailProviderOptions>().BindConfiguration(SendgridEmailProviderOptions.ConfigItem);

        return services;
    }
}
