using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-10 "{първи множител} * {втори множител} = {резултат}".

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}");
                }
            }
        }
    }
}
