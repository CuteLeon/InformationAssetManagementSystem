using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DesktopComputerController : ModelController<DesktopComputer>
    {
        public DesktopComputerController(DBContext context) : base(context)
        {
        }
    }
}
