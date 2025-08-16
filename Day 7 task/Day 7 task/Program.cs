using System;

namespace Day_7_task
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            MyList list = new MyList();
            MyDictionary<int, string> dict = new MyDictionary<int, string>();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Stack Operations");
                Console.WriteLine("2. List Operations");
                Console.WriteLine("3. Dictionary Operations");
                Console.WriteLine("4. Sort Array (Delegate)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StackMenu(stack);
                        break;
                    case "2":
                        ListMenu(list);
                        break;
                    case "3":
                        DictionaryMenu(dict);
                        break;
                    case "4":
                        SortMenu();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void StackMenu(Stack stack)
        {
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.Write("Choose: ");
            string c = Console.ReadLine();

            try
            {
                if (c == "1")
                {
                    Console.Write("Enter value: ");
                    int val = int.Parse(Console.ReadLine());
                    stack.Push(val);
                }
                else if (c == "2")
                {
                    Console.WriteLine("Popped: " + stack.Pop());
                }
                else if (c == "3")
                {
                    Console.WriteLine("Peek: " + stack.Peek());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListMenu(MyList list)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Get");
            Console.WriteLine("3. RemoveAt");
            Console.WriteLine("4. Show All");
            Console.Write("Choose: ");
            string c = Console.ReadLine();

            try
            {
                if (c == "1")
                {
                    Console.Write("Enter value: ");
                    int val = int.Parse(Console.ReadLine());
                    list.Add(val);
                }
                else if (c == "2")
                {
                    Console.Write("Enter index: ");
                    int idx = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value: " + list.Get(idx));
                }
                else if (c == "3")
                {
                    Console.Write("Enter index: ");
                    int idx = int.Parse(Console.ReadLine());
                    list.RemoveAt(idx);
                }
                else if (c == "4")
                {
                    for (int i = 0; i < list.Count; i++)
                        Console.Write(list.Get(i) + " ");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DictionaryMenu(MyDictionary<int, string> dict)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. GetValue");
            Console.WriteLine("3. Remove");
            Console.Write("Choose: ");
            string c = Console.ReadLine();

            try
            {
                if (c == "1")
                {
                    Console.Write("Enter key: ");
                    int key = int.Parse(Console.ReadLine());
                    Console.Write("Enter value: ");
                    string value = Console.ReadLine();
                    dict.Add(key, value);
                }
                else if (c == "2")
                {
                    Console.Write("Enter key: ");
                    int key = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value: " + dict.GetValue(key));
                }
                else if (c == "3")
                {
                    Console.Write("Enter key: ");
                    int key = int.Parse(Console.ReadLine());
                    dict.Remove(key);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SortMenu()
        {
            int[] arr = { 5, 2, 8, 1, 3 };
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Choose: ");
            string c = Console.ReadLine();

            Delegate.Compare cmp;
            if (c == "1")
                cmp = delegate (int a, int b) { return a > b; };
            else
                cmp = delegate (int a, int b) { return a < b; };

            Delegate.MySort(arr, cmp);

            Console.Write("Sorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();

        }
    }
}
