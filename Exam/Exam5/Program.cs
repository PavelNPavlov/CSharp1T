using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string all30 = "";

            for(int i=0; i<N;i++)
            { 
                string temp="";
                long numb = long.Parse(Console.ReadLine());

                for(int j=0;j<30; j++)
                {
                    long bit = (numb >> j) & 1;
                    temp= bit.ToString() + temp;
                }

                //Console.WriteLine(temp);
                all30 += temp;
            }

            int series1 = 0;
            int series0 = 0;
            int series1max = 0;
            int series0max = 0;
            int last1 = 0;
            int last0 = 0;
            char turn = '0';
            char firstB = all30[all30.Length - 1];
            if(firstB=='1')
            {
                turn = '1';
                series1++;
                series1max = series1;
            }

            else
            {
                turn = '0';
                series0++;
                series0max = series0;
            }

            int count = all30.Length - 2;
            while (true)
            {
                if(all30[count]==turn)
                {
                    if(turn=='1')
                    {
                        series1++;
                        if (series1 >= series1max)
                        {
                            series1max = series1;
                        }
                        if (series0 >= series0max)
                        {
                            series0max = series0;
                        }
                        series0 = 0;
                    }

                    else
                    {
                        series0 ++;
                        if (series0 >= series0max)
                        {
                            series0max = series0;
                        }
                        
                    }
                }


                else
                {

                    if (turn == '1')
                    {
                        if (series1 >= series1max)
                        {
                            series1max = series1;
                        }
                        series1 = 0;
                        series0++;
                        turn = '0';
                    }
                    else
                    {
                        if (series0 >= series0max)
                        {
                            series0max = series0;
                        }
                        series0 = 0;
                        series1 ++;
                        turn = '1';
                    }
                }
                count--;
                if (count < 0) { break; }
            }
 
            /*int limit=all30.Length-1;
            for(int i=0; i<limit;i++)
            {
                char temp = all30[limit -1- i];

                if(all30[limit-1 -i] == turn)
                {
                    if(turn=='1')
                    {
                        series1++;
                        if (series1 >= series1max)
                        {
                            series1max = series1;
                        }
                                               
                    }
                    else
                    {
                        series0++;
                    }
                }

                else
                {

                    if (turn == '1')
                    {
                        if(series1>=series1max)
                        {
                            series1max=series1;
                        }
                        series1=0;
                        turn = '0';
                    }
                    else
                    {
                        if (series0 >= series0max)
                        {
                            series0max = series0;
                        }
                        series0 = 0;
                        turn = '1';
                    }
                }
            }*/

            Console.WriteLine(series1max);
            Console.WriteLine(series0max);
           
            //Console.WriteLine(all30.Length);
        }
    }
}
