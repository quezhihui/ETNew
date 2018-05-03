using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SYNC_EVENT_TASK : BaseEntity
    {
        [Key]
        public string TASK_ID { get; set; }

        public string EVENT_ID { get; set; }

        public string APP_ID { get; set; }

        public string TR_CODE { get; set; }

        public int TASK_STATUS { get; set; }

        public int TASK_FINISHED { get; set; }

        public int TASK_RETRY_COUNT { get; set; }

        public DateTime CREATE_TIME { get; set; } = DateTime.UtcNow;

        public DateTime LAST_UPDATE_TIME { get; set; } = DateTime.Now;
    }
}
