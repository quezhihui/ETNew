using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreMetaDataTable
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string TableCode { get; set; }
        public string BusinessClass { get; set; }
        public string BusinessClassName { get; set; }
        public bool? IsPrimaryTable { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Memo { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string OtherTableCodes { get; set; }
    }
}
