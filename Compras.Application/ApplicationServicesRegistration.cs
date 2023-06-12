
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Compras.Application;

public static class ApplicationServicesRegistration
{

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services; 

    }


}
