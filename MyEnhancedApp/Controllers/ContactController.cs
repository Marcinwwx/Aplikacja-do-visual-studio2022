using Microsoft.AspNetCore.Mvc;

namespace MyEnhancedApp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string name, string email, string message)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Message = message;
            return View("ThankYou");
        }
    }
}
