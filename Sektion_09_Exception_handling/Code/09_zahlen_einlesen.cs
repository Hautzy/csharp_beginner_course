using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_09
{
    class _09_zahlen_einlesen
    {
        public static void Run()
        {
            string input = "";
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    input = Console.ReadLine();
                    number = Convert.ToInt32(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!");
                    string newInput = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] >= '0' && input[i] <= '9')
                        {
                            newInput += input[i];
                        }
                    }
                    number = Convert.ToInt32(newInput);
                }

                Console.WriteLine("number: {0}", number);
                Console.ReadLine();
            }
        }
    }
}
