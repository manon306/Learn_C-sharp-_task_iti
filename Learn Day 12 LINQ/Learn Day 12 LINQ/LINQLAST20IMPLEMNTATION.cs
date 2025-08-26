using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Day_12_LINQ
{

    public static class IMPLEMENTATION
    {
        #region Where --> كل الي فيه بس بيطبق الشرط
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
        #endregion
        #region --> Like if index < 5 && value > 3
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
        #endregion
        #region
        public static List<dynamic> SELECTION(this List<dynamic> lst, Func<dynamic, dynamic> z)
        {
            List<dynamic> y = new List<dynamic>();
            foreach (var item in lst)
            {
                y.Add(z.Invoke(item));
            }
            return y;
        }
        #endregion
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
        public static List<dynamic> ORDER_BY_DECS(this List<dynamic> lst)
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
            if (lst.Count == 0)
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
            return lst[(lst.Count) - 1];
        }
        public static dynamic LASTORDefault_ELEMENT(this List<dynamic> lst)
        {
            if (lst.Count == 0)
            {
                return default(dynamic);
            }
            return lst[lst.Count - 1];
        }
        public static dynamic SINGLE_LIST(this List<dynamic> lst,Func<dynamic,bool>x)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("List is empty");

            if (lst.Count > 1 && x==null)
                throw new Exception("List must contain exactly one element");
            List<dynamic> lst2 = new();

            foreach(dynamic item in lst)
            {
                bool flag=false;
                if(x.Invoke(item))
                {
                    lst2.Add(item);
                    flag = true;
                }
                if(lst.Count>1)
                {
                    throw new Exception(" must be one element");
                }
            }
            return (lst2[0]);

            
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
        public static List<dynamic> DISTINCTBY_LIST(this List<dynamic> lst, Func<dynamic, dynamic> x)
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
        public static dynamic MIN_ELEMent(this List<dynamic> lst)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("The list is empty or null");

            dynamic flag = lst[0];

            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] != null && lst[i] < flag)
                {
                    flag = lst[i];
                }
            }

            return flag;
        }
        public static dynamic Max_ELEMent(this List<dynamic> lst)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("The list is empty or null");

            dynamic flag = lst[0];

            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] != null && lst[i] > flag)
                {
                    flag = lst[i];
                }
            }

            return flag;
        }
        public static dynamic Sum_Element(this List<dynamic> lst)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("The list is empty or null");
            dynamic Sum = 0;
            for (int i = 0; i < lst.Count; i++)
                Sum += lst[i];
            return Sum;
        }
        public static int Count_Element(this List<dynamic> lst)
        {
            return lst.Count;
        }
        public static dynamic Avg_Element(this List<dynamic> lst)
        {
            dynamic Sum = 0;
            for (int i = 0; i < lst.Count; i++)
                Sum += lst[i];

            return Sum / lst.Count;
        }
        public static dynamic MaxBY_ELEMent(this List<dynamic> lst,Func<dynamic,dynamic> x)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("The list is empty or null");

            dynamic flag = lst[0];
            dynamic max = x.Invoke(lst[0]);

            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] != null && x.Invoke(lst[i]) > max)
                {
                    flag = lst[i];
                    max = x.Invoke(lst[i]);
                }
            }

            return flag;
        }
        public static dynamic MinBY_ELEMent(this List<dynamic> lst, Func<dynamic, dynamic> x)
        {
            if (lst == null || lst.Count == 0)
                throw new Exception("The list is empty or null");

            dynamic flag = lst[0];
            dynamic min = x.Invoke(lst[0]);

            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] != null && x.Invoke(lst[i]) < min)
                {
                    flag = lst[i];
                    min = x.Invoke(lst[i]);
                }
            }

            return flag;
        }
        public static List<dynamic> Select_Many(this List<dynamic> lst, Func<dynamic, dynamic> x)
        {
            List<dynamic> z = new();
            foreach (var i in lst)
            {
                foreach (var item in x.Invoke(i))
                {
                    z.Add(item);
                }
            }
            return z;
        }
        public static List<dynamic> TOLIST(this dynamic[] arr)
        {
            List<dynamic> z = new();
            foreach (var i in arr)
            {
                z.Add(i);
            }
            return z;
        }
        public static dynamic[] TOArray(this List<dynamic> lst)
        {
            dynamic[] z = new dynamic[lst.Count];
            for (int i = 0; i < lst.Count; i++)
                z[i] = lst[i];

            return z;
        }
        public static Dictionary<dynamic, dynamic> ToDictionary(this List<dynamic> lst,Func<dynamic, dynamic> key,Func<dynamic, dynamic> value)
        {
            var d = new Dictionary<dynamic, dynamic>();
            foreach (var item in lst)
            {
                var k = key.Invoke(item);
                if (!d.ContainsKey(k))
                {
                    d[k] = value.Invoke(item);
                }
            }
            return d;
        }
        public static List<dynamic> TOHashSet(this List<dynamic> lst)
        {
            List<dynamic> z = new();
            foreach (var item in lst)
            {
                bool flag = false;
                foreach (var item1 in z)
                {
                    if (item == item1)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    z.Add(item);
                }
            }
            return z;
        }
        public static List<dynamic> UNION_ELEMENT(this List<dynamic> lst1, List<dynamic> lst2)
        {
            List<dynamic> newList = new();

            foreach (var item in lst1)
            {
                newList.Add(item);
            }

            foreach (var item in lst2)
            {
                bool flag = false;
                foreach (var item1 in newList)
                {
                    if (item == item1)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) newList.Add(item);
            }

            return newList;
        }
        public static List<dynamic> Concate_ELEMENT(this List<dynamic> lst1, List<dynamic> lst2)
        {
            List<dynamic> newList = new();

            foreach (var item in lst1)
            {
                newList.Add(item);
            }

            foreach (var item in lst2)
            {
                newList.Add(item);
            }

            return newList;
        }
        public static List<dynamic> Except_Element(this List<dynamic> lst1, List<dynamic> lst2)
        {
            List<dynamic> newList = new();
            foreach (var item in lst1)
            {
                bool flag = false;
                foreach (var item1 in lst2)
                {
                    if (item == item1)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) newList.Add(item);
            }
            return newList;
        }
        public static List<dynamic> intersact_Element(this List<dynamic> lst1, List<dynamic> lst2)
        {
            List<dynamic> newList = new();
            foreach (var item in lst1)
            {
                foreach (var item1 in lst2)
                {
                    if (item == item1)
                    {
                        newList.Add(item);
                    }
                }

            }
            return newList;
        }
        public static List<dynamic> UNIONBy_ELEMENT(this List<dynamic> lst1, List<dynamic> lst2,Func<dynamic,dynamic> x)
        {
            List<dynamic> newList = new();

            foreach (var item in lst1)
            {
                newList.Add(item);
            }

            foreach (var item in lst2)
            {

                bool flag = false;
                foreach (var item1 in newList)
                {
                    if (x.Invoke(item) == x.Invoke(item1))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) newList.Add(item);
            }

            return newList;
        }
        public static bool ANY_ELEMENT(this List<dynamic> lst1, Func<dynamic, bool> x)
        {
            foreach (var item in lst1)
            {
                if (x.Invoke(item))
                    return true;
            }
            return false;
        }
        public static bool ALL_ELEMENT(this List<dynamic> lst1, Func<dynamic, bool> x)
        {
            foreach (var item in lst1)
            {
                if (!x.Invoke(item))
                    return false;
            }
            return true;
        }
        public static List<(dynamic, dynamic)> InnerJoin(this List<dynamic> lst1, List<dynamic> lst2, Func<dynamic, dynamic> x)
        {
            var z = new List<(dynamic, dynamic)>();
            foreach (var a in lst1)
            {
                foreach (var b in lst2)
                {
                    if (x.Invoke(a) == x.Invoke(b))
                    {
                        z.Add((a, b));
                    }
                }
            }
            return z;
        }
        public static List<(dynamic, dynamic)> Zip_element(this List<dynamic> lst1, List<dynamic> lst2)
        {
            int minCount = lst1.Count < lst2.Count ? lst1.Count : lst2.Count;
            List<(dynamic, dynamic)> newList = new();

            for (int i = 0; i < minCount; i++)
            {
                newList.Add((lst1[i], lst2[i]));
            }

            return newList;
        }
        public static Dictionary<dynamic, List<dynamic>> GroupBy_element(this List<dynamic> lst1, Func<dynamic, dynamic> x)
        {
            Dictionary<dynamic, List<dynamic>> z = new();

            foreach (var item in lst1)
            {
                var k = x.Invoke(item);

                if (!z.ContainsKey(k))
                {
                    z[k] = new List<dynamic>();
                }

                z[k].Add(item);
            }

            return z;
        }


    }
}
