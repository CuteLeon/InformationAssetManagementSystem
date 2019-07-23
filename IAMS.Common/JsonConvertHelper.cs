using Newtonsoft.Json;

namespace IAMS.Common
{
    /// <summary>
    /// Json 转换助手
    /// </summary>
    public static class JsonConvertHelper
    {
        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SerializeObject(object value)
            => JsonConvert.SerializeObject(value);

        /// <summary>
        /// 反序列化 json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static object DeserializeObject<T>(string json)
            => JsonConvert.DeserializeObject<T>(json);
    }
}
