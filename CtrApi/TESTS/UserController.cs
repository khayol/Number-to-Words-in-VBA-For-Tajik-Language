   using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Woorj.CtrApi.TESTS
{

    [Route("api/[controller]")] 
    [ApiController]
    public class UserController : Controller
    {
        // GET: api/<controller> How to call it from Browser: https://localhost:5001/api/User
        [HttpGet]
        public IEnumerable<string> Get() 
        {
            return new string[] { "value1", "value2" , "value3" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


}