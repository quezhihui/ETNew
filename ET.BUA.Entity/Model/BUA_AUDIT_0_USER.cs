using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_USER : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string OPERATER_TYPE { get; set; }

        public string USER_ID { get; set; }

        public string USER_UID { get; set; }

        public string USER_NAME { get; set; }

        public string VERSION { get; set; }

        public BUA_AUDIT_0_USER()
        {
        }

        public BUA_AUDIT_0_USER(string eventId, string operaterType, string userId, string userUid, string userName, string version)
        {
            this.EVENT_ID = eventId;
            this.OPERATER_TYPE = operaterType;
            this.USER_ID = userId;
            this.USER_UID = userUid;
            this.USER_NAME = userName;
            this.VERSION = version;
        }
    }
}
