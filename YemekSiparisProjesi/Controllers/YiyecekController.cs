using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    public class YiyecekController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Yiyecek
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult yiyecekEkle()
        {
            Yiyecek yiyecek = new Yiyecek();
            return View(yiyecek);
        }
        [HttpPost]
        public ActionResult yiyecekEkle(Yiyecek yiyecek)
        {
            Yiyecek yeniYiyecek = y.Yiyecek.FirstOrDefault(x => x.YiyecekNo == yiyecek.YiyecekNo);
            if (yeniYiyecek == null)
            {
                y.Yiyecek.Add(yiyecek);
            }
            else
            {
                yeniYiyecek.YiyecekAd = yiyecek.YiyecekAd;
                yeniYiyecek.YiyecekFiyat = yiyecek.YiyecekFiyat;
                yeniYiyecek.YiyecekAdet = yiyecek.YiyecekAdet;

            }
            y.SaveChanges();

            return RedirectToAction("yiyecekEkle");
        }
        
    }
}