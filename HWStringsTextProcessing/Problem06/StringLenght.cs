using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StrComplete(input));
        }

        static string StrComplete(string s)
        {
            string result=s;
            while (result.Length>20)
            {
                Console.WriteLine("Invalid String.");
                result = Console.ReadLine();
            }

            result = result.PadRight(20, '*');

            return result;
        }
    }
}
