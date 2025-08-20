namespace Learn_Day_12_LINQ
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name} ({Department})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list1 = new List<dynamic> { 1, 2, 3 ,4 };
            //var list2 = new List<dynamic> { "A", "B", "C" };

            //var result = list1.Zip_element(list2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            List<dynamic> students = new()
        {
            new Student { ID = 1, Name = "Ahmed", Department = "CS" },
            new Student { ID = 2, Name = "Sara", Department = "IT" },
            new Student { ID = 1, Name = "Ali", Department = "CS" },
            new Student { ID = 4, Name = "Mona", Department = "Math" },
            new Student { ID = 5, Name = "Hana", Department = "IT" },
        };
            var dict = students.ToDictionary(k => k.ID, s => s.Name);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

                // نستخدم GroupBy_element
                //var grouped = students.GroupBy_element(s => s.Department);

                //// نطبع الناتج
                //foreach (var group in grouped)
                //{
                //    Console.WriteLine($"Department: {group.Key}");
                //    foreach (var student in group.Value)
                //        Console.WriteLine("  " + student);
                //}

            }
    }
}
