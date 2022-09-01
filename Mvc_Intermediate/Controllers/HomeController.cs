using Mvc_Intermediate.Models;
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
            UrunKategoriModel model = new UrunKategoriModel();
            model.Urunler = Veritabani.Liste.Where(i => i.SatistaMi).ToList();
            model.UrunSayisi = model.Urunler.Count();

            //ViewBag.UrunSayisi = 
            //ViewBag.Kategoriler = kategoriler;

            return View(model);

        }

        public ActionResult Details(int id)
        {
            var urun =Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();

            return View(urun);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(Urun urun)
        {
            var lastId = (Veritabani.Liste.Select(x => x.UrunId)).Max();
            urun.UrunId = lastId + 1;
            Veritabani.ElemanEkle(urun);
            return View("UrunListe", Veritabani.Liste);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}