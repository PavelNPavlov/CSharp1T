using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input

            int symbolsCount = int.Parse(Console.ReadLine());
            List<string> symbols = new List<string>();

            for (int i = 0; i < symbolsCount; i++)
            {
                symbols.Add(Console.ReadLine());
            }

            var repetionCount = symbols.GroupBy(x => x)
                .Select(g => g.Count())
                .ToList();

            var symbolU = symbols.Distinct()
                .ToList();

            List<Symbol> text = new List<Symbol>();

            for (int i = 0; i < repetionCount.Count; i++)
            {
                text.Add(new Symbol(repetionCount[i], symbolU[i]));
            }
            Console.WriteLine(CombinationCount(text,symbolsCount));


        }

        static int CombinationCount(List<Symbol> list, int size)
        {
            List<Symbol> inner = new List<Symbol>();
            int counter=0;
            for (int i = 0; i < size; i++)
            {
                list.CopyTo(inner);
                Symbol last = inner[i];
                int branch = 1;
                for (int j = 0; j < size-1; j++)
                {
                    RSymbol temp = GetCombinationStep(inner, last);
                    if(temp.index>=0)
                    {
                        last = list[temp.index];
                        branch *=temp.counter;
                    }
                    else
                    {
                        break;
                    }
                }
                counter += branch;
            }
            
            return counter;
        }

        static RSymbol GetCombinationStep(List<Symbol> list, Symbol a)
        {
            int counter = 0;
            int index=-1;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].symbol!=a.symbol && list[i].counter>=1)
                {
                    counter++;
                    list[i] = new Symbol(list[i].counter - 1,list[i].symbol);
                    index=i;
                    
                }
            }

            return new RSymbol(counter, index);
        }

       
        struct Symbol
        {
            public int counter;
            public string symbol;


            public Symbol(int n, string s)
            {
                counter = n;
                symbol = s;
            }
        }

        struct RSymbol
        {
            public int counter;
            public int index;

            public RSymbol(int n, int s)
            {
                counter = n;
                index = s;
            }
        }
       
    }
}
