using IAMS.Model;

namespace IAMS.Client.Controls
{
    /// <summary>
    /// 模型容器基类
    /// </summary>
    public partial class ModelContainer<TModel> : TabContainer
        where TModel : ModelBase
    {
        public ModelContainer()
        {
            this.InitializeComponent();
        }
    }
}
