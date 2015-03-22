using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] code = new string[N];
            List<String> code1 = new List<string>();
            for (int i = 0; i < N; i++)
            {
                code1.Add(Console.ReadLine());
            }

            var classes = code1.FindAll(o => o.IndexOf("static") > 0);
            for (int i = 0; i < classes.Count; i++)
            {
                var subString = classes[i].Substring(classes[i].IndexOf("(")+1, (classes[i].IndexOf(")") - classes[i].IndexOf("("))-1);
                var sA = subString.Split(' ');

                for (int j = 0; j < sA.Count(); j++)
                {
                    if (j % 2 != 0)
                    {
                        string s = sA[j ];
                        var sF = code1.FindAll(o => o.IndexOf(s + ".") > 0 && code1.IndexOf(classes[1]) > code1.IndexOf(o));
                        int count = sF.Count;
                        Console.Write(count+" ");

                        string method = code1.Find(o => o.IndexOf(s + ".") > 0);
                        string methodName=method.Substring(method.IndexOf(s + ".")+(s+".").Length,method.IndexOf('('));
                        Console.Write(methodName);
                        Console.WriteLine();
                    }
                }
                
            }
            //var subString = classes[0].Substring(classes[0].IndexOf("(")+1, (classes[0].IndexOf(")") - classes[0].IndexOf("("))-1);
            //var s = subString.Split(' ')[1];

            //var sF = code1.FindAll(o => o.IndexOf(s+".") > 0 && code1.IndexOf(classes[1])>code1.IndexOf(o));
            //int count = sF.Count;
            Console.WriteLine();
        }
    }
}
