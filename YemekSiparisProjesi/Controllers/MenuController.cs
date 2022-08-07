using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Controllers
{
    public class MenuController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuEkle()
        {
            Menu m = new Menu();  
            return View(m);
        }
        [HttpPost]
        public ActionResult MenuEkle(Menu m)
        {
            Menu yeniMenu = y.Menu.FirstOrDefault(x => x.MenuNo == m.MenuNo);
            if (yeniMenu == null)
            {
                y.Menu.Add(m);
            }
            else
            {
                yeniMenu.MenuAd = m.MenuAd;
                yeniMenu.MenuFiyat = m.MenuFiyat;

            }
            y.SaveChanges();

            return RedirectToAction("MenuEkle");
            
        }
        //[HttpPost]
        //public ActionResult MenuGuncelle(int id)
        //{
        //    Menu guncelMenu = y.Menu.FirstOrDefault(x => x.MenuNo == id);
        //    return View("MenuEkle", guncelMenu);
        //}
    }
}