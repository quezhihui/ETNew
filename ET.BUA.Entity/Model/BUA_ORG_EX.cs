using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_ORG_EX : BaseEntity
    {
        [Key]
        public string ORG_ID { get; set; } = "";

        [Key]
        public string EX_CODE { get; set; } = "";

        public string EX_VALUE { get; set; } = "";
    }
}
