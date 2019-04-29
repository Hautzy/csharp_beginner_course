using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_zahlen_sortieren
    {
        public static void Run()
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int temp = 0;

            // input data
            Console.Write("1.number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("3.number:");
            number3 = Convert.ToInt32(Console.ReadLine());
            
            // order numbers
            if (number1 > number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }
            if (number2 > number3)
            {
                temp = number2;
                number2 = number3;
                number3 = temp;
            }
            if (number1 > number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }
            Console.WriteLine("Sorted:");
            Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
            Console.ReadLine();
        }
    }
}
