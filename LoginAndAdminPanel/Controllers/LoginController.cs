using LoginAndAdminPanel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string password, string kullaniciAdi, string radioValue)
        {
            if (radioValue=="Kurucus")
            {
                var isExist = context.Kurucus.Where(x => x.KullaniciAdi == kullaniciAdi && x.Password == password).FirstOrDefault();
                if (isExist!=null )
                {
                    HttpContext.Session.SetString("SessionName", isExist.Isim);
                    HttpContext.Session.SetInt32("SessionRole", Convert.ToInt32(isExist.Role));
                    return RedirectToAction("Index", "Kurucu");
                }
                return View();
                
            }
            else if (radioValue == "Mudurs")
            {
                var isExist = context.Mudurs.Where(x => x.KullaniciAdi == kullaniciAdi && x.Password == password).FirstOrDefault();
                if (isExist != null)
                {
                    HttpContext.Session.SetString("SessionName", isExist.Isim);
                    HttpContext.Session.SetInt32("SessionRole", Convert.ToInt32(isExist.Role));
                    return RedirectToAction("Index", "Mudur");
                }
                return View();
            }
            else if (radioValue == "Ogretmens")
            {
                var isExist = context.Ogretmens.Where(x => x.KullaniciAdi == kullaniciAdi && x.Password == password).FirstOrDefault();
                if (isExist != null)
                {
                    HttpContext.Session.SetString("SessionName", isExist.Isim.ToString());
                    HttpContext.Session.SetInt32("SessionRole", Convert.ToInt32(isExist.Role));
                    ViewBag.name = HttpContext.Session.GetString("SessionName");
                    return RedirectToAction("Index", "Ogretmen");
                }
                return View();
            }
            else if (radioValue == "Ogrencis")
            {
                var isExist = context.Ogrencis.Where(x => x.KullaniciAdi == kullaniciAdi && x.Password == password).FirstOrDefault();
                if (isExist != null)
                {
                    HttpContext.Session.SetString("SessionName", isExist.Isim);
                    HttpContext.Session.SetInt32("SessionRole", Convert.ToInt32(isExist.Role));
                    return RedirectToAction("Index", "Ogrenci");
                }
                return View();
            }
            
            return View();
        }

    }
}
