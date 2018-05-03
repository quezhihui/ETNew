using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_FIELDS_CONFIG : BaseEntity
    {
        [Key]
        public string OBJECT_TYPE { get; set; }

        [Key]
        public string FIELD_NAME { get; set; }

        public char FIELD_NEED_FLAG { get; set; }

        public char FIELD_SYS_FLAG { get; set; }

        public string FIELD_DESC { get; set; }

        [Key]
        public string OBJECT_SUB_TYPE { get; set; }

        public char FIELD_SHOW_FLAG { get; set; }
    }
}
