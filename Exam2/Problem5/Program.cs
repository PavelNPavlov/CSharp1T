using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] lines = new string[N];
            
            for (int i = 0; i < N; i++)
            {
                lines[i] = Console.ReadLine();
            }
            List<string> allD=new List<string>();
            foreach (var item in lines)
            {
                allD.Add(item[0].ToString());
                allD.Add(item[item.Length - 1].ToString());
            }

            List<string> digits = allD.Distinct().ToList();
            string d = string.Empty;
            foreach (var item in digits)
	        {
                d +=item;
		 
	        }

            var all = GetPermutations(d.ToString());
            List<long> number = new List<long>();

            
            foreach (var item in lines)
            {
                int index0 = item.IndexOf("is before");
                string el1 = item[0].ToString();
                string el2 = item[item.Length - 1].ToString();
                if(index0>0)
                {
                    all=all.Where(o => o.IndexOf(el1) < o.IndexOf(el2));
                }
                else
                {
                    all = all.Where(o => o.IndexOf(el1) > o.IndexOf(el2));

                }
            }
            long resul = long.MaxValue;

            foreach (var item in all)
            {
                if(resul>int.Parse(item))
                {
                    resul = int.Parse(item);
                }
            }
            Console.WriteLine(resul);
            
        }
        //http://stackoverflow.com/questions/774457/combination-generator-in-linq
        
        
        public static IEnumerable<string> GetPermutations(string s)
        {
            if (s.Length > 1)
                return from ch in s
                       from permutation in GetPermutations(s.Remove(s.IndexOf(ch), 1))
                       select string.Format("{0}{1}", ch, permutation);

            else
                return new string[] { s };
        }

        

    }
}
