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
        [HttpGet]

        [HttpPost]
        public IActionResult GetAlls()
        {
            var result = userService.GetAll(); // لو عايز كلهم
            if (!result.Item1)
            {
                ViewBag.ErrorMessage = result.Item3;
                return View();
            }

            return View(result.Item2); 
        }

    }
}
