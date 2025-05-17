namespace MediatorPattern.Application.Commands;

public class ProductsResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
