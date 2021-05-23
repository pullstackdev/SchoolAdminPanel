using LoginAndAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LoginAndAdminPanel.Controllers
{
    public class OgrenciController : Controller
    {
        Context context = new Context();

        public IActionResult Index(int page = 1)
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis = context.Ogrencis.Include("Okul").Include("Ogretmen").ToList();
            return View(ogrencis.ToPagedList(page, 10));
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
        }
        public IActionResult Delete(int id)
        {
            var deletedOgrenci = context.Ogrencis.Where(x => x.Id == id).FirstOrDefault();
            deletedOgrenci.IsActive = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var updatedOgrenci = context.Ogrencis.Include("Kurucu").Include("Okul").Include("Mudur").Include("Ogretmen").Where(x => x.Id == id).FirstOrDefault();
            return View(updatedOgrenci);
        }
        [HttpPost]
        public IActionResult Update(Ogrenci ogrenci)
        {
            context.Ogrencis.Update(ogrenci);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
