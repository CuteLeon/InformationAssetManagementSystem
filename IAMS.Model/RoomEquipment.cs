namespace IAMS.Model
{
    /// <summary>
    /// 机房设备
    /// </summary>
    public class RoomEquipment : EquipmentBase
    {
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public string User { get; set; }
    }
}
