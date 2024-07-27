using Carter;
using Category.Common.Models;
using Category.Services.Interfaces;

namespace Category.Endpoints;

public class CategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/categories")
            .WithTags("Category Endpoint");

        group.MapGet("", GetCategoriesAsync);
        group.MapGet("/{id:int}", GetCategoryAsync);
        group.MapPost("", AddCategoryAsync);
        group.MapPut("/{id:int}", UpdateCategoryAsync);
        group.MapDelete("/{id:int}", RemoveCategoryAsync);
    }

    private static async Task<IResult> GetCategoriesAsync(ICategoryService categoryService)
    {
        var result = await categoryService.GetAllAsync();
        return Results.Ok(result);
    }

    private static async Task<IResult> GetCategoryAsync(int id, ICategoryService categoryService)
    {
        var result = await categoryService.GetByIdAsync(id);
        return Results.Ok(result);
    }

    private static async Task<IResult> AddCategoryAsync(CategoryCreateDto category, ICategoryService categoryService)
    {
        var result = await categoryService.CreateAsync(category);
        return Results.Ok(result);
    }

    private static async Task<IResult> UpdateCategoryAsync(int id, CategoryCreateDto category, ICategoryService categoryService)
    {
        var result = await categoryService.UpdateAsync(id, category);
        return Results.Ok(result);
    }

    private static async Task<IResult> RemoveCategoryAsync(int id, ICategoryService categoryService)
    {
        var result = await categoryService.DeleteAsync(id);
        return Results.Ok(result);
    }
}