using System;

namespace _03.animal_type_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.dog -> mammal
            //2.crocodile, tortoise, snake->reptile
            //3.others->unknown

            string animal = Console.ReadLine();

            if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
            {
                Console.WriteLine("reptile");
            }
            else if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}