using System;

namespace _02._Half_Sum_Element_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxnum = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > maxnum)
                {
                    maxnum = num;
                }
            }

            if (maxnum == (sum - maxnum))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxnum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxnum - (sum - maxnum))}");
            }
        }
    }
}
