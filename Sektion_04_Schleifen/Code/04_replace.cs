using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_replace
    {
        public static void Run()
        {
            string text = "";
            string result = "";
            char pattern = ' ';
            char replacement = ' ';

            Console.Write("Text: ");
            text = Console.ReadLine();
            Console.Write("Pattern: ");
            pattern = Console.ReadLine()[0];
            Console.Write("Replacement: ");
            replacement = Console.ReadLine()[0];

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == pattern)
                {
                    result += replacement;
                }
                else
                {
                    result += text[i];
                }
            }

            Console.WriteLine("---");
            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }
    }
}
