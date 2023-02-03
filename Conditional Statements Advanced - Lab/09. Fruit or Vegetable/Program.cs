using System;

namespace _09._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	"fruit"  banana, apple, kiwi, cherry, lemon и grapes
            //•	"vegetable"  tomato, cucumber, pepper и carrot
            //•	 "unknown"

            string product = Console.ReadLine();

            if (product == "banana" || product == "apple" || product == "kiwi"
                                    || product == "cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}