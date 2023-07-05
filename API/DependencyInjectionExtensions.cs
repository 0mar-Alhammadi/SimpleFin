using System.Reflection;
using Mapster;
using MapsterMapper;

namespace SimpleFin;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddPresentationLayer(this IServiceCollection services) =>
        services
            .AddMapper();
    
    private static IServiceCollection AddMapper(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }
}