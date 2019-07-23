using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ModelController<Person>
    {
        public PersonController(DBContext context) : base(context)
        {
        }
    }
}