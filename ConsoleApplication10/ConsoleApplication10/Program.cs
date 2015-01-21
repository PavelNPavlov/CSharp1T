﻿using System;
using System.Collections.Generic;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;

internal class FallingRocks
{

    //    Problem 12.** Falling Rocks

    //Implement the "Falling Rocks" game in the text console.
    //A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    //A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    //Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    //Ensure a constant game speed by Thread.Sleep(150).
    //Implement collision detection and scoring system.

    private struct Playground
    {
        public const int WIDTH = 100;
        public const int HEIGHT = 40;
        public const int PLAYFIELD = 70;
    }

    private struct PlayObject
    {
        public int x, y, moveStep;
        public string look;
        public const int WIDTH = 3;
        public const int HEIGHT = 1;
        public ConsoleColor color;
    }


    private static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    public static void Main()
    {

        Random randomGenerator = new Random();
        int livesCount = 5;
        bool hitted = false;
        double level = 1;
        int points = 0;
        string[] rocksType = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "\u2665" };
        ConsoleColor[] colorNames = { ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.DarkYellow, ConsoleColor.DarkGreen, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.DarkRed };


        Console.BufferHeight = Console.WindowHeight = Playground.HEIGHT;
        Console.BufferWidth = Console.WindowWidth = Playground.WIDTH;
        Console.CursorVisible = false;


        PlayObject userDwarf = new PlayObject();
        userDwarf.x = Playground.PLAYFIELD / 2;
        userDwarf.y = Playground.HEIGHT - PlayObject.HEIGHT;
        userDwarf.moveStep = 2;
        userDwarf.look = "(@)";
        userDwarf.color = ConsoleColor.Yellow;


        List<PlayObject> rocks = new List<PlayObject>();
        List<PlayObject> lives = new List<PlayObject>();

        SoundPlayer sound = new SoundPlayer();
        sound.SoundLocation = (@"..\..\Properties\alpswave.wav");
        sound.PlayLooping();

        while (true)
        {

            string rockCh = rocksType[randomGenerator.Next(0, rocksType.Length)];
            ConsoleColor rockColor = colorNames[randomGenerator.Next(0, colorNames.Length)];
            PlayObject newRock = new PlayObject();
            newRock.color = rockColor;
            newRock.x = randomGenerator.Next(0, Playground.PLAYFIELD);
            newRock.y = 0;
            newRock.look = rockCh;
            rocks.Add(newRock);
            points++;
            if (level > 99)
            {
                level = 100;
            }
            else if (points % 100 == 0)
            {
                level++;
            }

            //Move Dwarf

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo presedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                if (presedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 2 >= 0)
                    {
                        userDwarf.x = userDwarf.x - userDwarf.moveStep;
                    }
                }
                else if (presedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x - 1 < Playground.PLAYFIELD - 2)
                    {
                        userDwarf.x = userDwarf.x + userDwarf.moveStep;

                    }
                }
            }
            //Clear playfield
            Console.Clear();
            //ReDraw playfield

            PrintOnPosition(userDwarf.x, userDwarf.y, userDwarf.look, userDwarf.color);

            if (hitted == true)
            {

                PrintOnPosition(userDwarf.x, userDwarf.y, "XXX", ConsoleColor.Red);
                //sound.Stop();
                SystemSounds.Asterisk.Play();

                if (livesCount <= 0)
                {
                    PrintOnPosition(Playground.PLAYFIELD + 5, 5, "GAME OVER", ConsoleColor.Red);
                    PrintOnPosition(Playground.PLAYFIELD + 5, 7, "Press Enter key to exit", ConsoleColor.Red);
                    PrintOnPosition(Playground.PLAYFIELD + 5, 9, "Win Points :" + points, ConsoleColor.Green);
                    Console.ReadLine();
                    return;
                }
                PrintOnPosition(10, 10, "You loosing a life. Pres Enter Key to continue...", ConsoleColor.Red);
                Console.ReadLine();
                hitted = false;
                rocks.Clear();
                //sound.Play();
            }
            else
            {
                PrintOnPosition(userDwarf.x, userDwarf.y, userDwarf.look, userDwarf.color);
            }

            foreach (PlayObject rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.look, rock.color);
            }

            //Move rocks
            List<PlayObject> movedRocks = new List<PlayObject>();
            for (int i = 0; i < rocks.Count; i++)
            {
                PlayObject oldRock = rocks[i];
                PlayObject nRock = new PlayObject();
                nRock.x = oldRock.x;
                nRock.y = oldRock.y + 1;
                nRock.look = oldRock.look;
                nRock.color = oldRock.color;

                //Check for loosing live

                if (nRock.y == userDwarf.y && nRock.x == userDwarf.x || nRock.y == userDwarf.y && nRock.x == userDwarf.x + 1 || nRock.y == userDwarf.y && nRock.x == userDwarf.x + 2)
                {
                    if (nRock.look == "\u2665")
                    {
                        livesCount++;
                        hitted = false;
                        SystemSounds.Beep.Play();

                    }
                    else
                    {
                        livesCount--;
                        hitted = true;
                    }
                }


                if (nRock.y < Playground.HEIGHT)
                {
                    movedRocks.Add(nRock);
                }
            }
            rocks = movedRocks;

            //Drawning info

            for (int i = 0; i < Playground.HEIGHT; i++)
            {
                PrintOnPosition(Playground.PLAYFIELD + 1, i, "|");
            }
            PrintOnPosition(Playground.PLAYFIELD + 4, 2, "Falling Rocks Game info");
            PrintOnPosition(Playground.PLAYFIELD + 4, 3, "________________________");
            PrintOnPosition(Playground.PLAYFIELD + 5, 5, "Lives: " + livesCount, ConsoleColor.White);
            PrintOnPosition(Playground.PLAYFIELD + 5, 6, "Level: " + level, ConsoleColor.White);
            PrintOnPosition(Playground.PLAYFIELD + 5, 7, "Points: " + points, ConsoleColor.White);


            //Slow down program
            Thread.Sleep((int)(149 - (level * 5)));
        }
    }
}