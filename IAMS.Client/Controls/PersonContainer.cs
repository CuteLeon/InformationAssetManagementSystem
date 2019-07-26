using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    public class PersonContainer : ModelContainer<Person>
    {
        protected override void InitGridViewColumns(DataGridView dataGridView)
        {
            base.InitGridViewColumns(dataGridView);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.Name), HeaderText = "姓名", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.Department), HeaderText = "部门", Frozen = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.Job), HeaderText = "职务", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.IDNumber), HeaderText = "身份证号", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.InnerNetComputerIP), HeaderText = "内网IP", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.InnerNetComputerNumber), HeaderText = "内网电脑编号", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.OuterNetComputerIP), HeaderText = "外网IP", });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = nameof(Person.OuterNetComputerNumber), HeaderText = "外网电脑编号", });
        }
    }
}
