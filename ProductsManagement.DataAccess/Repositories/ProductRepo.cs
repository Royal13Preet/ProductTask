using ProductsManagement.DataAccess.DBmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.DataAccess.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductDBContext _dbContext;

        public ProductRepo(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddProduct(Product products)
        {

            var res = _dbContext.Products.Add(products);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int id)
        {
            var result = _dbContext.Products.FirstOrDefault(a => a.Id == id);
            if (result != null)
            {
                _dbContext.Remove(result);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products;
        }

        public Product GetProductById(int id)
        {
            var products = _dbContext.Products.FirstOrDefault(x => x.Id == id);

            return products!;
        }

        public bool UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return true;

        }
    }
}
