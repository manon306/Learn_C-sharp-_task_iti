using Microsoft.AspNetCore.Mvc;
using Student.DAL.Entity;
using Students.BLL.Service.Abstraction;
using Students.BLL.Service.Implementation;

namespace Student.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly  IUserService userService;
        public UserController()
        {
            userService  = new UserService();
        }
        public IActionResult GetAll()
        {
            var result =userService.GetAll();
            return View(result);
        }
        public IActionResult create()
        {
            return View();
        }
        public IActionResult saveUser(User user)
        {
            var result =userService.Create(user);
            if (result.Item1 == true)
            {
                return RedirectToAction("GetAll", "User");
            }
            
            return View("Create",user);
        }

    }

}
