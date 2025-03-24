using E_CommerceApi.Models;
using E_CommerceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/Orders
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(DataRepository.Orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = DataRepository.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST: api/Orders
        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            order.Id = DataRepository.Orders.Any()
                       ? DataRepository.Orders.Max(o => o.Id) + 1
                       : 1;
            DataRepository.Orders.Add(order);
            return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Order order)
        {
            if (order == null || id != order.Id)
                return BadRequest();

            var existingOrder = DataRepository.Orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
                return NotFound();

            // Mettez à jour les propriétés de l'ordre ici.
            // Par exemple : existingOrder.SomeProperty = order.SomeProperty;

            return NoContent();
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = DataRepository.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
                return NotFound();

            DataRepository.Orders.Remove(order);
            return NoContent();
        }
    }
}
