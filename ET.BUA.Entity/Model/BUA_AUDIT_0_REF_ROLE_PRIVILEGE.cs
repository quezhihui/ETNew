using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_REF_ROLE_PRIVILEGE : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }
        [Key]
        public string ROLE_ID { get; set; }

        public string APP_CODE { get; set; }

        public string OPERATER_TYPE { get; set; }

        public string PRIVILEGE_ID { get; set; }

        public string PRIVILEGE_NAME { get; set; }

        public string PRIVILEGE_CODE { get; set; }

        public string ATTR_ID { get; set; }

        public string ATTR_NAME { get; set; }

        public string ATTR_CODE { get; set; }

        public string PRIVILEGE_GRANT { get; set; }

        public string PRIVILEGE_ACCESS { get; set; }

        public BUA_AUDIT_0_REF_ROLE_PRIVILEGE()
        {
        }

        public BUA_AUDIT_0_REF_ROLE_PRIVILEGE(string eventId, string roleId, string operaterType, string appCode, string privilegeId, string privilegeName, string privilegeCode, string attrId, string attrName, string attrCode, string privilegeAccess, string privilegeGrant)
        {
            this.EVENT_ID = eventId;
            this.ROLE_ID = roleId;
            this.OPERATER_TYPE = operaterType;
            this.APP_CODE = appCode;
            this.PRIVILEGE_ID = privilegeId;
            this.PRIVILEGE_NAME = privilegeName;
            this.PRIVILEGE_CODE = privilegeCode;
            this.ATTR_ID = attrId;
            this.ATTR_NAME = attrName;
            this.ATTR_CODE = attrCode;
            this.PRIVILEGE_ACCESS = privilegeAccess;
            this.PRIVILEGE_GRANT = privilegeGrant;
        }
    }
}
