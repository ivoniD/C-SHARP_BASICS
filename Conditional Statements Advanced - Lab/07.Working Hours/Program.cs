using System;

namespace _7.Working_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //час от денонощието(цяло число)
            int hour = int.Parse(Console.ReadLine());
            //ден от седмицата
            string weekDay = Console.ReadLine();
            //работното време на офисът е от 10-18 часа, от понеделник до събота включително

            if (weekDay != "Sunday")
            {
                if (hour < 18 && hour >= 10)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }



        }
    }
}