using ProductWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebAPI
{
    public class MockProductService : IProductService
    {
        Product[] products = new Product[] {
            new Product() { Id=1, Name="Tomato Soup", Category="Groceries",Price=1.00M},
            new Product() { Id=2, Name="Yo-yo", Category="Toys",Price=3.75M},
            new Product() { Id=3, Name="Hammer", Category="Hammer",Price=16.99M}
        };

        public IEnumerable<Product> getAllProducts() {
            return products;
        }
        public Product getProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            return product;
        }
    }
}