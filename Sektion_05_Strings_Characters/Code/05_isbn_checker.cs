using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_05
{
    class _05_isbn_checker
    {
        public static void Run()
        {
            string isbn = "";
            bool isValid = true;

            Console.Write("Isbn number: ");
            isbn = Console.ReadLine();

            isbn = isbn.Replace("-", "");

            if (isbn.Length == 10)
            {
                int weight = 10;
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    var ch = isbn[i];
                    int number;
                    if (ch >= '0' && ch <= '9')
                    {
                        number = ch - '0';
                    }
                    else
                    {
                        if (i != 9)
                        {
                            isValid = false;
                            break;
                        }
                        if (ch == 'x' || ch == 'X')
                        {
                            number = 10;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    sum += number * weight;
                    weight--;
                }
                if (sum % 11 != 0)
                {
                    isValid = false;
                }
                isValid = (sum % 11) == 0;
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("\nisbn number is valid!");
            }
            else
            {
                Console.WriteLine("\nisbn number is not valid");
            }
            Console.ReadLine();
        }
    }
}
