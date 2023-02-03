using System;

namespace _6.Num
{
    class Program
    {
        static void Main(string[] args)
        {
            // -100< num <100 !=0
            //извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.

            double num = double.Parse(Console.ReadLine());

            if (num >= -100 && num <= 100 && num != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
