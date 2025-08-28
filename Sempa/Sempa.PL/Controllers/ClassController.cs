namespace Student.MVC.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService classService;

        public ClassController(IClassService classService)
        {
            this.classService = classService;
        }

        public IActionResult GetAll()
        {
            var (success, classes, students, teachers, error) = classService.GetAll();

            if (!success)
            {
                ViewBag.Error = error;
                return View(new ClassDashboardVM());
            }

            var vm = new ClassDashboardVM
            {
                Classes = classes,
                Students = students,
                Teachers = teachers
            };

            return View(vm);
        }



    }
}
