using MediatorPattern.Application.Commands;
using MediatorPattern.Application.Handler;
using MediatorPattern.Core.Concrete;
using MediatorPattern.Core.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace MediatorPattern.Application.Extensions;

public static class BuildServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatorService();
        services.AddProductServices();
        return services;
    }

    private static IServiceCollection AddMediatorService(this IServiceCollection services)
    {
        return services.AddSingleton<IMediator, Mediator>();
    }

    private static IServiceCollection AddProductServices(this IServiceCollection services)
    {
        return services.AddTransient<IRequestHandler<CreateProductsCommand, ProductsResponse>, CreateProductHanlder>();
    }
}
