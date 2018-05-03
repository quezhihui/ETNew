using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_LOGIN : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string USER_ID { get; set; }

        public string USER_NAME { get; set; }

        public string USER_UID { get; set; }

        public string SESSION_ID { get; set; }

        public string IP { get; set; }

        public DateTime LOGIN_TIME { get; set; }

        public DateTime LOGOFF_TIME { get; set; }
    }
}
