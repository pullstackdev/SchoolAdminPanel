using LoginAndAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;


namespace LoginAndAdminPanel.Controllers
{
    public class KurucuController : Controller
    {
        Context context = new Context();
        public IActionResult Index(int page = 1)
        {
            List<Kurucu> kurucus = new List<Kurucu>();
            kurucus = context.Kurucus.ToList();
            return View(kurucus.ToPagedList(page, 10));
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
        }
    }
}
