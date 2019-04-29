using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_04
{
    class _04_substring
    {
        public static void Run()
        {
            string text = "";
            string pattern = "";
            int startIndex = -1;

            Console.Write("Text: ");
            text = Console.ReadLine();

            Console.Write("Pattern: ");
            pattern = Console.ReadLine();

            for (int i = 0; i < text.Length - pattern.Length + 1; i++)
            {
                if(text[i] == pattern[0])
                {
                    bool wrongChar = false;
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if(text[i + j] != pattern[j])
                        {
                            wrongChar = true;
                            break;
                        }
                    }
                    if(wrongChar)
                    {
                        startIndex = -1;
                    }
                    else
                    {
                        startIndex = i;
                        break;
                    }
                }
            }
            
            if(startIndex > -1)
            {
                Console.WriteLine("Found pattern at index {0}!", startIndex);
            }
            else
            {
                Console.WriteLine("Not found!");
            }
            Console.ReadLine();
        }
    }
}
