using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadium = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine(); // A B - първия отбор  /  V G - втория отбор
                switch (sector)
                {
                    case "A":
                        a++; break;
                    case "B":
                        b++; break;
                    case "V":
                        v++; break;
                    case "G":
                        g++; break;
                }
            }
            double prA = a / fans * 100;
            double prB = b / fans * 100;
            double prV = v / fans * 100;
            double prG = g / fans * 100;
            double capacity = fans / stadium * 100;
            Console.WriteLine($"{prA:f2}%");
            Console.WriteLine($"{prB:f2}%");
            Console.WriteLine($"{prV:f2}%");
            Console.WriteLine($"{prG:f2}%");
            Console.WriteLine($"{capacity:f2}%");
        }
    }
}
