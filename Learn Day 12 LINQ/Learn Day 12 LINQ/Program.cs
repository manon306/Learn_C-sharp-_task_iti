using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn_Day_12_LINQ
{
    class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }
            public string Department { get; set; }

            public override string ToString() => $"ID: {Id}, Name: {Name}, Age: {Age}, Grade: {Grade}, Dept: {Department}";
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }

            public override string ToString() => $"{Name} - ${Price} ({Category})";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== COMPLETE LINQ CUSTOM METHODS TEST ===\n");

            TestAllMethods();
        }

        static void TestAllMethods()
        {
            // Test data
            List<dynamic> numbers = new List<dynamic> { 5, 2, 8, 1, 9, 3, 6, 4, 7, 10 };
            List<dynamic> names = new List<dynamic> { "John", "Alice", "Bob", "Charlie", "David" };
            List<dynamic> duplicates = new List<dynamic> { 1, 2, 2, 3, 4, 4, 5 };

            // 1. Where operations
            Console.WriteLine("1. WHERE OPERATIONS:");
            Console.WriteLine("Numbers > 5: " + string.Join(", ", numbers.Where_Function(x => x > 5)));
            Console.WriteLine("Names starting with 'A': " + string.Join(", ", names.Where_Function(x => x.ToString().StartsWith("A"))));
            Console.WriteLine();

            // 2. Select operations
            Console.WriteLine("2. SELECT OPERATIONS:");
            Console.WriteLine("Numbers squared: " + string.Join(", ", numbers.SELECTION(x => x * x)));
            Console.WriteLine("Name lengths: " + string.Join(", ", names.SELECTION(x => x.ToString().Length)));
            Console.WriteLine();

            // 3. Take/Skip operations
            Console.WriteLine("3. TAKE/SKIP OPERATIONS:");
            Console.WriteLine("First 3 numbers: " + string.Join(", ", numbers.TaKe_First(3)));
            Console.WriteLine("Skip first 3 numbers: " + string.Join(", ", numbers.SKIP_FIRST(3)));
            Console.WriteLine("Last 3 numbers: " + string.Join(", ", numbers.TaKe_LAST(3)));
            Console.WriteLine();

            // 4. Sorting operations
            Console.WriteLine("4. SORTING OPERATIONS:");
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers.ORDER_BY()));
            Console.WriteLine("Sorted descending: " + string.Join(", ", numbers.ORDER_BY_DECS()));
            Console.WriteLine("Distinct numbers: " + string.Join(", ", duplicates.DISTINCT_LIST()));
            Console.WriteLine();

            // 5. Aggregation operations
            Console.WriteLine("5. AGGREGATION OPERATIONS:");
            Console.WriteLine("Sum: " + numbers.Sum_Element());
            Console.WriteLine("Count: " + numbers.Count_Element());
            Console.WriteLine("Average: " + numbers.Avg_Element());
            Console.WriteLine("Max: " + numbers.Max_ELEMent());
            Console.WriteLine("Min: " + numbers.MIN_ELEMent);
            Console.WriteLine();

            // 6. Set operations
            Console.WriteLine("6. SET OPERATIONS:");
            List<dynamic> set1 = new List<dynamic> { 1, 2, 3, 4, 5 };
            List<dynamic> set2 = new List<dynamic> { 4, 5, 6, 7, 8 };

            Console.WriteLine("Union: " + string.Join(", ", set1.UNION_ELEMENT(set2)));
            Console.WriteLine("Concat: " + string.Join(", ", set1.Concate_ELEMENT(set2)));
            Console.WriteLine("Except: " + string.Join(", ", set1.Except_Element(set2)));
            Console.WriteLine("Intersect: " + string.Join(", ", set1.intersact_Element(set2)));
            Console.WriteLine();

            // 7. Boolean operations
            Console.WriteLine("7. BOOLEAN OPERATIONS:");
            Console.WriteLine("Any > 8: " + numbers.ANY_ELEMENT(x => x > 8));
            Console.WriteLine("All > 0: " + numbers.ALL_ELEMENT(x => x > 0));
            Console.WriteLine();

            // 8. Conversion operations
            Console.WriteLine("8. CONVERSION OPERATIONS:");
            dynamic[] array = numbers.TOArray();
            Console.WriteLine("ToArray: " + string.Join(", ", array));

            List<dynamic> newList = array.TOLIST();
            Console.WriteLine("ToList: " + string.Join(", ", newList));

            Console.WriteLine("ToHashSet: " + string.Join(", ", duplicates.TOHashSet()));
            Console.WriteLine();

            // 9. Zip operation
            Console.WriteLine("9. ZIP OPERATION:");
            List<dynamic> letters = new List<dynamic> { "A", "B", "C", "D", "E" };
            var zipped = numbers.Zip_element(letters);
            foreach (var (num, letter) in zipped)
            {
                Console.WriteLine($"  {num}-{letter}");
            }
            Console.WriteLine();

            // 10. Advanced operations with objects
            Console.WriteLine("10. ADVANCED OPERATIONS WITH OBJECTS:");

            List<dynamic> students = new List<dynamic>
            {
                new Student { Id = 1, Name = "John", Age = 20, Grade = 85.5, Department = "CS" },
                new Student { Id = 2, Name = "Alice", Age = 22, Grade = 92.0, Department = "CS" },
                new Student { Id = 3, Name = "Bob", Age = 19, Grade = 78.5, Department = "Math" }
            };

            // MaxBy and MinBy
            var topStudent = students.MaxBY_ELEMent(s => s.Grade);
            Console.WriteLine("Top student by grade: " + topStudent);

            var youngestStudent = students.MinBY_ELEMent(s => s.Age);
            Console.WriteLine("Youngest student: " + youngestStudent);

            // GroupBy
            var grouped = students.GroupBy_element(s => s.Department);
            Console.WriteLine("Grouped by department:");
            foreach (var group in grouped)
            {
                Console.WriteLine($"  {group.Key}:");
                foreach (var student in group.Value)
                {
                    Console.WriteLine($"    {student.Name}");
                }
            }

            Console.WriteLine("\n=== ALL TESTS COMPLETED SUCCESSFULLY ===");
        }
    }
}