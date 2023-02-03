using System;

namespace zadacha_test
{
    class Program
    {
        static void Main(string[] args)
        {

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double foodCost = (dogFood * 2.50) + (catFood * 4);


            Console.WriteLine($"{foodCost} lv.");


        }
    }
}