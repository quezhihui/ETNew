using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    [Table("BUA_ATTR_PRIVILEGE_GROUP")]
    public class BUA_ATTR_PRIVILEGE_GROUP : BaseDataEntity
    {
        [Key]
        public string GROUP_ID { get; set; } = "";

        public string APP_ID { get; set; } = "";

        public string GROUP_NAME { get; set; } = "";

        public string GROUP_ATTR_PRIVILEGES { get; set; } = "";

        public string GROUP_DESCRIPTION { get; set; } = "";

        public string GROUP_CODE { get; set; } = "";
    }
}
