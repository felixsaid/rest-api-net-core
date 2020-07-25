using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using ProductsAPI.Model;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private ILogger _logger;
        private IProductsService _service;

        public ProductsController(ILogger<ProductsController> logger, IProductsService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return _service.GetProducts();
        }


        [HttpPost("/api/products")]
        public ActionResult<Product> AddProduct(Product product)
        {
            _service.AddProduct(product);
            return product;
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Product> UpdateProduct(string id, Product product)
        {
            _service.UpdateProduct(id, product);
            return product;
        }

        public ActionResult<string> DeleteProduct(string id)
        {
            _service.DeleteItem(id);
            return id;
        }
    }
}
