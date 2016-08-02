namespace DBMiddleWareForm
{
    partial class SqlServerSetupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_VerifyMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_DBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_DBName = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_TestConn = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_Local = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Local);
            this.groupBox1.Controls.Add(this.comboBox_VerifyMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_User);
            this.groupBox1.Controls.Add(this.textBox_DBName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_DBName);
            this.groupBox1.Controls.Add(this.textBox_Server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接参数";
            // 
            // comboBox_VerifyMode
            // 
            this.comboBox_VerifyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VerifyMode.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_VerifyMode.FormattingEnabled = true;
            this.comboBox_VerifyMode.Items.AddRange(new object[] {
            "Sql Server验证",
            "Windows验证"});
            this.comboBox_VerifyMode.Location = new System.Drawing.Point(173, 161);
            this.comboBox_VerifyMode.Name = "comboBox_VerifyMode";
            this.comboBox_VerifyMode.Size = new System.Drawing.Size(211, 25);
            this.comboBox_VerifyMode.TabIndex = 9;
            this.comboBox_VerifyMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_VerifyMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(77, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "验证模式:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Password.Location = new System.Drawing.Point(172, 263);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(212, 27);
            this.textBox_Password.TabIndex = 7;
            // 
            // textBox_User
            // 
            this.textBox_User.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_User.Location = new System.Drawing.Point(172, 212);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(212, 27);
            this.textBox_User.TabIndex = 6;
            // 
            // textBox_DBName
            // 
            this.textBox_DBName.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DBName.Location = new System.Drawing.Point(172, 109);
            this.textBox_DBName.Name = "textBox_DBName";
            this.textBox_DBName.Size = new System.Drawing.Size(212, 27);
            this.textBox_DBName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(113, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(95, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名:";
            // 
            // label_DBName
            // 
            this.label_DBName.AutoSize = true;
            this.label_DBName.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DBName.Location = new System.Drawing.Point(59, 113);
            this.label_DBName.Name = "label_DBName";
            this.label_DBName.Size = new System.Drawing.Size(107, 18);
            this.label_DBName.TabIndex = 2;
            this.label_DBName.Text = "数据库名称:";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Server.Location = new System.Drawing.Point(172, 59);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(212, 27);
            this.textBox_Server.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机名或IP地址:";
            // 
            // button_TestConn
            // 
            this.button_TestConn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TestConn.Location = new System.Drawing.Point(12, 323);
            this.button_TestConn.Name = "button_TestConn";
            this.button_TestConn.Size = new System.Drawing.Size(114, 36);
            this.button_TestConn.TabIndex = 1;
            this.button_TestConn.Text = "测试连接";
            this.button_TestConn.UseVisualStyleBackColor = true;
            this.button_TestConn.Click += new System.EventHandler(this.button_TestConn_Click);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OK.Location = new System.Drawing.Point(194, 323);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(114, 36);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确　定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancel.Location = new System.Drawing.Point(320, 323);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(114, 36);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取　消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox_Local
            // 
            this.checkBox_Local.AutoSize = true;
            this.checkBox_Local.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Local.Location = new System.Drawing.Point(36, 20);
            this.checkBox_Local.Name = "checkBox_Local";
            this.checkBox_Local.Size = new System.Drawing.Size(117, 22);
            this.checkBox_Local.TabIndex = 10;
            this.checkBox_Local.Text = "本地数据库";
            this.checkBox_Local.UseVisualStyleBackColor = true;
            this.checkBox_Local.CheckedChanged += new System.EventHandler(this.checkBox_Local_CheckedChanged);
            // 
            // SqlServerSetupFormForm
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(446, 377);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_TestConn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SqlServerSetupFormForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlServer数据库设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_DBName;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_DBName;
        private System.Windows.Forms.Button button_TestConn;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_VerifyMode;
        private System.Windows.Forms.CheckBox checkBox_Local;
    }
}