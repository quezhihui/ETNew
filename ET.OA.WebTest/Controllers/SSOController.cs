﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ET.OA.WebTest.Models;
using Microsoft.AspNetCore.Authorization;

namespace ET.OA.WebTest.Controllers
{
    public class SSOController : Controller
    {
        [Authorize]
        public IActionResult SignOn()
        {
            return View();
        }
    }
}
