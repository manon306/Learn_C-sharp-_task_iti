using Microsoft.AspNetCore.Mvc;
using Student.DAL.Entity;
using Students.BLL.Service.Abstraction;
using Students.BLL.Service.Implementation;

namespace Student.MVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;
        public TeacherController()
        {
            teacherService = new TeacherService();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var result = teacherService.GetAll();
            return View(result);
        }
        public IActionResult saveTeacher(Teacher t)
        {
            var result = teacherService.Create(t);
            if (result.Item1 == true)
            {
                return RedirectToAction("GetAll", "Teacher");
            }
            return View("create" , t);
        }
    }
}
