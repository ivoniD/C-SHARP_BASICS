using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се отпечата на конзолата един ред:  "{цена на поръчката}"

            double chicken = double.Parse(Console.ReadLine()); //•	Пилешко меню –  10.35 лв. 
            double fish = double.Parse(Console.ReadLine());   // •  Меню с риба – 12.40 лв. 
            double veg = double.Parse(Console.ReadLine());   //  •  Вегетарианско меню  – 8.15 лв. 

            //Групата ще си поръча и десерт, чиято цена е равна на 20% от общата сметка (без доставката). 
            //Цената на доставка е 2.50 лв и се начислява най - накрая.

            double foodCosat = (chicken * 10.35) + (fish * 12.40) + (veg * 8.15);
            double desertCost = foodCosat * 0.2;

            double check = foodCosat + desertCost + 2.50;

            Console.WriteLine(check);




        }
    }
}