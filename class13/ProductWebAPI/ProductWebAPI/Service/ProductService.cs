using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductWebAPI.Models;
using ProductWebAPI.DAL;

namespace ProductWebAPI.Service
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var repo = new SampleModel()) {
                foreach (var petsDomainModel in repo.Pets) {
                    Product p = new Product();
                    p.Id = (int)petsDomainModel.PetID;
                    p.Name = petsDomainModel.PetName + " (" + petsDomainModel.PetDescription +")";
                    p.Price = petsDomainModel.PetPrice;
                    p.Category = petsDomainModel.AnimalType.AnimalName;
                    products.Add(p);
                }
            }

            return products;
        }
        
        public Product getProductById(int id)
        {
            Product result = null;
            IEnumerable < Product > products = getAllProducts();
            foreach (Product p in products) {
                if (p.Id == id)
                {
                    result = p;
                }
            }
            return result;
        }
    }
}