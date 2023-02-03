using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // Summer / Winter
            string location = ""; // "Alaska" и "Morocco"
            string type = ""; //"Hotel", "Hut" или "Camp"
            double price = 0;

            if (budget <= 1000)
            //if(budget <=1000) - Camp -> sum - Alaska - 65% / win -Morocco - 45%
            {
                type = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            //if(budget > 1000 && budget <=3000) - Hut -> sum - Alaska - 80% / win - Morocco - 60%
            {
                type = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            //if(budget > 3000) - Hotel - sum - Alaska - 90% / win - Morocco - 90%
            {
                type = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            //"{локацията} – {мястото за настаняване} – {цената}" - до втори знак
            Console.WriteLine($"{location} - {type} - {price:f2}");
        }
    }
}
