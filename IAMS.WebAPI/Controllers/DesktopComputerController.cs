using IAMS.Data;
using IAMS.Model;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class DesktopComputerController : ModelController<DesktopComputer>
    {
        public DesktopComputerController(
            DBContext context,
            ILogger<DesktopComputerController> logger)
            : base(context, logger)
        {
        }
    }
}
