/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.*/
using System;


namespace Problem02
{
    class Compare
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                Console.WriteLine("Enter size of arrays");
                int size = int.Parse(Console.ReadLine());

                int[] array1=new int[size];
                int[] array2 = new int[size];
                Console.WriteLine("Input elemets of array1");
                for(int i=0; i<size;i++)
                {
                    Console.Write("1_"+i + ": ");
                    array1[i] = int.Parse(Console.ReadLine());
                }
                
                Console.WriteLine("Input elemets of array2");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("2_" + i + ": ");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                bool areE = true;
                for(int i=0;i<size;i++)
                {
                    if (array1[i] != array2[i]) { areE = false; }
                }

                Console.WriteLine("Arrays are equal: " + areE);
            }

            catch(FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }

        }
    }
}
