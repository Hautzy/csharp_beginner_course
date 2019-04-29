using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_08
{
    class _08_wetterstation
    {
        public struct WeatherStation
        {
            public int id;
            public double mean;
            public int max;
            public int min;
            public int[] measurements;
        }

        const int MAX_MEASUREMENTS = 24;
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 30;

        public static void Run()
        {
            int count = 0;
            string input = "";

            Console.Write("Number of stations: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            WeatherStation[] stations = new WeatherStation[count];

            for (int i = 0; i < stations.Length; i++)
            {
                stations[i] = new WeatherStation();
                stations[i].id = i;
            }

            do
            {
                for (int i = 0; i < stations.Length; i++)
                {
                    stations[i] = GenerateValues(stations[i]);
                }
                Sort(stations);
                PrintData(stations);
                input = Console.ReadLine();
                Console.Clear();
            } while (input != "X" && input != "x");
            Console.WriteLine("closed...");
            Console.ReadLine();
        }

        public static void PrintData(WeatherStation[] stations)
        {
            Console.WriteLine("Stations");
            Console.WriteLine("--------");

            Console.WriteLine("{0, -10} {1, -10} {2, -10}", "mean", "max", "min");
            for (int i = 0; i < stations.Length; i++)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", stations[i].mean + "°C", stations[i].max + "°C", stations[i].min + "°C");
            }

            for (int i = 0; i < stations.Length; i++)
            {
                for (int j = 0; j < MAX_MEASUREMENTS; j++)
                {

                }
            }
        }

        public static void Sort(WeatherStation[] weathers)
        {
            for (int i = 0; i < weathers.Length - 1; i++)
            {
                for (int j = 0; j < weathers.Length - i - 1; j++)
                {
                    if (weathers[j].mean < weathers[j + 1].mean)
                    {
                        WeatherStation temp = weathers[j];
                        weathers[j] = weathers[j + 1];
                        weathers[j + 1] = temp;
                    }
                }
            }
        }

        public static WeatherStation GenerateValues(WeatherStation station)
        {
            Random random = new Random();
            int[] measurements = new int[MAX_MEASUREMENTS];

            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = random.Next(MIN_VALUE, MAX_VALUE + 1);
            }
            station.measurements = measurements;
            station.max = Max(station.measurements);
            station.min = Min(station.measurements);
            station.mean = Mean(station.measurements);
            return station;
        }

        public static double Mean(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return Math.Round((double)sum / arr.Length, 2);
        }

        public static int Min(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int Max(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
