using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [ApiController]
    public class ModelController<TModel> : ControllerBase
        where TModel : ModelBase
    {
        /// <summary>
        /// 数据库交互
        /// </summary>
        protected readonly DBContext context;

        public ModelController(DBContext context)
        {
            this.context = context;
        }

        public ActionResult<string> Get(int id)
        {
            return $"value {typeof(TModel).FullName}";
        }
    }
}
