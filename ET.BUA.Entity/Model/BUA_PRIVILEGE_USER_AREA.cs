using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_PRIVILEGE_USER_AREA
    {
        [Key]
        public string REF_ROLE_PRIVILEGE_ID { get; set; }

        [Key]
        public string USER_ID { get; set; }
    }
}
