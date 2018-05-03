using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_REF_ROLE_PRIVILEGE : BaseEntity
    {
        [Key]
        public string REF_ROLE_PRIVILEGE_ID { get; set; } = "";

        public string ROLE_ID { get; set; } = "";

        public string PRIVILEGE_ID { get; set; } = "";

        public string ATTR_ID { get; set; } = null;

        public string PRIVILEGE_GRANT { get; set; }

        public string PRIVILEGE_ACCESS { get; set; }

        public string PRIVILEGE_RESTRICT_ID { get; set; } = null;
    }
}
