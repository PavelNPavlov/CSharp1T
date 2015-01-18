/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

namespace Problem12
{
    class Program
    {
        static void Main()
        {
            int? intnum = null;
            double? doublenum = null;
            Console.WriteLine("Pring nulls");
            Console.WriteLine(intnum);
            Console.WriteLine(doublenum);
            Console.WriteLine("Print after addition of 10");
            Console.WriteLine(intnum+10);
            Console.WriteLine(doublenum+10.0);


        }
    }
}
