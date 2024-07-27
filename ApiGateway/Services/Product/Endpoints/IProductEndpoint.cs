using Carter;
using Product.Common.Models;
using Product.Services.Interfaces;

namespace Product.Endpoints;

public class IProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/products")
            .WithTags("Product Endpoints");
        group.MapGet("/", GetAllProductsAsync);
        group.MapGet("/{id:int}", GetProductAsync);
        group.MapPost("/", CreateProductAsync);
        group.MapPut("/{id:int}", UpdateProductAsync);
        group.MapDelete("/{id:int}", DeleteProductAsync);
    }

    private static async Task<IResult> GetAllProductsAsync(IProductService productService)
    {
        var products = await productService.GetAllAsync();
        return Results.Ok(products);
    }
    
    private static async Task<IResult> GetProductAsync(int id, IProductService productService)
    {
        var product = await productService.GetByIdAsync(id);
        return Results.Ok(product);
    }
    
    private static async Task<IResult> CreateProductAsync(ProductCreateDto productCreateDto, IProductService productService)
    {
        var product = await productService.CreateAsync(productCreateDto);
        return Results.Ok(product);
    }
    
    private static async Task<IResult> UpdateProductAsync(int id, ProductCreateDto productCreateDto, IProductService productService)
    {
        var product = await productService.UpdateAsync(id, productCreateDto);
        return Results.Ok(product);
    }
    
    private static async Task<IResult> DeleteProductAsync(int id, IProductService productService)
    {
        var product = await productService.DeleteAsync(id);
        return Results.Ok(product);
    }
}