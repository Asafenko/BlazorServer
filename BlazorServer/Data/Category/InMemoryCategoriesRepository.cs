namespace BlazorServer.Data;


public class InMemoryCategoriesRepository : ICategoriesRepository

{
    private readonly List<Category> _categories = new List<Category>()
    {
        new("Electronics"),
        new("Appliances"),
        new("Books")
    };

    public void AddCategory(Category category)
    {
        _categories.Add(category);
    }
    public IReadOnlyList<Category> GetCategories()
    {
        return _categories;
    }
}