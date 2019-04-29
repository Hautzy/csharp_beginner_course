using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_schaltjahrbestimmung
    {
        public static void Run()
        {
            int year = 0;

            Console.Write("enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap-year!", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap-year!", year);
            }
        }
    }
}
