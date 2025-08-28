namespace Sempa.BLL.VM.UserVm
{
    public class GetAllVm
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public DateTime CreatedAt { get;  set; }
        public string imagePath { get; set; }
        public Sempa.DAL.Enum.UserType UserType { get;  set; }


    }
}
