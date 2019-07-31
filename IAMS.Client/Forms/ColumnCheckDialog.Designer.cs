namespace IAMS.Client.Forms
{
    partial class ColumnCheckDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColumnCheckList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ColumnCheckList
            // 
            this.ColumnCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnCheckList.CheckOnClick = true;
            this.ColumnCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnCheckList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColumnCheckList.FormattingEnabled = true;
            this.ColumnCheckList.Location = new System.Drawing.Point(0, 0);
            this.ColumnCheckList.Name = "ColumnCheckList";
            this.ColumnCheckList.Size = new System.Drawing.Size(260, 289);
            this.ColumnCheckList.TabIndex = 0;
            // 
            // ColumnCheckDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 289);
            this.Controls.Add(this.ColumnCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColumnCheckDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择字段";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ColumnCheckList;
    }
}