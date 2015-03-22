using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();
            //encode
            Console.WriteLine(EnDeCode(text,key));
            //decode
            Console.WriteLine(EnDeCode(EnDeCode(text,key),key));
        }

        static string EnDeCode(string str, string key)
        {
            
            char[] tempTxt = str.ToCharArray();
            char[] tempKey = key.ToCharArray();

            int countKey = 0;
            for (int i = 0; i < tempTxt.Length; i++)
            {
                tempTxt[i] = (char) (tempTxt[i] ^ key[countKey]);
                countKey++;
                if(countKey==key.Length)
                {
                    countKey = 0;
                }
            }

            return new string(tempTxt);

        }
    }
}
