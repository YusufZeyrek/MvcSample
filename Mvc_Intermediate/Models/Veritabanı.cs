using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Intermediate.Models
{
    public static class Veritabani
    {
        private static List<Urun> _liste;

        static Veritabani()
        {
            _liste = new List<Urun>()
            {
                new Urun
                {
                     UrunId = 1, UrunAdi = "Samsung S6", Aciklama= "idare eder", Fiyat= 1000, SatistaMi = true, Resim = "1.jpg"
                },
                 new Urun
                {
                     UrunId = 2, UrunAdi = "Samsung S7", Aciklama= "idare eder", Fiyat= 2000, SatistaMi = false, Resim = "1.jpg"
                },
                  new Urun
                {
                     UrunId = 3, UrunAdi = "Samsung S8", Aciklama= "idare eder", Fiyat= 3000, SatistaMi = true, Resim = "1.jpg"
                },
                   new Urun
                {
                     UrunId = 4, UrunAdi = "Iphone 6S", Aciklama= "idare eder", Fiyat= 4000, SatistaMi = true, Resim = "1.jpg"
                },
                    new Urun
                {
                     UrunId = 5, UrunAdi = "Iphone 7S", Aciklama= "idare eder", Fiyat= 5000, SatistaMi = false, Resim = "1.jpg"
                },
            };
        }

        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }

        public static Urun UrunDetay(int urunId)
        {
            return _liste.Where(l => l.UrunId == urunId).FirstOrDefault();
        }
    }
}