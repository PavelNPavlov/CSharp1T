using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] wordBank = text.Split(' ');
            foreach (var item in wordBank)
            {
                var temp = Reverse(item);
                if(temp.Equals(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        static string Reverse(string s)
        {
            char[] temp = s.ToCharArray();

            Array.Reverse(temp);

            string output = new string(temp);

            return output;
        }
    }
}
