namespace DBMiddleWareForm
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
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Mark = new System.Windows.Forms.Button();
            this.treeView_DB = new System.Windows.Forms.TreeView();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.测试ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(769, 32);
            this.menuStrip_Main.TabIndex = 4;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接数据库ToolStripMenuItem,
            this.关闭数据库ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 连接数据库ToolStripMenuItem
            // 
            this.连接数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlServerToolStripMenuItem,
            this.accessToolStripMenuItem,
            this.mySqlToolStripMenuItem,
            this.oracleToolStripMenuItem});
            this.连接数据库ToolStripMenuItem.Name = "连接数据库ToolStripMenuItem";
            this.连接数据库ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.连接数据库ToolStripMenuItem.Text = "连接数据库";
            // 
            // sqlServerToolStripMenuItem
            // 
            this.sqlServerToolStripMenuItem.Name = "sqlServerToolStripMenuItem";
            this.sqlServerToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.sqlServerToolStripMenuItem.Text = "SqlServer";
            this.sqlServerToolStripMenuItem.Click += new System.EventHandler(this.sqlServerToolStripMenuItem_Click);
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.accessToolStripMenuItem.Text = "Access";
            this.accessToolStripMenuItem.Click += new System.EventHandler(this.accessToolStripMenuItem_Click);
            // 
            // mySqlToolStripMenuItem
            // 
            this.mySqlToolStripMenuItem.Name = "mySqlToolStripMenuItem";
            this.mySqlToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.mySqlToolStripMenuItem.Text = "MySql";
            this.mySqlToolStripMenuItem.Click += new System.EventHandler(this.mySqlToolStripMenuItem_Click);
            // 
            // oracleToolStripMenuItem
            // 
            this.oracleToolStripMenuItem.Name = "oracleToolStripMenuItem";
            this.oracleToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.oracleToolStripMenuItem.Text = "Oracle";
            this.oracleToolStripMenuItem.Click += new System.EventHandler(this.oracleToolStripMenuItem_Click);
            // 
            // 关闭数据库ToolStripMenuItem
            // 
            this.关闭数据库ToolStripMenuItem.Name = "关闭数据库ToolStripMenuItem";
            this.关闭数据库ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.关闭数据库ToolStripMenuItem.Text = "关闭数据库";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试对话框ToolStripMenuItem});
            this.测试ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.测试ToolStripMenuItem.Text = "测试";
            // 
            // 测试对话框ToolStripMenuItem
            // 
            this.测试对话框ToolStripMenuItem.Name = "测试对话框ToolStripMenuItem";
            this.测试对话框ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.测试对话框ToolStripMenuItem.Text = "测试对话框";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Clear);
            this.splitContainer1.Panel1.Controls.Add(this.button_Mark);
            this.splitContainer1.Panel1.Controls.Add(this.treeView_DB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_Out);
            this.splitContainer1.Size = new System.Drawing.Size(769, 480);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 7;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Clear.Location = new System.Drawing.Point(146, 441);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(87, 34);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "清　除";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_Mark
            // 
            this.button_Mark.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Mark.Location = new System.Drawing.Point(25, 441);
            this.button_Mark.Name = "button_Mark";
            this.button_Mark.Size = new System.Drawing.Size(87, 34);
            this.button_Mark.TabIndex = 2;
            this.button_Mark.Text = "生　成";
            this.button_Mark.UseVisualStyleBackColor = true;
            this.button_Mark.Click += new System.EventHandler(this.button_Mark_Click);
            // 
            // treeView_DB
            // 
            this.treeView_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_DB.CheckBoxes = true;
            this.treeView_DB.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView_DB.Location = new System.Drawing.Point(0, 0);
            this.treeView_DB.Name = "treeView_DB";
            this.treeView_DB.Size = new System.Drawing.Size(255, 436);
            this.treeView_DB.TabIndex = 1;
            this.treeView_DB.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_DB_AfterCheck);
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Out.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.Size = new System.Drawing.Size(510, 480);
            this.richTextBox_Out.TabIndex = 0;
            this.richTextBox_Out.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 512);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.Text = "实体类生成工具";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试对话框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oracleToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_DB;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.Button button_Mark;
        private System.Windows.Forms.Button button_Clear;
    }
}

