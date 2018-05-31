using ET.Core.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    [Table("BUA_USER")]
    public class UserEntity : BaseDataEntity
    {
        [Key]
        public Decimal USER_ID { get; set; }

        public Decimal ORG_ID { get; set; }

        [Column("USER_UID")]
        [Display(Description = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        public string USER_UID { get; set; } = "";

        public string USER_NAME { get; set; } = "";

        [Column("USER_PASSWD")]
        [Display(Description = "密码")]
        [Required(ErrorMessage = "密码不能为空")]
        public string USER_PASSWD { get; set; } = "";

        public Decimal USER_SEQUENCE { get; set; } = 0;

        public Decimal USER_LOCKED { get; set; } = 0;

        public string USER_SEX { get; set; } = "";

        public string USER_TYPE { get; set; } = "";

        public string USER_FULL_NAME { get; set; } = "";

        public string USER_EMAIL { get; set; } = "";

        public Decimal USER_EMAIL_PUBLIC { get; set; } = 0;

        public DateTime? EXPIRE_DATE { get; set; }
    }
}
