/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/
using System;


namespace Problem_07
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                Console.Write("Input x coordinate: ");
                double xpoint = double.Parse(Console.ReadLine());
                Console.Write("Input y coordinate: ");
                double ypoint = double.Parse(Console.ReadLine());
                double xcenter = 0;
                double ycenter = 0;
                double rcircle=2;

                double xdistance = Math.Abs(xcenter - xpoint);
                double ydistance = Math.Abs(ycenter - ypoint);

                bool isInCircle = (Math.Pow(rcircle, 2) >= (Math.Pow(xdistance, 2) + Math.Pow(ydistance, 2)));

                Console.WriteLine("Is pot with coordinate [{0},{1}] in a circle with center [{2},{3}] and a radius {4}?\n" + isInCircle, xpoint, ypoint, xcenter, ycenter, rcircle);
                Console.WriteLine("If you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
