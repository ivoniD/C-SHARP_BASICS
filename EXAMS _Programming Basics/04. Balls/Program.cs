using System;

namespace exam___04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //броят на топките // - 3
            double totalPoints = 0;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int elseCount = 0;
            int blackCount = 0;
            for (int i = 0; i < n; i++)
            {
                string color = Console.ReadLine(); // -white - black - pink
                if (color == "red")
                //•	Ако топката е “red” точките ни се повишават с 5.
                {
                    redCount++;
                    totalPoints = totalPoints + 5;
                }
                else if (color == "orange")
                //•	Ако топката е “orange” точките ни се повишават с 10.
                {
                    orangeCount++;
                    totalPoints = totalPoints + 10;
                }
                else if (color == "yellow")
                //•	Ако топката е “yellow” точките ни се повишават с 15.
                {
                    yellowCount++;
                    totalPoints = totalPoints + 15;
                }
                else if (color == "white")
                //•	Ако топката е “white” точките ни се повишават с 20.
                {
                    whiteCount++;
                    totalPoints = totalPoints + 20;
                }
                else if (color == "black")
                //•	Ако топката е “black” точките ни се делят на 2, като закръгляме към по-малкото цяло число.
                {
                    blackCount++;
                    totalPoints = Math.Floor(totalPoints / 2);
                }
                else
                {
                    elseCount++;
                    continue;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}"); //countAllBalls
            Console.WriteLine($"Red balls: {redCount}"); //redCount
            Console.WriteLine($"Orange balls: {orangeCount}"); // orangeCount
            Console.WriteLine($"Yellow balls: {yellowCount}"); // yellowCount
            Console.WriteLine($"White balls: {whiteCount}"); // whiteCount
            Console.WriteLine($"Other colors picked: {elseCount}"); // elseCount
            Console.WriteLine($"Divides from black balls: {blackCount}"); //blackCount


        }
    }
}
