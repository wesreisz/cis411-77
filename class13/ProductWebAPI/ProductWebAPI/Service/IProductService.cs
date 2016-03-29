using System.Collections.Generic;
using ProductWebAPI.Models;

namespace ProductWebAPI
{
    public interface IProductService
    {
        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);
    }
}