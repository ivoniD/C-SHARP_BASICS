using System;

namespace _04._Personal_Titles_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	"Mr." – мъж (пол 'm') на 16 или повече години ->   >=16 check
            //•	"Master" – момче (пол 'm') под 16 години      ->   <16
            //•	"Ms." – жена (пол 'f') на 16 или повече години->   >=16
            //•	"Miss" – момиче (пол 'f') под 16 години       ->   <16

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();


            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }

            }


        }
    }
}