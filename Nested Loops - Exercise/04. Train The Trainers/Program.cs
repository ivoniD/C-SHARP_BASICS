using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); // хора в журито
            string presentation = Console.ReadLine();
            double counter = 0;
            double allEvaluations = 0;
            while (presentation != "Finish")
            {
                counter++;
                double eval = 0;
                for (int i = 0; i < n; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    eval += evaluation;
                    allEvaluations += evaluation;
                }
                Console.WriteLine($"{presentation} - {(eval / n):f2}.");

                presentation = Console.ReadLine();
            }
            if (presentation == "Finish")
            {
                double average = allEvaluations / (counter * n);
                Console.WriteLine($"Student's final assessment is {average:f2}.");
            }


        }
    }
}
