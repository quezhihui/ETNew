using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_EVENT : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string EVENT_CODE { get; set; }

        public string EVENT_TYPE { get; set; }

        public string OPERATOR_ID { get; set; }

        public string OPERATOR { get; set; }

        public string OPERATOR_CODE { get; set; }

        public DateTime OPERATER_TIME { get; set; } = DateTime.Now;

        public string EVENT_REF_CODE { get; set; }

        public BUA_AUDIT_0_EVENT()
        {

        }

        public BUA_AUDIT_0_EVENT(string eventCode, string eventType, string eventRefCode)
        {
            this.EVENT_CODE = eventCode;
            this.EVENT_TYPE = eventType;
            this.EVENT_REF_CODE = eventRefCode;
        }
    }
}
