/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;

namespace Problem04
{
    class Signs
    {
        static void Main()
        {
            double a, b, c, zeroCheck;
            try
            {
            Start:
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                //Creat Bools
                bool asign = (a > 0);
                bool bsign = (b > 0);
                bool csign = (c > 0);
                bool zero = (a == 0 || b == 0 || c == 0);
                //Get sings
                a = asign ? 1 : -1;
                b = bsign ? 1 : -1;
                c = csign ? 1 : -1;
                zeroCheck = zero ? 0 : 1;
                //Print result, if the ouput wasn't supposed to be only a sign, there will be no need of if statemest( a*b*c*zeroCheck =-1,0,+1)
                if (a * b * c * zeroCheck == 0)
                {
                    Console.WriteLine(a * b * c * zeroCheck);
                }
                else if (a * b * c * zeroCheck < 0)
                {
                    Console.WriteLine("-");
                }

                else if (a * b * c * zeroCheck > 0)
                {
                    Console.WriteLine("+");
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalide output");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
