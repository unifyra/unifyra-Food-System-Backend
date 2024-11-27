using FoodSystem.Models;

namespace FoodSystem.Data
{
    public static class ProductDataStore
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99m },
            new Product { Id = 2, Name = "Product B", Price = 20.50m }
        };
    }
}