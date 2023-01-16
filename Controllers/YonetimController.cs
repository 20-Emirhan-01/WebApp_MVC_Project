using Microsoft.AspNetCore.Mvc;
using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Controllers
{
    public class YonetimController : Controller
    {
        public IActionResult Yonetimsayfası()
        {
            return View();
        }
        public IActionResult Yeni()
        {
            return View();
        }
        public IActionResult YonetimDetay(int id)
        {
            var r = Models.YonetimVeri.Yöneticiler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult YonetimSil(int id)
        {
            var r = Models.YonetimVeri.Yöneticiler.FirstOrDefault(x => x.Id == id);
            Models.YonetimVeri.Yöneticiler.Remove(r);
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public IActionResult Yeni(Yonetim yonetim)
        {
            Models.YonetimVeri.Yöneticiler.Add(yonetim);
            return View();
        }
        
        [HttpPost]
        public IActionResult YonetimDetay(Yonetim yonetim)
        {
            var r = Models.YonetimVeri.Yöneticiler.FirstOrDefault(x => x.Id == yonetim.Id);
            Models.YonetimVeri.Yöneticiler.Remove(r);
            Models.YonetimVeri.Yöneticiler.Add(yonetim);
            return RedirectToAction("Listele");
        }
        public IActionResult listele()
        {
            return View(Models.YonetimVeri.Yöneticiler);
        }
    }
}
