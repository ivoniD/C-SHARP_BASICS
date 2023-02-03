using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	литрите вода, които ще  събира аквариума.
            //  Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            // Console.WriteLine(volume);

            double volumeLit = volume * 0.001; // volume / 1000
                                               //  Console.WriteLine(volumeLit);

            double capacity = volumeLit * (1 - (percent / 100));

            Console.WriteLine(capacity);


        }
    }
}