using System;

namespace IAMS.Model
{
    /// <summary>
    /// 备用电脑
    /// </summary>
    public class AuxiliaryComputer : ComputerBase
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
        /// 借用人
        /// </summary>
        public string Borrower { get; set; }

        /// <summary>
        /// 借用日期
        /// </summary>
        public DateTime BorrowDateTime { get; set; }

        /// <summary>
        /// 归还人
        /// </summary>
        public string Returner { get; set; }

        /// <summary>
        /// 归还日期
        /// </summary>
        public DateTime ReturnDateTime { get; set; }
    }
}
