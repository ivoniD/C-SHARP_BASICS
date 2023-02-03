using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //  0:0 до 23:59, всеки на отделен ред. Часовете трябва да се изписват във формат "{час}:{минути}".




            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {

                    Console.WriteLine($"{i}:{j}");
                }
            }


        }
    }
}