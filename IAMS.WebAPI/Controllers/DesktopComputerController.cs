using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
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

        protected override IEnumerable<DesktopComputer> CreateQueryPerdicate(IEnumerable<DesktopComputer> enumerable, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return base.CreateQueryPerdicate(enumerable, key);
            }
            else
            {
                var pattern = $"%{key}%";
                return base.CreateQueryPerdicate(enumerable, key)
                    .Where(model =>
                        EF.Functions.Like(model.User, pattern) ||
                        EF.Functions.Like(model.Model, pattern) ||
                        EF.Functions.Like(model.NameNumber, pattern));
            }
        }
    }
}
