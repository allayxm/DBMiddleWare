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
    public partial class TestForm : Form
    {
        BasicDBClass vBasicDBClass;
        public TestForm()
        {
            InitializeComponent();
            BasicDBClass.DataSource = @"D:\用户目录\我的文档\Database1.mdb";
            //BasicDBClass.DataSource = @"(LocalDB)\MSSQLLocalDB";
            //asicDBClass.AttachDbFilename = @"D:\用户目录\我的文档\YXMDB.mdf";
            BasicDBClass.IntegratedSecurity = true;
            vBasicDBClass = new BasicDBClass(DataBaseType.Access);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable vTable = vBasicDBClass.SelectAllRecords<Table1Struct>();
            //vBasicDBClass.DeleteRecord<Table1Struct>(1);
            Table1Struct vTable1Str = new Table1Struct();
            vTable1Str.V1_String = "123";
            vTable1Str.V2_Byte = (byte)1;
            vTable1Str.V3_SByte = (sbyte)2;
            vTable1Str.V4_short = (short)-1;
            vTable1Str.V5_Int = (int)-2;
            vTable1Str.V6_long = (long)-3;
            vTable1Str.V7_ushort = (ushort)1;
            vTable1Str.V8_uint = (uint)2;
            vTable1Str.V9_ulong = (ulong)3;
            vTable1Str.V10_float = (float)11.11;
            vTable1Str.V11_double = (double)12.1212;
            vTable1Str.V12_bool = true;
            vTable1Str.V13_char = 'a';
            vTable1Str.V14_decimal = (decimal)12.121212;
            vTable1Str.V15_object = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            vTable1Str.V16_DateTime = DateTime.Now;
            int vID = vBasicDBClass.InsertRecord(vTable1Str);
            MessageBox.Show("插入ID:" + vID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable vTable = vBasicDBClass.SelectAllRecords<Table1Struct>();
            Table1Struct vRecord = new Table1Struct();
            vRecord.ID = 11;
            if (vBasicDBClass.DeleteRecordByPrimaryKey<Table1Struct>(12))
                //if (vBasicDBClass.DeleteRecord(vRecord))
                MessageBox.Show("删除成功");
            else
                MessageBox.Show("删除失败");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table1Struct vRecord = new Table1Struct();
            vRecord.V16_DateTime = DateTime.Now;
            vRecord.ID = 20;
            //if ( vBasicDBClass.UpdateRecord(vRecord,20 ) )
            if (vBasicDBClass.UpdateRecord(vRecord))
                MessageBox.Show("更新成功");
            else
                MessageBox.Show("更新失败");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] asasdf = new byte[2];

            Table1Struct vRecord = new Table1Struct();
            Table1Struct vTable = vBasicDBClass.SelectRecordByPrimaryKeyEx<Table1Struct>(4);
            vRecord.V4_short = -5;
            Table1Struct[] vList = vBasicDBClass.SelectRecordsEx(vRecord, "ID desc", "V1_String,V16_DateTime");
            //vBasicDBClass.DeleteRecord();
        }
    }
}
