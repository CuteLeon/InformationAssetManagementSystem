namespace IAMS.Model
{
    /// <summary>
    /// 电脑基类
    /// </summary>
    public abstract class ComputerBase : EquipmentBase
    {
        /// <summary>
        /// 处理器
        /// </summary>
        public string CPU { get; set; }

        /// <summary>
        /// 显卡
        /// </summary>
        public string GPU { get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// 硬盘
        /// </summary>
        public string Disk { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 固态硬盘序列号
        /// </summary>
        public string SSDSerialNumber { get; set; }

        /// <summary>
        /// 机械硬盘序列号
        /// </summary>
        public string MDSerialNumber { get; set; }
    }
}
