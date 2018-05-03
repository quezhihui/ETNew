using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_REF_ROLE_OBJECT : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }
        [Key]
        public string ROLE_ID { get; set; }

        public string OPERATER_TYPE { get; set; }
        [Key]
        public string REF_TYPE { get; set; }
        [Key]
        public string REF_OBJECT_ID { get; set; }

        public string REF_OBJECT_NAME { get; set; }

        public string REF_OBJECT_CODE { get; set; }

        public BUA_AUDIT_0_REF_ROLE_OBJECT()
        {
        }

        public BUA_AUDIT_0_REF_ROLE_OBJECT(string eventId, string roleId, string refType, string refObjectId, string operaterType, string refObjectName, string refObjectCode)
        {
            this.EVENT_ID = eventId;
            this.ROLE_ID = roleId;
            this.REF_TYPE = refType;
            this.REF_OBJECT_ID = refObjectId;
            this.OPERATER_TYPE = operaterType;
            this.REF_OBJECT_NAME = refObjectName;
            this.REF_OBJECT_CODE = refObjectCode;
        }
    }
}
