/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Prime
    {
        static void Main(string[] args)
        {
            //takes a while for the run 
            List<int> allNum = new List<int>();

            for(int i=0;i<10000000;i++)
            {
                allNum.Add(i + 1);
            }
            double limit = Math.Sqrt(10000000);
            int limit1 = (int)limit;
            for(int i=1;i<limit1+1;i++)
            { 
                //if (i > allNum.Count) { break; }
                allNum.RemoveAll(x => x % allNum[i] == 0 && x != allNum[i]);
                Console.WriteLine(i);
               
            }

            foreach(int value in allNum)
            {
                Console.WriteLine(value);
            }

        }
    }
}
