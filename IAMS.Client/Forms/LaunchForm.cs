using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAMS.Client.Utils;

namespace IAMS.Client.Forms
{
    public partial class LaunchForm : Form
    {
        public MainForm MainForm { get; protected set; }

        public LaunchForm()
        {
            this.InitializeComponent();

            this.Icon = AppResource.AppIcon;
        }

        private async void LaunchForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            DialogResult dialogResult = DialogResult.None;
            try
            {
                await this.LaunchApplication();

                dialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                dialogResult = DialogResult.Abort;
            }
            finally
            {
                this.DialogResult = dialogResult;
            }
        }

        /// <summary>
        /// 启动应用程序
        /// </summary>
        private async Task LaunchApplication()
        {
            this.MainForm = new MainForm();

            var address = ConfigHelper.WebAPIAddress;
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("Web API 地址为空！");
            }

            // 测试连接 并 获取会话秘钥
            const string apiAddress = "Connect/GetSessionKey";
            string key = await WebHelper.GetStringAsync($"{address}/{apiAddress}");
            WebHelper.SetSessionKey(key);

        }
    }
}
