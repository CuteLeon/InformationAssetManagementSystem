using System.Windows.Forms;

namespace IAMS.Client.Controls
{
    /// <summary>
    /// 选项容器
    /// </summary>
    public partial class TabContainer : UserControl
    {
        public TabContainer()
        {
            this.InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }
    }
}
