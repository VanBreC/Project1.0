using System;
using System.Collections.Generic;

namespace Project1._0
{
    class NFLDraft
    {
        static void Main(string[] args)
        {
            List<string> SelectedPlayers = new List<string>();


            string[,] QuarterbacksDisplay =
            {
                {"\t", "The Best", "\t2nd Best", "\t3rd Best", "\t4th Best", "\t5th Best\n"},
                {"Quarterback", "Dwayne Haskins", "\tKyler Murray", "\tDrew Lock", "\tDaniel Jones", "\tWill Grier"},
                {"\t", "(Ohio St.)", "\t(Oklahoma)", "\t(Missouri)", "\t(Duke)", "\t\t(West Virginia)"},
                {"\t", "$26,400,100", "\t$20,300,100", "\t$17,420,300", "\t$13,100,145", "\t$10,300,000"}
            };


            string[,] RunningbacksDisplay =
            {
                {"\nRunningback", "Josh Jacobs", "\tDamien Harris", "\tDavid Montgomery", "Justice Hill", "\tDevin Singletary"},
                {"\t", "(Alabama)\t", "(Alabama)\t", "(Iowa St.)\t", "(Oklahoma St.)", "\t(FAU)   \t"},
                {"\t", "$24,500,100", "\t$19,890,200", "\t$18,700,800", "\t$15,000,000", "\t$11,600,400\n"}
            };


            string[,] SelectPlayerList =
            {
                {"Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"},
                {"Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"}
            };


            int[,] Cost = { { 26400100, 20300100, 17420300, 13100145, 10300000 }, { 24500100, 19890200, 18700800, 15000000, 11600400 } };


            int Cash = 95000000;


            int totalCost = 0;
            bool repeat = true;
            Console.WriteLine("Welcome To The Team Manager!");
            do
            {
                ConsoleKey finished;
                finished = exit();
                int position;
                int rank;
                if (finished == ConsoleKey.Enter)
                {
                    repeat = false;
                    while (finished != ConsoleKey.X)
                    {

                        Console.Clear();

                        //Print Player Listing
                        outputTable(QuarterbacksDisplay);
                        outputTable(RunningbacksDisplay);

                        //Display Current Cash Available
                        Console.WriteLine("Current Cash {0}\n", (Cash - totalCost).ToString("c"));

                        //Row Selection
                        position = PlayerPos();

                        //Column Selection
                        rank = PlayerRank();

                        //Take And Check The Player Name And Cost To Make Sure Your Cash Doesnt Go Negative
                        //And That The Player Hasnt Already Been Selected
                        PriceAndPlayerCheck(SelectPlayerList, Cost, ref totalCost, position, rank, ref Cash, ref SelectedPlayers);

                        finished = exit();

                    }
                    Console.WriteLine("\nEnding Program\nThank You For Creating Your Team");

                }
                else if (finished == ConsoleKey.X)
                {
                    Console.WriteLine("\nEnding Program");
                    repeat = false;
                }
                else if ((finished != ConsoleKey.Enter) || (finished != ConsoleKey.X))
                {
                    Console.WriteLine("ERROR: Wrong Key Input");
                }
            }
            while (repeat == true);

        }







        static void outputTable(string[,] prod)
        {

            for (var i = 0; i < prod.GetLength(0); i++)
            {

                for (var x = 0; x < prod.GetLength(1); x++)
                {
                    Console.Write($"{prod[i, x]}\t");
                }
                Console.WriteLine("");
            }

        }

        static ConsoleKey exit()
        {
            Console.WriteLine("Press The 'Enter' Key To Continue Or Press 'Shift + X' To Finish\n");
            ConsoleKey sentinel;
            sentinel = Console.ReadKey().Key;
            Console.Clear();
            return sentinel;
        }

        static int PlayerPos()
        {
            int position; //Local
            Console.WriteLine("Please enter the position number you wish to select from");
            position = Convert.ToInt32(Console.ReadLine()) - 1;
            if (position < 0)
            {
                Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                PlayerPos();
            }
            else if (position > 7)
            {
                Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                PlayerPos();
            }
            else{}

            return position;
        }

        static int PlayerRank()
        {
            int rank; //Local
            Console.WriteLine("\nPlease enter the ranking number of the player you wish to add to your team");
            rank = Convert.ToInt32(Console.ReadLine()) - 1;
            
            if (rank < 0)
            {
                Console.WriteLine("Invalid entry, please enter a number between 1 and 5");
                PlayerRank();
            }
            else if (rank > 4)
            {
                Console.WriteLine("Invalid entry, please enter a number between 1 and 5");
                PlayerRank();
            }
            else { }

            return rank;
        }

        static void PriceAndPlayerCheck(string[,] player, int[,] price, ref int total, int position, int rank, ref int Cash, ref List<string> AddPlayer)
        {

            if ((Cash - (total + price[position, rank])) < 0)
            {
                Console.WriteLine("ERROR: Cash Will Reach Below Zero, This Player Cannot Be Selected");
                total += 0;
            }
            else if (AddPlayer.Contains(player[position, rank]) == true)
            {
                Console.WriteLine("\n{0} Has Already Been Added To Your Team", player[position, rank]);
            }
            else
            {
                Console.WriteLine($"\nYou have selected {player[position, rank]} for {price[position, rank].ToString("c")}");
                total += price[position, rank];
                AddPlayer.Add(player[position, rank]);
            }
            
        }

    }
}
