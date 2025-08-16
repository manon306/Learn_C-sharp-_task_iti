using System;

namespace Day_5_task
{
    class Calculator
    {
        public static double Sum;
        public static double Diff;
        public static double Prod;
        public static double Div;

        public static void Calculate(int x, int y)
        {
            Sum = x + y;
            Diff = x - y;
            Prod = x * y;
            Div = (double)x / y;
        }
    }

    public class Method
    {
        public void Calculate(int x, int y, ref int sum, ref int diff, ref int prod, ref double div)
        {
            sum = x + y;
            diff = x - y;
            prod = x * y;
            div = (double)x / y;
        }

        public void Calculate2(int x, int y, out int sum, out int diff, out int prod, out double div)
        {
            sum = x + y;
            diff = x - y;
            prod = x * y;
            div = (double)x / y;
        }

        public object Calculate3(int x, int y)
        {
            return new { Sum = x + y, Diff = x - y, Prod = x * y, Div = (double)x / y };
        }

        public double[] Calculate4(int x, int y)
        {
            return new double[] { x + y, x - y, x * y, (double)x / y };
        }

        public double CalculateSwitch(int x, int y, string operation)
        {
            switch (operation)
            {
                case "sum": return x + y;
                case "diff": return x - y;
                case "prod": return x * y;
                case "div": return (double)x / y;
                default: throw new ArgumentException("Invalid operation");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                int x = 10, y = 5;
                Method m = new Method();

                Console.WriteLine("===== Static Field Method =====");
                Calculator.Calculate(x, y);
                Console.WriteLine($"Sum: {Calculator.Sum}, Diff: {Calculator.Diff}, Prod: {Calculator.Prod}, Div: {Calculator.Div}");

                Console.WriteLine("\n===== Ref Method =====");
                int sum = 0, diff = 0, prod = 0;
                double div = 0;
                m.Calculate(x, y, ref sum, ref diff, ref prod, ref div);
                Console.WriteLine($"Sum: {sum}, Diff: {diff}, Prod: {prod}, Div: {div}");

                Console.WriteLine("\n===== Out Method =====");
                m.Calculate2(x, y, out sum, out diff, out prod, out div);
                Console.WriteLine($"Sum: {sum}, Diff: {diff}, Prod: {prod}, Div: {div}");

                Console.WriteLine("\n===== Object Method =====");
                var objResult = (dynamic)m.Calculate3(x, y);
                Console.WriteLine($"Sum: {objResult.Sum}, Diff: {objResult.Diff}, Prod: {objResult.Prod}, Div: {objResult.Div}");

                Console.WriteLine("\n===== Array Method =====");
                var arrResult = m.Calculate4(x, y);
                Console.WriteLine($"Sum: {arrResult[0]}, Diff: {arrResult[1]}, Prod: {arrResult[2]}, Div: {arrResult[3]}");

                Console.WriteLine("\n===== Switch Method =====");
                Console.WriteLine($"Sum: {m.CalculateSwitch(x, y, "sum")}");
                Console.WriteLine($"Diff: {m.CalculateSwitch(x, y, "diff")}");
                Console.WriteLine($"Prod: {m.CalculateSwitch(x, y, "prod")}");
                Console.WriteLine($"Div: {m.CalculateSwitch(x, y, "div")}");
            }
        }
    }
}
