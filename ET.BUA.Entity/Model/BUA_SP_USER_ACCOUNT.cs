using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SP_USER_ACCOUNT : BaseDataEntity
    {
        [Key]
        public string USER_ID { get; set; } = "";

        public string SP_APP_CODE { get; set; } = "";

        public string SP_USER_UID { get; set; } = "";

        public string SP_USER_PASSWORD { get; set; } = "";
    }
}
