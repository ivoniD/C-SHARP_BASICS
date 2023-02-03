using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {


            double nylon = double.Parse(Console.ReadLine());  
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine()); 
            double hours = double.Parse(Console.ReadLine());

    

            double nylonCost = (nylon + 2) * 1.50;

            double paintCost = (paint + (paint * 0.1)) * 14.50;

            double thinnerCost = thinner * 5.00;

            double materialCost = nylonCost + paintCost + thinnerCost + 0.40;

            double workerCost = materialCost * 0.3;

            double total = materialCost + (workerCost * hours);

            Console.WriteLine(total);


        }
    }
}