using System;

namespace Day3_task
{
    class User : employee
    {
        public User() { }
        public User(int id, string name, int age, int salary)
            : base(id, name, age, salary) { }
        public override void ShowBonus()
        {
            Console.WriteLine("30%");
        }
        public static void ShowMenu()
        {
            employee[] employees = new employee[10];
            int count = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
                **************************************************************
                 MENU:
                     1 - ADD
                     2 - EDIT
                     3 - DELETE
                     4 - GET ALL
                     5 - GET BY ID
                     6 - EXIT
                **************************************************************
                ");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 6)
                    return;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter ID, Name, Age, Salary:");

                        int id = int.Parse(Console.ReadLine());
                        while (id <= 0)
                        {
                            Console.WriteLine("ID must be a positive number:");
                            id = int.Parse(Console.ReadLine());
                        }

                        string name = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Name cannot be empty. Please enter again:");
                            name = Console.ReadLine();
                        }

                        int age = int.Parse(Console.ReadLine());
                        while (age <= 0)
                        {
                            Console.WriteLine("Age must be a positive number:");
                            age = int.Parse(Console.ReadLine());
                        }

                        int salary = int.Parse(Console.ReadLine());
                        while (salary <= 0)
                        {
                            Console.WriteLine("Salary must be a positive number:");
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
                                while (string.IsNullOrWhiteSpace(newName))
                                {
                                    Console.WriteLine("Name cannot be empty. Please enter again:");
                                    newName = Console.ReadLine();
                                }

                                int newAge = int.Parse(Console.ReadLine());
                                while (newAge <= 0)
                                {
                                    Console.WriteLine("Age must be a positive number:");
                                    newAge = int.Parse(Console.ReadLine());
                                }

                                int newSalary = int.Parse(Console.ReadLine());
                                while (newSalary <= 0)
                                {
                                    Console.WriteLine("Salary must be a positive number:");
                                    newSalary = int.Parse(Console.ReadLine());
                                }

                                employees[i].SetName(newName);
                                employees[i].SetAge(newAge);
                                employees[i].Setsalary(newSalary);
                                Console.WriteLine("Employee updated successfully!");
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
