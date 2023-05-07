namespace BlazorServer.Data;

public interface ICategoriesRepository
{

    public void AddCategory(Category category);
    public IReadOnlyList<Category> GetCategories();
}