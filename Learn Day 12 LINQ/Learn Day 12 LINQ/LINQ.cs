using System.Linq;
namespace Day_8
{

    class Department
    {
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Employee/*: IComparable*/
    {
        public Employee(int id, string name, int age, List<string> projects = null, int deptId = 0)
        {
            Id = id;
            Name = name;
            Age = age;
            Projects = projects;
            DeptId = deptId;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int DeptId { get; set; }
        public List<string> Projects { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    var mapp = obj as Employee ;
        //    if (mapp.Age<Age)
        //        return 1;
        //    else if (mapp.Age>Age)
        //        return -1;
        //    return 0;
        //}

        public override string ToString()
        {
            return $"Id : {Id}  - Name : {Name}  - Age : {Age}";
        }
    }
    class DTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
    #region Extention Method

    //public static class Extention
    //{
    //    public static void Print(this int parameter)
    //    {

    //    }
    //}
    #endregion


    public static class Linq
    {
        public static List<dynamic> Filter(this List<dynamic> values, Func<dynamic, bool> predicate)
        {
            List<dynamic> t = new List<dynamic>();
            foreach (dynamic item in values)
            {
                if (predicate.Invoke(item))
                {
                    t.Add(item);
                }
            }
            return t;
        }
    }
    internal class Program
    {
        //static List<int> Filter( List<int> lst, Func<int, bool> func)
        //{
        //    List<int> output = new List<int>();
        //    foreach (int num in lst)
        //    {
        //        if (func.Invoke(num))
        //            output.Add(num);
        //    }
        //    return output;
        //}

        static void Main2(string[] args)
        {
            #region Source

            //1   List<Emplyee> 
            List<Employee> employees = [];
            employees.Add(new Employee(1, "Essam", 20, ["Upper App", "Resturant App", "Social App"], 1));
            employees.Add(new Employee(1, "Ali", 21, ["ECommerce App, Amazon App"], 1));
            employees.Add(new Employee(1, "Osama", 22, ["Social Travilling App"], 2));
            employees.Add(new Employee(1, "Ebrahem", 27, ["Car App", "Private clinic"], 1));
            employees.Add(new Employee(1, "Ali", 25, ["Hr System"], 2));
            employees.Add(new Employee(1, "Ebtisam", 20, ["Teacher Suystem", "Car", "Upper"], 3));
            List<Department> Depts = new List<Department>();
            Depts.Add(new Department(1, "IT"));
            Depts.Add(new Department(2, "Retail"));
            Depts.Add(new Department(3, "Hr"));

            List<Employee> employees2 = new List<Employee>();
            //employees.Add(new Employee(1, "Essam", 20, ["Upper App", "Resturant App", "Social App"]));
            //employees.Add(new Employee(2, "Ali", 31, ["ECommerce App, Amazon App"]));
            //employees.Add(new Employee(3, "Osama", 32, ["Social Travilling App"]));
            //employees.Add(new Employee(4, "Ebrahem", 37, ["Car App", "Private clinic"]));
            //employees.Add(new Employee(5, "Ali", 39, ["Hr System"]));
            //employees.Add(new Employee(6, "Ebtisam", 30, ["Teacher Suystem", "Car", "Upper"]));
            List<string> names = ["Essam", "Mina", "Omar", "Kareem"];
            List<int> lst = [1, 2, 5, 6, 6, 4, -3, -4, 15, 4, 56];
            #endregion

            #region Implicit Type Local var
            //var num = "Mohamed";
            //int number = 9;
            //number.Print()
            #endregion
            #region Linq Method Two V
            //Extention Method

            //Query Expression ==> 12
            #endregion
            #region Filteration  ==> Where - IndexedWhere

            //var result = Filter(lst, (a) => a<0);

            //var result = names.Where((value, index) => value == "Essam" && index>4);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}
            //var result = from i in lst
            //             where i>0
            //             select i;
            //var result = lst.Where(a => a>0);
            #endregion
            #region Transformation Operation SELECT - SELECTIndex
            //var result = employees
            //                                 .Where(a => a.Id >4)
            //           .Select(a => a.Name);

            //var result = employees
            //                                 .Where(a => a.Id >4)
            //           .Select(a=> new DTO() { Id = a.Id , FullName = a.Name});


            //var result = employees
            //    .Select((value, Index) => new { Name = value.Name, Index = Index })
            //    .Where(a=>a.Index >3);
            //var result = employees.Select(a => a);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id);
            //}


            #endregion
            #region Immadiate Execution && Deffered Execution
            //lst.Add(12);
            //lst.Add(13);
            //var result = lst.Where(a => a>5);//6-12-13
            //lst.Add(15);
            //lst.Add(16);

            ////Immadiate Execution => First FirstOrDefault Last Or LastOrdefault Singl or Single Deafult .ToList .ToArray
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Slicing /Partioning Operator ==> Take - Take Last - skip - Skip Last - Take While - SkipWhile - Chunk
            //var result = lst.Take(3).Where(a => a>4);
            //var result = lst.TakeLast(3);

            //var result = lst.Skip(2);
            //var result = lst.SkipLast(2);

            // Take All Elements in DS  as long as Predicate return true
            //Skip All After First Element returning false from Predicate
            //var result = lst.TakeWhile(a => a>0);
            //var result = lst.SkipWhile(a => a >0);
            //Skip   All Elements in DS  as long as Predicate return true
            //Take All After First Element returning false from Predicate

            //var result = lst.Skip(2).Take(3);  // Paginage


            //Paginage Before C sharp 10;
            //var result = lst.Chunk(3);

            //foreach (var item in result)
            //{
            //    Console.Clear();
            //    foreach (int i in item)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();


            //}
            #endregion
            #region Oredring Operator OrderBy - OrederByDescending
            //var result = lst.OrderBy(a => a);//Ascending
            //var result = lst.OrderByDescending(a => a);//Ascending
            //var result = employees.OrderByDescending(a=>a.Id);
            //var result = from p in employees
            //             orderby p.Id descending
            //             select p;
            #endregion
            #region single element => Immidiate Execution First - First Or Default - Single - single Or default - Last - Last Or deafult 
            //var result = lst.First();
            //var result = lst.FirstOrDefault(a=>a >0);

            //var result = lst.Last(a=>a>0);
            //var result = lst.LastOrDefault(a => a>0);

            //List<int> lst = [1, 2, 5, 6, 4, -3, -4, 15, 44, 56];
            //var result = lst.SingleOrDefault(a=> a==14);
            //Console.WriteLine(result);
            #endregion
            #region Distinict - Distinict By  (Uniqe)
            //var result = lst.Distinct();
            //var result = employees.DistinctBy(a => a.Name);
            #endregion
            #region Aggregate Function  COUNT  -MAX  MAxBy Min MinBy Sum Avg
            //var result = lst.Min();
            //C sharp Max by   Min by ===> 2 opion ==> 1 : Icomparable 
            //==> Query Expresion
            //var result = employees.Min(a=>a.Age);
            //var order = employees.OrderByDescending(a=>a.Age).FirstOrDefault();

            //var maxEmployee = employees.Where(a => a.Age == result).LastOrDefault();
            //Console.WriteLine(maxEmployee);

            //var result = from p in employees
            //             where p.Age==(employees.Max(a => a.Age))
            //             select p;  

            //var result = lst.Average();
            #endregion
            #region Select Many
            //var result = employees.Select(a => a.Projects);
            //List<string> result = new();
            //foreach (Employee e in employees)
            //{
            //    foreach (var item in e.Projects)
            //    {
            //        result.Add(item);
            //    }
            //}

            //var result = employees.SelectMany(a => a.Projects);
            #endregion
            #region Casting Operation (Collection => Immadiate Execution) ToList - ToArray ToDictionary .ToHashSet
            //int[] number = [1, 2, 3, 4, 56, 7, 8];
            //var reeult = number.ToList();

            //var test = employees.Select(a => new { Id = a.Id, Name = a.Name }).ToList();
            //test.Add(new { Id = 5, Name = "Essam" });

            //var arr = test.ToArray();

            //var result = lst.ToHashSet();

            //var result = employees.ToDictionary(a => new {a.Id,a.Name});
            #endregion
            #region Set Operation Union - Concat - Except - Intersect Union BY
            //List<int> nums = [1, 2, 3, 4, 667, 787, 88];
            //var result = lst.Union(nums);
            //var result = employees2.UnionBy(employees,a=>a.Age);

            //var result = lst.Concat([1,2,34,56,99]);
            #endregion
            #region Countifier  Any - ALL  => true or false
            //var result = employees.Any(a => a.Id ==1);
            //var result = employees.Any();//True ===> List have 1 element at least , If Predicate return true at least

            //var result = employees.All(a=>a.Id ==1);
            //Console.WriteLine(result);
            #endregion
            #region Inner JOIN
            //var result = from p in employees
            //             join D in Depts
            //             on
            //             p.DeptId equals D.Id
            //             select new { EmpId = p.Id, EmpName = p.Name, EmpAge = p.Age, DeptName = D.Name };


            //var result = employees.Join(Depts,
            //    e => e.DeptId,
            //    D => D.Id,
            //    (e, D) => new { EmpId = e.Id, EmpName = e.Name, EmpAge = e.Age, DeptName = D.Name }



            //    );

            #endregion
            #region Zip
            //List<(int, string)> Conc = new();
            //if(lst.Count >= names.Count)
            //    for (int i = 0; i < names.Count; i++)
            //    {
            //        Conc.Add((lst[i], names[i]));
            //    }

            //var result = lst.Zip(names);
            #endregion
            #region Group By
            var result = employees.GroupBy(a => a.DeptId);
            #endregion
            foreach (IGrouping<int, Employee> item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var value in item)
                {

                    Console.WriteLine(value);

                }
                Console.WriteLine("============");

            }
        }
    }
}