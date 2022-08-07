using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    public class IsletmeController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Isletme
        public ActionResult Index()
        {
            //List<Isletme> isletmeListe = y.Isletme.ToList();
            
            return View();
        }

        
        public ActionResult IsletmeListele()
        {
            
            List<Isletme> isletmeListe=y.Isletme.ToList();
            //ViewBag.IsletmeListe=isletmeListe;
            return View(isletmeListe);
        }
        
        
        public ActionResult IsletmeSayfasi(Isletme i ,int? id)
        {
            List<Menu_Gor> Menuler = y.Menu_Gor.ToList();
            //ViewBag.menus = Menuler;
            ViewBag.Index = id;
            

            return View(Menuler);
        }

        [HttpPost]     
        public string IsletmeSil(int id)
        {
            Isletme isletme = y.Isletme.FirstOrDefault(x => x.IsletmeNo == id);
            if(isletme != null)
            {
                y.Isletme.Remove(isletme);
                y.SaveChanges();
                return "başarılı";
                
            }

            return "başarısız";


        }

        public ActionResult IsletmeEkle()
        {
            Isletme i = new Isletme();
            //ViewBag.isletme = i;
            return View(i);
        }

        
        [HttpPost]
        
        public ActionResult IsletmeEkle(Isletme i)
        {
            Isletme yeniIsletme = y.Isletme.FirstOrDefault(x => x.IsletmeNo == i.IsletmeNo);
            if (yeniIsletme == null)
            {
                y.Isletme.Add(i);
            }
            else
            {
                yeniIsletme.IsletmeAd = i.IsletmeAd;
                yeniIsletme.IsletmeTelNo = i.IsletmeTelNo;

            }
            y.SaveChanges();
           
            return RedirectToAction("IsletmeListele");
        }

        
        public ActionResult IsletmeGuncelle(int id)
        {
            Isletme obje = y.Isletme.FirstOrDefault(x => x.IsletmeNo== id);
            return View("IsletmeEkle", obje);
        }


    }
}