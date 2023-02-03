using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // широчина // 20 - 20 - 20 - 20 - 21
            int b = int.Parse(Console.ReadLine()); // дължина 
            double allPieces = a * b;
            string input = " ";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                double piecesTaken = double.Parse(input);
                allPieces = allPieces - piecesTaken;

                if (allPieces < 0)
                {
                    break;
                }
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{allPieces} pieces are left.");
            }
            else if (true)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
            }
        }
    }
}
