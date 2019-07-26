using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class OtherEquipmentController : ModelController<OtherEquipment>
    {
        public OtherEquipmentController(
            DBContext context,
            ILogger<OtherEquipmentController> logger)
            : base(context, logger)
        {
        }

        protected override IEnumerable<OtherEquipment> CreateQueryPerdicate(IEnumerable<OtherEquipment> enumerable, string key)
        {
            var pattern = $"%{key}%";
            return base.CreateQueryPerdicate(enumerable, key)
                .Where(model =>
                    EF.Functions.Like(model.Use, pattern) ||
                    EF.Functions.Like(model.Model, pattern) ||
                    EF.Functions.Like(model.NameNumber, pattern));
        }
    }
}
