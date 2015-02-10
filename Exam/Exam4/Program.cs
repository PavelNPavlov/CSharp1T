using System;


namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //top
            for(int i=0; i<N;i++)
            {
                Console.Write(":");
            }
            Console.WriteLine();
            //part2
            for (int i = 0; i < N - 2;i++ )
            {
                Console.Write(":");
                for (int j = 0; j < N - 2; j++ )
                {
                    Console.Write(" ");
                }
                Console.Write(":");
                for (int j = 0; j < i; j++ )
                {
                    Console.Write("|");
                }
                Console.Write(":");
                Console.WriteLine();
            }

            //part3

            for (int i = 0; i < N; i++)
            {
                Console.Write(":");
            }

            for (int i = 0; i < N - 2; i++)
            {
                Console.Write("|");
            }
            Console.Write(":");
            Console.WriteLine();
                
            //mid
            for(int i=0; i<N-2;i++)
            {
                //white spaces
                for (int j = 0; j < i + 1; j++ )
                {
                    Console.Write(" ");
                }

                Console.Write(":");
                for (int j = 0; j < N - 2; j++)
                {
                    Console.Write("-");
                }
                Console.Write(":");
                for (int j = 0; j < N-2 -(i + 1); j++)
                {
                    Console.Write("|");
                }
                Console.Write(":");
                Console.WriteLine();

            }

            //bot
            for (int i = 0; i < N - 1;i++ )
            {
                Console.Write(" ");
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(":");
            }
            
        }
    }
}
