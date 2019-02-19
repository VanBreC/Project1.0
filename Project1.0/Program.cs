using System;
using System.Collections.Generic;

namespace Project1._0
{
    class NFLDraft
    {
        static void Main(string[] args)
        {
            //Players selected by user
            List<string> SelectedPlayers = new List<string>();

            //Quarterbacks displayed in table
            string[,] QuarterbackDisplay =
            {
                {"    Position\t", "1. The Best", "\t2. 2nd Best", "\t3. 3rd Best", "\t4. 4th Best", "\t5. 5th Best\n_________________________________________________________________________________________________________________________________________"},
                {"1. Quarterback\t", "Dwayne Haskins", "\tKyler Murray", "\tDrew Lock", "\tDaniel Jones", "\tWill Grier"},
                {"\t\t", "(Ohio St.)", "\t(Oklahoma)", "\t(Missouri)", "\t(Duke)", "\t\t(West Virginia)"},
                {"\t\t", "$26,400,100", "\t$20,300,100", "\t$17,420,300", "\t$13,100,145", "\t$10,300,000\n_________________________________________________________________________________________________________________________________________"}
            };

            //Runningbacks displayed in table
            string[,] RunningbackDisplay =
            {
                {"2. Runningback\t", "Josh Jacobs", "\tDamien Harris", "\tDavid Montgomery", "Justice Hill", "\tDevin Singletary"},
                {"\t\t", "(Alabama)\t", "(Alabama)\t", "(Iowa St.)\t", "(Oklahoma St.)", "\t(FAU)   \t"},
                {"\t\t", "$24,500,100", "\t$19,890,200", "\t$18,700,800", "\t$15,000,000", "\t$11,600,400\n_________________________________________________________________________________________________________________________________________"}
            };

            //Wide Recievers displayed in table
            string[,] WideRecieverDisplay =
            {
                {"3. Wide-Reciever", "D.K. Metcalf\t", "A.J. Brown\t", "N'Keal Harry\t", "Marquise Brown\t", "Kelvin Harmon"},
                {"\t\t", "(Ole Miss)\t", "(Ole Miss)\t", "(Arizona St.)\t", "(Oklahoma)\t", "(NC State)"},
                {"\t\t", "$23,400,000", "\t$21,900,300", "\t$19,300,230", "\t$13,400,230", "\t$10,000,000\n_________________________________________________________________________________________________________________________________________"}
            };

            //Deffensive Lineman displayed in table
            string[,] DeffensiveLinemanDisplay =
            {
                {"4. Defensive Lineman", "Nick Bosa", "\tQuinnen Williams", "Ed Oliver", "\tJeffery Simmons", "\tClelin Ferrell"},
                {"\t\t", "(Ohio St.)", "\t(Alabama)", "\t(Houston)", "\t(Miss. State)", "\t(Clemson)"},
                {"\t\t", "$26,200,300", "\t$22,000,000", "\t$16,000,000", "\t$18,000,000", "\t$13,000,000\n_________________________________________________________________________________________________________________________________________"}
            };

            //Deffensive Backs displayed in table
            string[,] DeffensiveBackDisplay =
            {
                {"5. Defensive-Back", "Greedy Williams\t", "Deandre Baker\t", "Byron Murphy\t", "Deionte Thompson", "Amani Oruwariye"},
                {"\t\t", "(LSU)\t\t", "(Georgia)\t", "(Washington)\t", "(Alabama)\t", "(Penn State)"},
                {"\t\t", "$24,000,000", "\t$22,500,249", "\t$20,000,100", "\t$16,000,200", "\t$11,899,999\n_________________________________________________________________________________________________________________________________________"}
            };

            //Tight Ends displayed in table
            string[,] TightEndDisplay =
            {
                {"6. Tight Ends\t", "Noah Fant\t", "Irv Smith\t", "T.J. Hockenson\t", "Kaden Smith\t", "Josh Oliver"},
                {"\t\t", "(Iowa)\t\t", "(Alabama)\t", "(Iowa)\t\t", "(Stanford)\t", "(San Jose St.)"},
                {"\t\t", "$27,800,900", "\t$21,000,800", "\t$17,499,233", "\t$27,900,200", "\t$14,900,333\n_________________________________________________________________________________________________________________________________________"}
            };

            //Line Backers displayed in table
            string[,] LineBackerDisplay =
            {
                {"7. Line-Backer's", "Josh Allen\t", "Devin White\t", "Montez Sweat\t", "Mack Wilson\t", "Devin Bush"},
                {"\t\t", "(Kentucky)\t", "(LSU)\t\t", "(Miss. State)\t", "(Alabama)\t", "(Michigan)"},
                {"\t\t", "$22,900,300", "\t$19,000,590", "\t$18,000,222", "\t$12,999,999", "\t$10,000,100\n_________________________________________________________________________________________________________________________________________"}
            };

            //Offensive Tacklers displayed in table
            string[,] OffensiveTackleDisplay =
            {
                {"8. Offensive Tackles", "Jonah Williams\t", "Greg Little\t", "Cody Ford\t", "Jawaan Taylor\t", "Yodny Cajuste"},
                {"\t\t", "(Alabama)\t", "(Ole Miss)\t", "(Oklahoma)\t", "(Florida)\t", "(West Virginia)"},
                {"\t\t", "$23,000,000", "\t$20,000,000", "\t$19,400,000", "\t$16,200,700", "\t$15,900,000\n_________________________________________________________________________________________________________________________________________"}
            };

            //List of all players that the program will be able to select from based off user input
            string[,] SelectPlayerList =
            {
                {"Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"},
                {"Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"},
                {"D.K. Metcalf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon"},
                {"Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell"},
                {"Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye"},
                {"Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver"},
                {"Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush"},
                {"Jonah Williams", "Greg Little", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste"}
            };

            //List of player costs that the program will use based off of user input
            int[,] Cost = 
            { 
                { 26400100, 20300100, 17420300, 13100145, 10300000 },
                { 24500100, 19890200, 18700800, 15000000, 11600400 },
                { 23400000, 21900300, 19300230, 13400230, 10000000 },
                { 26200300, 22000000, 16000000, 18000000, 13000000 },
                { 24000000, 22500249, 20000100, 16000200, 11899999 },
                { 27800900, 21000800, 17499233, 27900200, 14900333 },
                { 22900300, 19000590, 18000222, 12999999, 10000100 },
                { 23000000, 20000000, 19400000, 16200700, 15900000 }
            };

            //Starting Cash for user
            int Cash = 95000000;

            //Total Cost of players selected
            int totalCost = 0;

            //used to let the program repeat until a correct input is entered
            bool repeat = true;

            //Welcome message
            Console.WriteLine("Welcome To The Team Manager!");

            //loop connected to 'repeat' assigned above
            do
            {
                //assigns key press to continue or end player select loop
                ConsoleKey finished;
                finished = exit();
                int position;
                int rank;
                if (finished == ConsoleKey.Enter)
                {
                    repeat = false;
                    while (finished != ConsoleKey.X)
                    {
                        if (SelectedPlayers.Count == 5 )
                        {
                            Console.WriteLine("Player Limit Reached");
                            
                            break;
                        }

                        Console.Clear();


                        Console.WriteLine("_________________________________________________________________________________________________________________________________________");

                        //Print Player Listing
                        outputTable(QuarterbackDisplay);
                        outputTable(RunningbackDisplay);
                        outputTable(WideRecieverDisplay);
                        outputTable(DeffensiveLinemanDisplay);
                        outputTable(DeffensiveBackDisplay);
                        outputTable(TightEndDisplay);
                        outputTable(LineBackerDisplay);
                        outputTable(OffensiveTackleDisplay);

                        //Display Current Cash Available
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t      Current Cash {0}\n", (Cash - totalCost).ToString("c"));

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
                    Console.WriteLine($"ERROR: Wrong Key Input (The '{finished.ToString()}' Key Was Pressed)");
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
            Console.WriteLine("Press The 'Enter' Key To Continue Or Press 'X' To Exit The Team Manager\n");
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
