using MediatorPatern.Api.Endpoints;

namespace MediatorPatern.Api.Extensions;

public static class EndpointRouteExtension
{
    public static WebApplication UseEndpoint(this WebApplication app)
    {
        var builder = app.MapGroup("");
        MapMainEndpoint(builder);
        return app;
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) 
        where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }

    public static void MapMainEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGroup("/info")
            .WithTags("InfoEndpoint")
            .MapEndpoint<MainEndpoint>();
    }
}
