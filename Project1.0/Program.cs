using System;
using System.Collections.Generic;

namespace Project1._0
{
    class NFLDraft
    {
        static void Main()
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

            outputTable(Quarterbacks);
            outputTable(Runningbacks);

            bool done = false;
            while (!done)
            {




                //Test loop to print answers
                for (int x = 0; x < 10; ++x)
                {
                    string[] PlayerRow = new string[10];
                    string[] PlayerColumn = new string[10];

                    Console.WriteLine("\nEnter the Position number you want select a player from");
                    PlayerRow[x] = Console.ReadLine();
                    Console.WriteLine("\nEnter the Ranking number of the player you wish to select");
                    PlayerColumn[x] = Console.ReadLine();
                    string Test = new string(PlayerRow[x] + PlayerColumn[x]);

                    bool PlayerSearch = SelectedPlayers.Contains(Test);
                    if (PlayerSearch == false)
                        SelectedPlayers.Add(Test);
                    else
                        Console.WriteLine("You have already selected this player, please select a different player");

                    Console.WriteLine();
                }
                done = true;
                

                
                

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

    }
}
