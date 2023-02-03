using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = 0;
            int sum = 0;
            while (sum < num)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
