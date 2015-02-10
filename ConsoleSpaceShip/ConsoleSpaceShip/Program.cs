using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;


namespace ConsoleSpaceShip
{
    public class Alien
    {
        public int xpos;
        public int ypos;
        public int lives;
        public int reloadTime;
        public int reloadTimer;

        public Alien()
        {
            xpos = 0;
            ypos = 0;
            lives = 0;
        }

        public Alien(int x,int y, int l, int r)
        {
            xpos =x;
            ypos =y;
            lives = l;
            Random rng= new Random();
            reloadTimer = r;
            reloadTime = rng.Next(0, r);
        }
        public void Print()
        {
            Console.SetCursorPosition(xpos, ypos);
            Console.Write("#");
        }

        public void Hit(Projectile x)
        {
            if(x.xpos==this.xpos&&x.ypos==this.ypos)
            {
                this.lives = this.lives - 1;
            }
        }

        public int Hit_All(List<Projectile> j)
        {
            if (j.Exists(x => x.xpos == this.xpos && x.ypos == this.ypos && x.direction==-1) && lives==1)
            {
                lives--;
                int index = j.FindIndex(x => x.xpos == this.xpos && x.ypos == this.ypos);
                Console.SetCursorPosition(this.xpos, this.ypos);
                Console.Write(" ");
                return index;
            }
            return -1;
        }

        public Projectile Fire()
        {
            if(this.reloadTime==this.reloadTimer)
            {
                return new Projectile(xpos, ypos+1, 1);
            }
            else
            {
                return new Projectile(-1, -1, 1);
            }
        }

        public void ProgressTime()
        {
            if (this.reloadTime > this.reloadTimer) { this.reloadTime = 0; }
            this.reloadTime++;
        }
    }

    public class Projectile
    {
        public int xpos;
        public int ypos;
        public int direction;
        //public int reload;

        public Projectile()
        {
            xpos = 0;
            ypos = 0;
            direction = 1;
        }

        public Projectile(int x, int y, int d)
        {
            xpos = x;
            ypos = y;
            direction = d;
        }
        public void Print()
        {
                Console.SetCursorPosition(xpos, ypos);
                Console.Write("o");
        }


        public void PrintMissAlien(List<Alien> a)
        {
            if(a.Exists(x=> x.xpos==this.xpos && x.ypos==this.ypos)==false)
            {
                Console.SetCursorPosition(xpos, ypos);
                if (this.direction == 1) { Console.Write("o"); }
                if (this.direction == -1) { Console.Write("+"); }
            }
        }

        public void TimeProgress()
        {
            ypos = this.ypos + this.direction;
        }
    }

    public class Hero
    {
        public int xpos;
        public int ypos;
        public int lives;

        public Hero()
        {
            this.xpos = 18;
            this.ypos = 20;
            this.lives = 3;
        }

