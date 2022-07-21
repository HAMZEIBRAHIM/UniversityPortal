    using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmintion.Controllers
{
    public class AplicaionController : Controller
    {
        public IActionResult App()
        {
            return View();
        }
        public IActionResult process()
        {
            return View();
        }
    }
}
