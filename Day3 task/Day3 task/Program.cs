using System.Diagnostics.Metrics;

namespace Day3_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"
                **************************************************************
                 MENU:
                     1-USER
                     2-HR
                     3-Programmer
                     4-Show User Bonus
                     5-Show Hr Bonus
                     6-Show Programmer Bonus
                     7-Exit
                **************************************************************
                ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        User.ShowMenu(); break;
                    case 2:
                        HR.ShowMenu(); break;
                    case 3:
                        Programmer.ShowMenu(); break;
                    case 4:
                        User e = new User();
                        e.ShowBonus(); break;
                    case 5:
                        HR e2 = new HR();
                        e2.ShowBonus(); break;
                    case 6:
                        Programmer e3 = new Programmer();
                        e3.ShowBonus(); break;
                    case 7:
                        return;

                }
            }
        }
    }
}
