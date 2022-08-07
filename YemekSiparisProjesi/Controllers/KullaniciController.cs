using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;
using System.Web.Security; //sistem çerezleri için

namespace YemekSiparisProjesi.Controllers
{
    [AllowAnonymous]
    public class KullaniciController : Controller
    {
        YemekSiparisEntities y = new YemekSiparisEntities();
        // GET: Kullanici
        public ActionResult Index(Kullanici k)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public ActionResult Login(Kullanici k)
        //{

        //    if (!string.IsNullOrEmpty(k.MailAdress) && !string.IsNullOrEmpty(k.KullaniciSifre))
        //    {
        //        FormsAuthentication.SetAuthCookie(k.MailAdress, false);
        //        return RedirectToAction("Index", "Anasayfa");
        //    }
        //    else
        //    {
        //        ViewBag.mesaj = "Kullanıcı Adı veya Şifreniz Yanlış";
        //        return View();
        //    }

        //}


        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Kullanici k)
        {
            Kullanici model = new Kullanici();
            k.MailAdress = k.MailAdress.Trim();
            k.KullaniciSifre = k.KullaniciSifre.Trim();

            //List<Kullanici> list = y.Kullanici.ToList();
            //Kullanici model = (from kullanici in list
            //                   where kullanici.MailAdress==k.MailAdress
            //                   select kullanici).First();
            model = y.Kullanici.Where(x => x.MailAdress == k.MailAdress && x.KullaniciSifre == k.KullaniciSifre).FirstOrDefault();

            if (k.MailAdress != null)
            {
                FormsAuthentication.SetAuthCookie(k.MailAdress, false);
                Session.Add("AktifMail", k.MailAdress);
                return RedirectToAction("Index", "Anasayfa");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı Adı veya Şifreniz Yanlış";
                return View();
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(Kullanici k,string KullaniciNo1)
        {
            y.Kullanici.Add(k);
            //k.GirisTip.Add(KullaniciNo);
            
            y.SaveChanges();

            return RedirectToAction("Index", "Anasayfa");

        }


    }
}