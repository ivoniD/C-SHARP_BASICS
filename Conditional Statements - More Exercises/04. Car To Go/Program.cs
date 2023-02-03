using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – "{Вид на класа}"
            //	"Economy class", "Compact class" или "Luxury class"
            //•	Втори ред – "{Вид на колата} - {цена на колата}" // Cabrio / Jeep - до втория знак 
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();  // Summer / Winter
            string clas = "";
            string carType = "";
            double carPrice = 0;
            // if (budget <=100)

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            // if (budget >100 && budget <= 500) - compact ->summer - Cabrio - 45% / winter - Jeep - 80%
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.80;
                }
            }
            else if (budget > 500)
            // if (budget > 500) - lux -> summer && winter - jeep - 90%
            {
                clas = "Luxury class";
                if (season == "Summer" || season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.90;
                }
            }
            //•	Първи ред – "{Вид на класа}"
            //	"Economy class", "Compact class" или "Luxury class"
            //•	Втори ред – "{Вид на колата} - {цена на колата}" // Cabrio / Jeep - до втория знак 
            Console.WriteLine(clas);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
