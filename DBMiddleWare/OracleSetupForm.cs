using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MXKJ.DBMiddleWareLib;

namespace DBMiddleWareForm
{
    public partial class OracleSetupForm : Form
    {
        public OracleSetupForm()
        {
            InitializeComponent();
        }

        public string DataSource { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

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
            BasicDBClass.UserID = textBox_User.Text;
            BasicDBClass.Password = textBox_Password.Text;
            BasicDBClass vBasicDBClass = new BasicDBClass(DataBaseType.Oracle);
            return vBasicDBClass.TestConnection();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                DataSource = textBox_Server.Text;
                User = textBox_User.Text;
                Password = textBox_Password.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("连测失败，请重新设置参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
