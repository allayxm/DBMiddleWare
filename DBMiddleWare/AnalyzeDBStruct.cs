using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBMiddleWareForm
{
    public struct DBStruct
    {
        public string ColumnName;
        public string ColumnType;
    }
        
    public class AnalyzeDBStruct
    {
        public AnalyzeDBStruct()
        {

        }

        public DBStruct[] AnalyzeSqlServerTableStruct( DataTable TableStruct  )
        {
            DBStruct[] vResult = new DBStruct[TableStruct.Rows.Count];
            for( int i=0;i<vResult.Length;i++)
            {
                vResult[i].ColumnName = TableStruct.Rows[i]["Column_Name"].ToString();
                string vDataType = TableStruct.Rows[i]["Data_Type"].ToString();
                switch( vDataType.ToUpper() )
                {
                    case "BIGINT":
                        vDataType = "Int32?";
                        break;
                    case "BINARY":
                    case "VARBINARY":
                    case "IMAGE":
                        vDataType = "byte[]";
                        break;
                    case "BIT":
                    case "TINYINT":
                        vDataType = "byte?";
                        break;
                    case "CHAR":
                        vDataType = "char?";
                        break;
                    case "DATE":
                    case "DATETIME":
                    case "DATETIME2":
                    case "TIME":
                    case "SMALLDATETIME":
                        vDataType = "DateTime?";
                        break;
                    case "DATETIMEOFFSET":
                        vDataType = "DateTimeOffset?";
                        break;
                    case "DECIMAL":
                    case "MONEY":
                    case "NUMERIC":
                    case "SMALLMONEY":
                        vDataType = "decimal?";
                        break;
                    case "FLOAT":
                        vDataType = "float?";
                        break;
                    case "INT":
                        vDataType = "int?";
                        break;
                    case "NCHAR":
                    case "NTEXT":
                    case "NVARCHAR":
                    case "TEXT":
                    case "VARCHAR":
                    case "ROWVERSION":
                    case "TIMESTAMP":
                    case "UNIQUEIDENTIFIER":
                        vDataType = "string";
                        break;
                    case "REAL":
                        vDataType = "double?";
                        break;
                    case "SMALLINT":
                        vDataType = "Int16?";
                        break;
                    case "SQL_VARIANT":
                        vDataType = "Object";
                        break;
                    default:
                        vDataType = "string";
                        break;
                }
                vResult[i].ColumnType = vDataType;
            }
            return vResult;
        }

        public DBStruct[] AnalyzeTableStruct( DataTable TableStruct)
        {
            DBStruct[] vResult = new DBStruct[TableStruct.Columns.Count];
            for( int i=0;i<vResult.Length;i++)
            {
                vResult[i].ColumnName = TableStruct.Columns[i].ColumnName;
                string vDataType = "";
                switch(TableStruct.Columns[i].DataType.ToString() )
                {
                    case "System.Boolean":
                    case "System.Nullable`1[System.Boolean]":
                    case "System.Data.SqlTypes.SqlBoolean":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "bool?" : "bool";
                        vDataType = "bool?";
                        break;
                    case "System.Int16":
                    case "System.Nullable`1[System.Int16]":
                    case "System.Data.SqlTypes.SqlInt16":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "Int16?" : "Int16";
                        vDataType = "Int16?";
                        break;
                    case "System.Int32":
                    case "System.Nullable`1[System.Int32]":
                    case "System.Data.SqlTypes.SqlInt32":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "int?" : "int";
                        vDataType =  "int?";
                        break;
                    case "System.String":
                    case "System.Nullable`1[System.String]":
                    case "System.Data.SqlTypes.SqlString":
                        vDataType = "String";
                        break;
                    case "System.DateTime":
                    case "System.Nullable`1[System.DateTime]":
                    case "System.Data.SqlTypes.SqlDateTime":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "DateTime?" : "DateTime";
                        vDataType = "DateTime?";
                        break;
                    //float
                    case "System.Single":
                    case "System.Nullable`1[System.Single]":
                    case "System.Data.SqlTypes.SqlSingle":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "float?" : "float";
                        vDataType = "float?";
                        break;
                    //Decimal
                    case "System.Decimal":
                    case "System.Nullable`1[System.Decimal]":
                    case "System.Data.SqlTypes.SqlDecimal":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "decimal?" : "decimal";
                        vDataType = "decimal?";
                        break;
                    //byte[]
                    case "System.Byte[]":
                    case "System.Nullable`1[System.Byte[]]":
                    case "System.Data.SqlTypes.SqlBytes":
                        vDataType = "byte[]";
                        break;
                    //double
                    case "System.Double":
                    case "System.Nullable`1[System.Double]":
                    case "System.Data.SqlTypes.SqlDouble":
                        //vDataType = TableStruct.Columns[i].AllowDBNull == true ? "double?" : "double";
                        vDataType = "double?";
                        break;
                    case "System.UInt64":
                        vDataType = "UInt64?";
                        break;
                    default:
                        vDataType = "string";
                        break;
                }
                vResult[i].ColumnType = vDataType;
            }
            return vResult;
        }
    }
}
