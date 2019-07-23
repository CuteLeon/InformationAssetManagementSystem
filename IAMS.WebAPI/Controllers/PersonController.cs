using IAMS.Data;
using IAMS.Model;

namespace IAMS.WebAPI.Controllers
{
    public class PersonController : ModelController<Person>
    {
        public PersonController(DBContext context) : base(context)
        {
        }
    }
}