using System.Collections.Generic;
using System.Linq;
using IAMS.Data;
using IAMS.Model;
using Microsoft.EntityFrameworkCore;
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

        protected override IEnumerable<Person> CreateQueryPerdicate(IEnumerable<Person> enumerable, string key)
        {
            var pattern = $"%{key}%";
            return base.CreateQueryPerdicate(enumerable, key)
                .Where(model =>
                    EF.Functions.Like(model.Name, pattern) ||
                    EF.Functions.Like(model.IDNumber, pattern) ||
                    EF.Functions.Like(model.Department, pattern) ||
                    EF.Functions.Like(model.Job, pattern));
        }
    }
}