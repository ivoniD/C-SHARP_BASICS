using System;

namespace _02._Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя
            //и печата на конзолата правоъгълник от n * n звездички.
            int n = int.Parse(Console.ReadLine());


            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
