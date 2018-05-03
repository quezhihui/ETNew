using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_DATA : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string VERSION { get; set; }

        public string OBJECT_TYPE { get; set; }

        public string OBJECT_ID { get; set; }

        public string OBJECT_CODE { get; set; }

        public string FIELD_NAME { get; set; }

        public string FIELD_OLD_VALUE { get; set; }

        public string FIELD_NEW_VALUE { get; set; }

        public BUA_AUDIT_0_DATA()
        {
        }

        public BUA_AUDIT_0_DATA(string eventId, string version, string objectType, string objectId, string objectCode, string fieldName, string fieldOldValue, string fieldNewValue)
        {
            this.EVENT_ID = eventId;
            this.VERSION = version;
            this.OBJECT_ID = objectId;
            this.OBJECT_TYPE = objectType;
            this.OBJECT_CODE = objectCode;
            this.FIELD_NAME = fieldName;
            this.FIELD_OLD_VALUE = fieldOldValue;
            this.FIELD_NEW_VALUE = fieldNewValue;
        }
    }
}
