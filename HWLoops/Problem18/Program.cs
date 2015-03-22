/*Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

using System;
using System.Numerics;


//caculating the factorial takes too much time; Hence there should be a quicker method. This solution is based on the fact that only multiples of 5 could give a zero. Same goes for any power of 5.
namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());

                int count5 = 1;
                BigInteger countE = 0;

                int zeroC=0;
                while(true)
                {
                    if (n / Math.Pow(5, count5) == 0) { break; }
                    else
                    {
                        zeroC += (n / (int)Math.Pow(5, count5));
                        
                    }
                    count5++;

                }
                
                Console.WriteLine(zeroC);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
//brute force
/*namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                BigInteger factorial = 1;
                for(int i=1; i<=n;i++)
                {
                    factorial *= i;
                }
                //Console.WriteLine(factorial);
                int trail0 = 0;

               while(true)
                {
                    if(factorial%10==0)
                    {
                        trail0++;
                        factorial /= 10;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(trail0);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}*/


