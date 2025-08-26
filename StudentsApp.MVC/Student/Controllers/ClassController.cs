using Microsoft.AspNetCore.Mvc;
using Student.DAL.Entity;
using Students.BLL.Service.Abstraction;
using Students.BLL.Service.Implementation;

namespace Student.MVC.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService classService;

        public ClassController()
        {
            classService = new ClassService();
        }

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult GetAll()
        {
            var result = classService.GetAll();
            return View(result);
        }


        public IActionResult SaveClass(Class c)
        {
            var result = classService.Create(c);
            if (result.Item1 == true)
            {
                return RedirectToAction("GetAll", "Class");
            }
            return View("Create", c);
        }
    }
}
