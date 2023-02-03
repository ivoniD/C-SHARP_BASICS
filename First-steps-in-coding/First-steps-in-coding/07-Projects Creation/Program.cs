using System;

namespace zadacha_test
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int hours = number * 3;


            Console.WriteLine($"The architect {name} will need {hours} hours to complete {number} project/s.");


        }
    }
}
