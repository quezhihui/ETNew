using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_USER : BaseDataEntity
    {
        [Key]
        public string USER_ID { get; set; } = "";

        public string ORG_ID { get; set; } = "";

        public string USER_UID { get; set; } = "";

        public string USER_NAME { get; set; } = "";

        public string USER_PASSWD { get; set; } = "";

        public int USER_SEQUENCE { get; set; } = 0;

        public int USER_LOCKED { get; set; } = 0;

        public string USER_SEX { get; set; } = "";

        public string USER_TYPE { get; set; } = "";

        public string USER_FULL_NAME { get; set; } = "";

        public string USER_EMAIL { get; set; } = "";

        public int USER_EMAIL_PUBLIC { get; set; } = 0;

        public DateTime? EXPIRE_DATE { get; set; }
    }
}
