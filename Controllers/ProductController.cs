using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Interfaces;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: /products - Get all products
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        // GET: /products/{id} - Get product by ID
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: /products - Create new product
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Create(product);
                return Ok(new { message = "Product created successfully", product });
            }
            return BadRequest(ModelState);
        }
    }
}
