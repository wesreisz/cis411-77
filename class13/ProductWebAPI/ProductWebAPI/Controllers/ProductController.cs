using ProductWebAPI.Models;
using ProductWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> GetAllProducts() {
            IProductService service = new ProductService();
            return service.getAllProducts();
        }

        public IHttpActionResult GetProduct(int id) {
            IProductService service = new ProductService();
            var product = service.getProductById(id);

            if (product == null) {
                return NotFound();
            }
            else {
                return Ok(product);
            }
        }
    }
}
