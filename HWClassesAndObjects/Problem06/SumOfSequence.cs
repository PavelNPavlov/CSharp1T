using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class SumOfSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(SumOfString(input));
        }

        static int SumOfString(string s)
        {
            string[] temp = s.Split(' ');

            int sum = 0;
            foreach (var item in temp)
            {
                sum += int.Parse(item);
            }
            return sum;
        }
    }
}
