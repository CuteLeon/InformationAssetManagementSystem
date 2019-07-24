using IAMS.Data;
using IAMS.Model;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class PersonController : ModelController<Person>
    {
        public PersonController(
            DBContext context,
            ILogger<PersonController> logger)
            : base(context, logger)
        {
        }
    }
}