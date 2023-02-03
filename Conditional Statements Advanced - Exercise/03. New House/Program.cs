using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //"Roses" - 5            ---  > 80  - 10% отстъпка
            //"Dahlias" - 3.80       ---  > 90  - 15 % отстъпка
            //"Tulips" - 2.80        ---  > 80  - 15% отстъпка
            //"Narcissus" - 3        ---  < 120 - оскъпява с 15%
            //"Gladiolus" - 2.50     ---  < 80  - оскъпява с 20%


            string flowers = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            if (flowers == "Roses")
            {
                totalPrice = num * 5;
                if (num > 80)
                {
                    totalPrice = num * 5 - (totalPrice * 0.1);
                }
            }
            else if (flowers == "Dahlias")
            {
                totalPrice = num * 3.8;
                if (num > 90)
                {
                    totalPrice = num * 3.8 - (totalPrice * 0.15);
                }
            }
            else if (flowers == "Tulips")
            {
                totalPrice = num * 2.8;
                if (num > 80)
                {
                    totalPrice = num * 2.8 - (totalPrice * 0.15);
                }
            }
            else if (flowers == "Narcissus")
            {
                totalPrice = num * 3;
                if (num < 120)
                {
                    totalPrice = num * 3 + (totalPrice * 0.15);
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = num * 2.5;
                if (num < 80)
                {
                    totalPrice = num * 2.5 + (totalPrice * 0.20);
                }

            }
            if (budget >= totalPrice)
            {
                double d = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {num} {flowers} and {d:f2} leva left.");
            }
            //"Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left." - достатъчен
            // "Not enough money, you need {нужната сума} leva more." - НЕдостатъчен
            //*Сумата да бъде форматирана до втория знак след десетичната запетая.

            else
            {
                double d = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {d:f2} leva more.");
            }
        }
    }
}