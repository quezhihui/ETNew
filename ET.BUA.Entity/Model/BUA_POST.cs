using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_POST : BaseDataEntity
    {
        [Key]
        public string POST_ID { get; set; } = "";

        public string ORG_ID { get; set; } = "";

        public string POST_NAME { get; set; } = "";

        public string POST_CODE { get; set; } = "";

        public string POST_DESCRIPTION { get; set; } = "";
    }
}
