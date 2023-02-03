using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            //- check - номерата на стаите в една сграда (в низходящ ред) 
            //всеки четен етаж има само офиси - офис се означава: О{номер на етажа}{номер на офиса} - номерата започват от 0
            //всеки нечетен етаж има само апартаменти - апартамент се означава: А{номер на етажа}{номер на апартамента} -  номерата започват от 0
            //На последният етаж винаги има апартаменти - пред номера им пише 'L', вместо 'А'

            int floors = int.Parse(Console.ReadLine());//6
            int rooms = int.Parse(Console.ReadLine());//4

            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($" L{i}{j}");
                    }
                    if (i % 2 == 0 && i != floors) //само офиси
                    {
                        Console.Write($" O{i}{j}");
                    }
                    else if (i % 2 != 0 && i != floors)
                    {
                        Console.Write($" A{i}{j}");
                    }
                    // Console.Write($"{i}{j}");
                }
                Console.WriteLine("");
            }

        }
    }
}
