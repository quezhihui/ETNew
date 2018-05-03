using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class BUA_PRIVILEGE : BaseDataEntity
    {
        [Key]
        public string PRIVILEGE_ID { get; set; }

        public string APP_ID { get; set; }

        public string PRIVILEGE_NAME { get; set; }

        public string PRIVILEGE_CODE { get; set; }

        public string PRIVILEGE_PARENT_ID { get; set; } = "0";

        public string PRIVILEGE_TYPE { get; set; }

        public bool PRIVILEGE_LOCK { get; set; }

        public string MENU_URL { get; set; }

        public string MENU_IMG_SRC { get; set; }

        public bool MENU_SEPARATOR { get; set; }

        public string PRIVILEGE_PATH { get; set; } = "0";

        public int PRIVILEGE_SEQUENCE { get; set; }

        public string PRIVILEGE_DESCRIPTION { get; set; }

        public string PrivilegeLockOrUnLock
        {
            get
            {
                string result;
                if (this.PRIVILEGE_LOCK)
                {
                    result = "锁定";
                }
                else
                {
                    result = "未锁定";
                }
                return result;
            }
        }

        public string PrivilegeMenuSeparator
        {
            get
            {
                string result;
                if (this.MENU_SEPARATOR)
                {
                    result = "可用";
                }
                else
                {
                    result = "不可用";
                }
                return result;
            }
        }
    }
}
