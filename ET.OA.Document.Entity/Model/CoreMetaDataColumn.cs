using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreMetaDataColumn
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string ColumnCode { get; set; }
        public string TableCode { get; set; }
        public string DataType { get; set; }
        public int? CharacterMaxNumLength { get; set; }
        public byte? NumericPrecision { get; set; }
        public short? NumericPrecisionRadix { get; set; }
        public bool? IsNullable { get; set; }
        public string Memo { get; set; }
    }
}
