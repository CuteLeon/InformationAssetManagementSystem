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

            foreach (var (name, type, container) in new (string, Type, Type)[]
            {
                ("台式电脑", typeof(DesktopComputer), typeof(ModelContainerBase)),
                ("笔记本电脑", typeof(LaptopComputer), typeof(ModelContainerBase)),
                ("备用电脑", typeof(AuxiliaryComputer), typeof(ModelContainerBase)),
                ("机房设备", typeof(RoomEquipment), typeof(ModelContainerBase)),
                ("其他设备", typeof(OtherEquipment), typeof(ModelContainerBase)),
                ("人员信息", typeof(Person), typeof(ModelContainerBase)),
            })
            {
                var tabButton = new TabButton()
                {
                    Name = $"Tab_{type.Name}",
                    Text = name,
                    Width = this.TabButtonPanel.Width,
                    Height = 50,
                };

                System.Threading.Thread.Sleep(100);
                var containerInstance = Activator.CreateInstance(container) as ModelContainerBase;
                var random = new Random();
                containerInstance.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                containerInstance.Hide();
                containerInstance.Left = random.Next(500);
                containerInstance.Top = random.Next(500);
                tabButton.Tag = containerInstance;
                this.ContainerPanel.Controls.Add(containerInstance);
                tabButton.ActiveTabChanged += (s, l) =>
                {
                    (l?.Tag as ModelContainerBase)?.Hide();
                    (s.Tag as ModelContainerBase).Show();
                };
                this.TabButtonPanel.Controls.Add(tabButton);
            }

            ((this.TabButtonPanel.Controls.Count > 0) ? (this.TabButtonPanel.Controls[0] as TabButton) : null)?.TabActive();
        }
        #endregion
    }
}
