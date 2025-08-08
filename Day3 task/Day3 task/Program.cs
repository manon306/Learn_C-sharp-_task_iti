using System.Diagnostics.Metrics;

namespace Day3_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[10];
            int count = 0; 
            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
                **************************************************************
                 MENU:
                     1-ADD
                     2-EDIT
                     3-Delete
                     4-GET ALL
                     5-GET BY ID
                     6-Exit
                **************************************************************
                ");
                Console.WriteLine("Enter your choise");
                int choise = int.Parse(Console.ReadLine());
                if (choise == 6)
                    return;
                
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter ID, Name, Age, Salary:");
                        int id = int.Parse(Console.ReadLine());
                        while (true)
                        {
                            if (id <= 0 || char.IsLetter((char)id))
                            {
                                Console.WriteLine("ID must be a positive number and not a letter. Please enter again:");
                                id = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                break;
                            }
                        }
                        string name = Console.ReadLine();
                        while (name == null || name == " ")
                        {
                            Console.WriteLine("Name cannot be empty. Please enter again:");
                            name = Console.ReadLine();
                        }
                        int age = int.Parse(Console.ReadLine());
                        while (age <= 0)
                        {
                            Console.WriteLine("Age must be a positive number. Please enter again:");
                            age = int.Parse(Console.ReadLine());
                        }
                        int salary = int.Parse(Console.ReadLine());
                        while (salary <= 0)
                        {
                            Console.WriteLine("Salary must be a positive number. Please enter again:");
                            salary = int.Parse(Console.ReadLine());
                        }

                        if (count < employees.Length)
                        {
                            employees[count] = new employee(id, name, age, salary);
                            count++;
                            Console.WriteLine("Employee added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Array is full! Cannot add more employees.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID to edit:");
                        id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            if (employees[i].GetID() == id)
                            {
                                Console.WriteLine("Enter new Name, Age, Salary:");
                                string newName = Console.ReadLine();
                                while (newName == null || newName == " ")
                                {
                                    Console.WriteLine("Name cannot be empty. Please enter again:");
                                    newName = Console.ReadLine();
                                }
                                int newAge = int.Parse(Console.ReadLine());
                                while (newAge <= 0)
                                {
                                    Console.WriteLine("Age must be a positive number. Please enter again:");
                                    newAge = int.Parse(Console.ReadLine());
                                }
                                int newSalary = int.Parse(Console.ReadLine());
                                while (newSalary <= 0)
                                {
                                    Console.WriteLine("Salary must be a positive number. Please enter again:");
                                    newSalary = int.Parse(Console.ReadLine());
                                }
                                employees[i].SetName(newName);
                                employees[i].SetAge(newAge);
                                employees[i].Setsalary(newSalary);
                                Console.WriteLine("Employee details updated successfully!");
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter ID to delete:");
                        id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            if (employees[i].GetID() == id)
                            {
                                // Shift elements to the left
                                for (int j = i; j < count - 1; j++)
                                {
                                    employees[j] = employees[j + 1];
                                }
                                employees[count - 1] = null;
                                count--;
                                Console.WriteLine("Employee deleted successfully!");
                                break;
                            }
                        }
                        break;
                    case 4:
                        for (int i = 0; i < count; i++)
                        {
                            employees[i].Print();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter ID to get employee details:");
                        id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            if (employees[i].GetID() == id)
                            {
                                employees[i].Print();
                                break;
                            }
                        }
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }
        }
    }
}
