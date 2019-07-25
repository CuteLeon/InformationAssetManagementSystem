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
            LogHelper<MainForm>.Debug("创建主窗口 ...");

            this.Icon = AppResource.AppIcon;
            this.Text = ConfigHelper.Title;
            this.InitializeComponent();

            LogHelper<MainForm>.Debug("主窗口创建完成");
        }

        private void MainForm_Shown(object sender, System.EventArgs e)
        {
            LogHelper<MainForm>.Debug("显示主窗口 ...");
            Application.DoEvents();

            this.IniTabs();

            LogHelper<MainForm>.Debug("主窗口显示完成");
        }

        #region 初始化界面

        private void IniTabs()
        {
            LogHelper<MainForm>.Debug("初始化 Tab 界面 ...");
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
                LogHelper<MainForm>.Debug($"Tab => {name} && {modelType.Name} && {containerType.Name}");

                var container = Activator.CreateInstance(containerType) as ModelContainerBase;

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

                LogHelper<MainForm>.Debug("初始化 Tab 界面完成");
            }

            ((this.TabButtonPanel.Controls.Count > 0) ? (this.TabButtonPanel.Controls[0] as TabButton) : null)?.TabActive();
        }
        #endregion

        #region 切换容器

        private void TabButton_ActiveTabChanged(TabButton current, TabButton last)
        {
            LogHelper<MainForm>.Debug($"切换 Tab => {last?.Name} => {current.Name}");

            (last?.Tag as ModelContainerBase)?.Hide();
            (current.Tag as ModelContainerBase).Show();
        }
        #endregion
    }
}
