using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomErrorPageMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string result = "";
            List<CustomClass> newlist;

            //newlist = Helper.FullList();
            newlist = Helper.FullListError();
            


            if (newlist.Count() > 0)
                result = "hello";

            ViewBag.Message = result;

            return View();
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