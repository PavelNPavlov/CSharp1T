using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class ExtractSentence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(SentenceSubStr(input));
        }

        static string SentenceSubStr(string s)
        {
            string[] temp = s.Split('.');

            string result = "";

            foreach (var item in temp)
            {
                if(item.IndexOf(" in ")>0)
                {
                    result += item+".";
                }
            }

            return result;
        }
    }
}
