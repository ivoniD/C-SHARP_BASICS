using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {

            double pensil = double.Parse(Console.ReadLine());
            double marker = double.Parse(Console.ReadLine());
            double liter = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = (pensil * 5.80) + (marker * 7.20) + (liter * 1.20);
            double discount = sum * (percent / 100);

            double totalSum = sum - discount;

            Console.WriteLine(totalSum);




        }
    }
}
