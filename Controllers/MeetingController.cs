using Microsoft.AspNetCore.Mvc;
using ToplantiOtomasyonu.Models;

namespace ToplantiOtomasyonu.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet] // Default hali get requestidir
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            UserData.CreateUser(model);
            ViewBag.UserCount = UserData.Users.Where(i => i.Attend == true).Count();
            return View("Thanks", model);
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(UserData.Users);
        }
        public IActionResult Details(int id)
        {
            return View(UserData.GetById(id));
        }
    }
}
