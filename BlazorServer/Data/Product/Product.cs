namespace BlazorServer.Data.Product;

public class Product
{
    public string Picture { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }
    public string Category { get; set; }

    public Product(string picture,string category, string name, decimal price, string description, int count)
    {
        Picture = picture;
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        Count = count;
    }
}