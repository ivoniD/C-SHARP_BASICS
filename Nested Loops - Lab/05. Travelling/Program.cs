using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine(); //Когато е посетила всички дестинации, които иска, вместо дестинация ще въведе "End" 
            double minBudget;
            double save;

            while (destination != "End")
            {
                minBudget = double.Parse(Console.ReadLine());
                double saveings = 0;
                while (saveings < minBudget)
                {
                    save = double.Parse(Console.ReadLine());
                    saveings = saveings + save;
                }
                if (saveings >= minBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                destination = Console.ReadLine();
            }

        }
    }
}
