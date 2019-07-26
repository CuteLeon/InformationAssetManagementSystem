using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Common;
using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
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

        /// <summary>
        /// 日志记录器
        /// </summary>
        protected readonly ILogger logger;

        public ModelController(DBContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        [HttpGet]
        public string Query(string key)
        {
            this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 请求查询所有 {typeof(TModel).Name} 数据，关键字 = {key}");

            var enumerable = this.context.Set<TModel>().AsEnumerable();
            enumerable = this.CreateQueryPerdicate(enumerable, key);

            var models = enumerable.ToList();

            return JsonConvertHelper.SerializeObject(models);
        }

        protected virtual IEnumerable<TModel> CreateQueryPerdicate(IEnumerable<TModel> enumerable, string key)
            => enumerable;

        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求查询空 ID 的 {typeof(TModel).Name} 数据");

                return this.StatusCode(StatusCodes.Status406NotAcceptable);
            }
            try
            {
                var model = await this.context.Set<TModel>().FindAsync(id);

                if (model == null)
                {
                    this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求查询 ID 不存在的 {typeof(TModel).Name} 数据");

                    return this.StatusCode(StatusCodes.Status406NotAcceptable);
                }
                else
                {
                    this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 请求查询 ID 为 {id} 的 {typeof(TModel).Name} 数据");

                    return this.Content(JsonConvertHelper.SerializeObject(model));
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"{this.HttpContext.Connection.RemoteIpAddress} 请求查询 ID 为 {id} 的 {typeof(TModel).Name} 数据遇到异常");

                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求新增空数据的 {typeof(TModel).Name} 对象");

                return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
            }

            try
            {
                var model = JsonConvertHelper.DeserializeObject<TModel>(value);
                if (model == null)
                {
                    this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求新增的数据转义为 {typeof(TModel).Name} 对象为空引用");

                    return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
                }

                await this.context.Set<TModel>().AddAsync(model);

                this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 请求新增 ID 为 {model.ID} 的 {typeof(TModel).Name} 对象");
                return this.StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"{this.HttpContext.Connection.RemoteIpAddress} 请求新增 {typeof(TModel).Name} 对象遇到异常");

                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Update(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求更新空数据的 {typeof(TModel).Name} 对象");

                return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
            }

            try
            {
                var model = JsonConvertHelper.DeserializeObject<TModel>(value);
                if (model == null)
                {
                    this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求更新的数据转义为 {typeof(TModel).Name} 对象为空引用");

                    return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
                }

                this.context.Set<TModel>().Update(model);

                this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 请求更新 ID 为 {model.ID} 的 {typeof(TModel).Name} 对象");
                return this.StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"{this.HttpContext.Connection.RemoteIpAddress} 请求更新 {typeof(TModel).Name} 对象遇到异常");

                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求删除空 ID 的 {typeof(TModel).Name} 数据");

                return this.StatusCode(StatusCodes.Status406NotAcceptable);
            }
            try
            {
                var model = await this.context.Set<TModel>().FindAsync(id);
                if (model == null)
                {
                    this.logger.LogWarning($"{this.HttpContext.Connection.RemoteIpAddress} 请求删除 ID 不存在的 {typeof(TModel).Name} 数据");

                    return this.StatusCode(StatusCodes.Status406NotAcceptable);
                }

                _ = this.context.Set<TModel>().Remove(model);

                this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 请求删除 ID 为 {id} 的 {typeof(TModel).Name} 数据");
                return this.StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"{this.HttpContext.Connection.RemoteIpAddress} 请求删除 ID 为 {id} 的 {typeof(TModel).Name} 数据遇到异常");

                return this.StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
    }
}
