using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.00 и 2.99
            //3.00 и 3.99
            //4.00 и 4.99
            //5.00 или повече
            int n = int.Parse(Console.ReadLine()); // броя на студентите явили се на изпит 
            double a2 = 0;
            double a3 = 0;
            double a4 = 0;
            double a5 = 0;
            double av = 0;
            for (int i = 1; i <= n; i++)
            {
                double assessment = double.Parse(Console.ReadLine());
                av = av + assessment;
                if (assessment >= 2 && assessment <= 2.99)
                {
                    a2++;
                }
                else if (assessment <= 3.99)
                {
                    a3++;
                }
                else if (assessment <= 4.99)
                {
                    a4++;
                }
                else if (assessment >= 5.00)
                {
                    a5++;
                }
            }

            double a2P = a2 / n * 100;
            double a3P = a3 / n * 100;
            double a4P = a4 / n * 100;
            double a5P = a5 / n * 100;
            double average = av / n;

            Console.WriteLine($"Top students: {a5P:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {a4P:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {a3P:f2}%");
            Console.WriteLine($"Fail: {a2P:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
