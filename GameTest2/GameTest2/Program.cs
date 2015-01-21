using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

struct Position
{
    public int row;
    public int col;
    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}//Position of a point;

struct Position2
{
    public int row;
    public int col;
    public int symIndex;
    public Position2(int row, int col,int symIndex)
    {
        this.row = row;
        this.col = col;
        this.symIndex = symIndex;
    }
}//Position of a point;

namespace GameTest2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Start:
            char[] rocks = { '^', '*', '&', '+', '-', ',', '.' };
            int left = -1;
            int right = 1;
            int still = 0;
            int move = 0;
            int points=0;
            Console.BufferHeight = Console.WindowHeight;
            Random rng=new Random();
            List<Position2> obstacles = new List<Position2>()
            {
                new Position2(1, 12,1),
                new Position2(1, 20,2),
                new Position2(1, 7,3),
                new Position2(1, 12,4),//max value 28,79
                new Position2(1, 9,5)
            };
            //int[] wipeRow = new int[5];
            int[] wipe = new int[5];

            //Dwarf
            List<Position> dwarf = new List<Position>()
            {
                new Position(28, 40),
                new Position(28, 41),
                new Position(28, 42),

            };
           
            while (true)
            {   
                //set up wipe for top line
                for (int i = 0; i < 5; i++)
                {
                    if (obstacles[i].row == 1) { wipe[i] = obstacles[i].col; }
                }
                //print rocks
                foreach (Position2 obstacle in obstacles)
                {
                    int color = rng.Next(0, 3);
                    if (obstacle.symIndex == 0) { Console.ForegroundColor = ConsoleColor.Cyan; }
                    if (obstacle.symIndex == 1) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (obstacle.symIndex == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    if (obstacle.symIndex == 3) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (obstacle.symIndex == 4) { Console.ForegroundColor = ConsoleColor.Magenta; }
                    if (obstacle.symIndex == 5) { Console.ForegroundColor = ConsoleColor.DarkBlue; }
                    if (obstacle.symIndex == 6) { Console.ForegroundColor = ConsoleColor.White; }
                    //int trap = rng.Next(0, 1000);
                    Console.SetCursorPosition(obstacle.col, obstacle.row); //pisane na opredelena poziciqta
                    Console.Write(rocks[obstacle.symIndex]);
                }
                //push rocks down
                for (int i=0; i<obstacles.Count; i++)
                {
                    obstacles[i] = new Position2(obstacles[i].row+1,obstacles[i].col,obstacles[i].symIndex);
                }

                //add new rocks
                for(int i=0;i<3;i++)
                {
                    obstacles.Add(new Position2(1, rng.Next(0, 79),rng.Next(0,6)));
                }
                //move

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf[0].col > 0) { move = left; }
                        else move = still;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf[2].col < 79) { move = right; }
                        else move = still;
                    }

                }

                for (int i = 0; i < dwarf.Count; i++)
                {
                   dwarf[i] = new Position(dwarf[i].row, dwarf[i].col+2*move);
                }

                for (int i = 0; i < dwarf.Count; i++)
                {
                   if ( obstacles.Exists(x=> x.col==dwarf[i].col && x.row==28)) {goto GameResult;}
                }

                foreach (Position position in dwarf)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("0");
                }

               
                obstacles.RemoveAll(x => x.row == 28);
                move = still;
                Thread.Sleep(150);
                Console.Clear();
                points++;

            }
            GameResult:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            Console.WriteLine("You have Scored: {0}",(points-28)*100);
            Console.WriteLine("Press Enter to exit or s to restart", (points - 28) * 100);

            string g=Console.ReadLine();
            if (g == "s") { goto Start; }
        }
    }
}
