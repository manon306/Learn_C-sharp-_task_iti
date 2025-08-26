namespace Student.DAL.Entity
{
    public class Class
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<User> users { get; set; }
        public List<Teacher> teachers { get; set; }

    }
}
