using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem12
{
    class UrlParse
    {
        static void Main(string[] args)
        {
            string uri = Console.ReadLine();

            var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(fragments[1]);
            Console.WriteLine(fragments[2]);
            Console.WriteLine(fragments[3]);
        }
    }
}
