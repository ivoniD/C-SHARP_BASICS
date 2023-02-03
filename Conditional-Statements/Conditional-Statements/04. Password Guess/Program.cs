using System;

namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"s3cr3t!P@ssw0rd".
            //При съвпадение да се изведе "Welcome".
            //При несъвпадение да се изведе "Wrong password!". 

            string pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
