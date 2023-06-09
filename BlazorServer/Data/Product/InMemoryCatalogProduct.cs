﻿namespace BlazorServer.Data.Product;

public class InMemoryCatalogProduct : ICatalogProduct
{
    private readonly List<Product> _product = new List<Product>
    {
        new("https://t-mobile.scene7.com/is/image/Tmusprod/Apple-iPhone-14-Pro-Deep-Purple-rightimage","Electronics", "IPhone", 20000m, "Apple", 17),
        new("https://leaders.jo/wp-content/uploads/2022/07/%D8%A7%D9%88%D9%84%D9%8A%D8%AF-2.jpg","Appliances", "TV", 80000m, "LG", 8),
        new("https://bc-img.s3.ap-south-1.amazonaws.com/images/cover/bc/9789389004267.png","Books", "1984", 200m, "Literature", 15)
    };

    public IReadOnlyList<Product> GetProducts()
    {
        return _product;
    }
}