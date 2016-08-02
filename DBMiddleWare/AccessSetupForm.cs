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
    public partial class AccessSetupForm : Form
    {
        public AccessSetupForm()
        {
            InitializeComponent();
        }
        string m_DataSource = string.Empty;
        string m_Password = string.Empty;

        public string DataSource
        {
            get
            {
                return m_DataSource;
            }

            set
            {
                m_DataSource = value;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }

            set
            {
                m_Password = value;
            }
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Multiselect = false;
            vOpenFileDialog.Filter = "Access Files (*.mdb)|*.mdb";
            if ( vOpenFileDialog.ShowDialog()== DialogResult.OK )
            {
                textBox_DBFile.Text = vOpenFileDialog.FileName;
            }
            vOpenFileDialog.Dispose();
        }

        bool testConnection()
        {
            BasicDBClass.DataSource = textBox_DBFile.Text;
            BasicDBClass.Password = textBox_Password.Text;
            BasicDBClass vBasicDBClass = new BasicDBClass(DataBaseType.Access);
            return vBasicDBClass.TestConnection();
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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                m_DataSource = textBox_DBFile.Text;
                m_Password = textBox_Password.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("连测失败，请重新设置参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
