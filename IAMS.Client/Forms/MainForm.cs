using System;
using System.Drawing;
using System.Windows.Forms;
using IAMS.Client.Controls;
using IAMS.Client.Utils;
using IAMS.Model;

namespace IAMS.Client.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.Icon = AppResource.AppIcon;
            this.Text = ConfigHelper.Title;
            this.InitializeComponent();
        }

        private void MainForm_Shown(object sender, System.EventArgs e)
        {
            Application.DoEvents();

            this.IniTabs();
        }

        #region 初始化界面

        private void IniTabs()
        {
            this.TabButtonPanel.BackColor = Color.FromArgb(234, 232, 231);

            foreach (var (name, modelType, containerType) in new (string, Type, Type)[]
            {
                ("台式电脑", typeof(DesktopComputer), typeof(ModelContainerBase)),
                ("笔记本电脑", typeof(LaptopComputer), typeof(ModelContainerBase)),
                ("备用电脑", typeof(AuxiliaryComputer), typeof(ModelContainerBase)),
                ("机房设备", typeof(RoomEquipment), typeof(ModelContainerBase)),
                ("其他设备", typeof(OtherEquipment), typeof(ModelContainerBase)),
                ("人员信息", typeof(Person), typeof(ModelContainerBase)),
            })
            {
                var container = Activator.CreateInstance(containerType) as ModelContainerBase;

                #region 初始化
                System.Threading.Thread.Sleep(100);
                var random = new Random();
                container.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                #endregion

                container.Dock = DockStyle.Fill;
                container.Visible = false;
                this.ContainerPanel.Controls.Add(container);

                var tabButton = new TabButton()
                {
                    Name = $"Tab_{modelType.Name}",
                    Text = name,
                    Width = this.TabButtonPanel.Width,
                    Height = 50,

                    Tag = container,
                };

                tabButton.ActiveTabChanged += this.TabButton_ActiveTabChanged;

                this.TabButtonPanel.Controls.Add(tabButton);
            }

            ((this.TabButtonPanel.Controls.Count > 0) ? (this.TabButtonPanel.Controls[0] as TabButton) : null)?.TabActive();
        }
        #endregion

        #region 切换容器

        private void TabButton_ActiveTabChanged(TabButton current, TabButton last)
        {
            (last?.Tag as ModelContainerBase)?.Hide();
            (current.Tag as ModelContainerBase).Show();
        }
        #endregion
    }
}
