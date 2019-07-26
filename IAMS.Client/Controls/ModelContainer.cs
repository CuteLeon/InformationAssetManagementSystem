using System;
using System.ComponentModel;
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

            this.MainDataGridView.DataSource = this.ModelBindingSource;

            this.InitGridViewColumns(this.MainDataGridView);

            (this.MainDataGridView as ISupportInitialize)?.EndInit();
            (this.ModelBindingSource as ISupportInitialize)?.EndInit();
            this.ResumeLayout(false);
        }

        protected virtual void InitGridViewColumns(DataGridView dataGridView)
        {
            var checkColumn = new DataGridViewCheckBoxColumn()
            {
                Frozen = true,
                ReadOnly = false,
            };
            this.MainDataGridView.Columns.Add(checkColumn);
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
