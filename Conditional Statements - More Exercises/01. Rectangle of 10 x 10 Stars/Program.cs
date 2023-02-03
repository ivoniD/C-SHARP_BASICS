using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чертае на конзолата правоъгълник от 10 x 10 звездички

            //col
            //row

            for (int col = 0; col < 10; col++)
            {
                for (int row = 0; row < 10; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
