using Microsoft.AspNetCore.Mvc;

namespace constructor.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index(int sayi1=0, int sayi2 = 0)
        {
            int sonuc = sayi1 + sayi2;
            ViewBag.snc = sonuc;
            return View();
        }
    }
}
