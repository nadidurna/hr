using Circle.Common;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection($"{nameof(Settings)}:Database");
        var settings = section.Get<Settings.DatabaseConfiguration>();
        services.AddDbContext<CircleDbContext>(builder =>
        {
            builder.UseSqlServer(settings.ConnectionString);
        });
        services.AddScoped<DbContext, CircleDbContext>();
        return services;
    }
}