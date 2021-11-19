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
            }

            Console.ReadLine();
        }        
    }
}
