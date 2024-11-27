using Microsoft.AspNetCore.Mvc;
using FoodSystem.Data;
using FoodSystem.Models;

namespace FoodSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // GET: api/products
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(ProductDataStore.Products);
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = ProductDataStore.Products.Find(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            product.Id = ProductDataStore.Products.Count + 1;
            ProductDataStore.Products.Add(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var product = ProductDataStore.Products.Find(p => p.Id == id);
            if (product == null) return NotFound();
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = ProductDataStore.Products.Find(p => p.Id == id);
            if (product == null) return NotFound();
            ProductDataStore.Products.Remove(product);
            return NoContent();
        }
    }
}
