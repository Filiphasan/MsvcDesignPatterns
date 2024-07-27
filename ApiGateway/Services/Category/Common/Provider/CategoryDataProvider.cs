namespace Category.Common.Provider;

public class CategoryDataProvider
{
    private static readonly Lazy<CategoryDataProvider> _instance = new(() => new CategoryDataProvider());
    public static CategoryDataProvider Instance => _instance.Value;

    // Its not thread safe but its ok for this demo
    private readonly List<Entities.Category> _categories = [];

    public List<Entities.Category> GetCategories()
    {
        return _categories;
    }

    public Entities.Category GetCategory(int id)
    {
        return _categories.Find(x => x.Id == id);
    }

    public void AddCategory(Entities.Category category)
    {
        if (category.Id == 0)
        {
            var lastId = _categories.MaxBy(x => x.Id)?.Id ?? 0;
            category.Id = lastId + 1;
        }
        _categories.Add(category);
    }

    public void RemoveCategory(Entities.Category category)
    {
        _categories.Remove(category);
    }

    public void UpdateCategory(Entities.Category category)
    {
        var updatedCategory = _categories.Find(x => x.Id == category.Id);
        if (updatedCategory is not null)
        {
            _categories.Remove(updatedCategory);
        }
        AddCategory(category);
    }
}