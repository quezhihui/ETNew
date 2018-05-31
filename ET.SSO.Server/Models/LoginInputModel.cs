using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ET.SSO.Server.Models
{
    public class LoginInputModel
    {
        [Required]
        [Display(Description = "用户名")]
        public string UserUID { get; set; }
        [Required]
        [Display(Description = "密码")]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
