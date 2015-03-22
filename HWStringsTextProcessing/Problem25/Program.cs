
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem25
{
    class Program
    {
        static List<string> titles = new List<string>();
        static List<string> paragraphs = new List<string>();

        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            string terminate="</html>";
            while(true)
            {
                string temp=Console.ReadLine();
                text.Append(temp);
                if(temp.Equals(terminate) )
                { break; }
            }
            Tittle(text.ToString());
            Body(text.ToString());

            foreach (var item in titles)
            {
                Console.WriteLine("Title: {0}",item);
            }

            foreach (var item in paragraphs)
            {
                Console.WriteLine("Text: {0}", item);
            }
            
        }

        static void Tittle(string s)
        {
            string result = s;

            int pFrom = 0;
            int pTo = 0;
            while (true)
            {
                pFrom = result.IndexOf("<head><title>") + "<head><title>".Length;
                pTo = result.IndexOf("</title></head>");

                if (pTo < 0)
                {
                    break;
                }

                string subStr = result.Substring(pFrom, pTo - pFrom);

                titles.Add(subStr);

                result = result.Remove(result.IndexOf("<head><title>"), "<head><title>".Length);
                result = result.Remove(result.IndexOf("</title></head>"), "</title></head>".Length);
                
               
            }

            
        }

        static void Body(string s)
        {
            string result = s;

            int pFrom = 0;
            int pTo = 0;
            while (true)
            {
                pFrom = result.IndexOf("<body><p>") + "<body><p>".Length;
                pTo = result.IndexOf("</p></body>");

                if (pTo < 0)
                {
                    break;
                }

                string subStr = result.Substring(pFrom, pTo - pFrom);

                subStr = TagReformat(subStr);
               
                paragraphs.Add(subStr.Replace("</a>"," ").Replace("  "," "));

                result = result.Remove(result.IndexOf("<body><p>"), "<body><p>".Length);
                result = result.Remove(result.IndexOf("</p></body>"), "</p></body>".Length);


            }

        }

        static string TagReformat(string s)
        {
            string result = s;

            string substring = s.Substring(result.IndexOf(@""">") + @""">".Length, result.IndexOf("</a>") );
            
            result = result.Remove(result.IndexOf(@"<a href="""), result.IndexOf("</a>") + "</a>".Length);
            result = result.Replace("</a>"," ");

            return substring+" "+result;//

        }
    }
}
