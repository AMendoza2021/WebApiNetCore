using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API_CHECADOR_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class controladorUsuarios : ControllerBase
    {
        // GET: api/<controladorUsuarios>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controladorUsuarios>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controladorUsuarios>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controladorUsuarios>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controladorUsuarios>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
