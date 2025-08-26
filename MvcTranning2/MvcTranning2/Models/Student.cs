using System.Security.Claims;

namespace MvcTranning2.Models
{
    public class Student
    {
        public Student(string name, int age, string email, string address)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
        }
        public Student()
        {
        }

        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
    }
}
