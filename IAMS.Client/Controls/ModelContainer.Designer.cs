using IAMS.Model;

namespace IAMS.Client.Controls
{
    partial class ModelContainer<TModel>
        where TModel : ModelBase
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.SelectNoneButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 8;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainLayoutPanel.Controls.Add(this.SelectAllButton, 2, 0);
            this.MainLayoutPanel.Controls.Add(this.SelectNoneButton, 3, 0);
            this.MainLayoutPanel.Controls.Add(this.ExportButton, 4, 0);
            this.MainLayoutPanel.Controls.Add(this.DeleteButton, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.SearchButton, 7, 0);
            this.MainLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.SearchTextBox, 6, 0);
            this.MainLayoutPanel.Controls.Add(this.MainDataGridView, 0, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(748, 502);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.AutoEllipsis = true;
            this.SelectAllButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SelectAllButton.FlatAppearance.BorderSize = 2;
            this.SelectAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SelectAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SelectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectAllButton.Location = new System.Drawing.Point(163, 3);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(74, 29);
            this.SelectAllButton.TabIndex = 14;
            this.SelectAllButton.Text = "全选";
            this.SelectAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectAllButton.UseVisualStyleBackColor = false;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // SelectNoneButton
            // 
            this.SelectNoneButton.AutoEllipsis = true;
            this.SelectNoneButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectNoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectNoneButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SelectNoneButton.FlatAppearance.BorderSize = 2;
            this.SelectNoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SelectNoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SelectNoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectNoneButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectNoneButton.Location = new System.Drawing.Point(243, 3);
            this.SelectNoneButton.Name = "SelectNoneButton";
            this.SelectNoneButton.Size = new System.Drawing.Size(74, 29);
            this.SelectNoneButton.TabIndex = 13;
            this.SelectNoneButton.Text = "取消";
            this.SelectNoneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectNoneButton.UseVisualStyleBackColor = false;
            this.SelectNoneButton.Click += new System.EventHandler(this.SelectNoneButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.AutoEllipsis = true;
            this.ExportButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ExportButton.FlatAppearance.BorderSize = 2;
            this.ExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportButton.Location = new System.Drawing.Point(323, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(74, 29);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.Text = "导出";
            this.ExportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoEllipsis = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteButton.Location = new System.Drawing.Point(83, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(74, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoEllipsis = true;
            this.SearchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.Location = new System.Drawing.Point(671, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(74, 29);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "搜索";
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoEllipsis = true;
            this.AddButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 29);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "新增";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(471, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(194, 22);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToOrderColumns = true;
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainLayoutPanel.SetColumnSpan(this.MainDataGridView, 8);
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 35);
            this.MainDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowTemplate.Height = 23;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(748, 467);
            this.MainDataGridView.TabIndex = 15;
            // 
            // ModelContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "ModelContainer";
            this.Size = new System.Drawing.Size(748, 502);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button SelectNoneButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView MainDataGridView;
    }
}
