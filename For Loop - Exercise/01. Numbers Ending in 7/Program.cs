using System;

namespace _01._Numbers_Ending_in_7_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //отпечатва числата в диапазона от 1 до 1000, които завършват на 7.

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}