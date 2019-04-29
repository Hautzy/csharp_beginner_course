using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_07
{
    class _07_tic_tac_toe
    {
        public static void Run()
        {
            Random random = new Random();
            int beginner = random.Next(0, 2);
            int endPlayer;
            int boardIsFull = 0;
            int positionOfPlayer = 0;
            bool end;
            int x = 0;
            int y = 0;
            int[,] board = new int[3, 3];

            DrawBoard(board);
            
            do
            {
                do
                {
                    Console.Write("\n\nSpieler {0}: ", beginner);
                    Console.Write("\nx: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                } while (!SetPosition(x, y, beginner, board) && boardIsFull < 9);

                Console.Clear();
                DrawBoard(board);

                endPlayer = beginner;

                if (beginner == 0)
                {
                    beginner = 1;
                }
                else
                {
                    beginner = 0;
                }
                
                end = WinnerOfTheGame(board);
                boardIsFull++;

            } while (!end && boardIsFull < 9);

            if (end)
            {
                Console.WriteLine("\n\nWinner is player with number {0}", endPlayer);
            }
            else
            {
                Console.WriteLine("\n\nThere is no winner - its a draw");
            }
            
            Console.ReadLine();
        }
        
        public static void DrawBoard(int[,] board)
        {
            Console.WriteLine("TicTacToe");
            Console.WriteLine("=========");

            Console.Write("   ");
            for (int i = 0; i < board.GetLength(1); i++)
            {
                Console.Write("  {0} ", i);
            }

            for (int y = 0; y < board.GetLength(0); y++)
            {
                Console.WriteLine("\n");
                Console.Write(" {0} ", y);
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    if(board[x, y] == -1)
                    {
                        Console.Write("  X ");
                    }
                    else if (board[x, y] == -2)
                    {
                        Console.Write("  O ");
                    }
                    else
                    {
                        Console.Write("  _ ");
                    }
                }
            }
        }
        
        public static bool SetPosition(int x, int y, int player, int[,] board)
        {
            if (x < 0 || x >= board.GetLength(0) || y < 0 || y >= board.GetLength(1))
            {
                return false;
            }
            
            if (SignAlreadySet(x, y, board))
            {
                return false;
            }

            if (player == 0)
            {
                board[x, y] = -1;
            }
            else
            {
                board[x, y] = -2;
            }
                    
            return true;
        }
        
        public static bool SignAlreadySet(int positionOfX, int positionOfY, int[,] board)
        {
            if (board[positionOfX, positionOfY] != 0)
            {
                return true;
            }
            return false;
        }
        
        public static bool WinnerOfTheGame(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckDiagonal(board, -1) || CheckLeftAndRight(board, 1, i, -1) || CheckUpAndDown(board, i, 1, -1))
                {
                    return true;
                }
                if (CheckDiagonal(board, -2) || CheckLeftAndRight(board, 1, i, -2) || CheckUpAndDown(board, i, 1, -2))
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool CheckDiagonal(int[,] board, int playerSymbol)
        {
            if (board[0, 2] == playerSymbol && board[2, 0] == playerSymbol && board[1, 1] == playerSymbol)
            {
                return true;
            }
            if (board[2, 2] == playerSymbol && board[0, 0] == playerSymbol && board[1, 1] == playerSymbol)
            {
                return true;
            }
            return false;
        }
        
        public static bool CheckLeftAndRight(int[,] board, int positionOfX, int positionOfY, int playerSymbol)
        {
            if (board[positionOfX - 1, positionOfY] == playerSymbol && board[positionOfX + 1, positionOfY] == playerSymbol && board[positionOfX, positionOfY] == playerSymbol)
            {
                return true;
            }
            return false;
        }
        
        public static bool CheckUpAndDown(int[,] board, int positionOfX, int positionOfY, int playerSymbol)
        {
            if (board[positionOfX, positionOfY - 1] == playerSymbol && board[positionOfX, positionOfY + 1] == playerSymbol && board[positionOfX, positionOfY] == playerSymbol)
            {
                return true;
            }
            return false;
        }
    }
}
