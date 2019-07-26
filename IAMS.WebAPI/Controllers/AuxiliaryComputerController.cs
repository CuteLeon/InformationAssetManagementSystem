using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class AuxiliaryComputerController : ModelController<AuxiliaryComputer>
    {
        public AuxiliaryComputerController(
            DBContext context,
            ILogger<AuxiliaryComputerController> logger)
            : base(context, logger)
        {
        }

        protected override IEnumerable<AuxiliaryComputer> CreateQueryPerdicate(IEnumerable<AuxiliaryComputer> enumerable, string key)
        {
            var pattern = $"%{key}%";
            return base.CreateQueryPerdicate(enumerable, key)
                .Where(model =>
                    EF.Functions.Like(model.Borrower, pattern) ||
                    EF.Functions.Like(model.Model, pattern) ||
                    EF.Functions.Like(model.NameNumber, pattern));
        }
    }
}
