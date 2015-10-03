//Dawn Myers
//ITDEV 110 Downtown
//9/30/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InClass6
{
    class InClass6
    {
        static void Main(string[] args)
        {
            int numberOfGames = 1;
            int singleScore = 1;
            int scoreAccumulator = 0;
            double average = 0.0;

            ConsoleSetup();
            DisplayInfo();
            while(singleScore != 0)
            {
                ScoreEntry(ref scoreAccumulator, ref numberOfGames, ref singleScore);
                if (singleScore != 0)
                {
                    average = DisplayAverage(scoreAccumulator, numberOfGames, singleScore);
                    numberOfGames++;
                }
                else if (singleScore == 0 && numberOfGames == 1)
                {
                    Console.WriteLine("Are you trying to break something? :(");
                    Thread.Sleep(500);
                    Console.Clear();
                    numberOfGames--;
                }
                else
                {
                    numberOfGames--;
                }
            }

            Console.WriteLine("Here is your total number of games: " + numberOfGames);
            Thread.Sleep(1000);
            Console.WriteLine("Here is your grand total of scores: " + scoreAccumulator);
            Thread.Sleep(1000);
            Console.WriteLine("Here is your average score: " + average);
            Thread.Sleep(1000);
            Console.Write("Thanks for using the Bowling Average Calculator! Press any key to exit...");
            Console.ReadKey();
        }

        public static void ConsoleSetup()
        {
            Console.Title = "Bowling Average Calculator";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void DisplayInfo()
        {
            Console.Beep();
            Console.WriteLine("Hi! Welcome to the Bowling Average Calculator!");
            Thread.Sleep(1500);
            Console.WriteLine("In this application, you will enter the total score of each game.");
            Thread.Sleep(1500);
            Console.WriteLine("Then we'll calculate the average.");
            Thread.Sleep(1500);
            Console.WriteLine("You will continue to be prompted to enter a score until you enter \"0\".");
            Thread.Sleep(1500);
            Console.WriteLine("Entering \"0\" will produce a final report.");
            Thread.Sleep(1500);
            Console.WriteLine("...");
            Thread.Sleep(1500);
            Console.WriteLine("If there was a game where you scored \"0\"...");
            Thread.Sleep(1500);
            Console.WriteLine("Then you have my deepest condolences.");
            Thread.Sleep(1500);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ScoreEntry( ref int scoreTotal, ref int gamesTotal, ref int score)
        {
            string scoreString = "asdf";

            Console.Write("Please enter your score for game " + gamesTotal + ", or press \"0\" to exit: >> ");
            scoreString = Console.ReadLine();
            score = int.Parse(scoreString);
            scoreTotal = scoreTotal + score;
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static double DisplayAverage(int scoreTotalForAverage, int gamesTotalForAverage, int singleScoreForAverage)
        {
            double scoreAverage = (double)scoreTotalForAverage / (double)gamesTotalForAverage;
            Console.WriteLine("Your score average as of game " + gamesTotalForAverage + " is: " + scoreAverage);
            Thread.Sleep(1000);
            Console.Write("Press any key to enter the next score.");
            Console.ReadKey();
            Console.Clear();
            return scoreAverage;
        }
    }
}
