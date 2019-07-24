using System;
using System.Drawing;
using System.Windows.Forms;

namespace IAMS.Client.Controls
{
    /// <summary>
    /// 选项按钮
    /// </summary>
    public class TabButton : Label
    {
        /// <summary>
        /// 选项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="lastActiveTab"></param>
        public delegate void TabEventHandler(object sender, TabButton lastActiveTab);

        /// <summary>
        /// 激活选项按钮
        /// </summary>
        private static TabButton activeTabButton = null;

        public TabButton()
            : base()
        {
            this.AutoEllipsis = true;
            this.BackColor = Color.FromArgb(234, 232, 231);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.Margin = Padding.Empty;
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }

        public event TabEventHandler ActiveTabChanged;

        #region 激活及样式

        /// <summary>
        /// 激活
        /// </summary>
        public void TabActive()
        {
            var lastActive = activeTabButton;

            if (activeTabButton == this)
            {
                return;
            }

            if (activeTabButton != null)
            {
                activeTabButton.Deactivate();
            }

            activeTabButton = this;
            this.Activate();

            this.ActiveTabChanged?.Invoke(this, lastActive);
        }

        /// <summary>
        /// 是否为激活选项
        /// </summary>
        /// <returns></returns>
        public bool IsActiveTab()
            => activeTabButton == this;

        /// <summary>
        /// 高亮状态
        /// </summary>
        protected virtual void HighLight()
        {
            this.BackColor = Color.FromArgb(222, 220, 219);
        }

        /// <summary>
        /// 激活状态
        /// </summary>
        protected virtual void Activate()
        {
            this.BackColor = Color.FromArgb(195, 196, 197);
        }

        /// <summary>
        /// 失活状态
        /// </summary>
        protected virtual void Deactivate()
        {
            this.BackColor = Color.FromArgb(234, 232, 231);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (this.IsActiveTab()) this.Activate(); else this.HighLight();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.IsActiveTab()) this.Activate(); else this.Deactivate();

            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.TabActive();
            base.OnMouseDown(e);
        }
        #endregion
    }
}
