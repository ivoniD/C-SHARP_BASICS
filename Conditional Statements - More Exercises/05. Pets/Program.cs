using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {килограма остатък} kilos of food left. - •	Ако оставената храна Е достатъчна
            // {килограма недостигат} more kilos of food are needed. - •	Ако оставената храна НЕ Е достатъчна
            // закръглен към по-високото цяло число

            int days = int.Parse(Console.ReadLine()); // брой дни 
            int food = int.Parse(Console.ReadLine()); // оставена храна в килограми 
            double dogFood = double.Parse(Console.ReadLine()); // храна на ден за кучето в килограми 
            double catFood = double.Parse(Console.ReadLine()); // храна на ден за котката в килограми 
            double turtleFood = double.Parse(Console.ReadLine()); // храна на ден за костенурката в грамове  

            double dogNeeds = days * dogFood;// 2
            double catNeeds = days * catFood; // 2
            double turtleNeedsG = days * turtleFood;
            double turtleNeedsKG = turtleNeedsG / 1000; //2.4
            double allNeeds = dogNeeds + catNeeds + turtleNeedsKG; //6.4

            if (food >= allNeeds)
            {
                double difference = food - allNeeds;
                difference = Math.Floor(difference);
                Console.WriteLine($"{difference} kilos of food left.");
            }
            else
            {
                double difference = allNeeds - food;
                difference = Math.Ceiling(difference);
                Console.WriteLine($"{difference} more kilos of food are needed.");
            }
        }
    }
}
