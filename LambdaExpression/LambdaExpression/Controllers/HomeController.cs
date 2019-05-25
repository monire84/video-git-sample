using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LambdaExpression.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // test commit
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hi Git";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}