using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ET.SSO.WebUI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ET.SSO.WebUI.Controllers
{
    public class SSOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Authorize]
        public IActionResult SignOn()
        {

            return View();
        }
    }
}
