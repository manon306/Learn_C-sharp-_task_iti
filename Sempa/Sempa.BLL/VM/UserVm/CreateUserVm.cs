using Sempa.DAL.Enum;
namespace Sempa.BLL.VM.UserVm
{
    public class CreateUserVm
    {
        [Required(ErrorMessage = "Must Be Enter First name")]
        [MinLength(3, ErrorMessage = "First name must be at least 3 characters long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must Be Enter Last name")]
        [MinLength(3, ErrorMessage = "Last name must be at least 3 characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must Be Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must Be Enter Password")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        public IFormFile Profile { get; set; }

        public Sempa.DAL.Enum.UserType UserType { get; set; } = DAL.Enum.UserType.Student;
        [Required(ErrorMessage = "Please select a class")]
        public int ClassId { get; set; }
    }
}
