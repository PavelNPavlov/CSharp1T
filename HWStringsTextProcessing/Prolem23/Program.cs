using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolem23
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReformatString(input));
        }

        static string ReformatString(string s)
        {
            char[] symbols = s.ToCharArray();
            StringBuilder result = new StringBuilder();
            result.Append(symbols[0]);
            for (int i = 1; i < symbols.Length; i++)
            {
                if(symbols[i]!=symbols[i-1])
                {
                    result.Append(symbols[i].ToString());
                }
            }
            return result.ToString();
        }
    }
}
