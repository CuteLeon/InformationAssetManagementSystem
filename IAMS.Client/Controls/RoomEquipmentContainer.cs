using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    public class RoomEquipmentContainer : ModelContainer<RoomEquipment>
    {
        protected override void InitGridViewColumns(DataGridView dataGridView)
        {
            base.InitGridViewColumns(dataGridView);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.NameNumber), HeaderText = "设备名称", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.Model), HeaderText = "型号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.BuyDateTime), HeaderText = "购买日期", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.BuyPrice), HeaderText = "购买价格", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.Location), HeaderText = "所在位置", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.Admin), HeaderText = "管理员", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.User), HeaderText = "使用人", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(RoomEquipment.Use), HeaderText = "用途", });
        }
    }
}
