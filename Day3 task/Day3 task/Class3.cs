using System;

namespace Day3_task
{
    class Programmer : employee
    {
        public Programmer() { }
        public Programmer(int id, string name, int age, int salary)
            : base(id, name, age, salary) { }
        public override void ShowBonus()
        {
            Console.WriteLine("20%");
        }
        public static void ShowMenu()
        {
            int count = 0;
            Programmer[] programmers = new Programmer[10];

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

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter ID, Name, Age, Salary:");

                        int id = int.Parse(Console.ReadLine());
                        while (id <= 0)
                        {
                            Console.WriteLine("ID must be positive:");
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
                            Console.WriteLine("Age must be a positive number. Please enter again:");
                            age = int.Parse(Console.ReadLine());
                        }

                        int salary = int.Parse(Console.ReadLine());
                        while (salary <= 0)
                        {
                            Console.WriteLine("Salary must be positive. Please enter again:");
                            salary = int.Parse(Console.ReadLine());
                        }

                        if (count < programmers.Length)
                        {
                            programmers[count] = new Programmer(id, name, age, salary);
                            count++;
                            Console.WriteLine("Programmer added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Array is full!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter ID to edit:");
                        id = int.Parse(Console.ReadLine());

                        bool found = false;
                        for (int i = 0; i < count; i++)
                        {
                            if (programmers[i].GetID() == id)
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
                                    Console.WriteLine("Age must be a positive number. Please enter again:");
                                    newAge = int.Parse(Console.ReadLine());
                                }

                                int newSalary = int.Parse(Console.ReadLine());
                                while (newSalary <= 0)
                                {
                                    Console.WriteLine("Salary must be a positive number. Please enter again:");
                                    newSalary = int.Parse(Console.ReadLine());
                                }

                                programmers[i].SetName(newName);
                                programmers[i].SetAge(newAge);
                                programmers[i].Setsalary(newSalary);
                                Console.WriteLine("Programmer details updated successfully!");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Programmer with this ID not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter ID to delete:");
                        id = int.Parse(Console.ReadLine());
                        found = false;

                        for (int i = 0; i < count; i++)
                        {
                            if (programmers[i].GetID() == id)
                            {
                                for (int j = i; j < count - 1; j++)
                                {
                                    programmers[j] = programmers[j + 1];
                                }
                                programmers[count - 1] = null;
                                count--;
                                Console.WriteLine("Programmer deleted successfully!");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Programmer with this ID not found.");
                        }
                        break;

                    case "4":
                        for (int i = 0; i < count; i++)
                        {
                            programmers[i].Print();
                        }
                        break;

                    case "5":
                        Console.WriteLine("Enter ID to get programmer details:");
                        id = int.Parse(Console.ReadLine());
                        found = false;

                        for (int i = 0; i < count; i++)
                        {
                            if (programmers[i].GetID() == id)
                            {
                                programmers[i].Print();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Programmer not found.");
                        }
                        break;
                    case "6":
                        return; 

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("\nاضغط زر للمتابعة...");
                Console.ReadKey();
            }
        }
    }
}
