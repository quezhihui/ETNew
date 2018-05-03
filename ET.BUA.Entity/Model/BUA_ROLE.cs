using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_ROLE : BaseDataEntity
    {
        [Key]
        public string ROLE_ID { get; set; } = null;

        public string APP_ID { get; set; } = null;

        public string ROLE_NAME { get; set; } = "";

        public string ROLE_CODE { get; set; } = "";

        public string ROLE_TYPE { get; set; } = "";

        public string ROLE_DESCRIPTION { get; set; } = "";

        public string ROLE_PRIVATE_TYPE { get; set; } = "";

        public string ROLE_REF_OBJECT_ID { get; set; } = null;

        public int ROLE_PRIOR_LEVEL { get; set; } = 9;

        public int ROLE_SEQUENCE { get; set; } = 0;
    }
}
