using E_CommerceApi.Models;
using E_CommerceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(DataRepository.Products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = DataRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            // Assigner un nouvel id (simple incrémentation)
            product.Id = DataRepository.Products.Any()
                         ? DataRepository.Products.Max(p => p.Id) + 1
                         : 1;
            DataRepository.Products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            if (product == null || id != product.Id)
                return BadRequest();

            var existingProduct = DataRepository.Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
                return NotFound();

            // Mise à jour des propriétés
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.LongDescription = product.LongDescription;
            existingProduct.Price = product.Price;
            existingProduct.DiscountPrice = product.DiscountPrice;
            existingProduct.ImageUrl = product.ImageUrl;
            existingProduct.Images = product.Images;
            existingProduct.Category = product.Category;
            existingProduct.Rating = product.Rating;
            existingProduct.Reviews = product.Reviews;
            existingProduct.StockCount = product.StockCount;
            existingProduct.Specs = product.Specs;
            existingProduct.Featured = product.Featured;

            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = DataRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            DataRepository.Products.Remove(product);
            return NoContent();
        }
    }
}
