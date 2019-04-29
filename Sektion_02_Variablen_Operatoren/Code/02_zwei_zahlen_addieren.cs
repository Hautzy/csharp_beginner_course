using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_02
{
    class _02_zwei_zahlen_addieren
    {
        public static void Run()
        {
            int number1 = 0;
            int number2 = 0;
            int sum = 0;

            Console.Write("Number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
