using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_vektor_addieren
    {
        public static void Run()
        {
            int[] vec1 = new int[3];
            int[] vec2 = new int[3];
            int[] result = new int[3];
            double magnitude = 0;
            
            string input = "";
            string output = "";

            Console.Write("vector 1: ");
            input = Console.ReadLine();

            string[] parts = input.Split(";");
            for (int i = 0; i < parts.Length; i++)
            {
                int value = Convert.ToInt32(parts[i]);
                vec1[i] = value;
            }
            
            Console.Write("vector 2: ");
            input = Console.ReadLine();

            parts = input.Split(";");
            for (int i = 0; i < parts.Length; i++)
            {
                int value = Convert.ToInt32(parts[i]);
                vec2[i] = value;
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = vec1[i] + vec2[i];
                output += result[i] + " ";
            }
            magnitude = Math.Sqrt(result[0] * result[0] + result[1] * result[1] + result[2] * result[2]);

            Console.WriteLine("\nresult vector: {0}", output);
            Console.WriteLine("magnitude: {0}", Math.Round(magnitude, 2));
            Console.ReadLine();
        }
    }
}
