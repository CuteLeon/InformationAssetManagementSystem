using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    public class DesktopComputerContainer : ModelContainer<DesktopComputer>
    {
        protected override void InitGridViewColumns(DataGridView dataGridView)
        {
            base.InitGridViewColumns(dataGridView);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.NameNumber), HeaderText = "编号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Model), HeaderText = "型号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.BuyDateTime), HeaderText = "购买日期", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.BuyPrice), HeaderText = "购买价格", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.CPU), HeaderText = "CPU", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.GPU), HeaderText = "显卡", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Memory), HeaderText = "内存", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Disk), HeaderText = "硬盘", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Size), HeaderText = "尺寸", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.SSDSerialNumber), HeaderText = "硬盘序列号-固态", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.MDSerialNumber), HeaderText = "硬盘序列号-机械", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.MAC), HeaderText = "MAC", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Admin), HeaderText = "管理员", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.User), HeaderText = "使用人" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(DesktopComputer.Use), HeaderText = "用途", });
        }
    }
}
