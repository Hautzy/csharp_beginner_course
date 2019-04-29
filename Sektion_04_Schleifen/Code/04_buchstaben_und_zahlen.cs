using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_buchstaben_und_zahlen
    {
        public static void Run()
        {
            string text = "";
            int letterCount = 0;
            int digitCount = 0;

            Console.Write("Enter a text: ");
            text = Console.ReadLine();

            int i = 0;
            while(i < text.Length)
            {
                if(text[i] >= 'a' && text[i] <= 'z' || text[i] >= 'A' && text[i] <= 'Z')
                {
                    letterCount++;
                }
                else if(text[i] >= '0' && text[i] <= '9')
                {
                    digitCount++;
                }
                i++;
            }

            Console.WriteLine("letters: {0}", letterCount);
            Console.WriteLine("numbers: {0}", digitCount);

            Console.ReadLine();
        }
    }
}
