using Microsoft.AspNetCore.Mvc;

namespace MVCTESET.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
