using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    public class AuxiliaryComputerContainer : ModelContainer<AuxiliaryComputer>
    {
        protected override void InitGridViewColumns(DataGridView dataGridView)
        {
            base.InitGridViewColumns(dataGridView);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.ID), HeaderText = "ID", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.NameNumber), HeaderText = "编号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Model), HeaderText = "型号", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.BorrowDateTime), HeaderText = "借用日期", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Borrower), HeaderText = "借用人", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.ReturnDateTime), HeaderText = "归还日期", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Returner), HeaderText = "归还人", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.CPU), HeaderText = "CPU", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.GPU), HeaderText = "GPU", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Memory), HeaderText = "内存", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Disk), HeaderText = "硬盘", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.MDSerialNumber), HeaderText = "机械硬盘序列号", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.SSDSerialNumber), HeaderText = "固态硬盘序列号", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.WiredMAC), HeaderText = "有线MAC", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.WirelessMAC), HeaderText = "无线MAC", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.BuyDateTime), HeaderText = "购买日期", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.BuyPrice), HeaderText = "购买价格", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Size), HeaderText = "尺寸", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Admin), HeaderText = "管理员", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(AuxiliaryComputer.Use), HeaderText = "用途", });
        }
    }
}
