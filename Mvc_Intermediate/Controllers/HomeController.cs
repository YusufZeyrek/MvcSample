using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            string[] kurslar = { "Mvc Kursu", "web form kursu", "c# kursu" };

            return View(kurslar);
        }
    }
}