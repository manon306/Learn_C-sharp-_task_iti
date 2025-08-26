using Microsoft.AspNetCore.Mvc;

namespace MvcTranning2.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
