using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new System.Globalization.CultureInfo("en-CA");
            string strRegex = @"[0-9]{2}.[0-9]{2}.[0-9]{4}";

            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = @"wjeqklejqwek 22.10.2015 a;lekqlwe anothermail@mail.ru";
            DateTime temp;
            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    string s = myMatch.ToString();
                    if(DateTime.TryParse(s,out temp))
                    {
                        Console.WriteLine("{0}",temp,"DD.MM.YYY",culture);
                    }
                }
            }
        }
        
    }
}
