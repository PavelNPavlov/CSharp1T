using System;

namespace CardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = 0;

            string[] P1Hand = new string[3];
            string[] P2Hand = new string[3];

            double player1Score = 0;
            double player2Score = 0;

            int gameWon1 = 0;
            int gameWon2 = 0;

            int winner = 0;
            int p1Z = 0;
            int p2Z = 0;

            numberOfGames=int.Parse(Console.ReadLine());
            for(int i=0; i<numberOfGames; i++)
            {
                int Xcount1 = 0;
                int Xcount2 = 0;
                
                int handScore1=0;
                int handScore2=0;


                //input hands

                for(int j=0; j<6; j++)
                {
                    string card = Console.ReadLine();
                    int cardScore = 0;
                    switch(card)
                    {
                        case "2":
                            cardScore=10;
                            break;
                        case "3":
                            cardScore=9;
                            break;
                        case "4":
                            cardScore=8;
                            break;
                        case "5":
                            cardScore=7;
                            break;
                        case "6":
                            cardScore=6;
                            break;
                        case "7":
                            cardScore=5;
                            break;
                        case "8":
                            cardScore=4;
                            break;
                        case "9":
                            cardScore=3;
                            break;
                        case "10":
                            cardScore=2;
                            break;
                        case "A":
                            cardScore=1;
                            break;
                        case "J":
                            cardScore=11;
                            break;
                        case "Q":
                            cardScore=12;
                            break;
                        case "K":
                            cardScore=13;
                            break;
                        case "Z":
                            if(j<3){ p1Z++;}
                            else{p2Z++;}
                            break;
                        case "Y":
                            if (j < 3) { player1Score -=200; }
                            else { player2Score -= 200; }
                            break;
                        case "X":
                            if(j<3){ Xcount1++;}
                            else{Xcount2++;}
                            break;
                        default:
                            break;

                    }//end switch

                    if(j<3)
                    {
                        handScore1 += cardScore;
                       // Console.WriteLine(handScore1);
                        
                    }
                    else
                    {
                        handScore2 += cardScore;
                        //Console.WriteLine(handScore2);
                    }
                }//end of card draw

                //XCard Check

                if(Xcount1>0 && Xcount2==0)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    winner = 1;
                }

                if (Xcount1 == 0 && Xcount2 > 0)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    winner = 1;
                }

                if(Xcount1>0 && Xcount2>0) //
                {
                    player1Score += 50;
                    player2Score += 50;

                    //Handle Z
                    player1Score *= Math.Pow(2, p1Z);
                    player2Score *= Math.Pow(2, p2Z);
                    //Console.WriteLine("{0} {1}", handScore1, player1Score);
                    //Console.WriteLine("{0} {1}", handScore1, player1Score);

                    int multypl1 = (handScore1 > handScore2) ? 1 : 0;
                    int multypl2 = (handScore1 < handScore2) ? 1 : 0;

                    player1Score += handScore1 * multypl1;
                    player2Score += handScore2 * multypl2;
                 
                    gameWon1 += multypl1;
                    gameWon2 += multypl2;
                    
                }

                //No X cases

                if(Xcount1==0&& Xcount2==0)
                {
                
                    //Handle Z
                    player1Score *= Math.Pow(2, p1Z);
                    player2Score *= Math.Pow(2, p2Z);

                    //Console.WriteLine("{0} {1}", handScore1, player1Score);
                    //Console.WriteLine("{0} {1}", handScore1, player1Score);

                    int multypl1 = (handScore1 >handScore2)? 1:0;
                    int multypl2 = (handScore1 < handScore2) ? 1 : 0;

                    player1Score += handScore1 * multypl1;
                    player2Score += handScore2 * multypl2;

                    gameWon1 += multypl1;
                    gameWon2 += multypl2;
                } //end of round


            } //end of game

            if (player1Score > player2Score && winner!=1) 
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + player1Score);
                Console.WriteLine("Games won: " + gameWon1);
            }

            if (player1Score < player2Score && winner != 1)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + player2Score);
                Console.WriteLine("Games won: " + gameWon2);
            }

            if (player1Score == player2Score && winner != 1)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: " + player2Score);
            }

        }
    }
}
