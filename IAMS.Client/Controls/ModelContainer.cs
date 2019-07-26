using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAMS.Client.Utils;
using IAMS.Common;
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

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string key = this.SearchTextBox.Text.Trim();

            try
            {
                this.ModelBindingSource.DataSource = await this.Query(key);
            }
            catch (Exception ex)
            {
                LogHelper<ModelContainer<TModel>>.ErrorException(ex, "查询数据遇到异常：");

                MessageBox.Show($"查询数据遇到异常：\n{ex.Message}", "查询失败，请重试", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual async Task<List<TModel>> Query(string key = "")
        {
            string queryUri = $"{ConfigHelper.WebAPIAddress}/{this.ModelType.Name}/Query?key={key}";
            LogHelper<ModelContainer<TModel>>.Debug($"查询地址：{queryUri}");

            try
            {
                using (var response = await WebHelper.GetAsync(queryUri))
                {
                    LogHelper<ModelContainer<TModel>>.Debug($"接收到响应数据，状态代码：{response.StatusCode}");

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var models = JsonConvertHelper.DeserializeObject<List<TModel>>(content);
                        return models;
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectNoneButton_Click(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
