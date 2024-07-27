namespace Category.Common.Models;

public class CategoryDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public DateTime CreateTime { get; set; }
}