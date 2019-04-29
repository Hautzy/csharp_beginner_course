using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_string_rueckwaerts
    {
        public static void Run()
        {
            string text = "";
            int blankCount = 0;

            Console.Write("Enter a text: ");
            text = Console.ReadLine();

            Console.Write("reversed: ");
            int i = text.Length - 1;
            while(i >= 0)
            {
                if(text[i] == ' ')
                {
                    blankCount++;
                }
                Console.Write(text[i]);
                i--;
            }
            Console.WriteLine("\nNumber of blanks: {0}", blankCount);
            Console.ReadLine();
        }
    }
}
