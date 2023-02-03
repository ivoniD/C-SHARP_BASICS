using System;

namespace _08._Tennis_Ranklist_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            double w = 0;
            double f = 0;
            double sf = 0;
            double allPoints = 0;
            double percent = 0;

            for (int i = 1; i <= n; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    w++;
                    points = points + 2000;
                }
                else if (stage == "F")
                {
                    f++;
                    points = points + 1200;
                }
                else if (stage == "SF")
                {
                    sf++;
                    points = points + 720;
                }

                allPoints = (w * 2000) + (f * 1200) + (sf * 720);

                percent = w / n * 100;
            }
            double average = allPoints / n;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
