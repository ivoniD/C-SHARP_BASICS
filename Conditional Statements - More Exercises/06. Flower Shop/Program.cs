using System;

namespace Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Ако парите СА стигнали: "She is left with {останали} leva." –
            //-сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1).
            //•	Ако парите НЕ достигат: "She will have to borrow {останали} leva." –
            //-сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2).
            int magnolias = int.Parse(Console.ReadLine()); // 3.25 
            int zumbuli = int.Parse(Console.ReadLine()); // 4
            int roses = int.Parse(Console.ReadLine()); //3.50
            int cactuses = int.Parse(Console.ReadLine()); // 8
            double precentPrice = double.Parse(Console.ReadLine());
            //От общата сума, Мария трябва да плати 5% данъци

            double flowersPrice = (magnolias * 3.25) + (zumbuli * 4) + (roses * 3.50) + (cactuses * 8);
            double taxes = flowersPrice * 0.05;
            double profit = flowersPrice - taxes;

            if (profit >= precentPrice)
            {
                double difference = profit - precentPrice;
                difference = Math.Floor(difference);
                Console.WriteLine($"She is left with {difference} leva.");
            }
            else
            {
                double difference = precentPrice - profit;
                difference = Math.Ceiling(difference);
                Console.WriteLine($"She will have to borrow {difference} leva.");
            }
        }
    }
}
