using System;

namespace _04._Toy_Shop_NEW_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ще има ли пари да отиде на екскурзия
            // "Yes! {оставащите пари} lv left." - когато са достатъчно
            //	"Not enough money! {недостигащите пари} lv needed." - когато не стигат
            //до втория знак 
            double vac = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());
            //50 или повече - отстъпка 25% от общата цена
            //10% за наема 

            double toysAll = puzzles + dolls + bears + minions + tracks;
            double PriceToys = (puzzles * 2.6) + (dolls * 3.0) + (bears * 4.1) + (minions * 8.2) + (tracks * 2.0);

            if (toysAll >= 50)
            {
                double discount = PriceToys * 0.25;
                PriceToys = PriceToys - discount;
            }

            PriceToys = PriceToys - (PriceToys * 0.1);

            double difference = PriceToys - vac;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }


        }
    }
}
