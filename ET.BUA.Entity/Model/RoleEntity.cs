using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    [Table("BUA_ROLE")]
    public class RoleEntity : BaseDataEntity
    {
        [Key]
        public Decimal ROLE_ID { get; set; }

        public Decimal APP_ID { get; set; }

        public string ROLE_NAME { get; set; } = "";

        public string ROLE_CODE { get; set; } = "";

        public string ROLE_TYPE { get; set; } = "";

        public string ROLE_DESCRIPTION { get; set; } = "";

        public string ROLE_PRIVATE_TYPE { get; set; } = "";

        public string ROLE_REF_OBJECT_ID { get; set; } = null;

        public Decimal ROLE_PRIOR_LEVEL { get; set; }

        public Decimal ROLE_SEQUENCE { get; set; }
    }
}
