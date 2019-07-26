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

            LogHelper<MainForm>.Debug("主窗口显示完成");
        }

        #region 初始化界面

        public void InitUI()
        {
            this.InitTabs();
        }

        private void InitTabs()
        {
            LogHelper<MainForm>.Debug("初始化 Tab ...");
            this.TabButtonPanel.BackColor = Color.FromArgb(234, 232, 231);

            foreach (var (name, modelType, containerType) in new (string, Type, Type)[]
            {
                ("台式电脑", typeof(DesktopComputer), typeof(DesktopComputerContainer)),
                ("笔记本电脑", typeof(LaptopComputer), typeof(LaptopComputerContainer)),
                ("备用电脑", typeof(AuxiliaryComputer), typeof(AuxiliaryComputerContainer)),
                ("机房设备", typeof(RoomEquipment), typeof(RoomEquipmentContainer)),
                ("其他设备", typeof(OtherEquipment), typeof(OtherEquipmentContainer)),
                ("人员信息", typeof(Person), typeof(PersonContainer)),
            })
            {
                LogHelper<MainForm>.Debug($"Tab => {name} && {modelType.Name} && {containerType.Name}");

                var container = Activator.CreateInstance(containerType) as TabContainer;

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
            LogHelper<MainForm>.Debug("初始化 Tab 界面完成");
        }
        #endregion

        #region 切换容器

        private void TabButton_ActiveTabChanged(TabButton current, TabButton last)
        {
            LogHelper<MainForm>.Debug($"切换 Tab => {last?.Name} => {current.Name}");

            this.SuspendLayout();
            (current.Tag as TabContainer).Show();
            (last?.Tag as TabContainer)?.Hide();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
