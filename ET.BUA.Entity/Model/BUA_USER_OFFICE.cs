using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_USER_OFFICE : BaseEntity
    {
        [Key]
        public string USER_ID { get; set; }

        public string ORG_ID { get; set; }

        public string USER_OFFICE_EMAIL { get; set; }

        public string USER_OFFICE_DESC { get; set; }

        public string USER_FAX { get; set; }

        public string USER_DUTY { get; set; }

        public string USER_OFFICE_PHONE { get; set; }

        public string USER_EXT_PHONE { get; set; }

        public string USER_OFFICE { get; set; }

        public string USER_DUTY_LEVEL { get; set; }
    }
}
