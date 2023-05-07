namespace BlazorServer.Data.Product;

public class InMemoryShopCart : IShopCart
{
   private readonly List<Product> _shopProduct = new List<Product>();
   
   public IReadOnlyList<Product> GetShopProduct()
   {
      return _shopProduct;
   }

   public void AddProductInCart(Product product)
   {
      _shopProduct.Add(product);
   }
   
   
   
   
   
   
   
   
}
    