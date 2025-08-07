namespace DAY2_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------DAY 2 LEARN----------------
            #region Switch case
                Console.WriteLine("plz enter your num");
                int num= int.Parse(Console.ReadLine());

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

                switch(num) {
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
            //stack Lifo -->last in first out  اي حاجة ليها بدايه والنهاية
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
                        } while (k<10);
            #endregion
            #region string formatting
                int x = 5,
                    y = 10,
                    z = x * y;
                Console.WriteLine(x+"*"+y+"="+z);
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
                    }else if (str[i] == 'o')
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
        }
    }
}
