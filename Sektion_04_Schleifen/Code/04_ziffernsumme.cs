using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_ziffernsumme
    {
        public static void Run()
        {
            string text = "";
            int notUsedChars = 0;
            int sum = 0;

            Console.Write("Text: ");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] >= '0' && text[i] <= '9')
                {
                    sum += text[i] - '0';
                }
                else
                {
                    notUsedChars++;
                }
            }

            Console.WriteLine("\nSum: {0}", sum);
            Console.WriteLine("not used characters: {0}", notUsedChars);
            Console.ReadLine();
        }
    }
}
