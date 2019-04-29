using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_05
{
    class _05_upper_lower
    {
        public static void Run()
        {
            string text = "";
            string upper = "";
            string lower = "";
            string reversed = "";
            const int diff = 'A' - 'a';

            Console.Write("Enter text: ");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    upper += (char)(text[i] + diff);
                }
                else
                {
                    upper += text[i];
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    lower += (char)(text[i] - diff);
                }
                else
                {
                    lower += text[i];
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    reversed += (char)(text[i] - diff);
                }
                else if (text[i] >= 'a' && text[i] <= 'z')
                {
                    reversed += (char)(text[i] + diff);
                }
                else
                {
                    reversed += text[i];
                }
            }

            Console.WriteLine("\nupper text: {0}", upper);
            Console.WriteLine("lower text: {0}", lower);
            Console.WriteLine("reversed text: {0}", reversed);

            Console.ReadLine();
        }
    }
}
