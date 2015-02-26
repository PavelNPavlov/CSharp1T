using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReverseText(input));
        }

        static string ReverseText(string s)
        {
            string start = s;

            List<string> sings = new List<string>();
            List<int> singsIndex = new List<int>();

            string[] temp = s.Split(' ');

            for (int i = 0; i < temp.Length; i++)
            {
                if(temp[i].IndexOf(",")>=0)
                {
                    sings.Add(",");
                    singsIndex.Add(i);
                }
                if (temp[i].IndexOf(".") >= 0)
                {
                    sings.Add(".");
                    singsIndex.Add(i);
                }
                if (temp[i].IndexOf("!") >= 0)
                {
                    sings.Add("!");
                    singsIndex.Add(i);
                }
                if (temp[i].IndexOf("?") >= 0)
                {
                    sings.Add("?");
                    singsIndex.Add(i);
                }
            }//get punctuation signs and positions in word order

            start = start.Replace(",", "");
            start = start.Replace("!", "");
            start = start.Replace(".", "");
            start = start.Replace("?", "");
            //remove them from reversal
            

            string[] words = start.Split(' ');
            Array.Reverse(words);

            int countS = 0;
            for (int i = 0; i < words.Length; i++)
            {
               
                if(i==singsIndex[countS])
                {
                    words[i] += sings[countS];
                    countS++;
                }
            }
            //word reves
            return string.Join(" ",words);
        }


        static string Reverse(string s)
        {
            char[] temp = s.ToCharArray();
            Array.Reverse(temp);

            return new string(temp);
        }
    }
}
