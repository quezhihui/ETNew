using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ET.BUA.Web.Models;
using ET.BUA.Service.Service;
using ET.BUA.Entity.Model;

namespace ET.BUA.Web.Controllers
{
    public class AppController : Controller
    {
        private readonly IApplicationService _applicationService;

        public AppController(IApplicationService applicationService)
        {
            this._applicationService = applicationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult AppAdd(string ReturnUrl)
        //{
        //    ViewBag.ReturnUrl = ReturnUrl;
        //    return View(_applicationService.GetSingleModel("BPM"));
        //}

        [HttpGet]
        public ActionResult AppAdd(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult AppAdd(ApplicationEntity App, string ReturnUrl)
        {
            try
            {
                App.CREATE_USER_NAME = "guanly";
                App.CREATE_TIME = System.DateTime.Now;
                App.LAST_UPDATE_USER_NAME = "guanly";
                App.LAST_UPDATE_TIME = System.DateTime.Now;
                _applicationService.Add(App);
            }
            catch (Exception ex)
            {
                ViewBag.Errormessage = ex.ToString();
                ViewBag.ReturnUrl = ReturnUrl;
                return View(App);
            }

            return RedirectToAction("Index", new { ReturnUrl });
        }

        
    }
}
