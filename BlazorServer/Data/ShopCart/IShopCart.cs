namespace BlazorServer.Data.Product;

public interface IShopCart
{
    IReadOnlyList<Product> GetShopProduct();
    void AddProductInCart(Product product);
}