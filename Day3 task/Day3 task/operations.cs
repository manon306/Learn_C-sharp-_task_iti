//using System;

//namespace Day3_task
//{
//    public class EmployeeOperations
//    {
//        public void AddEmployee([], ref int count)
//        {
//            if (count >= employees.Length)
//            {
//                Console.WriteLine("Array is full!");
//                return;
//            }

//            Console.WriteLine("Enter ID:");
//            int id = int.Parse(Console.ReadLine());
//            while (id <= 0)
//            {
//                Console.WriteLine("ID must be positive:");
//                id = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Enter Name:");
//            string name = Console.ReadLine();
//            while (string.IsNullOrWhiteSpace(name))
//            {
//                Console.WriteLine("Name cannot be empty. Enter again:");
//                name = Console.ReadLine();
//            }

//            Console.WriteLine("Enter Age:");
//            int age = int.Parse(Console.ReadLine());
//            while (age <= 0)
//            {
//                Console.WriteLine("Age must be positive:");
//                age = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Enter Salary:");
//            int salary = int.Parse(Console.ReadLine());
//            while (salary <= 0)
//            {
//                Console.WriteLine("Salary must be positive:");
//                salary = int.Parse(Console.ReadLine());
//            }

//            employees[count] = new employee(id, name, age, salary);
//            count++;
//            Console.WriteLine("Employee added successfully!");
//        }

//        public void EditEmployee(employee[] employees, int count)
//        {
//            Console.WriteLine("Enter ID to edit:");
//            int id = int.Parse(Console.ReadLine());

//            for (int i = 0; i < count; i++)
//            {
//                if (employees[i].GetID() == id)
//                {
//                    Console.WriteLine("Enter new Name:");
//                    string newName = Console.ReadLine();
//                    while (string.IsNullOrWhiteSpace(newName))
//                    {
//                        Console.WriteLine("Name cannot be empty:");
//                        newName = Console.ReadLine();
//                    }

//                    Console.WriteLine("Enter new Age:");
//                    int newAge = int.Parse(Console.ReadLine());
//                    while (newAge <= 0)
//                    {
//                        Console.WriteLine("Age must be positive:");
//                        newAge = int.Parse(Console.ReadLine());
//                    }

//                    Console.WriteLine("Enter new Salary:");
//                    int newSalary = int.Parse(Console.ReadLine());
//                    while (newSalary <= 0)
//                    {
//                        Console.WriteLine("Salary must be positive:");
//                        newSalary = int.Parse(Console.ReadLine());
//                    }

//                    employees[i].SetName(newName);
//                    employees[i].SetAge(newAge);
//                    employees[i].Setsalary(newSalary);

//                    Console.WriteLine("Employee updated successfully!");
//                    return;
//                }
//            }

//            Console.WriteLine("Employee not found.");
//        }

//        public void DeleteEmployee(employee[] employees, ref int count)
//        {
//            Console.WriteLine("Enter ID to delete:");
//            int id = int.Parse(Console.ReadLine());

//            for (int i = 0; i < count; i++)
//            {
//                if (employees[i].GetID() == id)
//                {
//                    for (int j = i; j < count - 1; j++)
//                    {
//                        employees[j] = employees[j + 1];
//                    }

//                    employees[count - 1] = null;
//                    count--;
//                    Console.WriteLine("Employee deleted successfully!");
//                    return;
//                }
//            }

//            Console.WriteLine("Employee not found.");
//        }

//        public void GetAllEmployees(employee[] employees, int count)
//        {
//            if (count == 0)
//            {
//                Console.WriteLine("No employees to show.");
//                return;
//            }

//            for (int i = 0; i < count; i++)
//            {
//                employees[i].Print();
//            }
//        }

//        public void GetEmployeeById(employee[] employees, int count)
//        {
//            Console.WriteLine("Enter ID to search:");
//            int id = int.Parse(Console.ReadLine());

//            for (int i = 0; i < count; i++)
//            {
//                if (employees[i].GetID() == id)
//                {
//                    employees[i].Print();
//                    return;
//                }
//            }

//            Console.WriteLine("Employee not found.");
//        }
//    }
//}
