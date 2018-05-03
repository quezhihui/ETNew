using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_ROLE : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        [Key]
        public string ROLE_ID { get; set; }

        public string APP_CODE { get; set; }

        public string OPERATER_TYPE { get; set; }

        public string ROLE_NAME { get; set; }

        public string ROLE_CODE { get; set; }

        public BUA_AUDIT_0_ROLE()
        {
        }

        public BUA_AUDIT_0_ROLE(string eventId, string roleId, string appCode, string operaterType, string roleName, string roleCode)
        {
            this.EVENT_ID = eventId;
            this.ROLE_ID = roleId;
            this.APP_CODE = appCode;
            this.OPERATER_TYPE = operaterType;
            this.ROLE_NAME = roleName;
            this.ROLE_CODE = roleCode;
        }
    }
}
