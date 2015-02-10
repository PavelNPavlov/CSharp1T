/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/
using System;


namespace Problem03
{
    class compareChar
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                Console.WriteLine("Enter size of arrays");
                int size = int.Parse(Console.ReadLine());

                char[] array1 = new char[size];
                char[] array2 = new char[size];
                Console.WriteLine("Input elemets of array1");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("1_" + i + ": ");
                    array1[i] = Console.ReadLine()[0];
                }

                Console.WriteLine("Input elemets of array2");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("2_" + i + ": ");
                    array2[i] = Console.ReadLine()[0];
                }

                bool areE = true;
                for (int i = 0; i < size; i++)
                {
                    if (array1[i] != array2[i]) { areE = false; }
                }

                Console.WriteLine("Arrays are equal: " + areE);
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
