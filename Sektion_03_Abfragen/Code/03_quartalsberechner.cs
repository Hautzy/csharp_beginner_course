using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_quartalsberechner
    {
        public static void Run()
        {
            int month = 0;
            
            Console.Write("enter your month of birth: ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month > 0 && month < 4)
            {
                Console.WriteLine("Your birthday is in the 1.quarter!");
            }
            else if (month > 3 && month < 7)
            {
                Console.WriteLine("Your birthday is in the 2.quarter!");
            }
            else if (month > 6 && month < 10)
            {
                Console.WriteLine("Your birthday is in the 3.quarter!");
            }
            else if (month > 9 && month < 13)
            {
                Console.WriteLine("Your birthday is in the 4.quarter!");
            }
            else
            {
                Console.WriteLine("Error, invalid month!");
            }
        }
    }
}
