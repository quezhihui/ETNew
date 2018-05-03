using ET.Core.Entity.Base;
using ET.BUA.Entity.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SYNC_EVENT : BaseEntity
    {
        [Key]
        public string EVENT_ID { get; set; }

        public string TR_CODE { get; set; }

        public EventStatus EVENT_STATUS { get; set; }

        public string OPERATOR_ID { get; set; }

        public string OPERATOR_CODE { get; set; }

        public string OPERATOR_NAME { get; set; }

        public string REF_TYPE { get; set; }

        public string REF_OBJECT_ID { get; set; }

        public string REF_OBJECT_CODE { get; set; }

        public string REF_OBJECT_PARENT_CODE { get; set; }

        public string REQUEST_XML { get; set; }

        public DateTime CREATE_TIME { get; set; }

        public DateTime LAST_UPDATE_TIME { get; set; }

        public string REF_OBJECT_TYPE { get; set; }
    }
}
