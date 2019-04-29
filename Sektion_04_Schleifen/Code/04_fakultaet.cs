using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_fakultaet
    {
        public static void Run()
        {
            int result = 1;
            int number = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculation:");
            Console.Write("{0}! = ", number);
            while (number > 2)
            {
                result *= number;
                Console.Write("{0} * ", number);
                number--;
            }
            result *= number;
            Console.Write("{0} = {1}", number, result);
            Console.ReadLine();
        }
    }
}
