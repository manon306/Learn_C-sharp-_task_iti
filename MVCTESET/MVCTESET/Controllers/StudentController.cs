using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCTESET.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext DB;
        public StudentController()
        {
            DB = new();
        }

        public IActionResult Index()
        {
            var query = DB.S.AsQueryable();
            var result = DB.S.ToList();
            return View(result);
        }
    }
}
