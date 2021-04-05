namespace WindowsFileMananger
{
    partial class FileMananger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMananger));
            this.listView_Area = new System.Windows.Forms.ListView();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnGoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label_perious = new System.Windows.Forms.Label();
            this.label_next = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Area
            // 
            this.listView_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Area.AutoArrange = false;
            this.listView_Area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_Area.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Area.HideSelection = false;
            this.listView_Area.Location = new System.Drawing.Point(14, 56);
            this.listView_Area.Name = "listView_Area";
            this.listView_Area.Size = new System.Drawing.Size(1095, 652);
            this.listView_Area.TabIndex = 0;
            this.listView_Area.UseCompatibleStateImageBehavior = false;
            this.listView_Area.DoubleClick += new System.EventHandler(this.listView_Area_DoubleClick);
            this.listView_Area.MouseHover += new System.EventHandler(this.listView_Area_MouseHover);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFilePath.Location = new System.Drawing.Point(6, 6);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(917, 22);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Text = "d:\\";
            this.tbFilePath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFilePath_KeyDown);
            // 
            // btnGoto
            // 
            this.btnGoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoto.BackgroundImage = global::WindowsFileMananger.Properties.Resources.enter;
            this.btnGoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoto.FlatAppearance.BorderSize = 0;
            this.btnGoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoto.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoto.Location = new System.Drawing.Point(1051, 9);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(50, 35);
            this.btnGoto.TabIndex = 4;
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            this.btnGoto.MouseEnter += new System.EventHandler(this.btnGoto_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbFilePath, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(108, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 36);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::WindowsFileMananger.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(60, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::WindowsFileMananger.Properties.Resources.previous;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Location = new System.Drawing.Point(14, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 32);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            // 
            // label_perious
            // 
            this.label_perious.AutoSize = true;
            this.label_perious.Location = new System.Drawing.Point(134, 46);
            this.label_perious.Name = "label_perious";
            this.label_perious.Size = new System.Drawing.Size(0, 12);
            this.label_perious.TabIndex = 6;
            this.label_perious.Visible = false;
            // 
            // label_next
            // 
            this.label_next.AutoSize = true;
            this.label_next.Location = new System.Drawing.Point(294, 46);
            this.label_next.Name = "label_next";
            this.label_next.Size = new System.Drawing.Size(0, 12);
            this.label_next.TabIndex = 7;
            this.label_next.Visible = false;
            // 
            // FileMananger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 720);
            this.Controls.Add(this.label_next);
            this.Controls.Add(this.label_perious);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listView_Area);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileMananger";
            this.Text = "文件管理器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileMananger_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Area;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_perious;
        private System.Windows.Forms.Label label_next;
    }
}

