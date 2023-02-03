using System;

namespace exam___03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Easter trip to {дестинация} : {разходи за екскурзията} leva."
            string destination = Console.ReadLine(); // дестинация - France ,Italy, Germany
            string dates = Console.ReadLine(); // "21 - 23"     "24 - 27"    "28 - 31"   
            int nights = int.Parse(Console.ReadLine()); // брой нощувки
            double expenses = 0;
            //Дестинация     21 - 23 март   24 - 27 март    28 - 31 март
            //Франция          30 лв.          35 лв.          40 лв.
            //Италия           28 лв.          32 лв.          39 лв.
            //Германия         32 лв.          37 лв.          43 лв.
            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    expenses = nights * 30;
                }
                else if (dates == "24-27")
                {
                    expenses = nights * 35;
                }
                else if (dates == "28-31")
                {
                    expenses = nights * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    expenses = nights * 28;
                }
                else if (dates == "24-27")
                {
                    expenses = nights * 32;
                }
                else if (dates == "28-31")
                {
                    expenses = nights * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    expenses = nights * 32;
                }
                else if (dates == "24-27")
                {
                    expenses = nights * 37;
                }
                else if (dates == "28-31")
                {
                    expenses = nights * 43;
                }
            }

            Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
        }
    }
}
