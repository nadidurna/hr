using Circle.Data.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micrososft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<ILookupService, LookupService>();

        var queriesAssembly = AppDomain.CurrentDomain.Load("Circle.Data.Management.Queries");
        var commandsAssembly = AppDomain.CurrentDomain.Load("Circle.Data.Managemet.Commands");
        services.AddMediatR(queriesAssembly, commandsAssembly);
        return services;
    }
}
