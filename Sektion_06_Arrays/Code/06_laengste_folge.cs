using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_laengste_folge
    {
        public static void Run()
        {
            int maxValues = 20;
            int[] arr = new int[maxValues];

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, maxValues);
            }

            int[] longest = new int[maxValues];
            int longestCnt = 0;

            int[] numbers = new int[maxValues];
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (cnt - 1 >= 0 && numbers[cnt - 1] < arr[i] || cnt <= 0)
                {
                    numbers[cnt] = arr[i];
                    cnt++;
                }
                else
                {
                    if (longestCnt <= cnt)
                    {
                        for (int j = 0; j < cnt; j++)
                        {
                            longest[j] = numbers[j];
                        }
                        longestCnt = cnt;
                    }
                    cnt = 0;
                }
            }

            Console.WriteLine("original:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            Console.WriteLine("longest:");
            for (int i = 0; i < longestCnt; i++)
            {
                Console.Write(longest[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
