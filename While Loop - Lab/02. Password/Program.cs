using System;

namespace _02._Password_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pass = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != pass)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}