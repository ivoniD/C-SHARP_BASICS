using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 5
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                if (double.Parse(input) <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
                Console.WriteLine($"Increase: {double.Parse(input):f2}");//5

                sum += double.Parse(input);

                input = Console.ReadLine();
            }
            if (input == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {sum:f2}");
            }

        }
    }
}
