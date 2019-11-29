using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class HomeController : Controller
    {


        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Home/Items")]
        public ActionResult Items()
        {



            return View();
        }

        [Route("Home/Orders")]
        public ActionResult Orders()
        {

            return View();
        }
    }
}