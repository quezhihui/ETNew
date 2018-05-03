using System;

namespace ET.Core.Entity.Base
{
    [Serializable]
    public class BaseDataEntity : BaseEntity
    {
        public DateTime CREATE_TIME { get; set; } = DateTime.UtcNow;

        public DateTime LAST_UPDATE_TIME { get; set; } = DateTime.UtcNow;

        public string CREATE_USER_NAME { get; set; }

        public string LAST_UPDATE_USER_NAME { get; set; }
    }
}
