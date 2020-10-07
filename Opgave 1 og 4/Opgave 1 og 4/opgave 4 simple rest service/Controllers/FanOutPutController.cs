using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FanLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace opgave_4_simple_rest_service.Controllers
{
    [Route("api/Fanoutput")]
    [ApiController]
    public class FanOutPutController : ControllerBase
    {
        // GET: api/<FanOutPutController>
        [HttpGet]
        public IEnumerable<FanOutput> Get()
        {
            return Fandata;
        }

        // GET api/<FanOutPutController>/5
        [HttpGet("{id}")]
        public FanOutput Get(int id)
        {
            return Fandata.Find(i => i.Id == id);
        }

        // POST api/<FanOutPutController>
        [HttpPost]
        public void Post([FromBody] FanOutput value)
        {
            Fandata.Add(value);
        }

        // PUT api/<FanOutPutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutput value)
        {
            FanOutput fan = Get(id);
            if (fan != null)
            {
                fan.Navn = value.Navn;
                fan.Fugt = value.Fugt;
                fan.Grader = value.Grader;

            }
        }

        // DELETE api/<FanOutPutController>/5
        [HttpDelete("{id}")]
        
        public void Delete(int id)
        {
            FanOutput fan = Get(id);
            Fandata.Remove(fan);
        }

        private static readonly List<FanOutput> Fandata = new List<FanOutput>()
        {
            new FanOutput("Lokale 304", 23, 45),
            new FanOutput("Lokale 204", 20, 55)
        };
    }
}
