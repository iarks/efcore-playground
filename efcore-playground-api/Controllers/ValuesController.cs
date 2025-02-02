﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcore_playground.service;
using Microsoft.AspNetCore.Mvc;

namespace efcore_playground_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        InsertService service;
        public ValuesController(InsertService service)
        {
            this.service = service;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            //await service.InsertRandom();
            //var xx = await service.GetAllStudents();
            await service.AddNewGrade();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
