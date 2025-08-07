using System.Xml.Linq;

namespace day2_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("*****************************text check task*****************************");
                Console.WriteLine("*****************************************************************************");
                string text;

                while (true)
                {
                    Console.WriteLine("Enter your text:");
                    text = Console.ReadLine();

                    bool isValid = true;

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (!char.IsLetter(text[i]) )
                        {
                            Console.WriteLine("Invalid text. Only letters allowed.");
                            isValid = false;
                            break; 
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine("Valid text: " + text);
                        break;
                    }
                }
                Console.WriteLine("*********************************************************************************************");

            #endregion
            #region task 2
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("*****************************Multiblication task*****************************");
                Console.WriteLine("*****************************************************************************");
                for(int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"#############################Multiplication table for {i}:######################");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    Console.WriteLine("*****************************************************************************");
                }
                Console.WriteLine("*****************************************************************************");
            #endregion
            #region task 3
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*****************************validation task*****************************");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Please enter your information for validation:");
            ///---------------------------------------------ID--------------------------------------------------
            int id;
            while (true)
            {
                Console.Write("Enter your ID (positive number): ");
                string input = Console.ReadLine();
                bool valid = true;


                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (ch < '0' || ch > '9')
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    id = int.Parse(input);
                    Console.WriteLine("Valid ID");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID! ID must be a number");
                }
            }
            //---------------------------------------------age--------------------------------------------------
            int age;
            while (true)
            {
                Console.Write("enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age < 21)
                {
                    Console.WriteLine("you must be greater than 21");
                }
                else
                {
                    Console.WriteLine("You are valid");
                    break;
                }
            }
            //---------------------------------------------salary--------------------------------------------------
            int salary;
            while (true)
            {
                Console.Write("enter your salary: ");
                salary = int.Parse(Console.ReadLine());
                if (salary < 1000)
                {
                    Console.WriteLine("invalid salary");
                }
                else
                {
                    Console.WriteLine("valid salary");
                    break;
                }
            }
            //---------------------------------------------name--------------------------------------------------
            string name;
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                bool valid = true;

                if (name == null || name.Length == 0)
                {
                    Console.WriteLine("Invalid name: name can't be empty.");
                    continue;
                }

                for (int i = 0; i < name.Length; i++)
                {
                    char ch = name[i];
                    if (ch >= '0' && ch <= '9')
                    {
                        valid = false;
                        Console.WriteLine("Invalid name: name can't contain numbers.");
                        break;
                    }
                }

                if (valid)
                {
                    Console.WriteLine("Valid name");
                    break;
                }
            }
            //---------------------------------------------email--------------------------------------------------
            string email;
            while (true)
            {
                Console.Write("enter your email: ");
                email = Console.ReadLine();
                if (email == null || email.Length == 0 || !email.Contains("@") || !email.Contains("."))
                {
                    Console.WriteLine("invalid email");
                }
                else
                {
                    Console.WriteLine("valid email");
                    break;
                }
            }

            //---------------------------------------------output--------------------------------------------------
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*****************************Your Information*****************************");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("\n--- Your Info ---");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("*******************************************************************************");
            #endregion
        }
    }
}
