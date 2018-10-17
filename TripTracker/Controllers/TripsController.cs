using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.Models;

namespace TripTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        public TripsController(Repository _repository)
        {
            repository = _repository;
        }

        private Repository repository;

        // GET api/Trips
        [HttpGet]
        public ActionResult<IEnumerable<Trip>> Get()
        {
            return repository.Get();
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody] Trip value)
        {
            repository.Add(value);
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            repository.Update(value);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Remove(id);
        }
    }
}

