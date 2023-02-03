using System;

namespace _02._Summer_Outfit_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreeces = int.Parse(Console.ReadLine());
            string dayPart = Console.ReadLine();

            string Outfit = "Shirt";
            string Shoes = "Moccasins";
            //18 < градуси <= 24
            if (degreeces >= 10 && degreeces <= 18 && dayPart == "Morning")
            {
                Outfit = "Sweatshirt";
                Shoes = "Sneakers";
            }
            else if ((degreeces > 18 && degreeces <= 24 && dayPart == "Afternoon") || (degreeces >= 25 && dayPart == "Morning"))
            {
                Outfit = "T-Shirt";
                Shoes = "Sandals";
            }
            else if (degreeces >= 25 && dayPart == "Afternoon")
            {
                Outfit = "Swim Suit";
                Shoes = "Barefoot";
            }

            Console.WriteLine($"It's {degreeces} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
