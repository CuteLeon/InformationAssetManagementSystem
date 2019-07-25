using IAMS.Model;

namespace IAMS.Client.Controls
{
    /// <summary>
    /// 模型容器基类
    /// </summary>
    public partial class ModelContainerBase<TModel> : TabContainer
        where TModel : ModelBase
    {
        public ModelContainerBase()
        {
            this.InitializeComponent();
        }
    }
}
