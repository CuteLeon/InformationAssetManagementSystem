using System;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ConnectController : ControllerBase
    {
        /// <summary>
        /// 获取会话秘钥
        /// </summary>
        /// <returns></returns>
        public string GetSessionKey()
        {
            var key = Guid.NewGuid().ToString("N");

            return key;
        }
    }
}