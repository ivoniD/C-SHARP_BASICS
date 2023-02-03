using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputSteps = "";
            double allSteps = 0;
            string inputSteps = Console.ReadLine();
            while (inputSteps != "Going home")
            {

                int steps = int.Parse(inputSteps);
                allSteps += steps;
                if (allSteps >= 10000)
                {
                    break;

                }
                inputSteps = Console.ReadLine();
            }
            if (inputSteps == "Going home")
            {
                double stepsToHome = double.Parse(Console.ReadLine());
                allSteps = allSteps + stepsToHome;
                if (allSteps < 10000)
                {

                    double difference = 10000 - allSteps;
                    Console.WriteLine($"{difference} more steps to reach goal.");

                }
                else if (allSteps >= 10000)
                {
                    double diff = allSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{diff} steps over the goal!");
                }

            }
            else if (allSteps >= 10000)
            {
                double diff = allSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }


        }
    }
}
