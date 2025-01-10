using ProductsManagement.DataAccess.DBmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.DataAccess.Repositories
{
    public interface IProductRepo
    {
        /// <summary>
        /// Getting all the Products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts();
        
        /// <summary>
        /// Get the Product By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id);

        /// <summary>
        /// Create New Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool AddProduct(Product product);

        /// <summary>
        /// Delete the Product by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteProduct(int id);

        /// <summary>
        /// Updating the Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool UpdateProduct(Product product);




    }
}
