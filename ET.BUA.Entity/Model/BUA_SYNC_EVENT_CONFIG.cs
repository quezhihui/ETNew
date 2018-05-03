using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_SYNC_EVENT_CONFIG : BaseDataEntity
    {
        [Key]
        public string APP_ID { get; set; }

        [Key]
        public string TR_CODE { get; set; }

        public string PROTOCOL_TYPE { get; set; }

        public string URL { get; set; }

        public int SEQ { get; set; }

        public bool LOCKED { get; set; }

        public string AdapterPropertyXml { get; set; }
    }
}
