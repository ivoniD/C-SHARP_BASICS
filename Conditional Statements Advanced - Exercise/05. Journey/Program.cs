using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //„Somewhere in [дестинация]“ // измежду “Bulgaria", "Balkans” и ”Europe”
            //“{Вид почивка} – {Похарчена сума}“ - Camp  Hotel
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string region = "";
            string type = "";
            double totalPrice = 0;
            //summer - Camp
            //winter -  Hotel
            //Europe - 

            //budget <=100 - Bulgaria
            //-	summer – 30% 
            //-	winter – 70% от бюджета

            //budget <=1000 - Balkans
            //-	summer – 40% 
            //-	winter – 80% 

            //budget>1000 - Europe
            //90% от бюджета


            if (budget <= 100)
            {
                region = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    totalPrice = budget * 0.3;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    totalPrice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                region = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    totalPrice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    totalPrice = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                region = "Europe";
                type = "Hotel";
                totalPrice = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{type} - {totalPrice:f2}");
        }
    }
}