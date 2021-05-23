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
    public class OgretmenController : Controller
    {
        Context context = new Context();

        public IActionResult Index(int page = 1)
        {
            List<Ogretmen> ogretmens = new List<Ogretmen>();
            ogretmens = context.Ogretmens.Include("Okul").Include("Mudur").ToList();
            return View(ogretmens.ToPagedList(page, 10));
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
        }
        public IActionResult Delete(int id)
        {
            var deletedOgretmen = context.Ogretmens.Where(x => x.Id == id).FirstOrDefault();
            deletedOgretmen.IsActive = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var updatedOgretmen = context.Ogretmens.Include("Kurucu").Include("Okul").Include("Mudur").Where(x => x.Id == id).FirstOrDefault();
            return View(updatedOgretmen);
        }
        [HttpPost]
        public IActionResult Update(Ogretmen ogretmen)
        {
            context.Ogretmens.Update(ogretmen);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
