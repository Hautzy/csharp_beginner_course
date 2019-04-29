using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_07
{
    class _07_game_of_life
    {
        static Random random = new Random();
        const int NUMBERS_X = 60;
        const int NUMBERS_Y = 20;
        public static void Run()
        {
            
            int numberOfCells;

            bool[,] world = new bool[NUMBERS_Y, NUMBERS_X];

            Console.Write("How many cells to set <max: 1200>? ");
            numberOfCells = Convert.ToInt32(Console.ReadLine());

            world = RandomPositionsOfX(world, numberOfCells);

            DrawWorld(world);

            Console.WriteLine();
            Console.WriteLine("Press a key to start!");

            Console.ReadLine();

            while (true)
            {
                world = GenerateNewWorld(world);

                Console.Clear();
                DrawWorld(world);
                Console.ReadLine();
            }
        }
        
        public static bool[,] RandomPositionsOfX(bool[,] world, int numberOfCells)
        {
            int randomX = 0;
            int randomY = 0;

            for (int i = 0; i < numberOfCells; i++)
            {
                do
                {
                    randomX = random.Next(0, NUMBERS_X);
                    randomY = random.Next(0, NUMBERS_Y);

                } while (world[randomY, randomX] == true);

                world[randomY, randomX] = true;

            }
            return world;
        }
        
        public static void DrawWorld(bool[,] oldWorld)
        {
            for (int y = 0; y < oldWorld.GetLength(0); y++)
            {
                for (int x = 0; x < oldWorld.GetLength(1); x++)
                {
                    if (oldWorld[y, x] == true)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }

        public static bool[,] GenerateNewWorld(bool[,] oldWorld)
        {
            bool[,] newWorld = new bool[oldWorld.GetLength(0), oldWorld.GetLength(1)];

            for (int y = 0; y < oldWorld.GetLength(0); y++)
            {

                for (int x = 0; x < oldWorld.GetLength(1); x++)
                {
                    int count = 0;
                    int height = oldWorld.GetLength(0);
                    int length = oldWorld.GetLength(1);

                    if ((y - 1 >= 0) && (x - 1 >= 0) && oldWorld[y - 1, x - 1])
                    {
                        count++;
                    }
                    if ((y - 1 >= 0) && oldWorld[y - 1, x])
                    {
                        count++;
                    }
                    if ((y - 1 >= 0) && (x + 1 < length) && oldWorld[y - 1, x + 1])
                    {
                        count++;
                    }
                    if ((x - 1 >= 0) && oldWorld[y, x - 1])
                    {
                        count++;
                    }
                    if ((x + 1 < length) && oldWorld[y, x + 1])
                    {
                        count++;
                    }
                    if ((y + 1 < height) && (x - 1 >= 0) && oldWorld[y + 1, x - 1])
                    {
                        count++;
                    }
                    if ((y + 1 < height) && oldWorld[y + 1, x])
                    {
                        count++;
                    }
                    if ((y + 1 < height) && (x + 1 < length) && oldWorld[y + 1, x + 1])
                    {
                        count++;
                    }

                    if ((count == 2 || count == 3) && oldWorld[y, x])   //Zelle überlebt
                    {
                        newWorld[y, x] = true;
                    }
                    else if (count < 2 || count > 3)   //Zelle stirbt
                    {
                        newWorld[y, x] = false;
                    }
                    else if (count == 3 && !oldWorld[y, x])   //Zelle wird wiederbelebt
                    {
                        newWorld[y, x] = true;
                    }
                }
            }
            return newWorld;
        }
    }
}
