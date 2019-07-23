namespace IAMS.Model
{
    /// <summary>
    /// 台式电脑
    /// </summary>
    public class DesktopComputer : ComputerBase
    {
        /// <summary>
        /// MAC 地址
        /// </summary>
        public string MAC { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public string User { get; set; }
    }
}
