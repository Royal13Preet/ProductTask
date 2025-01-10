using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ProductsManagement.DataAccess.DBmodel;
using ProductsManagement.Service;

namespace ProductsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }

        [HttpGet("Get-the-all-Products")]
        public IActionResult GetProducts()
        {
            var result = _productService.GetAlltheProductDetails();
            return Ok(result);
        }

        [HttpGet("Get-the-product-by-ID/{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProductDetailsById(id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }
            return Ok(product);
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            var createdProduct = _productService.AddNewProduct(product);
            return Created();
        }

        [HttpPut("Update-the-Product-By-ID/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var isUpdated = _productService.UpdateProduct(id, updatedProduct);

            if (!isUpdated)
            {
                return NotFound("Product not found.");
            }
            return Ok("Product updated successfully.");
        }

        [HttpDelete("Delete-the-Product-By-Id{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var isDeleted = _productService.DeleteProduct(id);

            if (!isDeleted)
            {
                return NotFound("Product not found.");
            }

            return NoContent();
        }
    }

}
