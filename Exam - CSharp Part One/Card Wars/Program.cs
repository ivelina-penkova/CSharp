using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of games:");
            int n = int.Parse(Console.ReadLine());
            string[] firstPlayer=new String[3];
            string[] secondPlayer=new String[3];
            int fpGames=0;
            int spGames=0;
            int fpScore = 0;
            int spScore = 0;
            int fpGameScore=0;
            int spGameScore=0;
            int outcome = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    firstPlayer[j] = Console.ReadLine();
                }
                for (int j = 0; j < 3; j++)
                {
                    secondPlayer[j] = Console.ReadLine();
                }


                for (int j = 0; j < 3; j++)
                {
                    switch (firstPlayer[j])
                    {
                        case "2": fpGameScore += 10;
                            break;
                        case "3": fpGameScore += 9;
                            break;
                        case "4": fpGameScore += 8;
                            break;
                        case "5": fpGameScore += 7;
                            break;
                        case "6": fpGameScore += 6;
                            break;
                        case "7": fpGameScore += 5;
                            break;
                        case "8": fpGameScore += 4;
                            break;
                        case "9": fpGameScore += 3;
                            break;
                        case "10": fpGameScore += 2;
                            break;
                        case "A": fpGameScore += 1;
                            break;
                        case "J": fpGameScore += 11;
                            break;
                        case "Q": fpGameScore += 12;
                            break;
                        case "K": fpGameScore += 13;
                            break;
                        case "Z": fpGameScore *= 2;
                            break;
                        case "Y": fpGameScore -= 200;
                            break;
                        case "X":
                            {
                                if (outcome == -1)
                                {
                                    outcome = 0;
                                }
                                else if (outcome == 1)
                                {
                                    outcome = 2;
                                }
                            }
                            break;
                        default: Console.WriteLine("Unknown card!");
                            break;
                    }

                    switch (secondPlayer[j])
                    {
                        case "2": spGameScore += 10;
                            break;
                        case "3": spGameScore += 9;
                            break;
                        case "4": spGameScore += 8;
                            break;
                        case "5": spGameScore += 7;
                            break;
                        case "6": spGameScore += 6;
                            break;
                        case "7": spGameScore += 5;
                            break;
                        case "8": spGameScore += 4;
                            break;
                        case "9": spGameScore += 3;
                            break;
                        case "10": spGameScore += 2;
                            break;
                        case "A": spGameScore += 1;
                            break;
                        case "J": spGameScore += 11;
                            break;
                        case "Q": spGameScore += 12;
                            break;
                        case "K": spGameScore += 13;
                            break;
                        case "Z": spGameScore *= 2;
                            break;
                        case "Y": spGameScore -= 200;
                            break;
                        case "X":
                            {
                                if (outcome == -1)
                                {
                                    outcome = 1;
                                }
                                else if (outcome == 0)
                                {
                                    outcome = 2;
                                }
                            }
                            break;
                        default: Console.WriteLine("Unknown card!");
                            break;
                    }
                }

                if(outcome==0)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }

                if (outcome == 1)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    break;
                }

                if(outcome== -1)
                {
                    if (fpGameScore > spGameScore) 
                    {
                        fpScore += fpGameScore;
                        fpGames++;
                    }
                    else if (fpGameScore < spGameScore)
                    {
                        spScore += spGameScore;
                        spGames++;
                    }
                }
                          
                if(outcome==2)
                {
                    fpScore += 50;
                    spScore += 50;
                    outcome = -1;
                }

                fpGameScore = 0;
                spGameScore = 0;
            }

            if (fpScore > spScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", fpScore);
                Console.WriteLine("Games won: {0}",fpGames);
            }

            if (fpScore < spScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", spScore);
                Console.WriteLine("Games won: {0}", spGames);
            }
            
            if(fpScore==spScore && (outcome==-1 || outcome==2))
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}",spScore);
            }
        }
    }
}
