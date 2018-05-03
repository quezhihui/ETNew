using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_DELED_OBJECT : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string OBJECT_ID { get; set; }
        [Key]
        public string OBJECT_TYPE { get; set; }

        public string OBJECT_CODE { get; set; }

        public string OBJECT_NAME { get; set; }

        public BUA_AUDIT_0_DELED_OBJECT()
        {
        }

        public BUA_AUDIT_0_DELED_OBJECT(string eventId, string objectId, string objectType, string objectCode, string objectName)
        {
            this.EVENT_ID = eventId;
            this.OBJECT_ID = objectId;
            this.OBJECT_TYPE = objectType;
            this.OBJECT_CODE = objectCode;
            this.OBJECT_NAME = objectName;
        }
    }
}
