using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //брой секунди 

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //сумарното им време във формат "минути:секунди".
            //Секундите да се изведат с водеща нула(2  "02", 7  "07", 35  "35"). 

            int allSec = (first + second + third);
            int min = allSec / 60;
            //Console.WriteLine(min);
            int minOst = (allSec % 60);
            //Console.WriteLine(minOst);
            if (minOst < 10)
            {
                Console.WriteLine($"{min}:0{minOst}");
            }
            else
            {
                Console.WriteLine($"{min}:{minOst}");
            }



        }
    }
}