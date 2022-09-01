using Mvc_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Intermediate.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori { Id = 1, Name = "Telefon" },
                new Kategori { Id = 2, Name = "Tablet" },
                new Kategori { Id = 3, Name = "Laptop" }
            };

            return PartialView("KategoriMenu", kategoriler);
        }
    }
}