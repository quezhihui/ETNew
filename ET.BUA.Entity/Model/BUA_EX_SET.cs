using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_EX_SET : BaseDataEntity
    {
        [Key]
        public string OBJECT_TYPE { get; set; }

        [Key]
        public string EX_CODE { get; set; }

        public string EX_NAME { get; set; }

        public string EX_TYPE { get; set; }

        public string PARAM_ENUM_VALUES { get; set; }

        public string EX_PROMPT { get; set; }

        public int EX_SEQUENCE { get; set; }
    }
}
