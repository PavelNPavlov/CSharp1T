/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/
using System;


namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input sides of rectagular");
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double primeter = 2 * (width + height);
                double area = width * height;
                Console.WriteLine("with: {0}, height: {1}, perimeter: {2}, area: {3} ", width, height, primeter, area);
                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
