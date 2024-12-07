using Microsoft.AspNetCore.Mvc;

namespace PB303Fashion.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}