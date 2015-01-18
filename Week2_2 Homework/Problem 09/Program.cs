/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
using System;


namespace Problem_09
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                Console.Write("Input base: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Input base: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Input height: ");
                double h = double.Parse(Console.ReadLine());


                double area = (a+b)/2*h;
                Console.WriteLine("Trapezoid with base {0} and {1} and a height {2} has an area of: {3}", a,b,h,area);
                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
