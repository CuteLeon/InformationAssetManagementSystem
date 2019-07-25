using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using IAMS.Model;

namespace IAMS.Client.Controls
{
    /// <summary>
    /// 模型容器基类
    /// </summary>
    public partial class ModelContainer<TModel> : TabContainer
        where TModel : ModelBase
    {
        protected Type ModelType = typeof(TModel);

        protected BindingSource ModelBindingSource = new BindingSource() { DataSource = typeof(TModel) };

        public ModelContainer()
        {
            this.InitializeComponent();

            if (this.DesignMode)
            {
                return;
            }

            this.InitGridView();
        }

        private void InitGridView()
        {
            this.MainDataGridView.AutoGenerateColumns = false;
            this.MainDataGridView.Columns.Clear();

            (this.MainDataGridView as ISupportInitialize)?.BeginInit();
            (this.ModelBindingSource as ISupportInitialize)?.BeginInit();
            this.SuspendLayout();

            foreach (var propery in this.ModelType.GetProperties()
                .Where(prop => prop.CanRead))
            {
                try
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = propery.Name,
                        Name = $"{propery.Name}DataGridViewColumn",
                    };

                    var attrs = propery.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    var first = attrs?.FirstOrDefault();
                    var text = (first as DisplayNameAttribute)?.DisplayName ?? propery.Name;

                    column.HeaderText = text;

                    this.MainDataGridView.Columns.Add(column);
                }
                catch
                {
                }
            }

            this.MainDataGridView.DataSource = this.ModelBindingSource;

            (this.MainDataGridView as ISupportInitialize)?.EndInit();
            (this.ModelBindingSource as ISupportInitialize)?.EndInit();
            this.ResumeLayout(false);
        }

        protected virtual void InitGridViewColumns(DataGridView dataGridView)
        {
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {

        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {

        }

        private void SelectAllButton_Click(object sender, System.EventArgs e)
        {

        }

        private void SelectNoneButton_Click(object sender, System.EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
