using MediatorPattern.Core.Interface;

namespace MediatorPattern.Application.Commands;

public class CreateProductsCommand : IRequest<ProductsResponse>
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
