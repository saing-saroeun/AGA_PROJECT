using Microsoft.AspNetCore.Mvc;

namespace AGA_GitProject.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
