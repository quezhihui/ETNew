using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_PRIVILEGE_ORG_AREA
    {
        [Key]
        public string REF_ROLE_PRIVILEGE_ID { get; set; }

        [Key]
        public string ORG_ID { get; set; }
    }
}
