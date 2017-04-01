using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2Asp.NetMVCViews.Models
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetView()
        {
            //return View("MyView");

            if (false)
            {
                return View("MyView"); }
            else
            {
               // return View("Fork");

            return Content ("helloo........");
            }
        }
    }
}