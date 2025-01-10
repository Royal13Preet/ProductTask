using ProductsManagement.DataAccess.DBmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.Service
{
    public interface IProductService
    {
        /// <summary>
        /// Creating a new Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool AddNewProduct(Product product);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteProduct(int id);

        /// <summary>
        /// Get the all Products list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAlltheProductDetails();

        /// <summary>
        /// Get the product by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductDetailsById(int id);

        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool UpdateProduct(int id, Product product);

    }
}
