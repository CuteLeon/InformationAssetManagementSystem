namespace IAMS.Model
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person : ModelBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// 外网电脑编号
        /// </summary>
        public string OuterNetComputerNumber { get; set; }

        /// <summary>
        /// 外网电脑IP
        /// </summary>
        public string OuterNetComputerIP { get; set; }

        /// <summary>
        /// 内网电脑编号
        /// </summary>
        public string InnerNetComputerNumber { get; set; }

        /// <summary>
        /// 内网电脑IP
        /// </summary>
        public string InnerNetComputerIP { get; set; }
    }
}
