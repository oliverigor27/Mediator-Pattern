using MediatorPattern.Application.Commands;
using MediatorPattern.Core.Interface;

namespace MediatorPattern.Application.Handler;

public class CreateProductHanlder : IRequestHandler<CreateProductsCommand, ProductsResponse>
{
    public async Task<ProductsResponse> HandleAsync(CreateProductsCommand request)
    {
        await Task.Delay(5000);

        return new ProductsResponse {
            Id = 01,
            Name = request.Name,
            Price = request.Price
        };
    }
}
