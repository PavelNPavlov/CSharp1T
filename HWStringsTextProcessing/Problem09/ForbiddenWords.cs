using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string fwords = Console.ReadLine();

            Console.WriteLine(BleepWords(input,fwords));
        }

        static string BleepWords(string s, string bwords)
        {
            string[] bleep = bwords.Split(' ');
            string result = s;
            foreach (var item in bleep)
            {
                result = result.Replace(item, new string('*', item.Length));
            }

            return result;
        }
    }
}
