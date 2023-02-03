using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // е валидно, ако е в диапазона[100…200] или е 0
            //"invalid" ако въведеното число не е валидно

            int num = int.Parse(Console.ReadLine());

            if ((num >= 100 && num <= 200) || num == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}