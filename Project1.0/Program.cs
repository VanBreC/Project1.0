using System;
using System.Collections.Generic;

namespace Project1._0
{
    class NFLDraft
    {
        static void Main(string[] args)
        {
            List<string> SelectedPlayers = new List<string>();


            string[,] Quarterbacks = {{"\t", "The Best", "\t2nd Best", "\t3rd Best", "\t4th Best", "\t5th Best\n"},
                                    {"Quarterback", "Dwayne Haskins", "\tKyler Murray", "\tDrew Lock", "\tDaniel Jones", "\tWill Grier"},
                                    {"\t", "(Ohio St.)", "\t(Oklahoma)", "\t(Missouri)", "\t(Duke)", "\t\t(West Virginia)"},
                                    {"\t", "$26,400,100", "\t$20,300,100", "\t$17,420,300", "\t$13,100,145", "\t$10,300,000"}
                                };
            string[,] Runningbacks = {
                                    {"\nRunningback", "Josh Jacobs", "\tDamien Harris", "\tDavid Montgomery", "Justice Hill", "\tDevin Singletary"},
                                    {"\t", "(Alabama)\t", "(Alabama)\t", "(Iowa St.)\t", "(Oklahoma St.)", "\t(FAU)   \t"},
                                    {"\t", "$24,500,100", "\t$19,890,200", "\t$18,700,800", "\t$15,000,000", "\t$11,600,400\n"}
                                };
            int[,] Cost = { { 26400100, 20300100, 17420300, 13100145, 10300000 }, { 24500100, 19890200, 18700800, 15000000, 11600400 } };

            int Cash = 95000000;

            outputTable(Quarterbacks);
            outputTable(Runningbacks);

            ConsoleKey finished;
            finished = exit();
            int position;
            int rank;
            Console.WriteLine("Welcome to the team manager");

            while (finished != ConsoleKey.X)
            {

                position = PlayerPos();

                if (position < 1)
                {
                    Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                    position = Convert.ToInt32(Console.ReadLine());
                }
                else
                if (position > 8)
                {
                    Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                    position = Convert.ToInt32(Console.ReadLine());
                }

                rank = PlayerRank();

                if (rank < 1)
                {
                    Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                    rank = Convert.ToInt32(Console.ReadLine());
                }
                else
                if (rank > 8)
                {
                    Console.WriteLine("Invalid entry, please enter a number between 1 and 8");
                    rank = Convert.ToInt32(Console.ReadLine());
                }


            }
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
            ConsoleKey sentinel; //Local

            Console.WriteLine("Press any key to start managing a team, press the x key once you are done to finish");
            return sentinel = Console.ReadKey(true).Key;
        }

        static int PlayerPos()
        {
            int position; //Local
            Console.WriteLine("Please enter the number of the player postion you wish to select from");
            return position = Convert.ToInt32(Console.ReadLine());
        }

        static int PlayerRank()
        {
            int column; //Local
            Console.WriteLine("Please enter the ranking number of the player you wish to add to your team");
            return column = Convert.ToInt32(Console.ReadLine());
        }

    }
}
