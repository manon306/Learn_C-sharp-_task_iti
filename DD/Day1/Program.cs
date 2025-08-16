using System.Threading.Channels;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int j = 0; j < x; j++)
            {
                {
                    int y = int.Parse(Console.ReadLine());
                    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
                    bool changed = false;
                    do
                    {
                        changed = false;
                        for (int i = 1; i < y - 1; i++)
                        {
                            if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                            {
                                int temp = arr[i];
                                arr[i] = arr[i + 1];
                                arr[i + 1] = temp;
                                changed = true;
                            }
                        }
                    } while (changed);
                    bool sorted = true;
                    for (int i = 1; i < y; i++)
                    {
                        if (arr[i - 1] > arr[i])
                        {
                            sorted = false;
                            break;
                        }
                    }
                    Console.WriteLine(sorted ? "YES" : "NO");


                }
            }
        }
    }
}
