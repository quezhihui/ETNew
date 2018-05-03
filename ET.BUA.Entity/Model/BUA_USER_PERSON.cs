using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{

    [Serializable]
    public class BUA_USER_PERSON : BaseEntity
    {
        [Key]
        public string USER_ID { get; set; }

        public string USER_CARD_TYPE { get; set; }

        public string USER_CARD { get; set; }

        public string USER_NICK { get; set; }

        public string USER_MOBILE_PHONE { get; set; }

        public string USER_HOME_ADDRESS { get; set; }

        public string USER_HOME_PHONE { get; set; }

        public string USER_HOME_POST { get; set; }

        public string USER_SECURITY_LEVEL { get; set; }

        public string USER_DESC { get; set; }
    }
}
