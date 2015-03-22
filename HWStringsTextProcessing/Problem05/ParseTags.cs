using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(UperCaseTags(input));
        }

        static string UperCaseTags(string s)
        {
            string result = s;

            int pFrom=0;
            int pTo = 0;
            while (true)
            {
                pFrom = result.IndexOf("<upcase>") + "<upcase>".Length;
                pTo = result.IndexOf("</upcase>");
                
                if(pTo<0)
                {
                    break;
                }
                
                string subStr = result.Substring(pFrom, pTo - pFrom);

                result = result.Remove(result.IndexOf("<upcase>"), "<upcase>".Length);
                result = result.Remove(result.IndexOf("</upcase>"), "</upcase>".Length);
                result = result.Replace(subStr, subStr.ToUpper());
            }

            return result; 
        }
    }
}
