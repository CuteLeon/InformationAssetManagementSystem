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

            foreach (var (name, type) in new (string, Type)[]
            {
                ("台式电脑", typeof(DesktopComputer)),
                ("笔记本电脑", typeof(LaptopComputer)),
                ("备用电脑", typeof(AuxiliaryComputer)),
                ("机房设备", typeof(RoomEquipment)),
                ("其他设备", typeof(OtherEquipment)),
                ("人员信息", typeof(Person)),
            })
            {
                var tabButton = new TabButton()
                {
                    Name = $"Tab_{type.Name}",
                    Text = name,
                    Width = this.TabButtonPanel.Width,
                    Height = 50,
                };

                tabButton.ActiveTabChanged += (s, l) => { Console.WriteLine($"当前：{(s as Control).Name}，Last：{l?.Name}"); };

                this.TabButtonPanel.Controls.Add(tabButton);
            }

            ((this.TabButtonPanel.Controls.Count > 0) ? (this.TabButtonPanel.Controls[0] as TabButton) : null)?.TabActive();
        }
        #endregion
    }
}
