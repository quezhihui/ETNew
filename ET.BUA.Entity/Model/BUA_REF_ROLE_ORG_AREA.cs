using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_REF_ROLE_ORG_AREA : BaseEntity
    {
        [Key]
        public string ROLE_ID { get; set; }

        [Key]
        public string ORG_ID { get; set; }
    }
}
