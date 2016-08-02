using System;
using System.Windows.Forms;
using MXKJ.DBMiddleWareLib;

namespace DBMiddleWareForm
{
    public partial class MySqlSetupForm : Form
    {
        public string DataSource { get; set; }
        public string DBName { get; set; }
        public int Port { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        

        public MySqlSetupForm()
        {
            InitializeComponent();
        }

        bool testConnection()
        {
            BasicDBClass.DataSource = textBox_Server.Text;
            BasicDBClass.DBName = textBox_DBName.Text;
            BasicDBClass.UserID = textBox_User.Text;
            BasicDBClass.Password = textBox_Password.Text;
            BasicDBClass.Port = int.Parse( textBox_Port.Text );
            BasicDBClass vBasicDBClass = new BasicDBClass(DataBaseType.MySql);
            return vBasicDBClass.TestConnection();
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                DataSource = textBox_Server.Text;
                DBName = textBox_DBName.Text;
                UserID = textBox_User.Text;
                Password = textBox_Password.Text;
                Port = int.Parse(textBox_Port.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("连测失败，请重新设置参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_TestConn_Click(object sender, EventArgs e)
        {
            if (testConnection())
                MessageBox.Show("连测成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("连测失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
