using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_07
{
    class _07_statistik
    {
        public static void Run()
        {
            int count = 0;
            int number = 0;
            int selection = 0;

            Console.Write("count of elements: ");
            count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}):", i + 1);
                number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            PrintMenu();
            selection = Convert.ToInt32(Console.ReadLine());
            while (selection >= 1 && selection <= 5)
            {
                switch(selection)
                {
                    case 1:
                        SortArray(numbers);
                        PrintArray(numbers);
                        break;
                    case 2:
                        int min = MinNumber(numbers);
                        Console.Write("Min: {0}", min);
                        break;
                    case 3:
                        int max = MaxNumber(numbers);
                        Console.Write("Max: {0}", max);
                        break;
                    case 4:
                        double mean = Mean(numbers);
                        Console.Write("Mean: {0}", mean);
                        break;
                    case 5:
                        double median = Median(numbers);
                        Console.WriteLine("Median: {0}", median);
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                PrintMenu();
                selection = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("------------");
            Console.WriteLine("1) sort array");
            Console.WriteLine("2) smallest number");
            Console.WriteLine("3) biggest number");
            Console.WriteLine("4) mean number");
            Console.WriteLine("5) median");
            Console.Write("> ");
        }

        public static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static int MinNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int MaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static double Mean(int[] arr)
        {
            int mean = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                mean += arr[i];
            }
            return Math.Round((double)mean / arr.Length, 2);
        }

        public static double Median(int[] arr)
        {
            SortArray(arr);
            if(arr.Length % 2 == 0)
            {
                return (double)(arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
            }
            else
            {
                return arr[arr.Length / 2];
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
