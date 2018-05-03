using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SYS_PARAMETERS : BaseDataEntity
    {
        [Key]
        public string PARAM_CODE { get; set; }

        public string PARAM_VALUE { get; set; }

        public string PARAM_TYPE { get; set; }

        public string PARAM_ENUM_VALUES { get; set; }

        public string PARAM_PROMPT { get; set; }
    }
}
