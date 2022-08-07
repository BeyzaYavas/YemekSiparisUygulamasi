using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    [AllowAnonymous]
    public class AnasayfaController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        
        [HttpGet]
        
        public ActionResult IsletmeBul(string IsletmeAd)
        {
            IsletmeAd = IsletmeAd.Trim();
            
               List<Isletme> degerBul = y.Isletme.Where(x => x.IsletmeAd.Contains(IsletmeAd)).ToList();
               ViewBag.IsletmeBul = degerBul;
            


            return View();
            
        }

        
        
    }
}