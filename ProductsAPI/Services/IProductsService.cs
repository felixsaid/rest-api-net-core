using ProductsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Services
{
    public interface IProductsService
    {
        public List<Product> GetProducts();

        public Product AddProduct(Product productItem);

        public Product UpdateProduct(string id, Product productItem);

        public string DeleteItem(string id);
    }
}
