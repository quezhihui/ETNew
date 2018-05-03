using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_ATTR_PRIVILEGE : BaseDataEntity
    {
        [Key]
        public string ATTR_ID { get; set; }

        public string APP_ID { get; set; }

        public string ATTR_NAME { get; set; }

        public string ATTR_CODE { get; set; }

        public string ATTR_DESCRIPTION { get; set; }

        public int ATTR_SEQUENCE { get; set; }
    }
}
