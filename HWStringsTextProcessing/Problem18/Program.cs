using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            string strRegex = @"[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = @"wjeqklejqwek myEmail@hotmail.com a;lekqlwe anothermail@mail.ru";

            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    Console.WriteLine(myMatch);
                }
            }
        }

        /*static string[] ListOfEmails(string s)
        {
            var fragments = Regex.Match(s, @"([A-Za-z0-9\-]+)\*@*.*",
        RegexOptions.IgnoreCase);
        }*/
    }
}
