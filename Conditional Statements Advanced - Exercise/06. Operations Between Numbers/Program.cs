using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //	"{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            // "{N1} % {N2} = {остатък}"
            //!!!!!!!делителят може да е равен на 0(нула), а на нула не се дели - 	"Cannot divide {N1} by zero"
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine(); //„+“, „-“, „*“, „/“, „%“

            //„+“, „-“, „*“ - > "result" - even or odd
            //„/“ -> "result" 
            //„%“ -> "difference"
            if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (symbol == "+")
            {
                double result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
                }
            }
            else if (symbol == "-")
            {
                double result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
                }
            }
            else if (symbol == "*")
            {
                double result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
                }
            }
            else if (symbol == "/")
            {
                double result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");

            }

            else if (symbol == "%")
            {
                double result = (num1 % num2);
                Console.WriteLine($"{num1} % {num2} = {result}");
            }
        }
    }
}