namespace DAY2_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------day 1 learn----------------
            #region  first program
            //int x = 200;
            //int y = 30;
            //Console.WriteLine(x+y);
            //if (x == y)
            //{
            //    Console.WriteLine("x is equal to y");
            //}
            //else if (x > y)
            //{
            //    Console.WriteLine("x is greater than y");
            //}
            //else
            //{
            //    Console.WriteLine("x is less than y");
            //}
            //string text = "Hello, World!";
            //Console.WriteLine(text);

            //Console.WriteLine("Enter a number:");
            //string text2=Console.ReadLine();
            //if (int.TryParse(text2, out int number))
            //{
            //    Console.WriteLine($"You entered the number: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input, please enter a valid number.");
            //}


            //int num1= int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");


            //Console.Write("Enter a number:"); -->print without newline
            //Console.WriteLine("Enter a number:"); -->print with newline
            #endregion
            #region example
            Console.Write("Enter a  first number:");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Enter a second number:");
                int num2 = int.Parse(Console.ReadLine());
                int sum = num * num2;
                Console.WriteLine($"The sum of {num} and {num2} is: {sum}");
            #endregion
            #region operation
            //unary operators -->Postfix, Prefix, Unary
            int x = 10;
            Console.WriteLine(x++); // Postfix increment--> outputs the current value of x, then increments it
            Console.WriteLine(++x); // Prefix increment --> increments x first, then outputs the new value
            Console.WriteLine(x--); // Postfix decrement --> outputs the current value of x, then decrements it
            Console.WriteLine(--x); // Prefix decrement --> decrements x first, then outputs the new value
            Console.WriteLine(x); // Output the current value of x
            Console.WriteLine("Enter a number to increment:");
            //binary
            //1-mathmatical --> addition, subtraction, multiplication, division, modulus
            //relational    --> greater than, less than, equal to, not equal to, greater than or equal to, less than or equal to
            //bitwise-->search -->&, |, ^, ~, <<, >>
            //logical --> &&, ||, !
            //2-assignment --> =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
            //ternary
            //3-conditional --> ?:
            Console.WriteLine("Enter a number to check if it is even or odd:");
            int number = int.Parse(Console.ReadLine());
            string result = (number % 2 == 0) ? "Even" : "Odd"; // Conditional operator
            Console.WriteLine($"The number {number} is {result}.");
            #endregion
            #region if else if else if
                    if (false)
                    {
                        Console.WriteLine("true");
                    }
                    else if (true)
                    {
                        Console.WriteLine("false");
                    }
                    else
                    {
                        Console.WriteLine("else");
                    }
                #endregion
            // --------------DAY 2 LEARN----------------
            #region Switch case
            Console.WriteLine("plz enter your num");
            int num = int.Parse(Console.ReadLine());

            //if (num == 0)
            //    Console.WriteLine("You entered zero"); 
            //else if (num ==1)
            //    Console.WriteLine("You entered one");
            //else if (num == 2)
            //    Console.WriteLine("You entered two");
            //else if (num == 3)
            //    Console.WriteLine("You entered three");
            //else if (num == 4)
            //    Console.WriteLine("You entered four");
            //else if (num == 5)
            //    Console.WriteLine("You entered five");
            //else
            //     Console.WriteLine("You entered a number greater than five");
            // Switch case

            switch (num)
            {
                case 0: Console.WriteLine("You entered zero"); break;
                case 1: Console.WriteLine("You entered one"); break;
                case 2: Console.WriteLine("You entered two"); break;
                case 3: Console.WriteLine("You entered three"); break;
                case 4: Console.WriteLine("You entered four"); break;
                case 5: Console.WriteLine("You entered five"); break;
                default: Console.WriteLine("You entered a number greater than five"); break;
            }
            // احلي لو مزادتش عن 8 

            #endregion
            #region stack heap
            //stack Lifo -->last in first out  اي حاجة ليها بدايه والنهاية لو شغال في ال main
            // sequential memory allocation
            // value type بنخزن فيه 
            //all data type except string and array -->because they are reference type and not have max value size
            //المسئول عن تنظيف هو ال os
            //heap -->dynamic memory allocation
            //reference type بنخزن فيه 
            //string and array are reference type
            //heap is not sequential memory allocation
            //heap is dynamic memory allocation
            //المسئول عن تنظيف هو garbage collector
            #endregion
            #region  Loops 
            //for loop
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
            //while loop
            int j = 0;
            while (j < num)
            {
                Console.WriteLine(j);
                j++;
            }
            //do while loop
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);
            #endregion
            #region string formatting
            int x = 5,
                y = 10,
                z = x * y;
            Console.WriteLine(x + "*" + y + "=" + z);
            Console.WriteLine($"{x} * {y} = {z}");
            Console.WriteLine("{0} * {1} = {2}", x, y, z);
            Console.WriteLine($@"{x}
                +
                {y}");
            /*
             * \n is used to insert a new line in the output.
             * */
            #endregion
            #region  String
            //string is a reference type
            //string is immutable
            //string is a collection of characters
            //string is a sequence of characters
            //string is a class
            //string is a reference type
            //string is a collection of characters
            string str = "Hello World";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);//index + 1
            Console.WriteLine(str[0]);
            Console.WriteLine(str.Substring(0, 5));
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue; // skip the space character
                }
                else if (str[i] == 'o')
                {
                    Console.WriteLine("have o");
                }
                Console.WriteLine(str[i]);
            }
            #endregion
            #region nested loops
            //nested loops are loops inside loops
            //outer loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Outer loop: " + i);
                //inner loop
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Inner loop: " + j);
                }
            }
            #endregion
            // --------------DAY 3 LEARN----------------
            #region  class
            /*
             * class user defiend 
             * is an active data structure -->store data
             * encapsulatin , //hide validation
             * every class must be in namespace and have unique name
             * كل كلاس في فايل لوحده
             * class have
             *  1- data members
             *       store data  -->feilds 
             *       علي مستوي ال class
             *       intialize with default value
             *       have default value
             *       int--> 0
             *       char-->'\0'
             *       double-->0.0
             *       string-->null
             *       bool-->false
             *       association with class
             *  2- functions member 
             *       excute code/bussiness logic -->method and constructor
             *      
             */
            #endregion
            #region  access Modifier
            /*
             *      1- public -->accessable in any class
             *      2- private -->only accessable in the same class
             *      3- protected -->accessable in the same class and derived classes
             *      4- internal -->accessable in the same assembly
             */
            #endregion
            #region parameter
            /*
             * default parameter -->نحطتاج نعرفها في ال constructor بس لازم يبقوا في الاخر
             * 
             */
            #endregion
            #region  setters and getters
            /*
             * setter -->set private data members
             * getter -->get private data members
             */
            #endregion
            #region instance
            /*
             * بيتخزن في ال stack and heap
             * new
             *   --> allocate memory for the objectin HEAP
             *   --> intialize allocated byte with default values
             *   -->call constructor
             *   --> assign reference value to the variable in stack
             *   -->advance pointer to the object in HEAP
             */

            /* 
             * overhead   جوا بيانات عن الكلاس
             *   reflection
             *   Garbage collector GC
             *   threading
             */
            #endregion
            #region constructor
            /*
             * -->reassign value 
             * default constructor -->constructor without parameters
             *                      -->public User(){} , بيتعمل لو معملتش اي واحد تاني
             *  public User(string name, int age){} -->parameterized constructor
             *  ممكن نعمل اكتر من كونستركتور بس لازم يكونوا مختلفين في عدد البراميتر او نوعهم
             *  not have return type
             *  
             */
            #endregion
            #region array
            /*
             * datastructure 
             * fixed size
             * store data in sequential memory allocation
             * specefic data type
             * last item index= length -1
             * int [] arr = new int[5]; //array of integers user defined size +entered data
             * int [] arr = { 1, 2, 3, 4, 5 }; //array of integers with initial values in c# 8
             * int [] arr = [ 1, 2, 3, 4, 5 ; //array of integers with initial values
             * 
             */
            #endregion
            #region clear
            Console.Clear(); //--> بيحذف الي ظاهر علي الشاشه
            #endregion
            //Menu add edit delete getall getbyid -->employee class
            //stack heap

        }
    }
}
namespace classLearn
    {
        class User
        {
            // Data members (fields)
            private string Name;
            private int Age;
            // Constructor
            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }
            // Method
            //accessModifier  return type   Name(parameter){}
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
            //setters and getters -->set private data members and get private data members
            public void SetName(string name)
            {
                Name = name;
            }
            public string GetName()
            {
                return Name;
            }
            public void SetAge(int age)
            {
                if (age > 0)
                {
                    Age = age;
                }
                else
                {
                    Console.WriteLine("Age must be positive.");
                }
            }
            public int GetAge()
            {
                return Age;
            }
            public void SetID(int id)
            {
                if (id > 0)
                {
                    ID = id;
                }
                else
                {
                    Console.WriteLine("ID must be a positive number.");
                }
            }
            public int GetID()
            {
                return ID;
            }
            public void SetAllData(string name, int age, int id)
            {
                id = id;
                name = name;
                age = age;
                id = id;
                Console.WriteLine($" all data added success : Name: {name}, Age: {age}, ID: {id}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
            }
        }
    }

