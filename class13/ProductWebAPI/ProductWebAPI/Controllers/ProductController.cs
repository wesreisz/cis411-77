using ProductWebAPI.Models;
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
            return new ProductService().getAllProducts();
        }

        public IHttpActionResult GetProduct(int id) {
            var product = new ProductService().getProductById(id);
            if (product == null) {
                return NotFound();
            }
            else {
                return Ok(product);
            }
        }
    }
}
