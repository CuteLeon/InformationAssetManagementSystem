namespace IAMS.Client.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TabButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TabButtonPanel
            // 
            this.TabButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.TabButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TabButtonPanel.Name = "TabButtonPanel";
            this.TabButtonPanel.Size = new System.Drawing.Size(200, 561);
            this.TabButtonPanel.TabIndex = 0;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(200, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(684, 561);
            this.ContainerPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.TabButtonPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TabButtonPanel;
        private System.Windows.Forms.Panel ContainerPanel;
    }
}

