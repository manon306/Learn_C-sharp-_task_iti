namespace Day1
{
    class Program // data structure data type //entry point 
    {
        static void Main(string[] args) //first method that runs
        {
            Console.WriteLine("------------------Learn C#------------------");
            #region task 1
            Console.WriteLine("Enter your number");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Number is : ");
                if (num1 > 0)
                {
                    Console.WriteLine("Positive");
                }
                else if (num1 < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Zero");
                }
            #endregion
            Console.WriteLine("---------------------------------------");
            #region task 2
                Console.WriteLine("Enter a number:");
                int num2 =int.Parse(Console.ReadLine());
                Console.Write("number is : ");
                Console.WriteLine((num2 % 2 == 0) ? "Even" : "Odd");
            #endregion
            Console.WriteLine("---------------------------------------");
            #region task 3
                Console.WriteLine("Enter a Width:");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Height:");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Shape is: ");
                Console.WriteLine( (width == height) ? "Square" : "Rectangle");
            #endregion
            Console.WriteLine("---------------------------------------");
        }
    }
}
