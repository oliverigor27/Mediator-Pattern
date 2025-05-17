using MediatorPatern.Api.RequestModels;
using MediatorPattern.Application.Commands;
using MediatorPattern.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPatern.Api.Endpoints;

public class CreateProductEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder builder)
    {
        builder.MapPost("/create", HandleAsync)
            .WithSummary("API for create a new product on the database")
            .WithTags("CreateProduct")
            .Produces(StatusCodes.Status201Created);
    }

    private static async Task<IResult> HandleAsync(
        [FromServices] IMediator mediator, 
        [FromBody] CreateProductRequest request
    )
    {
        var command = new CreateProductsCommand {
            Name = "Computador",
            Price = 1000
        };

        await mediator.Send(command);
        return TypedResults.Created();
    }
}
