using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_zahlen_sortieren
    {
        public static void Run()
        {
            int playerScore = 0;

            Console.Write("Player score: ");
            playerScore = Convert.ToInt32(Console.ReadLine());

            if(playerScore > 20)
            {
                Console.WriteLine("Player has won the game!");
            } 
            else
            {
                Console.WriteLine("Nothing happened yet");
            }
        }
    }
}
