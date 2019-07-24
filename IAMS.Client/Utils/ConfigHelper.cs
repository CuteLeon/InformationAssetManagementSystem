using System.Configuration;
using System.Linq;

namespace IAMS.Client.Utils
{
    public static class ConfigHelper
    {
        /// <summary>
        /// Gets exe配置管理器
        /// </summary>
        public static Configuration ExeConfiguration { get; }

        /// <summary>
        /// 标题
        /// </summary>
        public static string Title { get; private set; }

        /// <summary>
        /// WebAPI 地址
        /// </summary>
        public static string WebAPIAddress { get; private set; }

        static ConfigHelper()
        {
            ExeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Title = ReadConfig("Title", "信息化资产管理系统");
            WebAPIAddress = ReadConfig("WebAPIAddress");
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string ReadConfig(string key, string defaultValue = "")
            => ExeConfiguration.AppSettings.Settings[key]?.Value ?? defaultValue;

        /// <summary>
        /// 写入配置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <remarks>
        /// Settings.Add(key, value) 如果已经存在此 key 的配置，将会把多个配置以逗号分隔，同时保存
        /// Settings[Key] = value 可以使 key 的配置为最后一次保存的唯一配置值，但如果不存在此 key 的配置时将会出现空引用错误
        /// </remarks>
        public static void WriteConfig(string key, string value)
        {
            if (ExeConfiguration.AppSettings.Settings.AllKeys.Contains(key))
            {
                ExeConfiguration.AppSettings.Settings[key].Value = value;
            }
            else
            {
                ExeConfiguration.AppSettings.Settings.Add(key, value);
            }

            ExeConfiguration.Save();
        }
    }
}
