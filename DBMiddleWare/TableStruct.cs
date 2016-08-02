using MXKJ.DBMiddleWareLib;
using System;


namespace DBMiddleWareForm
{
    [TableAttrib("Table1","ID")]
    public struct Table1Struct
    {
        [ColumnAttrib("ID")]
        public int? ID;
        [ColumnAttrib("V1_String")]
        public string V1_String;
        [ColumnAttrib("V2_Byte")]
        public byte? V2_Byte;
        [ColumnAttrib("V3_SByte")]
        public sbyte? V3_SByte;
        [ColumnAttrib("V4_short")]
        public short? V4_short;
        [ColumnAttrib("V5_Int")]
        public int? V5_Int;
        [ColumnAttrib("V6_long")]
        public long? V6_long;
        [ColumnAttrib("V7_ushort")]
        public ushort? V7_ushort;
        [ColumnAttrib("V8_uint")]
        public uint? V8_uint;
        [ColumnAttrib("V9_ulong")]
        public ulong? V9_ulong;
        [ColumnAttrib("V10_float")]
        public float? V10_float;
        [ColumnAttrib("V11_double")]
        public double? V11_double;
        [ColumnAttrib("V12_bool")]
        public bool? V12_bool;
        [ColumnAttrib("V13_char")]
        public char? V13_char;
        [ColumnAttrib("V14_decimal")]
        public decimal? V14_decimal;
        [ColumnAttrib("V15_object")]
        public object V15_object;
        [ColumnAttrib("V16_DateTime")]
        public DateTime? V16_DateTime;
    }

    [TableAttrib("Table1", "ID")]
    public struct Table1
    {
        [ColumnAttrib("Id")]
        public int? Id;
        [ColumnAttrib("V1_String")]
        public string V1_String;
        [ColumnAttrib("V2_Byte")]
        public byte? V2_Byte;
        [ColumnAttrib("V3_SByte")]
        public byte? V3_SByte;
        [ColumnAttrib("V4_short")]
        public Int16? V4_short;
        [ColumnAttrib("V5_Int")]
        public int? V5_Int;
        [ColumnAttrib("V6_long")]
        public Int32? V6_long;
        [ColumnAttrib("V7_ushort")]
        public Int16? V7_ushort;
        [ColumnAttrib("V8_uint")]
        public int? V8_uint;
        [ColumnAttrib("V9_ulong")]
        public Int32? V9_ulong;
        [ColumnAttrib("V10_float")]
        public float? V10_float;
        [ColumnAttrib("V11_double")]
        public decimal? V11_double;
        [ColumnAttrib("V12_bool")]
        public byte? V12_bool;
        [ColumnAttrib("V13_char")]
        public char? V13_char;
        [ColumnAttrib("V14_decimal")]
        public decimal? V14_decimal;
        [ColumnAttrib("V15_object")]
        public byte[] V15_object;
        [ColumnAttrib("V16_DateTime")]
        public DateTime? V16_DateTime;
    }

    [TableAttrib("View", true)]
    public struct View
    {
        [ColumnAttrib("Id")]
        public int? Id;
        [ColumnAttrib("V1_String")]
        public string V1_String;
        [ColumnAttrib("V2_Byte")]
        public byte? V2_Byte;
        [ColumnAttrib("V3_SByte")]
        public byte? V3_SByte;
        [ColumnAttrib("V4_short")]
        public Int16? V4_short;
        [ColumnAttrib("V5_Int")]
        public int? V5_Int;
        [ColumnAttrib("V6_long")]
        public Int32? V6_long;
        [ColumnAttrib("V7_ushort")]
        public Int16? V7_ushort;
        [ColumnAttrib("V8_uint")]
        public int? V8_uint;
        [ColumnAttrib("V9_ulong")]
        public Int32? V9_ulong;
        [ColumnAttrib("V10_float")]
        public float? V10_float;
        [ColumnAttrib("V11_double")]
        public decimal? V11_double;
        [ColumnAttrib("V12_bool")]
        public byte? V12_bool;
        [ColumnAttrib("V13_char")]
        public char? V13_char;
        [ColumnAttrib("V14_decimal")]
        public decimal? V14_decimal;
        [ColumnAttrib("V15_object")]
        public byte[] V15_object;
        [ColumnAttrib("V16_DateTime")]
        public DateTime? V16_DateTime;
    }
}
