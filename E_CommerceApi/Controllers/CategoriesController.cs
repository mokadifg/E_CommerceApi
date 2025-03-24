using E_CommerceApi.Models;
using E_CommerceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // GET: api/Categories
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(DataRepository.Categories);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = DataRepository.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        // POST: api/Categories
        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            category.Id = DataRepository.Categories.Any()
                          ? DataRepository.Categories.Max(c => c.Id) + 1
                          : 1;
            DataRepository.Categories.Add(category);
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Category category)
        {
            if (category == null || id != category.Id)
                return BadRequest();

            var existingCategory = DataRepository.Categories.FirstOrDefault(c => c.Id == id);
            if (existingCategory == null)
                return NotFound();

            existingCategory.Name = category.Name;
            existingCategory.DisplayName = category.DisplayName;
            existingCategory.Description = category.Description;

            return NoContent();
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = DataRepository.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();

            DataRepository.Categories.Remove(category);
            return NoContent();
        }
    }
}
