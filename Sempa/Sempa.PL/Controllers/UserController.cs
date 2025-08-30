using Microsoft.AspNetCore.Authorization;
using Sempa.BLL.VM.ClassVm;
using Sempa.BLL.VM.UserVm;

namespace Sempa.PL.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IClassService classService;

        public UserController(IUserService userService, IClassService classService)
        {
            this.userService = userService;
            this.classService = classService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var classes = classService.GetAllClasses();
            if (classes.Item1)
            {
                ViewBag.Classes = classes.Item2;
            }
            else
            {
                throw new Exception(classes.Item3);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserVm user)
        {
            if (ModelState.IsValid)
            {
                var result = userService.Create(user);

                if (result.Item1 == true)
                {
                    return RedirectToAction("GetAlls", "User");
                }
                ViewBag.Message = result.Item2;
            }
            return View(user);
        }
        public IActionResult create_T()
        {
            var classes = classService.GetAllClasses();
            if (classes.Item1)
            {
                ViewBag.Classes = classes.Item2;
            }
            else
            {
                throw new Exception(classes.Item3);
            }
            return View();
        }
        [HttpPost]
        public IActionResult create_T(CreateTeacherVm user)
        {

            if (ModelState.IsValid)
            {
                var result = userService.Create_T(user);

                if (result.Item1 == true)
                {
                    return RedirectToAction("GetAll_T", "User");
                }
                ViewBag.Message = result.Item2;

            }
            return View(user);
        }

        [HttpGet]
        public IActionResult GetAlls()
        {
            var result = userService.GetAll();
            if (!result.Item1)
            {
                ViewBag.ErrorMessage = result.Item3;
                return View();
            }

            return View(result.Item2); 
        }

        [HttpGet]
        public IActionResult GetAll_T()
        {
            var result = userService.GetAll_T(); 
            if (!result.Item1)
            {
                ViewBag.ErrorMessage = result.Item3;
                return View();
            }

            return View(result.Item2);
        }

    }
}
