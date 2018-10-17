using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripTracker.Data;
using TripTracker.Models;

namespace TripTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private TripContext context;

        public TripsController(TripContext _context)
        {
            context = _context;
        }

        // GET api/Trips
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await context.Trips
                .AsNoTracking()
                .ToListAsync());
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return context.Trips.Find(id);
        }

        // POST api/Trips
        [HttpPost]
        public IActionResult Post([FromBody] Trip value)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            context.Trips.Add(value);
            context.SaveChanges();
            return Ok();
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            context.Trips.Update(value);
            context.SaveChanges();
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.Trips.Remove(id);
        }
    }
}

