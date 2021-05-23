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
    public class MudurController : Controller
    {
        Context context = new Context();

        public IActionResult Index(int page = 1)
        {
            List<Mudur> mudurs = new List<Mudur>();
            mudurs = context.Mudurs.Include("Okul").ToList();
            return View(mudurs.ToPagedList(page, 10));
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
        }
        public IActionResult Delete(int id)
        {
            var deletedMudur = context.Mudurs.Where(x => x.Id == id).FirstOrDefault();
            deletedMudur.IsActive = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var updatedMudur = context.Mudurs.Include("Kurucu").Include("Okul").Where(x => x.Id == id).FirstOrDefault();
            return View(updatedMudur);
        }
        [HttpPost]
        public IActionResult Update(Mudur mudur)
        {
            context.Mudurs.Update(mudur);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
