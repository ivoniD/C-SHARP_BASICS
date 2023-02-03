using System;

namespace _08._Graduation_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            double sumOfGrades = 0;
            int failedGrades = 0;
            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    failedGrades++;
                    if (failedGrades == 2)
                    {
                        break;
                    }
                    continue;
                }

                sumOfGrades += grade;
                year++;
            }

            if (failedGrades == 2)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
            else
            {
                double averrageGrade = sumOfGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averrageGrade:f2}");
            }
        }
    }
}
