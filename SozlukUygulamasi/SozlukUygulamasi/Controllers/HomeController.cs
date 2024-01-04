using Microsoft.AspNetCore.Mvc;
using SozlukUygulamasi.Models;
using System.Diagnostics;

namespace SozlukUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _context;
        public HomeController(MyDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Sozluk s)
        {
            var model=_context.Sozluk.FirstOrDefault(x => x.Tr == s.Tr);
            if (model!=null)
            {
                ViewBag.Sonuc = model.En;
            }
            else
            {
                ViewBag.Sonuc = "Böyle bir kelime bulunamadı.";
            }
            return View();
        }

    }
}