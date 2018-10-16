﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        // GET api/Trips
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {            
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {            
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
