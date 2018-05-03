using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_ORGANIZATION : BaseDataEntity
    {
        [Key]
        public string ORG_ID { get; set; }

        public string ORG_NAME { get; set; } = "";

        public string ORG_CODE { get; set; } = "";

        public string ORG_PARENT_ID { get; set; }

        public string ORG_PATH { get; set; } = "";

        public int ORG_SEQUENCE { get; set; }

        public string ORG_TYPE { get; set; } = "";

        public string UNIT_TYPE { get; set; } = "";

        public string UNIT_ID { get; set; }

        public string ORG_LEVEL { get; set; } = "";

        public string ORG_GlOBAL_NO { get; set; } = "";
    }
}
