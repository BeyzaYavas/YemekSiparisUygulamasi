using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    public class KuryeController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();

        // GET: Kurye
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult kuryeListele()
        {
            List < Kurye > kuryeList = y.Kurye.ToList();
            return View(kuryeList);
        }

        public ActionResult kuryeEkle()
        {
            Kurye k = new Kurye();
            return View(k);

        }
        [HttpPost]
        public ActionResult kuryeEkle(Kurye k)
        {
            Kurye yeniKurye = y.Kurye.FirstOrDefault(x=>x.KuryeNo==k.KuryeNo);
            if (yeniKurye == null)
            {
                y.Kurye.Add(k);
            }
            else
            {
                yeniKurye.KuryeAd = k.KuryeAd;
                yeniKurye.KuryeSoyad = k.KuryeSoyad;
                yeniKurye.KuryeTelNo = k.KuryeTelNo;
                yeniKurye.IsletmeNo = k.IsletmeNo;
            }
            y.SaveChanges();
            return RedirectToAction("KuryeListele");

        }

        public ActionResult kuryeGuncelle(int id)
        {
            Kurye kurye = y.Kurye.FirstOrDefault(x => x.KuryeNo == id);
            return View("kuryeEkle", kurye);
        }
    }
}