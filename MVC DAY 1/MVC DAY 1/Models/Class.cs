namespace MVC_DAY_1.Models
{
    public class Class
    {
        public Class()
        {
                
        }
        public Class(int iD, string name, List<Student> students)
        {
            ID = iD;
            Name = name;
            Students = students;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
