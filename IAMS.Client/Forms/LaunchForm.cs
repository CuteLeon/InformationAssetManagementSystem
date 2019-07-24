using System;
using System.Net;
using System.Net.Http;
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

        private void LaunchForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            DialogResult dialogResult = DialogResult.None;
            try
            {
                this.LaunchApplication();

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
        private void LaunchApplication()
        {
            this.MainForm = new MainForm();

            var address = ConfigHelper.WebAPIAddress;
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("Web API 地址为空！");
            }

            // TODO: 使用 WebHelper 请求一个会话秘钥，顺便测试网络连通；
            // TODO: 客户端每次请求需要附带此秘钥，WebAPI 使用中间件验证此秘钥
        }
    }
}
