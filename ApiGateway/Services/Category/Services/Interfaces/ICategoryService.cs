using Category.Common.Models;

namespace Category.Services.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryDto>> GetAllAsync();
    Task<CategoryDto> GetByIdAsync(int id);
    Task<CategoryDto> CreateAsync(CategoryCreateDto category);
    Task<CategoryDto> UpdateAsync(int id, CategoryCreateDto category);
    Task<bool> DeleteAsync(int id);
}