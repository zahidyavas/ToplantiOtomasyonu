using Microsoft.AspNetCore.Mvc;

namespace ToplantiOtomasyonu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
