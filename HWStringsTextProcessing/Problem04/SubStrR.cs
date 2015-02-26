using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class SubStrR
    {
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            string subStr = Console.ReadLine();

            Console.WriteLine(NumberOfSubstring(source, subStr));
        }

        static int NumberOfSubstring (string str, string sub) //removes the substring and compare lenghts. 
        {
            int count = 0;
            string temp=str.Replace(sub, ""); //or use remove

            count = (str.Length - temp.Length) / sub.Length;
           
            return count;
        }
    }
}
