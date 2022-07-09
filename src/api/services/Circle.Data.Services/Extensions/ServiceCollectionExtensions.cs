using Circle.Data.Services.Concretes;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<ILookupService, LookupService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ILookupTypeService, LookupTypeService>();


        var queriesAssembly = AppDomain.CurrentDomain.Load("Circle.Data.Management.Queries");
        var commandsAssembly = AppDomain.CurrentDomain.Load("Circle.Data.Managemet.Commands");
        services.AddMediatR(queriesAssembly, commandsAssembly);
        return services;
    }
}