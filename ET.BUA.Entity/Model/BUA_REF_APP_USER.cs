using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_REF_APP_USER : BaseEntity
    {
        [Key]
        public string APP_ID { get; set; }

        [Key]
        public string USER_ID { get; set; }
    }
}
