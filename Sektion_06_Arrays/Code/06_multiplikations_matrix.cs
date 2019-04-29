using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_multiplikations_matrix
    {
        public static void Run()
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", matrix[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
