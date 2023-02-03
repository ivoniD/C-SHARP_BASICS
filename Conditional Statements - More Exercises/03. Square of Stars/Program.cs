using System;

namespace _03._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n, въведено от потребителя, и чертае квадрат от n * n звездички.
            //Разликата с предходната задача е, че между всеки две звездички има по един интервал.
            int n = int.Parse(Console.ReadLine());

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
