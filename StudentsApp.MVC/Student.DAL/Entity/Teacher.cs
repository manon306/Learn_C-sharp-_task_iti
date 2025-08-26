namespace Student.DAL.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public List<Class> Class { get; set; }
        public int? ClassID { get; set; }
    }
}
