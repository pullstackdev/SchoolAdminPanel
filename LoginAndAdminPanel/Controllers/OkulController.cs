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
    public class OkulController : Controller
    {
        Context context = new Context();
        public IActionResult Index(int page = 1)
        {
            List<Okul> okuls = new List<Okul>();
            okuls = context.Okuls.ToList();
            return View(okuls.ToPagedList(page, 10));
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
        }

        public IActionResult Delete(int id)
        {
            var deletedOkul = context.Okuls.Where(x => x.Id == id).FirstOrDefault();
            deletedOkul.IsActive = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updatedOkul = context.Okuls.Include("Kurucu").Where(x => x.Id == id).FirstOrDefault();
            return View(updatedOkul);
        }
        [HttpPost]
        public IActionResult Update(Okul okul)
        {
            context.Okuls.Update(okul);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
