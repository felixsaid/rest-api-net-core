using ProductsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Services
{
    public class ProductsService : IProductsService
    {

        private List<Product> _productItems;

        public ProductsService()
        {
            _productItems = new List<Product>();
        }


        public List<Product> GetProducts()
        {
            return _productItems;
        }
        public Product AddProduct(Product productItem)
        {
            _productItems.Add(productItem);
            return productItem;
        }

        public string DeleteItem(string id)
        {
            throw new NotImplementedException();
        }


        public Product UpdateProduct(string id, Product productItem)
        {
            throw new NotImplementedException();
        }
    }
}
