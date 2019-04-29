using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_05
{
    class _05_split
    {
        public static void Run()
        {
            string text = "";
            char delimiter = ';';
            int substrings = 1;

            Console.Write("Enter text: ");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == delimiter)
                {
                    substrings++;
                }
            }

            Console.WriteLine("---");
            Console.WriteLine("Substring number: {0}", substrings);
            Console.WriteLine("---");

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == delimiter)
                {
                    Console.WriteLine();
                    continue;
                }
                Console.Write(text[i]);
            }

            Console.ReadLine();
        }
    }
}
