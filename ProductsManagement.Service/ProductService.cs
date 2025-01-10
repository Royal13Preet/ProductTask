using Microsoft.Extensions.Logging;
using ProductsManagement.DataAccess.DBmodel;
using ProductsManagement.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _repository;

        public ProductService(IProductRepo repository)
        {
            _repository = repository;
            
        }
        public bool AddNewProduct(Product product)
        {
            var result = _repository.AddProduct(product);
            return result;

        }
        public bool DeleteProduct(int id)
        {
            var result = _repository.DeleteProduct(id); 
            return result;

        }
        public IEnumerable<Product> GetAlltheProductDetails()
        {
           
            var products = _repository.GetAllProducts();
            return products;
          
        }
        public Product GetProductDetailsById(int id)
        {
            var product = _repository.GetProductById(id);
            return product;
 
        }
        public bool UpdateProduct(int id, Product product)
        {
           
            var result = _repository.UpdateProduct(product);
            return result;
        }
    }
}
