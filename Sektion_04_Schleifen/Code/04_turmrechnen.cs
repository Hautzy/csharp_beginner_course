using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_turmrechnen
    {
        public static void Run()
        {
            int number = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int i = 2;
            while(i < 10)
            {
                Console.WriteLine("{0} * {1}", number, i);
                number *= i;
                i++;
            }
            i--;
            while(i > 1)
            {
                Console.WriteLine("{0} / {1}", number, i);
                number /= i;
                i--;
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
