using System;

namespace zadacha_test
{
    class Program
    {
        static void Main(string[] args)
        {


            double landscapingArea = double.Parse(Console.ReadLine());

            double Cost = landscapingArea * 7.61;

            double discount = Cost * 0.18;

            double totalCost = Cost - discount;

            Console.WriteLine($"The final price is: {totalCost} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");



        }
    }
}
