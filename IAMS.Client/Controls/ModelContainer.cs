using System;
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

        public ModelContainer()
        {
            this.InitializeComponent();
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
