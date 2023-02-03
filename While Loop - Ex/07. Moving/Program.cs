using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string input = "";
            int allBoxes = 0;
            int freeSpace = a * b * c;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int boxes = int.Parse(input);
                allBoxes += boxes;
                if (allBoxes > freeSpace)
                {
                    break;
                }
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace - allBoxes} Cubic meters left.");
            }
            else if (allBoxes > freeSpace)
            {
                Console.WriteLine($"No more free space! You need {allBoxes - freeSpace} Cubic meters more.");
            }
        }
    }
}
