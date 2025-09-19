using Microsoft.AspNetCore.Mvc;
using ToplantiOtomasyonu.Models;

namespace ToplantiOtomasyonu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Selamlama =  saat < 12 ? "Günaydın" : saat < 18 ? "İyi Günler" : "İyi Akşamlar";
            int UserCount = UserData.Users.Where(i => i.Attend == true).Count();

            var MeetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Bursa - Merinos Atatürk Kongre Kültür Merkezi",
                Date = new DateTime(2026, 06, 29, 19, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(MeetingInfo);
        }
    }
}
