using Microsoft.AspNetCore.Mvc;
using MVC_DAY_1.Models;

namespace MVC_DAY_1.Controllers
{
    public class ClassController : Controller
    {
        private readonly AppDbContext DB;

        public ClassController()
        {
            DB = new();
        }

        public IActionResult Index()
        {
            var classes = DB.Classes.ToList();
            foreach (var c in classes)
            {
                c.Students = DB.S.Where(s => s.ClassID == c.ID).ToList();
            }
            return View(classes);
        }

    }
}
