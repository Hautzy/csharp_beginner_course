using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_05
{
    class _05_binaer_konvertierer
    {
        public static void Run()
        {
            int number = 0;
            string binary = "";

            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while(number > 0)
            {
                int rest = number % 2;
                binary = rest + binary;
                number = number / 2;
            }

            Console.WriteLine("\nbinary: {0}", binary);
            Console.ReadLine();
        }
    }
}
