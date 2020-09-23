using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTentakel.Lib;
using WebTentakel.Models;

namespace WebTentakel.Controllers
{
    public class AdminController : Controller
    {
        Function f = new Function();
        public IActionResult CMS_OurClient()
        {
            return View();
        }
        public async Task<IActionResult> CMS_Home()
        {
            var model = new HomeBannerModel();
            model.ListBanner = await f.GetDataHomeBanner();
            return View(model);
        }
        
        public IActionResult CMS_Home_Form(int Id=0)
        {
            ViewBag.Action = Id.ToString();
            return View();
        }

        //Solution Management
        public IActionResult CMS_Solution()
        {
            return View();
        }
        public IActionResult CMS_Solution_Form()
        {
            return View();
        }
        //Product Management
        public IActionResult CMS_Product()
        {
            return View();
        }
        public IActionResult CMS_Product_Form(int a = 0)
        {
            ViewBag.Action = a.ToString();
            return View();
        }
        //===========================
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }
    }
}
