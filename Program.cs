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

                
                if (player1 >= winScore || player2 >= winScore)
                {
                    Console.Clear();
                    break;
                }
            }

            Console.ReadLine();
        }        
    }
}
