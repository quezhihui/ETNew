using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_USER_PIC
    {
        [Key]
        public string USER_ID { get; set; }

        public string USER_FILE_EXT_NAME { get; set; }

        public byte[] USER_PIC { get; set; }
    }
}
