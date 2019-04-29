using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_05
{
    class _05_charakter_extractor
    {
        public static void Run()
        {
            string text = "";
            string newNumber = "";
            string newText = "";

            Console.Write("Enter text: ");
            text = Console.ReadLine();
            text = text.ToUpper();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] >= 'A' && text[i] <= 'Z')
                {
                    newText += text[i];
                }
                else if(text[i] >= '0' && text[i] <= '9')
                {
                    newNumber = text[i] + newNumber;
                }
            }

            Console.WriteLine("\nnew number: {0}", newNumber);
            Console.WriteLine("new text: {0}", newText);
            Console.ReadLine();
        }
    }
}
