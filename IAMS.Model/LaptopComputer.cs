namespace IAMS.Model
{
    /// <summary>
    /// 笔记本电脑
    /// </summary>
    public class LaptopComputer : ComputerBase
    {
        /// <summary>
        /// 有线 MAC 地址
        /// </summary>
        public string WiredMAC { get; set; }

        /// <summary>
        /// 无线 MAC 地址
        /// </summary>
        public string WirelessMAC { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public string User { get; set; }
    }
}
