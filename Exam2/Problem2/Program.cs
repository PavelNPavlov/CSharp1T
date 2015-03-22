using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = input.Split(' ').Select(long.Parse).ToArray();
            
            int count = 1;
            long sumEven = 0;
            do
            {
                long temp=AbsDifference(numbers[count], numbers[count - 1]);
                if(temp%2==0)
                {
                    count += 2;
                    sumEven += temp;
                }
                else
                {
                    count++;
                }

                if (count > numbers.Length - 1) { break; }
            } while (true);

            Console.WriteLine(sumEven);
        }

        static long AbsDifference(long n, long m)
        {
            return (n>m)? (n-m) : (m-n);
        }
    }
}
