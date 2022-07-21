using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmintion.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Singin()
        {
            return View();
        }

        public IActionResult Forgot()
        {
            return View();
        }

    }
}
