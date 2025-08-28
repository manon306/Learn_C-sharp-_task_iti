namespace Sempa.DAL.Entity
{
    public class CLass
    {
        public CLass() { }
        public CLass(string name, List<User> students)
        {
            Name = name;
            Students = students;
        }

        public int ID { get;private set; }
        public string Name { get; private set; }
        public virtual List<User> Students { get; private set; }
        public bool Update(string Name , List<User> Students)
        {
            this.Name = Name;
            this.Students = Students;
            return true;
        }


    }
}
