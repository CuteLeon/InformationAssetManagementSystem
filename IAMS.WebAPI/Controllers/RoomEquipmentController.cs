using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    public class RoomEquipmentController : ModelController<RoomEquipment>
    {
        public RoomEquipmentController(
            DBContext context,
            ILogger<RoomEquipmentController> logger)
            : base(context, logger)
        {
        }

        protected override IEnumerable<RoomEquipment> CreateQueryPerdicate(IEnumerable<RoomEquipment> enumerable, string key)
        {
            var pattern = $"%{key}%";
            return base.CreateQueryPerdicate(enumerable, key)
                .Where(model =>
                    EF.Functions.Like(model.Location, pattern) ||
                    EF.Functions.Like(model.Model, pattern) ||
                    EF.Functions.Like(model.NameNumber, pattern));
        }
    }
}
