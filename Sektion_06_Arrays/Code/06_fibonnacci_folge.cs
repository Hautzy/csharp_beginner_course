using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_fibonnacci_folge
    {
        public static void Run()
        {
            int size = 0;

            Console.Write("How many fib numbers: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] fibonacci = new int[size];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            Console.Write("\n1, 1, ");
            for (int i = 2; i < size; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                Console.Write("{0}, ", fibonacci[i]);
            }
            Console.ReadLine();
        }
    }
}
