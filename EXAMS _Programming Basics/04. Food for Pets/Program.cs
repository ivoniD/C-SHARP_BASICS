using System;

namespace exam___04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Брой дни – цяло число в диапазона[1…30]
            int days = int.Parse(Console.ReadLine());
            //•	Общо количество храна – реално число в диапазона[0.00…10000.00]
            double allFood = double.Parse(Console.ReadLine());
            int cookieCounter = 0;
            double dogEatenFood = 0;
            double catEatenFood = 0;
            double dayfood = 0;
            double eatenCookies = 0;
            double biscuits = 0;
            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());
                dogEatenFood += dogFood;
                catEatenFood += catFood;
                if (i % 3 == 0)
                {
                    cookieCounter++;
                    dayfood = dogFood + catFood;
                    eatenCookies = dayfood * 0.1;
                    biscuits += eatenCookies;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            double allEatenFood = dogEatenFood + catEatenFood;
            // Console.WriteLine(allEatenFood);
            double percentAllFoood = (allEatenFood / allFood) * 100;
            double percentDog = (dogEatenFood / allEatenFood) * 100;
            double percentCat = (catEatenFood / allEatenFood) * 100;

            Console.WriteLine($"{percentAllFoood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");
        }
    }
}
