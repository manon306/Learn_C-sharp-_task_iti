namespace Day3_task
{
    public abstract class AddBounus
    {
        public abstract void ShowBonus();
        
    }
     public class employee   : AddBounus
    {
        //data fields
            private int id;
            private string name;
            private int age;
            private int salary;
            
        //constructors
            public employee() { }
            public employee(int Id, string Name, int Age, int Salary)
        {
            id= Id;
            name= Name;
            age= Age;
            salary= Salary;
        }
        
        //methods
             public  override void ShowBonus()
                {
                    
                }
            public void Print()
            {
                Console.WriteLine(@$"
                Your info are :
                    Id      : {id}
                    name    : {name}
                    age     : {age}
                    salary  : {salary}"
                                    );
            }
        //getter and setters
            public void SetName(string Name)
            {
                name = Name;
            }
            public string GetName()
            {
                return name;
            }
            public void SetAge(int Age)
        {
            if (Age > 0)
            {
                age = Age;
            }
            else
            {
                Console.WriteLine("Age must be positive.");
            }
        }
            public int GetAge()
        {
            return age;
        }
            public void SetID(int Id)
        {
            if (Id > 0)
            {
                id = Id;
            }
            else
            {
                Console.WriteLine("ID must be a positive number.");
            }
        }
            public int GetID()
            {
                return id;
            }
            public void Setsalary(int Salary)
            {
                if (Salary > 0)
                {
                    salary = Salary;
                }
                else
                {
                    Console.WriteLine("Salary must be positive.");
                }
        }
            public int Getsalary()
            {
                return salary;
            }
            public void SetAllData(string Name, int Age, int Id)
            {
                id = Id;
                name = Name;
                age = Age;
                Console.WriteLine($" all data added success : Name: {name}, Age: {age}, ID: {id}");
            }
           
    }
}
