namespace Student.DAL.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int age { get; set; }
        public Student.DAL.Enum.Type Type { get; set; }
        public int? ClassID { get; set; }
        public Class? Class { get; set; }
    }
}