        public void Print()
        {
            Console.SetCursorPosition(xpos, ypos);
            if (lives == 3) { Console.ForegroundColor = ConsoleColor.Green; }
            if (lives == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
            if (lives == 1) { Console.ForegroundColor = ConsoleColor.DarkRed; }
            Console.Write("@");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Move(int move)
        {
            if (move == 1) { ypos=ypos-1; }
            if (move == -1) { ypos=ypos+1; }
            if (move == 2) { xpos =xpos -1*3; }
            if (move == -2) { xpos =xpos +1*3; }
        }

        public Projectile Fire()
        {
            return new Projectile(xpos, ypos - 1, -1);
        }

        public void Hit (List<Projectile> j)
        {
            if (j.Exists(x => x.xpos == this.xpos && x.ypos == this.ypos && x.direction == 1) )
            {
                lives--;
            }
        }
    }

    class ConsoleGame
    {
        static int Main()
        {
        Beging:

            Console.WriteLine("Aliens have attack the plante Earth");
            Console.WriteLine("Their Fleet is position in high Earth Orbit");
            Console.WriteLine("You are the pilot of prototype craft that we believe is the key for victory");
            Console.WriteLine("Good Hunting Captain!");

            Console.Write("Chose Difficulty(1-8): ");
            //lines of aliens
            int numberLines=int.Parse(Console.ReadLine());
            //hero creation
            Hero you = new Hero();
            //console setup
            Console.BufferHeight = Console.WindowHeight = 25;
            Console.BufferWidth = Console.WindowWidth =80;
            //creat swarm
            List<Alien> swarm = new List<Alien>();
            Random rng= new Random();
            //Line Wiper create
            string wipe="";
            for(int h=0; h<Console.BufferWidth; h++)
            {
                wipe=wipe+" ";
            }
            //Aliens create
            for(int j=0; j<numberLines; j++)
            {
                for(int i=0; i<(Console.BufferWidth-10)/3; i++)
                {
                    swarm.Add(new Alien (i*3,j,1,rng.Next(20,250)));
                }
            }
            int score=swarm.Count;
            //Aliens print
            foreach (Alien a in swarm)
            {
                a.Print();
            }
            //Projectiles created
            List<Projectile> bullets= new List<Projectile>();
            int count = 0;
            Console.SetCursorPosition(Console.BufferWidth - 10, 2);
            Console.Write("Lives: {0}/3", you.lives);
            Runing:
            while(true)
            {

                //Wipe fire lines
                for (int k = numberLines; k < Console.BufferHeight-1;k++ )
                {
                    Console.SetCursorPosition(0, k);
                    Console.Write(wipe);
                }
                //remove bullets out of bounds
                bullets.RemoveAll(x => x.xpos == Console.BufferHeight);
                
                //move hero and fire
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow && you.xpos >= 3)
                    {
                        you.Move(2);
                    }
                    if (userInput.Key == ConsoleKey.RightArrow && you.xpos<=Console.BufferWidth-10-3)
                    {
                        you.Move(-2);
                    }
                    if (userInput.Key == ConsoleKey.UpArrow && you.ypos>=5)
                    {
                        you.Move(1);
                    }
                    if (userInput.Key == ConsoleKey.DownArrow && you.ypos < Console.BufferHeight-2)
                    {
                        you.Move(-1);
                    }
                    if (userInput.Key == ConsoleKey.Spacebar)
                    {
                        bullets.Add(you.Fire());
                    }
                }
                //Print Hero
                int templ = you.lives;
                you.Hit(bullets);
                if (templ > you.lives)
                {
                    Console.SetCursorPosition(Console.BufferWidth - 10, 2);
                    Console.Write("Lives: {0}/3", you.lives);
                }
                if (you.lives == 0) { goto GameOver; }
                you.Print();
                //Alien time progression
                foreach (Alien a in swarm)
                {
                    a.ProgressTime();
                    bullets.Add(a.Fire());
                    //a.Hit_All(bullet);
                }
                //Get rid of not fireed bulltes
                bullets.RemoveAll(x => x.xpos == -1);
                //Print bullets
                foreach(Projectile b in bullets)
                {
                    b.PrintMissAlien(swarm);
                }
                //Time progress bullets
                foreach (Projectile b in bullets)
                {
                    b.TimeProgress();
                }

                foreach (Alien a in swarm)
                {
                    int temp= a.Hit_All(bullets);
                    if (temp > -1) { bullets.RemoveAt(temp); }
                }

                for (int kk = 0; kk < numberLines; kk++ )
                {
                    for(int kkk=0; kkk< Console.BufferWidth-10; kkk++)
                    {
                        if( swarm.Exists(x=> x.xpos==kkk && x.ypos==kk)==false)
                        {
                            Console.SetCursorPosition(kkk, kk);
                            Console.Write(" ");
                        }
                    }
                }
                //Get rid of bullets out of bounds
                bullets.RemoveAll(x => x.ypos == Console.BufferHeight - 1);
                //Get rid of bullets out of bounds
                bullets.RemoveAll(x => x.ypos == 0);
                //Get rid of dead aliens
                swarm.RemoveAll(x => x.lives == 0);
                count++;

                Thread.Sleep(100);
                if (swarm.Count == 0) { goto Win; }
            }
            
            GameOver:
            Console.SetCursorPosition(10,20);
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Game Over");
            Console.SetCursorPosition(11,20);
            Console.Write("You have scored: {0} points\n", (score-swarm.Count)*10);
            goto End;

            Win:

            Console.SetCursorPosition(10, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You have saved the planet\n");
            End:
            return 0;
            
            //Console.WriteLine(bullet.Count);
        }
    }
}
