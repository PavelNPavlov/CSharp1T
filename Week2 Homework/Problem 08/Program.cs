/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©*/
using System;
using System.Text;

namespace Problem_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // За да излезе правилно от properties на конзолата се избира Consolas font
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("    ©");
            Console.WriteLine("");
            Console.WriteLine("   © ©  ");
            Console.WriteLine("");
            Console.WriteLine("  ©   © ");
            Console.WriteLine("");
            Console.WriteLine(" © © © ©");

        }
    }
}
