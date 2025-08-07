namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            #region example
                Console.Write("Enter a  first number:");
                int num=int.Parse(Console.ReadLine());
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
                Console.WriteLine( "Enter a number to increment:");
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
        }
    }
}
