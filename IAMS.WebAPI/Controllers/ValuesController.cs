using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DBContext context;

        public ValuesController(DBContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            context.Persons.Add(new Person() { Name = "123" });
            context.SaveChanges();

            return new string[] { "value1", "value2", context.Persons.Count().ToString() };
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
