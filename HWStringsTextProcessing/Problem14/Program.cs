using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic=new Dictionary<string,string>();

            PopulateDictionary(dic);

            string input = Console.ReadLine();

            Console.WriteLine(dic.First(o => o.Key==input).Value);
        }

        static void PopulateDictionary(Dictionary<string,string> dic)
        {
            dic.Add(".NET", "platform for applications from Microsoft");
            dic.Add("CLR", "managed execution environment for .NET");
            dic.Add("namespace", "hierarchical organization of classes");
        }
    }
}
