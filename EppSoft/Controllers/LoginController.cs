using Microsoft.AspNetCore.Mvc;

namespace EppSoft.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}