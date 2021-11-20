using System;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            int player2 = 0;
            int increment = 4;
            int winScore = 42;

            Console.WriteLine("Match started !!\n");
            Console.WriteLine(ShowRecords(player1, player2));

            while (true)
            {
                Console.WriteLine($"[1] Push (1) to add {increment} point to player 1\n[2] Push (2) to add {increment} point to player 2\n");
                string opt = Console.ReadLine();
                Console.Clear();

                if (opt.Equals("1"))
                    player1 += increment;
                else if (opt.Equals("2"))
                    player2 += increment;
                else
                    Console.WriteLine("Error:> Invalid option try again");

                Console.WriteLine(ShowRecords(player1, player2));

                if (player1 >= winScore || player2 >= winScore)
                {
                    Console.Clear();
                    Console.WriteLine(ShowRecords(player1, player2));
                    break;
                }
            }

            Console.ReadLine();
        }

        private static string ShowRecords(int recordPlayer1, int recordPlayer2)
        {
            string specialMessage = ShowSpecialMessage(recordPlayer1, recordPlayer2);
            if (!string.IsNullOrEmpty(specialMessage)) return specialMessage;
            return $"Score:> Player 1 : ({recordPlayer1} Points) - Player 2 : ({recordPlayer2} Points)\n";
        }

        private static string ShowSpecialMessage(int recordPlayer1, int recordPlayer2)
        {
            if (recordPlayer1 == 0 && recordPlayer2 == 0) return "PlayerOne 0 PlayerTwo 0\n";
            else if (recordPlayer1 == 30 && recordPlayer2 == 15) return "PlayerOne 30 PlayerTwo 15\n";
            else if (recordPlayer1 == 40 && recordPlayer2 == 40) return "Deuce\n";
            else if (recordPlayer1 == 41 && recordPlayer2 == 40) return "Advantage PlayerOne\n";
            else if (recordPlayer1 == 40 && recordPlayer2 == 41) return "Advantage PlayerTwo\n";
            else if (recordPlayer1 >= 42) return "PlayerOne wins\n";
            else if (recordPlayer2 >= 42) return "PlayerTwo wins\n";
            else return string.Empty;
        }
    }
}
