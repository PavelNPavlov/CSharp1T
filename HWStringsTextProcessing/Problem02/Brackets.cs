using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Brackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(CorrectBrackets(input));
        }

        static bool CorrectBrackets(string s)
        {
            bool result = false;

            int rightB = s.Count(o => o == ')');
            int leftB = s.Count(o => o == '(');

            result = rightB == leftB;
            
            return result;
        }
    }
}
