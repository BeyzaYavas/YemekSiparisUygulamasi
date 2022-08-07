using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSiparisProjesi.Models;


namespace YemekSiparisProjesi.Controllers
{
    public class SiparisController : Controller
    {
       YemekSiparisEntities y = new YemekSiparisEntities(); 
        // GET: Siparis
        public ActionResult Index()
        {
            List<Siparis> siparislerListesi = y.Siparis.ToList();
            return View(siparislerListesi);
        }

        //[HttpPost]
        //public string SiparisEkle(int id)
        //{
        //    //Siparis siparis = y.Siparis.FirstOrDefault(x => x.SiparisNo == id);
        //    Siparis siparis = new Siparis();

        //    var kullaniciAd = User.Identity.Name;
        //    var kullanici1 = y.Kullanici.FirstOrDefault(x => x.KullaniciAd == kullaniciAd);

        //    siparis.SiparisTarih = DateTime.Now;
        //    siparis.SiparisTutar = id;
        //    siparis.KullaniciNo = kullanici1.KullaniciNo;
        //    y.Siparis.Add(siparis);
        //    y.SaveChanges();
        //    return "başarılı";
        //}

        [HttpPost]
        public ActionResult SiparisEkle(float id)
        {

            Siparis siparis = new Siparis();

            //var kullaniciAd = User.Identity.Name;
            //var kullanici1 = y.Kullanici.FirstOrDefault(x => x.KullaniciAd == kullaniciAd);

            //siparis.SiparisTarih = DateTime.Now;
            //siparis.SiparisTutar = id;
            //siparis.KullaniciNo = kullanici1.KullaniciNo;
            //y.Siparis.Add(siparis);
            //y.SaveChanges();
            //return View("/Siparis/Index");

           

            
            var kullaniciMail = Session["AktifMail"].ToString();
            var kullanici1 = y.Kullanici.FirstOrDefault(x => x.MailAdress == kullaniciMail);

            siparis.SiparisTarih = DateTime.Now;
            siparis.SiparisTutar = id;
            siparis.KullaniciNo = kullanici1.KullaniciNo;
            y.Siparis.Add(siparis);
            y.SaveChanges();
            return View("/Siparis/Index");


        }

    }
}