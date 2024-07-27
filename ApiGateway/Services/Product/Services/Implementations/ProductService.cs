using System.Security.Cryptography;
using Product.Common.Models;
using Product.Common.Poviders;
using Product.Services.Interfaces;

namespace Product.Services.Implementations;

public class ProductService : IProductService
{
    public async Task<List<ProductDto>> GetAllAsync()
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var products = ProductDataProvider.Instance.GetProducts();
        var list = products
            .Select(x => new ProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CategoryId = x.CategoryId,
                Price = x.Price,
                Stock = x.Stock,
                CreateTime = x.CreateTime
            })
            .ToList();
        return list;
    }

    public async Task<ProductDto> GetByIdAsync(int id)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var product = ProductDataProvider.Instance.GetProduct(id);
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            CategoryId = product.CategoryId,
            Price = product.Price,
            Stock = product.Stock,
            CreateTime = product.CreateTime
        };
    }

    public async Task<ProductDto> CreateAsync(ProductCreateDto product)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var productEntity = new Common.Entities.Product
        {
            Name = product.Name,
            Description = product.Description,
            CategoryId = product.CategoryId,
            Price = product.Price,
            Stock = product.Stock,
            CreateTime = DateTime.Now
        };
        ProductDataProvider.Instance.AddProduct(productEntity);
        return new ProductDto
        {
            Id = productEntity.Id,
            Name = productEntity.Name,
            Description = productEntity.Description,
            CategoryId = productEntity.CategoryId,
            Price = productEntity.Price,
            Stock = productEntity.Stock,
            CreateTime = productEntity.CreateTime
        };
    }

    public async Task<ProductDto> UpdateAsync(int id, ProductCreateDto product)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var productEntity = ProductDataProvider.Instance.GetProduct(id);
        productEntity.Name = product.Name;
        productEntity.Description = product.Description;
        productEntity.CategoryId = product.CategoryId;
        productEntity.Price = product.Price;
        productEntity.Stock = product.Stock;
        ProductDataProvider.Instance.UpdateProduct(productEntity);
        return new ProductDto
        {
            Id = productEntity.Id,
            Name = productEntity.Name,
            Description = productEntity.Description,
            Price = productEntity.Price,
            Stock = productEntity.Stock,
            CreateTime = productEntity.CreateTime
        };
    }

    public async Task<bool> DeleteAsync(int id)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var productEntity = ProductDataProvider.Instance.GetProduct(id);
        ProductDataProvider.Instance.RemoveProduct(productEntity);
        return true;
    }
}