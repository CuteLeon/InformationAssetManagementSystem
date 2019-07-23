using System;

namespace IAMS.Model
{
    /// <summary>
    /// 设备基类
    /// </summary>
    public abstract class EquipmentBase : ModelBase
    {
        /// <summary>
        /// 名称/编号
        /// </summary>
        public string NameNumber { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime BuyDateTime { get; set; }

        /// <summary>
        /// 购买价格
        /// </summary>
        public double BuyPrice { get; set; }

        /// <summary>
        /// 管理员
        /// </summary>
        public string Admin { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public string Use { get; set; }
    }
}
