using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            double heritage = double.Parse(Console.ReadLine()); // наследени пари
            int n = int.Parse(Console.ReadLine()); // години до които...
            double spendMoney = 0;
            int years = 0;
            for (int i = 1800; i <= n; i++) // 1802
            {
                if (i % 2 == 0)
                {
                    spendMoney = spendMoney + 12000;
                }
                else
                {
                    years = 18 + (i - 1800);
                    spendMoney = spendMoney + (12000 + 50 * years);
                }
            }
            if (heritage >= spendMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(heritage - spendMoney):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {(spendMoney - heritage):f2} dollars to survive.");
            }

        }
    }
}