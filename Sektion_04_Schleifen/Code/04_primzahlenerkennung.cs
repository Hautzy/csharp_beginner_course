using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_primzahlenerkennung
    {
        public static void Run()
        {
            int number;
            bool isNotPrime = false;
            
            Console.Write("enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isNotPrime = true;
                    break;
                }
            }
            if (isNotPrime)
            {
                Console.WriteLine("{0} is not a prime", number);
            }
            else
            {
                Console.WriteLine("{0} is a prime", number);
            }
            Console.ReadLine();
        }
    }
}
