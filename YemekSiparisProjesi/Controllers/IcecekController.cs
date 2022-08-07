using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    public class IcecekController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Icecek
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IcecekEkle()
        {
            Icecek icecek = new Icecek();
            return View(icecek);
        }
        [HttpPost]
        public ActionResult IcecekEkle(Icecek icecek)
        {
            Icecek yeniIcecek = y.Icecek.FirstOrDefault(x => x.IcecekNo == icecek.IcecekNo);
            if (yeniIcecek == null)
            {
                y.Icecek.Add(icecek);
            }
            else
            {
                yeniIcecek.IcecekAd = icecek.IcecekAd;
                yeniIcecek.IcecekFiyat = icecek.IcecekFiyat;
                yeniIcecek.IcecekAdet = icecek.IcecekAdet;

            }
            y.SaveChanges();

            return RedirectToAction("IcecekEkle");
          
        }
      
    }
}