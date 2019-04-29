using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_jüngsten_finden
    {
        public static void Run()
        {
            int age1 = 0;
            int age2 = 0;
            int age3 = 0;

            Console.Write("1.age: ");
            age1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.age: ");
            age2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.age: ");
            age3 = Convert.ToInt32(Console.ReadLine());

            if (age1 <= age2 && age1 <= age3)
            {
                Console.WriteLine("The youngest is {0} years old", age1);
            }
            else if (age2 <= age1 && age2 <= age3)
            {
                Console.WriteLine("The youngest is {0} years old", age2);
            }
            else
            {
                Console.WriteLine("The youngest is {0} years old", age3);
            }
        }
    }
}
