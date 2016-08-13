using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMiddleWareForm
{
    public class DBStructOut
    {
        StringBuilder m_StringBuffer = null;
        public DBStructOut()
        {
            m_StringBuffer = new StringBuilder();
        }

        public void AddTable( string TableName,string PK, DBStruct[] DBStructList )
        {
            m_StringBuffer.AppendFormat("[TableAttrib(\"{0}\",\"{1}\")]",TableName,PK);
            m_StringBuffer.AppendLine();
            m_StringBuffer.AppendFormat("public struct {0}", TableName);
            m_StringBuffer.AppendLine();
            m_StringBuffer.Append("{");
            m_StringBuffer.AppendLine();
            foreach ( DBStruct vTempDBStruct in DBStructList )
            {
                m_StringBuffer.AppendFormat("   [ColumnAttrib(\"{0}\")]",vTempDBStruct.ColumnName);
                m_StringBuffer.AppendLine();
                m_StringBuffer.AppendFormat("   public {0} {1} {{ get; set; }}", vTempDBStruct.ColumnType,vTempDBStruct.ColumnName);
                m_StringBuffer.AppendLine();
            }
            m_StringBuffer.Append("}");
            m_StringBuffer.AppendLine();
        }

        public void AddTableView(string TableName,string PK, DBStruct[] DBStructList)
        {
            m_StringBuffer.AppendFormat("[TableAttrib(\"{0}\",true,\"{1}\")]", TableName,PK);
            m_StringBuffer.AppendLine();
            m_StringBuffer.AppendFormat("public struct {0}", TableName);
            m_StringBuffer.AppendLine();
            m_StringBuffer.Append("{");
            m_StringBuffer.AppendLine();
            foreach (DBStruct vTempDBStruct in DBStructList)
            {
                m_StringBuffer.AppendFormat("   [ColumnAttrib(\"{0}\")]", vTempDBStruct.ColumnName);
                m_StringBuffer.AppendLine();
                m_StringBuffer.AppendFormat("   public {0} {1} {{ get;set;}}", vTempDBStruct.ColumnType, vTempDBStruct.ColumnName);
                m_StringBuffer.AppendLine();
            }
            m_StringBuffer.Append("}");
            m_StringBuffer.AppendLine();
        }

        public string Out()
        {
            return m_StringBuffer.ToString();
        }
    }
}
