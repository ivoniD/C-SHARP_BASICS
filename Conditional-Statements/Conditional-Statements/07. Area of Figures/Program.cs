using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();

            //квадрат (square): едно дробно число - дължина на страната му
            if (form == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:F3}");
            }
            //правоъгълник (rectangle): две дробни числа - дължините на страните му
            else if (form == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            //кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
            else if (form == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * (r * r);
                Console.WriteLine($"{area:f3}");
            }
            //триъгълник (triangle): две дробни числа - дължината на страната му
            //и дължината на височината към нея
            else if (form == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double area = (a * ha) / 2;
                Console.WriteLine($"{area:f3}");

            }


        }
    }
}
