using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ConnectController : ControllerBase
    {
        private readonly ILogger<ConnectController> logger;

        public ConnectController(ILogger<ConnectController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// 获取会话秘钥
        /// </summary>
        /// <returns></returns>
        public string GetSessionKey()
        {
            var key = Guid.NewGuid().ToString("N");

            this.logger.LogDebug($"{this.HttpContext.Connection.RemoteIpAddress} 获取会话秘钥：{key}");
            return key;
        }
    }
}