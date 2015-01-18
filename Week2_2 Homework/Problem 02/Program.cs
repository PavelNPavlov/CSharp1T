/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/
using System;

namespace Problem_02
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                Console.Write ("Write weight on Earth:");
                double earthWeight = double.Parse(Console.ReadLine());
                double moonWeight = 0.17 * earthWeight;
                Console.WriteLine("The same object in the Moon will weight: "+moonWeight);
                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
