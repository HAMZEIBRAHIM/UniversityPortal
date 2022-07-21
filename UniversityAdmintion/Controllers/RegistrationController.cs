using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmintion.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
