using System.Security.Cryptography;
using Category.Common.Models;
using Category.Common.Provider;
using Category.Services.Interfaces;

namespace Category.Services.Implementations;

public class CategoryService : ICategoryService
{
    public async Task<List<CategoryDto>> GetAllAsync()
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var categoryList = CategoryDataProvider.Instance.GetCategories();
        var list = categoryList
            .Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CreateTime = x.CreateTime
            })
            .ToList();
        return list;
    }

    public async Task<CategoryDto> GetByIdAsync(int id)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var category = CategoryDataProvider.Instance.GetCategory(id);
        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            CreateTime = category.CreateTime
        };
    }

    public async Task<CategoryDto> CreateAsync(CategoryCreateDto category)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var categoryEntity = new Common.Entities.Category
        {
            Name = category.Name,
            Description = category.Description,
            CreateTime = DateTime.Now
        };
        CategoryDataProvider.Instance.AddCategory(categoryEntity);
        return new CategoryDto
        {
            Id = categoryEntity.Id,
            Name = categoryEntity.Name,
            Description = categoryEntity.Description,
            CreateTime = categoryEntity.CreateTime
        };
    }

    public async Task<CategoryDto> UpdateAsync(int id, CategoryCreateDto category)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var categoryEntity = CategoryDataProvider.Instance.GetCategory(id);
        categoryEntity.Name = category.Name;
        categoryEntity.Description = category.Description;
        CategoryDataProvider.Instance.UpdateCategory(categoryEntity);
        return new CategoryDto
        {
            Id = categoryEntity.Id,
            Name = categoryEntity.Name,
            Description = categoryEntity.Description
        };
    }

    public async Task<bool> DeleteAsync(int id)
    {
        // Simulate network latency
        var delayTime = RandomNumberGenerator.GetInt32(200, 301);
        await Task.Delay(delayTime);
        var categoryEntity = CategoryDataProvider.Instance.GetCategory(id);
        CategoryDataProvider.Instance.RemoveCategory(categoryEntity);
        return true;
    }
}