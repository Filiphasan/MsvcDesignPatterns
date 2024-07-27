using Product.Common.Models;

namespace Product.Services.Interfaces;

public interface IProductService
{
    Task<List<ProductDto>> GetAllAsync();
    Task<ProductDto> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(ProductCreateDto product);
    Task<ProductDto> UpdateAsync(int id, ProductCreateDto product);
    Task<bool> DeleteAsync(int id);
}