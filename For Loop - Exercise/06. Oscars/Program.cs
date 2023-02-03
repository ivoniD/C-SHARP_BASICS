using System;

namespace _06._Oscars_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            for (int i = 1; i <= judges; i++)
            {
                string judgeName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                academyPoints = academyPoints + (judgeName.Length * points / 2);

                if (academyPoints >= 1250.5)
                {
                    break;
                }
            }

            if (academyPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {(academyPoints):f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorsName} you need {(1250.5 - academyPoints):f1} more!");
            }
        }
    }
}