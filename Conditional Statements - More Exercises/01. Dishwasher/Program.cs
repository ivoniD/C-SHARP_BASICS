using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string input = "";
            int counter = 0;
            int ml = bottles * 750;
            int dishesMl = 0;
            int plate = 0;
            int pot = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                counter++;
                int dishes = int.Parse(input);
                dishesMl = dishes * 5;
                if (counter % 3 == 0)
                {
                    pot += dishes;
                    dishesMl = dishes * 15;
                    if (ml < dishesMl)
                    {
                        break;
                    }
                }
                else if (counter % 3 != 0)
                {
                    plate += dishes;
                }
                ml = ml - dishesMl;
                if (ml < 0)
                {
                    break;
                }
            }

            if (input == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plate} dishes and {pot} pots were washed.");
                Console.WriteLine($"Leftover detergent {ml} ml.");
            }
            else if (ml < dishesMl)
            {
                Console.WriteLine($"Not enough detergent, {dishesMl - ml} ml. more necessary!");
            }
        }
    }
}
