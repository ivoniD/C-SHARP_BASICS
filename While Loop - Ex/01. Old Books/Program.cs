using System;

namespace old_booook
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int counter = 0;
            string randomBook = "";

            while (true)
            {
                randomBook = Console.ReadLine();
                if (randomBook == "No More Books")
                {
                    break;
                }
                if (randomBook == favBook)
                {
                    break;
                }
                counter++;
            }
            if (randomBook == favBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
