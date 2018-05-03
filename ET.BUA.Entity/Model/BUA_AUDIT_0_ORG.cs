using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_AUDIT_0_ORG : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string OPERATER_TYPE { get; set; }

        public string ORG_ID { get; set; }

        public string ORG_CODE { get; set; }

        public string ORG_NAME { get; set; }

        public string VERSION { get; set; }

        public BUA_AUDIT_0_ORG()
        {

        }

        public BUA_AUDIT_0_ORG(string eventId, string operaterType, string orgId, string orgCode, string orgName, string version)
        {
            this.EVENT_ID = eventId;
            this.OPERATER_TYPE = operaterType;
            this.ORG_ID = orgId;
            this.ORG_CODE = orgCode;
            this.ORG_NAME = orgName;
            this.VERSION = version;
        }
    }
}
