using System;

namespace _03._Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // чете число n, въведено от потребителя и отпечатва числата от 1 до n през 3.
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}