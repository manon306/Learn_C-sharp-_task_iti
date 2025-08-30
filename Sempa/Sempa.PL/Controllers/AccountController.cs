namespace Sempa.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<LogInUser> userManager;
        private readonly SignInManager<LogInUser> signInManager;

        public AccountController(UserManager<LogInUser> userManager, SignInManager<LogInUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm model)
        {
            if (ModelState.IsValid)
            {
                var user = new LogInUser()
                {
                    UserName = model.Name,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVm model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("GetAll", "Class");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserName Or Password");

                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
