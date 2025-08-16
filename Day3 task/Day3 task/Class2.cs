using Day3_task;

class HR : employee
{
    public HR() { }
    public HR(int id, string name, int age, int salary)
        : base(id, name, age, salary) { }
    public override void ShowBonus()
    {
        Console.WriteLine(" HR Bonus is :10% ");

    }
    public static void ShowMenu()
    {
        int count = 0;
        HR[] hr = new HR[10];

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
                    if (count < hr.Length)
                    {
                        hr[count] = new HR(id, name, age, salary);
                        count++;
                        Console.WriteLine("HR employee added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Array is full!");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter ID to edit:");
                    id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        if (hr[i].GetID() == id)
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
                            hr[i].SetName(newName);
                            hr[i].SetAge(newAge);
                            hr[i].Setsalary(newSalary);
                            Console.WriteLine("Employee details updated successfully!");
                            break;
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter ID to delete:");
                    id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        if (hr[i].GetID() == id)
                        {
                            // Shift elements to the left
                            for (int j = i; j < count - 1; j++)
                            {
                                hr[j] = hr[j + 1];
                            }
                            hr[count - 1] = null;
                            count--;
                            Console.WriteLine("Employee deleted successfully!");
                            break;
                        }
                    }

                    break;
                case "4":
                    for (int i = 0; i < count; i++)
                    {
                        hr[i].Print();
                    }
                    break;
                case "5":
                    Console.WriteLine("Enter ID to get employee details:");
                    id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        if (hr[i].GetID() == id)
                        {
                            hr[i].Print();
                            break;
                        }
                    }
                    break;
                case "6": // EXIT
                    return;



            }

            Console.WriteLine("اضغط زر للمتابعة...");
            Console.ReadKey();
        }
    }
}
