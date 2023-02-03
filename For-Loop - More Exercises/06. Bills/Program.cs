using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double other = 0; // събират се тока, водата и интернета за месеца и към сумата се прибавят 20%
            double elAllMonths = 0;
            double waterAllMonths = 0;
            double internetAllMonths = 0;
            for (int i = 1; i <= n; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                elAllMonths = elAllMonths + electricity;
                waterAllMonths = water * n;
                internetAllMonths = internet * n;
                other = other + (water + internet + electricity) + ((water + internet + electricity) * 0.2);
            }
            Console.WriteLine($"Electricity: {elAllMonths:f2} lv");
            Console.WriteLine($"Water: {waterAllMonths:f2} lv");
            Console.WriteLine($"Internet: {internetAllMonths:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            double average = (elAllMonths + waterAllMonths + internetAllMonths + other) / n;
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
