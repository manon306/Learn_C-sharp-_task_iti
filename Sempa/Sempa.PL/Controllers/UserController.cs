using Sempa.BLL.VM.UserVm;

namespace Sempa.PL.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult create()
        {


            return View();
        }
        [HttpPost]
        public IActionResult create(CreateUserVm user)
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
                    return RedirectToAction("GetAlls", "User");
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
