using System;

namespace _02._Exam_Preparation_exx
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatGrades = int.Parse(Console.ReadLine());
            double sumGrades = 0;
            string nameProb = "";
            int counProblems = 0;
            string lastProb = "";
            int countUnsatGrades = 0;
            while (true)
            {
                nameProb = Console.ReadLine();

                if (nameProb == "Enough")
                {
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    countUnsatGrades++;
                }
                if (countUnsatGrades == unsatGrades)
                {
                    break;

                }
                counProblems++;
                sumGrades += grade;
                lastProb = nameProb;
            }
            double average = sumGrades / counProblems;
            if (nameProb == "Enough")
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counProblems}");
                Console.WriteLine($"Last problem: {lastProb}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countUnsatGrades} poor grades.");
            }

        }
    }
}