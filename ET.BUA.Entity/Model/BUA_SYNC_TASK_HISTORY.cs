using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SYNC_TASK_HISTORY : BaseEntity
    {
        [Key]
        public string TASK_ID { get; set; }

        [Key]
        public int TASK_RETRY_NO { get; set; }

        public int TASK_STATUS { get; set; }

        public int OPERATOR_METHOD { get; set; }

        public DateTime TASK_BEGIN_TIME { get; set; }

        public DateTime TASK_END_TIME { get; set; }

        public string OPERATOR_ID { get; set; }

        public string OPERATOR_CODE { get; set; }

        public string OPERATOR_NAME { get; set; }

        public string ERROR_CODE { get; set; }

        public string ERROR_MSG { get; set; }
    }
}
