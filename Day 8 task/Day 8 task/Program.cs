namespace Day_8_task
{
    public class employee
    {
        public employee(int id, string name,int salary)
        {
            Id = id;
            Name = name;
            this.salary = salary;
        }

        public int Id { get;private set; }
        public string Name { get; private set; }
        public int salary { get; private set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {salary}";
        }

    }
    public static class LINQ_IMPLEMENTATION
    {
        public static List<dynamic> Where_Function(this List<dynamic> lst, Func<dynamic, bool> x)
        {
            List<dynamic> y = new List<dynamic>();
            foreach (dynamic item in lst)
            {
                if (x.Invoke(item))
                {
                    y.Add(item);
                }
            }
            return y;
        }
        public static List<dynamic> WhereINDEX_Function(this List<dynamic> lst, Func<dynamic, bool> x, Func<int, bool> z)
        {
            List<dynamic> y = new List<dynamic>();
            for (int i = 0; i < lst.Count; i++)
            {
                if (x.Invoke(lst[i]) && z.Invoke(i))
                {
                    y.Add(lst[i]);
                }
            }
            return y;
        }
        public static List<dynamic> SELECTION(this List<dynamic> lst, Func<dynamic, dynamic> z)
        {
            List<dynamic> y = new List<dynamic>();
            foreach (var item in lst)
            {
                y.Add(z.Invoke(item));
            }
            return y;
        }
        public static List<dynamic> SELECTION_INDEX(this List<dynamic> lst, Func<int, bool> z)
        {
            List<dynamic> y = new List<dynamic>();
            for (int i = 0; i < lst.Count; i++)
            {
                if (z.Invoke(i))
                {
                    y.Add(lst[i]);
                }
            }
            return y;
        }
        public static List<dynamic> TaKe_First(this List<dynamic> lst, int count)
        {
            List<dynamic> y = new List<dynamic>();
            if (count > lst.Count)
            {
                throw new Exception("INVALID count of indexes");
            }
            for (int i = 0; i < count; i++)
            {
                y.Add(lst[i]);
            }
            return y;
        }
        public static List<dynamic> TaKe_LAST(this List<dynamic> lst, int count)
        {
            List<dynamic> y = new List<dynamic>();
            int Start = lst.Count - count;
            if (count > lst.Count)
            {
                throw new Exception("INVALID count of indexes");
            }
            for (int i = Start; i < lst.Count; i++)
            {
                y.Add(lst[i]);
            }
            return y;
        }
        public static List<dynamic> SKIP_FIRST(this List<dynamic> lst, int count)
        {
            List<dynamic> y = new List<dynamic>();
            if (count > lst.Count)
            {
                throw new Exception("INVALID count of indexes");
            }
            for (int i = count; i < lst.Count; i++)
            {
                y.Add(lst[i]);
            }
            return y;
        }
        public static List<dynamic> SKIP_LAST(this List<dynamic> lst, int count)
        {
            List<dynamic> y = new List<dynamic>();
            int Start = lst.Count - count;
            if (count > lst.Count)
            {
                throw new Exception("INVALID count of indexes");
            }
            for (int i = 0; i < Start; i++)
            {
                y.Add(lst[i]);
            }
            return y;
        }
        public static List<dynamic> TaKe_While(this List<dynamic> lst, Func<dynamic, bool> z)
        {
            List<dynamic> y = new List<dynamic>();
            for (int i = 0; i < lst.Count; i++)
            {
                if (z.Invoke(lst[i]))
                {
                    y.Add(lst[i]);
                }
                else
                {
                    break;
                }
            }
            return y;
        }
        public static List<dynamic> SKIP_While(this List<dynamic> lst, Func<dynamic, bool> z)
        {
            List<dynamic> y = new List<dynamic>();
            bool f = false;
            int index = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if (z.Invoke(lst[i]))
                {
                    continue;
                }
                else
                {
                    f = true;
                    index = i;
                    break;
                }
            }
            for (int i = index; i < lst.Count; i++)
            {
                y.Add(lst[i]);
            }
            return y;
        }
        public static void CHUNK(this List<dynamic> lst, int count)
        {
            int current = 0;

            for (int i = 0; i < lst.Count; i++)
            {
                if (current == 0)
                {
                    Console.Clear();
                }
                Console.Write(lst[i] + " ");
                current++;

                if (current == count)
                {
                    Console.WriteLine();
                    current = 0;
                    Console.ReadLine(); 
                }
            }
            if (current != 0)
            {
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        public static List<dynamic> ORDER_BY(this List<dynamic> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst.Count - 1; j++)
                {
                    if (lst[j] > lst[j + 1])
                    {
                        dynamic temp = lst[j];
                        lst[j] = lst[j + 1];
                        lst[j + 1] = temp;
                    }
                }
            }
            return lst;
        }
        public static List<dynamic> ORDER_BY_DECS(this  List<dynamic> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst.Count - 1; j++)
                {
                    if (lst[j] < lst[j + 1])
                    {
                        dynamic temp = lst[j];
                        lst[j] = lst[j + 1];
                        lst[j + 1] = temp;
                    }
                }
            }
            return lst;
        }
        public static dynamic FIRST_ELEMENT(this List<dynamic> lst) 
        { 
            if(lst.Count == 0)
            {
                throw new Exception("empty List");
            }
            return lst[0];
        }
        public static dynamic FIRSTORDefault_ELEMENT(this List<dynamic> lst)
        {
            if (lst.Count == 0)
            {
                return default(dynamic);
            }
            return lst[0];
        }
        public static dynamic LAST_ELEMENT(this List<dynamic> lst)
        {
            if (lst.Count == 0)
            {
                throw new Exception("empty List");
            }
            return lst[(lst.Count) -1];
        }
        public static dynamic LASTORDefault_ELEMENT(this List<dynamic> lst)
        {
            if (lst.Count == 0)
            {
                return default(dynamic);
            }
            return lst[lst.Count - 1];
        }
        public static dynamic SINGLE_LIST(this List<dynamic> lst)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("List is empty");

            if (lst.Count > 1)
                throw new Exception("List must contain exactly one element");

            return lst[0];
        }
        public static dynamic SINGLEOrDefault_LIST(this List<dynamic> lst)
        {
            if (lst == null || lst.Count == 0)
                return default(dynamic);

            if (lst.Count > 1)
                throw new Exception("List must contain at most one element");

            return lst[0];
        }
        public static List<dynamic> DISTINCT_LIST(this List<dynamic> lst)
        {
            List<dynamic> y = new List<dynamic>();
            for (int i = 0; i < lst.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < y.Count; j++)
                {
                    if (lst[i] == y[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    y.Add(lst[i]);
                }
            }
            return y;
        }
        public static List<dynamic> DISTINCTBY_LIST(this List<dynamic> lst,Func<dynamic,dynamic> x)
        {
            List<dynamic> y = new List<dynamic>();
            for (int i = 0; i < lst.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < y.Count; j++)
                {
                    if (x.Invoke(lst[i]) == y[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    y.Add(lst[i]);
                }
            }
            return y;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<dynamic>
            {
                new employee(1, "Alice", 5000),
                new employee(2, "Bob", 4500),
                new employee(3, "Charlie", 5500),
                new employee(4, "David", 4700),
                new employee(5, "Eve", 5000)
            };
            var list = new List<dynamic> { 1, 2, 2, 3, 6, 5 };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("======= Menu =======");
                Console.WriteLine("1. Where_Function (>5)");
                Console.WriteLine("2. SELECTION (*2)");
                Console.WriteLine("3. TaKe_First (2 elements)");
                Console.WriteLine("4. TaKe_LAST (3 elements)");
                Console.WriteLine("5. SKIP_FIRST (2 elements)");
                Console.WriteLine("6. SKIP_LAST (2 elements)");
                Console.WriteLine("7. TaKe_While (<4)");
                Console.WriteLine("8. SKIP_While (<4)");
                Console.WriteLine("9. CHUNK (2 per row)");
                Console.WriteLine("10. ORDER_BY");
                Console.WriteLine("11. ORDER_BY_DECS");
                Console.WriteLine("12. FIRST_ELEMENT");
                Console.WriteLine("13. FIRSTORDefault_ELEMENT");
                Console.WriteLine("14. LAST_ELEMENT");
                Console.WriteLine("15. LASTORDefault_ELEMENT");
                Console.WriteLine("16. SINGLE_LIST");
                Console.WriteLine("17. SINGLEOrDefault_LIST");
                Console.WriteLine("18. DISTINCT_LIST");
                Console.WriteLine("19. DISTINCTBY_LIST (%2)");
                Console.WriteLine("20.select employee name");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                List<dynamic> result = null;
                dynamic singleResult;

                switch (choice)
                {
                    case "1":
                        result = list.Where_Function(a => a > 5);
                        break;
                    case "2":
                        result = list.SELECTION(a => a * 2);
                        break;
                    case "3":
                        result = list.TaKe_First(2);
                        break;
                    case "4":
                        result = list.TaKe_LAST(3);
                        break;
                    case "5":
                        result = list.SKIP_FIRST(2);
                        break;
                    case "6":
                        result = list.SKIP_LAST(2);
                        break;
                    case "7":
                        result = list.TaKe_While(a => a < 4);
                        break;
                    case "8":
                        result = list.SKIP_While(a => a < 4);
                        break;
                    case "9":
                        list.CHUNK(2);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "10":
                        result = list.ORDER_BY();
                        break;
                    case "11":
                        result = list.ORDER_BY_DECS();
                        break;
                    case "12":
                        singleResult = list.FIRST_ELEMENT();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "13":
                        singleResult = list.FIRSTORDefault_ELEMENT();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "14":
                        singleResult = list.LAST_ELEMENT();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "15":
                        singleResult = list.LASTORDefault_ELEMENT();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "16":
                        singleResult = list.SINGLE_LIST();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "17":
                        singleResult = list.SINGLEOrDefault_LIST();
                        Console.WriteLine(singleResult);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        continue;
                    case "18":
                        result = list.DISTINCT_LIST();
                        break;
                    case "19":
                        result = list.DISTINCTBY_LIST(a => a % 2);
                        break;
                    case "20":
                        result = employees.SELECTION(a => a.Name);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.ReadLine();
                        continue;
                }

                if (result != null)
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }

            }
        }
    }
}
