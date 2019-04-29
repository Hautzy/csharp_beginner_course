using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_statistik
    {
        public static void Run()
        {
            int count = 0;
            double average = 0.0;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.Write("how many numbers: ");
            count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
                if(number > max)
                {
                    max = number;
                }
                if(number < min)
                {
                    min = number;
                }

                average += number;
            }
            average /= count;
            average = Math.Round(average, 2);

            Console.WriteLine("\naverage: {0}", average);
            Console.WriteLine("min: {0}", min);
            Console.WriteLine("max: {0}", max);
            Console.ReadLine();
        }
    }
}
