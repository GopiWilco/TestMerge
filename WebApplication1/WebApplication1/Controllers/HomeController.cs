using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amazon;
using Amazon.QuickSight;
using Amazon.QuickSight.Model;
using Amazon.Runtime;
using WebApplication1.Models.QuickSight;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //QuicksightDashboard.CreateQuickSightGroup();

            var url = QuicksightDashboard.GetUrl();


            return View();
        }
        
        public Brnahc()
        {
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
