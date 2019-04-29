using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_schachbrett
    {
        public static void Run()
        {
            int[,] matrix = new int[10, 10];

            string input = "";

            do
            {
                Console.Write("Y: ");
                int posY = Convert.ToInt32(Console.ReadLine().ToUpper()[0] - 'A');
                Console.Write("X: ");
                int posX = Convert.ToInt32(Console.ReadLine()) - 1;

                matrix[posY, posX] = 1;

                // Print field
                Console.WriteLine();
                Console.Write("   ");
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write("  {0,-2}", x+1);
                }
                Console.WriteLine();
                Console.Write("   ");
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    Console.Write(" {0} | ", (char) ('A' + y));
                    for (int x = 0; x < matrix.GetLength(1); x++)
                    {
                        if(matrix[y, x] == 0)
                        {
                            Console.Write("  | ");
                        }
                        else
                        {
                            Console.Write("X | ");
                        }
                    }
                    Console.WriteLine();
                    Console.Write("   ");
                    for (int x = 0; x < matrix.GetLength(1); x++)
                    {
                        Console.Write("+---");
                    }
                    Console.WriteLine("+");
                }

                Console.WriteLine();
                Console.WriteLine("Go on (y/n)?");
                input = Console.ReadLine();
                Console.Clear();
            } while (input != "n");

            Console.WriteLine("stopped...");
            Console.ReadLine();
        }
    }
}
