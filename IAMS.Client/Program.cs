using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAMS.Client.Forms;

namespace IAMS.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.ApplicationExit += Application_ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var launchResult = DialogResult.None;
            Form mainForm = null;
            using (var launcher = new LaunchForm())
            {
                launchResult = launcher.ShowDialog();
                mainForm = launcher.MainForm;
            }

            switch (launchResult)
            {
                case DialogResult.None:
                case DialogResult.OK:
                case DialogResult.Ignore:
                case DialogResult.Yes:
                    {
                        if (mainForm != null)
                        {
                            Application.Run(mainForm);
                        }
                        else
                        {
                            throw new ArgumentNullException("空的主窗体对象");
                        }

                        break;
                    }

                case DialogResult.Cancel:
                case DialogResult.Abort:
                case DialogResult.Retry:
                case DialogResult.No:
                    {
                        Environment.Exit(-1);

                        break;
                    }

                default:
                    break;
            }
        }

        /// <summary>
        /// 应用程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 应用程序异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                $"应用遇到未捕捉异常：\n{e.Exception.Message}",
                "应用遇到未捕捉异常",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// 当前域异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(
                $"当前应用域遇到未捕捉异常：\n{(e.ExceptionObject as Exception)?.Message}",
                "当前应用域遇到未捕捉异常",
                MessageBoxButtons.OK,
                e.IsTerminating ? MessageBoxIcon.Error : MessageBoxIcon.Warning);
        }
    }
}
