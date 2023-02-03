using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine(); //100/10/20/50/40/Stop
            int maxNum = int.MinValue;
            while (input != "Stop")
            {
                int inputNum = int.Parse(input);
                if (inputNum > maxNum)
                {
                    maxNum = inputNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
