using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_REF_USERS : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        [Key]
        public string REF_TYPE { get; set; }

        [Key]
        public string REF_OBJECT_ID { get; set; }

        [Key]
        public string USER_ID { get; set; }

        public string OPERATER_TYPE { get; set; }

        public string USER_NAME { get; set; }

        public string USER_CODE { get; set; }

        public DateTime OPERATER_TIME { get; set; }

        public BUA_AUDIT_0_REF_USERS()
        {
        }

        public BUA_AUDIT_0_REF_USERS(string eventId, string refType, string refObjectId, string userId, string operaterType, string userName, string userCode)
        {
            this.EVENT_ID = eventId;
            this.REF_TYPE = refType;
            this.REF_OBJECT_ID = refObjectId;
            this.USER_ID = userId;
            this.OPERATER_TYPE = operaterType;
            this.USER_NAME = userName;
            this.USER_CODE = userCode;
        }
    }
}
