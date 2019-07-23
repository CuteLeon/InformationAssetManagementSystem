using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Common;
using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [ApiController]
    public class ModelController<TModel> : ControllerBase
        where TModel : ModelBase
    {
        /* 返回代码：
         * 创建成功：Status201Created
         * 操作成功：Status202Accepted
         * 
         * 无效的参数或未查找到实体：Status406NotAcceptable
         * 无效的数据或无法处理实体：Status422UnprocessableEntity
         * 遇到异常：Status417ExpectationFailed
         */

        /// <summary>
        /// 数据库交互
        /// </summary>
        protected readonly DBContext context;

        public ModelController(DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<string> Query()
        {
            var models = this.context.Set<TModel>().ToList();
            return models.Select(model => JsonConvertHelper.SerializeObject(model));
        }

        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return this.StatusCode(StatusCodes.Status406NotAcceptable);
            }
            try
            {
                var model = await this.context.Set<TModel>().FindAsync(id);
                if (model == null)
                {
                    return this.StatusCode(StatusCodes.Status406NotAcceptable);
                }
                else
                {
                    return this.Content(JsonConvertHelper.SerializeObject(model));
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
            }

            try
            {
                var model = JsonConvertHelper.DeserializeObject<TModel>(value);
                if (model == null)
                {
                    return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
                }

                await this.context.Set<TModel>().AddAsync(model);
                return this.StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Update(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
            }

            try
            {
                var model = JsonConvertHelper.DeserializeObject<TModel>(value);
                if (model == null)
                {
                    return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
                }

                this.context.Set<TModel>().Update(model);
                return this.StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return this.StatusCode(StatusCodes.Status406NotAcceptable);
            }
            try
            {
                var model = await this.context.Set<TModel>().FindAsync(id);
                if (model == null)
                {
                    return this.StatusCode(StatusCodes.Status406NotAcceptable);
                }

                _ = this.context.Set<TModel>().Remove(model);
                return this.StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
    }
}
