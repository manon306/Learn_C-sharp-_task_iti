namespace Students.BLL.ModelVM.Class
{
    public class GetAllClass
    {
        public string name { get; set; }
        public List<User> users { get; set; }
        public List<Student.DAL.Entity.Teacher> teachers { get; set; }
    }
}
