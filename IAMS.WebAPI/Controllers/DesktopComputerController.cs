using IAMS.Data;
using IAMS.Model;

namespace IAMS.WebAPI.Controllers
{
    public class DesktopComputerController : ModelController<DesktopComputer>
    {
        public DesktopComputerController(DBContext context) : base(context)
        {
        }
    }
}
