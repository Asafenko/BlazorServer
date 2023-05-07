namespace BlazorServer.Data.Product;

public interface ICatalogProduct
{
    IReadOnlyList<Product> GetProducts();
}