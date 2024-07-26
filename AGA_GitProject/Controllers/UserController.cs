using Microsoft.AspNetCore.Mvc;

namespace AGA_GitProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
