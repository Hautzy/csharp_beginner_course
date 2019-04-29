using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_character_zaehler
    {
        public static void Run()
        {
            string text = "";
            int[] letters = new int['z' - 'a'];
            int[] digits = new int[9];

            Console.Write("Enter text: ");
            text = Console.ReadLine();
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] >= 'a' && text[i] <= 'z')
                {
                    letters[text[i] - 'a']++;
                } else if(text[i] >= '0' && text[i] <= '9')
                {
                    digits[text[i] - '0']++;
                }
            }

            Console.WriteLine("\nanalysis:");

            Console.WriteLine("\nletters");
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 0)
                {
                    Console.WriteLine("{0} x {1}", (char)('a' + i), letters[i]);
                }
            }

            Console.WriteLine("\ndigits");
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > 0)
                {
                    Console.WriteLine("{0} x {1}", i, digits[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
