using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    public class LaptopComputerContainer : ModelContainer<LaptopComputer>
    {
        protected override void InitGridViewColumns(DataGridView dataGridView)
        {
            base.InitGridViewColumns(dataGridView);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.NameNumber), HeaderText = "编号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Model), HeaderText = "型号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.BuyDateTime), HeaderText = "购买日期", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.BuyPrice), HeaderText = "购买价格", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.CPU), HeaderText = "CPU", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.GPU), HeaderText = "显卡", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Memory), HeaderText = "内存", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Disk), HeaderText = "硬盘", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Size), HeaderText = "尺寸", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.SSDSerialNumber), HeaderText = "硬盘序列号-固态", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.MDSerialNumber), HeaderText = "硬盘序列号-机械", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.WiredMAC), HeaderText = "有线MAC", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.WirelessMAC), HeaderText = "无线MAC", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Admin), HeaderText = "管理员", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.User), HeaderText = "使用人" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(LaptopComputer.Use), HeaderText = "用途", });
        }
    }
}
