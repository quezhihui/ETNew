using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_DICTIONARY : BaseDataEntity
    {
        [Key]
        public string DIC_ID { get; set; } = "";

        public string DIC_PARENT_ID { get; set; } = "0";

        public string DIC_NAME { get; set; }

        public string DIC_CODE { get; set; }

        public string DIC_NAME2 { get; set; }

        public string DIC_CODE2 { get; set; }

        public string DIC_NAME3 { get; set; }

        public string DIC_CODE3 { get; set; }

        public string DIC_TYPE { get; set; } = "";

        public string APP_ID { get; set; }

        public string DIC_PATH { get; set; } = "0";

        public int DIC_SEQUENCE { get; set; } = 0;

        public bool DIC_IS_SYS { get; set; }

        public string DIC_DESCRIPTION { get; set; }

        public string SystemDic
        {
            get
            {
                string result;
                if (this.DIC_IS_SYS)
                {
                    result = "是";
                }
                else
                {
                    result = "否";
                }
                return result;
            }
        }
    }
}
