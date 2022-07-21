using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmintion.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
