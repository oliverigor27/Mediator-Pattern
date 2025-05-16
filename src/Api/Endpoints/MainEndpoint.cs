namespace MediatorPatern.Api.Endpoints;

public class MainEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/all", HandleAsync)
            .WithSummary("Base endpoint to get some infos")
            .WithTags("InfoEndpoint")
            .Produces(StatusCodes.Status200OK);
    }

    private static IResult HandleAsync()
    {
        return TypedResults.Ok(new {
            Message = "API is Running!"
        });
    }
}
