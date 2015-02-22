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
    public Position2(int row, int col, int symIndex)
    {
        this.row = row;
        this.col = col;
        this.symIndex = symIndex;
    }
}//Position of a rock;

namespace GameTest2
{
    class Falling_Rocks
    {

        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Choose difficulty level 1-5");
            int level = 7 - int.Parse(Console.ReadLine());
            char[] rocks = { '^', '*', '&', '+', '-', '.', '.' };
            int left = -1;
            int right = 1;
            int still = 0;
            int move = 0;
            int points = 10;
            int skipLine=1;
            int numberPerLine = 1;
            int lives = 3;
            Console.BufferHeight = Console.WindowHeight;
            Random rng = new Random();
            List<Position2> obstacles = new List<Position2>()
            {
                new Position2(1, 6,1),
                new Position2(1, 10,2),
                new Position2(1, 7,3),
                new Position2(1, 6,4),//max value 28,79
                new Position2(1, 9,5)
            };
            //int[] wipeRow = new int[5];
            int[] wipe = new int[numberPerLine];

            //Dwarf
            List<Position> dwarf = new List<Position>()
            {
                new Position(28, 20),
                new Position(28, 21),
                new Position(28, 22),

            };

           // List<Position> drill = new List<Position>();  //Drill intilizi

            while (true)
            {
                Console.Title = "Dwarf";
                Console.SetCursorPosition(50, 1);
                Console.Write("Help me get to Princes Pretty");
                Console.SetCursorPosition(50, 5);
                Console.Write("Lives: {0}/3", lives);
                Console.SetCursorPosition(50, 6);
                Console.Write("Points to princes: {0}/300", points);
                //set up wipe for top line
                for (int i = 0; i < numberPerLine; i++)
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
                for (int i = 0; i < obstacles.Count; i++)
                {
                    obstacles[i] = new Position2(obstacles[i].row + 1, obstacles[i].col, obstacles[i].symIndex);
                }

               /* foreach (Position obstacle in drill)
                {
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.SetCursorPosition(obstacle.col, obstacle.row); //pisane na opredelena poziciqta
                    Console.Write("~");
                } */ //print drill
                //move missile
               /* if (drill.Count > 0)
                {
                    for (int i = 0; i < drill.Count; i++)
                    {
                        drill[i] = new Position(drill[i].row - 1, drill[i].col);
                    }
                }
                */
                //add new rocks


                 for (int i = 0; i < numberPerLine; i++)
                 {
                     obstacles.Add(new Position2(1, rng.Next(0, 40), rng.Next(0, 6)));
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
                        if (dwarf[2].col < 40) { move = right; }
                        else move = still;
                    }

                   /* if (userInput.Key == ConsoleKey.Spacebar && drill.Count<5)
                    {
                        drill.Add(new Position (dwarf[1].row-1,dwarf[1].col));
                    }*/ //add drills

                }

                for (int i = 0; i < dwarf.Count; i++)
                {
                    dwarf[i] = new Position(dwarf[i].row, dwarf[i].col + 2*move);
                }
                //drill hit deteckt
                /*for (int i = 0; i < drill.Count; i++)
                {
                     obstacles.RemoveAll(x => x.row == drill[i].row && x.col==drill[i].col);
                }*/


                //Hit Detect
                for (int i = 0; i < dwarf.Count; i++)
                {
                    if (obstacles.Exists(x => x.col == dwarf[i].col && x.row == 28)) 
                    { 
                        lives--;
                        if (lives == 0) { goto GameResult; } 
                    }
                }

                foreach (Position position in dwarf)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    if (lives == 3) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (lives == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    if (lives == 1) { Console.ForegroundColor = ConsoleColor.Red; }
                    Console.Write("0");
                }


                obstacles.RemoveAll(x => x.row == 28);
                //drill.RemoveAll(x => x.row == 0);
                move = still;
                skipLine++;
                Thread.Sleep(level*50);
                Console.Clear();
                points--;
                if(points==0){goto Win;}

            }
        GameResult:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            //Console.WriteLine("You have Scored: {0}", (points - 28) * 100);
            Console.WriteLine("Press Enter to exit or s to restart", (points - 28) * 100);
            goto End;
        Win:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I found the princess!!!");
            Console.WriteLine("          WWWWW           ");
            Console.WriteLine("         ((. .))          ");
            Console.WriteLine("        ))) - (((         ");
            Console.WriteLine("       ((((-...-)))        ");
            Console.WriteLine("       ))))\\  /(((        ");
            Console.WriteLine("       /    \\/    \\       ");
            Console.WriteLine("      / /\\      /\\ \\      ");
            Console.WriteLine("     / /  \\    /  \\ \\     ");
            Console.WriteLine("    @@@@  / \\/ \\  @@@@    ");
            Console.WriteLine("    (v   /      \\   v)    ");
            Console.WriteLine("        @@@@@@@@@@        ");
            Console.WriteLine("       /          \\       ");
            Console.WriteLine("      /            \\      ");
            Console.WriteLine("     @@@@@@@@@@@@@@@@     ");
            Console.WriteLine("    /                \\    ");
            Console.WriteLine("   /                  \\   ");
            Console.WriteLine("  @@@@@@@@@@@@@@@@@@@@@@  ");
            Console.WriteLine("  /                    \\  ");
            Console.WriteLine(" @@@@@@@@@@@@@@@@@@@@@@@@ ");
            Console.WriteLine("          v  v            ");
        End:
            string g = Console.ReadLine();
            if (g == "s") { goto Start; }
        }
    }
}
