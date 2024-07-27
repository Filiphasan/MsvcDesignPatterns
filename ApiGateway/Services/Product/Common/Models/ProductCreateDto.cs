namespace Product.Common.Models;

public class ProductCreateDto
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}