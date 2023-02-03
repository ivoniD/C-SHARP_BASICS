using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //	"Not enough money!" - (Ако  парите за декора и дрехите са повече от бюджета) 80b 50r 50
            // "Wingard needs {парите недостигащи за филма} leva more."

            //	"Action!" - (Ако парите за декора и дрехите са по малко или равни на бюджета)
            // "Wingard starts filming with {останалите пари} leva left."
            //форматиран до втория знак 

            double budget = double.Parse(Console.ReadLine()); // бюджет
            int extraPeople = int.Parse(Console.ReadLine()); //брой статисти
            double PriceClothingOneExtra = double.Parse(Console.ReadLine()); // облекло за един

            //•	Декорът за филма е на стойност 10% от бюджета. 
            double decor = budget * 0.1;
            double clothingPrice = extraPeople * PriceClothingOneExtra;
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%.
            if (extraPeople > 150)
            {
                clothingPrice = clothingPrice - clothingPrice * 0.1;
            }
            double expences = decor + clothingPrice;
            double difference = budget - expences;

            if (difference < 0)
            {
                Console.WriteLine("Not enough money!");
                difference = Math.Abs(difference);
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}
