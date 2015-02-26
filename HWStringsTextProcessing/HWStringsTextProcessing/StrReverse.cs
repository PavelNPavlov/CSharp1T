using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWStringsTextProcessing
{
    class StrReverse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(Reverse(input));
        }

        static string Reverse(string s)
        {
            char[] temp = s.ToCharArray();

            Array.Reverse(temp);

            string output = new string (temp);

            return output;
        }
    }
}
