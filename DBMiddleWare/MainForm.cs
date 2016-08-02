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
    public partial class MainForm : Form
    {

        BasicDBClass m_BasicDBClass = null;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void sqlServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlServerSetupForm vSqlServerSetupFormForm = new SqlServerSetupForm();
            if (  vSqlServerSetupFormForm.ShowDialog() == DialogResult.OK )
            {
                if (vSqlServerSetupFormForm.IsLocal)
                {
                    BasicDBClass.DataSource = vSqlServerSetupFormForm.DataSource;
                    BasicDBClass.AttachDbFilename = vSqlServerSetupFormForm.DBName;
                }
                else
                {
                    BasicDBClass.DataSource = vSqlServerSetupFormForm.DataSource;
                    BasicDBClass.DBName = vSqlServerSetupFormForm.DBName;
                    BasicDBClass.IntegratedSecurity = vSqlServerSetupFormForm.IntegratedSecurity;
                    BasicDBClass.UserID = vSqlServerSetupFormForm.User;
                    BasicDBClass.Password = vSqlServerSetupFormForm.Password;
                }
                m_BasicDBClass = new BasicDBClass(DataBaseType.SqlServer);
                treeView_DB.Nodes.Clear();
                createTableStructTreeView(m_BasicDBClass.TableList, m_BasicDBClass.TableViewList);
            }
            vSqlServerSetupFormForm.Dispose();
        }

        void createTableStructTreeView( string[] Tables,string[] TableViews)
        {
            TreeNode vTablesNode = new TreeNode("数据表");
            vTablesNode.Name = "数据表";
            vTablesNode.Checked = true;
            if (Tables != null)
            {
                foreach (string TableName in Tables)
                {
                    TreeNode vChildTableNode = new TreeNode(TableName);
                    vChildTableNode.Checked = true;
                    vTablesNode.Nodes.Add(vChildTableNode);
                }
            }
            treeView_DB.Nodes.Add(vTablesNode);

            TreeNode vTableViewsNode = new TreeNode("数据视图");
            vTableViewsNode.Name = "数据视图";
            vTableViewsNode.Checked = true;
            if (TableViews != null)
            {
                foreach (string TableViewName in TableViews)
                {
                    TreeNode vChildTableViewNode = new TreeNode(TableViewName);
                    vChildTableViewNode.Checked = true;
                    vTableViewsNode.Nodes.Add(vChildTableViewNode);
                }
            }
            treeView_DB.Nodes.Add(vTableViewsNode);
        }

        private void treeView_DB_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if ( e.Node.Level== 0 )
            {
                foreach (TreeNode vTempNode in e.Node.Nodes)
                {
                    vTempNode.Checked = e.Node.Checked;
                }
            }
        }

        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessSetupForm vAccessSetupFormForm = new AccessSetupForm();
            if ( vAccessSetupFormForm.ShowDialog() == DialogResult.OK )
            {
                BasicDBClass.DataSource = vAccessSetupFormForm.DataSource;
                BasicDBClass.Password = vAccessSetupFormForm.Password;
                m_BasicDBClass = new BasicDBClass(DataBaseType.Access);
                treeView_DB.Nodes.Clear();
                createTableStructTreeView(m_BasicDBClass.TableList, m_BasicDBClass.TableViewList);
            }
        }

        private void button_Mark_Click(object sender, EventArgs e)
        {
            AnalyzeDBStruct vAnalyzeDBStruct = new AnalyzeDBStruct();
            DBStructOut vDBStructOut = new DBStructOut();
            List<string> vTableList = new List<string>();
            TreeNode vTreeNodes = treeView_DB.Nodes["数据表"];
            if (vTreeNodes.Nodes.Count != 0)
            {
                foreach (TreeNode vTempNode in vTreeNodes.Nodes)
                {
                    if (vTempNode.Checked)
                        vTableList.Add(vTempNode.Text);
                }
            }


            foreach ( string vTempTable in vTableList )
            {
                //DataTable vTable =  m_BasicDBClass.SelectCustom( string.Format("select * from information_schema.columns where table_name='{0}'",vTempTable) );
                DataTable vTable = m_BasicDBClass.SelectCustom(string.Format("select * from {0}", vTempTable));
                DBStruct[] DBStructArray = vAnalyzeDBStruct.AnalyzeTableStruct(vTable);
                string vPK = "";
                //vTable = m_BasicDBClass.SelectCustom(string.Format("Execute sp_pkeys {0}", vTempTable));
                if ( vTable.PrimaryKey.Length>0 )
                    vPK = vTable.PrimaryKey[0].ColumnName;
                vDBStructOut.AddTable(vTempTable, vPK, DBStructArray);
            }

            List<string> vTableViewList = new List<string>();
            vTreeNodes = treeView_DB.Nodes["数据视图"];
            if (vTreeNodes.Nodes.Count != 0)
            {
                foreach (TreeNode vTempNode in vTreeNodes.Nodes)
                {
                    if (vTempNode.Checked)
                        vTableViewList.Add(vTempNode.Text);
                }
            }


            foreach (string vTempTableView in vTableViewList)
            {
                //DataTable vTable = m_BasicDBClass.SelectCustom(string.Format("select * from information_schema.columns where table_name='{0}'", vTempTableView));
                DataTable vTable = m_BasicDBClass.SelectCustom(string.Format("select * from {0}", vTempTableView));
                DBStruct[] DBStructArray = vAnalyzeDBStruct.AnalyzeTableStruct(vTable);
                string vPK = "";
                if (vTable.PrimaryKey.Length > 0)
                    vPK = vTable.PrimaryKey[0].ColumnName;
                vDBStructOut.AddTableView(vTempTableView,vPK, DBStructArray);
            }

            richTextBox_Out.Text = vDBStructOut.Out();
        }

        private void mySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlSetupForm vMySqlSetupFormForm = new MySqlSetupForm();
            if ( vMySqlSetupFormForm.ShowDialog() == DialogResult.OK)
            {
                BasicDBClass.DataSource = vMySqlSetupFormForm.DataSource;
                BasicDBClass.DBName = vMySqlSetupFormForm.DBName;
                BasicDBClass.UserID = vMySqlSetupFormForm.UserID;
                BasicDBClass.Password = vMySqlSetupFormForm.Password;
                BasicDBClass.Port= vMySqlSetupFormForm.Port;
                m_BasicDBClass = new BasicDBClass(DataBaseType.MySql);
                treeView_DB.Nodes.Clear();
                createTableStructTreeView(m_BasicDBClass.TableList, m_BasicDBClass.TableViewList);
            }
          
        }

        private void oracleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OracleSetupForm vOracleSetupForm = new OracleSetupForm();
            if ( vOracleSetupForm.ShowDialog() == DialogResult.OK )
            {
                BasicDBClass.DataSource = vOracleSetupForm.DataSource;
                BasicDBClass.UserID = vOracleSetupForm.User;
                BasicDBClass.Password = vOracleSetupForm.Password;
                m_BasicDBClass = new BasicDBClass(DataBaseType.Oracle);
                treeView_DB.Nodes.Clear();
                createTableStructTreeView(m_BasicDBClass.TableList, m_BasicDBClass.TableViewList);
            }
        }
    }
}
