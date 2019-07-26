using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class LaptopComputerController : ModelController<LaptopComputer>
    {
        public LaptopComputerController(
            DBContext context,
            ILogger<LaptopComputerController> logger)
            : base(context, logger)
        {
        }

        protected override IEnumerable<LaptopComputer> CreateQueryPerdicate(IEnumerable<LaptopComputer> enumerable, string key)
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
