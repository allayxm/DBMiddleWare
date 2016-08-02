using System;
using System.Windows.Forms;
using MXKJ.DBMiddleWareLib;

namespace DBMiddleWareForm
{
    public partial class SqlServerSetupForm : Form
    {
        public SqlServerSetupForm()
        {
            InitializeComponent();
            comboBox_VerifyMode.SelectedIndex = 0;
        }

        string m_DataSource = string.Empty;
        string m_DBName = string.Empty;
        bool m_IntegratedSecurity = false;
        string m_User = string.Empty;
        string m_Password = string.Empty;

        public bool IsLocal { get; private set; }

        public string DataSource
        {
            get
            {
                return m_DataSource;
            }
        }

        public string DBName
        {
            get
            {
                return m_DBName;
            }
        }

        public bool IntegratedSecurity
        {
            get
            {
                return m_IntegratedSecurity;
            }
        }

        public string User
        {
            get
            {
                return m_User;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }
        }

        private void button_TestConn_Click(object sender, EventArgs e)
        {
            if (testConnection())
                MessageBox.Show("连测成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("连测失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool testConnection()
        {
            BasicDBClass.DataSource = textBox_Server.Text;
            BasicDBClass.DBName = textBox_DBName.Text;
            if (comboBox_VerifyMode.SelectedIndex == 0)
            {
                BasicDBClass.UserID = textBox_User.Text;
                BasicDBClass.Password = textBox_Password.Text;
            }
            else
            {
                BasicDBClass.IntegratedSecurity = true;
            }
            BasicDBClass vBasicDBClass = new BasicDBClass(DataBaseType.SqlServer);
            return vBasicDBClass.TestConnection();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                m_DataSource = textBox_Server.Text;
                m_DBName = textBox_DBName.Text;
                m_IntegratedSecurity = comboBox_VerifyMode.SelectedIndex == 0 ? false : true;
                m_User = textBox_User.Text;
                m_Password = textBox_Password.Text;
                IsLocal = checkBox_Local.Checked;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("连测失败，请重新设置参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBox_VerifyMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( comboBox_VerifyMode.SelectedIndex == 0 )
            {
                textBox_User.Enabled = true;
                textBox_Password.Enabled = true;
            }
            else
            {
                textBox_User.Enabled = false;
                textBox_Password.Enabled = false;
            }
        }

        private void checkBox_Local_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox_Local.Checked )
            {
                label_DBName.Text = "数据库文件:";
                textBox_Server.Text = @"(LocalDB)\MSSQLLocalDB";
                textBox_Server.ReadOnly = true;
                textBox_User.ReadOnly = true;
                textBox_Password.ReadOnly = true;
                comboBox_VerifyMode.Enabled = false;
                comboBox_VerifyMode.Text = "Windows验证";
            }
            else
            {
                label_DBName.Text = "数据库名称:";
                textBox_Server.Text = "";
                textBox_Server.ReadOnly = false;
                textBox_User.ReadOnly = false;
                textBox_Password.ReadOnly = false;
                comboBox_VerifyMode.Enabled = true;
            }
        }
    }
}
