using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mobileSpeacApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    getSpeac ob = new getSpeac();
        //    string value = ob.GetSpecById(id);
        //    return value;
        //}


        // GET api/values/5
        //[Route("api/values/GetSpeacefactions")]
        [HttpGet("{Name}")]
        public List<string> Get(string Name)
        {
            getSpeac ob = new getSpeac();
            List<string> value = ob.GetSpecByName(Name);
            return value;
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
