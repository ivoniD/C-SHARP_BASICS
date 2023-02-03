using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //колко ще са разходите на Джеси, ако започне да спортува баскетбол

            double taxPerYear = double.Parse(Console.ReadLine());

            //•	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
            double snickers = taxPerYear - (taxPerYear * 0.4);

            //•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
            double equipment = snickers - (snickers * 0.2);

            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип

            double ball = equipment / 4;

            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            double accessories = ball / 5;

            double totalCost = taxPerYear + snickers + equipment + ball +
                accessories;

            Console.WriteLine(totalCost);



        }
    }
}
