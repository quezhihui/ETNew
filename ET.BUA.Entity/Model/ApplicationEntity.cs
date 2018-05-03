using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    [Table("BUA_APPLICATION")]
    public class ApplicationEntity : BaseDataEntity
    {
        [Key]
        [Column("APP_ID")]
        [Required(ErrorMessage = "APP_ID不能为空")]
        //[MaxLength(38, ErrorMessage = "APP_ID最多不超过38个字符")]
        public Decimal APP_ID { get; set; } = 11111;

        [Column("APP_NAME")]
        [Display(Description = "应用系统名称")]
        [Required(ErrorMessage = "应用系统名称不能为空")]
        [MaxLength(128, ErrorMessage = "应用系统名称最多不超过128个字符")]
        public string APP_NAME { get; set; } = "";
       
        [Column("APP_CODE")]
        [Display(Description = "应用系统标识")]
        [Required(ErrorMessage = "应用系统标识不能为空")]
        [MaxLength(36, ErrorMessage = "应用系统标识最多不超过36个字符")]
        public string APP_CODE { get; set; } = "";
     
        [Column("APP_PASSWD")]
        [Display(Description = "访问接口密码")]
        [Required(ErrorMessage = "访问接口密码不能为空")]
        [MaxLength(16, ErrorMessage = "访问接口密码最多不超过16个字符")]
        public string APP_PASSWD { get; set; } = "";

        [Column("APP_KIND")]
        [Display(Description = "应用系统类别")]
        [Required(ErrorMessage = "应用系统类别不能为空")]
        [StringLength(36, ErrorMessage = "应用系统类别最多不超过36个字符")]
        public string APP_KIND { get; set; } = "";

        [Column("APP_LOCKED")]
        [Display(Description = "应用系统锁定状态")]
        [Required(ErrorMessage = "应用系统锁定状态不能为空")]
        public Decimal APP_LOCKED { get; set; }

        public string APP_DEV_COMPANY_NAME { get; set; } = "";

        public string APP_HOME_URL { get; set; } = "";

        public string APP_LOGIN_URL { get; set; } = "";

        public Decimal APP_SEQUENCE { get; set; }

        public Decimal ENABLE_MANAGE_SAO { get; set; } = 0;

        public string APP_DESCRIPTION { get; set; } = "";

        public string SYNC_USER_UID { get; set; } = "";

        public string SYNC_USER_PASSWORD { get; set; } = "";

        public string APP_INTEGRATE_MODE { get; set; } = "";
    }
}
