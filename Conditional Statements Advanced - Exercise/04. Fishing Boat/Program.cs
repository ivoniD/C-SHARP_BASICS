using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yes! You have {останалите пари} leva left.
            //Not enough money! You need {сумата, която не достига} leva. - до 2-ри знак
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fisherman = double.Parse(Console.ReadLine());
            double price = 0.0;
            //Spring  3000 
            //Summer Autumn   3000 
            //Winter  2600 

            //<=6 - отстъпка от 10%
            //>7>=11 - отстъпка от 15%
            //<=12 - отстъпка от 25%
            //5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат 

            if (season == "Spring" && fisherman <= 6)
            {
                price = 3000 - 3000 * 0.1;
            }
            else if (season == "Spring" && fisherman > 7 && fisherman <= 11)
            {
                price = 3000 - 3000 * 0.15;
            }
            else if (season == "Spring" && fisherman >= 12)
            {
                price = 3000 - 3000 * 0.25;
            }
            if (season == "Summer" && fisherman <= 6)
            {
                price = 4200 - 4200 * 0.1;
            }
            else if (season == "Summer" && fisherman > 7 && fisherman <= 11)
            {
                price = 4200 - 4200 * 0.15;
            }
            else if (season == "Summer" && fisherman >= 12)
            {
                price = 4200 - 4200 * 0.25;
            }
            if (season == "Autumn" && fisherman <= 6)
            {
                price = 4200 - 4200 * 0.1;
            }
            else if (season == "Autumn" && fisherman > 7 && fisherman <= 11)
            {
                price = 4200 - 4200 * 0.15;
            }
            else if (season == "Autumn" && fisherman >= 12)
            {
                price = 4200 - 4200 * 0.25;
            }
            if (season == "Winter" && fisherman <= 6)
            {
                price = 2600 - 2600 * 0.1;
            }
            else if (season == "Winter" && fisherman > 7 && fisherman <= 11)
            {
                price = 2600 - 2600 * 0.15;
            }
            else if (season == "Winter" && fisherman >= 12)
            {
                price = 2600 - 2600 * 0.25;
            }

            if (fisherman % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }
            if (budget >= price)
            {
                double difference = budget - price;
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else if (price > budget)
            {
                double difference = price - budget;
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}